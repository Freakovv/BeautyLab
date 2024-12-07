using Guna.UI2.WinForms;

namespace BeautyLab.Tabs.Master_Tabs
{
    public partial class AcceptRecords : UserControl
    {
        Guna2MessageDialog messageDialog;
        public AcceptRecords(MainForm form)
        {
            InitializeComponent();
            messageDialog = new Guna2MessageDialog();
            messageDialog.Parent = form;
            messageDialog.Style = MessageDialogStyle.Light;
        }

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
                        Table.Rows.RemoveAt(rowIndex);
                        // TODO: Тут удалить из БД
                    }
                }
            }
        }


        private void RecordAcceptControl_Load(object sender, EventArgs e)
        {
            // TODO: Тут загрузить из БД таблицу
            AddDeleteButtonColumn();
        }
    }
}
