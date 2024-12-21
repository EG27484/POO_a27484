using System;
using System.Windows.Forms;
using HealthClinic.Models;
using HealthClinic.Utils;

namespace HealthClinic
{
    /// \file ViewDoctors.cs
    /// \brief Form for viewing and managing doctors in the HealthClinic application.

    public partial class ViewDoctors : Form
    {
        #region Constructor

        /// \brief Initializes a new instance of the ViewDoctors form.
        public ViewDoctors()
        {
            InitializeComponent();
            InitializeListView();
            LoadDoctors();
        }

        #endregion

        #region Private Methods

        /// \brief Configures the ListView control for displaying doctor details.
        private void InitializeListView()
        {
            // Configurar colunas do ListView
            listViewDoctors.Columns.Add("Name", 150);
            listViewDoctors.Columns.Add("Age", 50);
            listViewDoctors.Columns.Add("Gender", 100);
            listViewDoctors.Columns.Add("Contact Info", 200);
            listViewDoctors.Columns.Add("Specialty", 200);
            listViewDoctors.Columns.Add("Fee", 100);
        }

        /// \brief Loads doctor data from a JSON file and populates the ListView.
        private void LoadDoctors()
        {
            try
            {
                // Carregar médicos do arquivo JSON
                var doctors = DataPersistence.LoadDataFromFile<Doctor>("doctors.json");

                // Adicionar médicos ao ListView
                foreach (var doctor in doctors)
                {
                    var item = new ListViewItem(new[]
                    {
                        doctor.Name,
                        doctor.Age.ToString(),
                        doctor.Gender,
                        doctor.ContactInfo,
                        doctor.Specialty,
                        doctor.ConsultationFee.ToString("F2")
                    });

                    listViewDoctors.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading doctors: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// \brief Handles the selection change event for the ListView control.
        /// \param sender The source of the event.
        /// \param e The event data.
        private void listViewDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDoctors.SelectedItems.Count > 0)
            {
                var selectedItem = listViewDoctors.SelectedItems[0];
                MessageBox.Show($"Selected Doctor: {selectedItem.Text}");
            }
        }

        #endregion
    }
}
