//-----------------------------------------------------------------
//    <copyright file="Medication.cs"
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
    /// Represents a medication in the health clinic.
    /// This class stores details about the medication's name, dosage, and its associated cost.
    /// </summary>
    public class Medication
    {
     
        public int ID { get; private set; }

        public string MedicationName { get; private set; }

   
        public string Dosage { get; private set; }

        public decimal Cost { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Medication"/> class with the specified medication name, dosage, and cost.
        /// </summary>
        /// <param name="medicationName">The name of the medication.</param>
        /// <param name="dosage">The dosage of the medication.</param>
        /// <param name="cost">The cost of the medication.</param>
        public Medication(string medicationName, string dosage, decimal cost)
        {
            MedicationName = medicationName;
            Dosage = dosage;
            Cost = cost;
        }
    }
}
