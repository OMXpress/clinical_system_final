using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinical_system_N.models
{
    internal static class GlobalManager
    {
        public static string PathToPatients = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "PatientData");
        public static Clinic OrthoClinic;
        public static Clinic PhysioClinic;
        private static bool OrthoInitialized = false;
        private static bool PhysioInitialized = false;
        public static string PathToAppData = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ClinicalSystem");
        private static List<Appointment> appointments = new List<Appointment>();

        public static string ClinicToText(ClinicType clinicType)
        {
            if (clinicType == ClinicType.physio)
            {
                string text = "Physio";
                return text;
            }
            else if (clinicType == ClinicType.ortho)
            {
                string text = "Ortho";
                return text;
            }
            return string.Empty;
        }
        public static string GenderToText(Gender gender)
        {
            if (gender == Gender.male)
            {
                string text = "Male";
                return text;
            }
            else if (gender == Gender.female)
            {
                string text = "Female";
                return text;
            }
            return string.Empty;
        }
        public static string AppointmentTypeToText(AppointmentType AppointmentType)
        {
            if (AppointmentType == AppointmentType.Checkup)
            {
                string text = "Checkup";
                return text;
            }
            else if (AppointmentType == AppointmentType.Consultation)
            {
                string text = "Consultation";
                return text;
            }
            return string.Empty;
        }
        public static Dictionary<string, int> OrthoAppointmentToText(OrthoAppointment OrthoAppointment)
        {
            Dictionary<string, int> XX = new Dictionary<string, int>();

            if (OrthoAppointment == OrthoAppointment.a8)
            {
                XX.Add("Hour", 8);
                XX.Add("Mins", 0);
            }
            else if (OrthoAppointment == OrthoAppointment.a830)
            {
                XX.Add("Hour", 8);
                XX.Add("Mins", 30);
            }
            else if (OrthoAppointment == OrthoAppointment.a9)
            {
                XX.Add("Hour", 9);
                XX.Add("Mins", 0);
            }
            else if (OrthoAppointment == OrthoAppointment.a930)
            {
                XX.Add("Hour", 9);
                XX.Add("Mins", 30); 
            }
            else if (OrthoAppointment == OrthoAppointment.a10)
            {
                XX.Add("Hour", 10);
                XX.Add("Mins", 0);
            }
            else if (OrthoAppointment == OrthoAppointment.a1030)
            {
                XX.Add("Hour", 10);
                XX.Add("Mins", 30);
            }
            else if (OrthoAppointment == OrthoAppointment.a11)
            {
                XX.Add("Hour", 11);
                XX.Add("Mins", 0);
            }
            else if (OrthoAppointment == OrthoAppointment.a1130)
            {
                XX.Add("Hour", 11);
                XX.Add("Mins", 30);
            }
            else if (OrthoAppointment == OrthoAppointment.a12)
            {
                XX.Add("Hour", 12);
                XX.Add("Mins", 0);
            }
            else if (OrthoAppointment == OrthoAppointment.a1230)
            {
                XX.Add("Hour", 12);
                XX.Add("Mins", 30);
            }
            else if (OrthoAppointment == OrthoAppointment.a1)
            {
                XX.Add("Hour", 1);
                XX.Add("Mins", 0);
            }
            else if (OrthoAppointment == OrthoAppointment.a130)
            {
                XX.Add("Hour", 1);
                XX.Add("Mins", 30);
            }
            else if (OrthoAppointment == OrthoAppointment.a3)
            {
                XX.Add("Hour", 3);
                XX.Add("Mins", 0);
            }
            else if (OrthoAppointment == OrthoAppointment.a330)
            {
                XX.Add("Hour", 3);
                XX.Add("Mins", 30);
            }
            else if (OrthoAppointment == OrthoAppointment.a4)
            {
                XX.Add("Hour", 4);
                XX.Add("Mins", 0);
            }
            else if (OrthoAppointment == OrthoAppointment.a430)
            {
                XX.Add("Hour", 4);
                XX.Add("Mins", 30);
            }
            return XX;
        }
        public static void InitializeOrtho(Clinic clinic)
        {
            if (!OrthoInitialized)
            {
                OrthoClinic = clinic;
                OrthoInitialized = true;
            }
            
        }
        public static void InitializePhysio(Clinic clinic)
        {
            if (!PhysioInitialized)
            {
                PhysioInitialized = true;
                PhysioClinic = clinic;
            }
        }


    }
}
