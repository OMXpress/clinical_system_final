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
    public partial class CalendarBlock : UserControl
    {
        public CalendarBlock()
        {
            InitializeComponent();
            Ready();
        }

        private void CalendarBlock_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Ready()
        {
            lblPatient1.Text = String.Empty;
            lblPatient2.Text = String.Empty;   
        }

    }
}
