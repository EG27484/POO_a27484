using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace HealthClinic.Forms
{
    /// \file ManageDoctorsForm.Designer.cs
    /// \brief Designer class for the ManageDoctorsForm in the HealthClinic application.

    partial class ManageDoctorsForm
    {
        #region Fields

        /// \brief Container for components used in the form.
        private System.ComponentModel.IContainer components = null;

        /// \brief Button for adding a new doctor.
        private Button btnAddDoctor;

        /// \brief Button for deleting a doctor.
        private Button btnDeleteDoctor;

        /// \brief Button for viewing doctors.
        private Button btnViewDoctors;

        /// \brief Button for searching a doctor.
        private Button btnSearchDoctor;

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

        /// \brief Initializes the components of the ManageDoctorsForm.
        private void InitializeComponent()
        {
            btnAddDoctor = new Button();
            btnDeleteDoctor = new Button();
            btnViewDoctors = new Button();
            btnSearchDoctor = new Button();
            SuspendLayout();

            // 
            // btnAddDoctor
            // 
            btnAddDoctor.Location = new Point(20, 20);
            btnAddDoctor.Name = "btnAddDoctor";
            btnAddDoctor.Size = new Size(200, 30);
            btnAddDoctor.TabIndex = 0;
            btnAddDoctor.Text = "Add Doctor";
            btnAddDoctor.Click += btnAddDoctor_Click;

            // 
            // btnDeleteDoctor
            // 
            btnDeleteDoctor.Location = new Point(20, 60);
            btnDeleteDoctor.Name = "btnDeleteDoctor";
            btnDeleteDoctor.Size = new Size(200, 30);
            btnDeleteDoctor.TabIndex = 1;
            btnDeleteDoctor.Text = "Delete Doctor";
            btnDeleteDoctor.Click += btnDeleteDoctor_Click;

            // 
            // btnViewDoctors
            // 
            btnViewDoctors.Location = new Point(20, 100);
            btnViewDoctors.Name = "btnViewDoctors";
            btnViewDoctors.Size = new Size(200, 30);
            btnViewDoctors.TabIndex = 2;
            btnViewDoctors.Text = "View Doctors";
            btnViewDoctors.Click += btnViewDoctors_Click;

            // 
            // btnSearchDoctor
            // 
            btnSearchDoctor.Location = new Point(20, 140);
            btnSearchDoctor.Name = "btnSearchDoctor";
            btnSearchDoctor.Size = new Size(200, 30);
            btnSearchDoctor.TabIndex = 3;
            btnSearchDoctor.Text = "Search Doctor";
            btnSearchDoctor.Click += btnSearchDoctor_Click;

            // 
            // ManageDoctorsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(250, 200);
            Controls.Add(btnAddDoctor);
            Controls.Add(btnDeleteDoctor);
            Controls.Add(btnViewDoctors);
            Controls.Add(btnSearchDoctor);
            Name = "ManageDoctorsForm";
            Text = "Manage Doctors";
            Load += ManageDoctorsForm_Load;
            ResumeLayout(false);
        }

        #endregion
    }
}