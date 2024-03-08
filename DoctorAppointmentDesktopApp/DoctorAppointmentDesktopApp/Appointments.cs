using DoctorAppointmentDesktopApp.AppointmentHostService;
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
            _appointmentServiceClient = new AppointmentHostService.AppointmentServiceClient();
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
            dataGridViewAppointments.DataSource = appointments;
            dataGridViewAppointments.Columns["DoctorID"].Visible = false;
            dataGridViewAppointments.Columns["PatientID"].Visible = false;
            dataGridViewAppointments.Columns["StatusID"].Visible = false;
        }

        private void btnScheduleAppointment_Click(object sender, EventArgs e)
        {
            int selectedDoctorId = (int)cbDoctors.SelectedValue;
            int selectedPatientId = (int)cbPatients.SelectedValue;
            DateTime appointmentDateTime = dtpAppointmentDateTime.Value;

            _appointmentServiceClient.ScheduleAppointment(selectedDoctorId, selectedPatientId, appointmentDateTime);

            MessageBox.Show("Appointment scheduled successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Refresh appointments after scheduling
            LoadAppointments();
        }

        private void ScheduleAppointmentForm_Load(object sender, EventArgs e)
        {

        }

        private void cbPatients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridViewAppointments.SelectedRows.Count > 0)
            {
                int selectedAppointmentId = (int)dataGridViewAppointments.SelectedRows[0].Cells["AppointmentID"].Value;

                _appointmentServiceClient.CancelAppointment(selectedAppointmentId);

                MessageBox.Show("Appointment cancelled successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadAppointments();
            }
            else
            {
                MessageBox.Show("Please select an appointment to cancel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnScheduleAppointment_Click_1(object sender, EventArgs e)
        {
            int selectedDoctorId = (int)cbDoctors.SelectedValue;
            int selectedPatientId = (int)cbPatients.SelectedValue;
            DateTime appointmentDateTime = dtpAppointmentDateTime.Value;

            _appointmentServiceClient.ScheduleAppointment(selectedDoctorId, selectedPatientId, appointmentDateTime);

            MessageBox.Show("Appointment scheduled successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Refresh appointments after scheduling
            LoadAppointments();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridViewAppointments.SelectedRows.Count > 0)
            {
                int selectedAppointmentId = (int)dataGridViewAppointments.SelectedRows[0].Cells["AppointmentID"].Value;

                _appointmentServiceClient.CompleteAppointment(selectedAppointmentId);

                MessageBox.Show("Appointment completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadAppointments();
            }
            else
            {
                MessageBox.Show("Please select an appointment to mark as completed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
