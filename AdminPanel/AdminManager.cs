using Microsoft.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace AdminPanel
{
    internal class AdminManager
    {
        private readonly SqlConnection _connection;
        public SqlConnection connection { get { return _connection; } }

        public AdminManager(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
        }

        public AdminManager()
        {
            _connection = new SqlConnection(@"Data Source=Freakovv;Initial Catalog=BeautyLab;
            Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;
            Application Intent=ReadWrite;Multi Subnet Failover=False");
        }


        public void AddAdmin(string login, string password)
        {
            if (AccountExists(login))
            {
                throw new ArgumentException("Пользователь с таким логином уже существует.");
            }

            string hashedPassword = HashPassword(password);

            // SQL-запрос для добавления администратора
            string query = "INSERT INTO Users (email, password, access) VALUES (@Login, @Password, @Access)";
            using SqlCommand command = new SqlCommand(query, _connection);
            command.Parameters.AddWithValue("@Login", login); // Логин используется как email
            command.Parameters.AddWithValue("@Password", hashedPassword);
            command.Parameters.AddWithValue("@Access", 1); // Уровень доступа 

            ExecuteNonQuery(command);
        }

        public void DeleteAdmin(string login)
        {
            if (!AccountExists(login))
            {
                throw new ArgumentException("Пользователь с таким логином не существует.");
            }

            // SQL-запрос для удаления администратора
            string query = "DELETE FROM Users WHERE email = @Login AND access = 1";
            using SqlCommand command = new SqlCommand(query, _connection);
            command.Parameters.AddWithValue("@Login", login); // Логин используется как email

            ExecuteNonQuery(command);
        }

        private bool AccountExists(string login)
        {
            // SQL-запрос для проверки существования пользователя
            string query = "SELECT COUNT(*) FROM Users WHERE email = @Login";
            using SqlCommand command = new SqlCommand(query, _connection);
            command.Parameters.AddWithValue("@Login", login);

            return ExecuteScalar(command) > 0;
        }

        private void ExecuteNonQuery(SqlCommand command)
        {
            try
            {
                OpenConnection();
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Ошибка при выполнении команды: " + ex.Message);
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
                throw new Exception("Ошибка при выполнении запроса: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        private static string HashPassword(string password)
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

        public void OpenConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Open)
            {
                _connection.Close();
            }
        }
    }
}
