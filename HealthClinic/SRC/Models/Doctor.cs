using System;
using HealthClinic.Utils;

namespace HealthClinic.Models
{
    /// \file Doctor.cs
    /// \brief Represents a doctor in the HealthClinic application.

    public class Doctor : Person
    {
        #region Properties

        /// \brief Gets the specialty of the doctor.
        public string Specialty { get; private set; }

        /// \brief Gets the consultation fee of the doctor.
        public decimal ConsultationFee { get; private set; }

        #endregion

        #region Constructor

        /// \brief Initializes a new instance of the Doctor class.
        /// \param name The name of the doctor.
        /// \param gender The gender of the doctor.
        /// \param contactInfo The contact information of the doctor.
        /// \param dateOfBirth The date of birth of the doctor.
        /// \param specialty The specialty of the doctor.
        /// \param consultationFee The consultation fee of the doctor.
        public Doctor(string name, string gender, string contactInfo, DateTime dateOfBirth, string specialty, decimal consultationFee)
            : base(name, gender, contactInfo, dateOfBirth)
        {
            Specialty = specialty;
            ConsultationFee = consultationFee;
        }

        #endregion

        #region Methods

        /// \brief Displays the detailed information of the doctor.
        public override void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Gender: {Gender}");
            Console.WriteLine($"Contact Info: {ContactInfo}");
            Console.WriteLine($"Specialty: {Specialty}");
            Console.WriteLine($"Fee: {ConsultationFee} $");
        }

        #endregion
    }
}
