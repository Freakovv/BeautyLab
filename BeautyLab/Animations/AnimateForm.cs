using System;
using Timer = System.Windows.Forms.Timer;

namespace BeautyLab.Animations
{
    internal class AnimateForm
    {
        private Timer timer;
        private Form form;
        private bool fadeIn;

        public AnimateForm(Form form)
        {
            this.form = form;
            timer = new Timer();
            timer.Interval = 5;
            timer.Tick += Timer_Tick;
        }

        public void Start(bool fadeIn)
        {
            this.fadeIn = fadeIn;
            form.Opacity = fadeIn ? 0.0 : 1.0;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (fadeIn)
            {
                if (form.Opacity < 1.0)
                    form.Opacity += 0.05;
                else
                    timer.Stop();
            }
            else
            {
                if (form.Opacity > 0.0)
                    form.Opacity -= 0.05;
                else
                {
                    timer.Stop();
                    form.Hide();
                }
            }
        }
    }
}
