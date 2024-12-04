using Guna.UI2.WinForms;
using OfficeOpenXml;
using System.Text;

namespace BeautyLab.Infrastructure
{
    public class ExcelReportLoader
    {
        private readonly string baseDirectory;

        public ExcelReportLoader()
        {
            baseDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "BusinessReports");
            Directory.CreateDirectory(baseDirectory); // Убедимся, что папка существует
        }

        public void LoadLastReportToTextBox(Control control)
        {
            // Проверяем, является ли переданный объект текстовым полем
            if (control is Guna2TextBox textBox)
            {
                // Получаем все файлы Excel в папке отчетов с расширением .xlsx
                var files = new DirectoryInfo(baseDirectory).GetFiles("Report_*.xlsx") // Ищем файлы с именем, начинающимся с 'Report_'
                    .OrderByDescending(f => f.LastWriteTime) // Сортируем по дате изменения
                    .ToList();

                if (files.Count == 0)
                {
                    MessageBox.Show("Не найдено отчетов.");
                    return;
                }

                // Берем последний (самый новый) файл
                string filePath = files.First().FullName;

                try
                {
                    using (var package = new ExcelPackage(new FileInfo(filePath)))
                    {
                        var worksheet = package.Workbook.Worksheets[0]; // Читаем первый лист

                        StringBuilder reportContent = new StringBuilder();

                        // Прочитаем все строки в Excel и добавим в StringBuilder
                        for (int row = 1; row <= worksheet.Dimension.Rows; row++)
                        {
                            for (int col = 1; col <= worksheet.Dimension.Columns; col++)
                            {
                                var cellValue = worksheet.Cells[row, col].Text;
                                reportContent.Append(cellValue + "\t"); // Разделитель табуляцией
                            }
                            reportContent.AppendLine(); // Переход на новую строку после каждого ряда
                        }

                        // Заполняем TextBox содержимым последнего отчета
                        textBox.Text = reportContent.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при чтении файла отчета: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Переданный контроль не является TextBox.");
            }
        }
    }
}
