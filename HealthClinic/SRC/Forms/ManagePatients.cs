using HealthClinic.Forms;
using System;
using System.Windows.Forms;

namespace HealthClinic.Forms
{
    /// \file ManagePatientsForm.cs
    /// \brief Form for managing patient-related actions in the HealthClinic application.

    public partial class ManagePatientsForm : Form
    {
        #region Constructor

        /// \brief Initializes a new instance of the ManagePatientsForm class.
        public ManagePatientsForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Event Handlers

        /// \brief Handles the click event for adding a patient.
        /// \param sender The source of the event.
        /// \param e The event data.
        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            AddPatient addPatient = new AddPatient();
            addPatient.Show();
        }

        /// \brief Handles the click event for deleting a patient.
        /// \param sender The source of the event.
        /// \param e The event data.
        private void btnDeletePatient_Click(object sender, EventArgs e)
        {
            DeletePatient deletePatient = new DeletePatient();
            deletePatient.Show();
        }

        /// \brief Handles the click event for viewing patients.
        /// \param sender The source of the event.
        /// \param e The event data.
        private void btnViewPatient_Click(object sender, EventArgs e)
        {
            ViewPatients viewPatients = new ViewPatients();
            viewPatients.Show();
        }

        /// \brief Handles the click event for searching a patient.
        /// \param sender The source of the event.
        /// \param e The event data.
        private void btnSearchPatient_Click(object sender, EventArgs e)
        {
            SearchPatient searchPatient = new SearchPatient();
            searchPatient.Show();
        }

        /// \brief Handles the load event of the form.
        /// \param sender The source of the event.
        /// \param e The event data.
        private void ManagePatientsForm_Load(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
