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
    internal partial class Doctor_Prescription : Form
    {
        public Patient patient;

        public Doctor_Prescription(Patient p)
        {
            InitializeComponent();
            patient = p;
        }
        public Doctor_Prescription()
        {
            InitializeComponent();

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_assesment(object sender, EventArgs e)
        {
            this.Hide();
            Assesment C105 = new Assesment();
            C105.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_doctor_prescription(object sender, EventArgs e)
        {
            this.Hide();
            Doctor_Prescription C112 = new Doctor_Prescription(patient);
            C112.Show();
        }

        private void Doctor_Prescription_Load(object sender, EventArgs e)
        {
            display();
        }
        private void display()
        {
            string id = Guid.NewGuid().ToString();
            try
            {
                var pMed = GlobalManager.perscribedMedicines;
                foreach (PerscribedMedicine pat in pMed)
                {
                    new_prescription control = new new_prescription(pat);
                    flowLayoutPanel_Med.Controls.Add(control);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No patients are in the system.");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_calender(object sender, EventArgs e)
        {
            this.Hide();
            OrthopedicUnit_Calender C100 = new OrthopedicUnit_Calender();
            C100.Show();
        }

        private void btn_records(object sender, EventArgs e)
        {
            this.Hide();
            Records C101 = new Records();
            C101.Show();
        }

        private void btn_finance(object sender, EventArgs e)
        {
            this.Hide();
            Finance C102 = new Finance();
            C102.Show();
        }

        private void btn_adminsettings(object sender, EventArgs e)
        {
            this.Hide();
            AdminSettings C103 = new AdminSettings();
            C103.Show();
        }

        private void btn_investigation(object sender, EventArgs e)
        {
            this.Hide();
            Investigation C104 = new Investigation();
            C104.Show();
        }

        private void btn_physio(object sender, EventArgs e)
        {
            this.Hide();
            Physio C106 = new Physio();
            C106.Show();
        }

        private void btn_services(object sender, EventArgs e)
        {
            this.Hide();
            Services C107 = new Services();
            C107.Show();
        }

        private void btn_x_ray(object sender, EventArgs e)
        {
            this.Hide();
            X_Ray C108 = new X_Ray();
            C108.Show();
        }

        private void btn_app(object sender, EventArgs e)
        {
            this.Hide();
            App C113 = new App();
            C113.Show();
        }

        private void btn_save(object sender, EventArgs e)
        {
            JsonManager jsonManager = new JsonManager();
            jsonManager.AddJson(JsonType.Prescriptions, patient.info.PatientId, GlobalManager.perscribedMedicines);
            GlobalManager.perscribedMedicines.Clear();
        }

        private void btn_print(object sender, EventArgs e)
        {

        }

        private void new_prescription_panel(object sender, PaintEventArgs e)
        {

        }

        private void btn_add(object sender, EventArgs e)
        {
            this.Hide();
            Add_prescription C231 = new Add_prescription();
            C231.Show();

        }

        private void prescription_history_panel(object sender, PaintEventArgs e)
        {

        }
    }
}
