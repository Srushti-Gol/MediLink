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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewAppointments = new System.Windows.Forms.DataGridView();
            this.btnScheduleAppointment = new System.Windows.Forms.Button();
            this.dtpAppointmentDateTime = new System.Windows.Forms.DateTimePicker();
            this.cbPatients = new System.Windows.Forms.ComboBox();
            this.cbDoctors = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Cancel_appointment = new System.Windows.Forms.Button();
            this.Complate_appointment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAppointments
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            this.dataGridViewAppointments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAppointments.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAppointments.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewAppointments.GridColor = System.Drawing.Color.Gray;
            this.dataGridViewAppointments.Location = new System.Drawing.Point(36, 26);
            this.dataGridViewAppointments.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewAppointments.Name = "dataGridViewAppointments";
            this.dataGridViewAppointments.RowHeadersWidth = 51;
            this.dataGridViewAppointments.RowTemplate.Height = 42;
            this.dataGridViewAppointments.Size = new System.Drawing.Size(1596, 436);
            this.dataGridViewAppointments.TabIndex = 0;
            // 
            // btnScheduleAppointment
            // 
            this.btnScheduleAppointment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.btnScheduleAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScheduleAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnScheduleAppointment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnScheduleAppointment.Location = new System.Drawing.Point(54, 709);
            this.btnScheduleAppointment.Margin = new System.Windows.Forms.Padding(4);
            this.btnScheduleAppointment.Name = "btnScheduleAppointment";
            this.btnScheduleAppointment.Size = new System.Drawing.Size(243, 55);
            this.btnScheduleAppointment.TabIndex = 8;
            this.btnScheduleAppointment.Text = "Schedule Appointment";
            this.btnScheduleAppointment.UseVisualStyleBackColor = false;
            this.btnScheduleAppointment.Click += new System.EventHandler(this.btnScheduleAppointment_Click_1);
            // 
            // dtpAppointmentDateTime
            // 
            this.dtpAppointmentDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpAppointmentDateTime.Location = new System.Drawing.Point(200, 644);
            this.dtpAppointmentDateTime.Margin = new System.Windows.Forms.Padding(4);
            this.dtpAppointmentDateTime.Name = "dtpAppointmentDateTime";
            this.dtpAppointmentDateTime.Size = new System.Drawing.Size(501, 30);
            this.dtpAppointmentDateTime.TabIndex = 7;
            // 
            // cbPatients
            // 
            this.cbPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbPatients.FormattingEnabled = true;
            this.cbPatients.Location = new System.Drawing.Point(200, 597);
            this.cbPatients.Margin = new System.Windows.Forms.Padding(4);
            this.cbPatients.Name = "cbPatients";
            this.cbPatients.Size = new System.Drawing.Size(501, 33);
            this.cbPatients.TabIndex = 6;
            this.cbPatients.SelectedIndexChanged += new System.EventHandler(this.cbPatients_SelectedIndexChanged);
            // 
            // cbDoctors
            // 
            this.cbDoctors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbDoctors.FormattingEnabled = true;
            this.cbDoctors.Location = new System.Drawing.Point(200, 551);
            this.cbDoctors.Margin = new System.Windows.Forms.Padding(4);
            this.cbDoctors.Name = "cbDoctors";
            this.cbDoctors.Size = new System.Drawing.Size(501, 33);
            this.cbDoctors.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(49, 555);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Doctor Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(49, 603);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Patient Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(49, 644);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Date:";
            // 
            // Cancel_appointment
            // 
            this.Cancel_appointment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.Cancel_appointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel_appointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Cancel_appointment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cancel_appointment.Location = new System.Drawing.Point(600, 710);
            this.Cancel_appointment.Margin = new System.Windows.Forms.Padding(4);
            this.Cancel_appointment.Name = "Cancel_appointment";
            this.Cancel_appointment.Size = new System.Drawing.Size(221, 55);
            this.Cancel_appointment.TabIndex = 21;
            this.Cancel_appointment.Text = "Cancel Appointment";
            this.Cancel_appointment.UseVisualStyleBackColor = false;
            this.Cancel_appointment.Click += new System.EventHandler(this.button1_Click);
            // 
            // Complate_appointment
            // 
            this.Complate_appointment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(99)))));
            this.Complate_appointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Complate_appointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Complate_appointment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Complate_appointment.Location = new System.Drawing.Point(318, 710);
            this.Complate_appointment.Margin = new System.Windows.Forms.Padding(4);
            this.Complate_appointment.Name = "Complate_appointment";
            this.Complate_appointment.Size = new System.Drawing.Size(251, 55);
            this.Complate_appointment.TabIndex = 22;
            this.Complate_appointment.Text = "Complate Appointment";
            this.Complate_appointment.UseVisualStyleBackColor = false;
            this.Complate_appointment.Click += new System.EventHandler(this.button2_Click);
            // 
            // ScheduleAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1697, 954);
            this.Controls.Add(this.Complate_appointment);
            this.Controls.Add(this.Cancel_appointment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnScheduleAppointment);
            this.Controls.Add(this.dtpAppointmentDateTime);
            this.Controls.Add(this.cbPatients);
            this.Controls.Add(this.cbDoctors);
            this.Controls.Add(this.dataGridViewAppointments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ScheduleAppointmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedule Appointment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ScheduleAppointmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewAppointments;
        private System.Windows.Forms.Button btnScheduleAppointment;
        private System.Windows.Forms.DateTimePicker dtpAppointmentDateTime;
        private System.Windows.Forms.ComboBox cbPatients;
        private System.Windows.Forms.ComboBox cbDoctors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Cancel_appointment;
        private System.Windows.Forms.Button Complate_appointment;
    }
}
