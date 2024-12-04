namespace BeautyLab.Tabs.Default_tabs
{
    partial class ReportControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            linkHome = new Label();
            txtReport = new Guna.UI2.WinForms.Guna2TextBox();
            SuspendLayout();
            // 
            // linkHome
            // 
            linkHome.AutoSize = true;
            linkHome.Font = new Font("Jura", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, 204);
            linkHome.ForeColor = Color.FromArgb(227, 89, 164);
            linkHome.Location = new Point(141, 287);
            linkHome.Name = "linkHome";
            linkHome.Size = new Size(957, 64);
            linkHome.TabIndex = 1;
            linkHome.Text = "Вы не совершили ни одного отчета...";
            // 
            // txtReport
            // 
            txtReport.CustomizableEdges = customizableEdges1;
            txtReport.DefaultText = "";
            txtReport.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtReport.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtReport.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtReport.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtReport.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtReport.Font = new Font("Segoe UI", 9F);
            txtReport.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtReport.Location = new Point(44, 25);
            txtReport.Name = "txtReport";
            txtReport.PasswordChar = '\0';
            txtReport.PlaceholderText = "";
            txtReport.SelectedText = "";
            txtReport.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtReport.Size = new Size(1179, 633);
            txtReport.TabIndex = 2;
            // 
            // ReportControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(txtReport);
            Controls.Add(linkHome);
            Name = "ReportControl";
            Size = new Size(1280, 689);
            Load += ReportControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label linkHome;
        private Guna.UI2.WinForms.Guna2TextBox txtReport;
    }
}
