using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany.models
{
    public class Contract
    {
        private string _contractNum;
        private string _signDate;
        private string _expirationDate;
        private string _customerName;
        private string _companyName;

        public Contract(string contractNum, string signDate, string expirationDate, string customerName, string companyName)
        {
            ContractNum = contractNum;
            SignDate = signDate;
            ExpirationDate = expirationDate;
            CustomerName = customerName;
            CompanyName = companyName;
        }

        public string ContractNum { get => _contractNum; set => _contractNum = value; }
        public string SignDate { get => _signDate; set => _signDate = value; }
        public string ExpirationDate { get => _expirationDate; set => _expirationDate = value; }
        public string CustomerName { get => _customerName; set => _customerName = value; }
        public string CompanyName { get => _companyName; set => _companyName = value; }
    }
}
