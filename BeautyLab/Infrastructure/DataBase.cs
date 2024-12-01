using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace BeautyLab.Infrastructure
{
    internal class DataBase
    {
        private readonly SqlConnection _homeConnection = new SqlConnection(
            @"Data Source=DESKTOP-MF1UJ07\FREAKOVVSERVER;Initial Catalog=BeautyLab; Integrated Security=True; TrustServerCertificate=True");

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

        public void InsertEmailAndPassword(string email, string password)
        {
            string hashedPassword = HashPassword(password);
            using SqlCommand command = new SqlCommand("INSERT INTO Users (email, password) VALUES (@Email, @Password)", _homeConnection);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Password", hashedPassword);

            ExecuteNonQuery(command, "Email and password inserted successfully.");
        }

        public void InsertLoginNameSurname(string email, string login, string name, string surname)
        {
            using SqlCommand command = new SqlCommand("UPDATE Users SET login = @Login, name = @Name, surname = @Surname WHERE email = @Email", _homeConnection);
            command.Parameters.AddWithValue("@Login", login);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Surname", surname);
            command.Parameters.AddWithValue("@Email", email);

            ExecuteNonQuery(command, "Login, name, and surname inserted successfully.");
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

        private void ExecuteNonQuery(SqlCommand command, string successMessage)
        {
            try
            {
                OpenConnection();
                command.ExecuteNonQuery();
                MessageBox.Show(successMessage);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
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
                return 0; // Return 0 for error cases
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
    }
}
