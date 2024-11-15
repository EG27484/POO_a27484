//-----------------------------------------------------------------
//    <copyright file="Patient.cs"
//    </copyright>
//    <date>15-11-2024</date>
//    <time>21:00</time>
//    <version>0.1</version>
//    <author>Eva Gomes</author>
//-----------------------------------------------------------------

using System;

namespace HealthClinic.Models
{
    /// <summary>
    /// Represents a patient in the health clinic, inheriting from Person.
    /// This class stores details about the patient, including personal information
    /// such as name, address, date of birth, email, telephone, and NIF.
    /// </summary>
    public class Patient : Person
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Patient"/> class with the specified details.
        /// </summary>
        /// <param name="name">The patient's name.</param>
        /// <param name="address">The patient's address.</param>
        /// <param name="dateOfBirth">The patient's date of birth.</param>
        /// <param name="email">The patient's email address.</param>
        /// <param name="telephone">The patient's telephone number.</param>
        /// <param name="nif">The patient's NIF (tax identification number).</param>
        public Patient(string name, string address, DateTime dateOfBirth, string email, string telephone, string nif)
            : base(name, address, dateOfBirth, email, telephone, nif)
        {
        }
    }
}
