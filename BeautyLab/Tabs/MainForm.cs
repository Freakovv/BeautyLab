using BeautyLab.Animations;
using BeautyLab.Infrastructure;
using BeautyLab.Tabs.Admin_Tabs;
using BeautyLab.Tabs.Default_tabs;
using BeautyLab.Tabs.Master_Tabs;
using Guna.UI2.AnimatorNS;
using Guna.UI2.WinForms;

namespace BeautyLab
{

    /// <summary>
    /// Основной класс разработанный для управления основной формы
    /// </summary>
    public partial class MainForm : Form
    {

        /// <summary>
        /// Объявление стандартных шрифтов
        /// </summary>
        private readonly Font defaultFont;
        private readonly Font activeFont;


        /// <summary>
        /// Объявление страниц
        /// </summary>
        private HomeControl homeWindow;
        private RecordControl recordControl;
        private AcceptRecords recordMasterControl;
        private ReportControl reportControl;


        private Guna2Transition animator;


        /// <summary>
        /// Конструктор основной формы
        /// Определяет текущего пользователя
        /// </summary>

        string _localEmail;

        public MainForm(string _email)
        {
            InitializeComponent();

            _localEmail = _email;

            defaultFont = new Font("Jura", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 204);
            activeFont = new Font(defaultFont, defaultFont.Style | FontStyle.Underline);


            homeWindow = new HomeControl(this, _localEmail);
            recordControl = new RecordControl(this);
            recordMasterControl = new AcceptRecords(this);
            reportControl = new ReportControl();

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
            OpenTab(homeWindow);
        }

        private void ToggleUnderline(Label selectedLabel)
        {
            foreach (Control control in AdminLinks.Controls)
            {
                if (control is Label label)
                {
                    label.Font = defaultFont;
                }
            }

            selectedLabel.Font = activeFont;
        }

        /// <summary>
        /// Гиперссылки для открытия страниц
        /// </summary>

        private void linkHome_Click(object sender, EventArgs e)
        {
            if (!CheckActiveWindow(homeWindow))
            {
                ToggleUnderline(linkHome);
                OpenTab(homeWindow);
            }
        }
        private void linkRecord_Click(object sender, EventArgs e)
        {
            Users data = new Users();
            int access = data.GetUserAccess(_localEmail);

            if (access == 1)
            {
                if (!CheckActiveWindow(recordControl))
                {
                    ToggleUnderline(linkRecord);
                    OpenTab(recordControl);
                }
            }
            else
            {
                if (!CheckActiveWindow(recordMasterControl))
                {
                    ToggleUnderline(linkRecord);
                    OpenTab(recordMasterControl);
                }
            }

        }
        //private void linkMaterial_Click(object sender, EventArgs e)
        //{
        //    ToggleUnderline(linkMaterial);
        //}
        private void linkReport_Click(object sender, EventArgs e)
        {
            if (!CheckActiveWindow(reportControl))
            {
                ToggleUnderline(linkReport);
                OpenTab(reportControl);
            }

        }


        /// <summary>
        /// Переменная activeControl записывает текущую страницу на главной панели
        /// Функция для открытия страницы на главной панели
        /// Задает окну параметры для корректного отображения
        /// Уничтожает активный (прошлый) контроллер
        /// </summary>
        private UserControl? activeControl = null;
        private void OpenTab(UserControl control)
        {
            if (activeControl != null)
            {
                activeControl.Hide();
                activeControl.Enabled = false;
            }

            activeControl = control;

            // Проверяем, что control не null перед использованием
            if (activeControl != null)
            {
                activeControl.Enabled = true;
                activeControl.Dock = DockStyle.Fill;
                panelWindow.Controls.Add(activeControl);
                panelWindow.Tag = activeControl;
                activeControl.BringToFront();
                activeControl.Show();
            }
        }

        /// <summary>
        /// Проверяет, открыт ли контроллер перебирая все элементы главной панели
        /// Используется для корректной визуальной работы ссылок (подчеркивания)
        /// Пренебрежение функцией вызывает проблемы с работой интерфейса
        /// </summary>
        /// <param name="control">Активный контроллер для проверки</param>
        /// <returns>Включает ли панель в себя контроллер</returns>
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
