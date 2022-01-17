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
    public partial class Physio_Devices : Form
    {
        public Physio_Devices()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Physio_Devices_Load(object sender, EventArgs e)
        {

        }

        private void btn_calender(object sender, EventArgs e)
        {
            this.Hide();
            OrthopedicUnit_Calender C141 = new OrthopedicUnit_Calender();
            C141.Show();
        }

        private void btn_records(object sender, EventArgs e)
        {
            this.Hide();
            Records C142 = new Records();
            C142.Show();
        }

        private void btn_finance(object sender, EventArgs e)
        {
            this.Hide();
            Finance C143 = new Finance();
            C143.Show();
        }

        private void btn_adminsettings(object sender, EventArgs e)
        {
            this.Hide();
            AdminSettings C144 = new AdminSettings();
            C144.Show();
        }

        private void btn_investigation(object sender, EventArgs e)
        {
            this.Hide();
            Investigation C145 = new Investigation();
            C145.Show();
        }

        private void btn_assesment(object sender, EventArgs e)
        {
            this.Hide();
            Assesment C146 = new Assesment();
            C146.Show();
        }

        private void btn_physio(object sender, EventArgs e)
        {
            this.Hide();
            Physio C147 = new Physio();
            C147.Show();
        }

        private void btn_servises(object sender, EventArgs e)
        {
            this.Hide();
            Services C148 = new Services();
            C148.Show();
        }

        private void btn_x_ray(object sender, EventArgs e)
        {
            this.Hide();
            X_Ray C149 = new X_Ray();
            C149.Show();
        }

        private void btn_doctor_prescription(object sender, EventArgs e)
        {
            this.Hide();
            Doctor_Prescription C150 = new Doctor_Prescription();
            C150.Show();
        }

        private void btn_app(object sender, EventArgs e)
        {
            this.Hide();
            App C151 = new App();
            C151.Show();
        }
    }
}
