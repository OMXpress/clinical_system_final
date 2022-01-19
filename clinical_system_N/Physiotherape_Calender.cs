using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clinical_system_N.models;


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
            var apps = GlobalManager.PhysioAppointments;
            int timeCounter = 0;
            int dayCounter = 0;
            for (int i = 0; i < 15; i++)
            {

                dayCounter = (dayCounter + 1) % 6;
                if (dayCounter == 1)
                {
                    timeCounter++;
                }
                DaysOfWeeks day = DaysOfWeeks.Monday;
                PhysioAppointment ment = PhysioAppointment.a3;
                if (timeCounter == 1)
                {
                    ment = PhysioAppointment.a9;
                }
                if (timeCounter == 2)
                {
                    ment = PhysioAppointment.a10;
                }
                if (timeCounter == 3)
                {
                    ment = PhysioAppointment.a11;
                }
                if (timeCounter == 4)
                {
                    ment = PhysioAppointment.a12;
                }
                if (timeCounter == 5)
                {
                    ment = PhysioAppointment.a1;
                }
                if (timeCounter == 6)
                {
                    ment = PhysioAppointment.a3;
                }
                if (timeCounter == 7)
                {
                    ment = PhysioAppointment.a4;
                }

                if (dayCounter == 1)
                {
                    day = DaysOfWeeks.Sunday;
                }
                if (dayCounter == 2)
                {
                    day = DaysOfWeeks.Monday;
                }
                if (dayCounter == 3)
                {
                    day = DaysOfWeeks.Tuesday;
                }
                if (dayCounter == 4)
                {
                    day = DaysOfWeeks.Wednesday;
                }
                if (dayCounter == 5)
                {
                    day = DaysOfWeeks.Thursday;
                }
                if (dayCounter == 6)
                {
                    day = DaysOfWeeks.Saturday;
                }



                var ls = GlobalManager.GetPhysioAppAt(day, ment);
                Physio_Calender physioBlock = new Physio_Calender();
                if (ls.Count > 0)
                {
                    foreach (var item in ls)
                    {
                        Console.WriteLine(item._patient);
                        physioBlock.AddPatient(item._patient);
                    }
                }
                fl_AppContainer.Controls.Add(physioBlock);

            }




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
