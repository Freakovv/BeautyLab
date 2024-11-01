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
        public MainForm()
        {
            InitializeComponent();
            defaultFont = new Font("Jura", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 204);
            activeFont = new Font(defaultFont, defaultFont.Style | FontStyle.Underline);
            mainWindow = new HomeControl(this);
            OpenWindow(mainWindow);
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
            ToggleUnderline(linkHome);
            OpenWindow(mainWindow);
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

    }
}
