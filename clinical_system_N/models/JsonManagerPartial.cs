using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinical_system_N.models
{
    internal partial class JsonManager
    {
        public List<string> GetHistory(string patientID)
        {
            var list = new List<string>();
            string x = LoadJson(JsonType.History, patientID);

            list = JsonConvert.DeserializeObject<List<string>>(x);
            return list;

        }
    }
}
