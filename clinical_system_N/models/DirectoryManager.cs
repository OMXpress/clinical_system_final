using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinical_system_N.models
{
    internal static class DirectoryManager
    {

        private readonly static string dir = GlobalManager.PathToPatients;

        public static bool ReadyPatient(string id)
        {
            string patientID = id;
            string path = Path.Combine(dir, patientID);

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                List<string> DataPaths = new List<string>();
                string dataPath = Path.Combine(path, "Data");
                string investigationPath = Path.Combine(path, "Investigations");
                DataPaths.Add(Path.Combine(dataPath, "MetaData.json"));
                DataPaths.Add(Path.Combine(dataPath, "Prescriptions.json"));
                DataPaths.Add(Path.Combine(dataPath, "History.json"));
                DataPaths.Add(Path.Combine(dataPath, "Visits.json"));
                string XrayPath = Path.Combine(investigationPath, "Xray");
                string MRIPath = Path.Combine(investigationPath, "MRI");
                Directory.CreateDirectory(XrayPath);
                Directory.CreateDirectory(MRIPath);
                Directory.CreateDirectory(dataPath);

                foreach (string p in DataPaths)
                {
                    using (FileStream fs = File.Create(p))
                    {

                    }
                }

                
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void InitializeApp()
        {
            string path = GlobalManager.PathToAppData;
            List<string> folders = new List<string>();
            folders.Add("Doctors");
            folders.Add("Clinics");
            folders.Add("Appointments");
            List<string> files = new List<string>();
            files.Add("Doctors.json");
            files.Add("Clinics.json");
            files.Add("Appointments.json");
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);

                for (int i = 0; i < folders.Count; i++)
                {
                    string f = Path.Combine(path, folders[i]);
                    Directory.CreateDirectory(f);
                    string file = Path.Combine(f, files[i]);
                    using (FileStream fs = File.Create(file))
                    {

                    }
                }   
            }
        }
    }
}
