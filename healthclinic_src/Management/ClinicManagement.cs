//-----------------------------------------------------------------
//    <copyright file="ClinicManagement.cs"
//    </copyright>
//    <date>15-11-2024</date>
//    <time>21:00</time>
//    <version>0.1</version>
//    <author>Eva Gomes</author>
//-----------------------------------------------------------------

using HealthClinic.Models;
using System;
using System.Collections.Generic;

namespace HealthClinic.Management
{
    /// <summary>
    /// Manages the operations and records of the health clinic.
    /// This class allows the management of doctors, patients, rooms, and appointments.
    /// </summary>
    public class ClinicManagement
    {
        private readonly List<Doctor> Doctors = new List<Doctor>();
        private readonly List<Patient> Patients = new List<Patient>();
        private readonly List<Room> Rooms = new List<Room>();
        private readonly List<Appointment> Appointments = new List<Appointment>();

        /// <summary>
        /// Adds a doctor to the in-memory list of doctors.
        /// </summary>
        /// <param name="doctor">The doctor to add.</param>
        /// <returns>True if the doctor was added successfully; otherwise, false.</returns>
        public bool AddDoctor(Doctor doctor)
        {
            if (doctor != null)
            {
                Doctors.Add(doctor);
                Console.WriteLine($"Doctor {doctor.GetName()} added with specialty ID {doctor.SpecialtyID}.");
                return true;
            }
            return false;
        }

        /// <summary>
        /// Adds a patient to the in-memory list of patients.
        /// </summary>
        /// <param name="patient">The patient to add.</param>
        /// <returns>True if the patient was added successfully; otherwise, false.</returns>
        public bool AddPatient(Patient patient)
        {
            if (patient != null)
            {
                Patients.Add(patient);
                Console.WriteLine($"Patient {patient.GetName()} added.");
                return true;
            }
            return false;
        }

        /// <summary>
        /// Adds a room to the in-memory list of rooms.
        /// </summary>
        /// <param name="room">The room to add.</param>
        /// <returns>True if the room was added successfully; otherwise, false.</returns>
        public bool AddRoom(Room room)
        {
            if (room != null)
            {
                Rooms.Add(room);
                Console.WriteLine($"Room {room.RoomNumber} added.");
                return true;
            }
            return false;
        }

        /// <summary>
        /// Schedules an appointment by adding it to the in-memory list.
        /// </summary>
        /// <param name="appointment">The appointment to schedule.</param>
        /// <returns>True if the appointment was scheduled successfully; otherwise, false.</returns>
        public bool ScheduleAppointment(Appointment appointment)
        {
            if (appointment != null && appointment.Schedule())
            {
                Appointments.Add(appointment);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Displays a list of all doctors in the clinic.
        /// </summary>
        public void DisplayDoctors()
        {
            Console.WriteLine("Doctors List:");
            foreach (var doctor in Doctors)
            {
                Console.WriteLine($"{doctor.GetName()} (Specialty ID: {doctor.SpecialtyID})");
            }
        }

        /// <summary>
        /// Displays a list of all patients in the clinic.
        /// </summary>
        public void DisplayPatients()
        {
            Console.WriteLine("Patients List:");
            foreach (var patient in Patients)
            {
                Console.WriteLine($"{patient.GetName()}");
            }
        }

        /// <summary>
        /// Displays a list of all rooms in the clinic.
        /// </summary>
        public void DisplayRooms()
        {
            Console.WriteLine("Rooms List:");
            foreach (var room in Rooms)
            {
                Console.WriteLine($"Room Number: {room.RoomNumber}");
            }
        }

        /// <summary>
        /// Displays a list of all scheduled appointments.
        /// </summary>
        public void DisplayAppointments()
        {
            Console.WriteLine("Appointments List:");
            foreach (var appointment in Appointments)
            {
                Console.WriteLine($"Appointment for {appointment.Patient.GetName()} with Dr. {appointment.Doctor.GetName()} on {appointment.Date}");
            }
        }
    }
}
