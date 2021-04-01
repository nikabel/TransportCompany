using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany.models
{
    public class TransportCompany
    {
        private string _companyName;
        private string _managerName;
        private string _companyAddress;
        private string _companyBussinessAddress;
        private string _companyTel;

        public TransportCompany(string companyName, string managerName, string companyAddress, string companyBussinessAddress, string companyTel)
        {
            CompanyName = companyName;
            ManagerName = managerName;
            CompanyAddress = companyAddress;
            CompanyBussinessAddress = companyBussinessAddress;
            CompanyTel = companyTel;
        }

        public string CompanyName { get => _companyName; set => _companyName = value; }
        public string ManagerName { get => _managerName; set => _managerName = value; }
        public string CompanyAddress { get => _companyAddress; set => _companyAddress = value; }
        public string CompanyBussinessAddress { get => _companyBussinessAddress; set => _companyBussinessAddress = value; }
        public string CompanyTel { get => _companyTel; set => _companyTel = value; }
    }
}
