using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HealthClinic.Forms
{
    /// \file UserControl1.cs
    /// \brief User control for handling user login in the HealthClinic application.

    public partial class UserControl1 : UserControl
    {
        #region Events

        /// \brief Event triggered when login is successful.
        public event EventHandler LoginSuccess;

        #endregion

        #region Fields

        /// \brief Mocked user credentials for login verification.
        private readonly Dictionary<string, string> users = new Dictionary<string, string>
        {
            { "admin", "password123" },
            { "user1", "userpassword" }
        };

        #endregion

        #region Constructor

        /// \brief Initializes a new instance of the UserControl1 class.
        public UserControl1()
        {
            InitializeComponent();
        }

        #endregion

        #region Event Handlers

        /// \brief Handles the login button click event.
        /// \param sender The source of the event.
        /// \param e The event data.
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            // Validate input fields
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblMessage.Text = "Please fill in all fields.";
                lblMessage.ForeColor = System.Drawing.Color.Red;
                return;
            }

            // Check credentials
            if (users.TryGetValue(username, out string correctPassword) && correctPassword == password)
            {
                lblMessage.Text = "Login successful!";
                lblMessage.ForeColor = System.Drawing.Color.Green;
                MessageBox.Show("Welcome!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Trigger login success event
                LoginSuccess?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                lblMessage.Text = "Invalid username or password.";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
        }

        /// \brief Handles the load event of the user control.
        /// \param sender The source of the event.
        /// \param e The event data.
        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
