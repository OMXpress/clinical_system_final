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
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_calender(object sender, EventArgs e)
        {
            this.Hide();
            OrthopedicUnit_Calender C121 = new OrthopedicUnit_Calender();
            C121.Show();
        }

        private void btn_records(object sender, EventArgs e)
        {
            this.Hide();
            Records C122 = new Records();
            C122.Show();
        }

        private void btn_finance(object sender, EventArgs e)
        {
            this.Hide();
            Finance C123 = new Finance();
            C123.Show();
        }

        private void btn_adminsettings(object sender, EventArgs e)
        {
            this.Hide();
            AdminSettings C124 = new AdminSettings();
            C124.Show();
        }

        private void btn_general(object sender, EventArgs e)
        {
            this.Hide();
            //General C125 = new General();
            //C125.Show();
        }

        private void btn_active(object sender, EventArgs e)
        {
            this.Hide();
            Active C126 = new Active();
            C126.Show();
        }

        private void btn_prescription(object sender, EventArgs e)
        {
            this.Hide();
            prescription C127 = new prescription();
            C127.Show();
        }
    }
}
