using HealthClinic.Models;
using HealthClinic.Utils;
using System;
using System.Windows.Forms;

namespace HealthClinic
{
    /// \file AddDoctor.cs
    /// \brief Form for adding a new doctor in the HealthClinic application.

    public partial class AddDoctor : Form
    {
        #region Constructor

        /// \brief Initializes a new instance of the AddDoctor form.
        public AddDoctor()
        {
            InitializeComponent();
        }

        #endregion

        #region Event Handlers

        /// \brief Handles the click event for saving a new doctor.
        /// \param sender The source of the event.
        /// \param e The event data.
        private void btnSaveDoctor_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate required fields
                if (string.IsNullOrWhiteSpace(txtName.Text) ||
                    cmbGender.SelectedIndex == -1 ||
                    string.IsNullOrWhiteSpace(txtContactInfo.Text) ||
                    string.IsNullOrWhiteSpace(txtSpecialty.Text) ||
                    string.IsNullOrWhiteSpace(txtConsultationFee.Text) ||
                    dtpDateOfBirth.Value == null)
                {
                    MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate consultation fee
                if (!decimal.TryParse(txtConsultationFee.Text, out decimal fee) || fee <= 0)
                {
                    MessageBox.Show("Please enter a valid consultation fee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Create a new Doctor object
                var newDoctor = new Doctor(
                    txtName.Text,
                    cmbGender.SelectedItem.ToString(),
                    txtContactInfo.Text,
                    dtpDateOfBirth.Value,
                    txtSpecialty.Text,
                    fee
                );

                // Save the new doctor to the file
                var doctors = DataPersistence.LoadDataFromFile<Doctor>("doctors.json");
                doctors.Add(newDoctor);
                DataPersistence.SaveDataToFile(doctors, "doctors.json");

                MessageBox.Show("Doctor added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear the form
                txtName.Clear();
                cmbGender.SelectedIndex = -1;
                txtContactInfo.Clear();
                txtSpecialty.Clear();
                txtConsultationFee.Clear();
                dtpDateOfBirth.Value = DateTime.Today;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// \brief Handles the load event of the form.
        /// \param sender The source of the event.
        /// \param e The event data.
        private void AddDoctor_Load(object sender, EventArgs e)
        {
            // Initialize default values
            dtpDateOfBirth.MaxDate = DateTime.Today;
        }

        #endregion
    }
}