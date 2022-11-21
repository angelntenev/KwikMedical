using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KwikMedical
{
    internal class MedicalEmployee
    {
        public string employeePswd { get; set; }
        public string employeeLogin { get; set; }
        public string employeeName { get; set; }

        public string getEmployeeLogin()
        {
            return employeeLogin;
        }

        public string getEmployeeName()
        {
            return employeeName;
        }

        public string getEmployeePswd()
        {
            return employeePswd;
        }

        public void setEmployeeLogin(string login)
        {
            employeeLogin = login;
        }

        public void setEmployeePswd(string password)
        {
            employeePswd = PasswordHasher.hashPassword(password);
        }

        public void setEmployeeName(string name)
        {
            employeeName = name;
        }
    }
}
