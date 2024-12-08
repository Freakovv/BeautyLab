using BeautyLab.Tabs;
using BeautyLab.Tabs.General_Tabs;
using Guna.UI2.AnimatorNS;
using Guna.UI2.WinForms;

namespace BeautyLab
{
    public partial class HomeControl : UserControl
    {
        private ProfileControl profileTab;
        private SettingsControl settingsTab;
        private ContactControl contactTab;

        private readonly string _localEmail;

        public HomeControl(MainForm form, string email)
        {
            refForm = form;
            _localEmail = email;
            InitializeComponent();


            profileTab = new ProfileControl(ref refForm, _localEmail);
            settingsTab = new SettingsControl(form);
            contactTab = new ContactControl();

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
                OpenTab(profileTab);
                btnProfile.Checked = true;

                isProfileTabOpen = true;
                isContactTabOpen = false;
                isSettingsTabOpen = false;
            }

            isProfileTabOpen =!isProfileTabOpen;
        }

        private void OpenTab(UserControl control, MainForm form = null)
        {
            control.Dock = DockStyle.Fill;
            panelWindow.Controls.Add(control);
            control.BringToFront();
            Guna2Transition trans = new Guna2Transition();
            trans.AnimationType = AnimationType.Transparent;
            trans.ShowSync(control);

            //control.Show();
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
                OpenTab(settingsTab);
                btnSettings.Checked = true;

                isProfileTabOpen = false;
                isSettingsTabOpen = true;
                isContactTabOpen = false;
            }

            isSettingsTabOpen =!isSettingsTabOpen;
        }
        private bool isContactTabOpen = false;
        private void btnContact_Click(object sender, EventArgs e)
        {
            if (isContactTabOpen)
            {
                CloseCustomWindows();
                btnContact.Checked = false;
            }
            else
            {
                OpenTab(contactTab);
                btnContact.Checked = true;

                isProfileTabOpen = false;
                isSettingsTabOpen = false;
                isContactTabOpen = true;
            }
            isContactTabOpen =!isContactTabOpen;
        }
    }
}
