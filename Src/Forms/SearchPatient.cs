using HealthClinic.Models;
using HealthClinic.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HealthClinic.Forms
{
    /// \file SearchPatient.cs
    /// \brief Form for searching and displaying patient details in the HealthClinic application.

    public partial class SearchPatient : Form
    {
        #region Fields

        /// \brief List of patients loaded from the data source.
        private List<Patient> patients;

        #endregion

        #region Constructor

        /// \brief Initializes a new instance of the SearchPatient form.
        public SearchPatient()
        {
            InitializeComponent();
            LoadPatients();
        }

        #endregion

        #region Private Methods

        /// \brief Loads patients from the data source into the patients list.
        private void LoadPatients()
        {
            try
            {
                // Load patients from JSON file
                patients = DataPersistence.LoadDataFromFile<Patient>("patients.json");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading patients: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// \brief Handles the click event for the search button.
        /// \param sender The source of the event.
        /// \param e The event data.
        private void btnSearchPatient_Click(object sender, EventArgs e)
        {
            try
            {
                string searchName = txtPatientName.Text.Trim();

                if (string.IsNullOrEmpty(searchName))
                {
                    MessageBox.Show("Please enter a patient name to search.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Search for the patient
                var patient = patients.FirstOrDefault(p => p.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase));

                if (patient != null)
                {
                    // Display patient details
                    lblPatientDetails.Text = $"Name: {patient.Name}\n" +
                                             $"Age: {patient.Age}\n" +
                                             $"Gender: {patient.Gender}\n" +
                                             $"Contact Info: {patient.ContactInfo}\n" +
                                             $"Medical History: {patient.MedicalHistory}\n" +
                                             $"NIF: {patient.GetNIF()}\n" +
                                             $"Address: {patient.GetAddress()}";
                }
                else
                {
                    lblPatientDetails.Text = string.Empty;
                    MessageBox.Show("Patient not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching for the patient: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// \brief Handles the load event of the form.
        /// \param sender The source of the event.
        /// \param e The event data.
        private void SearchPatient_Load(object sender, EventArgs e)
        {
            // Optional preload setup
        }

        /// \brief Additional load event handler (if required).
        /// \param sender The source of the event.
        /// \param e The event data.
        private void SearchPatient_Load_1(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
