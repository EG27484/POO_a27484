using HealthClinic.Forms;
using System;
using System.Windows.Forms;

namespace HealthClinic.Forms
{
    /// \file LoginHostForm.cs
    /// \brief Host form for the login functionality in the HealthClinic application.

    public partial class LoginHostForm : Form
    {
        #region Constructor

        /// \brief Initializes a new instance of the LoginHostForm class.
        public LoginHostForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Event Handlers

        /// \brief Handles the load event of the LoginHostForm.
        /// \param sender The source of the event.
        /// \param e The event data.
        private void LoginHostForm_Load(object sender, EventArgs e)
        {
            // Create and add UserControl1 to the host form
            var loginControl = new UserControl1
            {
                Dock = DockStyle.Fill // Make it fill the form
            };

            // Handle successful login
            loginControl.LoginSuccess += OnLoginSuccess;

            // Add the UserControl to the form
            Controls.Add(loginControl);
        }

        /// \brief Handles the login success event.
        /// \param sender The source of the event.
        /// \param e The event data.
        private void OnLoginSuccess(object sender, EventArgs e)
        {
            // Open the Main Menu form upon successful login
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();

            // Close the LoginHostForm
            this.Hide();
        }

        #endregion
    }
}
