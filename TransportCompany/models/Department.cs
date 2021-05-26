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

        public Department(string departmentName, string companyName)
        {
            DepartmentName = departmentName;
            CompanyName = companyName;
        }

        public string DepartmentName { get => _departmentName; set => _departmentName = value; }
        public string CompanyName { get => _companyName; set => _companyName = value; }
    }
}
