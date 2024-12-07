using BeautyLab.Infrastructure;
using Guna.UI2.WinForms;

namespace BeautyLab.Tabs
{
    /// <summary>
    /// Класс для изменения пароля, удаления аккаунта, выхода из него
    /// </summary>
    public partial class ProfileControl : UserControl
    {
        /// <summary>
        /// Стандартный конструктор админской страницы профиля
        /// </summary>
        public ProfileControl(ref MainForm mainForm, string email)
        {
            InitializeComponent();
            msg = new Guna2MessageDialog();
            msg.Style = MessageDialogStyle.Light;
            msg.Parent = mainForm;
            _overlay = new Form();
            _localEmail = email;
            _mainForm = mainForm;
        }
        private MainForm _mainForm;
        private Guna2MessageDialog msg;
        private readonly string _localEmail;
        private readonly string avatarPath = "avatar.jpg";
        private void picUser_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";
                openFileDialog.Title = "Выберите изображение";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var selectedImage = Image.FromFile(openFileDialog.FileName);
                        pictureBoxAvatar.Image = selectedImage;

                        selectedImage.Save(avatarPath);
                    }
                    catch (Exception ex)
                    {
                        msg.Show($"Ошибка при загрузке изображения: {ex.Message}");
                    }
                }
            }
        }

        private void admProfile_Load(object sender, EventArgs e)
        {
            if (File.Exists(avatarPath))
            {
                pictureBoxAvatar.Image = Image.FromFile(avatarPath);
            }
            txtLogin.Enabled = false;
            txtLogin.Text = _localEmail;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var server = new Users();
            string Login = txtLogin.Text;
            string Password = Users.HashPassword(txtPassword.Text);


            SendVerificationEmail();
            if (VerifyAccount())
            {
                server.ChangePassword(_localEmail, txtPassword.Text);
                msg.Icon = MessageDialogIcon.Information;
                msg.Show("Данные изменены", "Успех");
            }
            else
            {
                msg.Icon = MessageDialogIcon.Error;
                msg.Show("Вы отменили изменения", "Ошибка");
            }
        }
        private int _securityCode;
        private void SendVerificationEmail()
        {
            Guna2MessageDialog msg = new Guna2MessageDialog();
            msg.Style = MessageDialogStyle.Light;
            msg.Parent = FindForm();

            string subject = "Вход";
            Email emailSender = new Email(msg);
            _securityCode = emailSender.GenerateSecurityCode();
            string message = Email.GetEmailBody("пользователь", _securityCode);
            emailSender.Send(_localEmail, subject, message);
        }

        // Окно для ввода кода верификации
        private bool VerifyAccount()
        {
            var msg = new Guna2MessageDialog
            {
                Parent = _mainForm,
                Style = MessageDialogStyle.Light
            };

            VerificationForm verification = new VerificationForm(_securityCode);
            CustomizeForm(ref verification);

            ShowOverlay(); // Показываем оверлей

            // Показываем VerificationForm как модальную форму
            verification.ShowDialog(_mainForm);

            HideOverlay(); // Скрываем оверлей

            return verification.GetResult(); // Получаем результат работы формы
        }


        private void ShowOverlay()
        {
            _overlay.FormBorderStyle = FormBorderStyle.None;
            _overlay.StartPosition = FormStartPosition.Manual;
            _overlay.Opacity = 0.5;
            _overlay.BackColor = Color.Black;
            _overlay.ShowInTaskbar = false;
            _overlay.Size = _mainForm.Size;
            _overlay.Location = _mainForm.Location;
            _overlay.Owner = _mainForm;

            // Используем Show(), чтобы не блокировать выполнение
            _overlay.Show();
        }

        private void HideOverlay() => _overlay.Hide();

        // Настройка окна
        private void CustomizeForm(ref VerificationForm form)
        {
            form.FormBorderStyle = FormBorderStyle.None;
            form.StartPosition = FormStartPosition.Manual;
            form.ShowInTaskbar = false;
            form.Owner = _mainForm;

            // Задаём позицию по центру _mainForm
            form.Location = CenterFormPosition(form);
        }

        private Point CenterFormPosition(Form form)
        {
            int centerX = _mainForm.Left + (_mainForm.Width - form.Width) / 2;
            int centerY = _mainForm.Top + (_mainForm.Height - form.Height) / 2;
            return new Point(centerX, centerY);
        }
















        private readonly Form _overlay;

    }
}
