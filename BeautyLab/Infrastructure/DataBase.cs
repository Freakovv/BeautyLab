using Microsoft.Data.SqlClient;
using System.Data;

namespace BeautyLab.Infrastructure
{
    internal class DataBase
    {
        protected readonly SqlConnection _connection;

        public DataBase()
        {
            _connection = new SqlConnection(@"Data Source=Freakovv;Initial Catalog=BeautyLab;
            Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;
            Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
        public DataBase(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
        }

        public void OpenConnection()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (_connection.State == ConnectionState.Open)
            {
                _connection.Close();
            }
        }

        protected int ExecuteScalar(SqlCommand command)
        {
            try
            {
                OpenConnection();
                return Convert.ToInt32(command.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                throw new Exception("Database access error: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        protected void ExecuteNonQuery(SqlCommand command)
        {
            try
            {
                OpenConnection();
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Database operation error: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public static string HashPassword(string password)
        {
            using var sha256 = System.Security.Cryptography.SHA256.Create();
            byte[] bytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            var builder = new System.Text.StringBuilder();
            foreach (var b in bytes)
            {
                builder.Append(b.ToString("x2"));
            }
            return builder.ToString();
        }

    }
}
