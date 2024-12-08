namespace BeautyLab
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            //Application.Run(new MainForm("misha.simanovich@mail.ru"));
            Application.Run(new MainForm("misha.simanovich@mail.ru"));
        }
    }
}