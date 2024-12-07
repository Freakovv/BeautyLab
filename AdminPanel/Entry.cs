using Microsoft.IdentityModel.Tokens;

namespace AdminPanel
{
    public partial class Entry : Form
    {
        public Entry()
        {
            InitializeComponent();
        }

        private readonly string key = "147852";

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtKey.Text.IsNullOrEmpty())
            {
                ShowError("Введите ключ");
                return;
            }

            if (txtKey.Text != key)
            {
                ShowError("Неверный ключ");
                return;
            }

            ShowAdminPanel();
        }

        private void ShowAdminPanel()
        {
            AdminPanel _adminPanel = new AdminPanel();
            _adminPanel.Show();
            this.Hide();
        }

        private void ShowError(string message, string caption = "Ошибка")
        {
            msg.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            msg.Show(message, caption);
        }

        private void Entry_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
