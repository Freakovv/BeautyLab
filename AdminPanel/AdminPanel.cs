using Guna.UI2.WinForms;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;

namespace AdminPanel
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string password = txtPass.Text;

            if (password.Length < 6)
            {
                ShowError("Слишком короткий пароль (<6)");
                return;
            }

            AdminManager adminManager = new();
            try
            {
                // Добавление админа в базу данных
                adminManager.AddAdmin(login, password);

            }
            catch (ArgumentException a)
            {
                ShowError(a.Message, "Ошибка создания аккаунта");
                return;
            }
            catch (SqlException sql)
            {
                ShowError(sql.Message, "Ошибка базы данных");
                return;
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
                return;
            }

            ShowInfo("Администратор " + login + " успешно создан!");

            // Добавление администратора в таблицу TableAdmins
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(TableAdmins);
            newRow.Cells[0].Value = login;

            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(255, 211, 233, 252),             // Цвет фона
                ForeColor = Color.Black,                                    // Цвет текста
                SelectionBackColor = Color.FromArgb(255, 107, 185, 246),    // Цвет фона для выделенной ячейки
                SelectionForeColor = Color.Black,                           // Цвет текста для выделенной ячейки
                Font = new Font("Segoe UI", 11),                            // Шрифт текста
                WrapMode = DataGridViewTriState.False,                      // Отключение переноса текста
                Alignment = DataGridViewContentAlignment.MiddleLeft         // Выравнивание по левому краю
            };

            // Применение стиля к DataGridView
            TableAdmins.DefaultCellStyle = cellStyle;

            TableAdmins.Rows.Add(newRow);
        }

        private void ShowError(string message, string caption = "Ошибка")
        {
            msg.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            msg.Buttons = MessageDialogButtons.OK;
            msg.Show(message, caption);
        }
        private void ShowInfo(string message, string caption = "Информация")
        {
            msg.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            msg.Buttons = MessageDialogButtons.OK;
            msg.Show(message, caption);
        }

        private void TableAdmins_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = TableAdmins.CurrentRow;
            var login = selectedRow.Cells[0].Value.ToString();

            if (login == null || login.IsNullOrEmpty())
            {
                ShowError("Логин не найден", "Критическая ошибка таблицы");
                return;
            }

            AdminManager adminManager = new();

            if (e.ColumnIndex == TableAdmins.Columns["btnReject"].Index)
            {
                int rowIndex = e.RowIndex;
                if (rowIndex >= 0)
                {
                    msg.Buttons = MessageDialogButtons.YesNo;
                    var result = msg.Show(
                        "Вы уверены, что хотите удалить администратора " + login + "?",
                        "Подтверждение удаления");

                    if (result == DialogResult.Yes)
                    {
                        // Удаляем администратора из БД
                        try
                        {
                            adminManager.DeleteAdmin(login: login);
                        }
                        catch (ArgumentException ex)
                        {
                            ShowError(ex.Message);
                            return;
                        }
                        // Удаляем строку из таблицы
                        TableAdmins.Rows.RemoveAt(rowIndex);
                    }
                }
            }

        }

        private void ImportAdmins()
        {
            AdminManager adminManager = new();
            try
            {
                // Получаем список администраторов из базы данных
                string query = "SELECT email FROM Users WHERE access = 1";
                using (SqlCommand command = new(query, adminManager.connection))
                {
                    adminManager.OpenConnection();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        TableAdmins.Rows.Clear();

                        while (reader.Read())
                        {
                            string login = reader["email"].ToString();

                            // Создание строки
                            DataGridViewRow newRow = new DataGridViewRow();
                            newRow.CreateCells(TableAdmins);
                            newRow.Cells[0].Value = login;

                            // Стиль ячеек
                            newRow.DefaultCellStyle.BackColor = Color.FromArgb(255, 211, 233, 252);
                            newRow.DefaultCellStyle.ForeColor = Color.Black;
                            newRow.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 107, 185, 246);
                            newRow.DefaultCellStyle.SelectionForeColor = Color.Black;
                            newRow.DefaultCellStyle.Font = new Font("Segoe UI", 11);
                            newRow.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
                            newRow.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                            // Добавление строки в таблицу
                            TableAdmins.Rows.Add(newRow);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ShowError("Ошибка при импорте администраторов: " + ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            ImportAdmins();
        }
    }
}
