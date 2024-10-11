namespace BeautyLab
{
    partial class EntryForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntryForm));
            BorderForm = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            pictureCircle = new PictureBox();
            panelLabel = new Panel();
            pictureLabel = new PictureBox();
            pictureFlower = new PictureBox();
            TabEntry = new Guna.UI2.WinForms.Guna2TabControl();
            pageEntry = new TabPage();
            picRectangle = new Guna.UI2.WinForms.Guna2PictureBox();
            btnEnter = new Guna.UI2.WinForms.Guna2GradientButton();
            checkBoxRememberMe = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            labelRemember = new Label();
            txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            txtLogin = new Guna.UI2.WinForms.Guna2TextBox();
            picUser = new PictureBox();
            PageReg = new TabPage();
            FormCaptionButton = new Bunifu.UI.WinForms.BunifuFormCaptionButton();
            dragPanel = new Panel();
            dragControl = new Guna.UI2.WinForms.Guna2DragControl(components);
            ((System.ComponentModel.ISupportInitialize)pictureCircle).BeginInit();
            panelLabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureLabel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureFlower).BeginInit();
            TabEntry.SuspendLayout();
            pageEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picRectangle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picUser).BeginInit();
            dragPanel.SuspendLayout();
            SuspendLayout();
            // 
            // BorderForm
            // 
            BorderForm.AnimateWindow = true;
            BorderForm.BorderRadius = 10;
            BorderForm.ContainerControl = this;
            BorderForm.DockIndicatorTransparencyValue = 0.6D;
            BorderForm.DragForm = false;
            BorderForm.ResizeForm = false;
            BorderForm.TransparentWhileDrag = true;
            // 
            // pictureCircle
            // 
            pictureCircle.Dock = DockStyle.Left;
            pictureCircle.Image = Properties.Resources.Ellipse_11;
            pictureCircle.Location = new Point(0, 0);
            pictureCircle.Margin = new Padding(3, 4, 3, 4);
            pictureCircle.Name = "pictureCircle";
            pictureCircle.Size = new Size(667, 933);
            pictureCircle.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureCircle.TabIndex = 0;
            pictureCircle.TabStop = false;
            // 
            // panelLabel
            // 
            panelLabel.BackColor = Color.FromArgb(255, 214, 236);
            panelLabel.Controls.Add(pictureLabel);
            panelLabel.Controls.Add(pictureFlower);
            panelLabel.Location = new Point(47, 373);
            panelLabel.Margin = new Padding(3, 4, 3, 4);
            panelLabel.Name = "panelLabel";
            panelLabel.Size = new Size(509, 132);
            panelLabel.TabIndex = 1;
            // 
            // pictureLabel
            // 
            pictureLabel.BackColor = Color.Transparent;
            pictureLabel.Image = Properties.Resources.BeautyLab;
            pictureLabel.Location = new Point(135, 35);
            pictureLabel.Margin = new Padding(3, 4, 3, 4);
            pictureLabel.Name = "pictureLabel";
            pictureLabel.Size = new Size(347, 67);
            pictureLabel.TabIndex = 0;
            pictureLabel.TabStop = false;
            // 
            // pictureFlower
            // 
            pictureFlower.BackColor = Color.Transparent;
            pictureFlower.Image = Properties.Resources.icons8_цветок_64;
            pictureFlower.Location = new Point(32, 21);
            pictureFlower.Margin = new Padding(3, 4, 3, 4);
            pictureFlower.Name = "pictureFlower";
            pictureFlower.Size = new Size(96, 92);
            pictureFlower.TabIndex = 1;
            pictureFlower.TabStop = false;
            // 
            // TabEntry
            // 
            TabEntry.Alignment = TabAlignment.Bottom;
            TabEntry.Controls.Add(pageEntry);
            TabEntry.Controls.Add(PageReg);
            TabEntry.ItemSize = new Size(80, 40);
            TabEntry.Location = new Point(648, 52);
            TabEntry.Margin = new Padding(3, 4, 3, 4);
            TabEntry.Name = "TabEntry";
            TabEntry.SelectedIndex = 0;
            TabEntry.Size = new Size(499, 881);
            TabEntry.TabButtonHoverState.BorderColor = Color.Empty;
            TabEntry.TabButtonHoverState.FillColor = Color.FromArgb(40, 52, 70);
            TabEntry.TabButtonHoverState.Font = new Font("Segoe UI Semibold", 10F);
            TabEntry.TabButtonHoverState.ForeColor = Color.White;
            TabEntry.TabButtonHoverState.InnerColor = Color.FromArgb(40, 52, 70);
            TabEntry.TabButtonIdleState.BorderColor = Color.Empty;
            TabEntry.TabButtonIdleState.FillColor = Color.FromArgb(33, 42, 57);
            TabEntry.TabButtonIdleState.Font = new Font("Segoe UI Semibold", 10F);
            TabEntry.TabButtonIdleState.ForeColor = Color.FromArgb(156, 160, 167);
            TabEntry.TabButtonIdleState.InnerColor = Color.FromArgb(33, 42, 57);
            TabEntry.TabButtonSelectedState.BorderColor = Color.Empty;
            TabEntry.TabButtonSelectedState.FillColor = Color.FromArgb(29, 37, 49);
            TabEntry.TabButtonSelectedState.Font = new Font("Segoe UI Semibold", 10F);
            TabEntry.TabButtonSelectedState.ForeColor = Color.White;
            TabEntry.TabButtonSelectedState.InnerColor = Color.FromArgb(76, 132, 255);
            TabEntry.TabButtonSize = new Size(80, 40);
            TabEntry.TabIndex = 2;
            TabEntry.TabMenuBackColor = Color.FromArgb(33, 42, 57);
            TabEntry.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalBottom;
            // 
            // pageEntry
            // 
            pageEntry.BackColor = Color.White;
            pageEntry.Controls.Add(picRectangle);
            pageEntry.Controls.Add(btnEnter);
            pageEntry.Controls.Add(checkBoxRememberMe);
            pageEntry.Controls.Add(labelRemember);
            pageEntry.Controls.Add(txtPassword);
            pageEntry.Controls.Add(txtLogin);
            pageEntry.Controls.Add(picUser);
            pageEntry.Font = new Font("Jura", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            pageEntry.Location = new Point(4, 4);
            pageEntry.Margin = new Padding(3, 4, 3, 4);
            pageEntry.Name = "pageEntry";
            pageEntry.Padding = new Padding(3, 4, 3, 4);
            pageEntry.Size = new Size(491, 833);
            pageEntry.TabIndex = 0;
            pageEntry.Text = "PageEntry";
            // 
            // picRectangle
            // 
            picRectangle.BackColor = Color.Transparent;
            picRectangle.CustomizableEdges = customizableEdges1;
            picRectangle.Image = Properties.Resources.Rectangle_4;
            picRectangle.ImageRotate = 0F;
            picRectangle.Location = new Point(133, 579);
            picRectangle.Name = "picRectangle";
            picRectangle.ShadowDecoration.CustomizableEdges = customizableEdges2;
            picRectangle.Size = new Size(228, 51);
            picRectangle.SizeMode = PictureBoxSizeMode.StretchImage;
            picRectangle.TabIndex = 6;
            picRectangle.TabStop = false;
            picRectangle.UseTransparentBackground = true;
            picRectangle.Click += guna2PictureBox1_Click;
            // 
            // btnEnter
            // 
            btnEnter.Animated = true;
            btnEnter.BackColor = Color.Transparent;
            btnEnter.BorderRadius = 30;
            btnEnter.CustomizableEdges = customizableEdges3;
            btnEnter.DisabledState.BorderColor = Color.DarkGray;
            btnEnter.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEnter.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEnter.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnEnter.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEnter.FillColor = Color.FromArgb(227, 89, 164);
            btnEnter.FillColor2 = Color.FromArgb(222, 89, 227);
            btnEnter.Font = new Font("Jura", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnEnter.ForeColor = Color.White;
            btnEnter.Location = new Point(126, 572);
            btnEnter.Name = "btnEnter";
            btnEnter.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnEnter.ShadowDecoration.Enabled = true;
            btnEnter.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnEnter.ShadowDecoration.Shadow = new Padding(1, 1, 1, 5);
            btnEnter.Size = new Size(244, 66);
            btnEnter.TabIndex = 7;
            btnEnter.Text = "Войти";
            btnEnter.TextOffset = new Point(0, -3);
            // 
            // checkBoxRememberMe
            // 
            checkBoxRememberMe.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            checkBoxRememberMe.CheckedState.BorderRadius = 2;
            checkBoxRememberMe.CheckedState.BorderThickness = 0;
            checkBoxRememberMe.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            checkBoxRememberMe.CustomizableEdges = customizableEdges5;
            checkBoxRememberMe.Location = new Point(103, 520);
            checkBoxRememberMe.Name = "checkBoxRememberMe";
            checkBoxRememberMe.ShadowDecoration.BorderRadius = 30;
            customizableEdges6.BottomLeft = false;
            customizableEdges6.BottomRight = false;
            checkBoxRememberMe.ShadowDecoration.CustomizableEdges = customizableEdges6;
            checkBoxRememberMe.ShadowDecoration.Depth = 15;
            checkBoxRememberMe.ShadowDecoration.Enabled = true;
            checkBoxRememberMe.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            checkBoxRememberMe.ShadowDecoration.Shadow = new Padding(1, 1, 1, 4);
            checkBoxRememberMe.Size = new Size(25, 25);
            checkBoxRememberMe.TabIndex = 3;
            checkBoxRememberMe.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            checkBoxRememberMe.UncheckedState.BorderRadius = 6;
            checkBoxRememberMe.UncheckedState.BorderThickness = 1;
            checkBoxRememberMe.UncheckedState.FillColor = Color.Transparent;
            // 
            // labelRemember
            // 
            labelRemember.AutoSize = true;
            labelRemember.BackColor = Color.Transparent;
            labelRemember.Font = new Font("Jura", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelRemember.ForeColor = Color.FromArgb(135, 128, 128);
            labelRemember.Location = new Point(133, 511);
            labelRemember.Name = "labelRemember";
            labelRemember.Size = new Size(235, 37);
            labelRemember.TabIndex = 5;
            labelRemember.Text = "Запомнить меня";
            labelRemember.Click += labelRemember_Click;
            // 
            // txtPassword
            // 
            txtPassword.AcceptsReturn = true;
            txtPassword.Animated = true;
            txtPassword.BackColor = Color.Transparent;
            txtPassword.BorderRadius = 25;
            txtPassword.CustomizableEdges = customizableEdges7;
            txtPassword.DefaultText = "";
            txtPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.FillColor = Color.FromArgb(239, 239, 239);
            txtPassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.Font = new Font("Microsoft Sans Serif", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtPassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.IconLeft = Properties.Resources.Lock1;
            txtPassword.IconLeftOffset = new Point(12, 0);
            txtPassword.IconLeftSize = new Size(23, 23);
            txtPassword.Location = new Point(48, 411);
            txtPassword.Margin = new Padding(14, 16, 14, 16);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '⊛';
            txtPassword.PlaceholderForeColor = Color.FromArgb(135, 128, 128);
            txtPassword.PlaceholderText = "Пароль";
            txtPassword.SelectedText = "";
            txtPassword.ShadowDecoration.BorderRadius = 150;
            txtPassword.ShadowDecoration.Color = Color.FromArgb(135, 128, 128);
            txtPassword.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtPassword.ShadowDecoration.Depth = 21;
            txtPassword.ShadowDecoration.Enabled = true;
            txtPassword.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            txtPassword.ShadowDecoration.Shadow = new Padding(2, 0, 2, 5);
            txtPassword.Size = new Size(386, 75);
            txtPassword.TabIndex = 3;
            txtPassword.TextOffset = new Point(0, -3);
            // 
            // txtLogin
            // 
            txtLogin.AcceptsReturn = true;
            txtLogin.Animated = true;
            txtLogin.BackColor = Color.Transparent;
            txtLogin.BorderRadius = 25;
            txtLogin.CustomizableEdges = customizableEdges9;
            txtLogin.DefaultText = "";
            txtLogin.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtLogin.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtLogin.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtLogin.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtLogin.FillColor = Color.FromArgb(239, 239, 239);
            txtLogin.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtLogin.Font = new Font("Microsoft Sans Serif", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtLogin.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtLogin.IconLeft = Properties.Resources.mail1;
            txtLogin.IconLeftOffset = new Point(12, 0);
            txtLogin.IconLeftSize = new Size(27, 25);
            txtLogin.Location = new Point(48, 304);
            txtLogin.Margin = new Padding(14, 16, 14, 16);
            txtLogin.Name = "txtLogin";
            txtLogin.PasswordChar = '\0';
            txtLogin.PlaceholderForeColor = Color.FromArgb(135, 128, 128);
            txtLogin.PlaceholderText = "Логин";
            txtLogin.SelectedText = "";
            txtLogin.ShadowDecoration.BorderRadius = 150;
            txtLogin.ShadowDecoration.Color = Color.FromArgb(135, 128, 128);
            txtLogin.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtLogin.ShadowDecoration.Depth = 21;
            txtLogin.ShadowDecoration.Enabled = true;
            txtLogin.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            txtLogin.ShadowDecoration.Shadow = new Padding(2, 0, 2, 5);
            txtLogin.Size = new Size(386, 75);
            txtLogin.TabIndex = 1;
            txtLogin.TextOffset = new Point(0, -3);
            // 
            // picUser
            // 
            picUser.Anchor = AnchorStyles.None;
            picUser.BackColor = Color.Transparent;
            picUser.Image = Properties.Resources.Group_3;
            picUser.Location = new Point(130, 11);
            picUser.Margin = new Padding(3, 4, 3, 4);
            picUser.Name = "picUser";
            picUser.Size = new Size(242, 267);
            picUser.SizeMode = PictureBoxSizeMode.Zoom;
            picUser.TabIndex = 2;
            picUser.TabStop = false;
            // 
            // PageReg
            // 
            PageReg.BackColor = Color.White;
            PageReg.Location = new Point(4, 4);
            PageReg.Margin = new Padding(3, 4, 3, 4);
            PageReg.Name = "PageReg";
            PageReg.Padding = new Padding(3, 4, 3, 4);
            PageReg.Size = new Size(491, 833);
            PageReg.TabIndex = 1;
            PageReg.Text = "PageReg";
            // 
            // FormCaptionButton
            // 
            FormCaptionButton.AllowAnimations = true;
            FormCaptionButton.AllowBorderColorChanges = true;
            FormCaptionButton.AllowDefaults = true;
            FormCaptionButton.AllowMouseEffects = true;
            FormCaptionButton.AnimationSpeed = 200;
            FormCaptionButton.AutoSizeCaptions = true;
            FormCaptionButton.BackColor = Color.Transparent;
            FormCaptionButton.BackgroundColor = Color.White;
            FormCaptionButton.BackHoverColor = Color.LightGray;
            FormCaptionButton.BackPressedColor = Color.Silver;
            FormCaptionButton.BorderColor = Color.White;
            FormCaptionButton.BorderHoverColor = Color.DarkGray;
            FormCaptionButton.BorderPressedColor = Color.DarkGray;
            FormCaptionButton.BorderRadius = 1;
            FormCaptionButton.BorderStyle = Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderStyles.Solid;
            FormCaptionButton.BorderThickness = 1;
            FormCaptionButton.CaptionType = Bunifu.UI.WinForms.BunifuFormCaptionButton.CaptionTypes.Close;
            FormCaptionButton.ColorContrastOnClick = 30;
            FormCaptionButton.ColorContrastOnHover = 30;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            FormCaptionButton.CustomizableEdges = borderEdges1;
            FormCaptionButton.DefaultBorderColor = Color.White;
            FormCaptionButton.DefaultColor = Color.White;
            FormCaptionButton.DialogResult = DialogResult.None;
            FormCaptionButton.IconColor = Color.Black;
            FormCaptionButton.IconHoverColor = Color.Black;
            FormCaptionButton.IconPressedColor = Color.Black;
            FormCaptionButton.Image = (Image)resources.GetObject("FormCaptionButton.Image");
            FormCaptionButton.ImageMargin = new Padding(1, 1, 0, 0);
            FormCaptionButton.ImageSize = new Size(20, 20);
            FormCaptionButton.Location = new Point(1090, -3);
            FormCaptionButton.Margin = new Padding(3, 4, 3, 4);
            FormCaptionButton.Name = "FormCaptionButton";
            FormCaptionButton.ShowBorders = true;
            FormCaptionButton.Size = new Size(57, 53);
            FormCaptionButton.TabIndex = 3;
            FormCaptionButton.Click += FormCaptionButton_Click;
            // 
            // dragPanel
            // 
            dragPanel.BackColor = Color.Transparent;
            dragPanel.Controls.Add(FormCaptionButton);
            dragPanel.ForeColor = Color.Transparent;
            dragPanel.Location = new Point(0, 0);
            dragPanel.Margin = new Padding(3, 4, 3, 4);
            dragPanel.Name = "dragPanel";
            dragPanel.Size = new Size(1463, 51);
            dragPanel.TabIndex = 4;
            // 
            // dragControl
            // 
            dragControl.DockIndicatorTransparencyValue = 0.6D;
            dragControl.TargetControl = dragPanel;
            dragControl.UseTransparentDrag = true;
            // 
            // EntryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1143, 933);
            Controls.Add(panelLabel);
            Controls.Add(pictureCircle);
            Controls.Add(TabEntry);
            Controls.Add(dragPanel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "EntryForm";
            Text = "EntryForm";
            FormClosing += EntryForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureCircle).EndInit();
            panelLabel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureLabel).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureFlower).EndInit();
            TabEntry.ResumeLayout(false);
            pageEntry.ResumeLayout(false);
            pageEntry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picRectangle).EndInit();
            ((System.ComponentModel.ISupportInitialize)picUser).EndInit();
            dragPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm BorderForm;
        private PictureBox pictureCircle;
        private Panel panelLabel;
        private PictureBox pictureLabel;
        private PictureBox pictureFlower;
        private Guna.UI2.WinForms.Guna2TabControl TabEntry;
        private TabPage pageEntry;
        private TabPage PageReg;
        private Bunifu.UI.WinForms.BunifuFormCaptionButton FormCaptionButton;
        private Panel dragPanel;
        private Guna.UI2.WinForms.Guna2DragControl dragControl;
        private PictureBox picUser;
        private Guna.UI2.WinForms.Guna2TextBox txtLogin;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Label labelRemember;
        private Guna.UI2.WinForms.Guna2CustomCheckBox checkBoxRememberMe;
        private Guna.UI2.WinForms.Guna2PictureBox picRectangle;
        private Guna.UI2.WinForms.Guna2GradientButton btnEnter;
    }
}