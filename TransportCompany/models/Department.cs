using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany.models
{
    public class Department
    {
        private string _departmentName;
        private string _companyName;

        public Department() { }
        public Department(string departmentName, string companyName)
        {
            CompanyName = companyName;
            DepartmentName = departmentName;
        }

        public string DepartmentName
        {
            get { return _departmentName; }
            set { _departmentName = value; }
        }

        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }
    }
}
