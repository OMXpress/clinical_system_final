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
        public static List<Appointment> OrthoAppointments = new List<Appointment>();

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

            if (OrthoAppointment == OrthoAppointment.a9)
            {
                XX.Add("Hour", 9);
                XX.Add("Mins", 0);
            }

            else if (OrthoAppointment == OrthoAppointment.a10)
            {
                XX.Add("Hour", 10);
                XX.Add("Mins", 0);
            }

            else if (OrthoAppointment == OrthoAppointment.a11)
            {
                XX.Add("Hour", 11);
                XX.Add("Mins", 0);
            }

            else if (OrthoAppointment == OrthoAppointment.a12)
            {
                XX.Add("Hour", 12);
                XX.Add("Mins", 0);
            }

            else if (OrthoAppointment == OrthoAppointment.a1)
            {
                XX.Add("Hour", 1);
                XX.Add("Mins", 0);
            }

            else if (OrthoAppointment == OrthoAppointment.a3)
            {
                XX.Add("Hour", 3);
                XX.Add("Mins", 0);
            }

            else if (OrthoAppointment == OrthoAppointment.a4)
            {
                XX.Add("Hour", 4);
                XX.Add("Mins", 0);
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
        public static void AddAppointment(Appointment appointment)
        {
            OrthoAppointments.Add(appointment);
            JsonManager jsonManager = new JsonManager();
            jsonManager.SaveAppointments(OrthoAppointments);
        }
        public static void InitializeAll()
        {
            DirectoryManager.InitializeApp();
            JsonManager jsonManager = new JsonManager();
            OrthoAppointments = jsonManager.LoadOpenAppointments();
            Patient p = PatientFactory.CreatePatient("Omar", "Khale", "tezoo", "201068037112", "Male", "yarab@muslim.com", "01068037112", "Segada", "Single", "Student");
            Doctor d = new Doctor();
            d.Name = "Omar";
            d.Id = "wjhbfewkj";
            d.clinic = ClinicType.ortho;
            d.Email = "jskddsj@hdsch.com";
            d.Password = "sdfnadkc";
            Appointment appointment = new Appointment(p, d, ClinicType.ortho, OrthoAppointment.a9, DateTime.Now);
            OrthoAppointments.Add(appointment);
            Patient p2 = PatientFactory.CreatePatient("Oma", "Khale", "tezoo", "201068037112", "Male", "yarab@muslim.com", "01068037112", "Segada", "Single", "Student");
            Doctor d2 = new Doctor();
            d2.Name = "Oma";
            d2.Id = "wjhbfewkj";
            d2.clinic = ClinicType.ortho;
            d2.Email = "jskddsj@hdsch.com";
            d2.Password = "sdfnadkc";
            Appointment appointment2 = new Appointment(p2, d2, ClinicType.ortho, OrthoAppointment.a1, DateTime.Now);
            OrthoAppointments.Add(appointment2);
        }
        public static List<Appointment> GetOrthoAppAt(DaysOfWeeks day, OrthoAppointment time) 
        {
            List<Appointment> all = new List<Appointment>();
            foreach (Appointment appointment in OrthoAppointments)
            {
                int dayofweek = (int)appointment.dateofAppointment.DayOfWeek;
                if (appointment._orthoAppointment == time && dayofweek == ((int)day))
                {
                    all.Add(appointment);
                }
            }
            return all;
        
        
        }
    }
}
