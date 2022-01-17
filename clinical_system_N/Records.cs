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
            PatientInformation info = new PatientInformation("sfsfdr564", "Omar", "1999", "123144562", Gender.male, "dafjadj@desk.com", "01068037112", "7oby", MaritialStatus.Single, "Student");
            Patient patientTest = new Patient(info);
            for (int i = 0; i < 5 ; i++)
            {
                PatientUserControl control = new PatientUserControl(patientTest);
                RecordDisplayer.Controls.Add(control);
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
    }
}
