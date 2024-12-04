using Microsoft.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace BeautyLab.Infrastructure
{
    internal class DataBase
    {
        private readonly SqlConnection _homeConnection = new SqlConnection(
            @"Data Source=Freakovv;Initial Catalog=BeautyLab;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");

        public void OpenConnection()
        {
            if (_homeConnection.State == ConnectionState.Closed)
            {
                _homeConnection.Open();
            }
        }

        public void CloseConnection()
        {
            if (_homeConnection.State == ConnectionState.Open)
            {
                _homeConnection.Close();
            }
        }

        public bool InsertEmailAndPassword(string email, string password)
        {
            string hashedPassword = HashPassword(password);
            using SqlCommand command = new SqlCommand("INSERT INTO Users (email, password) VALUES (@Email, @Password)", _homeConnection);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Password", hashedPassword);

            string result = ExecuteNonQueryRegister(command);

            if (result == "Успешно")
            {
                return true;
            }
            else
            {
                throw new ArgumentException(result);
            }
        }
        public void ChangePassword(string email, string newPassword)
        {
            string hashedPassword = HashPassword(newPassword);

            using SqlCommand command = new SqlCommand(
                "UPDATE Users SET password = @Password WHERE email = @Email",
                _homeConnection
            );
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Password", hashedPassword);

            try
            {
                OpenConnection();
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected <= 0)
                {
                    MessageBox.Show("Указанный адрес электронной почты не найден.");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка при изменении пароля: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }


        public bool AccountExists(string email)
        {
            using SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Users WHERE email = @Email", _homeConnection);
            command.Parameters.AddWithValue("@Email", email);
            return ExecuteScalar(command) > 0;
        }

        public bool GetAccess(string login, string password)
        {
            const string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            string loginOrEmail = Regex.IsMatch(login, pattern) ? "email" : "login";
            string hashedPassword = HashPassword(password);

            string query = $"SELECT COUNT(*) FROM Users WHERE {loginOrEmail} = @Login AND password = @Password";
            using SqlCommand command = new SqlCommand(query, _homeConnection);
            command.Parameters.AddWithValue("@Login", login);
            command.Parameters.AddWithValue("@Password", hashedPassword);

            return ExecuteScalar(command) > 0;
        }

        private string ExecuteNonQueryRegister(SqlCommand command)
        {
            try
            {
                OpenConnection();
                command.ExecuteNonQuery();
                return "Успешно";
            }
            catch (SqlException ex)
            {
                return ex.Message;
            }
            finally
            {
                CloseConnection();
            }
        }

        private int ExecuteScalar(SqlCommand command)
        {
            try
            {
                OpenConnection();
                return Convert.ToInt32(command.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database access error: " + ex.Message);
                return 0;
            }
            finally
            {
                CloseConnection();
            }
        }

        public static string HashPassword(string password)
        {
            using SHA256 sha256 = SHA256.Create();
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            StringBuilder builder = new StringBuilder();
            foreach (byte b in bytes)
            {
                builder.Append(b.ToString("x2"));
            }

            return builder.ToString();
        }
        public int GetUserAccess(string loginOrEmail)
        {
            const string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            string loginOrEmailColumn = Regex.IsMatch(loginOrEmail, pattern) ? "email" : "login"; // Определяем, является ли это email или логином

            // Строим SQL запрос для получения значения поля 'access'
            string query = $"SELECT access FROM Users WHERE {loginOrEmailColumn} = @LoginOrEmail";

            using (SqlCommand command = new SqlCommand(query, _homeConnection))
            {
                command.Parameters.AddWithValue("@LoginOrEmail", loginOrEmail);

                // Выполняем запрос и получаем значение поля 'access'
                object result = ExecuteScalar(command);

                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToInt32(result); // Возвращаем значение поля 'access'
                }
                else
                {
                    return 0; // Если не найдено, возвращаем 0
                }
            }
        }

        //public void InsertLoginNameSurname(string email, string login, string name, string surname)
        //{
        //    using SqlCommand command = new SqlCommand("UPDATE Users SET login = @Login, name = @Name, surname = @Surname WHERE email = @Email", _homeConnection);
        //    command.Parameters.AddWithValue("@Login", login);
        //    command.Parameters.AddWithValue("@Name", name);
        //    command.Parameters.AddWithValue("@Surname", surname);
        //    command.Parameters.AddWithValue("@Email", email);

        //    ExecuteNonQuery(command, "Login, name, and surname inserted successfully.");
        //}

    }
}
