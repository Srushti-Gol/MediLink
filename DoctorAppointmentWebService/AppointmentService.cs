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

        public List<Appointment> GetAllAppointments()
        {
            List<Appointment> appointments = new List<Appointment>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"SELECT Appointments.AppointmentID,
                                Appointments.DoctorID,
                                Doctors.FirstName AS DoctorFirstName,
                                Doctors.LastName AS DoctorLastName,
                                Appointments.PatientID,
                                Patients.FirstName AS PatientFirstName,
                                Patients.LastName AS PatientLastName,
                                Appointments.AppointmentDateTime,
                                Appointments.StatusID,
                                AppointmentStatus.StatusName AS Status
                         FROM Appointments
                         INNER JOIN Doctors ON Appointments.DoctorID = Doctors.DoctorID
                         INNER JOIN Patients ON Appointments.PatientID = Patients.PatientID
                         INNER JOIN AppointmentStatus ON Appointments.StatusID = AppointmentStatus.StatusID";

                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Appointment appointment = new Appointment
                    {
                        AppointmentID = Convert.ToInt32(reader["AppointmentID"]),
                        DoctorName = reader["DoctorFirstName"].ToString() + " " + reader["DoctorLastName"].ToString(),
                        PatientName = reader["PatientFirstName"].ToString() + " " + reader["PatientLastName"].ToString(),
                        AppointmentDateTime = Convert.ToDateTime(reader["AppointmentDateTime"]),
                        Status = reader["status"].ToString(),   

                    };

                    appointments.Add(appointment);
                }

                reader.Close();
            }

            return appointments;
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

        public int GetTotalAppointments()
        {
            int totalAppointments = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Appointments";

                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                totalAppointments = (int)command.ExecuteScalar();
            }

            return totalAppointments;
        }

        public int GetActiveAppointments()
        {
            int activeAppointments = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Appointments WHERE StatusID = 1"; // Assuming StatusID 1 represents 'Scheduled'

                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                activeAppointments = (int)command.ExecuteScalar();
            }

            return activeAppointments;
        }

        public int GetCanceledAppointments()
        {
            int canceledAppointments = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Appointments WHERE StatusID = 2"; // Assuming StatusID 2 represents 'Cancelled'

                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                canceledAppointments = (int)command.ExecuteScalar();
            }

            return canceledAppointments;
        }

        public int GetCompletedAppointments()
        {
            int completedAppointments = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Appointments WHERE StatusID = 3"; // Assuming StatusID 3 represents 'Completed'

                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                completedAppointments = (int)command.ExecuteScalar();
            }

            return completedAppointments;
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
        public List<Doctor> GetDoctors()
        {
            List<Doctor> doctors = new List<Doctor>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Doctors";

                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Doctor doctor = new Doctor
                    {
                        DoctorId = Convert.ToInt32(reader["DoctorId"]),
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        Specialty = reader["Specialty"].ToString(),
                        Email = reader["Email"].ToString(),
                        Phone = reader["Phone"].ToString()
                    };

                    doctors.Add(doctor);
                }

                reader.Close();
            }

            return doctors;
        }
        public List<Patient> GetPatients()
        {
            List<Patient> patients = new List<Patient>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Patients";

                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Patient patient = new Patient
                    {
                        PatientId = Convert.ToInt32(reader["PatientId"]),
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]),
                        Gender = reader["Gender"].ToString(),
                        Email = reader["Email"].ToString(),
                        Phone = reader["Phone"].ToString()
                    };

                    patients.Add(patient);
                }

                reader.Close();
            }

            return patients;
        }

    }
}
