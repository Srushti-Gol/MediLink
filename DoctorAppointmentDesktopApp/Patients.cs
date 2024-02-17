using DoctorAppointmentDesktopApp.PatientService;
using System;
using System.Windows.Forms;

namespace DoctorAppointmentDesktopApp
{
    public partial class Patients : Form
    {
        private readonly PatientServiceClient _patientServiceClient;
        private Patient selectedPatient;

        public Patients()
        {
            InitializeComponent();
            _patientServiceClient = new PatientService.PatientServiceClient();
            RefreshPatients();
        }

        private void RefreshPatients()
        {
            dataGridView1.DataSource = _patientServiceClient.GetPatients();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedPatientId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["PatientId"].Value);
                selectedPatient = _patientServiceClient.GetPatientById(selectedPatientId);
                txtFirstName.Text = selectedPatient.FirstName;
                txtLastName.Text = selectedPatient.LastName;
                dtpDateOfBirth.Value = selectedPatient.DateOfBirth;
                txtGender.Text = selectedPatient.Gender;
                txtEmail.Text = selectedPatient.Email;
                txtPhone.Text = selectedPatient.Phone;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Patient newPatient = new Patient
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                DateOfBirth = dtpDateOfBirth.Value,
                Gender = txtGender.Text,
                Email = txtEmail.Text,
                Phone = txtPhone.Text
            };
            _patientServiceClient.AddPatient(newPatient);
            RefreshPatients();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedPatient != null)
            {
                selectedPatient.FirstName = txtFirstName.Text;
                selectedPatient.LastName = txtLastName.Text;
                selectedPatient.DateOfBirth = dtpDateOfBirth.Value;
                selectedPatient.Gender = txtGender.Text;
                selectedPatient.Email = txtEmail.Text;
                selectedPatient.Phone = txtPhone.Text;
                _patientServiceClient.UpdatePatient(selectedPatient);
                RefreshPatients();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedPatient != null)
            {
                _patientServiceClient.DeletePatient(selectedPatient.PatientId);
                RefreshPatients();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
