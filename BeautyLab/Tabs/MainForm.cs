using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeautyLab.Animations;
using Guna.UI2.AnimatorNS;
using Guna.UI2.WinForms;
using static System.Windows.Forms.LinkLabel;

namespace BeautyLab
{
    //TODO: Распределние ролей
    //Панель с доступным меню пользователя будет расположена вместо админской
    //Доступ будет осуществляться по сохраненному уровню доступа из бд
    public partial class MainForm : Form
    {
        private readonly Font defaultFont;
        private readonly Font activeFont;

        private HomeControl mainWindow;
        Guna2Transition animator;
        public MainForm()
        {
            InitializeComponent();
            defaultFont = new Font("Jura", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 204);
            activeFont = new Font(defaultFont, defaultFont.Style | FontStyle.Underline);
            mainWindow = new HomeControl(this);
            animator = new Guna2Transition();
            animator.Interval = 1;
            animator.AnimationType = AnimationType.Transparent;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            AnimateForm animation = new AnimateForm(this);
            animation.Start(true);
            ToggleUnderline(linkHome);
            OpenTab(mainWindow);
        }
        private void ToggleUnderline(Label selectedLabel)
        {
            foreach (Control control in panelLinks.Controls)
            {
                if (control is Label label)
                {
                    label.Font = defaultFont;
                }
            }

            selectedLabel.Font = activeFont;
        }

        private void linkHome_Click(object sender, EventArgs e)
        {
            if (!CheckActiveWindow(mainWindow))
            {
                ToggleUnderline(linkHome);
                OpenTab(mainWindow);
            }
        }
        private void linkRecord_Click(object sender, EventArgs e)
        {
            ToggleUnderline(linkRecord);
        }
        private void linkMaterial_Click(object sender, EventArgs e)
        {
            ToggleUnderline(linkMaterial);
        }
        private void linkReport_Click(object sender, EventArgs e)
        {
            ToggleUnderline(linkReport);
        }

        private UserControl activeControl = null;
        private void OpenTab(UserControl control)
        {
            if (activeControl != null)
            {
                activeControl.Hide();
                activeControl.Enabled = false;
            }
            activeControl = control;
            activeControl.Enabled = true;
            control.Dock = DockStyle.Fill;
            panelWindow.Controls.Add(control);
            panelWindow.Tag = control;
            control.BringToFront();
            //animator.ShowSync(control);
            control.Show();
        }
        //private void CloseTab(UserControl control)
        //{
        //    animator.HideSync(control);
        //    activeControl = null;
        //}

        private bool CheckActiveWindow(UserControl control)
        {
            foreach (var element in panelWindow.Controls)
            {
                if (element == control)
                {
                    if (control.Enabled)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

    }
}
