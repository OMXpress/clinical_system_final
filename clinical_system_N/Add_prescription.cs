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
    internal partial class Add_prescription : Form
    {
        public Patient patient;

        public Add_prescription(Patient p)
        {
            InitializeComponent();
            patient = p;
        }
        public Add_prescription()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Doctor_Prescription C230 = new Doctor_Prescription();
            C230.Show();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            string medName = textBox1.Text.ToString();
            string activeSubstance = textBox2.Text.ToString();
            string use = textBox3.Text.ToString();
            string Duration = textBox4.Text.ToString();
            // addPresJson
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_prescription_Load(object sender, EventArgs e)
        {

        }
    }
}
