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

namespace BeautyLab
{
    public partial class EntryForm : Form
    {
        public EntryForm()
        {
            InitializeComponent();
        }

        private void EntryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void FormCaptionButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void timerShow_Tick(object sender, EventArgs e)
        {
            if (Opacity < 1)
            {
                Opacity += 0.05;
            }
            else
            {
                timerShow.Stop();
            }
        }

        private void EntryForm_Load(object sender, EventArgs e)
        {
            timerShow.Start();
        }

        private void lblTerms_Click(object sender, EventArgs e)
        {
            Animator animator = new Animator();
            Animator animator2 = new Animator();
            animator.AnimationType = AnimationType.Transparent;
            animator2.AnimationType = AnimationType.Transparent;

            animator.HideSync(panelLabel);
            animator.ShowSync(txtTerms);
            animator2.ShowSync(btnCloseTerms);
            btnCloseTerms.BringToFront();
        }

        private void btnCloseTerms_Click(object sender, EventArgs e)
        {
            Animator animator = new Animator();
            Animator animator2 = new Animator();
            animator.AnimationType = AnimationType.Transparent;
            animator2.AnimationType = AnimationType.Transparent;

            animator2.HideSync(btnCloseTerms);
            animator.HideSync(txtTerms);
            animator.ShowSync(panelLabel);
        }
    }
}
