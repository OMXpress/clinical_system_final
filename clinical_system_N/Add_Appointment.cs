using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using clinical_system_N.models;

namespace clinical_system_N
{
    internal partial class AddAppointment : Form
    {
        Patient patient;
        public AddAppointment()
        {
            InitializeComponent();

        }

        private bool isValid_name(string inp)
        {
            Regex check = new Regex(@"^([A-Z][a-z-A-z]+)$");
            bool valid = check.IsMatch(inp);
            return valid;

        }

        private bool Validation()
        {

            return true;
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button6_MouseClick(object sender, MouseEventArgs e)
        {



        }

        private void btn_calender(object sender, EventArgs e)
        {
            this.Hide();
            Physiotherape_Calender C22 = new Physiotherape_Calender();
            C22.Show();


        }

        private void btn_confirm(object sender, EventArgs e)
        {
            bool validation = Validation();
            //if all inputs are true proceed to database
            if (validation)
            {
                Doctor doctor = GlobalManager.OrthoClinic.attending;
                DaysOfWeeks day = ((DaysOfWeeks)(int)dateTimePicker1.Value.DayOfWeek);
                string time = comboBox2.Text;
                OrthoAppointment app = OrthoAppointment.a9;
                if (time == "9:00" || time == "9:30")
                {
                    app = OrthoAppointment.a9;
                }
                if (time == "10:00" || time == "10:30")
                {
                    app = OrthoAppointment.a10;
                }
                if (time == "11:00" || time == "11:30")
                {
                    app = OrthoAppointment.a11;
                }
                if (time == "12:00" || time == "12:30")
                {
                    app = OrthoAppointment.a12;
                }
                if (time == "1:00" || time == "1:30")
                {
                    app = OrthoAppointment.a1;
                }
                if (time == "3:00" || time == "3:30")
                {
                    app = OrthoAppointment.a3;
                }
                if (time == "4:00" || time == "4:30")
                {
                    app = OrthoAppointment.a4;
                }


                Appointment appointment = new Appointment(patient, doctor, ClinicType.ortho, app, dateTimePicker1.Value);
                GlobalManager.AddOrthoAppointment(appointment);

                this.Hide();
                OrthopedicUnit_Calender C21 = new OrthopedicUnit_Calender();
                C21.Show();
            }
        }

        private void btn_AddPatient_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Patient C16 = new Add_Patient();
            C16.Show();
        }

        private void btn_records(object sender, EventArgs e)
        {
            this.Hide();
            Records C18 = new Records();
            C18.Show();

        }

        private void AddAppointment_Load(object sender, EventArgs e)
        {

        }

       // private void button7_Click(object sender, EventArgs e)
        //{
          //  this.Hide();
           // OrthopedicUnit C17 = new OrthopedicUnit();
            //C17.Show();
        //}

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void btn_finance(object sender, EventArgs e)
        {
            this.Hide();
            Finance C19 = new Finance();
            C19.Show();
        }

        private void btn_adminsettings(object sender, EventArgs e)
        {
            this.Hide();
            AdminSettings C20 = new AdminSettings();
            C20.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private bool Date_time = false;
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                string nid = NationalID.Text.Trim();
                List < Patient >  ls = PatientFactory.GetAllPatients();
                foreach (Patient pat in ls)
                {
                    if (pat.info.NationalID == nid)
                    {
                        patient = pat;
                        patientID.Text = pat.info.PatientId;                        
                        string name = pat.info.PatientName;
                        string fname = name.Split(' ')[0];
                        string lname = name.Split(' ')[1];
                        lblfname.Text = fname;
                        last.Text = lname;
                        break;
                    }
                }
            }
            catch (Exception)
            {
                
            }
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            Date_time = true;
        }
    }
}
