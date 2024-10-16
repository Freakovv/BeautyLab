using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.AnimatorNS;
using Guna.UI2.WinForms;
using Microsoft.IdentityModel.Tokens;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace BeautyLab
{
    public partial class EntryForm : Form
    {
        public EntryForm() => InitializeComponent();

        private readonly DataBase _dataBase = new DataBase();

        private void EntryForm_Load(object sender, EventArgs e)
        {
            FadeIn.Start();
        }

        private int _securityCode;
        private string _localEmail;
        private string _localHashPassword;

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if(!ValidLoginTxtBoxes())
                return;

            //TODO: Авторизация
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            string email = txtLogReg.Text;
            string password = txtPassReg1.Text;
            string subject = "Вход";

            if (!ValidRegTxtBoxes())
            {
                return;
            }

            if (_dataBase.AccountExists(email))
            {
                ShowErrorMessage("Аккаунт с таким email уже существует");
                return;
            }

            _localEmail = email;
            _localHashPassword = HashPassword(password);

            Email emailSender = new Email(MessageDialog);
            _securityCode = emailSender.GetSecurityCode();
            string message = Email.GetEmailBody("пользователь", _securityCode);
            emailSender.Send(email, subject, message);

            VerificationForm verification = new VerificationForm(_securityCode);
            CustomizeForm(ref verification);

            ShowOverlay();
            verification.ShowDialog();
            HideOverlay();

            bool result = verification.getResult();

            if (result)
            {
                _dataBase.OpenConnection();
                _dataBase.InsertEmailAndPassword(_localEmail, _localHashPassword);
                _dataBase.CloseConnection();
            }
            else
            {
                MessageDialog.Icon = MessageDialogIcon.Information;
                MessageDialog.Show("Регистрация отменена", "Информация");
            }
        }

        private void CustomizeForm(ref VerificationForm Form)
        {
            Form.FormBorderStyle = FormBorderStyle.None;
            Form.StartPosition = FormStartPosition.Manual;
            Form.ShowInTaskbar = false;
            Form.Owner = this;

            int centerX = Left + (Width - Form.Width) / 2;
            int centerY = Top + (Height - Form.Height) / 2;

            Form.Location = new Point(centerX, centerY);
        }

        private bool ValidLoginTxtBoxes()
        {
            if (txtLogin.Text.IsNullOrEmpty() || txtPassword.Text.IsNullOrEmpty())
            {
                ShowErrorMessage("Поля не могут быть пустыми!");
                return false;
            }

            return true;
        }
        private bool ValidRegTxtBoxes()
        {
            if (string.IsNullOrWhiteSpace(txtLogReg.Text) ||
                string.IsNullOrWhiteSpace(txtPassReg1.Text) ||
                string.IsNullOrWhiteSpace(txtPassReg2.Text))
            {
                ShowErrorMessage("Поля не могут быть пустыми!");
                return false;
            }

            if (txtPassReg1.Text != txtPassReg2.Text)
            {
                ShowErrorMessage("Пароли не совпадают");
                return false;
            }

            if (txtPassReg1.Text.Length <= 5)
            {
                ShowErrorMessage("Слишком короткий пароль!");
                return false;
            }

            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(txtLogReg.Text, pattern))
            {
                ShowErrorMessage("Некорректный формат адреса электронной почты!");
                return false;
            }
            return true;
        }

        public static string HashPassword(string password)
        {
            using SHA256 sha256 = SHA256.Create();
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            StringBuilder builder = new StringBuilder();
            foreach (byte b in bytes)
            {
                builder.Append(b.ToString("x2"));
            }

            return builder.ToString();
        }

    }
}