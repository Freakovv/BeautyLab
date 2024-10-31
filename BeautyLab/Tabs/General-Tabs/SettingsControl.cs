using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautyLab.Tabs.General_Tabs
{
    public partial class SettingsControl : UserControl
    {
        public SettingsControl()
        {
            InitializeComponent();
        }
        //TODO: Сделать дизайн, реализацию настроек, класса xml
        private void guna2TrackBar1_Scroll(object sender, EventArgs e)
        {
            ProgressBarVolume.Value = guna2TrackBar1.Value;
        }

    }
}
