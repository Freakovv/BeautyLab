namespace BeautyLab.Tabs.General_Tabs
{
    partial class SettingsControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsControl));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            ProgressVolume = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            TrackVolume = new Guna.UI2.WinForms.Guna2TrackBar();
            TrackBorder = new Guna.UI2.WinForms.Guna2TrackBar();
            ProgressBorder = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            textVolume = new Label();
            textBorder = new Label();
            btnSave = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            SHADOWBUTTON = new Guna.UI2.WinForms.Guna2GradientButton();
            btnReset = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            SHADOWBUTTON1 = new Guna.UI2.WinForms.Guna2GradientButton();
            SuspendLayout();
            // 
            // ProgressVolume
            // 
            ProgressVolume.AnimationSpeed = 0.1F;
            ProgressVolume.FillColor = Color.FromArgb(200, 213, 218, 223);
            ProgressVolume.Font = new Font("Segoe UI", 12F);
            ProgressVolume.ForeColor = Color.White;
            ProgressVolume.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            ProgressVolume.Image = (Image)resources.GetObject("ProgressVolume.Image");
            ProgressVolume.ImageSize = new Size(77, 77);
            ProgressVolume.Location = new Point(58, 132);
            ProgressVolume.Minimum = 0;
            ProgressVolume.Name = "ProgressVolume";
            ProgressVolume.ProgressColor = Color.FromArgb(227, 89, 164);
            ProgressVolume.ProgressColor2 = Color.FromArgb(255, 214, 236);
            ProgressVolume.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round;
            ProgressVolume.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round;
            ProgressVolume.ProgressThickness = 9;
            ProgressVolume.ShadowDecoration.CustomizableEdges = customizableEdges1;
            ProgressVolume.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            ProgressVolume.Size = new Size(99, 99);
            ProgressVolume.TabIndex = 1;
            ProgressVolume.Value = 5;
            // 
            // TrackVolume
            // 
            TrackVolume.FillColor = Color.FromArgb(255, 214, 236);
            TrackVolume.LargeChange = 1;
            TrackVolume.Location = new Point(183, 165);
            TrackVolume.Name = "TrackVolume";
            TrackVolume.Size = new Size(834, 23);
            TrackVolume.TabIndex = 4;
            TrackVolume.ThumbColor = Color.FromArgb(227, 89, 164);
            TrackVolume.Value = 5;
            TrackVolume.ValueChanged += TrackVolume_ValueChanged;
            // 
            // TrackBorder
            // 
            TrackBorder.FillColor = Color.FromArgb(255, 214, 236);
            TrackBorder.LargeChange = 1;
            TrackBorder.Location = new Point(183, 283);
            TrackBorder.Maximum = 35;
            TrackBorder.Name = "TrackBorder";
            TrackBorder.Size = new Size(834, 23);
            TrackBorder.TabIndex = 8;
            TrackBorder.ThumbColor = Color.FromArgb(227, 89, 164);
            TrackBorder.Value = 15;
            TrackBorder.ValueChanged += TrackBorder_ValueChanged;
            // 
            // ProgressBorder
            // 
            ProgressBorder.FillColor = Color.FromArgb(200, 213, 218, 223);
            ProgressBorder.Font = new Font("Segoe UI", 12F);
            ProgressBorder.ForeColor = Color.White;
            ProgressBorder.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            ProgressBorder.Image = (Image)resources.GetObject("ProgressBorder.Image");
            ProgressBorder.ImageSize = new Size(77, 77);
            ProgressBorder.Location = new Point(58, 250);
            ProgressBorder.Minimum = 0;
            ProgressBorder.Name = "ProgressBorder";
            ProgressBorder.ProgressColor = Color.FromArgb(227, 89, 164);
            ProgressBorder.ProgressColor2 = Color.FromArgb(255, 214, 236);
            ProgressBorder.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round;
            ProgressBorder.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round;
            ProgressBorder.ProgressThickness = 9;
            ProgressBorder.ShadowDecoration.CustomizableEdges = customizableEdges2;
            ProgressBorder.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            ProgressBorder.Size = new Size(99, 99);
            ProgressBorder.TabIndex = 7;
            ProgressBorder.Value = 10;
            // 
            // textVolume
            // 
            textVolume.AutoSize = true;
            textVolume.BackColor = Color.Transparent;
            textVolume.Font = new Font("Jura", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textVolume.ForeColor = Color.FromArgb(227, 89, 164);
            textVolume.Location = new Point(1032, 163);
            textVolume.Name = "textVolume";
            textVolume.Size = new Size(42, 25);
            textVolume.TabIndex = 34;
            textVolume.Text = "5%";
            textVolume.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBorder
            // 
            textBorder.AutoSize = true;
            textBorder.BackColor = Color.Transparent;
            textBorder.Font = new Font("Jura", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBorder.ForeColor = Color.FromArgb(227, 89, 164);
            textBorder.Location = new Point(1032, 281);
            textBorder.Name = "textBorder";
            textBorder.Size = new Size(49, 25);
            textBorder.TabIndex = 35;
            textBorder.Text = "10%";
            textBorder.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            btnSave.AllowAnimations = true;
            btnSave.AllowMouseEffects = true;
            btnSave.AllowToggling = false;
            btnSave.AnimationSpeed = 200;
            btnSave.AutoGenerateColors = false;
            btnSave.AutoRoundBorders = false;
            btnSave.AutoSizeLeftIcon = true;
            btnSave.AutoSizeRightIcon = true;
            btnSave.BackColor = Color.Transparent;
            btnSave.BackColor1 = Color.FromArgb(227, 89, 164);
            btnSave.BackgroundImage = (Image)resources.GetObject("btnSave.BackgroundImage");
            btnSave.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnSave.ButtonText = "Сохранить";
            btnSave.ButtonTextMarginLeft = 0;
            btnSave.ColorContrastOnClick = 45;
            btnSave.ColorContrastOnHover = 45;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            btnSave.CustomizableEdges = borderEdges1;
            btnSave.DialogResult = DialogResult.None;
            btnSave.DisabledBorderColor = Color.Empty;
            btnSave.DisabledFillColor = Color.FromArgb(242, 220, 232);
            btnSave.DisabledForecolor = Color.White;
            btnSave.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Idle;
            btnSave.Font = new Font("Jura", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnSave.ForeColor = Color.White;
            btnSave.IconLeftAlign = ContentAlignment.MiddleLeft;
            btnSave.IconLeftCursor = Cursors.Default;
            btnSave.IconLeftPadding = new Padding(11, 3, 3, 3);
            btnSave.IconMarginLeft = 11;
            btnSave.IconPadding = 10;
            btnSave.IconRightAlign = ContentAlignment.MiddleRight;
            btnSave.IconRightCursor = Cursors.Default;
            btnSave.IconRightPadding = new Padding(3, 3, 7, 3);
            btnSave.IconSize = 25;
            btnSave.IdleBorderColor = Color.Empty;
            btnSave.IdleBorderRadius = 50;
            btnSave.IdleBorderThickness = 1;
            btnSave.IdleFillColor = Color.FromArgb(227, 89, 164);
            btnSave.IdleIconLeftImage = null;
            btnSave.IdleIconRightImage = null;
            btnSave.IndicateFocus = false;
            btnSave.Location = new Point(849, 367);
            btnSave.Name = "btnSave";
            btnSave.OnDisabledState.BorderColor = Color.Empty;
            btnSave.OnDisabledState.BorderRadius = 50;
            btnSave.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnSave.OnDisabledState.BorderThickness = 0;
            btnSave.OnDisabledState.FillColor = Color.FromArgb(242, 220, 232);
            btnSave.OnDisabledState.ForeColor = Color.White;
            btnSave.OnDisabledState.IconLeftImage = null;
            btnSave.OnDisabledState.IconRightImage = null;
            btnSave.onHoverState.BorderColor = Color.Empty;
            btnSave.onHoverState.BorderRadius = 50;
            btnSave.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnSave.onHoverState.BorderThickness = 0;
            btnSave.onHoverState.FillColor = Color.FromArgb(240, 100, 200);
            btnSave.onHoverState.ForeColor = Color.White;
            btnSave.onHoverState.IconLeftImage = null;
            btnSave.onHoverState.IconRightImage = null;
            btnSave.OnIdleState.BorderColor = Color.Empty;
            btnSave.OnIdleState.BorderRadius = 50;
            btnSave.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnSave.OnIdleState.BorderThickness = 0;
            btnSave.OnIdleState.FillColor = Color.FromArgb(227, 89, 164);
            btnSave.OnIdleState.ForeColor = Color.White;
            btnSave.OnIdleState.IconLeftImage = null;
            btnSave.OnIdleState.IconRightImage = null;
            btnSave.OnPressedState.BorderColor = Color.Empty;
            btnSave.OnPressedState.BorderRadius = 50;
            btnSave.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnSave.OnPressedState.BorderThickness = 0;
            btnSave.OnPressedState.FillColor = Color.FromArgb(230, 80, 170);
            btnSave.OnPressedState.ForeColor = Color.White;
            btnSave.OnPressedState.IconLeftImage = null;
            btnSave.OnPressedState.IconRightImage = null;
            btnSave.Size = new Size(168, 50);
            btnSave.TabIndex = 37;
            btnSave.TextAlign = ContentAlignment.MiddleCenter;
            btnSave.TextAlignment = HorizontalAlignment.Center;
            btnSave.TextMarginLeft = 0;
            btnSave.TextPadding = new Padding(0, -2, 0, 0);
            btnSave.UseDefaultRadiusAndThickness = true;
            btnSave.Click += btnSave_Click;
            // 
            // SHADOWBUTTON
            // 
            SHADOWBUTTON.Animated = true;
            SHADOWBUTTON.BackColor = Color.Transparent;
            SHADOWBUTTON.BackgroundImageLayout = ImageLayout.Stretch;
            SHADOWBUTTON.BorderRadius = 25;
            SHADOWBUTTON.CustomizableEdges = customizableEdges3;
            SHADOWBUTTON.DisabledState.BorderColor = Color.DarkGray;
            SHADOWBUTTON.DisabledState.CustomBorderColor = Color.DarkGray;
            SHADOWBUTTON.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            SHADOWBUTTON.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            SHADOWBUTTON.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            SHADOWBUTTON.FillColor = Color.FromArgb(227, 89, 164);
            SHADOWBUTTON.FillColor2 = Color.FromArgb(222, 89, 227);
            SHADOWBUTTON.Font = new Font("Jura", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SHADOWBUTTON.ForeColor = Color.White;
            SHADOWBUTTON.Location = new Point(849, 367);
            SHADOWBUTTON.Margin = new Padding(3, 2, 3, 2);
            SHADOWBUTTON.Name = "SHADOWBUTTON";
            SHADOWBUTTON.ShadowDecoration.CustomizableEdges = customizableEdges4;
            SHADOWBUTTON.ShadowDecoration.Enabled = true;
            SHADOWBUTTON.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            SHADOWBUTTON.ShadowDecoration.Shadow = new Padding(1, 1, 1, 3);
            SHADOWBUTTON.Size = new Size(168, 50);
            SHADOWBUTTON.TabIndex = 36;
            SHADOWBUTTON.Text = "Сохранить";
            SHADOWBUTTON.TextOffset = new Point(0, -3);
            // 
            // btnReset
            // 
            btnReset.AllowAnimations = true;
            btnReset.AllowMouseEffects = true;
            btnReset.AllowToggling = false;
            btnReset.AnimationSpeed = 200;
            btnReset.AutoGenerateColors = false;
            btnReset.AutoRoundBorders = false;
            btnReset.AutoSizeLeftIcon = true;
            btnReset.AutoSizeRightIcon = true;
            btnReset.BackColor = Color.Transparent;
            btnReset.BackColor1 = Color.FromArgb(225, 214, 236);
            btnReset.BackgroundImage = (Image)resources.GetObject("btnReset.BackgroundImage");
            btnReset.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnReset.ButtonText = "Сброс";
            btnReset.ButtonTextMarginLeft = 0;
            btnReset.ColorContrastOnClick = 45;
            btnReset.ColorContrastOnHover = 45;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            btnReset.CustomizableEdges = borderEdges2;
            btnReset.DialogResult = DialogResult.None;
            btnReset.DisabledBorderColor = Color.Empty;
            btnReset.DisabledFillColor = Color.FromArgb(242, 220, 232);
            btnReset.DisabledForecolor = Color.White;
            btnReset.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Idle;
            btnReset.Font = new Font("Jura", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnReset.ForeColor = Color.White;
            btnReset.IconLeftAlign = ContentAlignment.MiddleLeft;
            btnReset.IconLeftCursor = Cursors.Default;
            btnReset.IconLeftPadding = new Padding(11, 3, 3, 3);
            btnReset.IconMarginLeft = 11;
            btnReset.IconPadding = 10;
            btnReset.IconRightAlign = ContentAlignment.MiddleRight;
            btnReset.IconRightCursor = Cursors.Default;
            btnReset.IconRightPadding = new Padding(3, 3, 7, 3);
            btnReset.IconSize = 25;
            btnReset.IdleBorderColor = Color.FromArgb(227, 89, 164);
            btnReset.IdleBorderRadius = 50;
            btnReset.IdleBorderThickness = 1;
            btnReset.IdleFillColor = Color.FromArgb(225, 214, 236);
            btnReset.IdleIconLeftImage = null;
            btnReset.IdleIconRightImage = null;
            btnReset.IndicateFocus = false;
            btnReset.Location = new Point(699, 367);
            btnReset.Name = "btnReset";
            btnReset.OnDisabledState.BorderColor = Color.Empty;
            btnReset.OnDisabledState.BorderRadius = 50;
            btnReset.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnReset.OnDisabledState.BorderThickness = 0;
            btnReset.OnDisabledState.FillColor = Color.FromArgb(242, 220, 232);
            btnReset.OnDisabledState.ForeColor = Color.White;
            btnReset.OnDisabledState.IconLeftImage = null;
            btnReset.OnDisabledState.IconRightImage = null;
            btnReset.onHoverState.BorderColor = Color.Empty;
            btnReset.onHoverState.BorderRadius = 50;
            btnReset.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnReset.onHoverState.BorderThickness = 0;
            btnReset.onHoverState.FillColor = Color.FromArgb(240, 100, 200);
            btnReset.onHoverState.ForeColor = Color.White;
            btnReset.onHoverState.IconLeftImage = null;
            btnReset.onHoverState.IconRightImage = null;
            btnReset.OnIdleState.BorderColor = Color.FromArgb(227, 89, 164);
            btnReset.OnIdleState.BorderRadius = 50;
            btnReset.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnReset.OnIdleState.BorderThickness = 0;
            btnReset.OnIdleState.FillColor = Color.FromArgb(225, 214, 236);
            btnReset.OnIdleState.ForeColor = Color.White;
            btnReset.OnIdleState.IconLeftImage = null;
            btnReset.OnIdleState.IconRightImage = null;
            btnReset.OnPressedState.BorderColor = Color.Empty;
            btnReset.OnPressedState.BorderRadius = 50;
            btnReset.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnReset.OnPressedState.BorderThickness = 0;
            btnReset.OnPressedState.FillColor = Color.FromArgb(230, 80, 170);
            btnReset.OnPressedState.ForeColor = Color.White;
            btnReset.OnPressedState.IconLeftImage = null;
            btnReset.OnPressedState.IconRightImage = null;
            btnReset.Size = new Size(144, 50);
            btnReset.TabIndex = 39;
            btnReset.TextAlign = ContentAlignment.MiddleCenter;
            btnReset.TextAlignment = HorizontalAlignment.Center;
            btnReset.TextMarginLeft = 0;
            btnReset.TextPadding = new Padding(0, -2, 0, 0);
            btnReset.UseDefaultRadiusAndThickness = true;
            btnReset.Click += btnReset_Click;
            // 
            // SHADOWBUTTON1
            // 
            SHADOWBUTTON1.Animated = true;
            SHADOWBUTTON1.BackColor = Color.Transparent;
            SHADOWBUTTON1.BackgroundImageLayout = ImageLayout.Stretch;
            SHADOWBUTTON1.BorderRadius = 25;
            SHADOWBUTTON1.CustomizableEdges = customizableEdges5;
            SHADOWBUTTON1.DisabledState.BorderColor = Color.DarkGray;
            SHADOWBUTTON1.DisabledState.CustomBorderColor = Color.DarkGray;
            SHADOWBUTTON1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            SHADOWBUTTON1.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            SHADOWBUTTON1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            SHADOWBUTTON1.FillColor = Color.FromArgb(227, 89, 164);
            SHADOWBUTTON1.FillColor2 = Color.FromArgb(222, 89, 227);
            SHADOWBUTTON1.Font = new Font("Jura", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SHADOWBUTTON1.ForeColor = Color.White;
            SHADOWBUTTON1.Location = new Point(699, 367);
            SHADOWBUTTON1.Margin = new Padding(3, 2, 3, 2);
            SHADOWBUTTON1.Name = "SHADOWBUTTON1";
            SHADOWBUTTON1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            SHADOWBUTTON1.ShadowDecoration.Enabled = true;
            SHADOWBUTTON1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            SHADOWBUTTON1.ShadowDecoration.Shadow = new Padding(1, 1, 1, 3);
            SHADOWBUTTON1.Size = new Size(144, 50);
            SHADOWBUTTON1.TabIndex = 38;
            SHADOWBUTTON1.Text = "Сохранить";
            SHADOWBUTTON1.TextOffset = new Point(0, -3);
            // 
            // SettingsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(btnReset);
            Controls.Add(SHADOWBUTTON1);
            Controls.Add(btnSave);
            Controls.Add(SHADOWBUTTON);
            Controls.Add(textBorder);
            Controls.Add(textVolume);
            Controls.Add(TrackBorder);
            Controls.Add(ProgressBorder);
            Controls.Add(TrackVolume);
            Controls.Add(ProgressVolume);
            Name = "SettingsControl";
            Size = new Size(1102, 689);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleProgressBar ProgressVolume;
        private Guna.UI2.WinForms.Guna2TrackBar TrackVolume;
        private Guna.UI2.WinForms.Guna2TrackBar TrackBorder;
        private Guna.UI2.WinForms.Guna2CircleProgressBar ProgressBorder;
        private Label textVolume;
        private Label textBorder;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnSave;
        private Guna.UI2.WinForms.Guna2GradientButton SHADOWBUTTON;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnReset;
        private Guna.UI2.WinForms.Guna2GradientButton SHADOWBUTTON1;
    }
}
