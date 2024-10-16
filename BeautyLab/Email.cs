using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Security;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;
using Guna.UI2.WinForms;

namespace BeautyLab
{
    internal class Email(Guna2MessageDialog message)
    {
        private const string SmtpServer = "smtp.gmail.com";
        private const int SmtpPort = 587;

        private const string SmtpUsername = "beautylab.service@gmail.com"; 
        private const string SmtpPassword = "xyrp gwja pdyd mdpe";


        public int GetSecurityCode()
        {
            Random random = new Random();
            return random.Next(111111, 999999);
        }

        public void Send(string toEmail, string subject, string body)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtpClient = new SmtpClient(SmtpServer, SmtpPort);

                mail.From = new MailAddress(SmtpUsername);
                mail.To.Add(toEmail);
                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = true;

                smtpClient.Credentials = new NetworkCredential(SmtpUsername, SmtpPassword);
                smtpClient.EnableSsl = true; 

                smtpClient.Send(mail);

                message.Icon = MessageDialogIcon.Information;
                message.Caption = "Информация";
                message.Text = "Письмо было успешно отправлено. Проверьте почту";
                message.Show();
            }
            catch (Exception ex)
            {
                message.Icon = MessageDialogIcon.Error;
                message.Caption = "Ошибка";
                message.Text = ex.Message;
                message.Show();
            }
        }

        public static string GetEmailBody(string userName, int securityCode)
        {
            return $@"
    <!DOCTYPE html><html lang='en'><head><meta charset='UTF-8'><meta name='viewport' content='width=device-width, initial-scale=1.0'><title>Security Code</title>
    <style>
        body {{font-family: 'Arial', sans-serif;background-color: #f4f4f4;margin: 0;padding: 0;color: #333;}}
        .email-container {{max-width: 600px;margin: 40px auto;background-color: #ffffff;border-radius: 8px;box-shadow: 0 2px 8px rgba(0, 0, 0, 0.1);overflow: hidden;}}
        .email-header {{background-color: #4CAF50;color: #ffffff;padding: 20px;text-align: center;}}
        .email-header h1 {{margin: 0;font-size: 24px;}}
        .email-body {{padding: 20px;line-height: 1.6;}}
        .email-body p {{margin: 0 0 10px;}}
        .email-footer {{background-color: #f0f0f0;padding: 15px;text-align: center;font-size: 12px;color: #777;}}
        .email-footer p {{margin: 0;}}
    </style>
    </head>
    <body>
        <div class='email-container'>
            <div class='email-header'><h1>Security Code</h1></div>
            <div class='email-body'>
                <p>Уважаемый {userName},</p>
                <p>Для завершения запроса используйте следующий код безопасности:</p>
                <div style='text-align: center;'>
                    <div class='security-code' style='display: inline-block; font-size: 32px; font-weight: bold; color: #4CAF50; background-color: #f0f0f0; padding: 10px 20px; border-radius: 8px;'>
                        {securityCode}
                    </div>
                </div>
                <p>Если вы этого не запрашивали, проигнорируйте это письмо или свяжитесь с нашей службой поддержки.</p>
                <p>Благодарим вас за использование нашего сервиса!</p>
            </div>
            <div class='email-footer'><p>&copy; 2024 BeautyLab. All rights reserved.</p></div>
        </div>
    </body>
    </html>";
        }

    }
}
