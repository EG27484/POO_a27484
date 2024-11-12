using System;
using System.Collections.Generic;

namespace HealthClinic
{
    // Base class for all people involved in the clinic
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string NIF { get; set; }

        public Person(int id, string name, string address, DateTime dateOfBirth, string email, string telephone, string nif)
        {
            ID = id;
            Name = name;
            Address = address;
            DateOfBirth = dateOfBirth;
            Email = email;
            Telephone = telephone;
            NIF = nif;
        }
    }

    // Speciality class to represent medical specialties
    public class Speciality
    {
        public int IDSpeciality { get; set; }
        public string SpecialityName { get; set; }

        public Speciality(int idSpeciality, string specialityName)
        {
            IDSpeciality = idSpeciality;
            SpecialityName = specialityName;
        }
    }

    // Base Staff class for general staff
    public class Staff : Person
    {
        public string Role { get; set; }

        public Staff(int idStaff, string name, string address, DateTime dateOfBirth, string email, string telephone, string nif, string role)
            : base(idStaff, name, address, dateOfBirth, email, telephone, nif)
        {
            Role = role;
        }
    }

    // Doctor class inheriting from Staff with doctor-specific attributes
    public class Doctor : Staff
    {
        public Speciality Speciality { get; set; }
        public decimal ConsultationFee { get; set; }

        public Doctor(int idDoctor, string name, string address, DateTime dateOfBirth, string email, string telephone, string nif, Speciality speciality, decimal consultationFee)
            : base(idDoctor, name, address, dateOfBirth, email, telephone, nif, "Doctor")
        {
            Speciality = speciality;
            ConsultationFee = consultationFee;
        }

        // Method to prescribe medication during an appointment
        public bool PrescribeMedication(Appointment appointment, Medication medication)
        {
            if (appointment != null)
            {
                appointment.Medications.Add(medication);
                Console.WriteLine($"{Name} prescribed: {medication.MedicationName} to {appointment.Patient.Name}");
                return true;
            }
            return false;
        }

        // Method to order an exam during an appointment
        public bool OrderExam(Appointment appointment, Exam exam)
        {
            if (appointment != null)
            {
                appointment.Exams.Add(exam);
                Console.WriteLine($"{Name} ordered exam: {exam.ExamName} for {appointment.Patient.Name}");
                return true;
            }
            return false;
        }
    }

    // Patient inherits from Person
    public class Patient : Person
    {
        public Patient(int idPatient, string name, string address, DateTime dateOfBirth, string email, string telephone, string nif)
            : base(idPatient, name, address, dateOfBirth, email, telephone, nif)
        {
        }
    }

    // Room class to represent appointment rooms
    public class Room
    {
        public int RoomNumber { get; set; }
        public bool IsAvailable { get; set; }

        public Room(int roomNumber)
        {
            RoomNumber = roomNumber;
            IsAvailable = true;
        }
    }

    // Medication class to represent medications
    public class Medication
    {
        public int IDMedication { get; set; }
        public string MedicationName { get; set; }
        public string Dosage { get; set; }
        public decimal Cost { get; set; }

        public Medication(int idMedication, string medicationName, string dosage, decimal cost)
        {
            IDMedication = idMedication;
            MedicationName = medicationName;
            Dosage = dosage;
            Cost = cost;
        }
    }

    // Exam class to represent exams
    public class Exam
    {
        public int IDExam { get; set; }
        public string ExamName { get; set; }
        public decimal Cost { get; set; }

        public Exam(int idExam, string examName, decimal cost)
        {
            IDExam = idExam;
            ExamName = examName;
            Cost = cost;
        }
    }

    // Appointment class for scheduling appointments
    public class Appointment
    {
        public DateTime Date { get; set; }
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
        public Room Room { get; set; }
        public List<Medication> Medications { get; set; } = new List<Medication>();
        public List<Exam> Exams { get; set; } = new List<Exam>();

        public Appointment(DateTime date, Doctor doctor, Patient patient, Room room)
        {
            Date = date;
            Doctor = doctor;
            Patient = patient;
            Room = room;
        }

        // Method to schedule the appointment
        public bool Schedule()
        {
            if (Room.IsAvailable)
            {
                Room.IsAvailable = false;
                Console.WriteLine($"Appointment scheduled for {Patient.Name} with Dr. {Doctor.Name} in Room {Room.RoomNumber} on {Date}.");
                return true;
            }
            else
            {
                Console.WriteLine($"Room {Room.RoomNumber} is not available.");
                return false;
            }
        }

        // Method to calculate the total cost for the appointment
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

    // Main Clinic Management System
    public class ClinicManagement
    {
        private List<Doctor> Doctors = new List<Doctor>();
        private List<Patient> Patients = new List<Patient>();
        private List<Room> Rooms = new List<Room>();
        private List<Appointment> Appointments = new List<Appointment>();

        // Add a doctor
        public bool AddDoctor(Doctor doctor)
        {
            if (doctor != null)
            {
                Doctors.Add(doctor);
                Console.WriteLine($"Doctor {doctor.Name} added with specialty {doctor.Speciality.SpecialityName}.");
                return true;
            }
            return false;
        }

        // Add a patient
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

        // Add a room
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

        // Schedule an appointment
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

    class Program
    {
        static void Main(string[] args)
        {
            // Initializing clinic management
            ClinicManagement clinic = new ClinicManagement();

            // Adding specialties
            Speciality cardiology = new Speciality(1, "Cardiology");

            // Adding doctors
            Doctor doctor1 = new Doctor(1, "Dr. Alice", "123 Main St", new DateTime(1979, 5, 20), "alice@example.com", "123-456-7890", "123456789", cardiology, 150.00m);
            clinic.AddDoctor(doctor1);

            // Adding rooms
            Room room1 = new Room(101);
            clinic.AddRoom(room1);

            // Adding patients
            Patient patient1 = new Patient(1, "John Doe", "456 Elm St", new DateTime(1994, 3, 15), "johndoe@example.com", "987-654-3210", "987654321");
            clinic.AddPatient(patient1);

            // Scheduling an appointment
            Appointment appointment1 = new Appointment(DateTime.Now, doctor1, patient1, room1);
            clinic.ScheduleAppointment(appointment1);

            // Adding medication and exam
            Medication medication1 = new Medication(1, "Aspirin", "100mg", 5.00m);
            Exam exam1 = new Exam(1, "Blood Test", 50.00m);

            doctor1.PrescribeMedication(appointment1, medication1);
            doctor1.OrderExam(appointment1, exam1);

            // Calculating total cost
            decimal totalCost = appointment1.CalculateTotalCost();
            Console.WriteLine($"Total cost for the appointment: ${totalCost.ToString("F2")}");
        }
    }
}

