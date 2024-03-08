using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DoctorAppointmentDesktopApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Retrieve connection string from app.config
            string connectionString = ConfigurationManager.ConnectionStrings["DoctorAppointmentDBConnectionString"].ConnectionString;

            // Use the connection string to establish a connection to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Open the connection
                    connection.Open();

                    // Connection successful, run the application
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Form1());
                }
                catch (Exception ex)
                {
                    // Handle connection errors
                    MessageBox.Show("Error connecting to database: " + ex.Message);
                    // Exit the application
                    return;
                }
            }
        }
    }
}
