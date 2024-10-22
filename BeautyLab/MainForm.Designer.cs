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
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            BorderForm = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            adminHome = new TabPage();
            bunifuPages1 = new Bunifu.UI.WinForms.BunifuPages();
            adminRecord = new TabPage();
            adminMaterial = new TabPage();
            adminReport = new TabPage();
            guna2ShadowPanel3 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            tabPage5 = new TabPage();
            guna2ShadowPanel4 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            tabPage6 = new TabPage();
            guna2ShadowPanel5 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            tabPage7 = new TabPage();
            guna2ShadowPanel6 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            tabPage8 = new TabPage();
            guna2ShadowPanel7 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            bunifuShadowPanel1 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            bunifuShadowPanel2 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            adminHome.SuspendLayout();
            bunifuPages1.SuspendLayout();
            adminRecord.SuspendLayout();
            adminMaterial.SuspendLayout();
            adminReport.SuspendLayout();
            tabPage5.SuspendLayout();
            tabPage6.SuspendLayout();
            tabPage7.SuspendLayout();
            tabPage8.SuspendLayout();
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
            // adminHome
            // 
            adminHome.BackgroundImage = (Image)resources.GetObject("adminHome.BackgroundImage");
            adminHome.BackgroundImageLayout = ImageLayout.Stretch;
            adminHome.Controls.Add(bunifuShadowPanel2);
            adminHome.Location = new Point(4, 4);
            adminHome.Name = "adminHome";
            adminHome.Padding = new Padding(3);
            adminHome.Size = new Size(1432, 772);
            adminHome.TabIndex = 0;
            adminHome.Text = "adminHome";
            adminHome.UseVisualStyleBackColor = true;
            // 
            // bunifuPages1
            // 
            bunifuPages1.Alignment = TabAlignment.Bottom;
            bunifuPages1.AllowTransitions = false;
            bunifuPages1.Controls.Add(adminHome);
            bunifuPages1.Controls.Add(adminRecord);
            bunifuPages1.Controls.Add(adminMaterial);
            bunifuPages1.Controls.Add(adminReport);
            bunifuPages1.Controls.Add(tabPage5);
            bunifuPages1.Controls.Add(tabPage6);
            bunifuPages1.Controls.Add(tabPage7);
            bunifuPages1.Controls.Add(tabPage8);
            bunifuPages1.Location = new Point(0, 0);
            bunifuPages1.Multiline = true;
            bunifuPages1.Name = "bunifuPages1";
            bunifuPages1.Page = adminMaterial;
            bunifuPages1.PageIndex = 2;
            bunifuPages1.PageName = "adminMaterial";
            bunifuPages1.PageTitle = "adminMaterial";
            bunifuPages1.SelectedIndex = 0;
            bunifuPages1.Size = new Size(1440, 800);
            bunifuPages1.TabIndex = 2;
            animation1.AnimateOnlyDifferences = false;
            animation1.BlindCoeff = (PointF)resources.GetObject("animation1.BlindCoeff");
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = (PointF)resources.GetObject("animation1.MosaicCoeff");
            animation1.MosaicShift = (PointF)resources.GetObject("animation1.MosaicShift");
            animation1.MosaicSize = 0;
            animation1.Padding = new Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = (PointF)resources.GetObject("animation1.ScaleCoeff");
            animation1.SlideCoeff = (PointF)resources.GetObject("animation1.SlideCoeff");
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            bunifuPages1.Transition = animation1;
            bunifuPages1.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // adminRecord
            // 
            adminRecord.BackgroundImage = (Image)resources.GetObject("adminRecord.BackgroundImage");
            adminRecord.BackgroundImageLayout = ImageLayout.Stretch;
            adminRecord.Controls.Add(bunifuShadowPanel1);
            adminRecord.Location = new Point(4, 4);
            adminRecord.Name = "adminRecord";
            adminRecord.Padding = new Padding(3);
            adminRecord.Size = new Size(1432, 772);
            adminRecord.TabIndex = 1;
            adminRecord.Text = "adminRecord";
            adminRecord.UseVisualStyleBackColor = true;
            // 
            // adminMaterial
            // 
            adminMaterial.BackgroundImage = (Image)resources.GetObject("adminMaterial.BackgroundImage");
            adminMaterial.BackgroundImageLayout = ImageLayout.Stretch;
            adminMaterial.Controls.Add(guna2ShadowPanel1);
            adminMaterial.Location = new Point(4, 4);
            adminMaterial.Name = "adminMaterial";
            adminMaterial.Padding = new Padding(3);
            adminMaterial.Size = new Size(1432, 772);
            adminMaterial.TabIndex = 2;
            adminMaterial.Text = "adminMaterial";
            adminMaterial.UseVisualStyleBackColor = true;
            // 
            // adminReport
            // 
            adminReport.BackgroundImage = (Image)resources.GetObject("adminReport.BackgroundImage");
            adminReport.BackgroundImageLayout = ImageLayout.Stretch;
            adminReport.Controls.Add(guna2ShadowPanel3);
            adminReport.Location = new Point(4, 4);
            adminReport.Name = "adminReport";
            adminReport.Padding = new Padding(3);
            adminReport.Size = new Size(1432, 772);
            adminReport.TabIndex = 3;
            adminReport.Text = "adminReport";
            adminReport.UseVisualStyleBackColor = true;
            // 
            // guna2ShadowPanel3
            // 
            guna2ShadowPanel3.BackColor = Color.Transparent;
            guna2ShadowPanel3.FillColor = Color.FromArgb(224, 224, 224);
            guna2ShadowPanel3.Location = new Point(-208, 70);
            guna2ShadowPanel3.Name = "guna2ShadowPanel3";
            guna2ShadowPanel3.Radius = 120;
            guna2ShadowPanel3.ShadowColor = Color.Black;
            guna2ShadowPanel3.Size = new Size(425, 609);
            guna2ShadowPanel3.TabIndex = 1;
            // 
            // tabPage5
            // 
            tabPage5.BackgroundImage = (Image)resources.GetObject("tabPage5.BackgroundImage");
            tabPage5.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage5.Controls.Add(guna2ShadowPanel4);
            tabPage5.Location = new Point(4, 4);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(1432, 772);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "tabPage5";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // guna2ShadowPanel4
            // 
            guna2ShadowPanel4.BackColor = Color.Transparent;
            guna2ShadowPanel4.FillColor = Color.FromArgb(224, 224, 224);
            guna2ShadowPanel4.Location = new Point(-208, 70);
            guna2ShadowPanel4.Name = "guna2ShadowPanel4";
            guna2ShadowPanel4.Radius = 120;
            guna2ShadowPanel4.ShadowColor = Color.Black;
            guna2ShadowPanel4.Size = new Size(425, 609);
            guna2ShadowPanel4.TabIndex = 1;
            // 
            // tabPage6
            // 
            tabPage6.BackgroundImage = (Image)resources.GetObject("tabPage6.BackgroundImage");
            tabPage6.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage6.Controls.Add(guna2ShadowPanel5);
            tabPage6.Location = new Point(4, 4);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(1432, 772);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "tabPage6";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // guna2ShadowPanel5
            // 
            guna2ShadowPanel5.BackColor = Color.Transparent;
            guna2ShadowPanel5.FillColor = Color.FromArgb(224, 224, 224);
            guna2ShadowPanel5.Location = new Point(-208, 70);
            guna2ShadowPanel5.Name = "guna2ShadowPanel5";
            guna2ShadowPanel5.Radius = 120;
            guna2ShadowPanel5.ShadowColor = Color.Black;
            guna2ShadowPanel5.Size = new Size(425, 609);
            guna2ShadowPanel5.TabIndex = 1;
            // 
            // tabPage7
            // 
            tabPage7.BackgroundImage = (Image)resources.GetObject("tabPage7.BackgroundImage");
            tabPage7.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage7.Controls.Add(guna2ShadowPanel6);
            tabPage7.Location = new Point(4, 4);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(3);
            tabPage7.Size = new Size(1432, 772);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "tabPage7";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // guna2ShadowPanel6
            // 
            guna2ShadowPanel6.BackColor = Color.Transparent;
            guna2ShadowPanel6.FillColor = Color.FromArgb(224, 224, 224);
            guna2ShadowPanel6.Location = new Point(-208, 70);
            guna2ShadowPanel6.Name = "guna2ShadowPanel6";
            guna2ShadowPanel6.Radius = 120;
            guna2ShadowPanel6.ShadowColor = Color.Black;
            guna2ShadowPanel6.Size = new Size(425, 609);
            guna2ShadowPanel6.TabIndex = 1;
            // 
            // tabPage8
            // 
            tabPage8.BackgroundImage = (Image)resources.GetObject("tabPage8.BackgroundImage");
            tabPage8.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage8.Controls.Add(guna2ShadowPanel7);
            tabPage8.Location = new Point(4, 4);
            tabPage8.Name = "tabPage8";
            tabPage8.Padding = new Padding(3);
            tabPage8.Size = new Size(1432, 772);
            tabPage8.TabIndex = 7;
            tabPage8.Text = "tabPage8";
            tabPage8.UseVisualStyleBackColor = true;
            // 
            // guna2ShadowPanel7
            // 
            guna2ShadowPanel7.BackColor = Color.Transparent;
            guna2ShadowPanel7.FillColor = Color.FromArgb(224, 224, 224);
            guna2ShadowPanel7.Location = new Point(-208, 70);
            guna2ShadowPanel7.Name = "guna2ShadowPanel7";
            guna2ShadowPanel7.Radius = 120;
            guna2ShadowPanel7.ShadowColor = Color.Black;
            guna2ShadowPanel7.Size = new Size(425, 609);
            guna2ShadowPanel7.TabIndex = 1;
            // 
            // bunifuShadowPanel1
            // 
            bunifuShadowPanel1.BackColor = Color.Transparent;
            bunifuShadowPanel1.BorderColor = Color.FromArgb(224, 224, 224);
            bunifuShadowPanel1.BorderRadius = 280;
            bunifuShadowPanel1.BorderThickness = 1;
            bunifuShadowPanel1.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            bunifuShadowPanel1.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            bunifuShadowPanel1.Location = new Point(-110, 79);
            bunifuShadowPanel1.Name = "bunifuShadowPanel1";
            bunifuShadowPanel1.PanelColor = Color.FromArgb(224, 224, 224);
            bunifuShadowPanel1.PanelColor2 = Color.FromArgb(224, 224, 224);
            bunifuShadowPanel1.ShadowColor = Color.Black;
            bunifuShadowPanel1.ShadowDept = 2;
            bunifuShadowPanel1.ShadowDepth = 5;
            bunifuShadowPanel1.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.ForwardDiagonal;
            bunifuShadowPanel1.ShadowTopLeftVisible = false;
            bunifuShadowPanel1.Size = new Size(593, 737);
            bunifuShadowPanel1.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            bunifuShadowPanel1.TabIndex = 2;
            // 
            // bunifuShadowPanel2
            // 
            bunifuShadowPanel2.BackColor = Color.Transparent;
            bunifuShadowPanel2.BorderColor = Color.FromArgb(224, 224, 224);
            bunifuShadowPanel2.BorderRadius = 260;
            bunifuShadowPanel2.BorderThickness = 0;
            bunifuShadowPanel2.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Gradient;
            bunifuShadowPanel2.ForeColor = Color.Transparent;
            bunifuShadowPanel2.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.ForwardDiagonal;
            bunifuShadowPanel2.Location = new Point(-208, 70);
            bunifuShadowPanel2.Name = "bunifuShadowPanel2";
            bunifuShadowPanel2.PanelColor = Color.FromArgb(224, 224, 224);
            bunifuShadowPanel2.PanelColor2 = Color.FromArgb(224, 230, 224);
            bunifuShadowPanel2.RightToLeft = RightToLeft.No;
            bunifuShadowPanel2.ShadowColor = Color.Black;
            bunifuShadowPanel2.ShadowDept = 2;
            bunifuShadowPanel2.ShadowDepth = 3;
            bunifuShadowPanel2.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            bunifuShadowPanel2.ShadowTopLeftVisible = false;
            bunifuShadowPanel2.Size = new Size(425, 609);
            bunifuShadowPanel2.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            bunifuShadowPanel2.TabIndex = 3;
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.FillColor = Color.FromArgb(224, 224, 224);
            guna2ShadowPanel1.Location = new Point(-208, 70);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.Radius = 120;
            guna2ShadowPanel1.ShadowColor = Color.Black;
            guna2ShadowPanel1.Size = new Size(425, 609);
            guna2ShadowPanel1.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1440, 800);
            Controls.Add(bunifuPages1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            Text = "BeautyLab";
            Load += MainForm_Load;
            adminHome.ResumeLayout(false);
            bunifuPages1.ResumeLayout(false);
            adminRecord.ResumeLayout(false);
            adminMaterial.ResumeLayout(false);
            adminReport.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            tabPage6.ResumeLayout(false);
            tabPage7.ResumeLayout(false);
            tabPage8.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm BorderForm;
        private Guna.UI2.WinForms.Guna2Elipse ElipsePanel;
        private Bunifu.UI.WinForms.BunifuPages bunifuPages1;
        private TabPage adminHome;
        private TabPage adminRecord;
        private TabPage adminMaterial;
        private TabPage adminReport;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel3;
        private TabPage tabPage5;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel4;
        private TabPage tabPage6;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel5;
        private TabPage tabPage7;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel6;
        private TabPage tabPage8;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel7;
        private Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel1;
        private Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel2;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
    }
}