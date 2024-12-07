<?xml version="1.0"?>
<doc>
    <assembly>
        <name>BeautyLab</name>
    </assembly>
    <members>
        <member name="T:BeautyLab.BeginAnimation">
            <summary>
            Отвечает за первоначальный показ анимации0,
            </summary>
        </member>
        <member name="M:BeautyLab.BeginAnimation.#ctor">
            <summary>
            Стандартный конструктор
            </summary>
        </member>
        <member name="F:BeautyLab.BeginAnimation.animation_type">
            <summary>
            Настройка типов анимаций
            1 - fade in
            2 - stay (waiting)
            3 - fade out
            </summary>
        </member>
        <member name="M:BeautyLab.BeginAnimation.timer_animation_Tick(System.Object,System.EventArgs)">
            <summary>
            Таймер, тики которого реализуют анимацию в зависимости от типа
            </summary>
        </member>
        <member name="M:BeautyLab.BeginAnimation.BeginAnimation_FormClosing(System.Object,System.Windows.Forms.FormClosingEventArgs)">
            <summary>
            Корректное закрытие формы при ручном закрытии приложения
            Предотвращает зависание процесса в системе после закрытия приложения
            </summary>
        </member>
        <member name="F:BeautyLab.BeginAnimation.components">
            <summary>
            Required designer variable.
            </summary>
        </member>
        <member name="M:BeautyLab.BeginAnimation.Dispose(System.Boolean)">
            <summary>
            Clean up any resources being used.
            </summary>
            <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        </member>
        <member name="M:BeautyLab.BeginAnimation.InitializeComponent">
            <summary>
            Required method for Designer support - do not modify
            the contents of this method with the code editor.
            </summary>
        </member>
        <member name="F:BeautyLab.Overlay.components">
            <summary>
            Required designer variable.
            </summary>
        </member>
        <member name="M:BeautyLab.Overlay.Dispose(System.Boolean)">
            <summary>
            Clean up any resources being used.
            </summary>
            <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        </member>
        <member name="M:BeautyLab.Overlay.InitializeComponent">
            <summary>
            Required method for Designer support - do not modify
            the contents of this method with the code editor.
            </summary>
        </member>
        <member name="M:BeautyLab.Infrastructure.Users.HashPassword(System.String)">
            <summary>
            Функция хеширования пароля
            </summary>
            <param name="password"></param>
            <returns>Зашифрованный пароль</returns>
        </member>
        <member name="F:BeautyLab.VerificationForm.components">
            <summary>
            Required designer variable.
            </summary>
        </member>
        <member name="M:BeautyLab.VerificationForm.Dispose(System.Boolean)">
            <summary>
            Clean up any resources being used.
            </summary>
            <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        </member>
        <member name="M:BeautyLab.VerificationForm.InitializeComponent">
            <summary>
            Required method for Designer support - do not modify
            the contents of this method with the code editor.
            </summary>
        </member>
        <member name="T:BeautyLab.EntryForm">
            <summary>
            Форма входа
            Описана регистрация, вход пользователей
            </summary>
        </member>
        <member name="M:BeautyLab.EntryForm.#ctor">
            <summary>
            Конструктор формы входа по умолочанию 
            </summary>
        </member>
        <member name="T:BeautyLab.Properties.Resources">
            <summary>
              Класс ресурса со строгой типизацией для поиска локализованных строк и т.д.
            </summary>
        </member>
        <member name="P:BeautyLab.Properties.Resources.ResourceManager">
            <summary>
              Возвращает кэшированный экземпляр ResourceManager, использованный этим классом.
            </summary>
        </member>
        <member name="P:BeautyLab.Properties.Resources.Culture">
            <summary>
              Перезаписывает свойство CurrentUICulture текущего потока для всех
              обращений к ресурсу с помощью этого класса ресурса со строгой типизацией.
            </summary>
        </member>
        <member name="P:BeautyLab.Properties.Resources.BeautyLab">
            <summary>
              Поиск локализованного ресурса типа System.Drawing.Bitmap.
            </summary>
        </member>
        <member name="P:BeautyLab.Properties.Resources.Ellipse_1">
            <summary>
              Поиск локализованного ресурса типа System.Drawing.Bitmap.
            </summary>
        </member>
        <member name="P:BeautyLab.Properties.Resources.Ellipse_11">
            <summary>
              Поиск локализованного ресурса типа System.Drawing.Bitmap.
            </summary>
        </member>
        <member name="P:BeautyLab.Properties.Resources.Group_3">
            <summary>
              Поиск локализованного ресурса типа System.Drawing.Bitmap.
            </summary>
        </member>
        <member name="P:BeautyLab.Properties.Resources.icons8_цветок_64">
            <summary>
              Поиск локализованного ресурса типа System.Drawing.Bitmap.
            </summary>
        </member>
        <member name="P:BeautyLab.Properties.Resources.iconShow1">
            <summary>
              Поиск локализованного ресурса типа System.Drawing.Bitmap.
            </summary>
        </member>
        <member name="P:BeautyLab.Properties.Resources.iconShow2">
            <summary>
              Поиск локализованного ресурса типа System.Drawing.Bitmap.
            </summary>
        </member>
        <member name="P:BeautyLab.Properties.Resources.Lock">
            <summary>
              Поиск локализованного ресурса типа System.Drawing.Bitmap.
            </summary>
        </member>
        <member name="P:BeautyLab.Properties.Resources.Lock1">
            <summary>
              Поиск локализованного ресурса типа System.Drawing.Bitmap.
            </summary>
        </member>
        <member name="P:BeautyLab.Properties.Resources.mail">
            <summary>
              Поиск локализованного ресурса типа System.Drawing.Bitmap.
            </summary>
        </member>
        <member name="P:BeautyLab.Properties.Resources.mail1">
            <summary>
              Поиск локализованного ресурса типа System.Drawing.Bitmap.
            </summary>
        </member>
        <member name="P:BeautyLab.Properties.Resources.Rectangle_4">
            <summary>
              Поиск локализованного ресурса типа System.Drawing.Bitmap.
            </summary>
        </member>
        <member name="P:BeautyLab.Properties.Resources.ВХОД">
            <summary>
              Поиск локализованного ресурса типа System.Drawing.Bitmap.
            </summary>
        </member>
        <member name="F:BeautyLab.Tabs.Admin_Tabs.RecordControl.components">
            <summary> 
            Required designer variable.
            </summary>
        </member>
        <member name="M:BeautyLab.Tabs.Admin_Tabs.RecordControl.Dispose(System.Boolean)">
            <summary> 
            Clean up any resources being used.
            </summary>
            <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        </member>
        <member name="M:BeautyLab.Tabs.Admin_Tabs.RecordControl.InitializeComponent">
            <summary> 
            Required method for Designer support - do not modify 
            the contents of this method with the code editor.
            </summary>
        </member>
        <member name="T:BeautyLab.Tabs.ProfileControl">
            <summary>
            Класс для изменения пароля, удаления аккаунта, выхода из него
            </summary>
        </member>
        <member name="M:BeautyLab.Tabs.ProfileControl.#ctor(BeautyLab.MainForm@,System.String)">
            <summary>
            Стандартный конструктор админской страницы профиля
            </summary>
        </member>
        <member name="F:BeautyLab.Tabs.ProfileControl.components">
            <summary> 
            Обязательная переменная конструктора.
            </summary>
        </member>
        <member name="M:BeautyLab.Tabs.ProfileControl.Dispose(System.Boolean)">
            <summary> 
            Освободить все используемые ресурсы.
            </summary>
            <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        </member>
        <member name="M:BeautyLab.Tabs.ProfileControl.InitializeComponent">
            <summary> 
            Требуемый метод для поддержки конструктора — не изменяйте 
            содержимое этого метода с помощью редактора кода.
            </summary>
        </member>
        <member name="F:BeautyLab.Tabs.Default_tabs.ReportControl.components">
            <summary> 
            Required designer variable.
            </summary>
        </member>
        <member name="M:BeautyLab.Tabs.Default_tabs.ReportControl.Dispose(System.Boolean)">
            <summary> 
            Clean up any resources being used.
            </summary>
            <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        </member>
        <member name="M:BeautyLab.Tabs.Default_tabs.ReportControl.InitializeComponent">
            <summary> 
            Required method for Designer support - do not modify 
            the contents of this method with the code editor.
            </summary>
        </member>
        <member name="F:BeautyLab.Tabs.General_Tabs.SettingsControl.components">
            <summary> 
            Обязательная переменная конструктора.
            </summary>
        </member>
        <member name="M:BeautyLab.Tabs.General_Tabs.SettingsControl.Dispose(System.Boolean)">
            <summary> 
            Освободить все используемые ресурсы.
            </summary>
            <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        </member>
        <member name="M:BeautyLab.Tabs.General_Tabs.SettingsControl.InitializeComponent">
            <summary> 
            Требуемый метод для поддержки конструктора — не изменяйте 
            содержимое этого метода с помощью редактора кода.
            </summary>
        </member>
        <member name="F:BeautyLab.Tabs.General_Tabs.ContactControl.components">
            <summary> 
            Обязательная переменная конструктора.
            </summary>
        </member>
        <member name="M:BeautyLab.Tabs.General_Tabs.ContactControl.Dispose(System.Boolean)">
            <summary> 
            Освободить все используемые ресурсы.
            </summary>
            <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        </member>
        <member name="M:BeautyLab.Tabs.General_Tabs.ContactControl.InitializeComponent">
            <summary> 
            Требуемый метод для поддержки конструктора — не изменяйте 
            содержимое этого метода с помощью редактора кода.
            </summary>
        </member>
        <member name="F:BeautyLab.Tabs.Master_Tabs.AcceptRecords.components">
            <summary> 
            Required designer variable.
            </summary>
        </member>
        <member name="M:BeautyLab.Tabs.Master_Tabs.AcceptRecords.Dispose(System.Boolean)">
            <summary> 
            Clean up any resources being used.
            </summary>
            <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        </member>
        <member name="M:BeautyLab.Tabs.Master_Tabs.AcceptRecords.InitializeComponent">
            <summary> 
            Required method for Designer support - do not modify 
            the contents of this method with the code editor.
            </summary>
        </member>
        <member name="F:BeautyLab.HomeControl.components">
            <summary> 
            Обязательная переменная конструктора.
            </summary>
        </member>
        <member name="M:BeautyLab.HomeControl.Dispose(System.Boolean)">
            <summary> 
            Освободить все используемые ресурсы.
            </summary>
            <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        </member>
        <member name="M:BeautyLab.HomeControl.InitializeComponent">
            <summary> 
            Требуемый метод для поддержки конструктора — не изменяйте 
            содержимое этого метода с помощью редактора кода.
            </summary>
        </member>
        <member name="T:BeautyLab.MainForm">
            <summary>
            Основной класс разработанный для управления основной формы
            </summary>
        </member>
        <member name="F:BeautyLab.MainForm.defaultFont">
            <summary>
            Объявление стандартных шрифтов
            </summary>
        </member>
        <member name="F:BeautyLab.MainForm.homeWindow">
            <summary>
            Объявление страниц
            </summary>
        </member>
        <member name="F:BeautyLab.MainForm._localEmail">
            <summary>
            Конструктор основной формы
            Определяет текущего пользователя
            </summary>
        </member>
        <member name="M:BeautyLab.MainForm.linkHome_Click(System.Object,System.EventArgs)">
            <summary>
            Гиперссылки для открытия страниц
            </summary>
        </member>
        <member name="F:BeautyLab.MainForm.activeControl">
            <summary>
            Переменная activeControl записывает текущую страницу на главной панели
            Функция для открытия страницы на главной панели
            Задает окну параметры для корректного отображения
            Уничтожает активный (прошлый) контроллер
            </summary>
        </member>
        <member name="M:BeautyLab.MainForm.CheckActiveWindow(System.Windows.Forms.UserControl)">
            <summary>
            Проверяет, открыт ли контроллер перебирая все элементы главной панели
            Используется для корректной визуальной работы ссылок (подчеркивания)
            Пренебрежение функцией вызывает проблемы с работой интерфейса
            </summary>
            <param name="control">Активный контроллер для проверки</param>
            <returns>Включает ли панель в себя контроллер</returns>
        </member>
        <member name="F:BeautyLab.MainForm.components">
            <summary>
            Required designer variable.
            </summary>
        </member>
        <member name="M:BeautyLab.MainForm.Dispose(System.Boolean)">
            <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        </member>
        <member name="M:BeautyLab.MainForm.InitializeComponent">
            <summary>
            Required method for Designer support - do not modify
            the contents of this method with the code editor.
            </summary>
        </member>
        <member name="T:BeautyLab.ApplicationConfiguration">
            <summary>
             Bootstrap the application configuration.
            </summary>
        </member>
        <member name="M:BeautyLab.ApplicationConfiguration.Initialize">
            <summary>
             Bootstrap the application as follows:
             <code>
             global::System.Windows.Forms.Application.EnableVisualStyles();
             global::System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
             global::System.Windows.Forms.Application.SetHighDpiMode(HighDpiMode.SystemAware);
            </code>
            </summary>
        </member>
    </members>
</doc>
