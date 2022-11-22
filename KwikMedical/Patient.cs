using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KwikMedical
{
    internal class Patient
    {
        public string patientName1;

        public string GetpatientName()
        {
            return patientName1;
        }

        public void SetpatientName(string value)
        {
            patientName1 = value;
        }

        public string patientNHSnumb1;

        public string GetpatientNHSnumb()
        {
            return patientNHSnumb1;
        }

        public void SetpatientNHSnumb(string value)
        {
            patientNHSnumb1 = value;
        }

        public string patientAddress1;

        public string GetpatientAddress()
        {
            return patientAddress1;
        }

        public void SetpatientAddress(string value)
        {
            patientAddress1 = value;
        }

        public string patientCondition;

        public string getPatientCondition()
        {
            return patientCondition;
        }

        public void setPatientCondition(string newCondition)
        {
            patientCondition = newCondition;
        }


    }
}
