using HealthClinic.Models;
using HealthClinic.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HealthClinic.Forms
{
    /// \file SearchDoctor.cs
    /// \brief Form for searching and displaying doctor details in the HealthClinic application.

    public partial class SearchDoctor : Form
    {
        #region Fields

        /// \brief List of doctors loaded from the data source.
        private List<Doctor> doctors;

        #endregion

        #region Constructor

        /// \brief Initializes a new instance of the SearchDoctor form.
        public SearchDoctor()
        {
            InitializeComponent();
            LoadDoctors();
        }

        #endregion

        #region Private Methods

        /// \brief Loads doctors from the data source into the doctors list.
        private void LoadDoctors()
        {
            try
            {
                // Load doctors from JSON file
                doctors = DataPersistence.LoadDataFromFile<Doctor>("doctors.json");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading doctors: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// \brief Handles the click event for the search button.
        /// \param sender The source of the event.
        /// \param e The event data.
        private void btnSearchDoctor_Click(object sender, EventArgs e)
        {
            try
            {
                string searchName = txtDoctorName.Text.Trim();

                if (string.IsNullOrEmpty(searchName))
                {
                    MessageBox.Show("Please enter a doctor name to search.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Search for the doctor
                var doctor = doctors.FirstOrDefault(d => d.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase));

                if (doctor != null)
                {
                    // Display doctor details
                    lblDoctorDetails.Text = $"Name: {doctor.Name}\n" +
                                             $"Age: {doctor.Age}\n" +
                                             $"Gender: {doctor.Gender}\n" +
                                             $"Contact Info: {doctor.ContactInfo}\n" +
                                             $"Specialty: {doctor.Specialty}\n" +
                                             $"Consultation Fee: {doctor.ConsultationFee:C}";
                }
                else
                {
                    lblDoctorDetails.Text = string.Empty;
                    MessageBox.Show("Doctor not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching for the doctor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// \brief Handles the load event of the form.
        /// \param sender The source of the event.
        /// \param e The event data.
        private void SearchDoctor_Load(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
