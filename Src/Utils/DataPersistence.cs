using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace HealthClinic.Utils
{
    /// \file DataPersistence.cs
    /// \brief Provides utility methods for saving and loading data to and from files.
    /// \details This class utilizes JSON serialization and deserialization for data persistence.

    public static class DataPersistence
    {
        #region Fields

        /// \brief JSON serializer settings.
        /// \details Configures settings for handling object references and preventing reference loops during serialization.
        private static JsonSerializerSettings settings = new JsonSerializerSettings
        {
            PreserveReferencesHandling = PreserveReferencesHandling.Objects,
            ReferenceLoopHandling = ReferenceLoopHandling.Serialize
        };

        #endregion

        #region Methods

        /// \brief Saves data to a specified file.
        /// \param data A list of data objects to save.
        /// \param filePath The file path where the data will be saved.
        /// \tparam T The type of objects in the data list.
        /// \remarks The data is saved in a JSON format with indented styling.
        public static void SaveDataToFile<T>(List<T> data, string filePath)
        {
            var settings = new JsonSerializerSettings
            {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
                Formatting = Newtonsoft.Json.Formatting.Indented
            };

            string json = JsonConvert.SerializeObject(data, settings);
            File.WriteAllText(filePath, json);
        }

        /// \brief Loads data from a specified file.
        /// \param filePath The file path from which the data will be loaded.
        /// \tparam T The type of objects in the data list.
        /// \return A list of objects of type T loaded from the file.
        /// \remarks If the file does not exist, an empty list is returned.
        public static List<T> LoadDataFromFile<T>(string filePath)
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<List<T>>(json, settings);
            }
            return new List<T>();
        }

        #endregion
    }
}
