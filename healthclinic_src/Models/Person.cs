//-----------------------------------------------------------------
//    <copyright file="Person.cs"
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
    /// Represents a person in the health clinic.
    /// This class stores personal details, such as name, address, date of birth,
    /// email, telephone, and NIF (tax identification number), and provides 
    /// getter methods to access these properties.
    /// </summary>
    public class Person
    {
    
        private int ID { get; set; }

        private string Name { get; set; }

        private string Address { get; set; }


        private string Email { get; set; }

        private string Telephone { get; set; }

        private DateTime DateOfBirth { get; set; }

     
        private string NIF { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class with the specified personal details.
        /// </summary>
        /// <param name="name">The name of the person.</param>
        /// <param name="address">The address of the person.</param>
        /// <param name="dateOfBirth">The date of birth of the person.</param>
        /// <param name="email">The email address of the person.</param>
        /// <param name="telephone">The telephone number of the person.</param>
        /// <param name="nif">The NIF (tax identification number) of the person.</param>
        public Person(string name, string address, DateTime dateOfBirth, string email, string telephone, string nif)
        {
            Name = name;
            Address = address;
            DateOfBirth = dateOfBirth;
            Email = email;
            Telephone = telephone;
            NIF = nif;
        }

        /// <summary>
        /// Gets the name of the person.
        /// </summary>
        /// <returns>The name of the person.</returns>
        public string GetName()
        {
            return Name;
        }

        /// <summary>
        /// Gets the address of the person.
        /// </summary>
        /// <returns>The address of the person.</returns>
        public string GetAddress()
        {
            return Address;
        }

        /// <summary>
        /// Gets the email address of the person.
        /// </summary>
        /// <returns>The email address of the person.</returns>
        public string GetEmail()
        {
            return Email;
        }

        /// <summary>
        /// Gets the telephone number of the person.
        /// </summary>
        /// <returns>The telephone number of the person.</returns>
        public string GetTelephone()
        {
            return Telephone;
        }

        /// <summary>
        /// Gets the date of birth of the person.
        /// </summary>
        /// <returns>The date of birth of the person.</returns>
        public DateTime GetDateOfBirth()
        {
            return DateOfBirth;
        }

        /// <summary>
        /// Gets the NIF (tax identification number) of the person.
        /// </summary>
        /// <returns>The NIF of the person.</returns>
        public string GetNIF()
        {
            return NIF;
        }

        /// <summary>
        /// Sets the unique identifier for the person.
        /// </summary>
        /// <param name="id">The ID to be set for the person.</param>
        internal void SetID(int id)
        {
            ID = id;
        }

        /// <summary>
        /// Gets the unique identifier for the person.
        /// </summary>
        /// <returns>The ID of the person.</returns>
        public int GetID()
        {
            return ID;
        }
    }
}
