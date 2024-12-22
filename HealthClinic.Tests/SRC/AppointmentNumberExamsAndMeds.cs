using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HealthClinic.Models;
using System.Collections.Generic;

namespace HealthClinic.Tests
{
    /// \file AppointmentNumberExamsAndMeds.cs
    /// \brief Unit tests for managing exams and medications in an appointment.

    [TestClass]
    public class AppointmentNumberExamsAndMeds
    {
        #region Properties

        /// \brief Provides the context for the current test, including logging output.
        public TestContext TestContext { get; set; }

        #endregion

        #region Test Methods

        /// \brief Tests adding exams and medications to an appointment.
        /// \details Verifies that exams and medications are correctly added and that their counts match expectations.
        [TestMethod]
        public void AddingExamsAndMedications_ShouldWorkCorrectly()
        {
            // Arrange
            var doctor = new Doctor("Dr. Jane", "Female", "123456789", new DateTime(1985, 5, 15), "Pediatrics", 120.0m);
            var patient = new Patient("Alice Doe", "Female", "987654321", new DateTime(2010, 3, 10), "Healthy", "987654321", "456 Main St");
            var appointment = new Appointment(2, patient, doctor, "Room 202");

            var exam1 = new Exam("MRI", 500.0m);
            var exam2 = new Exam("CT Scan", 300.0m);

            var medication1 = new Medication("Paracetamol", 5.0m);
            var medication2 = new Medication("Ibuprofen", 8.0m);

            // Act
            appointment.AddExam(exam1);
            appointment.AddExam(exam2);

            appointment.AddMedication(medication1);
            appointment.AddMedication(medication2);

            // Log details
            TestContext.WriteLine($"Exam 1: {exam1.Name}, Cost: {exam1.Cost}");
            TestContext.WriteLine($"Exam 2: {exam2.Name}, Cost: {exam2.Cost}");
            TestContext.WriteLine($"Medication 1: {medication1.Name}, Cost: {medication1.Cost}");
            TestContext.WriteLine($"Medication 2: {medication2.Name}, Cost: {medication2.Cost}");

            TestContext.WriteLine($"Number of Exams Added: {appointment.PrescribedExams.Count}");
            TestContext.WriteLine($"Number of Medications Added: {appointment.PrescribedMedications.Count}");

            // Assert
            Assert.AreEqual(2, appointment.PrescribedExams.Count, "The number of exams added is incorrect.");
            Assert.AreEqual(2, appointment.PrescribedMedications.Count, "The number of medications added is incorrect.");
            Assert.AreEqual(exam1, appointment.PrescribedExams[0], "The first exam added is incorrect.");
            Assert.AreEqual(medication1, appointment.PrescribedMedications[0], "The first medication added is incorrect.");
        }

        #endregion
    }
}
