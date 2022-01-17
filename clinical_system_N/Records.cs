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

        private void btn_calender(object sender, EventArgs e)
        {
            this.Hide();
            OrthopedicUnit_Calender C173 = new OrthopedicUnit_Calender();
            C173.Show();
        }

        private void btn_finance(object sender, EventArgs e)
        {
            this.Hide();
            Finance C174 = new Finance();
            C174.Show();
        }

        private void btn_adminsettings(object sender, EventArgs e)
        {
            this.Hide();
            AdminSettings C175 = new AdminSettings();
            C175.Show();
        }

        private void btn_AddPatient_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Patient C176 = new Add_Patient();
            C176.Show();
        }
    }
}
