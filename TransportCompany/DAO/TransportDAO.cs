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
                throw ex;
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
                throw ex;
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
                string query = String.Format("Insert INTO Transport values ('{0}', '{1}', '{2}', '{3}')", transport.LicensePlate, transport.DriverName, transport.ModelName, transport.Occupation);
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
                string query = String.Format("SELECT license_plate, driver_name, model_name, occupation FROM Transport WHERE license_plate LIKE '{0}' + '%'", str);
                DataTable dt = connect.executeQuery(query);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void updateType(string oldName, Transport newTransport)
        {
            try
            {
                string query = String.Format("UPDATE Transport SET license_plate = '{0}', driver_name = '{1}', model_name = '{2}', occupation = '{3}' WHERE license_plate = '{4}' ", newTransport.LicensePlate, newTransport.DriverName, newTransport.ModelName, newTransport.Occupation, oldName);
                connect.executeNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
