using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HealthClinic.Forms
{
    /// \file UserControl1.Designer.cs
    /// \brief Designer class for the UserControl1 in the HealthClinic application.

    partial class UserControl1
    {
        #region Fields

        /// \brief Container for components used in the user control.
        private System.ComponentModel.IContainer components = null;

        /// \brief TextBox for the username input.
        private TextBox txtUsername;

        /// \brief TextBox for the password input.
        private TextBox txtPassword;

        /// \brief Button for login action.
        private Button btnLogin;

        /// \brief Label for displaying messages.
        private Label lblMessage;

        #endregion

        #region Methods

        /// \brief Disposes resources used by the user control.
        /// \param disposing Indicates whether managed resources should be disposed.
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// \brief Initializes the components of the UserControl1.
        private void InitializeComponent()
        {
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lblMessage = new Label();
            SuspendLayout();

            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(20, 20);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(200, 27);
            txtUsername.TabIndex = 0;

            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(20, 60);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(200, 27);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;

            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(20, 100);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(200, 30);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;

            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(20, 140);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 20);
            lblMessage.TabIndex = 3;

            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
            Controls.Add(lblMessage);
            Name = "UserControl1";
            Size = new Size(250, 200);
            Load += UserControl1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}