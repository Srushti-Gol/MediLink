using System;
using System.Drawing;
using System.Windows.Forms;

namespace DoctorAppointmentDesktopApp
{
    public partial class Form1 : Form
    {
        private Doctors form1;
        private Patients form2;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowForm1_Click(object sender, EventArgs e)
        {
            if (form1 == null || form1.IsDisposed)
            {
                form1 = new Doctors();
                form1.Show();
            }
            else
            {
                form1.BringToFront();
            }
        }

        private void btnShowForm2_Click(object sender, EventArgs e)
        {
            if (form2 == null || form2.IsDisposed)
            {
                form2 = new Patients();
                form2.Show();
            }
            else
            {
                form2.BringToFront();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set background color of the form
            this.BackColor = Color.LightBlue;

            // Set background color of specific controls
            btnShowForm1.BackColor = Color.Yellow;
            btnShowForm2.BackColor = Color.Green;
        }
    }
}
