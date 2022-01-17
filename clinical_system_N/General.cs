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
    internal partial class General : Form
    {
        public Patient Patient { get; set; }
        public General(Patient patient)
        {
            Patient = patient;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblAdress.Text = Patient.info.Address;
            lblAdress.ReadOnly = true;
            lblDOB.Text = Patient.info.DoB;
            lblDOB.ReadOnly = true;
            lblEmail.Text = Patient.info.Email;
            lblEmail.ReadOnly = true;
            lblGender.Text = GlobalVariables.GenderToText(Patient.info.Gender);
            lblGender.ReadOnly = true;
            lblNationalID.Text = Patient.info.NationalID;
            lblNationalID.ReadOnly = true;
            lblPhone.Text = Patient.info.Phone;
            lblPhone.ReadOnly = true;
            lblPID.Text = Patient.info.PatientId;
            lblPID.ReadOnly = true;
            Profession.Text = Patient.info.Proffession;
            Profession.ReadOnly = true;
            string x = Patient.info.PatientName;
            string fname = x.Split(' ')[0];
            string lname = x.Split(' ')[1];
            lblFirstName.Text = fname;
            lblLastName.Text = lname;
            lblFirstName.ReadOnly = true;
            lblLastName.ReadOnly = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
