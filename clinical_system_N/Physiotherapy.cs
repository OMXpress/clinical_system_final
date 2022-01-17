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
    public partial class Physiotherapy : Form
    {
        public Physiotherapy()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_investigations(object sender, EventArgs e)
        {
            this.Hide();
            Investigation C160 = new Investigation();
            C160.Show();
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_calender(object sender, EventArgs e)
        {
            this.Hide();
            Physiotherape_Calender C60 = new Physiotherape_Calender();
            C60.Show();
        }

        private void btn_records(object sender, EventArgs e)
        {
            this.Hide();
            Records C61 = new Records();
            C61.Show();
        }

        private void btn_finance(object sender, EventArgs e)
        {
            this.Hide();
            Finance C62 = new Finance();
            C62.Show();
        }

        private void btn_adminsettings(object sender, EventArgs e)
        {
            this.Hide();
            AdminSettings C63 = new AdminSettings();
            C63.Show();
        }

        private void btn_assesment(object sender, EventArgs e)
        {
            this.Hide();
            Assesment C161 = new Assesment();
            C161.Show();
        }

        private void btn_physio(object sender, EventArgs e)
        {
            this.Hide();
            Physio C162 = new Physio();
            C162.Show();
        }

        private void btn_services(object sender, EventArgs e)
        {
            this.Hide();
            Services C163 = new Services();
            C163.Show();
        }

        private void btn_x_ray(object sender, EventArgs e)
        {
            this.Hide();
            X_Ray C164 = new X_Ray();
            C164.Show();
        }

        private void btn_doctor_prescription(object sender, EventArgs e)
        {
            this.Hide();
            Doctor_Prescription C165 = new Doctor_Prescription();
            C165.Show();
        }

        private void btn_app(object sender, EventArgs e)
        {
            this.Hide();
            App C165 = new App();
            C165.Show();
        }
    }
}
