using DoctorAppointmentDesktopApp.AppointmentService;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DoctorAppointmentDesktopApp
{
    public partial class ScheduleAppointmentForm : Form
    {
        private readonly AppointmentServiceClient _appointmentServiceClient;
        private Doctor[] doctors;
        private Patient[] patients;
        private Appointment[] appointments;

        public ScheduleAppointmentForm()
        {
            InitializeComponent();
            _appointmentServiceClient = new AppointmentService.AppointmentServiceClient();
            LoadDoctors();
            LoadPatients();
            LoadAppointments();
        }

        private void LoadDoctors()
        {
            doctors = _appointmentServiceClient.GetDoctors();
            cbDoctors.DataSource = doctors;
            cbDoctors.DisplayMember = "FirstName";
            cbDoctors.ValueMember = "DoctorId";
        }

        private void LoadPatients()
        {
            patients = _appointmentServiceClient.GetPatients();
            cbPatients.DataSource = patients;
            cbPatients.DisplayMember = "FirstName";
            cbPatients.ValueMember = "PatientId";
        }

        private void LoadAppointments()
        {
            appointments = _appointmentServiceClient.GetAllAppointments();
            dataGridView1.DataSource = appointments;
        }

        private void btnScheduleAppointment_Click(object sender, EventArgs e)
        {
            int selectedDoctorId = (int)cbDoctors.SelectedValue;
            int selectedPatientId = (int)cbPatients.SelectedValue;
            DateTime appointmentDateTime = dtpAppointmentDateTime.Value;

            _appointmentServiceClient.ScheduleAppointment(selectedDoctorId, selectedPatientId, appointmentDateTime);

            MessageBox.Show("Appointment scheduled successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadAppointments();
        }

        private void btnCancelAppointment_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedAppointmentId = (int)dataGridView1.SelectedRows[0].Cells["AppointmentID"].Value;

                _appointmentServiceClient.CancelAppointment(selectedAppointmentId);

                MessageBox.Show("Appointment cancelled successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadAppointments();
            }
            else
            {
                MessageBox.Show("Please select an appointment to cancel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCompleteAppointment_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedAppointmentId = (int)dataGridView1.SelectedRows[0].Cells["AppointmentID"].Value;

                _appointmentServiceClient.CompleteAppointment(selectedAppointmentId);

                MessageBox.Show("Appointment completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadAppointments();
            }
            else
            {
                MessageBox.Show("Please select an appointment to mark as completed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ScheduleAppointmentForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
