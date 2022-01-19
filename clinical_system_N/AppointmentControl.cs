using clinical_system_N.models;
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
    internal partial class AppointmentControl : UserControl
    {
        private Appointment appointment;
        public AppointmentControl()
        {
            InitializeComponent();
        }
        public AppointmentControl(Appointment app)
        {
            appointment = app;
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void open_btn_Click(object sender, EventArgs e)
        {
            OrthopedicUnit orthopedicUnit = new OrthopedicUnit(appointment._patient);
            orthopedicUnit.Show();
            this.Hide();
        }

        private void start_t_label_Click(object sender, EventArgs e)
        {

        }

        private void AppointmentControl_Load(object sender, EventArgs e)
        {
            if (appointment != null)
            {
                name_label.Text = appointment._patient.info.PatientName;
                phone_label.Text = appointment._patient.info.Phone;
                start_t_label.Text = appointment.dateofAppointment.TimeOfDay.ToString();
                type.Text = "Check Up";
            }

        }

        private void medical_record_btn_Click(object sender, EventArgs e)
        {
            General general = new General(appointment._patient);
            general.Show();
            this.Hide();
        }
    }
}
