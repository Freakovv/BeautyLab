using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Drawing;
using Guna.UI2.WinForms;

namespace BeautyLab
{
    public partial class EntryForm : Form
    {
        private readonly DataBase _dataBase;
        private int _securityCode;
        private string _localEmail = string.Empty;
        private string? _localPassword;

        public EntryForm(){
            _dataBase = new DataBase(this);
            InitializeComponent();
        }

        private void EntryForm_Load(object sender, EventArgs e)
        {
            FadeIn.Start();
        }

        // Вход в аккаунт
        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (!ValidateLoginInputs())
                return;

            string login = txtLogin.Text;
            string password = txtPassword.Text;

            if (_dataBase.GetAccess(login, password))
            {
                ShowWelcomeMessage(login);
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

            if (_dataBase.AccountExists(_localEmail))
            {
                ShowErrorMsg("Аккаунт с таким email уже существует");
                return;
            }

            SendVerificationEmail();
            if (VerifyAccount())
            {
                _dataBase.InsertEmailAndPassword(_localEmail, _localPassword);
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
            return verification.getResult();
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

        // Центрирование формы
        private Point CenterFormPosition(Form form)
        {
            int centerX = Left + (Width - form.Width) / 2;
            int centerY = Top + (Height - form.Height) / 2;
            return new Point(centerX, centerY);
        }

        // Валидация данных для входа
        private bool ValidateLoginInputs()
        {
            if (IsEmpty(txtLogin.Text) || IsEmpty(txtPassword.Text))
            {
                ShowErrorMsg("Поля не могут быть пустыми");
                return false;
            }

            if (txtPassword.Text.Length < 6)
            {
                ShowErrorMsg("Неверный пароль");
                return false;
            }

            return true;
        }

        // Валидация данных для регистрации
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

        private bool IsEmpty(string input) => string.IsNullOrEmpty(input);

        private bool IsAnyFieldEmpty(params string[] inputs) => inputs.Any(IsEmpty);

        private bool ArePasswordsMatching(string pass1, string pass2) => pass1 == pass2;

        private bool IsValidEmail(string email)
        {
            const string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private void ShowWelcomeMessage(string login)
        {
            string msg = "Добро пожаловать";
            if (!IsValidEmail(login)) msg += ", " + login + "!";
            
            MessageDialog.Icon = MessageDialogIcon.Information;
            MessageDialog.Show(msg, "Вход");
        }

    }
}
