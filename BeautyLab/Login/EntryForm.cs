using BeautyLab.Animations;
using BeautyLab.Infrastructure;
using Guna.UI2.WinForms;
using System.Text.RegularExpressions;

namespace BeautyLab
{
    /// <summary>
    /// Форма входа
    /// Описана регистрация, вход пользователей
    /// </summary>
    public partial class EntryForm : Form
    {
        private readonly Users _usersTable;

        private string? _localEmail;
        private string? _localPassword;
        private int _securityCode;

        /// <summary>
        /// Конструктор формы входа по умолочанию 
        /// </summary>
        public EntryForm()
        {
            InitializeComponent();

            AnimateForm FadeIn = new AnimateForm(this);
            _usersTable = new();
            FadeIn.Start(true);
        }

        // Вход в аккаунт
        private void btnEnter_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string password = txtPassword.Text;

            if (_usersTable.GetAccess(login, password))
            {
                ShowWelcomeMessage(login);
                MainForm mainForm = new MainForm(login);
                this.Hide();
                mainForm.Show();
            }
            else
            {
                ShowErrorMsg("Неверный логин или пароль");
            }
        }

        // Регистрация аккаунта
        private void btnReg_Click(object sender, EventArgs e)
        {
            if (!ValidateRegistrationInputs())
                return;

            _localEmail = txtLogReg.Text;
            _localPassword = txtPassReg1.Text;

            if (_usersTable.AccountExists(_localEmail))
            {
                ShowErrorMsg("Аккаунт с таким email уже существует");
                return;
            }

            SendVerificationEmail();
            if (VerifyAccount())
            {
                try
                {
                    if (_usersTable.InsertEmailAndPassword(_localEmail, _localPassword))
                    {
                        ShowInfoMsg("Вы успешно зарегестрировались!");
                    }
                }
                catch (ArgumentException ex)
                {
                    ShowErrorMsg(ex.Message);
                }
            }
            else
            {
                ShowInfoMsg("Регистрация отменена");
            }
        }

        // Отправка письма
        private void SendVerificationEmail()
        {
            string subject = "Вход";
            Email emailSender = new Email(MessageDialog);
            _securityCode = emailSender.GenerateSecurityCode();
            string message = Email.GetEmailBody("пользователь", _securityCode);
            emailSender.Send(_localEmail, subject, message);
        }

        // Окно для ввода кода верификации
        private bool VerifyAccount()
        {
            VerificationForm verification = new VerificationForm(_securityCode);
            CustomizeForm(ref verification);
            ShowOverlay();
            verification.ShowDialog();
            HideOverlay();
            return verification.GetResult();
        }

        // Настройка окна
        private void CustomizeForm(ref VerificationForm form)
        {
            form.FormBorderStyle = FormBorderStyle.None;
            form.StartPosition = FormStartPosition.Manual;
            form.ShowInTaskbar = false;
            form.Owner = this;

            form.Location = CenterFormPosition(form);
        }

        // Центрирование окна
        private Point CenterFormPosition(Form form)
        {
            int centerX = Left + (Width - form.Width) / 2;
            int centerY = Top + (Height - form.Height) / 2;
            return new Point(centerX, centerY);
        }

        // Валидация для входа
        private bool ValidateInputs()
        {
            if (IsEmpty(txtLogin.Text) || IsEmpty(txtPassword.Text))
            {
                ShowErrorMsg("Поля не могут быть пустыми");
                return false;
            }

            return true;
        }

        // Валидация для регистрации
        private bool ValidateRegistrationInputs()
        {
            if (IsAnyFieldEmpty(txtLogReg.Text, txtPassReg1.Text, txtPassReg2.Text))
            {
                ShowErrorMsg("Поля не могут быть пустыми!");
                return false;
            }

            if (!ArePasswordsMatching(txtPassReg1.Text, txtPassReg2.Text))
            {
                ShowErrorMsg("Пароли не совпадают");
                return false;
            }

            if (txtPassReg1.Text.Length <= 5)
            {
                ShowErrorMsg("Слишком короткий пароль!");
                return false;
            }

            if (!IsValidEmail(txtLogReg.Text))
            {
                ShowErrorMsg("Некорректный формат адреса электронной почты!");
                return false;
            }

            if (!checkBoxTerms.Checked)
            {
                ShowErrorMsg("Вы должны принять условия использования для регистрации");
                return false;
            }

            return true;
        }

        // Функции для проверки
        private bool IsEmpty(string input) => string.IsNullOrEmpty(input);

        private bool IsAnyFieldEmpty(params string[] inputs) => inputs.Any(IsEmpty);

        private bool ArePasswordsMatching(string pass1, string pass2) => pass1 == pass2;
        // Валидация строки почты
        private bool IsValidEmail(string email) => Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");

        // Приветственное уведомление
        private void ShowWelcomeMessage(string login)
        {
            string msg = "Добро пожаловать";
            if (!IsValidEmail(login)) msg += ", " + login + "!";

            MessageDialog.Icon = MessageDialogIcon.Information;
            MessageDialog.Show(msg, "Вход");
        }
    }
}
