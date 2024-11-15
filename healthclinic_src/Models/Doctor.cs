//-----------------------------------------------------------------
//    <copyright file="Doctor.cs"
//    </copyright>
//    <date>15-11-2024</date>
//    <time>21:00</time>
//    <version>0.1</version>
//    <author>Eva Gomes</author>
//-----------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace HealthClinic.Models
{
    /// <summary>
    /// Represents a doctor in the health clinic, inheriting from Staff.
    /// This class stores details about the doctor's specialty, consultation fee,
    /// and methods for prescribing medication and ordering exams during appointments.
    /// </summary>
    public class Doctor : Staff
    {
        
        public int SpecialtyID { get; private set; }

        
        public decimal ConsultationFee { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Doctor"/> class with the specified details.
        /// </summary>
        /// <param name="name">The doctor's name.</param>
        /// <param name="address">The doctor's address.</param>
        /// <param name="dateOfBirth">The doctor's date of birth.</param>
        /// <param name="email">The doctor's email address.</param>
        /// <param name="telephone">The doctor's telephone number.</param>
        /// <param name="nif">The doctor's NIF (tax identification number).</param>
        /// <param name="specialtyID">The ID of the doctor's specialty.</param>
        /// <param name="consultationFee">The fee charged for a consultation.</param>
        public Doctor(string name, string address, DateTime dateOfBirth, string email, string telephone, string nif, int specialtyID, decimal consultationFee)
            : base(name, address, dateOfBirth, email, telephone, nif, "Doctor")
        {
            SpecialtyID = specialtyID;
            ConsultationFee = consultationFee;
        }

        /// <summary>
        /// Prescribes a medication to a patient during an appointment.
        /// </summary>
        /// <param name="appointment">The appointment where the medication will be prescribed.</param>
        /// <param name="medication">The medication to be prescribed.</param>
        /// <returns>True if the medication was successfully prescribed; otherwise, false.</returns>
        public bool PrescribeMedication(Appointment appointment, Medication medication)
        {
            if (appointment != null && medication != null)
            {
                appointment.Medications.Add(medication);
                Console.WriteLine($"{GetName()} prescribed: {medication.MedicationName} to {appointment.Patient.GetName()}");
                return true;
            }
            return false;
        }

        /// <summary>
        /// Orders an exam to be conducted during an appointment.
        /// </summary>
        /// <param name="appointment">The appointment where the exam will be ordered.</param>
        /// <param name="exam">The exam to be ordered.</param>
        /// <returns>True if the exam was successfully ordered; otherwise, false.</returns>
        public bool OrderExam(Appointment appointment, Exam exam)
        {
            if (appointment != null && exam != null)
            {
                appointment.Exams.Add(exam);
                Console.WriteLine($"{GetName()} ordered exam: {exam.ExamName} for {appointment.Patient.GetName()}");
                return true;
            }
            return false;
        }
    }
}
