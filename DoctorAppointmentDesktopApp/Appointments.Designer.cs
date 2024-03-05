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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDoctors = new System.Windows.Forms.ComboBox();
            this.cbPatients = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpAppointmentDateTime = new System.Windows.Forms.DateTimePicker();
            this.btnScheduleAppointment = new System.Windows.Forms.Button();
            this.btnCancelAppointment = new System.Windows.Forms.Button();
            this.btnCompleteAppointment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 18);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1380, 228);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(20, 326);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Doctor:";
            // 
            // cbDoctors
            // 
            this.cbDoctors.FormattingEnabled = true;
            this.cbDoctors.Location = new System.Drawing.Point(140, 326);
            this.cbDoctors.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cbDoctors.Name = "cbDoctors";
            this.cbDoctors.Size = new System.Drawing.Size(352, 24);
            this.cbDoctors.TabIndex = 2;
            // 
            // cbPatients
            // 
            this.cbPatients.FormattingEnabled = true;
            this.cbPatients.Location = new System.Drawing.Point(140, 390);
            this.cbPatients.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cbPatients.Name = "cbPatients";
            this.cbPatients.Size = new System.Drawing.Size(352, 24);
            this.cbPatients.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(20, 390);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Patient:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(20, 457);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Appointment Date:";
            // 
            // dtpAppointmentDateTime
            // 
            this.dtpAppointmentDateTime.Location = new System.Drawing.Point(275, 459);
            this.dtpAppointmentDateTime.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dtpAppointmentDateTime.Name = "dtpAppointmentDateTime";
            this.dtpAppointmentDateTime.Size = new System.Drawing.Size(352, 22);
            this.dtpAppointmentDateTime.TabIndex = 6;
            // 
            // btnScheduleAppointment
            // 
            this.btnScheduleAppointment.Location = new System.Drawing.Point(21, 526);
            this.btnScheduleAppointment.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnScheduleAppointment.Name = "btnScheduleAppointment";
            this.btnScheduleAppointment.Size = new System.Drawing.Size(356, 34);
            this.btnScheduleAppointment.TabIndex = 7;
            this.btnScheduleAppointment.Text = "Schedule Appointment";
            this.btnScheduleAppointment.UseVisualStyleBackColor = true;
            // 
            // btnCancelAppointment
            // 
            this.btnCancelAppointment.Location = new System.Drawing.Point(400, 526);
            this.btnCancelAppointment.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCancelAppointment.Name = "btnCancelAppointment";
            this.btnCancelAppointment.Size = new System.Drawing.Size(356, 34);
            this.btnCancelAppointment.TabIndex = 8;
            this.btnCancelAppointment.Text = "Cancel Appointment";
            this.btnCancelAppointment.UseVisualStyleBackColor = true;
            // 
            // btnCompleteAppointment
            // 
            this.btnCompleteAppointment.Location = new System.Drawing.Point(781, 526);
            this.btnCompleteAppointment.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCompleteAppointment.Name = "btnCompleteAppointment";
            this.btnCompleteAppointment.Size = new System.Drawing.Size(356, 34);
            this.btnCompleteAppointment.TabIndex = 9;
            this.btnCompleteAppointment.Text = "Complete Appointment";
            this.btnCompleteAppointment.UseVisualStyleBackColor = true;
            // 
            // ScheduleAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1697, 954);
            this.Controls.Add(this.btnCompleteAppointment);
            this.Controls.Add(this.btnCancelAppointment);
            this.Controls.Add(this.btnScheduleAppointment);
            this.Controls.Add(this.dtpAppointmentDateTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbPatients);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbDoctors);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ScheduleAppointmentForm";
            this.Text = "Schedule Appointment";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDoctors;
        private System.Windows.Forms.ComboBox cbPatients;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpAppointmentDateTime;
        private System.Windows.Forms.Button btnScheduleAppointment;
        private System.Windows.Forms.Button btnCancelAppointment;
        private System.Windows.Forms.Button btnCompleteAppointment;
    }
}
