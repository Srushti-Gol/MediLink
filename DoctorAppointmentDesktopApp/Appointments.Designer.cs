namespace DoctorAppointmentDesktopApp
{
    partial class ScheduleAppointmentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbDoctors = new System.Windows.Forms.ComboBox();
            this.cbPatients = new System.Windows.Forms.ComboBox();
            this.dtpAppointmentDateTime = new System.Windows.Forms.DateTimePicker();
            this.btnScheduleAppointment = new System.Windows.Forms.Button();
            this.dataGridViewAppointments = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // cbDoctors
            // 
            this.cbDoctors.FormattingEnabled = true;
            this.cbDoctors.Location = new System.Drawing.Point(12, 12);
            this.cbDoctors.Name = "cbDoctors";
            this.cbDoctors.Size = new System.Drawing.Size(200, 21);
            this.cbDoctors.TabIndex = 0;
            // 
            // cbPatients
            // 
            this.cbPatients.FormattingEnabled = true;
            this.cbPatients.Location = new System.Drawing.Point(12, 39);
            this.cbPatients.Name = "cbPatients";
            this.cbPatients.Size = new System.Drawing.Size(200, 21);
            this.cbPatients.TabIndex = 1;
            // 
            // dtpAppointmentDateTime
            // 
            this.dtpAppointmentDateTime.Location = new System.Drawing.Point(12, 66);
            this.dtpAppointmentDateTime.Name = "dtpAppointmentDateTime";
            this.dtpAppointmentDateTime.Size = new System.Drawing.Size(200, 20);
            this.dtpAppointmentDateTime.TabIndex = 2;
            // 
            // btnScheduleAppointment
            // 
            this.btnScheduleAppointment.Location = new System.Drawing.Point(12, 92);
            this.btnScheduleAppointment.Name = "btnScheduleAppointment";
            this.btnScheduleAppointment.Size = new System.Drawing.Size(200, 23);
            this.btnScheduleAppointment.TabIndex = 3;
            this.btnScheduleAppointment.Text = "Schedule Appointment";
            this.btnScheduleAppointment.UseVisualStyleBackColor = true;
            this.btnScheduleAppointment.Click += new System.EventHandler(this.btnScheduleAppointment_Click);
            // 
            // dataGridViewAppointments
            // 
            this.dataGridViewAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAppointments.Location = new System.Drawing.Point(12, 121);
            this.dataGridViewAppointments.Name = "dataGridViewAppointments";
            this.dataGridViewAppointments.Size = new System.Drawing.Size(776, 317);
            this.dataGridViewAppointments.TabIndex = 4;
            // 
            // ScheduleAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewAppointments);
            this.Controls.Add(this.btnScheduleAppointment);
            this.Controls.Add(this.dtpAppointmentDateTime);
            this.Controls.Add(this.cbPatients);
            this.Controls.Add(this.cbDoctors);
            this.Name = "ScheduleAppointmentForm";
            this.Text = "Schedule Appointment";
            this.Load += new System.EventHandler(this.ScheduleAppointmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDoctors;
        private System.Windows.Forms.ComboBox cbPatients;
        private System.Windows.Forms.DateTimePicker dtpAppointmentDateTime;
        private System.Windows.Forms.Button btnScheduleAppointment;
        private System.Windows.Forms.DataGridView dataGridViewAppointments;
    }
}
