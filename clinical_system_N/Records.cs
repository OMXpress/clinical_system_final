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
            List<Patient> patients = PatientFactory.GetAllPatients();
            foreach (Patient pat in patients)
            {
                PatientUserControl control = new PatientUserControl(pat);
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

        private void panel46_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
