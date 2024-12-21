/// \file Medication.cs
/// \brief Defines the Medication class for the HealthClinic application.
/// \details Represents a medication with a name and cost, including methods for displaying its details.

namespace HealthClinic.Models
{
    /// \namespace HealthClinic.Models
    /// \brief Contains the model classes representing entities in the HealthClinic application.

    /// \class Medication
    /// \brief Represents a medication in the HealthClinic application.
    /// \details Includes properties for the name and cost of the medication and a method to display its details.
    public class Medication
    {
        #region Properties

        /// \brief Gets the name of the medication.
        public string Name { get; private set; }

        /// \brief Gets the cost of the medication.
        public decimal Cost { get; private set; }

        #endregion

        #region Constructor

        /// \brief Initializes a new instance of the Medication class.
        /// \param name The name of the medication.
        /// \param cost The cost of the medication.
        public Medication(string name, decimal cost)
        {
            Name = name;
            Cost = cost;
        }

        #endregion

        #region Methods

        /// \brief Displays the details of the medication.
        /// \details Prints the name and cost of the medication to the console.
        public void DisplayDetails()
        {
            Console.WriteLine($"Medication Name: {Name}");
            Console.WriteLine($"Cost: {Cost}$");
        }

        #endregion
    }
}
