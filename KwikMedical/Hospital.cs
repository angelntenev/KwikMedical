using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KwikMedical
{
    internal class Hospital
    { 
        public string tagName;
        public string location;
        public bool full = false;

        public string getTagName()
        {
            return tagName;
        }

        public void setTagName(string name)
        {
            tagName = name;
        }

        public string getlocation()
        {
            return location;
        }

        public void setlocation(string loc)
        {
            location = loc;
        }

        public bool getFull()
        {
            return full;
        }

        public void setFullnessTrue()
        {
            full = true;
        }

        public void setFullnessFalse()
        {
            full = false;
        }
    }
}
