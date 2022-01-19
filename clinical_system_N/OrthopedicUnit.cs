using clinical_system_N.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinical_system_N
{
    internal partial class OrthopedicUnit : Form
    {
        Patient patient;
        public OrthopedicUnit()
        {
            InitializeComponent();
        }
        public OrthopedicUnit(Patient patient)
        {
            this.patient = patient;
            InitializeComponent();
        }

        private void btn_investigation(object sender, EventArgs e)
        {
            this.Hide();
            Investigation C134 = new Investigation();
            C134.Show();
        }

        private void btn_diagnosis(object sender, EventArgs e)
        {
            this.Hide();
            diagnosisdoc C136 = new diagnosisdoc();
            C136.Show();
        }

        private void OrthopedicUnit_Load(object sender, EventArgs e)
        {
            if (patient != null)
            {
                JsonManager jsonManager = new JsonManager();    
                var ls = jsonManager.GetHistory(patient.info.PatientId);
                history.Text = ls[0] + '\n' + ls[1];    
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_assesment(object sender, EventArgs e)
        {
            this.Hide();
            Assesment C135 = new Assesment();
            C135.Show();
        }

        private void btn_services(object sender, EventArgs e)
        {
            this.Hide();
            Services C137 = new Services();
            C137.Show();
        }

        private void btn_x_ray(object sender, EventArgs e)
        {
            this.Hide();
            X_Ray C138 = new X_Ray();
            C138.Show();
        }

        private void btn_doctor_prescription(object sender, EventArgs e)
        {
            this.Hide();
            Doctor_Prescription C139 = new Doctor_Prescription();
            C139.Show();
        }

        private void btn_app(object sender, EventArgs e)
        {
            this.Hide();
            App C140 = new App();
            C140.Show();
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_calender(object sender, EventArgs e)
        {
            this.Hide();
            OrthopedicUnit_Calender C12 = new OrthopedicUnit_Calender();
            C12.Show();
        }

        private void btn_records(object sender, EventArgs e)
        {
            this.Hide();
            Records C13 = new Records();
            C13.Show();
        }

        private void btn_finance(object sender, EventArgs e)
        {
            this.Hide();
            Finance C14 = new Finance();
            C14.Show();
        }

        private void btn_adminsettings(object sender, EventArgs e)
        {
            this.Hide();
            AdminSettings C15 = new AdminSettings();
            C15.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void history_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
