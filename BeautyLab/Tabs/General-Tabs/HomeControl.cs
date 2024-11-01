using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using BeautyLab.Tabs;
using BeautyLab.Tabs.General_Tabs;
using K4os.Hash.xxHash;

namespace BeautyLab
{
    public partial class HomeControl : UserControl
    {
        private admProfile profileTab;
        private SettingsControl settingsTab;
        private ContactControl contactTab;
        public HomeControl(MainForm form)
        {
            profileTab = new admProfile();
            settingsTab = new SettingsControl(form);
            contactTab = new ContactControl();
            InitializeComponent();
            refForm = form;
        }

        private MainForm? refForm;

        private bool isProfileTabOpen = false;

        private void btnProfile_Click(object sender, EventArgs e)
        {
            if (isProfileTabOpen)
            {
                CloseCustomWindows();
                btnProfile.Checked = false;
            }
            else
            {
                OpenWindow(profileTab);
                btnProfile.Checked = true;

                isSettingsTabOpen = false;
            }

            isProfileTabOpen =!isProfileTabOpen;
        }

        private UserControl activeControl;
        private void OpenWindow(UserControl control, MainForm form = null)
        {
            control.Dock = DockStyle.Fill;
            panelWindow.Controls.Add(control);
            control.BringToFront();
            control.Show();
        }

        private void CloseCustomWindows()
        {
            foreach (Control item in panelWindow.Controls)
            {
                if (item is UserControl)
                {
                    item.Hide();
                }
            }
        }

        private bool isSettingsTabOpen = false;
        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (isSettingsTabOpen)
            {
                CloseCustomWindows();
                btnSettings.Checked = false;
            }
            else
            {
                OpenWindow(settingsTab);
                btnSettings.Checked = true;

                isProfileTabOpen = false;
            }

            isSettingsTabOpen =!isSettingsTabOpen;
        }
        
        //TODO: Доделать страничку контакты
        private void btnContact_Click(object sender, EventArgs e)
        {

        }
    }
}
