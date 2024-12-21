using HealthClinic.Models;
using HealthClinic.Utils;
using System;
using Newtonsoft.Json;

namespace HealthClinic.Models
{
    /// \file Patient.cs
    /// \brief Represents a patient in the HealthClinic application.

    public class Patient : Person
    {
        #region Properties

        /// \brief Gets the medical history of the patient.
        public string MedicalHistory { get; private set; }

        /// \brief Gets or sets the NIF (tax identification number) of the patient.
        [JsonProperty]
        private string NIF { get; set; }

        /// \brief Gets or sets the address of the patient.
        [JsonProperty]
        private string Address { get; set; }

        /// \brief Retrieves the NIF of the patient.
        public string GetNIF()
        {
            return NIF;
        }

        /// \brief Retrieves the address of the patient.
        public string GetAddress()
        {
            return Address;
        }

        #endregion

        #region Constructor

        /// \brief Initializes a new instance of the Patient class.
        /// \param name The name of the patient.
        /// \param gender The gender of the patient.
        /// \param contactInfo The contact information of the patient.
        /// \param dateOfBirth The date of birth of the patient.
        /// \param medicalHistory The medical history of the patient.
        /// \param nif The NIF (tax identification number) of the patient.
        /// \param address The address of the patient.
        public Patient(string name, string gender, string contactInfo, DateTime dateOfBirth, string medicalHistory, string nif, string address)
            : base(name, gender, contactInfo, dateOfBirth)
        {
            MedicalHistory = medicalHistory;
            NIF = nif;
            Address = address;
        }

        #endregion

        #region Methods

        /// \brief Displays the detailed information of the patient.
        public override void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Gender: {Gender}");
            Console.WriteLine($"Contact Info: {ContactInfo}");
            Console.WriteLine($"Medical History: {MedicalHistory}");
            Console.WriteLine($"Date of Birth: {DateOfBirth:dd/MM/yyyy}");
            Console.WriteLine($"NIF: {GetNIF()}");
            Console.WriteLine($"Address: {GetAddress()}");
        }

        #endregion
    }
}
