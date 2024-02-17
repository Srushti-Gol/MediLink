using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.ServiceModel;

namespace DoctorAppointmentWebService
{
    public class AppointmentService : IAppointmentService
    {
        private string connectionString = "Data Source=SRUSHTI\\SQLEXPRESS;Initial Catalog=DoctorAppointmentSystem;Integrated Security=True";

        public void ScheduleAppointment(int doctorId, int patientId, DateTime appointmentDateTime)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Appointments (DoctorID, PatientID, AppointmentDateTime, StatusID) VALUES (@DoctorID, @PatientID, @AppointmentDateTime, @StatusID)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DoctorID", doctorId);
                command.Parameters.AddWithValue("@PatientID", patientId);
                command.Parameters.AddWithValue("@AppointmentDateTime", appointmentDateTime);
                command.Parameters.AddWithValue("@StatusID", 1); // StatusID 1 represents 'Scheduled'

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void CancelAppointment(int appointmentId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Appointments SET StatusID = @StatusID WHERE AppointmentID = @AppointmentID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@StatusID", 2); // StatusID 2 represents 'Cancelled'
                command.Parameters.AddWithValue("@AppointmentID", appointmentId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void CompleteAppointment(int appointmentId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Appointments SET StatusID = @StatusID WHERE AppointmentID = @AppointmentID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@StatusID", 3); // StatusID 3 represents 'Completed'
                command.Parameters.AddWithValue("@AppointmentID", appointmentId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<Appointment> GetDoctorAppointments(int doctorId)
        {
            List<Appointment> appointments = new List<Appointment>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Appointments WHERE DoctorID = @DoctorID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DoctorID", doctorId);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Appointment appointment = new Appointment
                    {
                        AppointmentID = Convert.ToInt32(reader["AppointmentID"]),
                        DoctorID = Convert.ToInt32(reader["DoctorID"]),
                        PatientID = Convert.ToInt32(reader["PatientID"]),
                        AppointmentDateTime = Convert.ToDateTime(reader["AppointmentDateTime"]),
                        StatusID = Convert.ToInt32(reader["StatusID"])
                    };

                    appointments.Add(appointment);
                }

                reader.Close();
            }

            return appointments;
        }

        public List<Appointment> GetPatientAppointments(int patientId)
        {
            List<Appointment> appointments = new List<Appointment>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Appointments WHERE PatientID = @PatientID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PatientID", patientId);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Appointment appointment = new Appointment
                    {
                        AppointmentID = Convert.ToInt32(reader["AppointmentID"]),
                        DoctorID = Convert.ToInt32(reader["DoctorID"]),
                        PatientID = Convert.ToInt32(reader["PatientID"]),
                        AppointmentDateTime = Convert.ToDateTime(reader["AppointmentDateTime"]),
                        StatusID = Convert.ToInt32(reader["StatusID"])
                    };

                    appointments.Add(appointment);
                }

                reader.Close();
            }

            return appointments;
        }
    }
}
