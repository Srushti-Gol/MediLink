using DoctorAppointmentDesktopApp.DoctorService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace DoctorAppointmentDesktopApp
{
    public partial class Doctors : Form
    {
        private readonly DoctorServiceClient _doctorServiceClient;
        private Doctor selectedDoctor;

        public Doctors()
        {
            InitializeComponent();
            _doctorServiceClient = new DoctorService.DoctorServiceClient();
            RefreshDoctors();
        }

        private void RefreshDoctors()
        {
            dataGridView1.DataSource = _doctorServiceClient.GetDoctors();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedDoctorId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["DoctorId"].Value);
                selectedDoctor = _doctorServiceClient.GetDoctorById(selectedDoctorId);
                txtFirstName.Text = selectedDoctor.FirstName;
                txtLastName.Text = selectedDoctor.LastName;
                txtSpecialty.Text = selectedDoctor.Specialty;
                txtEmail.Text = selectedDoctor.Email;
                txtPhone.Text = selectedDoctor.Phone;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Doctor newDoctor = new Doctor
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Specialty = txtSpecialty.Text,
                Email = txtEmail.Text,
                Phone = txtPhone.Text
            };
            _doctorServiceClient.AddDoctor(newDoctor);
            RefreshDoctors();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedDoctor != null)
            {
                selectedDoctor.FirstName = txtFirstName.Text;
                selectedDoctor.LastName = txtLastName.Text;
                selectedDoctor.Specialty = txtSpecialty.Text;
                selectedDoctor.Email = txtEmail.Text;
                selectedDoctor.Phone = txtPhone.Text;
                _doctorServiceClient.UpdateDoctor(selectedDoctor);
                RefreshDoctors();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedDoctor != null)
            {
                _doctorServiceClient.DeleteDoctor(selectedDoctor.DoctorId);
                RefreshDoctors();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
