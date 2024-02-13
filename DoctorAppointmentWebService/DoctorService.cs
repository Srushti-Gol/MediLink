using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.ServiceModel;

namespace DoctorAppointmentWebService
{
    public class DoctorService : IDoctorService
    {
        private string connectionString = "Data Source=SRUSHTI\\SQLEXPRESS;Initial Catalog=DoctorAppointmentSystem;Integrated Security=True";

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
                        Specialty = reader["Specialty"].ToString()
                    };

                    doctors.Add(doctor);
                }

                reader.Close();
            }

            return doctors;
        }

        public Doctor GetDoctorById(int doctorId)
        {
            Doctor doctor = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Doctors WHERE DoctorId = @DoctorId";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DoctorId", doctorId);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    doctor = new Doctor
                    {
                        DoctorId = Convert.ToInt32(reader["DoctorId"]),
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        Specialty = reader["Specialty"].ToString()
                    };
                }

                reader.Close();
            }

            return doctor;
        }

        public void AddDoctor(Doctor doctor)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Doctors (FirstName, LastName, Specialty) VALUES (@FirstName, @LastName, @Specialty)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FirstName", doctor.FirstName);
                command.Parameters.AddWithValue("@LastName", doctor.LastName);
                command.Parameters.AddWithValue("@Specialty", doctor.Specialty);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void UpdateDoctor(Doctor doctor)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Doctors SET FirstName = @FirstName, LastName = @LastName, Specialty = @Specialty WHERE DoctorId = @DoctorId";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FirstName", doctor.FirstName);
                command.Parameters.AddWithValue("@LastName", doctor.LastName);
                command.Parameters.AddWithValue("@Specialty", doctor.Specialty);
                command.Parameters.AddWithValue("@DoctorId", doctor.DoctorId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeleteDoctor(int doctorId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Doctors WHERE DoctorId = @DoctorId";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DoctorId", doctorId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
