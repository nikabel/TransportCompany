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
        private string _contractNum;
        private string _customerName;
        private string _licensePlate;
        private DateTime _signDate;
        private int _freightSum;
        private string _isInsured;
        private DateTime _deliveryDate;

        public Application(string applicationNum, string contractNum, string customerName, string licensePlate, DateTime signDate, int freightSum, string isInsured, DateTime deliveryDate)
        {
            ApplicationNum = applicationNum;
            ContractNum = contractNum;
            CustomerName = customerName;
            LicensePlate = licensePlate;
            SignDate = signDate;
            FreightSum = freightSum;
            IsInsured = isInsured;
            DeliveryDate = deliveryDate;
        }

        public string ApplicationNum { get => _applicationNum; set => _applicationNum = value; }
        public string ContractNum { get => _contractNum; set => _contractNum = value; }
        public string CustomerName { get => _customerName; set => _customerName = value; }
        public string LicensePlate { get => _licensePlate; set => _licensePlate = value; }
        public DateTime SignDate { get => _signDate; set => _signDate = value; }
        public int FreightSum { get => _freightSum; set => _freightSum = value; }
        public string IsInsured { get => _isInsured; set => _isInsured = value; }
        public DateTime DeliveryDate { get => _deliveryDate; set => _deliveryDate = value; }
    }
}
