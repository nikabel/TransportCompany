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
        private string _serviceDate;
        private string _certificateNum;
        private string _contractNum;

        public Service(string serviceName, string employeeName, int serviceCost, string serviceDate, string certificateNum, string contractNum)
        {
            ServiceName = serviceName;
            EmployeeName = employeeName;
            ServiceCost = serviceCost;
            ServiceDate = serviceDate;
            CertificateNum = certificateNum;
            ContractNum = contractNum;
        }

        public string ServiceName { get => _serviceName; set => _serviceName = value; }
        public string EmployeeName { get => _employeeName; set => _employeeName = value; }
        public int ServiceCost { get => _serviceCost; set => _serviceCost = value; }
        public string ServiceDate { get => _serviceDate; set => _serviceDate = value; }
        public string CertificateNum { get => _certificateNum; set => _certificateNum = value; }
        public string ContractNum { get => _contractNum; set => _contractNum = value; }
    }
}
