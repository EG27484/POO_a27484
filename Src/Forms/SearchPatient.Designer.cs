using System.Drawing;
using System.Windows.Forms;

namespace HealthClinic.Forms
{
    /// \file SearchPatient.Designer.cs
    /// \brief Designer class for the SearchPatient form in the HealthClinic application.

    partial class SearchPatient
    {
        #region Fields

        /// \brief Container for components used in the form.
        private System.ComponentModel.IContainer components = null;

        /// \brief TextBox for entering the patient name.
        private TextBox txtPatientName;

        /// \brief Button to trigger the search action.
        private Button btnSearchPatient;

        /// \brief Label for displaying patient details.
        private Label lblPatientDetails;

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

        /// \brief Initializes the components of the SearchPatient form.
        private void InitializeComponent()
        {
            txtPatientName = new TextBox();
            btnSearchPatient = new Button();
            lblPatientDetails = new Label();
            SuspendLayout();

            // 
            // txtPatientName
            // 
            txtPatientName.Location = new Point(20, 20);
            txtPatientName.Name = "txtPatientName";
            txtPatientName.PlaceholderText = "Enter Patient Name";
            txtPatientName.Size = new Size(250, 27);
            txtPatientName.TabIndex = 0;

            // 
            // btnSearchPatient
            // 
            btnSearchPatient.Location = new Point(20, 60);
            btnSearchPatient.Name = "btnSearchPatient";
            btnSearchPatient.Size = new Size(200, 30);
            btnSearchPatient.TabIndex = 1;
            btnSearchPatient.Text = "Search Patient";
            btnSearchPatient.Click += btnSearchPatient_Click;

            // 
            // lblPatientDetails
            // 
            lblPatientDetails.AutoSize = true;
            lblPatientDetails.Location = new Point(20, 110);
            lblPatientDetails.Name = "lblPatientDetails";
            lblPatientDetails.Size = new Size(0, 20);
            lblPatientDetails.TabIndex = 2;

            // 
            // SearchPatient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 350);
            Controls.Add(txtPatientName);
            Controls.Add(btnSearchPatient);
            Controls.Add(lblPatientDetails);
            Name = "SearchPatient";
            Text = "Search Patient";
            Load += SearchPatient_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
