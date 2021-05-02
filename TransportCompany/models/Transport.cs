using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany.models
{
    public class Transport
    {
        private string _modelName;
        private string _driverName;
        private string _licensePlate;
        private string _occupation;

        public Transport(string modelName, string driverName, string licensePlate, string occupation)
        {
            ModelName = modelName;
            DriverName = driverName;
            LicensePlate = licensePlate;
            Occupation = occupation;
        }

        public string ModelName { get => _modelName; set => _modelName = value; }
        public string DriverName { get => _driverName; set => _driverName = value; }
        public string LicensePlate { get => _licensePlate; set => _licensePlate = value; }
        public string Occupation { get => _occupation; set => _occupation = value; }
    }
}
