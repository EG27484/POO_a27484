using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HealthClinic.Models;

namespace HealthClinic.Tests
{
    /// \file PersonAgeTests.cs
    /// \brief Unit tests for verifying the age calculation in the Person class.

    [TestClass]
    public class PersonAge
    {
        #region Properties

        /// \brief Provides the context for the current test, including logging output.
        public TestContext TestContext { get; set; }

        #endregion

        #region Test Methods

        /// \brief Tests the age calculation logic in the Person class.
        /// \details Ensures that the age is calculated correctly based on the date of birth and the current date.
        [TestMethod]
        public void Age_ShouldReturnCorrectAge()
        {
            // Arrange
            var birthDate = new DateTime(2000, 1, 1);
            var person = new Patient("John Doe", "Male", "123456789", birthDate, "Healthy", "987654321", "123 Main St");

            // Act
            var actualAge = person.Age;

            // Calculate expected age
            var today = DateTime.Today;
            var expectedAge = today.Year - birthDate.Year;
            if (birthDate.Date > today.AddYears(-expectedAge))
            {
                expectedAge--;
            }

            // Log details
            TestContext.WriteLine($"Actual Age: {actualAge}");
            TestContext.WriteLine($"Expected Age: {expectedAge}");

            // Assert
            Assert.AreEqual(expectedAge, actualAge, "The calculated age does not match the expected age.");
        }

        #endregion
    }
}
