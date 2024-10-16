using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace BeautyLab
{
    //TODO: Метод для получения данных
    internal class DataBase
    {
        private readonly SqlConnection homeConnection =
            new SqlConnection(
                @"Data Source=DESKTOP-16N2RPD\FREAKOVVSERVER;Initial Catalog=BeautyLab; Integrated Security=True; TrustServerCertificate=True");


        public void OpenConnection()
        {
            if (homeConnection.State == ConnectionState.Closed)
            {
                homeConnection.Open();
            }
        }

        public void CloseConnection()
        {
            if (homeConnection.State == ConnectionState.Open)
            {
                homeConnection.Close();
            }
        }

        public SqlConnection GetHomeConnection()
        {
            return homeConnection;
        }

        public void InsertEmailAndPassword(string email, string password)
        {
            using SqlCommand command = new SqlCommand("INSERT INTO Users (email, password) VALUES (@Email, @Password)", homeConnection);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Password", password);

            try
            {
                OpenConnection();
                command.ExecuteNonQuery();
                MessageBox.Show("Email and password inserted successfully.");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error inserting email and password: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void InsertLoginNameSurname(string email, string login, string name, string surname)
        {
            using SqlCommand command = new SqlCommand("UPDATE Users SET login = @Login, name = @Name, surname = @Surname WHERE email = @Email", homeConnection);
            command.Parameters.AddWithValue("@Login", login);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Surname", surname);
            command.Parameters.AddWithValue("@Email", email); // Замените на реальный email

            try
            {
                OpenConnection();
                command.ExecuteNonQuery();
                MessageBox.Show("Login, name, and surname inserted successfully.");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error inserting login, name, and surname: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public bool AccountExists(string email)
        {
            using SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Users WHERE email = @Email", homeConnection);
            command.Parameters.AddWithValue("@Email", email);

            try
            {
                OpenConnection();
                int count = (int)command.ExecuteScalar();
                return count > 0; 
            }
            catch (SqlException ex)
            {
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }

    }
}
