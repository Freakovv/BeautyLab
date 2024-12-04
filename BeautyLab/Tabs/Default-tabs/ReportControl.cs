using BeautyLab.Infrastructure;

namespace BeautyLab.Tabs.Default_tabs
{
    public partial class ReportControl : UserControl
    {
        public ReportControl()
        {
            InitializeComponent();
        }

        private void ReportControl_Load(object sender, EventArgs e)
        {
            var reportLoader = new ExcelReportLoader();

            // Передаем объект Guna2TextBox в метод
            reportLoader.LoadLastReportToTextBox(txtReport);

            // Проверяем, если текст пустой, скрываем текстовое поле
            if (string.IsNullOrEmpty(txtReport.Text))
            {
                txtReport.Visible = false;
            }
            else
            {
                txtReport.Visible = true;
            }
        }
    }
}
