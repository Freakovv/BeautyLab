namespace BeautyLab
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
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
            Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            BorderForm = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            DragPanel = new Panel();
            btnExit = new Bunifu.UI.WinForms.BunifuFormCaptionButton();
            AdminLinks = new Panel();
            linkRecord = new Label();
            linkReport = new Label();
            linkHome = new Label();
            panelWindow = new Panel();
            DragControl = new Guna.UI2.WinForms.Guna2DragControl(components);
            MyMessage = new Guna.UI2.WinForms.Guna2MessageDialog();
            DragPanel.SuspendLayout();
            AdminLinks.SuspendLayout();
            SuspendLayout();
            // 
            // BorderForm
            // 
            BorderForm.BorderRadius = 10;
            BorderForm.ContainerControl = this;
            BorderForm.DockIndicatorTransparencyValue = 0.6D;
            BorderForm.TransparentWhileDrag = true;
            // 
            // DragPanel
            // 
            DragPanel.BackColor = Color.Transparent;
            DragPanel.Controls.Add(btnExit);
            DragPanel.Dock = DockStyle.Top;
            DragPanel.Location = new Point(0, 0);
            DragPanel.Name = "DragPanel";
            DragPanel.Size = new Size(1280, 30);
            DragPanel.TabIndex = 19;
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
            btnExit.BackgroundColor = Color.FromArgb(243, 243, 243);
            btnExit.BackHoverColor = Color.LightGray;
            btnExit.BackPressedColor = Color.Silver;
            btnExit.BorderColor = Color.LightGray;
            btnExit.BorderHoverColor = Color.FromArgb(243, 243, 243);
            btnExit.BorderPressedColor = Color.DarkGray;
            btnExit.BorderRadius = 1;
            btnExit.BorderStyle = Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderStyles.Solid;
            btnExit.BorderThickness = 1;
            btnExit.CaptionType = Bunifu.UI.WinForms.BunifuFormCaptionButton.CaptionTypes.Close;
            btnExit.ColorContrastOnClick = 30;
            btnExit.ColorContrastOnHover = 30;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            btnExit.CustomizableEdges = borderEdges1;
            btnExit.DefaultBorderColor = Color.LightGray;
            btnExit.DefaultColor = Color.FromArgb(243, 243, 243);
            btnExit.DialogResult = DialogResult.None;
            btnExit.IconColor = Color.Black;
            btnExit.IconHoverColor = Color.Red;
            btnExit.IconPressedColor = Color.Black;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageMargin = new Padding(1, 1, 0, 0);
            btnExit.ImageSize = new Size(20, 20);
            btnExit.Location = new Point(1241, -2);
            btnExit.Name = "btnExit";
            btnExit.ShowBorders = true;
            btnExit.Size = new Size(40, 32);
            btnExit.TabIndex = 2;
            btnExit.Click += btnExit_Click;
            // 
            // AdminLinks
            // 
            AdminLinks.BackColor = Color.Transparent;
            AdminLinks.Controls.Add(linkRecord);
            AdminLinks.Controls.Add(linkReport);
            AdminLinks.Controls.Add(linkHome);
            AdminLinks.Dock = DockStyle.Top;
            AdminLinks.Location = new Point(0, 30);
            AdminLinks.Name = "AdminLinks";
            AdminLinks.Size = new Size(1280, 41);
            AdminLinks.TabIndex = 20;
            // 
            // linkRecord
            // 
            linkRecord.AutoSize = true;
            linkRecord.Font = new Font("Jura", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 204);
            linkRecord.ForeColor = Color.FromArgb(227, 89, 164);
            linkRecord.Location = new Point(594, 3);
            linkRecord.Name = "linkRecord";
            linkRecord.Size = new Size(105, 31);
            linkRecord.TabIndex = 3;
            linkRecord.Text = "ЗАПИСЬ";
            linkRecord.Click += linkRecord_Click;
            // 
            // linkReport
            // 
            linkReport.AutoSize = true;
            linkReport.Font = new Font("Jura", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 204);
            linkReport.ForeColor = Color.FromArgb(227, 89, 164);
            linkReport.Location = new Point(787, 3);
            linkReport.Name = "linkReport";
            linkReport.Size = new Size(83, 31);
            linkReport.TabIndex = 1;
            linkReport.Text = "ОТЧЕТ";
            linkReport.Click += linkReport_Click;
            // 
            // linkHome
            // 
            linkHome.AutoSize = true;
            linkHome.Font = new Font("Jura", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 204);
            linkHome.ForeColor = Color.FromArgb(227, 89, 164);
            linkHome.Location = new Point(379, 3);
            linkHome.Name = "linkHome";
            linkHome.Size = new Size(119, 31);
            linkHome.TabIndex = 0;
            linkHome.Text = "ГЛАВНАЯ";
            linkHome.Click += linkHome_Click;
            // 
            // panelWindow
            // 
            panelWindow.BackColor = Color.Transparent;
            panelWindow.Dock = DockStyle.Fill;
            panelWindow.Location = new Point(0, 71);
            panelWindow.Name = "panelWindow";
            panelWindow.Size = new Size(1280, 689);
            panelWindow.TabIndex = 21;
            // 
            // DragControl
            // 
            DragControl.DockIndicatorTransparencyValue = 0.6D;
            DragControl.TargetControl = DragPanel;
            DragControl.TransparentWhileDrag = false;
            // 
            // MyMessage
            // 
            MyMessage.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            MyMessage.Caption = null;
            MyMessage.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            MyMessage.Parent = this;
            MyMessage.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            MyMessage.Text = null;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1280, 760);
            Controls.Add(panelWindow);
            Controls.Add(AdminLinks);
            Controls.Add(DragPanel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            Opacity = 0D;
            Text = "BeautyLab";
            Load += MainForm_Load;
            DragPanel.ResumeLayout(false);
            AdminLinks.ResumeLayout(false);
            AdminLinks.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public Guna.UI2.WinForms.Guna2BorderlessForm BorderForm;
        private Label linkHome;
        private Panel DragPanel;
        private Bunifu.UI.WinForms.BunifuFormCaptionButton btnExit;
        private Panel AdminLinks;
        private Label linkRecord;
        private Label linkReport;
        private Panel panelWindow;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private Guna.UI2.WinForms.Guna2MessageDialog MyMessage;
    }
}