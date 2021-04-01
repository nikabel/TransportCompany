using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany.models
{
    public class Application
    {
        private string _applicationNum;
        private string _customerName;
        private string _licensePlate;
        private string _cargoNum;
        private DateTime _signDate;
        private int _freightSum;
        private int _driversCount;
        private int _transportsCount;
        private int _cargoCount;
        private bool _isInsured;
        private DateTime _deliveryDate;

        public Application(string applicationNum, string customerName, string licensePlate, string cargoNum,
            DateTime signDate, int freightSum, int driversCount, int transportsCount, int cargoCount, bool isInsured, DateTime deliveryDate)
        {
            ApplicationNum = applicationNum;
            CustomerName = customerName;
            LicensePlate = licensePlate;
            CargoNum = cargoNum;
            SignDate = signDate;
            FreightSum = freightSum;
            DriversCount = driversCount;
            TransportsCount = transportsCount;
            CargoCount = cargoCount;
            IsInsured = isInsured;
            DeliveryDate = deliveryDate;
        }

        public string ApplicationNum { get => _applicationNum; set => _applicationNum = value; }
        public string CustomerName { get => _customerName; set => _customerName = value; }
        public string LicensePlate { get => _licensePlate; set => _licensePlate = value; }
        public string CargoNum { get => _cargoNum; set => _cargoNum = value; }
        public DateTime SignDate { get => _signDate; set => _signDate = value; }
        public int FreightSum { get => _freightSum; set => _freightSum = value; }
        public int DriversCount { get => _driversCount; set => _driversCount = value; }
        public int TransportsCount { get => _transportsCount; set => _transportsCount = value; }
        public int CargoCount { get => _cargoCount; set => _cargoCount = value; }
        public bool IsInsured { get => _isInsured; set => _isInsured = value; }
        public DateTime DeliveryDate { get => _deliveryDate; set => _deliveryDate = value; }
    }
}
