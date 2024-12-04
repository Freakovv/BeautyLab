using BeautyLab.Infrastructure;
using Guna.UI2.WinForms;
using OfficeOpenXml;

namespace BeautyLab.Tabs.Master_Tabs
{
    public partial class RecordAcceptControl : UserControl
    {
        ExcelManager excelManager;
        Guna2MessageDialog messageDialog;
        public RecordAcceptControl(MainForm form)
        {
            InitializeComponent();
            excelManager = new ExcelManager();
            messageDialog = new Guna2MessageDialog();
            messageDialog.Parent = form;
            messageDialog.Style = MessageDialogStyle.Light;
        }
        // Добавление кнопки в DataGridView
        private void AddDeleteButtonColumn()
        {
            DataGridViewButtonColumn btnDeleteColumn = new DataGridViewButtonColumn();
            btnDeleteColumn.Name = "btnReject";
            btnDeleteColumn.Text = "Удалить";
            btnDeleteColumn.UseColumnTextForButtonValue = true;
            btnDeleteColumn.HeaderText = "Удалить";
            btnDeleteColumn.Width = 100;

            // Добавляем колонку в таблицу
            Table.Columns.Add(btnDeleteColumn);

            // Обрабатываем событие клика по кнопке
            Table.CellContentClick += Table_CellContentClick;
        }

        private void Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Проверяем, что была нажата кнопка "Удалить"
            if (e.ColumnIndex == Table.Columns["btnReject"].Index)
            {
                int rowIndex = e.RowIndex;
                if (rowIndex >= 0)
                {
                    messageDialog.Buttons = MessageDialogButtons.YesNo;
                    var result = messageDialog.Show(
                        "Вы уверены, что хотите удалить эту запись?",
                        "Подтверждение удаления");

                    if (result == DialogResult.Yes)
                    {
                        // Удаляем строку
                        Table.Rows.RemoveAt(rowIndex);
                        DeleteRowFromExcel(rowIndex);
                    }
                }
            }
        }

        private void DeleteRowFromExcel(int rowIndex)
        {
            string filePath = excelManager.GetCurrentExcelFilePath();
            FileInfo fileInfo = new FileInfo(filePath);

            if (!fileInfo.Exists)
            {
                return;
            }

            using (var package = new ExcelPackage(fileInfo))
            {
                var worksheet = package.Workbook.Worksheets[0];

                // Удаляем строку из Excel
                worksheet.DeleteRow(rowIndex + 2);

                // Сохраняем изменения
                package.Save();
            }
        }

        private void RecordAcceptControl_Load(object sender, EventArgs e)
        {
            excelManager.ImportFromExcel(Table);
            AddDeleteButtonColumn();
        }
    }
}
