using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HealthClinic.Models;
using System.Collections.Generic;

namespace HealthClinic.Tests
{
    /// \file AppointmentTotalCost.cs
    /// \brief Unit tests for calculating the total cost of an appointment.

    [TestClass]
    public class AppointmentTotalCost
    {
        #region Properties

        /// \brief Provides the context for the current test, including logging output.
        public TestContext TestContext { get; set; }

        #endregion

        #region Test Methods

        /// \brief Tests the calculation of the total cost of an appointment.
        /// \details Verifies that the total cost is calculated correctly by summing the consultation fee, exam costs, and medication costs.
        [TestMethod]
        public void TotalCost_ShouldBeCalculatedCorrectly()
        {
            // Arrange
            var doctor = new Doctor("Dr. Smith", "Male", "123456789", new DateTime(1980, 1, 1), "Cardiology", 100.0m);
            var patient = new Patient("John Doe", "Male", "987654321", new DateTime(2000, 1, 1), "Healthy", "123456789", "123 Main St");
            var appointment = new Appointment(1, patient, doctor, "Room 101");

            // Add exams
            var exam1 = new Exam("Blood Test", 50.0m);
            var exam2 = new Exam("X-Ray", 150.0m);
            appointment.AddExam(exam1);
            appointment.AddExam(exam2);

            // Add medications
            var medication1 = new Medication("Aspirin", 10.0m);
            var medication2 = new Medication("Antibiotic", 30.0m);
            appointment.AddMedication(medication1);
            appointment.AddMedication(medication2);

            // Act
            appointment.CalculateTotalCost();
            var actualTotalCost = appointment.TotalCost;

            // Expected total cost
            var expectedTotalCost = doctor.ConsultationFee + exam1.Cost + exam2.Cost + medication1.Cost + medication2.Cost;

            // Log details
            TestContext.WriteLine($"Consultation Fee: {doctor.ConsultationFee}");
            TestContext.WriteLine($"Exam 1 Cost: {exam1.Cost}");
            TestContext.WriteLine($"Exam 2 Cost: {exam2.Cost}");
            TestContext.WriteLine($"Medication 1 Cost: {medication1.Cost}");
            TestContext.WriteLine($"Medication 2 Cost: {medication2.Cost}");
            TestContext.WriteLine($"Expected Total Cost: {expectedTotalCost}");
            TestContext.WriteLine($"Actual Total Cost: {actualTotalCost}");

            // Assert
            Assert.AreEqual(expectedTotalCost, actualTotalCost, "The total cost calculation is incorrect.");
        }

        #endregion
    }
}
