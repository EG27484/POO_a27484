using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using HealthClinic.Models;

namespace HealthClinic.Tests
{
    [TestClass]
    public class PatientNifAndAdress
    {
        [TestMethod]
        public void Patient_ShouldHaveCorrectNifAndAddress()
        {
            var expectedNif = "123456789";
            var expectedAddress = "123 Main St, Cityville";
            var patient = new Patient(
                name: "Jane Doe",
                gender: "Female",
                contactInfo: "987654321",
                dateOfBirth: new DateTime(1990, 5, 10),
                medicalHistory: "No major issues",
                nif: expectedNif,
                address: expectedAddress
            );

            // Act
            var actualNif = patient.GetNIF();
            var actualAddress = patient.GetAddress();

            // Log Test Details
            TestContext.WriteLine($"Expected NIF: {expectedNif}, Actual NIF: {actualNif}");
            TestContext.WriteLine($"Expected Address: {expectedAddress}, Actual Address: {actualAddress}");

            // Assert
            Assert.AreEqual(expectedNif, actualNif, "NIF does not match the expected value.");
            Assert.AreEqual(expectedAddress, actualAddress, "Address does not match the expected value.");
        }

        public TestContext TestContext { get; set; }
    }
}
