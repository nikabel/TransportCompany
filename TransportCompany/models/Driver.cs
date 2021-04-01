using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany.models
{
    public class Driver : Employee
    {
        private int _drivingExperience;
        private string _licenseCategory;

        public Driver(string employeeName, string departmentName, string employeePos, string employeeTel, string employeeAddress, int drivingExperience, string licenseCategory)
            : base(employeeName, departmentName, employeePos, employeeTel, employeeAddress)
        {
            LicenseCategory = licenseCategory;
            DrivingExperience = drivingExperience;
        }

        public int DrivingExperience { get => _drivingExperience; set => _drivingExperience = value; }
        public string LicenseCategory { get => _licenseCategory; set => _licenseCategory = value; }
    }
}
