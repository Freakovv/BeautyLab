namespace AdminPanel
{
    partial class Entry
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entry));
            txtKey = new Guna.UI2.WinForms.Guna2TextBox();
            borderForm = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            labelKey = new Label();
            btnEnter = new Guna.UI2.WinForms.Guna2Button();
            msg = new Guna.UI2.WinForms.Guna2MessageDialog();
            labelVersion = new Label();
            SuspendLayout();
            // 
            // txtKey
            // 
            txtKey.Animated = true;
            txtKey.CustomizableEdges = customizableEdges1;
            txtKey.DefaultText = "";
            txtKey.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtKey.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtKey.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtKey.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtKey.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtKey.Font = new Font("Segoe UI", 9F);
            txtKey.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtKey.Location = new Point(91, 149);
            txtKey.MaxLength = 10;
            txtKey.Name = "txtKey";
            txtKey.PasswordChar = '●';
            txtKey.PlaceholderText = "";
            txtKey.SelectedText = "";
            txtKey.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtKey.Size = new Size(200, 36);
            txtKey.TabIndex = 0;
            txtKey.UseSystemPasswordChar = true;
            // 
            // borderForm
            // 
            borderForm.AnimateWindow = true;
            borderForm.BorderRadius = 15;
            borderForm.ContainerControl = this;
            borderForm.DockIndicatorTransparencyValue = 0.6D;
            borderForm.TransparentWhileDrag = true;
            // 
            // labelKey
            // 
            labelKey.AutoSize = true;
            labelKey.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelKey.Location = new Point(165, 103);
            labelKey.Name = "labelKey";
            labelKey.Size = new Size(46, 25);
            labelKey.TabIndex = 1;
            labelKey.Text = "Key:";
            // 
            // btnEnter
            // 
            btnEnter.CustomizableEdges = customizableEdges3;
            btnEnter.DisabledState.BorderColor = Color.DarkGray;
            btnEnter.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEnter.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEnter.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEnter.FillColor = SystemColors.ActiveCaption;
            btnEnter.Font = new Font("Segoe UI", 9F);
            btnEnter.ForeColor = Color.White;
            btnEnter.Location = new Point(119, 212);
            btnEnter.Name = "btnEnter";
            btnEnter.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnEnter.Size = new Size(146, 38);
            btnEnter.TabIndex = 2;
            btnEnter.Text = "Войти";
            btnEnter.Click += btnEnter_Click;
            // 
            // msg
            // 
            msg.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            msg.Caption = null;
            msg.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            msg.Parent = this;
            msg.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            msg.Text = null;
            // 
            // labelVersion
            // 
            labelVersion.AutoSize = true;
            labelVersion.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelVersion.ForeColor = SystemColors.ControlDark;
            labelVersion.Location = new Point(319, 332);
            labelVersion.Name = "labelVersion";
            labelVersion.Size = new Size(53, 20);
            labelVersion.TabIndex = 3;
            labelVersion.Text = "v. 0.0.1";
            // 
            // Entry
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 361);
            Controls.Add(labelVersion);
            Controls.Add(btnEnter);
            Controls.Add(labelKey);
            Controls.Add(txtKey);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Entry";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Entry";
            FormClosing += Entry_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtKey;
        private Guna.UI2.WinForms.Guna2BorderlessForm borderForm;
        private Guna.UI2.WinForms.Guna2Button btnEnter;
        private Label labelKey;
        private Guna.UI2.WinForms.Guna2MessageDialog msg;
        private Label labelVersion;
    }
}