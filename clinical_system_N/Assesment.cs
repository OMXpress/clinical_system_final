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
    public partial class Assesment : Form
    {
        public Assesment()
        {
            InitializeComponent();
        }

        private void btn_calender(object sender, EventArgs e)
        {
            this.Hide();
            OrthopedicUnit_Calender C90 = new OrthopedicUnit_Calender();
            C90.Show();
        }

        private void btn_records(object sender, EventArgs e)
        {
            this.Hide();
            Records C91 = new Records();
            C91.Show();
        }

        private void btn_finance(object sender, EventArgs e)
        {
            this.Hide();
            Finance C92 = new Finance();
            C92.Show();
        }

        private void btn_adminsettings(object sender, EventArgs e)
        {
            this.Hide();
            AdminSettings C93 = new AdminSettings();
            C93.Show();
        }

        private void btn_investigation(object sender, EventArgs e)
        {
            this.Hide();
            Investigation C94 = new Investigation();
            C94.Show();
        }

        private void btn_diagnosis(object sender, EventArgs e)
        {
            this.Hide();
            diagnosisdoc C95 = new diagnosisdoc();
            C95.Show();
        }

        private void btn_services(object sender, EventArgs e)
        {
            this.Hide();
            Services C96 = new Services();
            C96.Show();
        }

        private void btn_x_ray(object sender, EventArgs e)
        {
            this.Hide();
            X_Ray C97 = new X_Ray();
            C97.Show();
        }

        private void btn_prescription(object sender, EventArgs e)
        {
            this.Hide();
            Doctor_Prescription C98 = new Doctor_Prescription();
            C98.Show();
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void btn_app(object sender, EventArgs e)
        {
            this.Hide();
            App C111 = new App();
            C111.Show();
        }
    }
}
