
namespace BeautyLab.Infrastructure
{

    using OfficeOpenXml;
    using System;
    using System.IO;
    using System.Windows.Forms;

    public class ExcelManager
    {
        private readonly string baseDirectory;

        public ExcelManager()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial; // Устанавливаем контекст лицензии
            baseDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "BusinessReports");
            Directory.CreateDirectory(baseDirectory);
        }

        internal string GetCurrentExcelFilePath()
        {
            string fileName = $"BusinessDay_{DateTime.Now:yyyy-MM-dd}.xlsx";
            return Path.Combine(baseDirectory, fileName);
        }

        // Экспорт строки в Excel
        public void ExportRowToExcel(string fullName, string phone, string date, string time, string master, string service, string price)
        {
            string filePath = GetCurrentExcelFilePath();
            FileInfo fileInfo = new FileInfo(filePath);

            using (var package = new ExcelPackage(fileInfo))
            {
                var worksheet = package.Workbook.Worksheets.Count > 0
                    ? package.Workbook.Worksheets[0]
                    : package.Workbook.Worksheets.Add("BusinessDay");

                if (worksheet.Dimension == null) // Если таблица пуста, создаем заголовки
                {
                    worksheet.Cells[1, 1].Value = "ФИО";
                    worksheet.Cells[1, 2].Value = "Номер телефона";
                    worksheet.Cells[1, 3].Value = "Дата";
                    worksheet.Cells[1, 4].Value = "Время";
                    worksheet.Cells[1, 5].Value = "Мастер";
                    worksheet.Cells[1, 6].Value = "Услуга";
                    worksheet.Cells[1, 7].Value = "Стоимость";
                }

                int lastRow = worksheet.Dimension?.Rows + 1 ?? 2;
                worksheet.Cells[lastRow, 1].Value = fullName;
                worksheet.Cells[lastRow, 2].Value = phone;
                worksheet.Cells[lastRow, 3].Value = date;
                worksheet.Cells[lastRow, 4].Value = time;
                worksheet.Cells[lastRow, 5].Value = master;
                worksheet.Cells[lastRow, 6].Value = service;
                worksheet.Cells[lastRow, 7].Value = price;

                package.Save();
            }
        }

        // Импорт данных из Excel в DataGridView
        public void ImportFromExcel(DataGridView dataGridView)
        {
            string filePath = GetCurrentExcelFilePath();
            FileInfo fileInfo = new FileInfo(filePath);
            if (!fileInfo.Exists)
                return;

            using (var package = new ExcelPackage(fileInfo))
            {
                var worksheet = package.Workbook.Worksheets[0];
                dataGridView.Rows.Clear();

                for (int row = 2; row <= worksheet.Dimension.Rows; row++)
                {
                    string fullName = worksheet.Cells[row, 1]?.Text ?? "";
                    string phone = worksheet.Cells[row, 2]?.Text ?? "";
                    string date = worksheet.Cells[row, 3]?.Text ?? "";
                    string time = worksheet.Cells[row, 4]?.Text ?? "";
                    string master = worksheet.Cells[row, 5]?.Text ?? "";
                    string service = worksheet.Cells[row, 6]?.Text ?? "";
                    string price = worksheet.Cells[row, 7]?.Text ?? "";

                    dataGridView.Rows.Add(fullName, phone, date, time, master, service, price);
                }
            }
        }

        // Завершение бизнес-дня
        public void EndBusinessDay(DataGridView Table)
        {
            string filePath = GetCurrentExcelFilePath();
            FileInfo fileInfo = new FileInfo(filePath);

            if (!fileInfo.Exists)
            {
                throw new ArgumentException("Данные за текущий бизнес-день отсутствуют!");
            }

            decimal totalCost = 0;
            var masterCount = new Dictionary<string, int>(); // Для подсчета позиций по мастерам
            var serviceCount = new Dictionary<string, int>(); // Для подсчета популярности услуг
            int totalRecords = 0; // Общее количество позиций

            using (var package = new ExcelPackage(fileInfo))
            {
                var worksheet = package.Workbook.Worksheets[0]; // Основной лист с данными
                for (int row = 2; row <= worksheet.Dimension.Rows; row++)
                {
                    string price = worksheet.Cells[row, 7]?.Text ?? "0";
                    if (decimal.TryParse(price, out decimal cost))
                    {
                        totalCost += cost;
                    }

                    // Подсчёт количества позиций по мастерам
                    string master = worksheet.Cells[row, 5]?.Text ?? "Неизвестен";
                    if (!masterCount.ContainsKey(master))
                    {
                        masterCount[master] = 0;
                    }
                    masterCount[master]++;

                    // Подсчёт популярности услуг
                    string service = worksheet.Cells[row, 6]?.Text ?? "Неизвестная услуга";
                    if (!serviceCount.ContainsKey(service))
                    {
                        serviceCount[service] = 0;
                    }
                    serviceCount[service]++;

                    totalRecords++;
                }

                // Создание нового листа с отчетом
                var reportWorksheet = package.Workbook.Worksheets.Add("Report_" + DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss"));
                reportWorksheet.Cells[1, 1].Value = "Общая сумма за день:";
                reportWorksheet.Cells[1, 2].Value = $"{totalCost:C}";
                reportWorksheet.Cells[2, 1].Value = "Общее количество позиций:";
                reportWorksheet.Cells[2, 2].Value = totalRecords;

                int rowIndex = 4;
                reportWorksheet.Cells[rowIndex, 1].Value = "Количество позиций по мастерам:";
                rowIndex++;
                foreach (var master in masterCount)
                {
                    reportWorksheet.Cells[rowIndex, 1].Value = $"{master.Key}: {master.Value} позиций";
                    rowIndex++;
                }

                reportWorksheet.Cells[rowIndex, 1].Value = "Самая популярная услуга:";
                rowIndex++;
                var mostPopularService = serviceCount.OrderByDescending(s => s.Value).FirstOrDefault();
                reportWorksheet.Cells[rowIndex, 1].Value = $"{mostPopularService.Key} ({mostPopularService.Value} раз)";

                package.Save();
            }

            MessageBox.Show($"Бизнес-день завершен. Отчет сохранен в Excel файл: {filePath}");
        }
    }
}
