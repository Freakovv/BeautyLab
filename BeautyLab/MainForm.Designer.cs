namespace BeautyLab
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            BorderForm = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            Tabs = new Guna.UI2.WinForms.Guna2TabControl();
            tabPage1 = new TabPage();
            panel1 = new Panel();
            btnExit = new Bunifu.UI.WinForms.BunifuFormCaptionButton();
            textContact = new Guna.UI2.WinForms.Guna2HtmlLabel();
            groupTabs = new Guna.UI2.WinForms.Guna2GroupBox();
            textSettings = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnProfile = new Guna.UI2.WinForms.Guna2CircleButton();
            btnContact = new Guna.UI2.WinForms.Guna2CircleButton();
            textHome = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnSettings = new Guna.UI2.WinForms.Guna2CircleButton();
            guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            tabPage2 = new TabPage();
            Tabs.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BorderForm
            // 
            BorderForm.BorderRadius = 10;
            BorderForm.ContainerControl = this;
            BorderForm.DockIndicatorTransparencyValue = 0.6D;
            BorderForm.TransparentWhileDrag = true;
            // 
            // Tabs
            // 
            Tabs.Controls.Add(tabPage1);
            Tabs.Controls.Add(tabPage2);
            Tabs.ItemSize = new Size(180, 40);
            Tabs.Location = new Point(-10, -10);
            Tabs.Name = "Tabs";
            Tabs.SelectedIndex = 0;
            Tabs.Size = new Size(1300, 780);
            Tabs.TabButtonHoverState.BorderColor = Color.Empty;
            Tabs.TabButtonHoverState.FillColor = Color.FromArgb(40, 52, 70);
            Tabs.TabButtonHoverState.Font = new Font("Segoe UI Semibold", 10F);
            Tabs.TabButtonHoverState.ForeColor = Color.White;
            Tabs.TabButtonHoverState.InnerColor = Color.FromArgb(40, 52, 70);
            Tabs.TabButtonIdleState.BorderColor = Color.Empty;
            Tabs.TabButtonIdleState.FillColor = Color.FromArgb(33, 42, 57);
            Tabs.TabButtonIdleState.Font = new Font("Segoe UI Semibold", 10F);
            Tabs.TabButtonIdleState.ForeColor = Color.FromArgb(156, 160, 167);
            Tabs.TabButtonIdleState.InnerColor = Color.FromArgb(33, 42, 57);
            Tabs.TabButtonSelectedState.BorderColor = Color.Empty;
            Tabs.TabButtonSelectedState.FillColor = Color.FromArgb(29, 37, 49);
            Tabs.TabButtonSelectedState.Font = new Font("Segoe UI Semibold", 10F);
            Tabs.TabButtonSelectedState.ForeColor = Color.White;
            Tabs.TabButtonSelectedState.InnerColor = Color.FromArgb(76, 132, 255);
            Tabs.TabButtonSize = new Size(180, 40);
            Tabs.TabIndex = 0;
            Tabs.TabMenuBackColor = Color.Transparent;
            Tabs.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            Tabs.TabMenuVisible = false;
            // 
            // tabPage1
            // 
            tabPage1.BackgroundImage = (Image)resources.GetObject("tabPage1.BackgroundImage");
            tabPage1.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(textContact);
            tabPage1.Controls.Add(groupTabs);
            tabPage1.Controls.Add(textSettings);
            tabPage1.Controls.Add(btnProfile);
            tabPage1.Controls.Add(btnContact);
            tabPage1.Controls.Add(textHome);
            tabPage1.Controls.Add(btnSettings);
            tabPage1.Controls.Add(guna2CirclePictureBox1);
            tabPage1.Location = new Point(4, 5);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1292, 771);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnExit);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1289, 43);
            panel1.TabIndex = 11;
            // 
            // btnExit
            // 
            btnExit.AllowAnimations = true;
            btnExit.AllowBorderColorChanges = true;
            btnExit.AllowDefaults = true;
            btnExit.AllowMouseEffects = true;
            btnExit.AnimationSpeed = 200;
            btnExit.AutoSizeCaptions = true;
            btnExit.BackColor = Color.Transparent;
            btnExit.BackgroundColor = Color.FromArgb(233, 233, 233);
            btnExit.BackHoverColor = Color.LightGray;
            btnExit.BackPressedColor = Color.Silver;
            btnExit.BorderColor = Color.LightGray;
            btnExit.BorderHoverColor = Color.DarkGray;
            btnExit.BorderPressedColor = Color.DarkGray;
            btnExit.BorderRadius = 1;
            btnExit.BorderStyle = Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderStyles.Solid;
            btnExit.BorderThickness = 1;
            btnExit.CaptionType = Bunifu.UI.WinForms.BunifuFormCaptionButton.CaptionTypes.Minimize;
            btnExit.ColorContrastOnClick = 30;
            btnExit.ColorContrastOnHover = 30;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            btnExit.CustomizableEdges = borderEdges2;
            btnExit.DefaultBorderColor = Color.Silver;
            btnExit.DefaultColor = Color.Gainsboro;
            btnExit.DialogResult = DialogResult.None;
            btnExit.IconColor = Color.Black;
            btnExit.IconHoverColor = Color.Black;
            btnExit.IconPressedColor = Color.Black;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageMargin = new Padding(1, 1, 0, 0);
            btnExit.ImageSize = new Size(20, 20);
            btnExit.Location = new Point(1238, 4);
            btnExit.Name = "btnExit";
            btnExit.ShowBorders = true;
            btnExit.Size = new Size(48, 42);
            btnExit.TabIndex = 2;
            btnExit.Click += btnExit_Click;
            // 
            // textContact
            // 
            textContact.BackColor = Color.FromArgb(224, 224, 224);
            textContact.Font = new Font("Jura SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textContact.ForeColor = Color.FromArgb(135, 128, 128);
            textContact.Location = new Point(24, 596);
            textContact.Name = "textContact";
            textContact.Size = new Size(78, 24);
            textContact.TabIndex = 10;
            textContact.Text = "Контакты";
            // 
            // groupTabs
            // 
            groupTabs.BorderColor = Color.Transparent;
            groupTabs.BorderRadius = 15;
            groupTabs.CustomBorderColor = Color.Transparent;
            groupTabs.CustomizableEdges = customizableEdges7;
            groupTabs.FillColor = Color.Transparent;
            groupTabs.Font = new Font("Segoe UI", 9F);
            groupTabs.ForeColor = Color.Transparent;
            groupTabs.Location = new Point(123, 49);
            groupTabs.Name = "groupTabs";
            groupTabs.ShadowDecoration.CustomizableEdges = customizableEdges8;
            groupTabs.Size = new Size(1000, 56);
            groupTabs.TabIndex = 3;
            groupTabs.TextAlign = HorizontalAlignment.Center;
            groupTabs.UseTransparentBackground = true;
            // 
            // textSettings
            // 
            textSettings.BackColor = Color.FromArgb(224, 224, 224);
            textSettings.Font = new Font("Jura SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textSettings.ForeColor = Color.FromArgb(135, 128, 128);
            textSettings.Location = new Point(21, 447);
            textSettings.Name = "textSettings";
            textSettings.Size = new Size(90, 24);
            textSettings.TabIndex = 9;
            textSettings.Text = "Настройки";
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
            btnProfile.Location = new Point(7, 183);
            btnProfile.Name = "btnProfile";
            btnProfile.PressedColor = Color.FromArgb(227, 89, 164);
            btnProfile.PressedDepth = 1;
            btnProfile.ShadowDecoration.BorderRadius = 0;
            btnProfile.ShadowDecoration.CustomizableEdges = customizableEdges9;
            btnProfile.ShadowDecoration.Depth = 0;
            btnProfile.Size = new Size(110, 110);
            btnProfile.TabIndex = 4;
            btnProfile.UseTransparentBackground = true;
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
            btnContact.Location = new Point(7, 483);
            btnContact.Name = "btnContact";
            btnContact.ShadowDecoration.BorderRadius = 0;
            btnContact.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnContact.ShadowDecoration.Depth = 0;
            btnContact.Size = new Size(110, 110);
            btnContact.TabIndex = 6;
            btnContact.UseTransparentBackground = true;
            // 
            // textHome
            // 
            textHome.BackColor = Color.FromArgb(224, 224, 224);
            textHome.Font = new Font("Jura SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textHome.ForeColor = Color.FromArgb(135, 128, 128);
            textHome.Location = new Point(27, 295);
            textHome.Name = "textHome";
            textHome.Size = new Size(75, 24);
            textHome.TabIndex = 8;
            textHome.Text = "Профиль";
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
            btnSettings.Location = new Point(7, 334);
            btnSettings.Name = "btnSettings";
            btnSettings.ShadowDecoration.BorderRadius = 0;
            btnSettings.ShadowDecoration.CustomizableEdges = customizableEdges11;
            btnSettings.ShadowDecoration.Depth = 0;
            btnSettings.Size = new Size(110, 110);
            btnSettings.TabIndex = 5;
            btnSettings.UseTransparentBackground = true;
            // 
            // guna2CirclePictureBox1
            // 
            guna2CirclePictureBox1.BackColor = Color.Transparent;
            guna2CirclePictureBox1.FillColor = Color.FromArgb(224, 224, 224);
            guna2CirclePictureBox1.ImageRotate = 0F;
            guna2CirclePictureBox1.Location = new Point(-202, 79);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.ShadowDecoration.BorderRadius = 550;
            guna2CirclePictureBox1.ShadowDecoration.Color = Color.IndianRed;
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges12;
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.ShadowDecoration.Shadow = new Padding(20);
            guna2CirclePictureBox1.Size = new Size(381, 643);
            guna2CirclePictureBox1.TabIndex = 1;
            guna2CirclePictureBox1.TabStop = false;
            guna2CirclePictureBox1.UseTransparentBackground = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 5);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1292, 771);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1280, 760);
            Controls.Add(Tabs);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            Opacity = 0D;
            Text = "BeautyLab";
            Load += MainForm_Load;
            Tabs.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm BorderForm;
        private TabControl tabControl1;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Guna.UI2.WinForms.Guna2TabControl Tabs;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Bunifu.UI.WinForms.BunifuFormCaptionButton btnExit;
        private Guna.UI2.WinForms.Guna2GroupBox groupTabs;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2CircleButton btnProfile;
        private Guna.UI2.WinForms.Guna2CircleButton btnContact;
        private Guna.UI2.WinForms.Guna2CircleButton btnSettings;
        private Label label1;
        private Guna.UI2.WinForms.Guna2HtmlLabel textHome;
        private Guna.UI2.WinForms.Guna2HtmlLabel textContact;
        private Guna.UI2.WinForms.Guna2HtmlLabel textSettings;
        private Panel panel1;
    }
}