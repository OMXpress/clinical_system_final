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
    public partial class Physio : Form
    {
        public Physio()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btn_devices(object sender, EventArgs e)
        {
            this.Hide();
            View_Devices C162 = new View_Devices();
            C162.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_calender(object sender, EventArgs e)
        {
            this.Hide();
            Physiotherape_Calender C152 = new Physiotherape_Calender();
            C152.Show();
        }

        private void btn_records(object sender, EventArgs e)
        {
            this.Hide();
            Records C153 = new Records();
            C153.Show();
        }

        private void btn_finance(object sender, EventArgs e)
        {
            this.Hide();
            Finance C154 = new Finance();
            C154.Show();
        }

        private void btn_adminsettings(object sender, EventArgs e)
        {
            this.Hide();
            AdminSettings C155 = new AdminSettings();
            C155.Show();
        }

        private void btn_investigation(object sender, EventArgs e)
        {
            this.Hide();
            Investigation C156 = new Investigation();
            C156.Show();
        }

        private void btn_assesment(object sender, EventArgs e)
        {
            this.Hide();
            Assesment C157 = new Assesment();
            C157.Show();
        }

        private void btn_services(object sender, EventArgs e)
        {
            this.Hide();
            Services C158 = new Services();
            C158.Show();
        }

        private void btn_x_ray(object sender, EventArgs e)
        {
            this.Hide();
            X_Ray C159 = new X_Ray();
            C159.Show();
        }

        private void btn_doctor_prescription(object sender, EventArgs e)
        {
            this.Hide();
            Doctor_Prescription C160 = new Doctor_Prescription();
            C160.Show();
        }

        private void btn_app(object sender, EventArgs e)
        {
            this.Hide();
            App C161 = new App();
            C161.Show();
        }

        private void btn_program(object sender, EventArgs e)
        {
            this.Hide();
            View_Program C163 = new View_Program();
            C163.Show();
        }
    }
}
