namespace BeautyLab
{
    partial class VerificationForm
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerificationForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            BorderForm = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            txtCode = new Guna.UI2.WinForms.Guna2TextBox();
            btnEnter = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            btnCancel = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            labelError = new Label();
            SuspendLayout();
            // 
            // BorderForm
            // 
            BorderForm.AnimateWindow = true;
            BorderForm.BorderRadius = 25;
            BorderForm.ContainerControl = this;
            BorderForm.DockIndicatorTransparencyValue = 0.6D;
            BorderForm.DragForm = false;
            // 
            // txtCode
            // 
            txtCode.AcceptsReturn = true;
            txtCode.Animated = true;
            txtCode.BackColor = Color.Transparent;
            txtCode.BorderRadius = 25;
            txtCode.CustomizableEdges = customizableEdges1;
            txtCode.DefaultText = "";
            txtCode.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtCode.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtCode.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtCode.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtCode.FillColor = Color.FromArgb(239, 239, 239);
            txtCode.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCode.Font = new Font("Jura", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtCode.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCode.IconLeft = (Image)resources.GetObject("txtCode.IconLeft");
            txtCode.IconLeftOffset = new Point(15, 0);
            txtCode.Location = new Point(33, 45);
            txtCode.Margin = new Padding(24, 25, 24, 25);
            txtCode.MaxLength = 6;
            txtCode.Name = "txtCode";
            txtCode.PasswordChar = '\0';
            txtCode.PlaceholderForeColor = Color.FromArgb(135, 128, 128);
            txtCode.PlaceholderText = "Код";
            txtCode.SelectedText = "";
            txtCode.ShadowDecoration.BorderRadius = 150;
            txtCode.ShadowDecoration.Color = Color.FromArgb(135, 128, 128);
            txtCode.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtCode.ShadowDecoration.Depth = 21;
            txtCode.ShadowDecoration.Enabled = true;
            txtCode.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            txtCode.ShadowDecoration.Shadow = new Padding(2, 0, 2, 5);
            txtCode.Size = new Size(244, 46);
            txtCode.TabIndex = 15;
            txtCode.TextOffset = new Point(0, -3);
            txtCode.TextChanged += txtCode_TextChanged;
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
            btnEnter.ButtonText = "Ввести";
            btnEnter.ButtonTextMarginLeft = 0;
            btnEnter.ColorContrastOnClick = 45;
            btnEnter.ColorContrastOnHover = 45;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            btnEnter.CustomizableEdges = borderEdges2;
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
            btnEnter.Location = new Point(143, 108);
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
            btnEnter.Size = new Size(134, 50);
            btnEnter.TabIndex = 20;
            btnEnter.TextAlign = ContentAlignment.MiddleCenter;
            btnEnter.TextAlignment = HorizontalAlignment.Center;
            btnEnter.TextMarginLeft = 0;
            btnEnter.TextPadding = new Padding(0, -2, 0, 0);
            btnEnter.UseDefaultRadiusAndThickness = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // btnCancel
            // 
            btnCancel.AllowAnimations = true;
            btnCancel.AllowMouseEffects = true;
            btnCancel.AllowToggling = false;
            btnCancel.AnimationSpeed = 200;
            btnCancel.AutoGenerateColors = false;
            btnCancel.AutoRoundBorders = false;
            btnCancel.AutoSizeLeftIcon = true;
            btnCancel.AutoSizeRightIcon = true;
            btnCancel.BackColor = Color.Transparent;
            btnCancel.BackColor1 = Color.White;
            btnCancel.BackgroundImage = (Image)resources.GetObject("btnCancel.BackgroundImage");
            btnCancel.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnCancel.ButtonText = "Отмена";
            btnCancel.ButtonTextMarginLeft = 0;
            btnCancel.ColorContrastOnClick = 45;
            btnCancel.ColorContrastOnHover = 45;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            btnCancel.CustomizableEdges = borderEdges1;
            btnCancel.DialogResult = DialogResult.None;
            btnCancel.DisabledBorderColor = Color.Empty;
            btnCancel.DisabledFillColor = Color.FromArgb(242, 220, 232);
            btnCancel.DisabledForecolor = Color.White;
            btnCancel.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Idle;
            btnCancel.Font = new Font("Jura", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnCancel.ForeColor = Color.Black;
            btnCancel.IconLeftAlign = ContentAlignment.MiddleLeft;
            btnCancel.IconLeftCursor = Cursors.Default;
            btnCancel.IconLeftPadding = new Padding(11, 3, 3, 3);
            btnCancel.IconMarginLeft = 11;
            btnCancel.IconPadding = 10;
            btnCancel.IconRightAlign = ContentAlignment.MiddleRight;
            btnCancel.IconRightCursor = Cursors.Default;
            btnCancel.IconRightPadding = new Padding(3, 3, 7, 3);
            btnCancel.IconSize = 25;
            btnCancel.IdleBorderColor = Color.FromArgb(227, 89, 164);
            btnCancel.IdleBorderRadius = 50;
            btnCancel.IdleBorderThickness = 1;
            btnCancel.IdleFillColor = Color.White;
            btnCancel.IdleIconLeftImage = null;
            btnCancel.IdleIconRightImage = null;
            btnCancel.IndicateFocus = false;
            btnCancel.Location = new Point(33, 108);
            btnCancel.Name = "btnCancel";
            btnCancel.OnDisabledState.BorderColor = Color.Empty;
            btnCancel.OnDisabledState.BorderRadius = 50;
            btnCancel.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnCancel.OnDisabledState.BorderThickness = 0;
            btnCancel.OnDisabledState.FillColor = Color.FromArgb(242, 220, 232);
            btnCancel.OnDisabledState.ForeColor = Color.White;
            btnCancel.OnDisabledState.IconLeftImage = null;
            btnCancel.OnDisabledState.IconRightImage = null;
            btnCancel.onHoverState.BorderColor = Color.Empty;
            btnCancel.onHoverState.BorderRadius = 50;
            btnCancel.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnCancel.onHoverState.BorderThickness = 0;
            btnCancel.onHoverState.FillColor = Color.FromArgb(240, 100, 200);
            btnCancel.onHoverState.ForeColor = Color.White;
            btnCancel.onHoverState.IconLeftImage = null;
            btnCancel.onHoverState.IconRightImage = null;
            btnCancel.OnIdleState.BorderColor = Color.FromArgb(227, 89, 164);
            btnCancel.OnIdleState.BorderRadius = 50;
            btnCancel.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnCancel.OnIdleState.BorderThickness = 0;
            btnCancel.OnIdleState.FillColor = Color.White;
            btnCancel.OnIdleState.ForeColor = Color.Black;
            btnCancel.OnIdleState.IconLeftImage = null;
            btnCancel.OnIdleState.IconRightImage = null;
            btnCancel.OnPressedState.BorderColor = Color.Empty;
            btnCancel.OnPressedState.BorderRadius = 50;
            btnCancel.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnCancel.OnPressedState.BorderThickness = 0;
            btnCancel.OnPressedState.FillColor = Color.FromArgb(230, 80, 170);
            btnCancel.OnPressedState.ForeColor = Color.White;
            btnCancel.OnPressedState.IconLeftImage = null;
            btnCancel.OnPressedState.IconRightImage = null;
            btnCancel.Size = new Size(99, 50);
            btnCancel.TabIndex = 21;
            btnCancel.TextAlign = ContentAlignment.MiddleCenter;
            btnCancel.TextAlignment = HorizontalAlignment.Center;
            btnCancel.TextMarginLeft = 0;
            btnCancel.TextPadding = new Padding(0, -2, 0, 0);
            btnCancel.UseDefaultRadiusAndThickness = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.Font = new Font("Jura", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelError.ForeColor = Color.Black;
            labelError.Location = new Point(98, 9);
            labelError.Name = "labelError";
            labelError.Size = new Size(98, 20);
            labelError.TabIndex = 22;
            labelError.Text = "Введите код";
            labelError.TextChanged += labelError_TextChanged;
            // 
            // VerificationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(303, 181);
            Controls.Add(labelError);
            Controls.Add(btnCancel);
            Controls.Add(btnEnter);
            Controls.Add(txtCode);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VerificationForm";
            Text = "VerificationForm";
            Load += VerificationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm BorderForm;
        private Guna.UI2.WinForms.Guna2TextBox txtCode;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnCancel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnEnter;
        private Label labelError;

        private void labelError_TextChanged(object sender, EventArgs e)
        {
            CenterLabel();
        }
        private void CenterLabel()
        {
            labelError.Left = (this.ClientSize.Width - labelError.Width) / 2;
        }
        private void VerificationForm_Load(object sender, EventArgs e)
        {
            CenterLabel();
        }

    }
}