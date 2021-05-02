using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany.models
{
    public class CargoType
    {
        private string _cargoTypeName;

        public CargoType(string cargoTypeName)
        {
            CargoTypeName = cargoTypeName;
        }

        public string CargoTypeName { get => _cargoTypeName; set => _cargoTypeName = value; }
    }
}
