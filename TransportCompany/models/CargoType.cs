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
        private string _cargoTypeDesc;

        public CargoType(string cargoTypeName, string cargoTypeDesc)
        {
            CargoTypeName = cargoTypeName;
            CargoTypeDesc = cargoTypeDesc;
        }

        public string CargoTypeName { get => _cargoTypeName; set => _cargoTypeName = value; }
        public string CargoTypeDesc { get => _cargoTypeDesc; set => _cargoTypeDesc = value; }
    }
}
