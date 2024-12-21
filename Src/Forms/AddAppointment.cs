using HealthClinic.Models;
using HealthClinic.Utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HealthClinic.Forms
{
    /// \file AddAppointment.cs
    /// \brief Form for adding a new appointment in the HealthClinic application.

    public partial class AddAppointment : Form
    {
        #region Fields

        /// \brief List of patients available for selection.
        private List<Patient> patients;

        /// \brief List of doctors available for selection.
        private List<Doctor> doctors;

        /// \brief Instance of the new appointment being created.
        private Appointment newAppointment;

        /// \brief DateTimePicker for selecting the appointment date and time.
        private DateTimePicker dtpAppointmentDate;

        #endregion

        #region Constructor

        /// \brief Initializes a new instance of the AddAppointment form.
        /// \param existingExams List of existing exams available for selection.
        /// \param existingMedications List of existing medications available for selection.
        public AddAppointment(List<Exam> existingExams, List<Medication> existingMedications)
        {
            InitializeComponent();

            int nextID = AppointmentService.GetNextID();
            newAppointment = new Appointment(nextID, null, null, "");

            dtpAppointmentDate = new DateTimePicker
            {
                Format = DateTimePickerFormat.Custom,
                CustomFormat = "dd/MM/yyyy HH:mm",
                Location = new Point(160, 210),
                Size = new Size(228, 27)
            };
            Controls.Add(dtpAppointmentDate);

            Label lblDate = new Label
            {
                Text = "Appointment Date:",
                Location = new Point(42, 210),
                Size = new Size(120, 27)
            };
            Controls.Add(lblDate);

            LoadData();
        }

        #endregion

        #region Private Methods

        /// \brief Loads data for patients and doctors into their respective ComboBoxes.
        private void LoadData()
        {
            patients = DataPersistence.LoadDataFromFile<Patient>("patients.json");
            doctors = DataPersistence.LoadDataFromFile<Doctor>("doctors.json");

            cmbPatients.DataSource = patients;
            cmbPatients.DisplayMember = "Name";
            cmbDoctors.DataSource = doctors;
            cmbDoctors.DisplayMember = "Name";
        }

        /// \brief Adds a new exam to the appointment.
        private void btnAddExam_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtExamName.Text) && decimal.TryParse(txtExamCost.Text, out decimal cost))
            {
                var exam = new Exam(txtExamName.Text, cost);
                newAppointment.AddExam(exam);
                MessageBox.Show($"Exam '{txtExamName.Text}' added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtExamName.Clear();
                txtExamCost.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a valid exam name and cost.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// \brief Adds a new medication to the appointment.
        private void btnAddMedication_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMedicationName.Text) && decimal.TryParse(txtMedicationCost.Text, out decimal cost))
            {
                var medication = new Medication(txtMedicationName.Text, cost);
                newAppointment.AddMedication(medication);
                MessageBox.Show($"Medication '{txtMedicationName.Text}' added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMedicationName.Clear();
                txtMedicationCost.Clear();
            }
            else
            {
                MessageBox.Show("Please enter valid medication details (name and cost).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// \brief Saves the new appointment.
        private void btnSaveAppointment_Click(object sender, EventArgs e)
        {
            if (cmbPatients.SelectedIndex == -1 || cmbDoctors.SelectedIndex == -1 || string.IsNullOrEmpty(txtOfficeRoom.Text))
            {
                MessageBox.Show("Please select a patient, doctor, and enter an office room.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedPatient = patients[cmbPatients.SelectedIndex];
            var selectedDoctor = doctors[cmbDoctors.SelectedIndex];
            var officeRoom = txtOfficeRoom.Text;
            var appointmentDate = dtpAppointmentDate.Value;

            newAppointment.Patient = selectedPatient;
            newAppointment.Doctor = selectedDoctor;
            newAppointment.OfficeRoom = officeRoom;
            newAppointment.AppointmentDate = appointmentDate;

            newAppointment.CalculateTotalCost();

            AppointmentService.SaveAppointment(newAppointment);

            MessageBox.Show("Appointment added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearFormFields();
        }

        /// \brief Clears all input fields in the form.
        private void ClearFormFields()
        {
            cmbPatients.SelectedIndex = -1;
            cmbDoctors.SelectedIndex = -1;
            txtOfficeRoom.Clear();
            txtExamName.Clear();
            txtExamCost.Clear();
            txtMedicationName.Clear();
            txtMedicationCost.Clear();

            int nextID = AppointmentService.GetNextID();
            newAppointment = new Appointment(nextID, null, null, "");
        }

        #endregion

        #region Event Handlers

        /// \brief Handles the load event of the form.
        private void AddAppointment_Load(object sender, EventArgs e)
        {
          
        }

        #endregion
    }
}