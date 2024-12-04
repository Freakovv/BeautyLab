﻿using BeautyLab.Infrastructure;
using Guna.UI2.WinForms;
namespace BeautyLab.Tabs.Admin_Tabs
{
    public partial class RecordControl : UserControl
    {
        private ExcelManager excelManager;


        public RecordControl(MainForm mainForm)
        {
            InitializeComponent();
            excelManager = new ExcelManager();
            msg.Parent = mainForm;
        }

        private void RecordControl_Load(object sender, EventArgs e)
        {
            excelManager.ImportFromExcel(Table);
        }

        private void AddRecord(string fullName, string phone, string date, string time, string master, string service, string price)
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

            Table.Rows.Add(fullName, phone, date, time, master, service, price);
            excelManager.ExportRowToExcel(fullName, phone, date, time, master, service, price);
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
            string master = txtMaster.Text;
            string service = ServiceTxt.Text;

            if (priceDictionary.TryGetValue(service, out string price))
            {
                AddRecord(name, phone, date, time, master, service, price);
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
                // Завершаем бизнес-день с сохранением отчета в Excel
                try
                {
                    excelManager.EndBusinessDay(Table); // Передаем таблицу для обработки
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
