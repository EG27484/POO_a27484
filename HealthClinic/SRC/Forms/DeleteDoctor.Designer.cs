using System.Drawing;
using System.Windows.Forms;

namespace HealthClinic.Forms
{
    /// \file DeleteDoctor.Designer.cs
    /// \brief Designer class for the DeleteDoctor form in the HealthClinic application.

    partial class DeleteDoctor
    {
        #region Fields

        /// \brief Container for components used in the form.
        private System.ComponentModel.IContainer components = null;

        /// \brief ComboBox for selecting a doctor to delete.
        private ComboBox cmbDoctors;

        /// \brief Button for deleting the selected doctor.
        private Button btnDeleteDoctor;

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

        /// \brief Initializes the components of the DeleteDoctor form.
        private void InitializeComponent()
        {
            cmbDoctors = new ComboBox();
            btnDeleteDoctor = new Button();
            SuspendLayout();

            // 
            // cmbDoctors
            // 
            cmbDoctors.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDoctors.Location = new Point(20, 20);
            cmbDoctors.Name = "cmbDoctors";
            cmbDoctors.Size = new Size(250, 28);
            cmbDoctors.TabIndex = 0;

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
            // DeleteDoctor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 120);
            Controls.Add(cmbDoctors);
            Controls.Add(btnDeleteDoctor);
            Name = "DeleteDoctor";
            Text = "Delete Doctor";
            Load += DeleteDoctor_Load;
            ResumeLayout(false);
        }

        #endregion
    }
}
