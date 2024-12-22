/// \file Program.cs
/// \brief Entry point for the HealthClinic application.
/// \details This file contains the main entry point for the HealthClinic application.

using System;
using System.Collections.Generic;
using System.Numerics;
using HealthClinic.Models;
using HealthClinic.Utils;
using HealthClinic.Forms;

namespace HealthClinic
{
    /// \namespace HealthClinic
    /// \brief Contains the core components and entry point for the HealthClinic application.

    public static class Program
    {
        /// \brief The main entry point for the application.
        /// \details Initializes application configuration and starts the application with a login form or the main menu.
        /// \remarks The [STAThread] attribute is required for Windows Forms applications.
        [STAThread]
        public static void Main()
        {
            /// \brief Initializes application settings and starts the application.
            ApplicationConfiguration.Initialize();

            /// \details Determines whether to start with the LoginHostForm or MainMenuForm.
            /// \remarks Replace LoginHostForm with MainMenuForm if login functionality is not required.
            Application.Run(new LoginHostForm());
        }
    }
}
