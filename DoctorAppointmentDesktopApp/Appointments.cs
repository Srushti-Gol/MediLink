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
            cbDoctors.DisplayMember = "FullName";
            cbDoctors.ValueMember = "DoctorId";
        }

        private void LoadPatients()
        {
            patients = _appointmentServiceClient.GetPatients();
            cbPatients.DataSource = patients;
            cbPatients.DisplayMember = "FullName";
            cbPatients.ValueMember = "PatientId";
        }

        private void LoadAppointments()
        {
            // Load appointments for a specific doctor or all doctors
            // For example, assuming you have a doctorId variable or you can set it to any specific doctor
            int doctorId = 1; // Change to the appropriate doctor ID or remove if you want to load appointments for all doctors
            appointments = _appointmentServiceClient.GetDoctorAppointments(doctorId);
            dataGridViewAppointments.DataSource = appointments;
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
    }
}
