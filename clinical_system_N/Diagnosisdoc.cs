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
    internal partial class diagnosisdoc : Form
    {
        Patient patient;
        public diagnosisdoc()
        {
            InitializeComponent();
        }
        public diagnosisdoc(Patient patient)
        {
            InitializeComponent();
            this.patient = patient;
        }

        private void btn_investigation(object sender, EventArgs e)
        {
            this.Hide();
            Investigation C81 = new Investigation();
            C81.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void OrthopedicUnit_Load(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_assesment(object sender, EventArgs e)
        {
            this.Hide();
            Assesment C82 = new Assesment();
            C82.Show();
        }

        private void btn_services(object sender, EventArgs e)
        {
            this.Hide();
            Services C83 = new Services();
            C83.Show();
        }

        private void btn_x_ray(object sender, EventArgs e)
        {
            this.Hide();
            X_Ray C84 = new X_Ray();
            C84.Show();
        }

        private void btn_doctor_prescription(object sender, EventArgs e)
        {
            this.Hide();
            Doctor_Prescription C85 = new Doctor_Prescription();
            C85.Show();
        }

        private void btn_app(object sender, EventArgs e)
        {
            this.Hide();
            App C99 = new App();
            C99.Show();
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_calender(object sender, EventArgs e)
        {
            this.Hide();
            OrthopedicUnit_Calender C77 = new OrthopedicUnit_Calender();
            C77.Show();
        }

        private void btn_records(object sender, EventArgs e)
        {
            this.Hide();
            Records C78 = new Records();
            C78.Show();
        }

        private void btn_finance(object sender, EventArgs e)
        {
            this.Hide();
            Finance C79 = new Finance();
            C79.Show();
        }

        private void btn_adminsettings(object sender, EventArgs e)
        {
            this.Hide();
            AdminSettings C80 = new AdminSettings();
            C80.Show();
        }

        private void richTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click_1(object sender, EventArgs e)
        {

        }

        private void diagnosis_TextChanged(object sender, EventArgs e)
        {
 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int Index = 0;
            diagnosis.SelectAll();
            diagnosis.SelectionBackColor = Color.White;
            List<string> list = diagnosis.Text.Split(' ').ToList<string>();
            var x = GlobalManager.allowed;
            var y = new List<string>();
            foreach (var item in list)
            {
                if (!x.Contains(item))
                {
                    y.Add(item);
                }
            }
            foreach (var item in y)
            {
                diagnosis.Find(item, Index, diagnosis.TextLength, RichTextBoxFinds.MatchCase);
                diagnosis.SelectionBackColor = Color.Red;
                Index = diagnosis.Text.IndexOf(item, Index) + 1;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int Index = 0;
            diagnosis.SelectAll();
            diagnosis.SelectionBackColor = Color.White;
            List<string> list = diagnosis.Text.Split(' ').ToList<string>();
            var x = GlobalManager.allowed;
            var y = new List<string>();
            foreach (var item in list)
            {
                if (!x.Contains(item))
                {
                    y.Add(item);
                }
            }
            foreach (var item in y)
            {
                diagnosis.Find(item, Index, diagnosis.TextLength, RichTextBoxFinds.MatchCase);
                diagnosis.SelectedText = "";
                Index = diagnosis.Text.IndexOf(item, Index) + 1;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            JsonManager jsonManager = new JsonManager();
            var ls = jsonManager.GetHistory(patient.info.PatientId);
            List<string> list = new List<string>();
            list = diagnosis.Text.Split(',').ToList<string>();
            foreach (var i in list)
            {
                string comps = Environment.NewLine + DateTime.Now.ToString() + Environment.NewLine + "Diagnosis: " + i + Environment.NewLine;
                ls.Add(comps);
            }

            JsonManager JsonManager = new JsonManager();
            JsonManager.AddJson(JsonType.History, patient.info.PatientId, ls);
        }
    }
}
