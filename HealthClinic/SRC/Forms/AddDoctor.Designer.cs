using System.Drawing;
using System.Windows.Forms;

namespace HealthClinic
{
    /// \file AddDoctor.Designer.cs
    /// \brief Designer class for the AddDoctor form in the HealthClinic application.

    partial class AddDoctor
    {
        #region Fields

        /// \brief Container for components used in the form.
        private System.ComponentModel.IContainer components = null;

        /// \brief TextBox for entering the doctor's name.
        private TextBox txtName;

        /// \brief DateTimePicker for selecting the doctor's date of birth.
        private DateTimePicker dtpDateOfBirth;

        /// \brief ComboBox for selecting the doctor's gender.
        private ComboBox cmbGender;

        /// \brief TextBox for entering the doctor's contact information.
        private TextBox txtContactInfo;

        /// \brief TextBox for entering the doctor's specialty.
        private TextBox txtSpecialty;

        /// \brief TextBox for entering the doctor's consultation fee.
        private TextBox txtConsultationFee;

        /// \brief Button for saving the doctor's information.
        private Button btnSaveDoctor;

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

        /// \brief Initializes the components of the AddDoctor form.
        private void InitializeComponent()
        {
            txtName = new TextBox();
            dtpDateOfBirth = new DateTimePicker();
            cmbGender = new ComboBox();
            txtContactInfo = new TextBox();
            txtSpecialty = new TextBox();
            txtConsultationFee = new TextBox();
            btnSaveDoctor = new Button();
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
            dtpDateOfBirth.Location = new Point(166, 67);
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
            // txtSpecialty
            // 
            txtSpecialty.Location = new Point(20, 180);
            txtSpecialty.Name = "txtSpecialty";
            txtSpecialty.PlaceholderText = "Specialty";
            txtSpecialty.Size = new Size(200, 27);
            txtSpecialty.TabIndex = 4;

            // 
            // txtConsultationFee
            // 
            txtConsultationFee.Location = new Point(20, 220);
            txtConsultationFee.Name = "txtConsultationFee";
            txtConsultationFee.PlaceholderText = "Consultation Fee";
            txtConsultationFee.Size = new Size(200, 27);
            txtConsultationFee.TabIndex = 5;

            // 
            // btnSaveDoctor
            // 
            btnSaveDoctor.Location = new Point(20, 260);
            btnSaveDoctor.Name = "btnSaveDoctor";
            btnSaveDoctor.Size = new Size(200, 30);
            btnSaveDoctor.TabIndex = 6;
            btnSaveDoctor.Text = "Save Doctor";
            btnSaveDoctor.Click += btnSaveDoctor_Click;

            // 
            // AddDoctor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 320);
            Controls.Add(lblDateOfBirth);
            Controls.Add(txtName);
            Controls.Add(dtpDateOfBirth);
            Controls.Add(cmbGender);
            Controls.Add(txtContactInfo);
            Controls.Add(txtSpecialty);
            Controls.Add(txtConsultationFee);
            Controls.Add(btnSaveDoctor);
            Name = "AddDoctor";
            Text = "Add Doctor";
            Load += AddDoctor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}