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
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btn_calender(object sender, EventArgs e)
        {
            this.Hide();
            OrthopedicUnit_Calender C85 = new OrthopedicUnit_Calender();
            C85.Show();
        }

        private void btn_records(object sender, EventArgs e)
        {
            this.Hide();
            Records C86 = new Records();
            C86.Show();
        }

        private void btn_finance(object sender, EventArgs e)
        {
            this.Hide();
            Finance C87 = new Finance();
            C87.Show();
        }

        private void btn_adminsettings(object sender, EventArgs e)
        {
            this.Hide();
            AdminSettings C88 = new AdminSettings();
            C88.Show();
        }

        private void btn_AddAppointment(object sender, EventArgs e)
        {
            this.Hide();
            AddAppointment C89 = new AddAppointment();
            C89.Show();
        }

        private void App_Load(object sender, EventArgs e)
        {

        }

        private void btn_investigation(object sender, EventArgs e)
        {
            this.Hide();
            Investigation C216 = new Investigation();
            C216.Show();
        }

        private void btn_assesment(object sender, EventArgs e)
        {
            this.Hide();
            Assesment C217 = new Assesment();
            C217.Show();
        }

        private void btn_diagnosis(object sender, EventArgs e)
        {
            this.Hide();
            diagnosisdoc C218 = new diagnosisdoc();
            C218.Show();
        }

        private void btn_services(object sender, EventArgs e)
        {
            this.Hide();
            Services C219 = new Services();
            C219.Show();
        }

        private void btn_x_ray(object sender, EventArgs e)
        {
            this.Hide();
            X_Ray C220 = new X_Ray();
            C220.Show();
        }

        private void btn_prescription(object sender, EventArgs e)
        {
            this.Hide();
            prescription C221 = new prescription();
            C221.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}
