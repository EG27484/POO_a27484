//-----------------------------------------------------------------
//    <copyright file="Specialty.cs"
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
    /// Represents a medical specialty in the health clinic.
    /// This class stores the name of the specialty and provides methods to access it.
    /// </summary>
    public class Specialty
    {
        public int ID { get; private set; }

        public string SpecialtyName { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Specialty"/> class with the specified specialty name.
        /// </summary>
        /// <param name="specialtyName">The name of the specialty.</param>
        public Specialty(string specialtyName)
        {
            SpecialtyName = specialtyName;
        }
    }
}
