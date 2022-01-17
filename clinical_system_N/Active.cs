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
    public partial class Active : Form
    {
        public Active()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_physio_calender(object sender, EventArgs e)
        {
            this.Hide();
            Physiotherape_Calender C70 = new Physiotherape_Calender();
            C70.Show();
        }

        private void btn_records(object sender, EventArgs e)
        {
            this.Hide();
            Records C71 = new Records();
            C71.Show();
        }

        private void btn_finance(object sender, EventArgs e)
        {
            this.Hide();
            Finance C72 = new Finance();
            C72.Show();
        }

        private void btn_adminsettings(object sender, EventArgs e)
        {
            this.Hide();
            AdminSettings C73 = new AdminSettings();
            C73.Show();
        }

        private void btn_general(object sender, EventArgs e)
        {
            this.Hide();
            General C74 = new General();
            C74.Show();
        }

        private void btn_history(object sender, EventArgs e)
        {
            this.Hide();
            History C75 = new History();
            C75.Show();
        }

        private void btn_prescription(object sender, EventArgs e)
        {
            this.Hide();
            prescription C76 = new prescription();
            C76.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}
