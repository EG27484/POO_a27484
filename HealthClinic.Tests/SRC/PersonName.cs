using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HealthClinic.Models;

namespace HealthClinic.Tests
{
    /// \file PersonNameTests.cs
    /// \brief Unit tests for verifying the name assignment in the Person class.

    [TestClass]
    public class PersonName
    {
        #region Properties

        /// \brief Provides the context for the current test, including logging output.
        public TestContext TestContext { get; set; }

        #endregion

        #region Test Methods

        /// \brief Tests the assignment of the name property in the Person class.
        /// \details Ensures that the name is correctly assigned during the construction of a Person object.
        [TestMethod]
        public void Name_ShouldBeAssignedCorrectly()
        {
            // Arrange
            var expectedName = "John Doe";
            var birthDate = new DateTime(2000, 1, 1);

            // Act
            var person = new Patient(expectedName, "Male", "123456789", birthDate, "Healthy", "987654321", "123 Main St");

            // Log details
            TestContext.WriteLine($"Expected Name: {expectedName}");
            TestContext.WriteLine($"Actual Name: {person.Name}");

            // Assert
            Assert.AreEqual(expectedName, person.Name, "The name should be assigned correctly during object construction.");
        }

        #endregion
    }
}
