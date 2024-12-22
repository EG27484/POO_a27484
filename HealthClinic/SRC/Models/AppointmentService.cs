using HealthClinic.Utils;
using System.Collections.Generic;
using System.Linq;

namespace HealthClinic.Models
{
    /// \file AppointmentService.cs
    /// \brief Provides services for managing appointments in the HealthClinic application.

    public static class AppointmentService
    {
        #region Constants

        /// \brief The file path for storing appointment data.
        private const string AppointmentsFilePath = "appointments.json";

        #endregion

        #region Methods

        /// \brief Gets the next available ID for an appointment.
        /// \return The next appointment ID as an integer.
        public static int GetNextID()
        {
            var appointments = LoadAllAppointments();
            return appointments.Any() ? appointments.Max(a => a.AppointmentID) + 1 : 1;
        }

        /// \brief Saves a new appointment to the appointments file.
        /// \param appointment The appointment to save.
        public static void SaveAppointment(Appointment appointment)
        {
            var appointments = LoadAllAppointments();
            appointments.Add(appointment);
            DataPersistence.SaveDataToFile(appointments, AppointmentsFilePath);
        }

        /// \brief Loads all appointments from the appointments file.
        /// \return A list of appointments.
        public static List<Appointment> LoadAllAppointments()
        {
            return DataPersistence.LoadDataFromFile<Appointment>(AppointmentsFilePath);
        }

        #endregion
    }
}
