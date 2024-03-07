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
            Doctors d = new Doctors();
            d.TopLevel = false;
            panel10.Controls.Add(d);
            d.BringToFront();
            d.Show();
            label2.Text = "Doctor";
        }

        private void btnShowForm2_Click(object sender, EventArgs e)
        {
            Patients patients = new Patients();
            patients.TopLevel = false;
            panel10.Controls.Add(patients);
            patients.BringToFront();
            patients.Show();
            label2.Text = "Patients";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DashBoard d = new DashBoard();
            d.TopLevel = false;
            panel10.Controls.Add(d);
            d.BringToFront();
            d.Show();
            label2.Text = "DashBoard";
        }

        private void form1_resize(object sender, EventArgs e)
        {
            int hight = Screen.PrimaryScreen.Bounds.Height;
            int width = Screen.PrimaryScreen.Bounds.Width;
            this.Width = width;
            this.Height = hight - 40;
            Top = 0;
            Left = 0;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DashBoard d = new DashBoard();
            d.TopLevel = false;
            panel10.Controls.Add(d);
            d.BringToFront();
            d.Show();
            label2.Text = "DashBoard";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ScheduleAppointmentForm d = new ScheduleAppointmentForm();
            d.TopLevel = false;
            panel10.Controls.Add(d);
            d.BringToFront();
            d.Show();
            label2.Text = "Appintments";
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
