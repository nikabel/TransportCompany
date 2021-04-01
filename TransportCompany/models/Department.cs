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
        private string _departmentDesc;
        private string _companyName;

        public Department() { }
        public Department(string departmentName, string departmentDesc, string companyName)
        {
            CompanyName = companyName;
            DepartmentName = departmentName;
            DepartmentDesc = departmentDesc;
        }

        public string DepartmentName
        {
            get { return _departmentName; }
            set { _departmentName = value; }
        }

        public string DepartmentDesc
        {
            get { return _departmentDesc; }
            set { _departmentDesc = value; }
        }

        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }
    }
}
