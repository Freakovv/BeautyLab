namespace BeautyLab
{
    partial class HomeControl
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

        #region 

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeControl));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtContact = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtSettings = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnProfile = new Guna.UI2.WinForms.Guna2CircleButton();
            btnContact = new Guna.UI2.WinForms.Guna2CircleButton();
            txtProfile = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnSettings = new Guna.UI2.WinForms.Guna2CircleButton();
            circle = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            textWelcome = new Label();
            panelWindow = new Panel();
            ((System.ComponentModel.ISupportInitialize)circle).BeginInit();
            panelWindow.SuspendLayout();
            SuspendLayout();
            // 
            // txtContact
            // 
            txtContact.BackColor = Color.FromArgb(224, 224, 224);
            txtContact.Font = new Font("Jura SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtContact.ForeColor = Color.FromArgb(135, 128, 128);
            txtContact.Location = new Point(20, 529);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(78, 24);
            txtContact.TabIndex = 32;
            txtContact.Text = "Контакты";
            // 
            // txtSettings
            // 
            txtSettings.BackColor = Color.FromArgb(224, 224, 224);
            txtSettings.Font = new Font("Jura SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtSettings.ForeColor = Color.FromArgb(135, 128, 128);
            txtSettings.Location = new Point(17, 380);
            txtSettings.Name = "txtSettings";
            txtSettings.Size = new Size(90, 24);
            txtSettings.TabIndex = 31;
            txtSettings.Text = "Настройки";
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.Transparent;
            btnProfile.BackgroundImageLayout = ImageLayout.Stretch;
            btnProfile.BorderColor = Color.Transparent;
            btnProfile.BorderThickness = 2;
            btnProfile.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnProfile.CheckedState.BorderColor = Color.FromArgb(227, 89, 164);
            btnProfile.CheckedState.CustomBorderColor = Color.Transparent;
            btnProfile.CheckedState.FillColor = Color.Transparent;
            btnProfile.CheckedState.ForeColor = Color.Transparent;
            btnProfile.CheckedState.Image = (Image)resources.GetObject("resource.Image");
            btnProfile.CustomBorderColor = Color.Transparent;
            btnProfile.DisabledState.BorderColor = Color.DarkGray;
            btnProfile.DisabledState.CustomBorderColor = Color.DarkGray;
            btnProfile.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnProfile.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnProfile.FillColor = Color.Empty;
            btnProfile.Font = new Font("Segoe UI", 9F);
            btnProfile.ForeColor = Color.White;
            btnProfile.HoverState.BorderColor = Color.DarkGray;
            btnProfile.HoverState.CustomBorderColor = Color.Transparent;
            btnProfile.HoverState.FillColor = Color.Transparent;
            btnProfile.HoverState.ForeColor = Color.Transparent;
            btnProfile.Image = (Image)resources.GetObject("btnProfile.Image");
            btnProfile.ImageOffset = new Point(1, 0);
            btnProfile.ImageSize = new Size(90, 90);
            btnProfile.Location = new Point(3, 116);
            btnProfile.Name = "btnProfile";
            btnProfile.PressedColor = Color.FromArgb(227, 89, 164);
            btnProfile.PressedDepth = 1;
            btnProfile.ShadowDecoration.BorderRadius = 0;
            btnProfile.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnProfile.ShadowDecoration.Depth = 0;
            btnProfile.Size = new Size(110, 110);
            btnProfile.TabIndex = 27;
            btnProfile.UseTransparentBackground = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnContact
            // 
            btnContact.BackColor = Color.Transparent;
            btnContact.BackgroundImageLayout = ImageLayout.Stretch;
            btnContact.BorderColor = Color.Empty;
            btnContact.BorderThickness = 2;
            btnContact.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnContact.CheckedState.BorderColor = Color.FromArgb(227, 89, 164);
            btnContact.CheckedState.CustomBorderColor = Color.Transparent;
            btnContact.CheckedState.FillColor = Color.Transparent;
            btnContact.CheckedState.ForeColor = Color.Transparent;
            btnContact.CheckedState.Image = (Image)resources.GetObject("resource.Image1");
            btnContact.DisabledState.BorderColor = Color.DarkGray;
            btnContact.DisabledState.CustomBorderColor = Color.DarkGray;
            btnContact.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnContact.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnContact.FillColor = Color.Empty;
            btnContact.Font = new Font("Segoe UI", 9F);
            btnContact.ForeColor = Color.White;
            btnContact.HoverState.BorderColor = Color.DarkGray;
            btnContact.HoverState.CustomBorderColor = Color.Transparent;
            btnContact.HoverState.FillColor = Color.Transparent;
            btnContact.HoverState.ForeColor = Color.Transparent;
            btnContact.Image = (Image)resources.GetObject("btnContact.Image");
            btnContact.ImageOffset = new Point(1, 0);
            btnContact.ImageSize = new Size(90, 90);
            btnContact.Location = new Point(3, 416);
            btnContact.Name = "btnContact";
            btnContact.ShadowDecoration.BorderRadius = 0;
            btnContact.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnContact.ShadowDecoration.Depth = 0;
            btnContact.Size = new Size(110, 110);
            btnContact.TabIndex = 29;
            btnContact.UseTransparentBackground = true;
            btnContact.Click += btnContact_Click;
            // 
            // txtProfile
            // 
            txtProfile.BackColor = Color.FromArgb(224, 224, 224);
            txtProfile.Font = new Font("Jura SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtProfile.ForeColor = Color.FromArgb(135, 128, 128);
            txtProfile.Location = new Point(23, 228);
            txtProfile.Name = "txtProfile";
            txtProfile.Size = new Size(75, 24);
            txtProfile.TabIndex = 30;
            txtProfile.Text = "Профиль";
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.Transparent;
            btnSettings.BackgroundImageLayout = ImageLayout.Stretch;
            btnSettings.BorderColor = Color.Empty;
            btnSettings.BorderThickness = 2;
            btnSettings.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnSettings.CheckedState.BorderColor = Color.FromArgb(227, 89, 164);
            btnSettings.CheckedState.CustomBorderColor = Color.Transparent;
            btnSettings.CheckedState.FillColor = Color.Transparent;
            btnSettings.CheckedState.ForeColor = Color.Transparent;
            btnSettings.CheckedState.Image = (Image)resources.GetObject("resource.Image2");
            btnSettings.DisabledState.BorderColor = Color.DarkGray;
            btnSettings.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSettings.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSettings.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSettings.FillColor = Color.Empty;
            btnSettings.Font = new Font("Segoe UI", 9F);
            btnSettings.ForeColor = Color.White;
            btnSettings.HoverState.BorderColor = Color.DarkGray;
            btnSettings.HoverState.CustomBorderColor = Color.Transparent;
            btnSettings.HoverState.FillColor = Color.Transparent;
            btnSettings.HoverState.ForeColor = Color.Transparent;
            btnSettings.Image = (Image)resources.GetObject("btnSettings.Image");
            btnSettings.ImageOffset = new Point(1, 0);
            btnSettings.ImageSize = new Size(90, 90);
            btnSettings.Location = new Point(3, 267);
            btnSettings.Name = "btnSettings";
            btnSettings.ShadowDecoration.BorderRadius = 0;
            btnSettings.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btnSettings.ShadowDecoration.Depth = 0;
            btnSettings.Size = new Size(110, 110);
            btnSettings.TabIndex = 28;
            btnSettings.UseTransparentBackground = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // circle
            // 
            circle.BackColor = Color.Transparent;
            circle.FillColor = Color.FromArgb(224, 224, 224);
            circle.ImageRotate = 0F;
            circle.Location = new Point(-206, 12);
            circle.Name = "circle";
            circle.ShadowDecoration.BorderRadius = 550;
            circle.ShadowDecoration.Color = Color.IndianRed;
            circle.ShadowDecoration.CustomizableEdges = customizableEdges4;
            circle.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            circle.ShadowDecoration.Shadow = new Padding(20);
            circle.Size = new Size(381, 643);
            circle.TabIndex = 26;
            circle.TabStop = false;
            circle.UseTransparentBackground = true;
            // 
            // textWelcome
            // 
            textWelcome.AutoSize = true;
            textWelcome.BackColor = Color.Transparent;
            textWelcome.Font = new Font("Jura", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textWelcome.ForeColor = Color.FromArgb(227, 89, 164);
            textWelcome.Location = new Point(236, 267);
            textWelcome.Name = "textWelcome";
            textWelcome.Size = new Size(511, 64);
            textWelcome.TabIndex = 33;
            textWelcome.Text = "Добро пожаловать!";
            textWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelWindow
            // 
            panelWindow.BackColor = Color.Transparent;
            panelWindow.Controls.Add(textWelcome);
            panelWindow.Location = new Point(178, 0);
            panelWindow.Name = "panelWindow";
            panelWindow.Size = new Size(1102, 689);
            panelWindow.TabIndex = 34;
            // 
            // HomeControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(txtContact);
            Controls.Add(txtSettings);
            Controls.Add(btnProfile);
            Controls.Add(btnContact);
            Controls.Add(txtProfile);
            Controls.Add(btnSettings);
            Controls.Add(circle);
            Controls.Add(panelWindow);
            DoubleBuffered = true;
            Name = "HomeControl";
            Size = new Size(1280, 689);
            ((System.ComponentModel.ISupportInitialize)circle).EndInit();
            panelWindow.ResumeLayout(false);
            panelWindow.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel txtContact;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtSettings;
        private Guna.UI2.WinForms.Guna2CircleButton btnProfile;
        private Guna.UI2.WinForms.Guna2CircleButton btnContact;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtProfile;
        private Guna.UI2.WinForms.Guna2CircleButton btnSettings;
        private Guna.UI2.WinForms.Guna2CirclePictureBox circle;
        private Label textWelcome;
        private Panel panelWindow;
    }
}
