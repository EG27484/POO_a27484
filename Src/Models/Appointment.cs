using System;
using System.Collections.Generic;
using System.Linq;
using HealthClinic.Utils;

namespace HealthClinic.Models
{
    /// \file Appointment.cs
    /// \brief Represents an appointment in the HealthClinic application.
    /// \details Contains information about the patient, doctor, office room, and costs associated with the appointment.

    public class Appointment
    {
        #region Properties

        /// \brief Gets or sets the ID of the appointment.
        public int AppointmentID { get; set; }

        /// \brief Gets or sets the patient involved in the appointment.
        public Patient Patient { get; set; }

        /// \brief Gets or sets the doctor involved in the appointment.
        public Doctor Doctor { get; set; }

        /// \brief Gets or sets the office room where the appointment takes place.
        public string OfficeRoom { get; set; }

        /// \brief Gets or sets the total cost of the appointment.
        public decimal TotalCost { get; set; }

        /// \brief Gets the list of exams prescribed during the appointment.
        public List<Exam> PrescribedExams { get; private set; }

        /// \brief Gets the list of medications prescribed during the appointment.
        public List<Medication> PrescribedMedications { get; private set; }

        /// \brief Gets or sets the date of the appointment.
        public DateTime AppointmentDate { get; set; }

        #endregion

        #region Constructor

        /// \brief Initializes a new instance of the Appointment class.
        /// \param appointmentID The ID of the appointment.
        /// \param patient The patient involved in the appointment.
        /// \param doctor The doctor involved in the appointment.
        /// \param officeRoom The office room where the appointment takes place.
        public Appointment(int appointmentID, Patient patient, Doctor doctor, string officeRoom)
        {
            AppointmentID = appointmentID;
            Patient = patient;
            Doctor = doctor;
            OfficeRoom = officeRoom;
            PrescribedExams = new List<Exam>();
            PrescribedMedications = new List<Medication>();
        }

        #endregion

        #region Methods

        /// \brief Adds an exam to the list of prescribed exams and updates the total cost.
        /// \param exam The exam to add.
        public void AddExam(Exam exam)
        {
            if (exam != null)
            {
                PrescribedExams.Add(exam);
                CalculateTotalCost();
            }
        }

        /// \brief Adds a medication to the list of prescribed medications and updates the total cost.
        /// \param medication The medication to add.
        public void AddMedication(Medication medication)
        {
            if (medication != null)
            {
                PrescribedMedications.Add(medication);
                CalculateTotalCost();
            }
        }

        /// \brief Calculates the total cost of the appointment based on the doctor's fee, exams, and medications.
        public void CalculateTotalCost()
        {
            decimal examCost = PrescribedExams?.Sum(e => e.Cost) ?? 0;
            decimal medicationCost = PrescribedMedications?.Sum(m => m.Cost) ?? 0;

            TotalCost = (Doctor?.ConsultationFee ?? 0) + examCost + medicationCost;
        }

        #endregion
    }
}
