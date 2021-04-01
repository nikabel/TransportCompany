using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany.models
{
    public class CertificateService
    {
        private string _certificateNum;
        private string _serviceName;
        private int _serviceCount;
        private int _serviceCost;

        public CertificateService(string certificateNum, string serviceName, int serviceCount, int serviceCost)
        {
            CertificateNum = certificateNum;
            ServiceName = serviceName;
            ServiceCount = serviceCount;
            ServiceCost = serviceCost;
        }

        public string CertificateNum { get => _certificateNum; set => _certificateNum = value; }
        public string ServiceName { get => _serviceName; set => _serviceName = value; }
        public int ServiceCount { get => _serviceCount; set => _serviceCount = value; }
        public int ServiceCost { get => _serviceCost; set => _serviceCost = value; }
    }
}
