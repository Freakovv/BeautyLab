using Microsoft.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace BeautyLab.Infrastructure
{
    internal class Users : DataBase
    {
        public Users() : base() { }

        public bool InsertEmailAndPassword(string email, string password)
        {
            string hashedPassword = HashPassword(password);
            using SqlCommand command = new SqlCommand("INSERT INTO Users (email, password) VALUES (@Email, @Password)", _connection);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Password", hashedPassword);

            try
            {
                ExecuteNonQuery(command);
                return true;
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        public void ChangePassword(string email, string newPassword)
        {
            string hashedPassword = HashPassword(newPassword);
            using SqlCommand command = new SqlCommand("UPDATE Users SET password = @Password WHERE email = @Email", _connection);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Password", hashedPassword);

            ExecuteNonQuery(command);
        }

        public bool AccountExists(string email)
        {
            using SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Users WHERE email = @Email", _connection);
            command.Parameters.AddWithValue("@Email", email);
            return ExecuteScalar(command) > 0;
        }

        public bool GetAccess(string email, string password)
        {
            string hashedPassword = HashPassword(password);

            string query = "SELECT COUNT(*) FROM Users WHERE email = @Email AND password = @Password";

            using SqlCommand command = new SqlCommand(query, _connection);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Password", hashedPassword);

            return ExecuteScalar(command) > 0;
        }

        public int GetUserAccess(string loginOrEmail)
        {
            string loginOrEmailColumn = Regex.IsMatch(loginOrEmail, @"^[^@\s]+@[^@\s]+\.[^@\s]+$") ? "email" : "login";

            string query = $"SELECT access FROM Users WHERE {loginOrEmailColumn} = @LoginOrEmail";
            using SqlCommand command = new SqlCommand(query, _connection);
            command.Parameters.AddWithValue("@LoginOrEmail", loginOrEmail);

            object result = ExecuteScalar(command);
            return result != null && result != DBNull.Value ? Convert.ToInt32(result) : 0;
        }

        /// <summary>
        /// Функция хеширования пароля
        /// </summary>
        /// <param name="password"></param>
        /// <returns>Зашифрованный пароль</returns>
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
    }
}
