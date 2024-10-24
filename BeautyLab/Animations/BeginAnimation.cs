using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Threading.Timer;

namespace BeautyLab
{
    public partial class BeginAnimation : Form
    {
        public BeginAnimation()
        {
            InitializeComponent();
        }


        private int animation_type = 1;
        private int staySeconds = 3;
        private void BeginAnimation_Load(object sender, EventArgs e)
        {
            timer_animation.Start();
        }

        private void timer_animation_Tick(object sender, EventArgs e)
        {
            switch (animation_type)
            {
                //start
                case 1:
                    if (Opacity != 1)
                    {
                        Opacity += 0.05;
                    }
                    else
                    {
                        animation_type = 2;
                        timer_animation.Interval = 1000;
                    }
                    break;
                //waiting
                case 2:
                    if (staySeconds != 0)
                        --staySeconds;
                    else
                    {
                        animation_type = 3;
                        timer_animation.Interval = 5;
                    }
                    break;
                //end
                case 3:
                    if (Opacity != 0)
                    {
                        Opacity -= 0.05;
                    }
                    else
                    {
                        timer_animation.Stop();
                        EntryForm adEntryForm = new EntryForm();
                        Hide();
                        adEntryForm.Show();
                    }
                    break;
            }
        }

        private void BeginAnimation_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
