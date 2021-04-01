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
        private DateTime _signDate;
        private DateTime _expirationDate;
        private string _customerName;
        private string _companyName;
        private string _applicationNum;

        public Contract(string contractNum, DateTime signDate, DateTime expirationDate, string customerName, string companyName, string applicationNum)
        {
            ContractNum = contractNum;
            SignDate = signDate;
            ExpirationDate = expirationDate;
            CustomerName = customerName;
            CompanyName = companyName;
            ApplicationNum = applicationNum;
        }

        public string ContractNum { get => _contractNum; set => _contractNum = value; }
        public DateTime SignDate { get => _signDate; set => _signDate = value; }
        public DateTime ExpirationDate { get => _expirationDate; set => _expirationDate = value; }
        public string CustomerName { get => _customerName; set => _customerName = value; }
        public string CompanyName { get => _companyName; set => _companyName = value; }
        public string ApplicationNum { get => _applicationNum; set => _applicationNum = value; }
    }
}
