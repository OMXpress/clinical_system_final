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
    internal partial class PatientUserControl : UserControl
    {
        private Patient _patient;
        public PatientUserControl(Patient patient)
        {
            InitializeComponent();
            _patient = patient;
        }

        private void PatientUserControl_Load(object sender, EventArgs e)
        {
            lblPatientID.Text = _patient.info.PatientId;
            lblPatientName.Text = _patient.info.PatientName;
            lblPhoneNumber.Text = _patient.info.Phone;
        }

        private void BtnOpenRecord_Click(object sender, EventArgs e)
        {
            General open = new General(_patient);
            this.Parent.Parent.Hide();
            open.Show();

        }

        private void lblPatientName_Click(object sender, EventArgs e)
        {

        }
    }
}
