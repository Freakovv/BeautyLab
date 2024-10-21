using System.Runtime.InteropServices;

namespace BeautyLab
{
    partial class MainForm
    {
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
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            BorderForm = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            panelBar = new Guna.UI2.WinForms.Guna2ShadowPanel();
            SuspendLayout();
            // 
            // BorderForm
            // 
            BorderForm.BorderRadius = 10;
            BorderForm.ContainerControl = this;
            BorderForm.DockIndicatorTransparencyValue = 0.6D;
            BorderForm.DragForm = false;
            BorderForm.TransparentWhileDrag = true;
            // 
            // panelBar
            // 
            panelBar.BackColor = Color.Transparent;
            panelBar.FillColor = Color.FromArgb(224, 224, 224);
            panelBar.Location = new Point(-213, 110);
            panelBar.Name = "panelBar";
            panelBar.Radius = 120;
            panelBar.ShadowColor = Color.Black;
            panelBar.Size = new Size(470, 592);
            panelBar.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1440, 800);
            Controls.Add(panelBar);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            Text = "BeautyLab";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm BorderForm;
        private Guna.UI2.WinForms.Guna2Elipse ElipsePanel;
        private Guna.UI2.WinForms.Guna2ShadowPanel panelBar;
    }
}