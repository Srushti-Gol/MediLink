using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.ServiceModel;

namespace DoctorAppointmentWebService
{
    public class PatientService : IPatientService
    {
        private string connectionString = "Data Source=localhost\\sqlexpress;Initial Catalog=DoctorAppointmentSystem;Integrated Security=True";

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

        public Patient GetPatientById(int patientId)
        {
            Patient patient = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Patients WHERE PatientId = @PatientId";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PatientId", patientId);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    patient = new Patient
                    {
                        PatientId = Convert.ToInt32(reader["PatientId"]),
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]),
                        Gender = reader["Gender"].ToString(),
                        Email = reader["Email"].ToString(),
                        Phone = reader["Phone"].ToString()
                    };
                }

                reader.Close();
            }

            return patient;
        }

        public void AddPatient(Patient patient)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Patients (FirstName, LastName, DateOfBirth, Gender, Email, Phone) VALUES (@FirstName, @LastName, @DateOfBirth, @Gender, @Email, @Phone)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FirstName", patient.FirstName);
                command.Parameters.AddWithValue("@LastName", patient.LastName);
                command.Parameters.AddWithValue("@DateOfBirth", patient.DateOfBirth);
                command.Parameters.AddWithValue("@Gender", patient.Gender);
                command.Parameters.AddWithValue("@Email", patient.Email);
                command.Parameters.AddWithValue("@Phone", patient.Phone);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void UpdatePatient(Patient patient)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Patients SET FirstName = @FirstName, LastName = @LastName, DateOfBirth = @DateOfBirth, Gender = @Gender, Email = @Email, Phone = @Phone WHERE PatientId = @PatientId";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FirstName", patient.FirstName);
                command.Parameters.AddWithValue("@LastName", patient.LastName);
                command.Parameters.AddWithValue("@DateOfBirth", patient.DateOfBirth);
                command.Parameters.AddWithValue("@Gender", patient.Gender);
                command.Parameters.AddWithValue("@Email", patient.Email);
                command.Parameters.AddWithValue("@Phone", patient.Phone);
                command.Parameters.AddWithValue("@PatientId", patient.PatientId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeletePatient(int patientId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Patients WHERE PatientId = @PatientId";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PatientId", patientId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
