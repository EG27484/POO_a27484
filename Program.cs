using HealthClinic;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;  // Alteração aqui para usar Microsoft.Data.SqlClient

namespace HealthClinic
{
    /// <summary>
    /// Represents a person in the health clinic system.
    /// </summary>
    public class Person
    {
        public int ID { get; private set; }
        public string Name { get; private set; }
        public string Address { get; private set; }
        public string Email { get; private set; }
        public string Telephone { get; private set; }
        protected DateTime DateOfBirth { get; private set; }
        protected string NIF { get; private set; }

        /// <summary>
        /// Initializes a new instance of the Person class.
        /// </summary>
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
        // Métodos públicos para acessar DateOfBirth e NIF
        public DateTime GetDateOfBirth()
        {
            return DateOfBirth;
        }

        public string GetNIF()
        {
            return NIF;
        }
    }

    /// <summary>
    /// Represents a medical specialty in the health clinic system.
    /// </summary>
    public class Specialty
    {
        public int ID { get; private set; }
        public string SpecialtyName { get; private set; }  // Changed to private set

        /// <summary>
        /// Initializes a new instance of the Specialty class.
        /// </summary>
        public Specialty(int id, string specialtyName)
        {
            ID = id;
            SpecialtyName = specialtyName;
        }
    }

    /// <summary>
    /// Represents a staff member in the health clinic system.
    /// </summary>
    public class Staff : Person
    {
        public string Role { get; private set; }

        /// <summary>
        /// Initializes a new instance of the Staff class.
        /// </summary>
        public Staff(int id, string name, string address, DateTime dateOfBirth, string email, string telephone, string nif, string role)
            : base(id, name, address, dateOfBirth, email, telephone, nif)
        {
            Role = role;
        }
    }

    /// <summary>
    /// Represents a doctor in the health clinic system.
    /// </summary>
    public class Doctor : Staff
    {
        public Specialty Specialty { get; private set; }
        public decimal ConsultationFee { get; private set; }

        /// <summary>
        /// Initializes a new instance of the Doctor class.
        /// </summary>
        public Doctor(int id, string name, string address, DateTime dateOfBirth, string email, string telephone, string nif, Specialty specialty, decimal consultationFee)
            : base(id, name, address, dateOfBirth, email, telephone, nif, "Doctor")
        {
            Specialty = specialty;
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
        public int RoomNumber { get; }
        protected bool IsAvailable { get; private set; }

        public Room(int roomNumber)
        {
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
        public string MedicationName { get; }
        public string Dosage { get; }
        public decimal Cost { get; }

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
        public string ExamName { get; }
        public decimal Cost { get; }

        public Exam(int id, string examName, decimal cost)
        {
            ID = id;
            ExamName = examName;
            Cost = cost;
        }
    }

    public class Appointment
    {
        public DateTime Date { get; private set; }
        public Doctor Doctor { get; private set; }
        public Patient Patient { get; private set; }
        public Room Room { get; private set; }
        public List<Medication> Medications { get; } = new List<Medication>();
        public List<Exam> Exams { get; } = new List<Exam>();

        public Appointment(DateTime date, Doctor doctor, Patient patient, Room room)
        {
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
                Console.WriteLine($"Doctor {doctor.Name} added with specialty {doctor.Specialty.SpecialtyName}.");
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
        private static readonly string connectionString = "Data Source=.;Initial Catalog=Health_POO;Integrated Security=True";

        public static void SavePerson(Person person)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Person (ID, Name, Address, DateOfBirth, Email, Telephone, NIF) VALUES (@ID, @Name, @Address, @DateOfBirth, @Email, @Telephone, @NIF)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", person.ID);
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
                string query = "INSERT INTO Specialty (ID, SpecialtyName) VALUES (@ID, @SpecialtyName)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", specialty.ID);
                    cmd.Parameters.AddWithValue("@SpecialtyName", specialty.SpecialtyName);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void SaveMedication(Medication medication)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Medication (ID, MedicationName, Dosage, Cost) VALUES (@ID, @MedicationName, @Dosage, @Cost)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", medication.ID);
                    cmd.Parameters.AddWithValue("@MedicationName", medication.MedicationName);
                    cmd.Parameters.AddWithValue("@Dosage", medication.Dosage);
                    cmd.Parameters.AddWithValue("@Cost", medication.Cost);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void SaveExam(Exam exam)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Exam (ID, ExamName, Cost) VALUES (@ID, @ExamName, @Cost)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", exam.ID);
                    cmd.Parameters.AddWithValue("@ExamName", exam.ExamName);
                    cmd.Parameters.AddWithValue("@Cost", exam.Cost);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void SaveDoctor(Doctor doctor)
        {
            SavePerson(doctor);  // Save the basic person details first

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Doctor (ID, SpecialtyID, ConsultationFee) VALUES (@ID, @SpecialtyID, @ConsultationFee)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", doctor.ID);
                    cmd.Parameters.AddWithValue("@SpecialtyID", doctor.Specialty.ID);
                    cmd.Parameters.AddWithValue("@ConsultationFee", doctor.ConsultationFee);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void SaveStaff(Staff staff)
        {
            SavePerson(staff);  

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Staff (ID, Role) VALUES (@ID, @Role)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", staff.ID);
                    cmd.Parameters.AddWithValue("@Role", staff.Role);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void SavePatient(Patient patient)
        {
            SavePerson(patient);  // Save the basic person details first

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Patient (ID) VALUES (@ID)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", patient.ID);
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
                    cmd.Parameters.AddWithValue("@DoctorID", appointment.Doctor.ID);
                    cmd.Parameters.AddWithValue("@PatientID", appointment.Patient.ID);
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

            // Criar especialidade
            var cardiology = new Specialty(1, "Cardiology");


            // Criar médicos
            var doctor1 = new Doctor(1, "Dr. Smith", "123 Street", new DateTime(1980, 1, 1), "drsmith@clinic.com", "123456789", "123456789", cardiology, 100);
            DatabaseHelper.SavePerson(doctor1);

            var doctor2 = new Doctor(2, "Dr. John", "456 Avenue", new DateTime(1985, 2, 1), "drjohn@clinic.com", "987654321", "987654321", cardiology, 150);

            // Adicionar médicos à clínica
            clinic.AddDoctor(doctor1);
            clinic.AddDoctor(doctor2);

            // Criar pacientes
            var patient1 = new Patient(1, "Alice", "789 Road", new DateTime(1990, 3, 1), "alice@clinic.com", "123123123", "123123123");
            var patient2 = new Patient(2, "Bob", "101 Street", new DateTime(1992, 4, 1), "bob@clinic.com", "456456456", "456456456");

            // Adicionar pacientes à clínica
            clinic.AddPatient(patient1);
            clinic.AddPatient(patient2);

            // Criar salas
            var room1 = new Room(101);
            var room2 = new Room(102);

            // Adicionar salas à clínica
            clinic.AddRoom(room1);
            clinic.AddRoom(room2);

            // Agendar consultas
            var appointment1 = new Appointment(DateTime.Now, doctor1, patient1, room1);
            var appointment2 = new Appointment(DateTime.Now, doctor2, patient2, room2);

            clinic.ScheduleAppointment(appointment1);
            clinic.ScheduleAppointment(appointment2);
        }
    }
}


