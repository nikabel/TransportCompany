using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportCompany.models;
using System.Windows.Forms;

namespace TransportCompany.DAO
{
    public class WorkCertificateDAO
    {
        DBUtil connect = new DBUtil();
        public void addCertificate(WorkCertificate certificate)
        {
            try
            {
                string[] date = certificate.SignDate.ToString().Split('.');
                string signDate = date[2] + "-" + date[1] + "-" + date[0];
                string query = String.Format("Insert WorkCertificate values ('{0}', '{1}', '{2}')", certificate.CertificateNum, signDate, certificate.ContractNum);
                connect.executeNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string[] getAllCertificates()
        {
            SqlConnection conn = connect.createConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("select certificate_num from WorkCertificate", conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                var certs = new List<string>();
                while (dr.Read())
                {
                    certs.Add(dr.GetString(0));
                }

                string[] certNums = certs.ToArray();
                dr.Close();
                conn.Close();
                return certNums;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
