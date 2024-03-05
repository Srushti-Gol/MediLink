using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoctorAppointmentHost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ServiceHost sh1 = new ServiceHost(typeof(DoctorAppointmentWebService.DoctorService));
            ServiceHost sh2 = new ServiceHost(typeof(DoctorAppointmentWebService.PatientService));
            ServiceHost sh3 = new ServiceHost(typeof(DoctorAppointmentWebService.AppointmentService));
            sh1.Open();
            sh2.Open();
            sh3.Open();
            label1.Text = "Service Running";
        }
    }
}
