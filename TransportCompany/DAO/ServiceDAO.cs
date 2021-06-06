using System;
using System.Data;
using System.Data.SqlClient;
using TransportCompany.models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany.DAO
{
    public class ServiceDAO
    {
        DBUtil connect = new DBUtil();

        public DataTable getAll()
        {
            try
            {
                string query = "select * from Service";
                DataTable dt = connect.executeQuery(query);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataTable getAllByContract(string num)
        {
            try
            {
                string query = String.Format("select * from Service WHERE contract_num= '{0}'", num);
                DataTable dt = connect.executeQuery(query);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void addService(Service service)
        {
            try
            {
                string[] date = service.ServiceDate.ToString().Split('.');
                string serviceDate = date[2] + "-" + date[1] + "-" + date[0];
                string query = String.Format("Insert Service values ('{0}', '{1}', '{2}', '{3}', '{4}', null)", service.ServiceName, service.ContractNum, service.EmployeeName, service.ServiceCost, serviceDate);
                connect.executeNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void updateService(string num, string contractNum)
        {
            try
            {
                string query = String.Format("UPDATE Service SET certificate_num = '{0}' WHERE contract_num = '{1}' ", num, contractNum);
                connect.executeNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void deleteService(string name, string num)
        {
            try
            {
                string query = String.Format("Delete from Service where service_name = '{0}' and contract_num = '{1}'", name, num);
                connect.executeNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
