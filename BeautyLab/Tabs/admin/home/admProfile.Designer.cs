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
            picUser = new PictureBox();
            picPlus = new PictureBox();
            GroupPicture = new Guna.UI2.WinForms.Guna2GroupBox();
            txtLogin = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)picUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPlus).BeginInit();
            GroupPicture.SuspendLayout();
            SuspendLayout();
            // 
            // picUser
            // 
            picUser.BackColor = Color.Transparent;
            picUser.Image = (Image)resources.GetObject("picUser.Image");
            picUser.Location = new Point(33, 43);
            picUser.Name = "picUser";
            picUser.Size = new Size(222, 200);
            picUser.TabIndex = 0;
            picUser.TabStop = false;
            // 
            // picPlus
            // 
            picPlus.BackColor = Color.Transparent;
            picPlus.Image = (Image)resources.GetObject("picPlus.Image");
            picPlus.Location = new Point(206, 194);
            picPlus.Name = "picPlus";
            picPlus.Size = new Size(49, 47);
            picPlus.TabIndex = 1;
            picPlus.TabStop = false;
            // 
            // GroupPicture
            // 
            GroupPicture.Controls.Add(picPlus);
            GroupPicture.Controls.Add(picUser);
            GroupPicture.CustomizableEdges = customizableEdges1;
            GroupPicture.Font = new Font("Segoe UI", 9F);
            GroupPicture.ForeColor = Color.FromArgb(125, 137, 149);
            GroupPicture.Location = new Point(18, 19);
            GroupPicture.Name = "GroupPicture";
            GroupPicture.ShadowDecoration.CustomizableEdges = customizableEdges2;
            GroupPicture.Size = new Size(300, 252);
            GroupPicture.TabIndex = 3;
            GroupPicture.Text = "Аватар";
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
            txtLogin.Location = new Point(466, 62);
            txtLogin.Margin = new Padding(25);
            txtLogin.Name = "txtLogin";
            txtLogin.PasswordChar = '\0';
            txtLogin.PlaceholderForeColor = Color.FromArgb(135, 128, 128);
            txtLogin.PlaceholderText = "Логин";
            txtLogin.SelectedText = "";
            txtLogin.ShadowDecoration.BorderRadius = 150;
            txtLogin.ShadowDecoration.Color = Color.FromArgb(135, 128, 128);
            txtLogin.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtLogin.ShadowDecoration.Depth = 21;
            txtLogin.ShadowDecoration.Enabled = true;
            txtLogin.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            txtLogin.ShadowDecoration.Shadow = new Padding(2, 0, 2, 5);
            txtLogin.Size = new Size(338, 56);
            txtLogin.TabIndex = 4;
            txtLogin.TextOffset = new Point(0, -3);
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(txtLogin);
            Controls.Add(GroupPicture);
            DoubleBuffered = true;
            Name = "Profile";
            Size = new Size(1102, 689);
            ((System.ComponentModel.ISupportInitialize)picUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPlus).EndInit();
            GroupPicture.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picUser;
        private PictureBox picPlus;
        private Guna.UI2.WinForms.Guna2GroupBox GroupPicture;
        private Guna.UI2.WinForms.Guna2TextBox txtLogin;
    }
}
