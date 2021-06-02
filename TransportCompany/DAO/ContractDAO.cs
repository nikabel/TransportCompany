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
    public class ContractDAO
    {
        DBUtil connect = new DBUtil();

        public DataTable getAll()
        {
            try
            {
                string query = "select * from Contract";
                DataTable dt = connect.executeQuery(query);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataTable getDelayedContract()
        {
            try
            {
                string query = "SELECT DISTINCT c.contract_num, c.customer_name, c.sign_date, c.expiration_date FROM Contract c Join ApplicationForm a ON c.contract_num = a.contract_num JOIN Route r ON a.application_num = r.application_num join Stop rp ON r.route_id=rp.route_id where c.completion= 'В работе' and (rp.fact_stop_date>rp.plan_stop_date or (rp.fact_stop_date=null and CONVERT (date, GETDATE())>rp.plan_stop_date))";
                DataTable dt = connect.executeQuery(query);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public void addContract(Contract contract)
        {
            try
            {
                string[] date = contract.SignDate.ToString().Split('.');
                string signDate = date[2] + "-" + date[1] + "-" + date[0];
                string[] d = contract.ExpirationDate.ToString().Split('.');
                string expDate = d[2] + "-" + d[1] + "-" + d[0];
                string query = String.Format("Insert Contract values ('{0}', '{1}', '{2}', '{3}', '{4}', 'В работе', null)", contract.ContractNum, contract.CompanyName, contract.CustomerName, signDate, expDate);
                connect.executeNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
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

        public string getContractByNum(string num)
        {
            SqlConnection conn = connect.createConnection();
            try
            {
                string query = String.Format("select customer_name from Contract where contract_num = '{0}'", num);
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                var contracts = new List<string>();
                while (dr.Read())
                {
                    contracts.Add(dr.GetString(0));
                }

                string[] contractNames = contracts.ToArray();
                dr.Close();
                conn.Close();
                return contractNames[0];
                
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void updateContract(string contractNum, string contractDate)
        {
            try
            {
                string query = String.Format("UPDATE Contract SET completion='Завершен', completion_date='{0}' WHERE contract_num='{1}'", contractDate, contractNum);
                connect.executeNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
