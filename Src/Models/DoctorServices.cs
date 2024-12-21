using HealthClinic.Utils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HealthClinic.Models
{
    /// \file DoctorServices.cs
    /// \brief Provides a collection of static methods to manage doctors.

    internal class DoctorServices
    {
        #region Methods

        /// \brief Adds a new doctor to the list and saves the updated list to a file.
        /// \param doctors The current list of doctors.
        /// \param newDoctor The doctor to add to the list.
        public static void AddDoctor(List<Doctor> doctors, Doctor newDoctor)
        {
            doctors.Add(newDoctor);
            DataPersistence.SaveDataToFile(doctors, "doctors.json");
        }

        /// \brief Loads all doctors from a file.
        /// \return A list of doctors loaded from the file.
        public static List<Doctor> ViewAllDoctors()
        {
            return DataPersistence.LoadDataFromFile<Doctor>("doctors.json");
        }

        /// \brief Searches for a doctor by their name.
        /// \param doctors The list of doctors to search.
        /// \param name The name of the doctor to find.
        /// \return The doctor object if found, otherwise null.
        public static Doctor SearchDoctorByName(List<Doctor> doctors, string name)
        {
            return doctors.FirstOrDefault(d => d.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        /// \brief Deletes a doctor from the list and saves the updated list to a file.
        /// \param doctors The current list of doctors.
        /// \param doctorToRemove The doctor to remove from the list.
        public static void DeleteDoctor(List<Doctor> doctors, Doctor doctorToRemove)
        {
            doctors.Remove(doctorToRemove);
            DataPersistence.SaveDataToFile(doctors, "doctors.json");
        }

        #endregion
    }
}
