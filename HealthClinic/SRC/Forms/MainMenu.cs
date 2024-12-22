using System;
using System.Windows.Forms;

namespace HealthClinic.Forms
{
    /// \file MainMenu.cs
    /// \brief Main menu form for navigating through different management sections of the HealthClinic application.

    public partial class MainMenu : Form
    {
        #region Constructor

        /// \brief Initializes a new instance of the MainMenu class.
        public MainMenu()
        {
            InitializeComponent();
        }

        #endregion

        #region Event Handlers

        /// \brief Handles the click event for managing patients.
        /// \param sender The source of the event.
        /// \param e The event data.
        private void btnManagePatients_Click(object sender, EventArgs e)
        {
            ManagePatientsForm managePatientsForm = new ManagePatientsForm();
            managePatientsForm.Show();
        }

        /// \brief Handles the click event for managing doctors.
        /// \param sender The source of the event.
        /// \param e The event data.
        private void btnManageDoctors_Click(object sender, EventArgs e)
        {
            ManageDoctorsForm manageDoctors = new ManageDoctorsForm();
            manageDoctors.Show();
        }

        /// \brief Handles the click event for managing appointments.
        /// \param sender The source of the event.
        /// \param e The event data.
        private void btnManageAppointments_Click(object sender, EventArgs e)
        {
            ManageAppointmentsForm manageAppointments = new ManageAppointmentsForm();
            manageAppointments.Show();
        }

        /// \brief Handles the load event of the form.
        /// \param sender The source of the event.
        /// \param e The event data.
        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
