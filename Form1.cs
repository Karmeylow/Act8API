using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Act_8_API
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient client = new HttpClient();

        private string[] doctorNames = { "Dr. Smith", "Dr. Brown", "Dr. Taylor", "Dr. Anderson", "Dr. White" };

        public Form1()
        {
            InitializeComponent();
        }

        private async void btnGetPatients_Click(object sender, EventArgs e)
        {
            try
            {
                var response = await client.GetStringAsync("http://localhost/clinic-api/index.php/patients");
                txtPatients.Text = response;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching patients: " + ex.Message);
            }
        }

        private async void btnAddPatient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPatientName.Text) ||
                string.IsNullOrWhiteSpace(txtPatientAge.Text) ||
                string.IsNullOrWhiteSpace(txtPatientGender.Text) ||
                string.IsNullOrWhiteSpace(txtPatientContacts.Text))
            {
                MessageBox.Show("Please fill in all patient information.");
                return;
            }

            try
            {
                var newPatient = new
                {
                    name = txtPatientName.Text,
                    age = Convert.ToInt32(txtPatientAge.Text),
                    gender = txtPatientGender.Text,
                    contact = txtPatientContacts.Text
                };
                var content = new StringContent(JsonConvert.SerializeObject(newPatient), Encoding.UTF8, "application/json");
                var response = await client.PostAsync("http://localhost/clinic-api/index.php/patients", content);
                var responseString = await response.Content.ReadAsStringAsync();
                MessageBox.Show("Patient added: " + responseString);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding patient: " + ex.Message);
            }
        }

        private async void btnGetAppointments_Click(object sender, EventArgs e)
        {
            try
            {
                var response = await client.GetStringAsync("http://localhost/clinic-api/index.php/appointments");
                txtAppointments.Text = response;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching appointments: " + ex.Message);
            }
        }

        private async void btnAddAppointment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAppointmentDate.Text) || string.IsNullOrWhiteSpace(txtAppointmentReason.Text))
            {
                MessageBox.Show("Please fill in appointment date and reason.");
                return;
            }

            try
            {
                Random rnd = new Random();
                string doctor = doctorNames[rnd.Next(doctorNames.Length)];

                var newAppointment = new
                {
                    patient_id = 1, // You need to adjust this according to your logic
                    appointment_date = txtAppointmentDate.Text,
                    doctor = doctor,
                    reason = txtAppointmentReason.Text
                };
                var content = new StringContent(JsonConvert.SerializeObject(newAppointment), Encoding.UTF8, "application/json");
                var response = await client.PostAsync("http://localhost/clinic-api/index.php/appointments", content);
                var responseString = await response.Content.ReadAsStringAsync();
                MessageBox.Show("Appointment added: " + responseString);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding appointment: " + ex.Message);
            }
        }

        private void lblPatientContacts_Click(object sender, EventArgs e)
        {

        }

        private void txtPatientContacts_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPatientAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPatientGender_Click(object sender, EventArgs e)
        {

        }
    }
}
