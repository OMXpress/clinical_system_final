using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinical_system_N.models
{
    internal static class AppointmentManager
    {

        public static Appointment CreateAppointment(Patient patient, Doctor doctor, ClinicType clinic, OrthoAppointment orthoAppointment)
        {
            Appointment appointment = new Appointment(patient, doctor, clinic, orthoAppointment);
            return appointment;

        }


    }
}
