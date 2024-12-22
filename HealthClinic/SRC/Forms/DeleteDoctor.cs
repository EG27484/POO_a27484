using HealthClinic.Models;
using HealthClinic.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HealthClinic.Forms
{
    /// \file DeleteDoctor.cs
    /// \brief Form for deleting doctors in the HealthClinic application.

    public partial class DeleteDoctor : Form
    {
        #region Fields

        /// \brief List of doctors loaded from the data source.
        private List<Doctor> doctors;

        #endregion

        #region Constructor

        /// \brief Initializes a new instance of the DeleteDoctor form.
        public DeleteDoctor()
        {
            InitializeComponent();
            LoadDoctors();
        }

        #endregion

        #region Private Methods

        /// \brief Loads doctors from the data source and populates the ComboBox.
        private void LoadDoctors()
        {
            try
            {
                // Load doctors from JSON file
                doctors = DataPersistence.LoadDataFromFile<Doctor>("doctors.json");

                // Populate ComboBox
                cmbDoctors.Items.AddRange(doctors.Select(d => d.Name).ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading doctors: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// \brief Handles the click event for deleting a selected doctor.
        /// \param sender The source of the event.
        /// \param e The event data.
        private void btnDeleteDoctor_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbDoctors.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a doctor to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Get the selected doctor's name
                string selectedDoctorName = cmbDoctors.SelectedItem.ToString();

                // Find the doctor in the list
                var doctorToDelete = doctors.FirstOrDefault(d => d.Name.Equals(selectedDoctorName, StringComparison.OrdinalIgnoreCase));

                if (doctorToDelete != null)
                {
                    // Remove the doctor
                    doctors.Remove(doctorToDelete);

                    // Save updated list to JSON file
                    DataPersistence.SaveDataToFile(doctors, "doctors.json");

                    MessageBox.Show("Doctor deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh ComboBox
                    cmbDoctors.Items.Remove(selectedDoctorName);
                    Close();
                }
                else
                {
                    MessageBox.Show("Doctor not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the doctor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// \brief Handles the load event of the form.
        /// \param sender The source of the event.
        /// \param e The event data.
        private void DeleteDoctor_Load(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
