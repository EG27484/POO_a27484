//-----------------------------------------------------------------
//    <copyright file="Exam.cs"
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
    /// Represents a medical exam in the health clinic.
    /// This class stores details about the exam's name and its associated cost.
    /// </summary>
    public class Exam
    {
    
        public int ID { get; private set; }


        public string ExamName { get; private set; }

      
        public decimal Cost { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Exam"/> class with the specified exam name and cost.
        /// </summary>
        /// <param name="examName">The name of the exam.</param>
        /// <param name="cost">The cost of the exam.</param>
        public Exam(string examName, decimal cost)
        {
            ExamName = examName;
            Cost = cost;
        }
    }
}
