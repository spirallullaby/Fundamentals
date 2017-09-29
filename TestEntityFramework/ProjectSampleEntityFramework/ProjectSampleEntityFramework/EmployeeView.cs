using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSampleEntityFramework
{
    class EmployeeView
    {
        private EMPLOYEE employee;
        public EmployeeView(EMPLOYEE emp)
        {
            employee = emp;
        }
        public string FirstName
        {
            get
            {
                return employee.FIRSTNAME;
            }
            set
            {
                employee.FIRSTNAME = value;
            }
        }
        public string LastName
        {
            get
            {
                return employee.LASTNAME;
            }
            set
            {
                employee.LASTNAME = value;
            }
        }
        public string OCCUPATION
        {
            get
            {
                return employee.OCCUPATION.OCCUPATION_NAME;
            }
        }
    }
}
