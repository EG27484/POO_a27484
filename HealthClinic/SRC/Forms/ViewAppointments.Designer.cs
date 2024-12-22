using System.Drawing;
using System.Windows.Forms;

namespace HealthClinic.Forms
{
    /// \file ViewAppointments.Designer.cs
    /// \brief Designer class for the ViewAppointments form in the HealthClinic application.

    partial class ViewAppointments
    {
        #region Fields

        /// \brief Container for components used in the form.
        private System.ComponentModel.IContainer components = null;

        /// \brief DataGridView control for displaying appointment data.
        private DataGridView dgvAppointments;

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

        /// \brief Initializes the components of the ViewAppointments form.
        private void InitializeComponent()
        {
            dgvAppointments = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).BeginInit();
            SuspendLayout();
            // 
            // dgvAppointments
            // 
            dgvAppointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAppointments.ColumnHeadersHeight = 29;
            dgvAppointments.Dock = DockStyle.Fill;
            dgvAppointments.Location = new Point(0, 0);
            dgvAppointments.Name = "dgvAppointments";
            dgvAppointments.ReadOnly = true;
            dgvAppointments.RowHeadersWidth = 51;
            dgvAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAppointments.Size = new Size(800, 450);
            dgvAppointments.TabIndex = 0;
            dgvAppointments.CellContentClick += dgvAppointments_CellContentClick;
            dgvAppointments.CellDoubleClick += dgvAppointments_CellDoubleClick;
            // 
            // ViewAppointments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvAppointments);
            Name = "ViewAppointments";
            Text = "View Appointments";
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}
