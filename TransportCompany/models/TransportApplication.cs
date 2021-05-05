using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany.models
{
    public class TransportApplication
    {
        private string _licensePlate;
        private string _applicationNum;

        public TransportApplication(string licensePlate, string applicationNum)
        {
            LicensePlate = licensePlate;
            ApplicationNum = applicationNum;
        }

        public string LicensePlate { get => _licensePlate; set => _licensePlate = value; }
        public string ApplicationNum { get => _applicationNum; set => _applicationNum = value; }
    }
}
