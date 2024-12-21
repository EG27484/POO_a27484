using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace HealthClinic.Forms
{
    /// \file ManagePatientsForm.Designer.cs
    /// \brief Designer class for the ManagePatientsForm in the HealthClinic application.

    partial class ManagePatientsForm
    {
        #region Fields

        /// \brief Container for components used in the form.
        private System.ComponentModel.IContainer components = null;

        /// \brief Button for adding a new patient.
        private Button btnAddPatient;

        /// \brief Button for deleting a patient.
        private Button btnDeletePatient;

        /// \brief Button for viewing patients.
        private Button btnViewPatient;

        /// \brief Button for searching a patient.
        private Button btnSearchPatient;

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

        /// \brief Initializes the components of the ManagePatientsForm.
        private void InitializeComponent()
        {
            btnAddPatient = new Button();
            btnDeletePatient = new Button();
            btnViewPatient = new Button();
            btnSearchPatient = new Button();
            SuspendLayout();

            // 
            // btnAddPatient
            // 
            btnAddPatient.Location = new Point(20, 20);
            btnAddPatient.Name = "btnAddPatient";
            btnAddPatient.Size = new Size(200, 30);
            btnAddPatient.TabIndex = 0;
            btnAddPatient.Text = "Add Patient";
            btnAddPatient.Click += btnAddPatient_Click;

            // 
            // btnDeletePatient
            // 
            btnDeletePatient.Location = new Point(20, 60);
            btnDeletePatient.Name = "btnDeletePatient";
            btnDeletePatient.Size = new Size(200, 30);
            btnDeletePatient.TabIndex = 1;
            btnDeletePatient.Text = "Delete Patient";
            btnDeletePatient.Click += btnDeletePatient_Click;

            // 
            // btnViewPatient
            // 
            btnViewPatient.Location = new Point(20, 100);
            btnViewPatient.Name = "btnViewPatient";
            btnViewPatient.Size = new Size(200, 30);
            btnViewPatient.TabIndex = 2;
            btnViewPatient.Text = "View Patients";
            btnViewPatient.Click += btnViewPatient_Click;

            // 
            // btnSearchPatient
            // 
            btnSearchPatient.Location = new Point(20, 140);
            btnSearchPatient.Name = "btnSearchPatient";
            btnSearchPatient.Size = new Size(200, 30);
            btnSearchPatient.TabIndex = 3;
            btnSearchPatient.Text = "Search Patient";
            btnSearchPatient.Click += btnSearchPatient_Click;

            // 
            // ManagePatientsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(250, 200);
            Controls.Add(btnAddPatient);
            Controls.Add(btnDeletePatient);
            Controls.Add(btnViewPatient);
            Controls.Add(btnSearchPatient);
            Name = "ManagePatientsForm";
            Text = "Manage Patients";
            Load += ManagePatientsForm_Load;
            ResumeLayout(false);
        }

        #endregion
    }
}
