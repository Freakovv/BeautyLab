namespace BeautyLab.Tabs.General_Tabs
{
    partial class ContactControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactControl));
            pictureBrowser = new PictureBox();
            picturePhone = new PictureBox();
            pictureEmail = new PictureBox();
            pictureDiscord = new PictureBox();
            pictureTelegram = new PictureBox();
            linkBrowser = new LinkLabel();
            linkDiscord = new LinkLabel();
            linkEmail = new LinkLabel();
            linkPhoneNumber = new LinkLabel();
            linkTelegram = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBrowser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picturePhone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureDiscord).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureTelegram).BeginInit();
            SuspendLayout();
            // 
            // pictureBrowser
            // 
            pictureBrowser.BackColor = Color.Transparent;
            pictureBrowser.Image = (Image)resources.GetObject("pictureBrowser.Image");
            pictureBrowser.Location = new Point(153, 70);
            pictureBrowser.Name = "pictureBrowser";
            pictureBrowser.Size = new Size(65, 65);
            pictureBrowser.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBrowser.TabIndex = 0;
            pictureBrowser.TabStop = false;
            // 
            // picturePhone
            // 
            picturePhone.BackColor = Color.Transparent;
            picturePhone.Image = (Image)resources.GetObject("picturePhone.Image");
            picturePhone.Location = new Point(153, 423);
            picturePhone.Name = "picturePhone";
            picturePhone.Size = new Size(65, 65);
            picturePhone.SizeMode = PictureBoxSizeMode.Zoom;
            picturePhone.TabIndex = 1;
            picturePhone.TabStop = false;
            // 
            // pictureEmail
            // 
            pictureEmail.BackColor = Color.Transparent;
            pictureEmail.Image = (Image)resources.GetObject("pictureEmail.Image");
            pictureEmail.Location = new Point(153, 307);
            pictureEmail.Name = "pictureEmail";
            pictureEmail.Size = new Size(65, 65);
            pictureEmail.SizeMode = PictureBoxSizeMode.Zoom;
            pictureEmail.TabIndex = 2;
            pictureEmail.TabStop = false;
            // 
            // pictureDiscord
            // 
            pictureDiscord.BackColor = Color.Transparent;
            pictureDiscord.Image = (Image)resources.GetObject("pictureDiscord.Image");
            pictureDiscord.Location = new Point(153, 188);
            pictureDiscord.Name = "pictureDiscord";
            pictureDiscord.Size = new Size(65, 65);
            pictureDiscord.SizeMode = PictureBoxSizeMode.Zoom;
            pictureDiscord.TabIndex = 3;
            pictureDiscord.TabStop = false;
            // 
            // pictureTelegram
            // 
            pictureTelegram.BackColor = Color.Transparent;
            pictureTelegram.Image = (Image)resources.GetObject("pictureTelegram.Image");
            pictureTelegram.Location = new Point(153, 541);
            pictureTelegram.Name = "pictureTelegram";
            pictureTelegram.Size = new Size(65, 65);
            pictureTelegram.SizeMode = PictureBoxSizeMode.Zoom;
            pictureTelegram.TabIndex = 4;
            pictureTelegram.TabStop = false;
            // 
            // linkBrowser
            // 
            linkBrowser.ActiveLinkColor = Color.FromArgb(255, 214, 236);
            linkBrowser.AutoSize = true;
            linkBrowser.Font = new Font("Jura", 26.25F);
            linkBrowser.LinkColor = Color.FromArgb(227, 89, 164);
            linkBrowser.Location = new Point(232, 77);
            linkBrowser.Name = "linkBrowser";
            linkBrowser.Size = new Size(824, 47);
            linkBrowser.TabIndex = 6;
            linkBrowser.TabStop = true;
            linkBrowser.Text = "https://www.slivki.by/salony-krasoty/bbeautylab";
            linkBrowser.LinkClicked += linkBrowser_LinkClicked;
            // 
            // linkDiscord
            // 
            linkDiscord.ActiveLinkColor = Color.FromArgb(255, 214, 236);
            linkDiscord.AutoSize = true;
            linkDiscord.Font = new Font("Jura", 26.25F);
            linkDiscord.LinkColor = Color.FromArgb(227, 89, 164);
            linkDiscord.Location = new Point(232, 197);
            linkDiscord.Name = "linkDiscord";
            linkDiscord.Size = new Size(473, 47);
            linkDiscord.TabIndex = 7;
            linkDiscord.TabStop = true;
            linkDiscord.Text = "https://discord.gg/4LkfrMSn";
            linkDiscord.LinkClicked += linkDiscord_LinkClicked;
            // 
            // linkEmail
            // 
            linkEmail.ActiveLinkColor = Color.FromArgb(255, 214, 236);
            linkEmail.AutoSize = true;
            linkEmail.Font = new Font("Jura", 26.25F);
            linkEmail.LinkColor = Color.FromArgb(227, 89, 164);
            linkEmail.Location = new Point(232, 310);
            linkEmail.Name = "linkEmail";
            linkEmail.Size = new Size(511, 47);
            linkEmail.TabIndex = 8;
            linkEmail.TabStop = true;
            linkEmail.Text = "beautylab.service@gmail.com";
            linkEmail.LinkClicked += linkEmail_LinkClicked;
            // 
            // linkPhoneNumber
            // 
            linkPhoneNumber.ActiveLinkColor = Color.FromArgb(255, 214, 236);
            linkPhoneNumber.AutoSize = true;
            linkPhoneNumber.Font = new Font("Jura", 26.25F);
            linkPhoneNumber.LinkColor = Color.FromArgb(227, 89, 164);
            linkPhoneNumber.Location = new Point(232, 425);
            linkPhoneNumber.Name = "linkPhoneNumber";
            linkPhoneNumber.Size = new Size(350, 47);
            linkPhoneNumber.TabIndex = 9;
            linkPhoneNumber.TabStop = true;
            linkPhoneNumber.Text = "+375 (33) 344-62-12 ";
            linkPhoneNumber.LinkClicked += linkPhoneNumber_LinkClicked;
            // 
            // linkTelegram
            // 
            linkTelegram.ActiveLinkColor = Color.FromArgb(255, 214, 236);
            linkTelegram.AutoSize = true;
            linkTelegram.Font = new Font("Jura", 26.25F);
            linkTelegram.LinkColor = Color.FromArgb(227, 89, 164);
            linkTelegram.Location = new Point(232, 543);
            linkTelegram.Name = "linkTelegram";
            linkTelegram.Size = new Size(172, 47);
            linkTelegram.TabIndex = 10;
            linkTelegram.TabStop = true;
            linkTelegram.Text = "@anexsis";
            linkTelegram.LinkClicked += linkTelegram_LinkClicked;
            // 
            // ContactControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(linkTelegram);
            Controls.Add(linkPhoneNumber);
            Controls.Add(linkEmail);
            Controls.Add(linkDiscord);
            Controls.Add(linkBrowser);
            Controls.Add(pictureTelegram);
            Controls.Add(pictureDiscord);
            Controls.Add(pictureEmail);
            Controls.Add(picturePhone);
            Controls.Add(pictureBrowser);
            Name = "ContactControl";
            Size = new Size(1102, 689);
            Load += ContactControl_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBrowser).EndInit();
            ((System.ComponentModel.ISupportInitialize)picturePhone).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureDiscord).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureTelegram).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBrowser;
        private PictureBox picturePhone;
        private PictureBox pictureEmail;
        private PictureBox pictureDiscord;
        private PictureBox pictureTelegram;
        private LinkLabel linkBrowser;
        private LinkLabel linkDiscord;
        private LinkLabel linkEmail;
        private LinkLabel linkPhoneNumber;
        private LinkLabel linkTelegram;
    }
}
