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
    public class TransportDAO
    {
        DBUtil connect = new DBUtil();
        TransportApplicationDAO daoTransApp = new TransportApplicationDAO();

        public DataTable getAll()
        {
            try
            {
                string query = "select * from Transport";
                DataTable dt = connect.executeQuery(query);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataTable getFreeTrans()
        {
            try
            {
                string query = "SELECT DISTINCT t.license_plate, t.model_name, tm.mark_name FROM Transport t join TransportModel tm on t.model_name = tm.model_name Join TransportApplication ta ON t.license_plate = ta.license_plate Join ApplicationForm a ON ta.application_num = a.application_num JOIN Contract c ON a.contract_num = c.contract_num where c.completion != 'В работе'";
                DataTable dt = connect.executeQuery(query);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataTable getOccupiedTrans()
        {
            try
            {
                string query = "SELECT t.license_plate, t.driver_name, t.model_name, tm.mark_name, c.contract_num FROM Transport t join TransportModel tm on t.model_name = tm.model_name Join TransportApplication ta ON t.license_plate = ta.license_plate Join ApplicationForm a ON ta.application_num = a.application_num JOIN Contract c ON a.contract_num = c.contract_num where c.completion = 'В работе'";
                DataTable dt = connect.executeQuery(query);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public string[] getTransportPlates()
        {
            SqlConnection conn = connect.createConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("select license_plate from Transport", conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                var plates = new List<string>();
                while (dr.Read())
                {
                    plates.Add(dr.GetString(0));
                }

                string[] platesNums = plates.ToArray();
                dr.Close();
                conn.Close();
                return platesNums;

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void deleteByName(string name)
        {
            try
            {
                string query = String.Format("Delete from Transport where license_plate = '{0}'", name);
                connect.executeNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void addType(Transport transport)
        {
            try
            {
                string query = String.Format("Insert INTO Transport values ('{0}', '{1}', '{2}')", transport.LicensePlate, transport.DriverName, transport.ModelName);
                connect.executeNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable searchByName(string str)
        {
            try
            {
                string query = String.Format("SELECT license_plate, driver_name, model_name FROM Transport WHERE license_plate LIKE '{0}' + '%'", str);
                DataTable dt = connect.executeQuery(query);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public void updateType(string oldName, Transport newTransport)
        {
            try
            {
                string query = String.Format("UPDATE Transport SET license_plate = '{0}', driver_name = '{1}', model_name = '{2}' WHERE license_plate = '{3}' ", 
                    newTransport.LicensePlate, newTransport.DriverName, newTransport.ModelName,  oldName);
                connect.executeNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
