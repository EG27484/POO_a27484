using HealthClinic.Models;
using HealthClinic.Utils;
using System;
using System.Linq;
using System.Windows.Forms;

namespace HealthClinic.Forms
{
    /// \file ViewAppointments.cs
    /// \brief Form for viewing and managing appointments in the HealthClinic application.

    public partial class ViewAppointments : Form
    {
        #region Constructor

        /// \brief Initializes a new instance of the ViewAppointments form.
        public ViewAppointments()
        {
            InitializeComponent();
            LoadAppointments();
        }

        #endregion

        #region Private Methods

        /// \brief Loads appointment data into the DataGridView control.
        private void LoadAppointments()
        {
            var appointments = AppointmentService.LoadAllAppointments();

            dgvAppointments.DataSource = appointments.Select(a => new
            {
                a.AppointmentID,
                PatientName = a.Patient?.Name ?? "N/A",
                DoctorName = a.Doctor?.Name ?? "N/A",
                a.OfficeRoom,
                AppointmentDate = a.AppointmentDate.ToString("dd/MM/yyyy HH:mm"),
                TotalCost = a.TotalCost.ToString("F2"),
                ExamsCount = a.PrescribedExams.Count,
                MedicationsCount = a.PrescribedMedications.Count
            }).ToList();
        }

        /// \brief Handles the cell double-click event for the DataGridView control.
        /// \param sender The source of the event.
        /// \param e The event data.
        private void dgvAppointments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int appointmentID = (int)dgvAppointments.Rows[e.RowIndex].Cells["AppointmentID"].Value;
                var appointments = AppointmentService.LoadAllAppointments();
                var selectedAppointment = appointments.FirstOrDefault(a => a.AppointmentID == appointmentID);

                if (selectedAppointment != null)
                {
                    AppointmentDetailsForm detailsForm = new AppointmentDetailsForm(selectedAppointment);
                    detailsForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Appointment not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// \brief Handles the cell content click event for the DataGridView control.
        /// \param sender The source of the event.
        /// \param e The event data.
        private void dgvAppointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell content click if needed
        }

        #endregion
    }
}
