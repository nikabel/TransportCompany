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
        private string _signDate;
        private int _freightSum;
        private string _isInsured;
        private string _deliveryDate;

        public Application(string applicationNum, string contractNum, string customerName, string signDate, int freightSum, string isInsured, string deliveryDate)
        {
            ApplicationNum = applicationNum;
            ContractNum = contractNum;
            CustomerName = customerName;
            SignDate = signDate;
            FreightSum = freightSum;
            IsInsured = isInsured;
            DeliveryDate = deliveryDate;
        }

        public string ApplicationNum { get => _applicationNum; set => _applicationNum = value; }
        public string ContractNum { get => _contractNum; set => _contractNum = value; }
        public string CustomerName { get => _customerName; set => _customerName = value; }
        public string SignDate { get => _signDate; set => _signDate = value; }
        public int FreightSum { get => _freightSum; set => _freightSum = value; }
        public string IsInsured { get => _isInsured; set => _isInsured = value; }
        public string DeliveryDate { get => _deliveryDate; set => _deliveryDate = value; }
    }
}
