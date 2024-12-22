using HealthClinic.Models;
using HealthClinic.Utils;
using System;
using System.Windows.Forms;

namespace HealthClinic.Forms
{
    /// \file AddPatient.cs
    /// \brief Form for adding a new patient in the HealthClinic application.

    public partial class AddPatient : Form
    {
        #region Constructor

        /// \brief Initializes a new instance of the AddPatient form.
        public AddPatient()
        {
            InitializeComponent();
        }

        #endregion

        #region Event Handlers

        /// \brief Handles the click event for saving a new patient.
        /// \param sender The source of the event.
        /// \param e The event data.
        private void btnSavePatient_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate required fields
                if (string.IsNullOrWhiteSpace(txtName.Text) ||
                    cmbGender.SelectedIndex == -1 ||
                    string.IsNullOrWhiteSpace(txtContactInfo.Text) ||
                    string.IsNullOrWhiteSpace(txtMedicalHistory.Text) ||
                    string.IsNullOrWhiteSpace(txtNIF.Text) ||
                    string.IsNullOrWhiteSpace(txtAddress.Text))
                {
                    MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Create the new Patient object
                var newPatient = new Patient(
                    name: txtName.Text,
                    gender: cmbGender.SelectedItem.ToString(),
                    contactInfo: txtContactInfo.Text,
                    medicalHistory: txtMedicalHistory.Text,
                    dateOfBirth: dtpDateOfBirth.Value,
                    nif: txtNIF.Text,
                    address: txtAddress.Text
                );

                // Save the new patient to the file
                var patients = DataPersistence.LoadDataFromFile<Patient>("patients.json");
                patients.Add(newPatient);
                DataPersistence.SaveDataToFile(patients, "patients.json");

                // Notify the user
                MessageBox.Show("Patient added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear the form
                ClearFormFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// \brief Clears all fields in the form.
        private void ClearFormFields()
        {
            txtName.Clear();
            cmbGender.SelectedIndex = -1;
            txtContactInfo.Clear();
            txtMedicalHistory.Clear();
            txtNIF.Clear();
            txtAddress.Clear();
            dtpDateOfBirth.Value = DateTime.Today;
        }

        /// \brief Handles the load event of the form.
        /// \param sender The source of the event.
        /// \param e The event data.
        private void AddPatient_Load(object sender, EventArgs e)
        {
            // Initialize default values if needed
            dtpDateOfBirth.MaxDate = DateTime.Today;
        }

        /// \brief Handles changes in the medical history text field.
        /// \param sender The source of the event.
        /// \param e The event data.
        private void txtMedicalHistory_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
