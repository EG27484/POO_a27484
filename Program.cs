using HealthClinic;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using HealthClinic.Models;

namespace HealthClinic
{

    
    }

    public class Doctor : Staff
    {
        public int SpecialtyID { get; private set; }
        public decimal ConsultationFee { get; private set; }

        public Doctor(int id, string name, string address, DateTime dateOfBirth, string email, string telephone, string nif, int specialtyID, decimal consultationFee)
            : base(id, name, address, dateOfBirth, email, telephone, nif, "Doctor")
        {
            SpecialtyID = specialtyID;
            ConsultationFee = consultationFee;
        }

        public bool PrescribeMedication(Appointment appointment, Medication medication)
        {
            if (appointment != null && medication != null)
            {
                appointment.Medications.Add(medication);
                Console.WriteLine($"{Name} prescribed: {medication.MedicationName} to {appointment.Patient.Name}");
                return true;
            }
            return false;
        }

        public bool OrderExam(Appointment appointment, Exam exam)
        {
            if (appointment != null && exam != null)
            {
                appointment.Exams.Add(exam);
                Console.WriteLine($"{Name} ordered exam: {exam.ExamName} for {appointment.Patient.Name}");
                return true;
            }
            return false;
        }
    }

    public class Patient : Person
    {
        public Patient(int id, string name, string address, DateTime dateOfBirth, string email, string telephone, string nif)
            : base(id, name, address, dateOfBirth, email, telephone, nif)
        {
        }
    }

    public class Room
    {
        public int ID { get; private set; }
        public int RoomNumber { get; private set; }
        protected bool IsAvailable { get; private set; }

        public Room(int id, int roomNumber)
        {
            ID = id;
            RoomNumber = roomNumber;
            IsAvailable = true;
        }

        public bool CheckAvailability() => IsAvailable;
        public void MarkUnavailable() => IsAvailable = false;
        public void MarkAvailable() => IsAvailable = true;
    }

    public class Medication
    {
        public int ID { get; private set; }
        public string MedicationName { get; private set; }
        public string Dosage { get; private set; }
        public decimal Cost { get; private set; }

        public Medication(int id, string medicationName, string dosage, decimal cost)
        {
            ID = id;
            MedicationName = medicationName;
            Dosage = dosage;
            Cost = cost;
        }
    }

    public class Exam
    {
        public int ID { get; private set; }
        public string ExamName { get; private set; }
        public decimal Cost { get; private set; }

        public Exam(int id, string examName, decimal cost)
        {
            ID = id;
            ExamName = examName;
            Cost = cost;
        }
    }

    public class Appointment
    {
        public int ID { get; private set; }
        public DateTime Date { get; private set; }
        public Doctor Doctor { get; private set; }
        public Patient Patient { get; private set; }
        public Room Room { get; private set; }
        public List<Medication> Medications { get; } = new List<Medication>();
        public List<Exam> Exams { get; } = new List<Exam>();

        public Appointment(int id, DateTime date, Doctor doctor, Patient patient, Room room)
        {
            ID = id;
            Date = date;
            Doctor = doctor;
            Patient = patient;
            Room = room;
        }

        public bool Schedule()
        {
            if (Room.CheckAvailability())
            {
                Room.MarkUnavailable();
                Console.WriteLine($"Appointment scheduled for {Patient.Name} with Dr. {Doctor.Name} in Room {Room.RoomNumber} on {Date}.");
                return true;
            }
            else
            {
                Console.WriteLine($"Room {Room.RoomNumber} is not available.");
                return false;
            }
        }

        public decimal CalculateTotalCost()
        {
            decimal totalCost = Doctor.ConsultationFee;

            foreach (var medication in Medications)
            {
                totalCost += medication.Cost;
            }

            foreach (var exam in Exams)
            {
                totalCost += exam.Cost;
            }

            return totalCost;
        }
    }

    public class ClinicManagement
    {
        private readonly List<Doctor> Doctors = new List<Doctor>();
        private readonly List<Patient> Patients = new List<Patient>();
        private readonly List<Room> Rooms = new List<Room>();
        private readonly List<Appointment> Appointments = new List<Appointment>();

        public bool AddDoctor(Doctor doctor)
        {
            if (doctor != null)
            {
                Doctors.Add(doctor);
                Console.WriteLine($"Doctor {doctor.Name} added with specialty ID {doctor.SpecialtyID}.");
                return true;
            }
            return false;
        }

        public bool AddPatient(Patient patient)
        {
            if (patient != null)
            {
                Patients.Add(patient);
                Console.WriteLine($"Patient {patient.Name} added.");
                return true;
            }
            return false;
        }

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

        public bool ScheduleAppointment(Appointment appointment)
        {
            if (appointment != null && appointment.Schedule())
            {
                Appointments.Add(appointment);
                return true;
            }
            return false;
        }
    }

    public static class DatabaseHelper
    {
        private static readonly string connectionString = "Data Source=DESKTOP-2K686U5\\SQLEXPRESS;Initial Catalog=Health_POO;Integrated Security=True;TrustServerCertificate=True";

        public static void SavePerson(Person person)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Person (Name, Address, DateOfBirth, Email, Telephone, NIF) VALUES (@Name, @Address, @DateOfBirth, @Email, @Telephone, @NIF)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", person.Name);
                    cmd.Parameters.AddWithValue("@Address", person.Address);
                    cmd.Parameters.AddWithValue("@DateOfBirth", person.GetDateOfBirth());
                    cmd.Parameters.AddWithValue("@Email", person.Email);
                    cmd.Parameters.AddWithValue("@Telephone", person.Telephone);
                    cmd.Parameters.AddWithValue("@NIF", person.GetNIF());
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void SaveSpecialty(Specialty specialty)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Specialty (SpecialtyName) VALUES (@SpecialtyName )";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SpecialtyName", specialty.SpecialtyName);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void SaveDoctor(Doctor doctor)
        {
            SavePerson(doctor);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Doctor (SpecialtyID, ConsultationFee) VALUES (@SpecialtyID, @ConsultationFee)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SpecialtyID", doctor.SpecialtyID);
                    cmd.Parameters.AddWithValue("@ConsultationFee", doctor.ConsultationFee);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void SaveAppointment(Appointment appointment)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Appointment (Date, DoctorID, PatientID, RoomNumber) VALUES (@Date, @DoctorID, @PatientID, @RoomNumber)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Date", appointment.Date);
                    cmd.Parameters.AddWithValue("@DoctorID", appointment.Doctor.ID);  // Corrected to use Doctor's ID
                    cmd.Parameters.AddWithValue("@PatientID", appointment.Patient.ID); // Assuming PatientID is an integer ID
                    cmd.Parameters.AddWithValue("@RoomNumber", appointment.Room.RoomNumber);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var clinic = new ClinicManagement();

            // Create a specialty (assuming that it is inserted into the database and given an ID)
            var cardiology = new Specialty(1, "Cardiology");  // This should be saved first, and the ID should be assigned.

            // Create doctors
            var doctor1 = new Doctor(1, "Dr. Smith", "123 Street", new DateTime(1980, 1, 1), "drsmith@clinic.com", "123456789", "123456789", cardiology.ID, 100);
            var doctor2 = new Doctor(2, "Dr. John", "456 Avenue", new DateTime(1985, 2, 1), "drjohn@clinic.com", "987654321", "987654321", cardiology.ID, 150);

            DatabaseHelper.SaveDoctor(doctor1);  // Save the doctor with the SpecialtyID
            DatabaseHelper.SaveDoctor(doctor2);

            // Add doctors to the clinic
            clinic.AddDoctor(doctor1);
            clinic.AddDoctor(doctor2);

            // Create patients
            var patient1 = new Patient(1, "Alice", "789 Road", new DateTime(1990, 3, 1), "alice@clinic.com", "123123123", "123123123");
            var patient2 = new Patient(2, "Bob", "101 Street", new DateTime(1992, 4, 1), "bob@clinic.com", "456456456", "456456456");

            // Add patients to the clinic
            clinic.AddPatient(patient1);
            clinic.AddPatient(patient2);

            // Create rooms
            var room1 = new Room(1, 101);
            var room2 = new Room(2, 102);

            // Add rooms to the clinic
            clinic.AddRoom(room1);
            clinic.AddRoom(room2);

            // Schedule appointments
            var appointment1 = new Appointment(1, DateTime.Now, doctor1, patient1, room1);
            var appointment2 = new Appointment(2, DateTime.Now, doctor2, patient2, room2);

            clinic.ScheduleAppointment(appointment1);
            clinic.ScheduleAppointment(appointment2);
        }
    }


