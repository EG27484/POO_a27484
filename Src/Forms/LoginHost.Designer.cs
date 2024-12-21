using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace HealthClinic.Forms
{
    /// \file LoginHostForm.Designer.cs
    /// \brief Designer class for the LoginHostForm in the HealthClinic application.

    partial class LoginHostForm
    {
        #region Fields

        /// \brief Container for components used in the form.
        private System.ComponentModel.IContainer components = null;

        #endregion

        #region Methods

        /// \brief Disposes resources used by the form.
        /// \param disposing Indicates whether managed resources should be disposed.
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// \brief Initializes the components of the LoginHostForm.
        private void InitializeComponent()
        {
            SuspendLayout();

            // 
            // LoginHostForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 250);
            StartPosition = FormStartPosition.CenterScreen;
            Name = "LoginHostForm";
            Text = "Login";
            Load += new System.EventHandler(this.LoginHostForm_Load); // Attach the Load event
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}