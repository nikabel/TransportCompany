using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportCompany.models;

namespace TransportCompany.DAO
{
    public class WorkCertificateDAO
    {
        DBUtil connect = new DBUtil();
        public bool addCertificate(WorkCertificate certificate)
        {
            try
            {
                string[] date = certificate.SignDate.ToString().Split('.');
                string signDate = date[2] + "-" + date[1] + "-" + date[0];
                string query = String.Format("Insert WorkCertificate values ('{0}', '{1}', '{2}')", certificate.CertificateNum, signDate, certificate.ContractNum);
                connect.executeNonQuery(query);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
