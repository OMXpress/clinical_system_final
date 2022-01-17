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
    public partial class General : Form
    {
        public General()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_calender(object sender, EventArgs e)
        {
            this.Hide();
            OrthopedicUnit_Calender C114 = new OrthopedicUnit_Calender();
            C114.Show();
        }

        private void btn_records(object sender, EventArgs e)
        {
            this.Hide();
            Records C115 = new Records();
            C115.Show();
        }

        private void btn_finance(object sender, EventArgs e)
        {
            this.Hide();
            Finance C116 = new Finance();
            C116.Show();
        }

        private void btn_adminsettings(object sender, EventArgs e)
        {
            this.Hide();
            AdminSettings C117 = new AdminSettings();
            C117.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_history(object sender, EventArgs e)
        {
            this.Hide();
            History C118 = new History();
            C118.Show();
        }

        private void btn_active(object sender, EventArgs e)
        {
            this.Hide();
            Active C119 = new Active();
            C119.Show();
        }

        private void btn_prescription(object sender, EventArgs e)
        {
            this.Hide();
            prescription C120 = new prescription();
            C120.Show();
        }
    }
}
