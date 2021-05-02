﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany.models
{
    public class Cargo
    {
        private string _cargoNum;
        private string _applicationNum;
        private string _cargoName;
        private string _cargoTypeName;
        private string _cargoWeight;
        private int _cargoVolume;
        private int _cargoCost;

        public Cargo(string cargoNum, string applicationNum, string cargoName, string cargoTypeName, string cargoWeight, int cargoVolume, int cargoCost)
        {
            CargoNum = cargoNum;
            ApplicationNum = applicationNum;
            CargoName = cargoName;
            CargoTypeName = cargoTypeName;
            CargoWeight = cargoWeight;
            CargoVolume = cargoVolume;
            CargoCost = cargoCost;
        }

        public string CargoNum { get => _cargoNum; set => _cargoNum = value; }
        public string ApplicationNum { get => _applicationNum; set => _applicationNum = value; }
        public string CargoName { get => _cargoName; set => _cargoName = value; }
        public string CargoTypeName { get => _cargoTypeName; set => _cargoTypeName = value; }
        public string CargoWeight { get => _cargoWeight; set => _cargoWeight = value; }
        public int CargoVolume { get => _cargoVolume; set => _cargoVolume = value; }
        public int CargoCost { get => _cargoCost; set => _cargoCost = value; }
    }
}
