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


        private void EntryForm_Load(object sender, EventArgs e)
        {
            timerShow.Start();
        }

        void ButtonsStateLogin(object s, EventArgs e)
        {
            if (txtLogin.Text.Length > 0 && txtPassword.Text.Length > 0)
            {
                btnEnter.Enabled = true;
            }
            else
            {
                btnEnter.Enabled = false;
            }
        }

        void ButtonsStateReg(object s, EventArgs e)
        {
            if (txtLogReg.Text.Length > 0 && txtPassReg1.Text.Length > 0 && txtPassReg2.Text.Length > 0)
            {
                btnReg.Enabled = true;
                btnReg.IdleFillColor = Color.FromArgb(227, 89, 164);
            }
            else
            {
                btnReg.Enabled = false;
                btnReg.IdleFillColor = Color.FromArgb(242, 220, 232);
            }
        }
    }
}
