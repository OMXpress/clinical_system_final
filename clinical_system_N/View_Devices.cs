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
    public partial class View_Devices : Form
    {
        public View_Devices()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_calender(object sender, EventArgs e)
        {
            this.Hide();
            Physiotherape_Calender C187 = new Physiotherape_Calender();
            C187.Show();
        }

        private void btn_records(object sender, EventArgs e)
        {
            this.Hide();
            Records C188 = new Records();
            C188.Show();
        }

        private void btn_finance(object sender, EventArgs e)
        {
            this.Hide();
            Finance C189 = new Finance();
            C189.Show();
        }

        private void btn_adminsettings(object sender, EventArgs e)
        {
            this.Hide();
            AdminSettings C190 = new AdminSettings();
            C190.Show();
        }

        private void btn_investigation(object sender, EventArgs e)
        {
            this.Hide();
            Investigation C191 = new Investigation();
            C191.Show();
        }

        private void btn_assesment(object sender, EventArgs e)
        {
            this.Hide();
            Assesment C192 = new Assesment();
            C192.Show();
        }

        private void btn_physio(object sender, EventArgs e)
        {
            this.Hide();
            Physiotherapy C193 = new Physiotherapy();
            C193.Show();
        }

        private void btn_services(object sender, EventArgs e)
        {
            this.Hide();
            Services C194 = new Services();
            C194.Show();
        }

        private void btn_x_ray(object sender, EventArgs e)
        {
            this.Hide();
            X_Ray C195 = new X_Ray();
            C195.Show();
        }

        private void btn_doctor_prescription(object sender, EventArgs e)
        {
            this.Hide();
            Doctor_Prescription C196 = new Doctor_Prescription();
            C196.Show();
        }

        private void btn_app(object sender, EventArgs e)
        {
            this.Hide();
            App C197 = new App();
            C197.Show();
        }
    }
}
