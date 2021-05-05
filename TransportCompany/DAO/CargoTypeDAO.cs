using System;
using System.Data;
using TransportCompany.models;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace TransportCompany.DAO
{
    public class CargoTypeDAO
    {
        DBUtil connect = new DBUtil();

        public DataTable getAll()
        {
            try
            {
                string query = "select * from CargoType";
                DataTable dt = connect.executeQuery(query);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public string[] getTypeNames()
        {
            SqlConnection conn = connect.createConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("select cargo_type_name from CargoType", conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                var types = new List<string>();
                while (dr.Read())
                {
                    types.Add(dr.GetString(0));
                }

                string[] typeNames = types.ToArray();
                dr.Close();
                conn.Close();
                return typeNames;

            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public bool deleteByName(string name)
        {
            try
            {
                string query = String.Format("Delete from CargoType where cargo_type_name = '{0}'", name);
                connect.executeNonQuery(query);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool addType(CargoType cargoType)
        {
            try
            {
                string query = String.Format("Insert CargoType values ('{0}')", cargoType.CargoTypeName);
                connect.executeNonQuery(query);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public DataTable searchByName(string name)
        {
            try
            {
                string query = String.Format("SELECT cargo_type_name FROM CargoType WHERE cargo_type_name LIKE '{0}' + '%'", name);
                DataTable dt = connect.executeQuery(query);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public bool updateType(string oldName, CargoType newCargoType)
        {
            try
            {
                string query = String.Format("UPDATE CargoType SET cargo_type_name = '{0}' WHERE cargo_type_name = '{2}' ", newCargoType.CargoTypeName, oldName);
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
