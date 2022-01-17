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
    public partial class Services : Form
    {
        public Services()
        {
            InitializeComponent();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_calender(object sender, EventArgs e)
        {
            this.Hide();
            OrthopedicUnit_Calender C177 = new OrthopedicUnit_Calender();
            C177.Show();
        }

        private void btn_records(object sender, EventArgs e)
        {
            this.Hide();
            Records C178 = new Records();
            C178.Show();
        }

        private void btn_finance(object sender, EventArgs e)
        {
            this.Hide();
            Finance C179 = new Finance();
            C179.Show();
        }

        private void btn_adminsettings(object sender, EventArgs e)
        {
            this.Hide();
            AdminSettings C180 = new AdminSettings();
            C180.Show();
        }

        private void btn_AddPatient_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Patient C181 = new Add_Patient();
            C181.Show();
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_investigation(object sender, EventArgs e)
        {
            this.Hide();
            Investigation C182 = new Investigation();
            C182.Show();
        }

        private void btn_assesment(object sender, EventArgs e)
        {
            this.Hide();
            Assesment C182 = new Assesment();
            C182.Show();
        }

        private void btn_diagnosis(object sender, EventArgs e)
        {
            this.Hide();
            diagnosisdoc C183 = new diagnosisdoc();
            C183.Show();
        }

        private void btn_x_ray(object sender, EventArgs e)
        {
            this.Hide();
            X_Ray C184 = new X_Ray();
            C184.Show();
        }

        private void btn_doctor_prescription(object sender, EventArgs e)
        {
            this.Hide();
            Doctor_Prescription C185 = new Doctor_Prescription();
            C185.Show();
        }

        private void btn_app(object sender, EventArgs e)
        {
            this.Hide();
            App C186 = new App();
            C186.Show();
        }
    }
}

