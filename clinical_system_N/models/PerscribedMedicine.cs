using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinical_system_N.models
{
    internal class PerscribedMedicine
    {
        public string MedicineName { get; set; }
        public string Duration { get; set; }
        public string Dose { get; set; }
        public string How { get; set; }
        public string ActiveIngredient { get; set; }

        public PerscribedMedicine(string medicineName, string duration, string dose, string how, string activeIngredient)
        {
            MedicineName = medicineName;
            Duration = duration;
            Dose = dose;
            How = how;
            ActiveIngredient = activeIngredient;
        }
    }
}
