using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.AnimatorNS;
using Guna.UI2.WinForms;

namespace BeautyLab
{
    public partial class EntryForm : Form
    {
        public EntryForm()
        {
            InitializeComponent();

        }
        private DataBase dataBase = new DataBase();

        private void EntryForm_Load(object sender, EventArgs e)
        {
            timerShow.Start();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {

        }

        private void eyeShow_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '\0';
            eyeShow.Image = Properties.Resources.iconShow2;
        }

        private void eyeShow_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '\u229b';
            eyeShow.Image = Properties.Resources.iconShow1;
        }
    }
}
