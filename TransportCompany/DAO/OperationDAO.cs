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
    public class OperationDAO
    {
        DBUtil connect = new DBUtil();

        public DataTable getAll()
        {
            try
            {
                string query = "select * from Operation";
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
                string query = String.Format("Delete from Operation where operation_name = '{0}'", name);
                connect.executeNonQuery(query);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool addType(Operation operation)
        {
            try
            {
                string query = String.Format("Insert Operation values ('{0}')", operation.OperationName);
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
                string query = String.Format("SELECT operation_name FROM Operation WHERE operation_name LIKE '{0}' + '%'", name);
                DataTable dt = connect.executeQuery(query);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public Operation getByName(string name)
        {
            try
            {
                string query = String.Format("SELECT operation_name FROM Operation WHERE operation_name LIKE '{0}' + '%'", name);
                DataTable dt = connect.executeQuery(query);
                Operation operation = new Operation(dt.Rows[0][0].ToString());
                return operation;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public bool updateType(string oldName, Operation newOperation)
        {
            try
            {
                string query = String.Format("UPDATE Operation SET operation_name = '{0}' WHERE operation_name = '1}' ", newOperation.OperationName, oldName);
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
