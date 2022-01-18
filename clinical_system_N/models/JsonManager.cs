﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace clinical_system_N.models
{
    internal class JsonManager
    {
        public string json;


        private string LoadJson(JsonType enumType, string patientID)
        {
            string DataPath = Path.Combine(Path.Combine(GlobalManager.PathToPatients, patientID), "Data");
            if (enumType == JsonType.History)
            {
                using (StreamReader r = new StreamReader(Path.Combine(DataPath, "History.json"))) 
                {
                    json = r.ReadToEnd();
                }
            }
            if (enumType == JsonType.MetaData)
            {
                using (StreamReader r = new StreamReader(Path.Combine(DataPath, "MetaData.json")))
                {
                    json = r.ReadToEnd();
                }
            }
            if (enumType == JsonType.Prescriptions)
            {
                using (StreamReader r = new StreamReader(Path.Combine(DataPath, "Prescriptions.json")))
                {
                    json = r.ReadToEnd();
                }
            }
            if (enumType == JsonType.Visits)
            {
                using (StreamReader r = new StreamReader(Path.Combine(DataPath, "Visits.json")))
                {
                    json = r.ReadToEnd();
                }
            }
            return json;
            
        }

        public Dictionary<string, JToken> deserializeToDictionary(JsonType jsonType, string patientID)
        {
            string jo = LoadJson(jsonType, patientID);
            var values = JsonConvert.DeserializeObject<Dictionary<string, JToken>>(jo);
            return values;
        }

        public void AddJson<T>(JsonType enumType, string patientID, List<T> toJson)
        {
            string DataPath = Path.Combine(Path.Combine(GlobalManager.PathToPatients, patientID), "Data");
            if (enumType == JsonType.History)
            {     
                string output = Newtonsoft.Json.JsonConvert.SerializeObject(toJson);
                File.WriteAllText(Path.Combine(DataPath, "History.json"), output);
            }
            if (enumType == JsonType.MetaData)
            {
                string output = Newtonsoft.Json.JsonConvert.SerializeObject(toJson);
                File.WriteAllText(Path.Combine(DataPath, "MetaData.json"), output);
            }
            if (enumType == JsonType.Prescriptions)
            {
                string output = Newtonsoft.Json.JsonConvert.SerializeObject(toJson);
                File.WriteAllText(Path.Combine(DataPath, "Prescriptions.json"), output);
            }
            if (enumType == JsonType.Visits)
            {
                string output = Newtonsoft.Json.JsonConvert.SerializeObject(toJson);
                File.WriteAllText(Path.Combine(DataPath, "Visits.json"), output);
            }

        }
        public void AddMetaData(string patientID, PatientInformation toJson)
        {
            string DataPath = Path.Combine(Path.Combine(GlobalManager.PathToPatients, patientID), "Data");
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(toJson);
            string PathFile = Path.Combine(DataPath, "MetaData.json");

            using (StreamWriter sw = new StreamWriter(PathFile))
            {
                sw.WriteLine(output);
            }
        }
        public List<PatientInformation> GetAllInfo()
        {

            var paths = Directory.GetDirectories(GlobalManager.PathToPatients);
            var result = new List<PatientInformation>();
            foreach (var path in paths)
            {;
                var json = LoadJson(JsonType.MetaData, path);
                var x = JsonConvert.DeserializeObject<PatientInformation>(json);
                result.Add(x);

            }
            return result;
        }


    }
}
