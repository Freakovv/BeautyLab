using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeautyLab.Tabs;

namespace BeautyLab
{
    public partial class admHome : UserControl
    {
        private admProfile profileTab;
        public admHome()
        {
            profileTab = new admProfile();
            InitializeComponent();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            OpenWindow(new admProfile());
        }

        private UserControl activeControl;
        private void OpenWindow(UserControl control)
        {
            if (activeControl != null)
                activeControl.Hide();
            activeControl = control;
            control.Dock = DockStyle.Fill;
            panelWindow.Controls.Add(control);
            panelWindow.Tag = control;
            control.BringToFront();
            control.Show();
        }

        private void CloseWindow(UserControl control)
        {
            activeControl = null;
        }
    }
}
