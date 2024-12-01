using BeautyLab.Animations;
using Guna.UI2.AnimatorNS;
using Guna.UI2.WinForms;

namespace BeautyLab
{
    // TODO: Распределние ролей
    // Панель с доступными ссылками пользователя будет расположена поверх админской
    // Доступ будет осуществляться по сохраненному уровню доступа из бд

    /// <summary>
    /// Основной класс разработанный для управления основной формы
    /// </summary>
    public partial class MainForm : Form
    {

        /// <summary>
        /// Объявление шрифтов
        /// </summary>
        private readonly Font defaultFont;
        private readonly Font activeFont;


        /// <summary>
        /// Объявление страницы
        /// </summary>
        private HomeControl homeWindow;
        private Guna2Transition animator;


        public MainForm()
        {
            InitializeComponent();

            /// <summary>
            /// Настройка стандартных шрифтов
            /// </summary>
            defaultFont = new Font("Jura", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 204);
            activeFont = new Font(defaultFont, defaultFont.Style | FontStyle.Underline);


            /// <summary>
            /// Создание экземпляров классов
            /// </summary>
            homeWindow = new HomeControl(this);
            animator = new Guna2Transition();

            /// <summary>
            /// Настройки классов
            /// </summary>
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
            foreach (Control control in panelLinks.Controls)
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


        /// <summary>
        /// Переменная activeControl записывает текущую страницу на главной панели
        /// Функция для открытия страницы на главной панели
        /// Задает окну параметры для корректного отображения
        /// Уничтожает активный (прошлый) контроллер
        /// </summary>
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
            control.Show();
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
