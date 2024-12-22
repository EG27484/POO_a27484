using System.Drawing;
using System.Windows.Forms;

namespace HealthClinic.Forms
{
    /// \file AddPatient.Designer.cs
    /// \brief Designer class for the AddPatient form in the HealthClinic application.

    partial class AddPatient
    {
        #region Fields

        /// \brief Container for components used in the form.
        private System.ComponentModel.IContainer components = null;

        /// \brief TextBox for entering the patient's name.
        private TextBox txtName;

        /// \brief DateTimePicker for selecting the patient's date of birth.
        private DateTimePicker dtpDateOfBirth;

        /// \brief ComboBox for selecting the patient's gender.
        private ComboBox cmbGender;

        /// \brief TextBox for entering the patient's contact information.
        private TextBox txtContactInfo;

        /// \brief TextBox for entering the patient's medical history.
        private TextBox txtMedicalHistory;

        /// \brief TextBox for entering the patient's NIF.
        private TextBox txtNIF;

        /// \brief TextBox for entering the patient's address.
        private TextBox txtAddress;

        /// \brief Button for saving the patient information.
        private Button btnSavePatient;

        /// \brief Label for describing the date of birth field.
        private Label lblDateOfBirth;

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

        /// \brief Initializes the components of the AddPatient form.
        private void InitializeComponent()
        {
            txtName = new TextBox();
            dtpDateOfBirth = new DateTimePicker();
            cmbGender = new ComboBox();
            txtContactInfo = new TextBox();
            txtMedicalHistory = new TextBox();
            txtNIF = new TextBox();
            txtAddress = new TextBox();
            btnSavePatient = new Button();
            lblDateOfBirth = new Label();
            SuspendLayout();

            // 
            // txtName
            // 
            txtName.Location = new Point(20, 20);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Name";
            txtName.Size = new Size(200, 27);
            txtName.TabIndex = 0;

            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.Location = new Point(20, 67);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(125, 27);
            lblDateOfBirth.Text = "Date of Birth";
            lblDateOfBirth.TextAlign = ContentAlignment.MiddleLeft;

            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Format = DateTimePickerFormat.Short;
            dtpDateOfBirth.Location = new Point(168, 65);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(200, 27);
            dtpDateOfBirth.TabIndex = 1;

            // 
            // cmbGender
            // 
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            cmbGender.Location = new Point(20, 100);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(200, 28);
            cmbGender.TabIndex = 2;

            // 
            // txtContactInfo
            // 
            txtContactInfo.Location = new Point(20, 140);
            txtContactInfo.Name = "txtContactInfo";
            txtContactInfo.PlaceholderText = "Contact Information";
            txtContactInfo.Size = new Size(200, 27);
            txtContactInfo.TabIndex = 3;

            // 
            // txtMedicalHistory
            // 
            txtMedicalHistory.Location = new Point(20, 173);
            txtMedicalHistory.Multiline = true;
            txtMedicalHistory.Name = "txtMedicalHistory";
            txtMedicalHistory.PlaceholderText = "Medical History";
            txtMedicalHistory.Size = new Size(348, 86);
            txtMedicalHistory.TabIndex = 4;

            // 
            // txtNIF
            // 
            txtNIF.Location = new Point(20, 272);
            txtNIF.Name = "txtNIF";
            txtNIF.PlaceholderText = "NIF";
            txtNIF.Size = new Size(200, 27);
            txtNIF.TabIndex = 5;

            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(20, 305);
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "Address";
            txtAddress.Size = new Size(200, 27);
            txtAddress.TabIndex = 6;

            // 
            // btnSavePatient
            // 
            btnSavePatient.Location = new Point(89, 338);
            btnSavePatient.Name = "btnSavePatient";
            btnSavePatient.Size = new Size(200, 30);
            btnSavePatient.TabIndex = 7;
            btnSavePatient.Text = "Save Patient";
            btnSavePatient.Click += btnSavePatient_Click;

            // 
            // AddPatient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 380);
            Controls.Add(lblDateOfBirth);
            Controls.Add(txtName);
            Controls.Add(dtpDateOfBirth);
            Controls.Add(cmbGender);
            Controls.Add(txtContactInfo);
            Controls.Add(txtMedicalHistory);
            Controls.Add(txtNIF);
            Controls.Add(txtAddress);
            Controls.Add(btnSavePatient);
            Name = "AddPatient";
            Text = "Add Patient";
            Load += AddPatient_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
