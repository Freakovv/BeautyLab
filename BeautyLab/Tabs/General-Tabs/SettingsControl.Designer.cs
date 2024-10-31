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
            ProgressBarVolume = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            guna2TrackBar1 = new Guna.UI2.WinForms.Guna2TrackBar();
            SuspendLayout();
            // 
            // ProgressBarVolume
            // 
            ProgressBarVolume.AnimationSpeed = 0.1F;
            ProgressBarVolume.FillColor = Color.FromArgb(200, 213, 218, 223);
            ProgressBarVolume.Font = new Font("Segoe UI", 12F);
            ProgressBarVolume.ForeColor = Color.White;
            ProgressBarVolume.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            ProgressBarVolume.Image = (Image)resources.GetObject("ProgressBarVolume.Image");
            ProgressBarVolume.ImageSize = new Size(77, 77);
            ProgressBarVolume.Location = new Point(62, 75);
            ProgressBarVolume.Minimum = 0;
            ProgressBarVolume.Name = "ProgressBarVolume";
            ProgressBarVolume.ProgressColor = Color.FromArgb(227, 89, 164);
            ProgressBarVolume.ProgressColor2 = Color.FromArgb(255, 214, 236);
            ProgressBarVolume.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round;
            ProgressBarVolume.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round;
            ProgressBarVolume.ProgressThickness = 9;
            ProgressBarVolume.ShadowDecoration.CustomizableEdges = customizableEdges1;
            ProgressBarVolume.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            ProgressBarVolume.Size = new Size(99, 99);
            ProgressBarVolume.TabIndex = 1;
            ProgressBarVolume.Value = 25;
            // 
            // guna2TrackBar1
            // 
            guna2TrackBar1.Location = new Point(187, 108);
            guna2TrackBar1.Name = "guna2TrackBar1";
            guna2TrackBar1.Size = new Size(834, 23);
            guna2TrackBar1.TabIndex = 4;
            guna2TrackBar1.ThumbColor = Color.FromArgb(160, 113, 255);
            guna2TrackBar1.Scroll += guna2TrackBar1_Scroll;
            // 
            // SettingsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2TrackBar1);
            Controls.Add(ProgressBarVolume);
            Name = "SettingsControl";
            Size = new Size(1102, 689);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar ProgressBarVolume;
        private Guna.UI2.WinForms.Guna2TrackBar guna2TrackBar1;
    }
}
