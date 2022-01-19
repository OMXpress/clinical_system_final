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
    internal partial class History : Form
    {
        Patient patient;
        public History()
        {
            InitializeComponent();
        }
        public History(Patient patient )
        {
            this.patient = patient;
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            JsonManager jsonManager = new JsonManager();    
            var ls = jsonManager.GetHistory(patient.info.PatientId);
            if (ls != null)
            {
                richTextBox2.Text = ls[0];
                richTextBox1.Text = ls[1];
            }


        }

        private void btn_calender(object sender, EventArgs e)
        {
            this.Hide();
            OrthopedicUnit_Calender C121 = new OrthopedicUnit_Calender();
            C121.Show();
        }

        private void btn_records(object sender, EventArgs e)
        {
            this.Hide();
            Records C122 = new Records();
            C122.Show();
        }

        private void btn_finance(object sender, EventArgs e)
        {
            this.Hide();
            Finance C123 = new Finance();
            C123.Show();
        }

        private void btn_adminsettings(object sender, EventArgs e)
        {
            this.Hide();
            AdminSettings C124 = new AdminSettings();
            C124.Show();
        }

        private void btn_general(object sender, EventArgs e)
        {
            this.Hide();
            //General C125 = new General();
            //C125.Show();
        }

        private void btn_active(object sender, EventArgs e)
        {
            this.Hide();
            Active C126 = new Active();
            C126.Show();
        }

        private void btn_prescription(object sender, EventArgs e)
        {
            this.Hide();
            prescription C127 = new prescription();
            C127.Show();
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            List<string> dic = new List<string>();

            dic.Add( richTextBox2.Text);
            dic.Add(richTextBox1.Text);
            JsonManager JsonManager = new JsonManager();
            JsonManager.AddJson(JsonType.History, patient.info.PatientId, dic);

        }
    }
}
