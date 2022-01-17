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
    public partial class UserControlDays5 : UserControl
    {
        private object connString;
        public static String static_day;
        public UserControlDays5()
        {
            InitializeComponent();
        }

        private void UserControlDays5_Load(object sender, EventArgs e)
        {

        }
        public void days(int numday)
        {
            lbdays.Text = numday + "";
        }

        internal void days()
        {
            throw new NotImplementedException();
        }

        private void UserControlDays5_Click(object sender, EventArgs e)
        {
            static_day = lbdays.Text;
            timer1.Start();
            Form2 Form2 = new Form2();
            Form2.Show();
        }
        private void displayEvent()
        {
            mySqlconnection conn = new mySqlconnection(connString);
            conn.open();
            string sql = "select* from tbl_calendar where date = ? ";
            MySqlcommand cmd = conn.createCommand();
            cmd.CommandText = sql;
            //cmd.parameters.AddwithValue("data", OrthopedicUnit_Calender.static_month + "/" +lbdays.Text);
            MySqlDateaReader reader = cmd.ExecteReader();
            if (reader.Read())
            {
                // lbevent.Text = reader["event"].Tostring();
            }
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            displayEvent();
        }
    }
}
