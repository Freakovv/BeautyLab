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
            Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntryForm));
            BorderForm = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            pictureCircle = new PictureBox();
            panelLabel = new Panel();
            pictureLabel = new PictureBox();
            pictureFlower = new PictureBox();
            TabEntry = new Guna.UI2.WinForms.Guna2TabControl();
            pageEntry = new TabPage();
            textBoxPassword = new Guna.UI2.WinForms.Guna2TextBox();
            textBoxLogin = new Guna.UI2.WinForms.Guna2TextBox();
            pictureUser = new PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)pictureUser).BeginInit();
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
            pictureCircle.Name = "pictureCircle";
            pictureCircle.Size = new Size(584, 700);
            pictureCircle.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureCircle.TabIndex = 0;
            pictureCircle.TabStop = false;
            // 
            // panelLabel
            // 
            panelLabel.BackColor = Color.FromArgb(255, 214, 236);
            panelLabel.Controls.Add(pictureLabel);
            panelLabel.Controls.Add(pictureFlower);
            panelLabel.Location = new Point(41, 280);
            panelLabel.Name = "panelLabel";
            panelLabel.Size = new Size(445, 99);
            panelLabel.TabIndex = 1;
            // 
            // pictureLabel
            // 
            pictureLabel.BackColor = Color.Transparent;
            pictureLabel.Image = Properties.Resources.BeautyLab;
            pictureLabel.Location = new Point(118, 26);
            pictureLabel.Name = "pictureLabel";
            pictureLabel.Size = new Size(304, 50);
            pictureLabel.TabIndex = 0;
            pictureLabel.TabStop = false;
            // 
            // pictureFlower
            // 
            pictureFlower.BackColor = Color.Transparent;
            pictureFlower.Image = Properties.Resources.icons8_цветок_64;
            pictureFlower.Location = new Point(28, 16);
            pictureFlower.Name = "pictureFlower";
            pictureFlower.Size = new Size(84, 69);
            pictureFlower.TabIndex = 1;
            pictureFlower.TabStop = false;
            // 
            // TabEntry
            // 
            TabEntry.Alignment = TabAlignment.Bottom;
            TabEntry.Controls.Add(pageEntry);
            TabEntry.Controls.Add(PageReg);
            TabEntry.ItemSize = new Size(80, 40);
            TabEntry.Location = new Point(567, 39);
            TabEntry.Name = "TabEntry";
            TabEntry.SelectedIndex = 0;
            TabEntry.Size = new Size(437, 661);
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
            pageEntry.Controls.Add(textBoxPassword);
            pageEntry.Controls.Add(textBoxLogin);
            pageEntry.Controls.Add(pictureUser);
            pageEntry.Location = new Point(4, 4);
            pageEntry.Name = "pageEntry";
            pageEntry.Padding = new Padding(3);
            pageEntry.Size = new Size(429, 613);
            pageEntry.TabIndex = 0;
            pageEntry.Text = "PageEntry";
            // 
            // textBoxPassword
            // 
            textBoxPassword.AcceptsReturn = true;
            textBoxPassword.Animated = true;
            textBoxPassword.BackColor = Color.Transparent;
            textBoxPassword.BorderRadius = 25;
            textBoxPassword.CustomizableEdges = customizableEdges1;
            textBoxPassword.DefaultText = "";
            textBoxPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            textBoxPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            textBoxPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            textBoxPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            textBoxPassword.FillColor = Color.FromArgb(239, 239, 239);
            textBoxPassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            textBoxPassword.Font = new Font("Jura", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxPassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            textBoxPassword.IconLeft = Properties.Resources.Lock1;
            textBoxPassword.IconLeftOffset = new Point(12, 0);
            textBoxPassword.IconLeftSize = new Size(23, 23);
            textBoxPassword.Location = new Point(42, 308);
            textBoxPassword.Margin = new Padding(12);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '⊛';
            textBoxPassword.PlaceholderForeColor = Color.FromArgb(135, 128, 128);
            textBoxPassword.PlaceholderText = "Пароль";
            textBoxPassword.SelectedText = "";
            textBoxPassword.ShadowDecoration.BorderRadius = 150;
            textBoxPassword.ShadowDecoration.Color = Color.FromArgb(135, 128, 128);
            textBoxPassword.ShadowDecoration.CustomizableEdges = customizableEdges2;
            textBoxPassword.ShadowDecoration.Depth = 21;
            textBoxPassword.ShadowDecoration.Enabled = true;
            textBoxPassword.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            textBoxPassword.ShadowDecoration.Shadow = new Padding(2, 0, 2, 5);
            textBoxPassword.Size = new Size(338, 56);
            textBoxPassword.TabIndex = 3;
            textBoxPassword.TextOffset = new Point(0, -3);
            // 
            // textBoxLogin
            // 
            textBoxLogin.AcceptsReturn = true;
            textBoxLogin.Animated = true;
            textBoxLogin.BackColor = Color.Transparent;
            textBoxLogin.BorderRadius = 25;
            textBoxLogin.CustomizableEdges = customizableEdges3;
            textBoxLogin.DefaultText = "";
            textBoxLogin.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            textBoxLogin.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            textBoxLogin.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            textBoxLogin.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            textBoxLogin.FillColor = Color.FromArgb(239, 239, 239);
            textBoxLogin.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            textBoxLogin.Font = new Font("Jura", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxLogin.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            textBoxLogin.IconLeft = Properties.Resources.mail1;
            textBoxLogin.IconLeftOffset = new Point(12, 0);
            textBoxLogin.IconLeftSize = new Size(27, 25);
            textBoxLogin.Location = new Point(42, 228);
            textBoxLogin.Margin = new Padding(12);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.PasswordChar = '\0';
            textBoxLogin.PlaceholderForeColor = Color.FromArgb(135, 128, 128);
            textBoxLogin.PlaceholderText = "Логин";
            textBoxLogin.SelectedText = "";
            textBoxLogin.ShadowDecoration.BorderRadius = 150;
            textBoxLogin.ShadowDecoration.Color = Color.FromArgb(135, 128, 128);
            textBoxLogin.ShadowDecoration.CustomizableEdges = customizableEdges4;
            textBoxLogin.ShadowDecoration.Depth = 21;
            textBoxLogin.ShadowDecoration.Enabled = true;
            textBoxLogin.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            textBoxLogin.ShadowDecoration.Shadow = new Padding(2, 0, 2, 5);
            textBoxLogin.Size = new Size(338, 56);
            textBoxLogin.TabIndex = 1;
            textBoxLogin.TextOffset = new Point(0, -3);
            // 
            // pictureUser
            // 
            pictureUser.Anchor = AnchorStyles.None;
            pictureUser.BackColor = Color.Transparent;
            pictureUser.Image = Properties.Resources.Group_3;
            pictureUser.Location = new Point(114, 8);
            pictureUser.Name = "pictureUser";
            pictureUser.Size = new Size(212, 200);
            pictureUser.SizeMode = PictureBoxSizeMode.Zoom;
            pictureUser.TabIndex = 2;
            pictureUser.TabStop = false;
            // 
            // PageReg
            // 
            PageReg.BackColor = Color.White;
            PageReg.Location = new Point(4, 4);
            PageReg.Name = "PageReg";
            PageReg.Padding = new Padding(3);
            PageReg.Size = new Size(429, 613);
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
            FormCaptionButton.Location = new Point(954, -2);
            FormCaptionButton.Name = "FormCaptionButton";
            FormCaptionButton.ShowBorders = true;
            FormCaptionButton.Size = new Size(50, 40);
            FormCaptionButton.TabIndex = 3;
            FormCaptionButton.Click += FormCaptionButton_Click;
            // 
            // dragPanel
            // 
            dragPanel.BackColor = Color.Transparent;
            dragPanel.Controls.Add(FormCaptionButton);
            dragPanel.ForeColor = Color.Transparent;
            dragPanel.Location = new Point(0, 0);
            dragPanel.Name = "dragPanel";
            dragPanel.Size = new Size(1280, 38);
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
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 700);
            Controls.Add(panelLabel);
            Controls.Add(pictureCircle);
            Controls.Add(TabEntry);
            Controls.Add(dragPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EntryForm";
            Text = "EntryForm";
            FormClosing += EntryForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureCircle).EndInit();
            panelLabel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureLabel).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureFlower).EndInit();
            TabEntry.ResumeLayout(false);
            pageEntry.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureUser).EndInit();
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
        private PictureBox pictureUser;
        private Guna.UI2.WinForms.Guna2TextBox textBoxLogin;
        private Guna.UI2.WinForms.Guna2TextBox textBoxPassword;
    }
}