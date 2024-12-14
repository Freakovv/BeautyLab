using Guna.UI2.WinForms;
namespace BeautyLab.Tabs.Admin_Tabs
{
    public partial class RecordControl : UserControl
    {
        // TODO: Тут объявить класс БД

        public RecordControl(MainForm mainForm)
        {
            InitializeComponent();
            //TODO: Тут создать экземпляр класса БД
            msg.Parent = mainForm;
        }

        private void RecordControl_Load(object sender, EventArgs e)
        {
            // TODO: Записать функцию которая импортирует из БД в табличку
        }

        private void AddRecord(string fullName, string phone, string date, string time, string service, string price)
        {
            if (!IsValidPhone(phone))
            {
                msg.Show($"Некорректный телефон: {phone}", "Ошибка");
                return;
            }
            if (!IsValidDate(date))
            {
                msg.Show($"Некорректная дата: {date}", "Ошибка");
                return;
            }
            if (!IsValidTime(time))
            {
                msg.Show($"Некорректное время: {time}", "Ошибка");
                return;
            }

            Table.Rows.Add(fullName, phone, date, time, service, price);


            // TODO: Тут выгрузить в БД
        }

        private bool IsValidPhone(string phone)
        {
            string digitsOnly = new string(phone.Where(char.IsDigit).ToArray());
            return digitsOnly.StartsWith("375") && digitsOnly.Length == 12;
        }

        private bool IsValidDate(string date)
        {
            return DateTime.TryParseExact(date, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out _);
        }

        private bool IsValidTime(string time)
        {
            return TimeSpan.TryParseExact(time, "hh\\:mm", null, out _);
        }

        private Dictionary<string, string> priceDictionary = new Dictionary<string, string>
        {
            { "эстетическая косметология", "50$" },
            { "коррекция фигуры", "70$" },
            { "массаж, SPA", "60$" },
            { "маникюр", "30$" },
            { "педикюр", "40$" },
            { "наращивание ресниц", "45$" },
            { "шугаринг", "35$" },
            { "парикмахерские услуги", "50$" }
        };
        private void btnCreateRequest_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string phone = txtPhone.Text;
            string date = txtDate.Text;
            string time = txtTime.Text;
            string service = ServiceTxt.Text;

            if (priceDictionary.TryGetValue(service, out string price))
            {
                AddRecord(name, phone, date, time, service, price);
                msg.Show("Запись успешно добавлена!", "Сохранено");
            }
            else
            {
                msg.Show("Услуга не найдена.", "Ошибка");
            }

        }

        private void btnEndDay_Click(object sender, EventArgs e)
        {
            msg.Buttons = MessageDialogButtons.YesNo;
            msg.Icon = MessageDialogIcon.Question;
            var result = msg.Show(
                "Вы уверены, что хотите завершить бизнес-день?",
                "Подтверждение завершения");

            if (result == DialogResult.Yes)
            {
                // Завершаем бизнес-день с сохранением отчета в БД
                try
                {
                    // TODO: Тут записать функцию которая передает таблицу для отработки и сохраняет в БД
                }
                catch (ArgumentException ex)
                {
                    msg.Icon = MessageDialogIcon.Warning;
                    msg.Show(ex.Message, "Предупреждение");
                    return;
                }

                msg.Icon = MessageDialogIcon.Information;
                msg.Buttons = MessageDialogButtons.OK;
                msg.Show("Бизнес-день успешно завершен!", "Успех");
            }
            else
            {
                msg.Icon = MessageDialogIcon.Warning;
                msg.Buttons = MessageDialogButtons.OK;
                msg.Show("Завершение бизнес-дня отменено.", "Отмена");
            }
        }
    }
}
