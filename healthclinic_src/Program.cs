//-----------------------------------------------------------------
//    <copyright file="Program.cs"
//    </copyright>
//    <date>15-11-2024</date>
//    <time>21:00</time>
//    <version>0.1</version>
//    <author>Eva Gomes</author>
//-----------------------------------------------------------------

using HealthClinic;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using HealthClinic.Models;
using HealthClinic.Management;

namespace HealthClinic
{

    /// <summary>
    /// The main entry point for the health clinic application.
    /// This class initializes the clinic, adds doctors, patients, rooms, and schedules appointments.
    /// </summary>
    public class Program
    {


        /// <summary>
        /// Main method to run the program. It sets up the clinic, doctors, patients, rooms, and appointments.
        /// </summary>
        /// <param name="args">Command-line arguments (not used in this program).</param>
        public static void Main(string[] args)
        {
            var clinic = new ClinicManagement();

            // Create a specialty (assuming that it is inserted into the database and given an ID)
            var cardiology = new Specialty( "Cardiology");  // This should be saved first, and the ID should be assigned.

            // Create doctors
            var doctor1 = new Doctor( "Dr. Smith", "123 Street", new DateTime(1980, 1, 1), "drsmith@clinic.com", "123456489", "133456759", cardiology.ID, 100);
            var doctor2 = new Doctor( "Dr. John", "456 Avenue", new DateTime(1985, 2, 1), "drjohn@clinic.com", "987644321", "9845624321", cardiology.ID, 150);

            // Add doctors to the clinic
            clinic.AddDoctor(doctor1);
            clinic.AddDoctor(doctor2);
          
        

            // Create patients
            var patient1 = new Patient( "Alice", "789 Road", new DateTime(1990, 3, 1), "alice@clinic.com", "123123123", "123123123");
            var patient2 = new Patient( "Bob", "101 Street", new DateTime(1992, 4, 1), "bob@clinic.com", "456456456", "456456456");

            // Add patients to the clinic
            clinic.AddPatient(patient1);
            clinic.AddPatient(patient2);

            // Create rooms
            var room1 = new Room( 101);
            var room2 = new Room( 102);

            // Add rooms to the clinic
            clinic.AddRoom(room1);
            clinic.AddRoom(room2);

            // Schedule appointments
            var appointment1 = new Appointment( DateTime.Now, doctor1, patient1, room1);
            var appointment2 = new Appointment( DateTime.Now, doctor2, patient2, room2);

            clinic.ScheduleAppointment(appointment1);
            clinic.ScheduleAppointment(appointment2);


            //Display
            clinic.DisplayDoctors();
            clinic.DisplayPatients();
            clinic.DisplayRooms();
            clinic.DisplayAppointments();
        }
    }
}
