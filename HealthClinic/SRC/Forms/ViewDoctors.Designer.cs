using System.Drawing;
using System.Windows.Forms;
using System;

namespace HealthClinic
{
    /// \file ViewDoctors.Designer.cs
    /// \brief Designer class for the ViewDoctors form in the HealthClinic application.

    partial class ViewDoctors
    {
        #region Fields

        /// \brief Container for components used in the form.
        private System.ComponentModel.IContainer components = null;

        /// \brief ListView control for displaying doctor data.
        private ListView listViewDoctors;

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

        /// \brief Initializes the components of the ViewDoctors form.
        private void InitializeComponent()
        {
            listViewDoctors = new ListView();
            SuspendLayout();

            // 
            // listViewDoctors
            // 
            listViewDoctors.Dock = DockStyle.Fill;
            listViewDoctors.FullRowSelect = true;
            listViewDoctors.GridLines = true;
            listViewDoctors.Location = new Point(0, 0);
            listViewDoctors.Name = "listViewDoctors";
            listViewDoctors.Size = new Size(800, 450);
            listViewDoctors.TabIndex = 0;
            listViewDoctors.UseCompatibleStateImageBehavior = false;
            listViewDoctors.View = View.Details;
            listViewDoctors.SelectedIndexChanged += this.listViewDoctors_SelectedIndexChanged;

            // 
            // ViewDoctors
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listViewDoctors);
            Name = "ViewDoctors";
            Text = "View Doctors";
            ResumeLayout(false);
        }

        #endregion
    }
}
