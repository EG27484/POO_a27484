using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace HealthClinic.Forms
{
    /// \file DeletePatient.Designer.cs
    /// \brief Designer class for the DeletePatient form in the HealthClinic application.

    partial class DeletePatient
    {
        #region Fields

        /// \brief Container for components used in the form.
        private System.ComponentModel.IContainer components = null;

        /// \brief ComboBox for selecting a patient to delete.
        private ComboBox cmbPatients;

        /// \brief Button for deleting the selected patient.
        private Button btnDeletePatient;

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

        /// \brief Initializes the components of the DeletePatient form.
        private void InitializeComponent()
        {
            cmbPatients = new ComboBox();
            btnDeletePatient = new Button();
            SuspendLayout();

            // 
            // cmbPatients
            // 
            cmbPatients.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPatients.Location = new Point(20, 20);
            cmbPatients.Name = "cmbPatients";
            cmbPatients.Size = new Size(250, 28);
            cmbPatients.TabIndex = 0;

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
            // DeletePatient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 120);
            Controls.Add(cmbPatients);
            Controls.Add(btnDeletePatient);
            Name = "DeletePatient";
            Text = "Delete Patient";
            Load += DeletePatient_Load;
            ResumeLayout(false);
        }

        #endregion
    }
}
