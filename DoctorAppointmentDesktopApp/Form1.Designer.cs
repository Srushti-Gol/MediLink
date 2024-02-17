namespace DoctorAppointmentDesktopApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnShowForm1 = new System.Windows.Forms.Button();
            this.btnShowForm2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowForm1
            // 
            this.btnShowForm1.Location = new System.Drawing.Point(16, 15);
            this.btnShowForm1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowForm1.Name = "btnShowForm1";
            this.btnShowForm1.Size = new System.Drawing.Size(100, 28);
            this.btnShowForm1.TabIndex = 0;
            this.btnShowForm1.Text = "Doctors";
            this.btnShowForm1.UseVisualStyleBackColor = true;
            this.btnShowForm1.Click += new System.EventHandler(this.btnShowForm1_Click);
            // 
            // btnShowForm2
            // 
            this.btnShowForm2.Location = new System.Drawing.Point(124, 15);
            this.btnShowForm2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowForm2.Name = "btnShowForm2";
            this.btnShowForm2.Size = new System.Drawing.Size(100, 28);
            this.btnShowForm2.TabIndex = 1;
            this.btnShowForm2.Text = "Pateients";
            this.btnShowForm2.UseVisualStyleBackColor = true;
            this.btnShowForm2.Click += new System.EventHandler(this.btnShowForm2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnShowForm2);
            this.Controls.Add(this.btnShowForm1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnShowForm1;
        private System.Windows.Forms.Button btnShowForm2;
    }
}
