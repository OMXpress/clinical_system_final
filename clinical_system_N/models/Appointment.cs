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
        public PhysioAppointment _physioAppointment;
        public DateTime dateofAppointment;
        public string Id;
        public ClinicType ClinicType;
        public bool open = true;

        public Appointment() { }
        public Appointment(Patient patient, Doctor doctor, ClinicType clinic, OrthoAppointment appointment, DateTime dateofAppointment)
        {
            _patient = patient;
            _doctor = doctor;
            DateCreated = DateTime.Now;
            Id = Guid.NewGuid().ToString();
            ClinicType = clinic;
            _orthoAppointment = appointment;
            this.dateofAppointment = dateofAppointment;
        }
        public Appointment(Patient patient, Doctor doctor, ClinicType clinic, PhysioAppointment appointment, DateTime dateofAppointment)
        {
            _patient = patient;
            _doctor = doctor;
            DateCreated = DateTime.Now;
            Id = Guid.NewGuid().ToString();
            ClinicType = clinic;
            _physioAppointment = appointment;
            this.dateofAppointment = dateofAppointment;
        }

        public void CloseAppointment()
        {
            open = false;
        }

    }
}
