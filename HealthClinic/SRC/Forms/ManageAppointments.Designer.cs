using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace HealthClinic.Forms
{
    /// \file ManageAppointmentsForm.Designer.cs
    /// \brief Designer class for the ManageAppointmentsForm in the HealthClinic application.
    partial class ManageAppointmentsForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnAddAppointment;
        private Button btnDeleteAppointment;
        private Button btnViewAppointments;
        private Button btnSearchAppointment;

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
            btnAddAppointment = new Button();
            btnDeleteAppointment = new Button();
            btnViewAppointments = new Button();
            btnSearchAppointment = new Button();
            SuspendLayout();
            // 
            // btnAddAppointment
            // 
            btnAddAppointment.Location = new Point(20, 20);
            btnAddAppointment.Name = "btnAddAppointment";
            btnAddAppointment.Size = new Size(200, 30);
            btnAddAppointment.TabIndex = 0;
            btnAddAppointment.Text = "Add Appointment";
            btnAddAppointment.Click += btnAddAppointment_Click;
            // 
            // btnDeleteAppointment
            // 
            btnDeleteAppointment.Location = new Point(0, 0);
            btnDeleteAppointment.Name = "btnDeleteAppointment";
            btnDeleteAppointment.Size = new Size(75, 23);
            btnDeleteAppointment.TabIndex = 1;
            // 
            // btnViewAppointments
            // 
            btnViewAppointments.Location = new Point(20, 100);
            btnViewAppointments.Name = "btnViewAppointments";
            btnViewAppointments.Size = new Size(200, 30);
            btnViewAppointments.TabIndex = 2;
            btnViewAppointments.Text = "View Appointments";
            btnViewAppointments.Click += btnViewAppointments_Click;
            // 
            // btnSearchAppointment
            // 
            btnSearchAppointment.Location = new Point(0, 0);
            btnSearchAppointment.Name = "btnSearchAppointment";
            btnSearchAppointment.Size = new Size(75, 23);
            btnSearchAppointment.TabIndex = 3;
            // 
            // ManageAppointmentsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(250, 200);
            Controls.Add(btnAddAppointment);
            Controls.Add(btnDeleteAppointment);
            Controls.Add(btnViewAppointments);
            Controls.Add(btnSearchAppointment);
            Name = "ManageAppointmentsForm";
            Text = "Manage Appointments";
            Load += ManageAppointmentsForm_Load;
            ResumeLayout(false);
        }
    }
}
