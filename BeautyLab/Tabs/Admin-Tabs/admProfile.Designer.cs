namespace BeautyLab.Tabs
{
    partial class admProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admProfile));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            picUser = new PictureBox();
            GroupPicture = new Guna.UI2.WinForms.Guna2GroupBox();
            txtLogin = new Guna.UI2.WinForms.Guna2TextBox();
            txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            btnEnter = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            SHADOWBUTTON = new Guna.UI2.WinForms.Guna2GradientButton();
            lblTerms = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)picUser).BeginInit();
            GroupPicture.SuspendLayout();
            SuspendLayout();
            // 
            // picUser
            // 
            picUser.BackColor = Color.Transparent;
            picUser.Cursor = Cursors.Hand;
            picUser.Image = (Image)resources.GetObject("picUser.Image");
            picUser.Location = new Point(33, 41);
            picUser.Name = "picUser";
            picUser.Size = new Size(222, 208);
            picUser.SizeMode = PictureBoxSizeMode.Zoom;
            picUser.TabIndex = 0;
            picUser.TabStop = false;
            // 
            // GroupPicture
            // 
            GroupPicture.BorderColor = Color.FromArgb(255, 214, 236);
            GroupPicture.Controls.Add(picUser);
            GroupPicture.CustomBorderColor = Color.FromArgb(255, 214, 236);
            GroupPicture.CustomizableEdges = customizableEdges1;
            GroupPicture.FillColor = Color.Transparent;
            GroupPicture.Font = new Font("Segoe UI", 9F);
            GroupPicture.ForeColor = Color.FromArgb(125, 137, 149);
            GroupPicture.Location = new Point(381, 42);
            GroupPicture.Name = "GroupPicture";
            GroupPicture.ShadowDecoration.CustomizableEdges = customizableEdges2;
            GroupPicture.Size = new Size(280, 252);
            GroupPicture.TabIndex = 3;
            GroupPicture.Text = "Login";
            GroupPicture.TextAlign = HorizontalAlignment.Center;
            // 
            // txtLogin
            // 
            txtLogin.AcceptsReturn = true;
            txtLogin.Animated = true;
            txtLogin.BackColor = Color.Transparent;
            txtLogin.BorderRadius = 25;
            txtLogin.CustomizableEdges = customizableEdges3;
            txtLogin.DefaultText = "";
            txtLogin.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtLogin.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtLogin.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtLogin.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtLogin.FillColor = Color.FromArgb(239, 239, 239);
            txtLogin.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtLogin.Font = new Font("Jura", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtLogin.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtLogin.IconLeft = Properties.Resources.mail1;
            txtLogin.IconLeftOffset = new Point(12, 0);
            txtLogin.IconLeftSize = new Size(27, 25);
            txtLogin.Location = new Point(284, 322);
            txtLogin.Margin = new Padding(25);
            txtLogin.Name = "txtLogin";
            txtLogin.PasswordChar = '\0';
            txtLogin.PlaceholderForeColor = Color.FromArgb(135, 128, 128);
            txtLogin.PlaceholderText = "Email";
            txtLogin.SelectedText = "";
            txtLogin.ShadowDecoration.BorderRadius = 150;
            txtLogin.ShadowDecoration.Color = Color.FromArgb(135, 128, 128);
            txtLogin.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtLogin.ShadowDecoration.Depth = 21;
            txtLogin.ShadowDecoration.Enabled = true;
            txtLogin.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            txtLogin.ShadowDecoration.Shadow = new Padding(2, 0, 2, 5);
            txtLogin.Size = new Size(460, 56);
            txtLogin.TabIndex = 4;
            txtLogin.TextOffset = new Point(0, -3);
            // 
            // txtPassword
            // 
            txtPassword.AcceptsReturn = true;
            txtPassword.Animated = true;
            txtPassword.BackColor = Color.Transparent;
            txtPassword.BorderRadius = 25;
            txtPassword.CustomizableEdges = customizableEdges5;
            txtPassword.DefaultText = "";
            txtPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.FillColor = Color.FromArgb(239, 239, 239);
            txtPassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.Font = new Font("Jura", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtPassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.IconLeft = Properties.Resources.Lock1;
            txtPassword.IconLeftOffset = new Point(15, 0);
            txtPassword.Location = new Point(284, 409);
            txtPassword.Margin = new Padding(24, 25, 24, 25);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '⊛';
            txtPassword.PlaceholderForeColor = Color.FromArgb(135, 128, 128);
            txtPassword.PlaceholderText = "Пароль";
            txtPassword.SelectedText = "";
            txtPassword.ShadowDecoration.BorderRadius = 150;
            txtPassword.ShadowDecoration.Color = Color.FromArgb(135, 128, 128);
            txtPassword.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtPassword.ShadowDecoration.Depth = 21;
            txtPassword.ShadowDecoration.Enabled = true;
            txtPassword.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            txtPassword.ShadowDecoration.Shadow = new Padding(2, 0, 2, 5);
            txtPassword.Size = new Size(460, 56);
            txtPassword.TabIndex = 5;
            txtPassword.TextOffset = new Point(0, -3);
            // 
            // btnEnter
            // 
            btnEnter.AllowAnimations = true;
            btnEnter.AllowMouseEffects = true;
            btnEnter.AllowToggling = false;
            btnEnter.AnimationSpeed = 200;
            btnEnter.AutoGenerateColors = false;
            btnEnter.AutoRoundBorders = false;
            btnEnter.AutoSizeLeftIcon = true;
            btnEnter.AutoSizeRightIcon = true;
            btnEnter.BackColor = Color.Transparent;
            btnEnter.BackColor1 = Color.FromArgb(227, 89, 164);
            btnEnter.BackgroundImage = (Image)resources.GetObject("btnEnter.BackgroundImage");
            btnEnter.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnEnter.ButtonText = "Редактировать";
            btnEnter.ButtonTextMarginLeft = 0;
            btnEnter.ColorContrastOnClick = 45;
            btnEnter.ColorContrastOnHover = 45;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            btnEnter.CustomizableEdges = borderEdges1;
            btnEnter.DialogResult = DialogResult.None;
            btnEnter.DisabledBorderColor = Color.Empty;
            btnEnter.DisabledFillColor = Color.FromArgb(242, 220, 232);
            btnEnter.DisabledForecolor = Color.White;
            btnEnter.Enabled = false;
            btnEnter.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Idle;
            btnEnter.Font = new Font("Jura", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnEnter.ForeColor = Color.White;
            btnEnter.IconLeftAlign = ContentAlignment.MiddleLeft;
            btnEnter.IconLeftCursor = Cursors.Default;
            btnEnter.IconLeftPadding = new Padding(11, 3, 3, 3);
            btnEnter.IconMarginLeft = 11;
            btnEnter.IconPadding = 10;
            btnEnter.IconRightAlign = ContentAlignment.MiddleRight;
            btnEnter.IconRightCursor = Cursors.Default;
            btnEnter.IconRightPadding = new Padding(3, 3, 7, 3);
            btnEnter.IconSize = 25;
            btnEnter.IdleBorderColor = Color.Empty;
            btnEnter.IdleBorderRadius = 50;
            btnEnter.IdleBorderThickness = 1;
            btnEnter.IdleFillColor = Color.FromArgb(227, 89, 164);
            btnEnter.IdleIconLeftImage = null;
            btnEnter.IdleIconRightImage = null;
            btnEnter.IndicateFocus = false;
            btnEnter.Location = new Point(361, 512);
            btnEnter.Name = "btnEnter";
            btnEnter.OnDisabledState.BorderColor = Color.Empty;
            btnEnter.OnDisabledState.BorderRadius = 50;
            btnEnter.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnEnter.OnDisabledState.BorderThickness = 0;
            btnEnter.OnDisabledState.FillColor = Color.FromArgb(242, 220, 232);
            btnEnter.OnDisabledState.ForeColor = Color.White;
            btnEnter.OnDisabledState.IconLeftImage = null;
            btnEnter.OnDisabledState.IconRightImage = null;
            btnEnter.onHoverState.BorderColor = Color.Empty;
            btnEnter.onHoverState.BorderRadius = 50;
            btnEnter.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnEnter.onHoverState.BorderThickness = 0;
            btnEnter.onHoverState.FillColor = Color.FromArgb(240, 100, 200);
            btnEnter.onHoverState.ForeColor = Color.White;
            btnEnter.onHoverState.IconLeftImage = null;
            btnEnter.onHoverState.IconRightImage = null;
            btnEnter.OnIdleState.BorderColor = Color.Empty;
            btnEnter.OnIdleState.BorderRadius = 50;
            btnEnter.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnEnter.OnIdleState.BorderThickness = 0;
            btnEnter.OnIdleState.FillColor = Color.FromArgb(227, 89, 164);
            btnEnter.OnIdleState.ForeColor = Color.White;
            btnEnter.OnIdleState.IconLeftImage = null;
            btnEnter.OnIdleState.IconRightImage = null;
            btnEnter.OnPressedState.BorderColor = Color.Empty;
            btnEnter.OnPressedState.BorderRadius = 50;
            btnEnter.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnEnter.OnPressedState.BorderThickness = 0;
            btnEnter.OnPressedState.FillColor = Color.FromArgb(230, 80, 170);
            btnEnter.OnPressedState.ForeColor = Color.White;
            btnEnter.OnPressedState.IconLeftImage = null;
            btnEnter.OnPressedState.IconRightImage = null;
            btnEnter.Size = new Size(300, 50);
            btnEnter.TabIndex = 12;
            btnEnter.TextAlign = ContentAlignment.MiddleCenter;
            btnEnter.TextAlignment = HorizontalAlignment.Center;
            btnEnter.TextMarginLeft = 0;
            btnEnter.TextPadding = new Padding(0, -2, 0, 0);
            btnEnter.UseDefaultRadiusAndThickness = true;
            // 
            // SHADOWBUTTON
            // 
            SHADOWBUTTON.Animated = true;
            SHADOWBUTTON.BackColor = Color.Transparent;
            SHADOWBUTTON.BackgroundImageLayout = ImageLayout.Stretch;
            SHADOWBUTTON.BorderRadius = 25;
            SHADOWBUTTON.CustomizableEdges = customizableEdges7;
            SHADOWBUTTON.DisabledState.BorderColor = Color.DarkGray;
            SHADOWBUTTON.DisabledState.CustomBorderColor = Color.DarkGray;
            SHADOWBUTTON.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            SHADOWBUTTON.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            SHADOWBUTTON.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            SHADOWBUTTON.FillColor = Color.FromArgb(227, 89, 164);
            SHADOWBUTTON.FillColor2 = Color.FromArgb(222, 89, 227);
            SHADOWBUTTON.Font = new Font("Jura", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SHADOWBUTTON.ForeColor = Color.White;
            SHADOWBUTTON.Location = new Point(361, 512);
            SHADOWBUTTON.Margin = new Padding(3, 2, 3, 2);
            SHADOWBUTTON.Name = "SHADOWBUTTON";
            SHADOWBUTTON.ShadowDecoration.CustomizableEdges = customizableEdges8;
            SHADOWBUTTON.ShadowDecoration.Enabled = true;
            SHADOWBUTTON.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            SHADOWBUTTON.ShadowDecoration.Shadow = new Padding(1, 1, 1, 3);
            SHADOWBUTTON.Size = new Size(300, 50);
            SHADOWBUTTON.TabIndex = 11;
            SHADOWBUTTON.Text = "Редактировать";
            SHADOWBUTTON.TextOffset = new Point(0, -3);
            // 
            // lblTerms
            // 
            lblTerms.AutoSize = true;
            lblTerms.BackColor = Color.Transparent;
            lblTerms.Cursor = Cursors.Hand;
            lblTerms.Font = new Font("Jura", 12.7499981F, FontStyle.Underline, GraphicsUnit.Point, 204);
            lblTerms.ForeColor = Color.FromArgb(227, 89, 164);
            lblTerms.Location = new Point(430, 580);
            lblTerms.Name = "lblTerms";
            lblTerms.Size = new Size(161, 23);
            lblTerms.TabIndex = 18;
            lblTerms.Text = "Выйти из аккаунта";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Jura", 12.7499981F, FontStyle.Underline, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(227, 89, 164);
            label1.Location = new Point(440, 624);
            label1.Name = "label1";
            label1.Size = new Size(142, 23);
            label1.TabIndex = 19;
            label1.Text = "Удалить аккаунт";
            // 
            // admProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(label1);
            Controls.Add(lblTerms);
            Controls.Add(btnEnter);
            Controls.Add(SHADOWBUTTON);
            Controls.Add(txtPassword);
            Controls.Add(txtLogin);
            Controls.Add(GroupPicture);
            DoubleBuffered = true;
            Name = "admProfile";
            Size = new Size(1102, 689);
            ((System.ComponentModel.ISupportInitialize)picUser).EndInit();
            GroupPicture.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picUser;
        private Guna.UI2.WinForms.Guna2GroupBox GroupPicture;
        private Guna.UI2.WinForms.Guna2TextBox txtLogin;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnEnter;
        private Guna.UI2.WinForms.Guna2GradientButton SHADOWBUTTON;
        private Label lblTerms;
        private Label label1;
    }
}
