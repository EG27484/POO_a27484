using HealthClinic.Models;
using HealthClinic.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HealthClinic.Forms
{
    /// \file DeletePatient.cs
    /// \brief Form for deleting patients in the HealthClinic application.

    public partial class DeletePatient : Form
    {
        #region Fields

        /// \brief List of patients loaded from the data source.
        private List<Patient> patients;

        #endregion

        #region Constructor

        /// \brief Initializes a new instance of the DeletePatient form.
        public DeletePatient()
        {
            InitializeComponent();
            LoadPatients();
        }

        #endregion

        #region Private Methods

        /// \brief Loads patients from the data source and populates the ComboBox.
        private void LoadPatients()
        {
            try
            {
                // Load patients from JSON file
                patients = DataPersistence.LoadDataFromFile<Patient>("patients.json");

                // Populate ComboBox
                cmbPatients.Items.AddRange(patients.Select(p => p.Name).ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading patients: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// \brief Handles the click event for deleting a selected patient.
        /// \param sender The source of the event.
        /// \param e The event data.
        private void btnDeletePatient_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbPatients.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a patient to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Get the selected patient's name
                string selectedPatientName = cmbPatients.SelectedItem.ToString();

                // Find the patient in the list
                var patientToDelete = patients.FirstOrDefault(p => p.Name.Equals(selectedPatientName, StringComparison.OrdinalIgnoreCase));

                if (patientToDelete != null)
                {
                    // Remove the patient
                    patients.Remove(patientToDelete);

                    // Save updated list to JSON file
                    DataPersistence.SaveDataToFile(patients, "patients.json");

                    MessageBox.Show("Patient deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh ComboBox
                    cmbPatients.Items.Remove(selectedPatientName);
                    Close();
                }
                else
                {
                    MessageBox.Show("Patient not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the patient: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// \brief Handles the load event of the form.
        /// \param sender The source of the event.
        /// \param e The event data.
        private void DeletePatient_Load(object sender, EventArgs e)
        {

        }

        #endregion
    }
}