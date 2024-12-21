using System.Drawing;
using System.Windows.Forms;

namespace HealthClinic
{
    /// \file ViewPatients.Designer.cs
    /// \brief Designer class for the ViewPatients form in the HealthClinic application.

    partial class ViewPatients
    {
        #region Fields

        /// \brief Container for components used in the form.
        private System.ComponentModel.IContainer components = null;

        /// \brief ListView control for displaying patient data.
        private ListView listView1;

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

        /// \brief Initializes the components of the ViewPatients form.
        private void InitializeComponent()
        {
            listView1 = new ListView();
            SuspendLayout();

            // Configuração do ListView
            listView1.Location = new Point(12, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(776, 426);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.SelectedIndexChanged += new EventHandler(listView1_SelectedIndexChanged);

            // Configuração do Form
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listView1);
            Name = "ViewPatients";
            Text = "Health Clinic - Patient List";
            ResumeLayout(false);
        }

        #endregion
    }
}
