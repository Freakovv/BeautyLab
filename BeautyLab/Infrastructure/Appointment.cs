namespace BeautyLab.Infrastructure
{
    public class Appointment
    {
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime AppointmentDate { get; set; }
        public TimeSpan AppointmentTime { get; set; }
        public string Master { get; set; }
        public string Service { get; set; }
        public int Cost { get; set; }
        public AppointmentStatus Status { get; set; }

        public Appointment(string fullName, string phoneNumber, DateTime appointmentDate, TimeSpan appointmentTime, string master, string service, int cost, AppointmentStatus status)
        {
            FullName = fullName;
            PhoneNumber = phoneNumber;
            AppointmentDate = appointmentDate;
            AppointmentTime = appointmentTime;
            Master = master;
            Service = service;
            Cost = cost;
            Status = status;
        }
    }

    public enum AppointmentStatus
    {
        Pending,  // Ожидает
        Completed, // Завершено
        Cancelled  // Отменено
    }

}
