using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportCompany.models;

namespace TransportCompany.DAO
{
    public class StopTypeDAO
    {
        DBUtil connect = new DBUtil();

        public DataTable getAll()
        {
            try
            {
                string query = "select * from StopType";
                DataTable dt = connect.executeQuery(query);
                return dt;
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
                string query = String.Format("Delete from StopType where stop_type_name = '{0}'", name);
                connect.executeNonQuery(query);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool addType(StopType stopType)
        {
            try
            {
                string query = String.Format("Insert StopType values ('{0}', '{1}')", stopType.StopTypeName, stopType.StopTypeDesc);
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
                string query = String.Format("SELECT stop_type_name, stop_type_desc FROM StopType WHERE stop_type_name LIKE '{0}' + '%'", name);
                DataTable dt = connect.executeQuery(query);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public bool updateType(string oldName, StopType newStopType)
        {
            try
            {
                string query = String.Format("UPDATE StopType SET stop_type_name = '{0}', stop_type_desc = '{1}' WHERE stop_type_name = '{2}' ", newStopType.StopTypeName, newStopType.StopTypeDesc, oldName);
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
