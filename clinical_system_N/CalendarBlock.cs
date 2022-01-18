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
    internal partial class CalendarBlock : UserControl
    {
        List<Patient> patients = new List<Patient>();
        public CalendarBlock()
        {
            InitializeComponent();
            Ready();

        }

        private void CalendarBlock_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Ready()
        {
            lblPatient1.Text = String.Empty;
            lblPatient2.Text = String.Empty;   
        }
        public bool AddPatient(Patient patient)
        {
            if (patients.Count == 2)
            {
                return false;
            }
            patients.Add(patient);
            if (patients.Count == 1)
            {
                lblPatient1.Text = patient.info.PatientName;
            }
            else
            {
                lblPatient2.Text = patient.info.PatientName;
            }
            return true;
        }

    }
}
