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
    public partial class View_Program : Form
    {
        public View_Program()
        {
            InitializeComponent();
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_calender(object sender, EventArgs e)
        {
            this.Hide();
            Physiotherape_Calender C197 = new Physiotherape_Calender();
            C197.Show();
        }

        private void btn_records(object sender, EventArgs e)
        {
            this.Hide();
            Records C198 = new Records();
            C198.Show();
        }

        private void btn_finance(object sender, EventArgs e)
        {
            this.Hide();
            Finance C199 = new Finance();
            C199.Show();
        }

        private void btn_adminsettings(object sender, EventArgs e)
        {
            this.Hide();
            AdminSettings C200 = new AdminSettings();
            C200.Show();
        }

        private void btn_investigation(object sender, EventArgs e)
        {
            this.Hide();
            Investigation C201 = new Investigation();
            C201.Show();
        }

        private void btn_assesment(object sender, EventArgs e)
        {
            this.Hide();
            Assesment C202 = new Assesment();
            C202.Show();
        }

        private void btn_physiotherapy(object sender, EventArgs e)
        {
            this.Hide();
            Physiotherapy C203 = new Physiotherapy();
            C203.Show();
        }

        private void btn_services(object sender, EventArgs e)
        {
            this.Hide();
            Services C204 = new Services();
            C204.Show();
        }

        private void btn_x_ray(object sender, EventArgs e)
        {
            this.Hide();
            X_Ray C205 = new X_Ray();
            C205.Show();
        }

        private void btn_doctor_prescription(object sender, EventArgs e)
        {
            this.Hide();
            Doctor_Prescription C206 = new Doctor_Prescription();
            C206.Show();
        }

        private void btn_app(object sender, EventArgs e)
        {
            this.Hide();
            App C207 = new App();
            C207.Show();
        }
    }
}
