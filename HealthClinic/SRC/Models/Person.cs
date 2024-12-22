namespace HealthClinic.Models
{
    /// \file Person.cs
    /// \brief Abstract base class representing a person.
    /// \details Provides basic properties such as name, gender, contact information, and date of birth.

    public abstract class Person
    {
        #region Properties

        /// \brief Gets the name of the person.
        public string Name { get; private set; }

        /// \brief Gets the gender of the person.
        public string Gender { get; private set; }

        /// \brief Gets the contact information of the person.
        public string ContactInfo { get; private set; }

        /// \brief Gets or sets the date of birth of the person.
        public DateTime DateOfBirth { get; private set; }

        /// \brief Gets the calculated age of the person.
        public int Age
        {
            get
            {
                var today = DateTime.Today;
                var age = today.Year - DateOfBirth.Year;
                if (DateOfBirth.Date > today.AddYears(-age)) age--;
                return age;
            }
        }

        #endregion

        #region Constructor

        /// \brief Initializes a new instance of the Person class.
        /// \param name The name of the person.
        /// \param gender The gender of the person.
        /// \param contactInfo The contact information of the person.
        /// \param dateOfBirth The date of birth of the person.
        protected Person(string name, string gender, string contactInfo, DateTime dateOfBirth)
        {
            Name = name;
            Gender = gender;
            ContactInfo = contactInfo;
            DateOfBirth = dateOfBirth;
        }

        #endregion

        #region Methods

        /// \brief Displays the basic details of the person.
        public virtual void DisplayBasicDetails()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Gender: {Gender}");
            Console.WriteLine($"Contact Info: {ContactInfo}");
        }

        /// \brief Displays extended details of the person.
        /// \details Must be implemented in derived classes to provide additional details.
        public abstract void DisplayDetails();

        #endregion
    }
}
