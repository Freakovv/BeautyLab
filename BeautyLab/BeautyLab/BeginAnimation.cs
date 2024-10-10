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
        private int animation_seconds = 3;
        private void BeginAnimation_Load(object sender, EventArgs e)
        {
            Opacity = 0;
            timer_animation.Start();
        }



        private void timer_animation_Tick(object sender, EventArgs e)
        {
            switch (animation_type)
            {
                //start
                case 1:
                    if (Opacity != 1.0)
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
                    if (animation_seconds != 0)
                        --animation_seconds;
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
                    }
                    break;
            }
        }
    }
}
