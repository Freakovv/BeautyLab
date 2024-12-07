using Microsoft.Data.SqlClient;

namespace BeautyLab.Infrastructure
{
    internal class AppointmentManager : DataBase
    {
        public AppointmentManager() : base() { }

        // Метод для добавления записи
        public void AddAppointment(string fullName, string phoneNumber, DateTime appointmentDate, TimeSpan appointmentTime, string master, string service, int cost, AppointmentStatus status)
        {
            string query = "INSERT INTO Appointments (FullName, PhoneNumber, AppointmentDate, AppointmentTime, Master, Service, Cost, Status) " +
                           "VALUES (@FullName, @PhoneNumber, @AppointmentDate, @AppointmentTime, @Master, @Service, @Cost, @Status)";

            using SqlCommand command = new SqlCommand(query, _connection);
            command.Parameters.AddWithValue("@FullName", fullName);
            command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
            command.Parameters.AddWithValue("@AppointmentDate", appointmentDate);
            command.Parameters.AddWithValue("@AppointmentTime", appointmentTime);
            command.Parameters.AddWithValue("@Master", master);
            command.Parameters.AddWithValue("@Service", service);
            command.Parameters.AddWithValue("@Cost", cost);
            command.Parameters.AddWithValue("@Status", status.ToString());

            ExecuteNonQuery(command);
        }

        // Метод для удаления записи по ID
        public void DeleteAppointment(int appointmentId)
        {
            string query = "DELETE FROM Appointments WHERE AppointmentId = @AppointmentId";

            using SqlCommand command = new SqlCommand(query, _connection);
            command.Parameters.AddWithValue("@AppointmentId", appointmentId);

            ExecuteNonQuery(command);
        }

        // Метод для изменения статуса записи
        public void UpdateAppointmentStatus(int appointmentId, AppointmentStatus newStatus)
        {
            string query = "UPDATE Appointments SET Status = @Status WHERE AppointmentId = @AppointmentId";

            using SqlCommand command = new SqlCommand(query, _connection);
            command.Parameters.AddWithValue("@Status", newStatus.ToString());
            command.Parameters.AddWithValue("@AppointmentId", appointmentId);

            ExecuteNonQuery(command);
        }

        // Метод для получения всех записей
        public List<Appointment> GetAllAppointments()
        {
            string query = "SELECT AppointmentId, FullName, PhoneNumber, AppointmentDate, AppointmentTime, Master, Service, Cost, Status FROM Appointments";

            using SqlCommand command = new SqlCommand(query, _connection);
            OpenConnection();

            using SqlDataReader reader = command.ExecuteReader();
            List<Appointment> appointments = new List<Appointment>();

            while (reader.Read())
            {
                var appointment = new Appointment(
                    fullName: reader["FullName"].ToString(),
                    phoneNumber: reader["PhoneNumber"].ToString(),
                    appointmentDate: Convert.ToDateTime(reader["AppointmentDate"]),
                    appointmentTime: TimeSpan.Parse(reader["AppointmentTime"].ToString()),
                    master: reader["Master"].ToString(),
                    service: reader["Service"].ToString(),
                    cost: Convert.ToInt32(reader["Cost"]),
                    status: Enum.Parse<AppointmentStatus>(reader["Status"].ToString())
                );

                appointments.Add(appointment);
            }

            CloseConnection();
            return appointments;
        }
    }
}