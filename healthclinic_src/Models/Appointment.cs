//-----------------------------------------------------------------
//    <copyright file="Apointment.cs"
//    </copyright>
//    <date>15-11-2024</date>
//    <time>21:00</time>
//    <version>0.1</version>
//    <author>Eva Gomes</author>
//-----------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace HealthClinic.Models
{
    /// <summary>
    /// Represents a medical appointment in the health clinic.
    /// This class stores details about the appointment, including the date, doctor, patient, room, 
    /// medications prescribed, and exams requested.
    /// </summary>
    public class Appointment
    {
        
        public int ID { get; private set; }

        public DateTime Date { get; private set; }

        public Doctor Doctor { get; private set; }

     
        public Patient Patient { get; private set; }

        public Room Room { get; private set; }

        /// <summary>
        /// Gets the list of medications prescribed during the appointment.
        /// </summary>
        public List<Medication> Medications { get; } = new List<Medication>();

        /// <summary>
        /// Gets the list of exams requested during the appointment.
        /// </summary>
        public List<Exam> Exams { get; } = new List<Exam>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Appointment"/> class with the specified date, doctor, patient, and room.
        /// </summary>
        /// <param name="date">The date and time of the appointment.</param>
        /// <param name="doctor">The doctor assigned to the appointment.</param>
        /// <param name="patient">The patient scheduled for the appointment.</param>
        /// <param name="room">The room assigned for the appointment.</param>
        public Appointment(DateTime date, Doctor doctor, Patient patient, Room room)
        {
            Date = date;
            Doctor = doctor;
            Patient = patient;
            Room = room;
        }

        /// <summary>
        /// Attempts to schedule the appointment by checking the availability of the assigned room.
        /// If the room is available, it marks the room as unavailable and schedules the appointment.
        /// </summary>
        /// <returns>True if the appointment was successfully scheduled; otherwise, false.</returns>
        public bool Schedule()
        {
            if (Room.CheckAvailability())
            {
                Room.MarkUnavailable();
                Console.WriteLine($"Appointment scheduled for {Patient.GetName()} with Dr. {Doctor.GetName()} in Room {Room.RoomNumber} on {Date}.");
                return true;
            }
            else
            {
                Console.WriteLine($"Room {Room.RoomNumber} is not available.");
                return false;
            }
        }

        /// <summary>
        /// Calculates the total cost of the appointment based on the doctor's consultation fee,
        /// the cost of prescribed medications, and the cost of requested exams.
        /// </summary>
        /// <returns>The total cost of the appointment.</returns>
        public decimal CalculateTotalCost()
        {
            decimal totalCost = Doctor.ConsultationFee;

            // Add the cost of medications
            foreach (var medication in Medications)
            {
                totalCost += medication.Cost;
            }

            // Add the cost of exams
            foreach (var exam in Exams)
            {
                totalCost += exam.Cost;
            }

            return totalCost;
        }
    }
}
