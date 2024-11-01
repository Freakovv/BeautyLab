using System;
using System.Windows.Forms;
using BeautyLab.Infrastructure;

namespace BeautyLab.Tabs.General_Tabs
{
    public partial class SettingsControl : UserControl
    {
        private MainForm? Form;

        public SettingsControl(MainForm form)
        {
            Form = form;
            InitializeComponent();
            LoadCfg();
        }

        private void TrackVolume_ValueChanged(object sender, EventArgs e)
        {
            var volume = TrackVolume.Value;
            ProgressVolume.Value = volume;
            textVolume.Text = $"{volume}%";

            using var cfg = new AppConfig();
            cfg.Load();
            cfg.Volume = volume;
            cfg.Save();
        }

        private void TrackBorder_ValueChanged(object sender, EventArgs e)
        {
            var border = TrackBorder.Value;
            ProgressBorder.Value = border;
            textBorder.Text = $"{border}%";
            Form.BorderForm.BorderRadius = border;

            using var cfg = new AppConfig();
            cfg.Load();
            cfg.CornerRadius = border;
            cfg.Save();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            SaveCfg(10, 5);
            LoadCfg();
        }

        private static void SaveCfg(int border, int volume)
        {
            using var cfg = new AppConfig();
            cfg.CornerRadius = border;
            cfg.Volume = volume;
            cfg.Save();
        }

        private void LoadCfg()
        {
            using var cfg = new AppConfig();
            cfg.Load();

            ProgressBorder.Value = cfg.CornerRadius;
            TrackBorder.Value = cfg.CornerRadius;
            textBorder.Text = $"{cfg.CornerRadius}%";

            ProgressVolume.Value = cfg.Volume;
            TrackVolume.Value = cfg.Volume;
            textVolume.Text = $"{cfg.Volume}%";

            Form.BorderForm.BorderRadius = cfg.CornerRadius;
        }
    }
}
