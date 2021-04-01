using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany.models
{
    public class OfficeEmployee : Employee
    {
        private string _specName;

        public OfficeEmployee(string employeeName, string departmentName, string employeePos, string employeeTel, string employeeAddress, string specName) 
            : base (employeeName, departmentName, employeePos, employeeTel, employeeAddress)
        {
            SpecName = specName;
        }

        public string SpecName { get => _specName; set => _specName = value; }
    }
}
