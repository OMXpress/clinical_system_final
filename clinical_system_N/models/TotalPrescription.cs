using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinical_system_N.models
{
    internal class TotalPrescription
    {
        //prescribed medicine
        public PerscribedMedicine mInfo;
        public PerscribedService sInfo;
        public Perscription pInfo;

        public TotalPrescription(PerscribedMedicine information)
        {
            mInfo = information;
        }
        public TotalPrescription(PerscribedService information)
        {
            sInfo = information;
        }
        public TotalPrescription(Perscription information)
        {
            pInfo = information;
        }
    }
}
