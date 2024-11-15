//-----------------------------------------------------------------
//    <copyright file="Staff.cs"
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
    /// Represents a staff member in the health clinic.
    /// This class extends the <see cref="Person"/> class and adds the role of the staff member.
    /// </summary>
    public class Staff : Person
    {
        
        public string Role { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Staff"/> class with the specified details.
        /// </summary>
        /// <param name="name">The name of the staff member.</param>
        /// <param name="address">The address of the staff member.</param>
        /// <param name="dateOfBirth">The date of birth of the staff member.</param>
        /// <param name="email">The email address of the staff member.</param>
        /// <param name="telephone">The telephone number of the staff member.</param>
        /// <param name="nif">The NIF (tax identification number) of the staff member.</param>
        /// <param name="role">The role of the staff member (e.g., Doctor, Nurse, etc.).</param>
        public Staff(string name, string address, DateTime dateOfBirth, string email, string telephone, string nif, string role)
            : base(name, address, dateOfBirth, email, telephone, nif)
        {
            Role = role;
        }
    }
}
