using System.Drawing;
using System.Windows.Forms;

namespace HealthClinic.Forms
{
    /// \file SearchDoctor.Designer.cs
    /// \brief Designer class for the SearchDoctor form in the HealthClinic application.

    partial class SearchDoctor
    {
        #region Fields

        /// \brief Container for components used in the form.
        private System.ComponentModel.IContainer components = null;

        /// \brief TextBox for entering the doctor name.
        private TextBox txtDoctorName;

        /// \brief Button to trigger the search action.
        private Button btnSearchDoctor;

        /// \brief Label for displaying doctor details.
        private Label lblDoctorDetails;

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

        /// \brief Initializes the components of the SearchDoctor form.
        private void InitializeComponent()
        {
            txtDoctorName = new TextBox();
            btnSearchDoctor = new Button();
            lblDoctorDetails = new Label();
            SuspendLayout();

            // 
            // txtDoctorName
            // 
            txtDoctorName.Location = new Point(20, 20);
            txtDoctorName.Name = "txtDoctorName";
            txtDoctorName.PlaceholderText = "Enter Doctor Name";
            txtDoctorName.Size = new Size(250, 27);
            txtDoctorName.TabIndex = 0;

            // 
            // btnSearchDoctor
            // 
            btnSearchDoctor.Location = new Point(20, 60);
            btnSearchDoctor.Name = "btnSearchDoctor";
            btnSearchDoctor.Size = new Size(200, 30);
            btnSearchDoctor.TabIndex = 1;
            btnSearchDoctor.Text = "Search Doctor";
            btnSearchDoctor.Click += btnSearchDoctor_Click;

            // 
            // lblDoctorDetails
            // 
            lblDoctorDetails.AutoSize = true;
            lblDoctorDetails.Location = new Point(20, 110);
            lblDoctorDetails.Name = "lblDoctorDetails";
            lblDoctorDetails.Size = new Size(0, 20);
            lblDoctorDetails.TabIndex = 2;

            // 
            // SearchDoctor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 322);
            Controls.Add(txtDoctorName);
            Controls.Add(btnSearchDoctor);
            Controls.Add(lblDoctorDetails);
            Name = "SearchDoctor";
            Text = "Search Doctor";
            Load += SearchDoctor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}