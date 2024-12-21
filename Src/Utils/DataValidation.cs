/// \file DataValidation.cs
/// \brief Provides utility methods for user input validation.
/// \details This class offers methods to validate integer, decimal, and string inputs from the user.

using System;

namespace HealthClinic.Utils
{
    /// \namespace HealthClinic.Utils
    /// \brief Contains utility classes and methods for the HealthClinic application.

    public static class DataValidation
    {
        #region Methods

        /// \brief Prompts the user for a valid positive integer.
        /// \param prompt The message displayed to the user.
        /// \return A valid positive integer entered by the user.
        /// \remarks Continues prompting the user until a valid input is provided.
        public static int GetValidInteger(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out int result) && result >= 0)
                {
                    return result;
                }
                Console.WriteLine("Invalid input, Please enter a positive integer");
            }
        }

        /// \brief Prompts the user for a valid positive decimal number.
        /// \param prompt The message displayed to the user.
        /// \return A valid positive decimal number entered by the user.
        /// \remarks Continues prompting the user until a valid input is provided.
        public static decimal GetValidDecimal(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                if (decimal.TryParse(Console.ReadLine(), out decimal result) && result >= 0)
                {
                    return result;
                }
                Console.WriteLine("Invalid input, Please enter a positive decimal number");
            }
        }

        /// \brief Prompts the user for a non-empty string.
        /// \param prompt The message displayed to the user.
        /// \return A non-empty string entered by the user.
        /// \remarks Continues prompting the user until a valid input is provided.
        public static string GetNonEmptyString(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    return input;
                }
                Console.WriteLine("Input cannot be empty, Please enter a valid value");
            }
        }

        #endregion
    }
}
