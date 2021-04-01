using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany.models
{
    public class Service
    {
        private string _serviceName;
        private string _employeeName;
        private int _serviceCost;
        private string _certificateNum;

        public Service(string serviceName, string employeeName, int serviceCost, string certificateNum)
        {
            ServiceName = serviceName;
            EmployeeName = employeeName;
            ServiceCost = serviceCost;
            CertificateNum = certificateNum;
        }

        public string ServiceName { get => _serviceName; set => _serviceName = value; }
        public string EmployeeName { get => _employeeName; set => _employeeName = value; }
        public int ServiceCost { get => _serviceCost; set => _serviceCost = value; }
        public string CertificateNum { get => _certificateNum; set => _certificateNum = value; }
    }
}
