using HealthClinic.Models;
using System.Drawing;
using System.Windows.Forms;

namespace HealthClinic.Forms
{
    /// \file AppointmentDetailsForm.cs
    /// \brief Form for displaying detailed information about an appointment.

    public partial class AppointmentDetailsForm : Form
    {
        #region Fields

        /// \brief The appointment object containing details to be displayed.
        private Appointment appointment;

        /// \brief Label for displaying the appointment date.
        private Label lblDate;

        #endregion

        #region Constructor

        /// \brief Initializes a new instance of the AppointmentDetailsForm class.
        /// \param appointment The appointment whose details will be displayed.
        public AppointmentDetailsForm(Appointment appointment)
        {
            InitializeComponent();
            this.appointment = appointment;

            // Initialize lblDate.
            lblDate = new Label
            {
                Location = new Point(20, 180),
                Size = new Size(400, 30)
            };
            Controls.Add(lblDate);

            LoadDetails();
        }

        #endregion

        #region Private Methods

        /// \brief Loads and displays the details of the appointment.
        private void LoadDetails()
        {
            // Set the text for all labels, including lblDate.
            lblPatient.Text = $"Patient: {appointment.Patient?.Name ?? "N/A"}";
            lblDoctor.Text = $"Doctor: {appointment.Doctor?.Name ?? "N/A"}";
            lblRoom.Text = $"Office Room: {appointment.OfficeRoom}";
            lblTotalCost.Text = $"Total Cost: {appointment.TotalCost:F2}";
            lblDate.Text = $"Appointment Date: {appointment.AppointmentDate:dd/MM/yyyy HH:mm}";

            // Bind data for exams and medications.
            lstExams.DataSource = new BindingSource(appointment.PrescribedExams, null);
            lstExams.DisplayMember = "Name";
            lstExams.ValueMember = "Cost";

            lstMedications.DataSource = new BindingSource(appointment.PrescribedMedications, null);
            lstMedications.DisplayMember = "Name";
            lstMedications.ValueMember = "Cost";
        }

        /// \brief Handles click events for the total cost label.
        /// \param sender The source of the event.
        /// \param e The event data.
        private void lblTotalCost_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}