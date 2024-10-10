namespace BeautyLab
{
    partial class BeginAnimation
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
            timer_animation = new System.Windows.Forms.Timer(components);
            pictureFlower = new Guna.UI2.WinForms.Guna2PictureBox();
            pictureBeautyLab = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureFlower).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBeautyLab).BeginInit();
            SuspendLayout();
            // 
            // timer_animation
            // 
            timer_animation.Interval = 5;
            timer_animation.Tick += timer_animation_Tick;
            // 
            // pictureFlower
            // 
            pictureFlower.Anchor = AnchorStyles.None;
            pictureFlower.BackColor = Color.Transparent;
            pictureFlower.CustomizableEdges = customizableEdges1;
            pictureFlower.Image = Properties.Resources.icons8_цветок_64;
            pictureFlower.ImageRotate = 0F;
            pictureFlower.Location = new Point(135, 100);
            pictureFlower.Name = "pictureFlower";
            pictureFlower.ShadowDecoration.CustomizableEdges = customizableEdges2;
            pictureFlower.Size = new Size(80, 72);
            pictureFlower.TabIndex = 3;
            pictureFlower.TabStop = false;
            pictureFlower.UseTransparentBackground = true;
            // 
            // pictureBeautyLab
            // 
            pictureBeautyLab.Anchor = AnchorStyles.None;
            pictureBeautyLab.BackColor = Color.Transparent;
            pictureBeautyLab.CustomizableEdges = customizableEdges3;
            pictureBeautyLab.Image = Properties.Resources.BeautyLab;
            pictureBeautyLab.ImageRotate = 0F;
            pictureBeautyLab.Location = new Point(221, 107);
            pictureBeautyLab.Name = "pictureBeautyLab";
            pictureBeautyLab.ShadowDecoration.CustomizableEdges = customizableEdges4;
            pictureBeautyLab.Size = new Size(312, 60);
            pictureBeautyLab.TabIndex = 2;
            pictureBeautyLab.TabStop = false;
            pictureBeautyLab.UseTransparentBackground = true;
            // 
            // BeginAnimation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Black;
            ClientSize = new Size(670, 300);
            Controls.Add(pictureFlower);
            Controls.Add(pictureBeautyLab);
            ForeColor = Color.Transparent;
            FormBorderStyle = FormBorderStyle.None;
            Name = "BeginAnimation";
            Opacity = 0D;
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BeginAnimation";
            TopMost = true;
            TransparencyKey = Color.Black;
            FormClosing += BeginAnimation_FormClosing;
            Load += BeginAnimation_Load;
            ((System.ComponentModel.ISupportInitialize)pictureFlower).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBeautyLab).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timer_animation;
        private Guna.UI2.WinForms.Guna2PictureBox pictureFlower;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBeautyLab;
    }
}