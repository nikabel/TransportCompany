using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany.models
{
    public class BankDetails
    {
        private string _acc;
        private string _companyName;
        private string _customerName;
        private string _inn;
        private string _rcbic;
        private string _ogrn;
        private string _corrAcc;

        public BankDetails(string acc, string companyName, string customerName, string inn, string rcbic, string ogrn, string corrAcc)
        {
            Acc = acc;
            CompanyName = companyName;
            CustomerName = customerName;
            Inn = inn;
            Rcbic = rcbic;
            Ogrn = ogrn;
            CorrAcc = corrAcc;
        }

        public string Acc { get => _acc; set => _acc = value; }
        public string CompanyName { get => _companyName; set => _companyName = value; }
        public string CustomerName { get => _customerName; set => _customerName = value; }
        public string Inn { get => _inn; set => _inn = value; }
        public string Rcbic { get => _rcbic; set => _rcbic = value; }
        public string Ogrn { get => _ogrn; set => _ogrn = value; }
        public string CorrAcc { get => _corrAcc; set => _corrAcc = value; }
    }
}
