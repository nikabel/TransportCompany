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
        private string _signDate;
        private string _contractNum;

        public WorkCertificate(string certificateNum, string signDate, string contractNum)
        {
            CertificateNum = certificateNum;
            SignDate = signDate;
            ContractNum = contractNum;
        }

        public string CertificateNum { get => _certificateNum; set => _certificateNum = value; }
        public string SignDate { get => _signDate; set => _signDate = value; }
        public string ContractNum { get => _contractNum; set => _contractNum = value; }
    }
}
