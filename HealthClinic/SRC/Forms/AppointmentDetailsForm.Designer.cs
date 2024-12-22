using System.Drawing;
using System.Windows.Forms;

namespace HealthClinic.Forms
{
    /// \file AppointmentDetailsForm.Designer.cs
    /// \brief Designer class for the AppointmentDetailsForm in the HealthClinic application.
    partial class AppointmentDetailsForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblPatient;
        private Label lblDoctor;
        private Label lblRoom;
        private Label lblTotalCost;
        private ListBox lstExams;
        private ListBox lstMedications;
        private Label lblExams;
        private Label lblMedications;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblPatient = new Label();
            lblDoctor = new Label();
            lblRoom = new Label();
            lblTotalCost = new Label();
            lblDate = new Label();
            lstExams = new ListBox();
            lstMedications = new ListBox();
            lblExams = new Label();
            lblMedications = new Label();
            SuspendLayout();
            // 
            // lblPatient
            // 
            lblPatient.Location = new Point(20, 20);
            lblPatient.Name = "lblPatient";
            lblPatient.Size = new Size(400, 30);
            lblPatient.TabIndex = 0;
            // 
            // lblDoctor
            // 
            lblDoctor.Location = new Point(20, 60);
            lblDoctor.Name = "lblDoctor";
            lblDoctor.Size = new Size(400, 30);
            lblDoctor.TabIndex = 1;
            // 
            // lblRoom
            // 
            lblRoom.Location = new Point(20, 100);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new Size(400, 30);
            lblRoom.TabIndex = 2;
            lblRoom.Click += lblRoom_Click;
            // 
            // lblTotalCost
            // 
            lblTotalCost.Location = new Point(20, 140);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(400, 30);
            lblTotalCost.TabIndex = 3;
            lblTotalCost.Click += lblTotalCost_Click;
            // 
            // lblDate
            // 
            lblDate.Location = new Point(20, 180);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(400, 30);
            lblDate.TabIndex = 4;
            // 
            // lstExams
            // 
            lstExams.Location = new Point(20, 240);
            lstExams.Name = "lstExams";
            lstExams.Size = new Size(200, 84);
            lstExams.TabIndex = 5;
            // 
            // lstMedications
            // 
            lstMedications.Location = new Point(240, 240);
            lstMedications.Name = "lstMedications";
            lstMedications.Size = new Size(200, 84);
            lstMedications.TabIndex = 7;
            // 
            // lblExams
            // 
            lblExams.Location = new Point(20, 220);
            lblExams.Name = "lblExams";
            lblExams.Size = new Size(200, 20);
            lblExams.TabIndex = 6;
            lblExams.Text = "Prescribed Exams:";
            // 
            // lblMedications
            // 
            lblMedications.Location = new Point(240, 220);
            lblMedications.Name = "lblMedications";
            lblMedications.Size = new Size(200, 20);
            lblMedications.TabIndex = 8;
            lblMedications.Text = "Prescribed Medications:";
            // 
            // AppointmentDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 360);
            Controls.Add(lblPatient);
            Controls.Add(lblDoctor);
            Controls.Add(lblRoom);
            Controls.Add(lblTotalCost);
            Controls.Add(lblDate);
            Controls.Add(lblExams);
            Controls.Add(lstExams);
            Controls.Add(lblMedications);
            Controls.Add(lstMedications);
            Name = "AppointmentDetailsForm";
            Text = "Appointment Details";
            ResumeLayout(false);
        }

        private void lblRoom_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Room label clicked!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
