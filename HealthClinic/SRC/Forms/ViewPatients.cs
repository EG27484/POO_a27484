using HealthClinic.Models;
using HealthClinic.Utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HealthClinic
{
    /// \file ViewPatients.cs
    /// \brief Form for viewing and managing patients in the HealthClinic application.

    public partial class ViewPatients : Form
    {
        #region Constructor

        /// \brief Initializes a new instance of the ViewPatients form.
        public ViewPatients()
        {
            InitializeComponent();
            InitializeListView();
            LoadPatients();
        }

        #endregion

        #region Private Methods

        /// \brief Configures the ListView control for displaying patient details.
        private void InitializeListView()
        {
            // Configuração do ListView
            listView1.Dock = DockStyle.Fill;
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            // Adicionando colunas ao ListView
            listView1.Columns.Add("Name", 150);
            listView1.Columns.Add("Age", 50);
            listView1.Columns.Add("Gender", 100);
            listView1.Columns.Add("Contact Info", 200);
            listView1.Columns.Add("Medical History", 300);
            listView1.Columns.Add("NIF", 100);
            listView1.Columns.Add("Address", 300);
        }

        /// \brief Loads patient data from a JSON file and populates the ListView.
        private void LoadPatients()
        {
            try
            {
                // Carregar pacientes do arquivo JSON
                List<Patient> patients = DataPersistence.LoadDataFromFile<Patient>("patients.json");

                // Adicionar os pacientes ao ListView
                foreach (var patient in patients)
                {
                    var item = new ListViewItem(new[]
                    {
                        patient.Name,
                        patient.Age.ToString(),
                        patient.Gender,
                        patient.ContactInfo,
                        patient.MedicalHistory,
                        patient.GetNIF(),
                        patient.GetAddress()
                    });

                    listView1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                // Exibir erro em caso de falha ao carregar dados
                MessageBox.Show($"Error loading patients: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// \brief Handles the selection change event for the ListView control.
        /// \param sender The source of the event.
        /// \param e The event data.
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var selectedItem = listView1.SelectedItems[0];
                MessageBox.Show($"Selected Patient: {selectedItem.Text}");
            }
        }

        #endregion
    }
}