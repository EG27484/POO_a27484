namespace HealthClinic.Forms
{
    partial class AddAppointment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cmbPatients = new ComboBox();
            cmbDoctors = new ComboBox();
            txtOfficeRoom = new TextBox();
            groupBox1 = new GroupBox();
            btnAddExam = new Button();
            txtExamCost = new TextBox();
            label5 = new Label();
            txtExamName = new TextBox();
            label4 = new Label();
            groupBox2 = new GroupBox();
            txtMedicationCost = new TextBox();
            label10 = new Label();
            btnAddMedication = new Button();
            txtMedicationName = new TextBox();
            label6 = new Label();
            btnSaveAppointment = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 55);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 0;
            label1.Text = "Patient:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 112);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 1;
            label2.Text = "Doctor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 171);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 2;
            label3.Text = "Office Room:";
            // 
            // cmbPatients
            // 
            cmbPatients.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPatients.FormattingEnabled = true;
            cmbPatients.Location = new Point(159, 51);
            cmbPatients.Margin = new Padding(3, 4, 3, 4);
            cmbPatients.Name = "cmbPatients";
            cmbPatients.Size = new Size(228, 28);
            cmbPatients.TabIndex = 3;
            // 
            // cmbDoctors
            // 
            cmbDoctors.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDoctors.FormattingEnabled = true;
            cmbDoctors.Location = new Point(159, 108);
            cmbDoctors.Margin = new Padding(3, 4, 3, 4);
            cmbDoctors.Name = "cmbDoctors";
            cmbDoctors.Size = new Size(228, 28);
            cmbDoctors.TabIndex = 4;
            // 
            // txtOfficeRoom
            // 
            txtOfficeRoom.Location = new Point(159, 167);
            txtOfficeRoom.Margin = new Padding(3, 4, 3, 4);
            txtOfficeRoom.Name = "txtOfficeRoom";
            txtOfficeRoom.Size = new Size(228, 27);
            txtOfficeRoom.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAddExam);
            groupBox1.Controls.Add(txtExamCost);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtExamName);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(42, 241);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(386, 180);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Exams";
            // 
            // btnAddExam
            // 
            btnAddExam.Location = new Point(261, 119);
            btnAddExam.Margin = new Padding(3, 4, 3, 4);
            btnAddExam.Name = "btnAddExam";
            btnAddExam.Size = new Size(86, 31);
            btnAddExam.TabIndex = 4;
            btnAddExam.Text = "Add";
            btnAddExam.UseVisualStyleBackColor = true;
            btnAddExam.Click += btnAddExam_Click;
            // 
            // txtExamCost
            // 
            txtExamCost.Location = new Point(123, 80);
            txtExamCost.Margin = new Padding(3, 4, 3, 4);
            txtExamCost.Name = "txtExamCost";
            txtExamCost.Size = new Size(222, 27);
            txtExamCost.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 84);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 2;
            label5.Text = "Cost:";
            // 
            // txtExamName
            // 
            txtExamName.Location = new Point(123, 41);
            txtExamName.Margin = new Padding(3, 4, 3, 4);
            txtExamName.Name = "txtExamName";
            txtExamName.Size = new Size(222, 27);
            txtExamName.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 45);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 0;
            label4.Text = "Name";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtMedicationCost);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(btnAddMedication);
            groupBox2.Controls.Add(txtMedicationName);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(42, 447);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(386, 180);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Medications";
            // 
            // txtMedicationCost
            // 
            txtMedicationCost.Location = new Point(123, 80);
            txtMedicationCost.Margin = new Padding(3, 4, 3, 4);
            txtMedicationCost.Name = "txtMedicationCost";
            txtMedicationCost.Size = new Size(222, 27);
            txtMedicationCost.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(24, 84);
            label10.Name = "label10";
            label10.Size = new Size(41, 20);
            label10.TabIndex = 2;
            label10.Text = "Cost:";
            // 
            // btnAddMedication
            // 
            btnAddMedication.Location = new Point(261, 119);
            btnAddMedication.Margin = new Padding(3, 4, 3, 4);
            btnAddMedication.Name = "btnAddMedication";
            btnAddMedication.Size = new Size(86, 31);
            btnAddMedication.TabIndex = 8;
            btnAddMedication.Text = "Add";
            btnAddMedication.UseVisualStyleBackColor = true;
            btnAddMedication.Click += btnAddMedication_Click;
            // 
            // txtMedicationName
            // 
            txtMedicationName.Location = new Point(123, 39);
            txtMedicationName.Margin = new Padding(3, 4, 3, 4);
            txtMedicationName.Name = "txtMedicationName";
            txtMedicationName.Size = new Size(222, 27);
            txtMedicationName.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 43);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 0;
            label6.Text = "Name";
            // 
            // btnSaveAppointment
            // 
            btnSaveAppointment.Location = new Point(310, 653);
            btnSaveAppointment.Margin = new Padding(3, 4, 3, 4);
            btnSaveAppointment.Name = "btnSaveAppointment";
            btnSaveAppointment.Size = new Size(119, 45);
            btnSaveAppointment.TabIndex = 8;
            btnSaveAppointment.Text = "Save Appointment";
            btnSaveAppointment.UseVisualStyleBackColor = true;
            btnSaveAppointment.Click += btnSaveAppointment_Click;
            // 
            // AddAppointment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 731);
            Controls.Add(btnSaveAppointment);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(txtOfficeRoom);
            Controls.Add(cmbDoctors);
            Controls.Add(cmbPatients);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddAppointment";
            Text = "Add Appointment";
            Load += AddAppointment_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbPatients;
        private ComboBox cmbDoctors;
        private TextBox txtOfficeRoom;
        private GroupBox groupBox1;
        private Button btnAddExam;
        private TextBox txtExamCost;
        private Label label5;
        private TextBox txtExamName;
        private Label label4;
        private GroupBox groupBox2;
        private Button btnAddMedication;
        private TextBox txtMedicationName;
        private Label label6;
        private Button btnSaveAppointment;
        private TextBox txtMedicationCost;
        private Label label10;
    }
}