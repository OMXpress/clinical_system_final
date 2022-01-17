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
    public partial class prescription : Form
    {
        public prescription()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_calender(object sender, EventArgs e)
        {
            this.Hide();
            OrthopedicUnit_Calender C166 = new OrthopedicUnit_Calender();
            C166.Show();
        }

        private void btn_records(object sender, EventArgs e)
        {
            this.Hide();
            Records C167 = new Records();
            C167.Show();
        }

        private void btn_finance(object sender, EventArgs e)
        {
            this.Hide();
            Finance C168 = new Finance();
            C168.Show();
        }

        private void btn_adminsettings(object sender, EventArgs e)
        {
            this.Hide();
            AdminSettings C169 = new AdminSettings();
            C169.Show();
        }

        private void btn_general(object sender, EventArgs e)
        {
            this.Hide();
            //General C170 = new General();
            //C170.Show();
        }

        private void btn_history(object sender, EventArgs e)
        {
            this.Hide();
            History C171 = new History();
            C171.Show();
        }

        private void btn_active(object sender, EventArgs e)
        {
            this.Hide();
            Active C172 = new Active();
            C172.Show();
        }

        private void btn_prescription(object sender, EventArgs e)
        {
            this.Hide();
            prescription C173 = new prescription();
            C173.Show();
        }
    }
}
