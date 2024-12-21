using HealthClinic.Forms;
using System;
using System.Windows.Forms;

namespace HealthClinic.Forms
{
    /// \file ManageDoctorsForm.cs
    /// \brief Form for managing doctor-related actions in the HealthClinic application.

    public partial class ManageDoctorsForm : Form
    {
        #region Constructor

        /// \brief Initializes a new instance of the ManageDoctorsForm class.
        public ManageDoctorsForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Event Handlers

        /// \brief Handles the click event for adding a doctor.
        /// \param sender The source of the event.
        /// \param e The event data.
        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            AddDoctor addDoctor = new AddDoctor();
            addDoctor.Show();
        }

        /// \brief Handles the click event for deleting a doctor.
        /// \param sender The source of the event.
        /// \param e The event data.
        private void btnDeleteDoctor_Click(object sender, EventArgs e)
        {
            DeleteDoctor deleteDoctor = new DeleteDoctor();
            deleteDoctor.Show();
        }

        /// \brief Handles the click event for viewing doctors.
        /// \param sender The source of the event.
        /// \param e The event data.
        private void btnViewDoctors_Click(object sender, EventArgs e)
        {
            ViewDoctors viewDoctors = new ViewDoctors();
            viewDoctors.Show();
        }

        /// \brief Handles the click event for searching a doctor.
        /// \param sender The source of the event.
        /// \param e The event data.
        private void btnSearchDoctor_Click(object sender, EventArgs e)
        {
            SearchDoctor searchDoctor = new SearchDoctor();
            searchDoctor.Show();
        }

        /// \brief Handles the load event of the form.
        /// \param sender The source of the event.
        /// \param e The event data.
        private void ManageDoctorsForm_Load(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
