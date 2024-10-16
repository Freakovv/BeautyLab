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
        public EntryForm()
        {
            InitializeComponent();

        }

        private DataBase dataBase = new DataBase();

        private void EntryForm_Load(object sender, EventArgs e)
        {
            FadeIn.Start();
        }

        private int _securityCode;
        private string _localEmail;
        private string _localHashPassword;

        private void btnEnter_Click(object sender, EventArgs e)
        {

        }

        private void SendMail(string userName, string subject, string userEmail)
        {
            Email emailSender = new Email(MessageDialog);

            _securityCode = emailSender.GetSecurityCode();
            string message = Email.GetEmailBody(userName, _securityCode);

            emailSender.Send(userEmail, subject, message);
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            string email = txtLogReg.Text;
            string password = txtPassReg1.Text;
            string subject = "Вход";

            if (!CheckRegTxtBoxes())
            {
                return;
            }

            _localEmail = email;
            _localHashPassword = HashPassword(password);

            SendMail("пользователь", subject, email);
            VerificationForm code = new VerificationForm(_securityCode);
            code.FormBorderStyle = FormBorderStyle.None;
            code.StartPosition = FormStartPosition.Manual;
            code.ShowInTaskbar = false;
            code.Owner = this;

            // Расчет центра диалогового окна
            int centerX = this.Left + (this.Width - code.Width) / 2;
            int centerY = this.Top + (this.Height - code.Height) / 2;

            code.Location = new Point(centerX, centerY);

            ShowOverlay();

            code.ShowDialog();
            bool result = code.getResult();
            HideOverlay();

            MessageBox.Show(Convert.ToString(result));

            //TODO: Сделать класс базы данных и переход 
        }

        private bool CheckRegTxtBoxes()
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