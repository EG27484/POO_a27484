/// \file Exam.cs
/// \brief Defines the Exam class for the HealthClinic application.
/// \details Represents a medical exam with a name and cost.

namespace HealthClinic.Models
{
    /// \namespace HealthClinic.Models
    /// \brief Contains the model classes representing entities in the HealthClinic application.

    /// \class Exam
    /// \brief Represents a medical exam in the HealthClinic application.
    /// \details Includes properties for the name and cost of the exam.
    public class Exam
    {
        #region Properties

        /// \brief Gets the name of the exam.
        public string Name { get; private set; }

        /// \brief Gets the cost of the exam.
        public decimal Cost { get; private set; }

        #endregion

        #region Constructor

        /// \brief Initializes a new instance of the Exam class.
        /// \param name The name of the exam.
        /// \param cost The cost of the exam.
        public Exam(string name, decimal cost)
        {
            Name = name;
            Cost = cost;
        }

        #endregion
    }
}