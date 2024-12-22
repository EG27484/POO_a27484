using HealthClinic.Utils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HealthClinic.Models
{
    /// \file PatientServices.cs
    /// \brief Provides a collection of static methods to manage patients.

    internal class PatientServices
    {
        #region Methods

        /// \brief Adds a new patient to the list and saves the updated list to a file.
        /// \param patients The current list of patients.
        /// \param newPatient The patient to add to the list.
        public static void AddPatient(List<Patient> patients, Patient newPatient)
        {
            patients.Add(newPatient);
            DataPersistence.SaveDataToFile(patients, "patients.json");
        }

        /// \brief Loads all patients from a file.
        /// \return A list of patients loaded from the file.
        public static List<Patient> ViewAllPatients()
        {
            return DataPersistence.LoadDataFromFile<Patient>("patients.json");
        }

        /// \brief Searches for a patient by their name.
        /// \param patients The list of patients to search.
        /// \param name The name of the patient to find.
        /// \return The patient object if found, otherwise null.
        public static Patient SearchPatientByName(List<Patient> patients, string name)
        {
            return patients.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        /// \brief Deletes a patient from the list and saves the updated list to a file.
        /// \param patients The current list of patients.
        /// \param patientToRemove The patient to remove from the list.
        public static void DeletePatient(List<Patient> patients, Patient patientToRemove)
        {
            patients.Remove(patientToRemove);
            DataPersistence.SaveDataToFile(patients, "patients.json");
        }

        #endregion
    }
}
