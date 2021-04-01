using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany.models
{
    public class WorkCertificate
    {
        private string _certificateNum;
        private DateTime _signDate;
        private int _servicesCost;
        private string _contractNum;

        public WorkCertificate(string certificateNum, DateTime signDate, int servicesCost, string contractNum)
        {
            CertificateNum = certificateNum;
            SignDate = signDate;
            ServicesCost = servicesCost;
            ContractNum = contractNum;
        }

        public string CertificateNum { get => _certificateNum; set => _certificateNum = value; }
        public DateTime SignDate { get => _signDate; set => _signDate = value; }
        public int ServicesCost { get => _servicesCost; set => _servicesCost = value; }
        public string ContractNum { get => _contractNum; set => _contractNum = value; }
    }
}
