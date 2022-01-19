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
    public partial class Records : Form
    {
        public Records()
        {
            InitializeComponent();
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {
            display();
        }
        private void display()
        {
            string id = Guid.NewGuid().ToString();
            try
            {
                List<Patient> patients = PatientFactory.GetAllPatients();
                foreach (Patient pat in patients)
                {
                    PatientUserControl control = new PatientUserControl(pat);
                    RecordDisplayer.Controls.Add(control);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No patients are in the system.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Records_Load(object sender, EventArgs e)
        {

        }

        private void panel46_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_calender(object sender, EventArgs e)
        {
            //this.Hide();
            //OrthopedicUnit_Calender C215 = new OrthopedicUnit_Calender();
            //C215.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void btn_finance(object sender, EventArgs e)
        {
            //this.Hide();
            //Finance C216 = new Finance();
            //C216.Show();
        }

        private void btn_adminsettings(object sender, EventArgs e)
        {
            //this.Hide();
            //AdminSettings C217 = new AdminSettings();
            //C217.Show();
        }

        private void btn_AddPatient_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Add_Patient C218 = new Add_Patient();
            //C218.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrthopedicUnit_Calender C215 = new OrthopedicUnit_Calender();
            C215.Show();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Finance C216 = new Finance();
            C216.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminSettings C217 = new AdminSettings();
            C217.Show();
        }

        private void btn_AddPatient_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Add_Patient C218 = new Add_Patient();
            C218.Show();
        }


    }
}