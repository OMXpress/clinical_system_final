using clinical_system_N.models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinical_system_N
{
    public partial class Add_Doctor : Form
    {
        public Add_Doctor()
        {
            InitializeComponent();
        }

        private bool isValid_name(string inp)
        {
            Regex check = new Regex(@"^?([a-zA-Z])$");
            bool valid = check.IsMatch(inp);
            //Console.WriteLine(valid);
            return valid;

        }

        private bool Validation()
        {
            //First Name Validation
            return true;
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_doctor_Load(object sender, EventArgs e)
        {

        }

        private void btn_save(object sender, EventArgs e)
        {
            bool validation = Validation();
            //if all inputs are true proceed to database
            if (validation)
            {
                try
                {
                    var x = Guid.NewGuid().ToString();
                    DBController db = new DBController();
                    string q = string.Format("INSERT INTO EMPLOYEE VALUES('{0}', '{1}', {2}, '{3}', '{4}','Doctor', '{5}', '{6}')",
                        firstName.Text, lastName.Text, salary.Text, password.Text, email.Text, x, phoneNumber.Text);
                    if (db.OpenConnection())
                    {
                        MySqlCommand cmd = new MySqlCommand(q, db.connection);
                        cmd.ExecuteNonQuery();
                        db.CloseConnection();
                    }
                    q = string.Format("INSERT INTO DOCTOR VALUES('{0}', '{1}', '{2}', '{3}')",
                       licsenceNumber.Text, x, specialization.Text, address.Text);
                    if (db.OpenConnection())
                    {
                        MySqlCommand cmd = new MySqlCommand(q, db.connection);
                        cmd.ExecuteNonQuery();
                        db.CloseConnection();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                this.Hide();
                AdminSettings C27 = new AdminSettings();
                C27.Show();
            }
        }

        private void Calender_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrthopedicUnit_Calender C28 = new OrthopedicUnit_Calender();
            C28.Show();

        }

        private void btn_records(object sender, EventArgs e)
        {
            this.Hide();
            Records C29 = new Records();
            C29.Show();
        }

        private void btn_finance(object sender, EventArgs e)
        {
            this.Hide();
            Finance C30 = new Finance();
            C30.Show();
        }

        private void Admin_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private bool Date_time = false;
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Date_time = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
