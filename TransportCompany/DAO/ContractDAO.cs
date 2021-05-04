using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportCompany.models;

namespace TransportCompany.DAO
{
    public class ContractDAO
    {
        DBUtil connect = new DBUtil();
        public bool addContract(Contract contract)
        {
            try
            {
                string[] date = contract.SignDate.ToString().Split('.');
                string signDate = date[2] + "-" + date[1] + "-" + date[0];
                string[] d = contract.ExpirationDate.ToString().Split('.');
                string expDate = d[2] + "-" + d[1] + "-" + d[0];
                string query = String.Format("Insert Contract values ('{0}', '{1}', '{2}', '{3}', '{4}')", contract.ContractNum, contract.CompanyName, contract.CustomerName, signDate, expDate);
                connect.executeNonQuery(query);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public string[] getAllContracts()
        {
            SqlConnection conn = connect.createConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("select contract_num from Contract", conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                var contracts = new List<string>();
                while (dr.Read())
                {
                    contracts.Add(dr.GetString(0));
                }

                string[] contractNums = contracts.ToArray();
                dr.Close();
                conn.Close();
                return contractNums;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
