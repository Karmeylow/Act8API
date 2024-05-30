namespace Act_8_API
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblPatients;
        private System.Windows.Forms.TextBox txtPatients;
        private System.Windows.Forms.Button btnGetPatients;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label lblPatientAge;
        private System.Windows.Forms.TextBox txtPatientAge;
        private System.Windows.Forms.Label lblPatientGender;
        private System.Windows.Forms.TextBox txtPatientGender;
        private System.Windows.Forms.Label lblPatientContacts;
        private System.Windows.Forms.TextBox txtPatientContacts;
        private System.Windows.Forms.Label lblAppointments;
        private System.Windows.Forms.TextBox txtAppointments;
        private System.Windows.Forms.Button btnGetAppointments;
        private System.Windows.Forms.Button btnAddAppointment;
        private System.Windows.Forms.Label lblAppointmentDate;
        private System.Windows.Forms.TextBox txtAppointmentDate;
        private System.Windows.Forms.Label lblAppointmentReason;
        private System.Windows.Forms.TextBox txtAppointmentReason;

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
            lblPatients = new Label();
            txtPatients = new TextBox();
            btnGetPatients = new Button();
            btnAddPatient = new Button();
            lblPatientName = new Label();
            txtPatientName = new TextBox();
            lblPatientAge = new Label();
            txtPatientAge = new TextBox();
            lblPatientGender = new Label();
            txtPatientGender = new TextBox();
            lblPatientContacts = new Label();
            txtPatientContacts = new TextBox();
            lblAppointments = new Label();
            txtAppointments = new TextBox();
            btnGetAppointments = new Button();
            btnAddAppointment = new Button();
            lblAppointmentDate = new Label();
            txtAppointmentDate = new TextBox();
            lblAppointmentReason = new Label();
            txtAppointmentReason = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblPatients
            // 
            lblPatients.AutoSize = true;
            lblPatients.Location = new Point(21, 22);
            lblPatients.Margin = new Padding(5, 0, 5, 0);
            lblPatients.Name = "lblPatients";
            lblPatients.Size = new Size(63, 20);
            lblPatients.TabIndex = 0;
            lblPatients.Text = "Patients:";
            // 
            // txtPatients
            // 
            txtPatients.Location = new Point(27, 58);
            txtPatients.Margin = new Padding(5, 8, 5, 8);
            txtPatients.Multiline = true;
            txtPatients.Name = "txtPatients";
            txtPatients.Size = new Size(619, 350);
            txtPatients.TabIndex = 1;
            // 
            // btnGetPatients
            // 
            btnGetPatients.Location = new Point(27, 424);
            btnGetPatients.Margin = new Padding(5, 8, 5, 8);
            btnGetPatients.Name = "btnGetPatients";
            btnGetPatients.Size = new Size(133, 54);
            btnGetPatients.TabIndex = 2;
            btnGetPatients.Text = "Get Patients";
            btnGetPatients.UseVisualStyleBackColor = true;
            btnGetPatients.Click += btnGetPatients_Click;
            // 
            // btnAddPatient
            // 
            btnAddPatient.Location = new Point(513, 424);
            btnAddPatient.Margin = new Padding(5, 8, 5, 8);
            btnAddPatient.Name = "btnAddPatient";
            btnAddPatient.Size = new Size(133, 54);
            btnAddPatient.TabIndex = 3;
            btnAddPatient.Text = "Add Patient";
            btnAddPatient.UseVisualStyleBackColor = true;
            btnAddPatient.Click += btnAddPatient_Click;
            // 
            // lblPatientName
            // 
            lblPatientName.AutoSize = true;
            lblPatientName.Location = new Point(676, 61);
            lblPatientName.Margin = new Padding(4, 0, 4, 0);
            lblPatientName.Name = "lblPatientName";
            lblPatientName.Size = new Size(52, 20);
            lblPatientName.TabIndex = 0;
            lblPatientName.Text = "Name:";
            // 
            // txtPatientName
            // 
            txtPatientName.Location = new Point(710, 95);
            txtPatientName.Margin = new Padding(4, 5, 4, 5);
            txtPatientName.Name = "txtPatientName";
            txtPatientName.Size = new Size(219, 27);
            txtPatientName.TabIndex = 1;
            // 
            // lblPatientAge
            // 
            lblPatientAge.AutoSize = true;
            lblPatientAge.Location = new Point(676, 137);
            lblPatientAge.Margin = new Padding(4, 0, 4, 0);
            lblPatientAge.Name = "lblPatientAge";
            lblPatientAge.Size = new Size(39, 20);
            lblPatientAge.TabIndex = 2;
            lblPatientAge.Text = "Age:";
            // 
            // txtPatientAge
            // 
            txtPatientAge.Location = new Point(710, 175);
            txtPatientAge.Margin = new Padding(4, 5, 4, 5);
            txtPatientAge.Name = "txtPatientAge";
            txtPatientAge.Size = new Size(219, 27);
            txtPatientAge.TabIndex = 3;
            txtPatientAge.TextChanged += txtPatientAge_TextChanged;
            // 
            // lblPatientGender
            // 
            lblPatientGender.AutoSize = true;
            lblPatientGender.Location = new Point(676, 249);
            lblPatientGender.Margin = new Padding(4, 0, 4, 0);
            lblPatientGender.Name = "lblPatientGender";
            lblPatientGender.Size = new Size(60, 20);
            lblPatientGender.TabIndex = 4;
            lblPatientGender.Text = "Gender:";
            lblPatientGender.Click += lblPatientGender_Click;
            // 
            // txtPatientGender
            // 
            txtPatientGender.Location = new Point(710, 293);
            txtPatientGender.Margin = new Padding(4, 5, 4, 5);
            txtPatientGender.Name = "txtPatientGender";
            txtPatientGender.Size = new Size(219, 27);
            txtPatientGender.TabIndex = 5;
            // 
            // lblPatientContacts
            // 
            lblPatientContacts.AutoSize = true;
            lblPatientContacts.Location = new Point(676, 339);
            lblPatientContacts.Margin = new Padding(4, 0, 4, 0);
            lblPatientContacts.Name = "lblPatientContacts";
            lblPatientContacts.Size = new Size(69, 20);
            lblPatientContacts.TabIndex = 6;
            lblPatientContacts.Text = "Contacts:";
            lblPatientContacts.Click += lblPatientContacts_Click;
            // 
            // txtPatientContacts
            // 
            txtPatientContacts.Location = new Point(710, 381);
            txtPatientContacts.Margin = new Padding(4, 5, 4, 5);
            txtPatientContacts.Name = "txtPatientContacts";
            txtPatientContacts.Size = new Size(219, 27);
            txtPatientContacts.TabIndex = 7;
            txtPatientContacts.TextChanged += txtPatientContacts_TextChanged;
            // 
            // lblAppointments
            // 
            lblAppointments.AutoSize = true;
            lblAppointments.Location = new Point(27, 517);
            lblAppointments.Margin = new Padding(5, 0, 5, 0);
            lblAppointments.Name = "lblAppointments";
            lblAppointments.Size = new Size(106, 20);
            lblAppointments.TabIndex = 4;
            lblAppointments.Text = "Appointments:";
            // 
            // txtAppointments
            // 
            txtAppointments.Location = new Point(33, 556);
            txtAppointments.Margin = new Padding(5, 8, 5, 8);
            txtAppointments.Multiline = true;
            txtAppointments.Name = "txtAppointments";
            txtAppointments.Size = new Size(619, 350);
            txtAppointments.TabIndex = 5;
            // 
            // btnGetAppointments
            // 
            btnGetAppointments.Location = new Point(33, 925);
            btnGetAppointments.Margin = new Padding(5, 8, 5, 8);
            btnGetAppointments.Name = "btnGetAppointments";
            btnGetAppointments.Size = new Size(191, 54);
            btnGetAppointments.TabIndex = 6;
            btnGetAppointments.Text = "Get Appointments";
            btnGetAppointments.UseVisualStyleBackColor = true;
            btnGetAppointments.Click += btnGetAppointments_Click;
            // 
            // btnAddAppointment
            // 
            btnAddAppointment.Location = new Point(465, 925);
            btnAddAppointment.Margin = new Padding(5, 8, 5, 8);
            btnAddAppointment.Name = "btnAddAppointment";
            btnAddAppointment.Size = new Size(191, 54);
            btnAddAppointment.TabIndex = 7;
            btnAddAppointment.Text = "Add Appointment";
            btnAddAppointment.UseVisualStyleBackColor = true;
            btnAddAppointment.Click += btnAddAppointment_Click;
            // 
            // lblAppointmentDate
            // 
            lblAppointmentDate.AutoSize = true;
            lblAppointmentDate.Location = new Point(682, 559);
            lblAppointmentDate.Margin = new Padding(4, 0, 4, 0);
            lblAppointmentDate.Name = "lblAppointmentDate";
            lblAppointmentDate.Size = new Size(134, 20);
            lblAppointmentDate.TabIndex = 8;
            lblAppointmentDate.Text = "Date: (2024-06-01)";
            // 
            // txtAppointmentDate
            // 
            txtAppointmentDate.Location = new Point(716, 596);
            txtAppointmentDate.Margin = new Padding(4, 5, 4, 5);
            txtAppointmentDate.Name = "txtAppointmentDate";
            txtAppointmentDate.Size = new Size(219, 27);
            txtAppointmentDate.TabIndex = 9;
            // 
            // lblAppointmentReason
            // 
            lblAppointmentReason.AutoSize = true;
            lblAppointmentReason.Location = new Point(682, 644);
            lblAppointmentReason.Margin = new Padding(4, 0, 4, 0);
            lblAppointmentReason.Name = "lblAppointmentReason";
            lblAppointmentReason.Size = new Size(60, 20);
            lblAppointmentReason.TabIndex = 10;
            lblAppointmentReason.Text = "Reason:";
            // 
            // txtAppointmentReason
            // 
            txtAppointmentReason.Location = new Point(716, 669);
            txtAppointmentReason.Margin = new Padding(4, 5, 4, 5);
            txtAppointmentReason.Name = "txtAppointmentReason";
            txtAppointmentReason.Size = new Size(219, 27);
            txtAppointmentReason.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.ForeColor = SystemColors.ControlDark;
            button1.Location = new Point(17, 494);
            button1.Name = "button1";
            button1.Size = new Size(927, 8);
            button1.TabIndex = 12;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aqua;
            ClientSize = new Size(954, 992);
            Controls.Add(button1);
            Controls.Add(lblAppointmentReason);
            Controls.Add(txtAppointmentReason);
            Controls.Add(lblAppointmentDate);
            Controls.Add(txtAppointmentDate);
            Controls.Add(lblAppointments);
            Controls.Add(txtAppointments);
            Controls.Add(btnGetAppointments);
            Controls.Add(btnAddAppointment);
            Controls.Add(lblPatientContacts);
            Controls.Add(txtPatientContacts);
            Controls.Add(lblPatientGender);
            Controls.Add(txtPatientGender);
            Controls.Add(lblPatientAge);
            Controls.Add(txtPatientAge);
            Controls.Add(lblPatientName);
            Controls.Add(txtPatientName);
            Controls.Add(lblPatients);
            Controls.Add(txtPatients);
            Controls.Add(btnGetPatients);
            Controls.Add(btnAddPatient);
            Margin = new Padding(5, 8, 5, 8);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clinic API Clinique";
            ResumeLayout(false);
            PerformLayout();
        }

        private Button button1;
    }
}
