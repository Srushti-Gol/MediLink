using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoctorAppointmentDesktopApp.PatientHostService;
using DoctorAppointmentDesktopApp.DoctorHostService;
using DoctorAppointmentDesktopApp.AppointmentHostService;

namespace DoctorAppointmentDesktopApp
{
    public partial class DashBoard : Form
    {
        private readonly AppointmentServiceClient _appointmentServiceClient;
        private readonly DoctorServiceClient _doctorServiceClient;
        private readonly PatientServiceClient _patientServiceClient;

        private int doctors;

        public DashBoard()
        {
            InitializeComponent();
            _appointmentServiceClient = new AppointmentServiceClient();
            _doctorServiceClient = new DoctorServiceClient();
            _patientServiceClient = new PatientServiceClient();


            label4.Text = _appointmentServiceClient.GetTotalAppointments().ToString(); 
            label9.Text = _appointmentServiceClient.GetCanceledAppointments().ToString();
            label11.Text = _appointmentServiceClient.GetCompletedAppointments().ToString();
            label13.Text = _appointmentServiceClient.GetActiveAppointments().ToString();
            label5.Text = _doctorServiceClient.GetTotalDoctors().ToString();
            label7.Text = _patientServiceClient.GetTotalPatients().ToString();

        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

        }
    }
}
