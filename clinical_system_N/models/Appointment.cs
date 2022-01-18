using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinical_system_N.models
{
    internal class Appointment
    {
        public Patient _patient;
        public Doctor _doctor;
        public DateTime DateCreated;
        public OrthoAppointment _orthoAppointment;
        public string Id;
        public ClinicType ClinicType;
        public bool open = true;

        public Appointment(Patient patient, Doctor doctor, ClinicType clinic, OrthoAppointment appointment)
        {
            _patient = patient;
            _doctor = doctor;
            DateCreated = DateTime.Now;
            Id = Guid.NewGuid().ToString();
            ClinicType = clinic;
            _orthoAppointment = appointment;
        }
        public void CloseAppointment()
        {
            open = false;
        }

    }
}
