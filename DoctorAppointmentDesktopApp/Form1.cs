using DoctorAppointmentDesktopApp.DoctorService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DoctorAppointmentDesktopApp
{
    public partial class Form1 : Form
    {
        private readonly DoctorServiceClient doctorServiceClient;

        public Form1()
        {
            InitializeComponent();

            // Initialize the DoctorServiceClient
            doctorServiceClient = new DoctorServiceClient();

            // Populate the DataGridView with doctors
            RefreshDoctors();
        }

        private void RefreshDoctors()
        {
            Doctor[] doctorsArray = doctorServiceClient.GetDoctors();
            List<Doctor> doctors = doctorsArray.ToList();
            dataGridViewDoctors.DataSource = doctors;
        }

        private void buttonAddDoctor_Click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor
            {
                FirstName = textBoxFirstName.Text,
                LastName = textBoxLastName.Text,
                Specialty = textBoxSpecialty.Text
            };

            doctorServiceClient.AddDoctor(doctor);
            RefreshDoctors();
        }

        private void buttonUpdateDoctor_Click(object sender, EventArgs e)
        {
            if (dataGridViewDoctors.SelectedRows.Count > 0)
            {
                int doctorId = (int)dataGridViewDoctors.SelectedRows[0].Cells["DoctorId"].Value;

                Doctor doctor = new Doctor
                {
                    DoctorId = doctorId,
                    FirstName = textBoxFirstName.Text,
                    LastName = textBoxLastName.Text,
                    Specialty = textBoxSpecialty.Text
                };

                doctorServiceClient.UpdateDoctor(doctor);
                RefreshDoctors();
            }
            else
            {
                MessageBox.Show("Please select a doctor to update.");
            }
        }

        private void buttonDeleteDoctor_Click(object sender, EventArgs e)
        {
            if (dataGridViewDoctors.SelectedRows.Count > 0)
            {
                int doctorId = (int)dataGridViewDoctors.SelectedRows[0].Cells["DoctorId"].Value;
                doctorServiceClient.DeleteDoctor(doctorId);
                RefreshDoctors();
            }
            else
            {
                MessageBox.Show("Please select a doctor to delete.");
            }
        }

        private void dataGridViewDoctors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
