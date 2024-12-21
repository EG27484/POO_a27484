using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace HealthClinic.Forms
{
    /// \file MainMenu.Designer.cs
    /// \brief Designer class for the MainMenu in the HealthClinic application.

    partial class MainMenu
    {
        #region Fields

        /// \brief Container for components used in the form.
        private System.ComponentModel.IContainer components = null;

        /// \brief Button for managing patients.
        private Button btnManagePatients;

        /// \brief Button for managing doctors.
        private Button btnManageDoctors;

        /// \brief Button for managing appointments.
        private Button btnManageAppointments;

        #endregion

        #region Methods

        /// \brief Disposes resources used by the form.
        /// \param disposing Indicates whether managed resources should be disposed.
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// \brief Initializes the components of the MainMenu form.
        private void InitializeComponent()
        {
            btnManagePatients = new Button();
            btnManageDoctors = new Button();
            btnManageAppointments = new Button();
            SuspendLayout();

            // 
            // btnManagePatients
            // 
            btnManagePatients.Location = new Point(20, 20);
            btnManagePatients.Name = "btnManagePatients";
            btnManagePatients.Size = new Size(200, 30);
            btnManagePatients.TabIndex = 0;
            btnManagePatients.Text = "Manage Patients";
            btnManagePatients.Click += btnManagePatients_Click;

            // 
            // btnManageDoctors
            // 
            btnManageDoctors.Location = new Point(20, 60);
            btnManageDoctors.Name = "btnManageDoctors";
            btnManageDoctors.Size = new Size(200, 30);
            btnManageDoctors.TabIndex = 1;
            btnManageDoctors.Text = "Manage Doctors";
            btnManageDoctors.Click += btnManageDoctors_Click;

            // 
            // btnManageAppointments
            // 
            btnManageAppointments.Location = new Point(20, 100);
            btnManageAppointments.Name = "btnManageAppointments";
            btnManageAppointments.Size = new Size(200, 30);
            btnManageAppointments.TabIndex = 2;
            btnManageAppointments.Text = "Manage Appointments";
            btnManageAppointments.Click += btnManageAppointments_Click;

            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(250, 160);
            Controls.Add(btnManagePatients);
            Controls.Add(btnManageDoctors);
            Controls.Add(btnManageAppointments);
            Name = "MainMenu";
            Text = "Main Menu";
            Load += MainMenu_Load;
            ResumeLayout(false);
        }

        #endregion
    }
}