using HealthClinic.Forms;
using System;
using System.Windows.Forms;
using HealthClinic.Models;
using HealthClinic.Utils;
using System.Collections.Generic;

namespace HealthClinic.Forms
{
    /// \file ManageAppointmentsForm.cs
    /// \brief Form for managing appointment-related actions in the HealthClinic application.

    public partial class ManageAppointmentsForm : Form
    {
        #region Constructor

        /// \brief Initializes a new instance of the ManageAppointmentsForm class.
        public ManageAppointmentsForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Event Handlers

        /// \brief Handles the click event for adding an appointment.
        /// \param sender The source of the event.
        /// \param e The event data.
        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            // Load existing exams and medications from the data source
            List<Exam> existingExams = DataPersistence.LoadDataFromFile<Exam>("C:/path/to/exams.json");
            List<Medication> existingMedications = DataPersistence.LoadDataFromFile<Medication>("C:/path/to/medications.json");

            // Pass the loaded lists to the AddAppointment constructor
            AddAppointment addAppointment = new AddAppointment(existingExams, existingMedications);
            addAppointment.Show();
        }

        /// \brief Handles the click event for viewing appointments.
        /// \param sender The source of the event.
        /// \param e The event data.
        private void btnViewAppointments_Click(object sender, EventArgs e)
        {
            ViewAppointments viewAppointments = new ViewAppointments();
            viewAppointments.Show();
        }

        /// \brief Handles the load event of the form.
        /// \param sender The source of the event.
        /// \param e The event data.
        private void ManageAppointmentsForm_Load(object sender, EventArgs e)
        {

        }

        #endregion
    }
}