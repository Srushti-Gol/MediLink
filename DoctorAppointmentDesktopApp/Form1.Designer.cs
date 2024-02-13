namespace DoctorAppointmentDesktopApp
{
    partial class Form1
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
            this.dataGridViewDoctors = new System.Windows.Forms.DataGridView();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxSpecialty = new System.Windows.Forms.TextBox();
            this.buttonAddDoctor = new System.Windows.Forms.Button();
            this.buttonUpdateDoctor = new System.Windows.Forms.Button();
            this.buttonDeleteDoctor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctors)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDoctors
            // 
            this.dataGridViewDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoctors.Location = new System.Drawing.Point(16, 15);
            this.dataGridViewDoctors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewDoctors.Name = "dataGridViewDoctors";
            this.dataGridViewDoctors.RowHeadersWidth = 51;
            this.dataGridViewDoctors.Size = new System.Drawing.Size(1035, 388);
            this.dataGridViewDoctors.TabIndex = 0;
            this.dataGridViewDoctors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDoctors_CellContentClick);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(16, 430);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(132, 22);
            this.textBoxFirstName.TabIndex = 1;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(173, 430);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(132, 22);
            this.textBoxLastName.TabIndex = 2;
            // 
            // textBoxSpecialty
            // 
            this.textBoxSpecialty.Location = new System.Drawing.Point(331, 430);
            this.textBoxSpecialty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSpecialty.Name = "textBoxSpecialty";
            this.textBoxSpecialty.Size = new System.Drawing.Size(132, 22);
            this.textBoxSpecialty.TabIndex = 3;
            // 
            // buttonAddDoctor
            // 
            this.buttonAddDoctor.Location = new System.Drawing.Point(508, 427);
            this.buttonAddDoctor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddDoctor.Name = "buttonAddDoctor";
            this.buttonAddDoctor.Size = new System.Drawing.Size(100, 28);
            this.buttonAddDoctor.TabIndex = 4;
            this.buttonAddDoctor.Text = "Add";
            this.buttonAddDoctor.UseVisualStyleBackColor = true;
            this.buttonAddDoctor.Click += new System.EventHandler(this.buttonAddDoctor_Click);
            // 
            // buttonUpdateDoctor
            // 
            this.buttonUpdateDoctor.Location = new System.Drawing.Point(641, 427);
            this.buttonUpdateDoctor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonUpdateDoctor.Name = "buttonUpdateDoctor";
            this.buttonUpdateDoctor.Size = new System.Drawing.Size(100, 28);
            this.buttonUpdateDoctor.TabIndex = 5;
            this.buttonUpdateDoctor.Text = "Update";
            this.buttonUpdateDoctor.UseVisualStyleBackColor = true;
            this.buttonUpdateDoctor.Click += new System.EventHandler(this.buttonUpdateDoctor_Click);
            // 
            // buttonDeleteDoctor
            // 
            this.buttonDeleteDoctor.Location = new System.Drawing.Point(775, 427);
            this.buttonDeleteDoctor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDeleteDoctor.Name = "buttonDeleteDoctor";
            this.buttonDeleteDoctor.Size = new System.Drawing.Size(100, 28);
            this.buttonDeleteDoctor.TabIndex = 6;
            this.buttonDeleteDoctor.Text = "Delete";
            this.buttonDeleteDoctor.UseVisualStyleBackColor = true;
            this.buttonDeleteDoctor.Click += new System.EventHandler(this.buttonDeleteDoctor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.buttonDeleteDoctor);
            this.Controls.Add(this.buttonUpdateDoctor);
            this.Controls.Add(this.buttonAddDoctor);
            this.Controls.Add(this.textBoxSpecialty);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.dataGridViewDoctors);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Doctor Appointment System";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDoctors;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxSpecialty;
        private System.Windows.Forms.Button buttonAddDoctor;
        private System.Windows.Forms.Button buttonUpdateDoctor;
        private System.Windows.Forms.Button buttonDeleteDoctor;
    }
}
