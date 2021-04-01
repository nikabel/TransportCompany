using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany.models
{
    public class Employee
    {
        private string _employeeName;
        private string _employeePos;
        private string _employeeTel;
        private string _employeeAddress;
        private string _departmentName;

        public Employee() { }
        public Employee(string employeeName, string departmentName, string employeePos, string employeeTel, string employeeAddress)
        {
            EmployeeName = employeeName;
            DepartmentName = departmentName;
            EmployeePos = employeePos;
            EmployeeTel = employeeTel;
            EmployeeAddress = employeeAddress;
        }

        public string EmployeeName
        {
            get { return _employeeName; }
            set { _employeeName = value; }
        }

        public string EmployeePos
        {
            get { return _employeePos; }
            set { _employeePos = value; }
        }

        public string EmployeeTel
        {
            get { return _employeeTel; }
            set { _employeeTel = value; }
        }

        public string EmployeeAddress
        {
            get { return _employeeAddress; }
            set { _employeeAddress = value; }
        }

        public string DepartmentName
        {
            get { return _departmentName; }
            set { _departmentName = value; }
        }
    }
}
