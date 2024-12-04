using Guna.UI2.WinForms;
using System.Diagnostics;

namespace BeautyLab.Tabs.General_Tabs
{
    public partial class ContactControl : UserControl
    {
        Guna2MessageDialog message;
        public ContactControl()
        {
            InitializeComponent();
        }

        private void ContactControl_Load(object sender, EventArgs e)
        {
            string filePath = "Resources/contacts.txt";

            if (File.Exists(filePath))
            {
                try
                {
                    string[] lines = File.ReadAllLines(filePath);

                    linkBrowser.Text = lines.Length > 0 ? lines[0] : "https://example.com";
                    linkDiscord.Text = lines.Length > 1 ? lines[1] : "https://discord.gg/example";
                    linkEmail.Text = lines.Length > 2 ? lines[2] : "mailto:someone@example.com";
                    linkPhoneNumber.Text = lines.Length > 3 ? lines[3] : "+1234567890";
                    linkTelegram.Text = lines.Length > 4 ? lines[4] : "https://t.me/username";
                }
                catch (Exception ex)
                {
                    // Обработка ошибок
                    MessageBox.Show($"Ошибка при чтении файла: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Файл contacts.txt не найден.");
            }
        }

        private void linkBrowser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = linkBrowser.Text;
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }
        private void linkDiscord_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = linkDiscord.Text;
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }
        private void linkEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string email = "mailto:" + linkEmail.Text;
            Process.Start(new ProcessStartInfo(email) { UseShellExecute = true });
        }

        private void linkPhoneNumber_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string phoneNumber = linkPhoneNumber.Text;
            Clipboard.SetText(phoneNumber);
            message = new Guna2MessageDialog();
            message.Style = MessageDialogStyle.Light;
            message.Parent = FindForm();
            message.Show("Номер телефона скопирован в буфер обмена!", "Контакты");
        }

        private void linkTelegram_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string telegramLink = "https://t.me/" + linkTelegram.Text.Substring(1);
            Process.Start(new ProcessStartInfo(telegramLink) { UseShellExecute = true });
        }

    }
}
