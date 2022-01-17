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
    public partial class Physiotherape_Calender : Form
    {
        public Physiotherape_Calender()
        {
            InitializeComponent();
        }

        private void Calendar_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel46_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_ortho_calender(object sender, EventArgs e)
        {
            this.Hide();
            OrthopedicUnit_Calender C3 = new OrthopedicUnit_Calender();
            C3.Show();
        }

        private void btn_records(object sender, EventArgs e)
        {
            this.Hide();
            Records C7 = new Records();
            C7.Show();
        }

        private void btn_finance(object sender, EventArgs e)
        {
            this.Hide();
            Finance C8 = new Finance();
            C8.Show();
        }

        private void btn_adminsettings(object sender, EventArgs e)
        {
            this.Hide();
            AdminSettings C9 = new AdminSettings();
            C9.Show();
        }

        private void btn_AddApp_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddAppointment C10 = new AddAppointment();
            C10.Show();
        }

        private void btn_physio(object sender, EventArgs e)
        {
            this.Hide();
            Physiotherapy C66 = new Physiotherapy();
            C66.Show();
        }

        private void fl_AppContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
