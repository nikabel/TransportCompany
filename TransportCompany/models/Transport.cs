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

        public Transport( string licensePlate, string driverName, string modelName)
        {
            ModelName = modelName;
            DriverName = driverName;
            LicensePlate = licensePlate;
        }

        public string ModelName { get => _modelName; set => _modelName = value; }
        public string DriverName { get => _driverName; set => _driverName = value; }
        public string LicensePlate { get => _licensePlate; set => _licensePlate = value; }
    }
}
