using System;
using System.Data;
using TransportCompany.models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany.DAO
{
    public class TransportModelDAO
    {
        DBUtil connect = new DBUtil();

        public DataTable getAll()
        {
            try
            {
                string query = "select * from TransportModel";
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
                string query = String.Format("Delete from TransportModel where model_name = '{0}'", name);
                connect.executeNonQuery(query);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool addType(TransportModel model)
        {
            try
            {
                string query = String.Format("Insert TransportModel values ('{0}', '{1}', '{2}', '{3}')", model.ModelName, model.MarkName, model.ModelDesc, model.ModelCount);
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
                string query = String.Format("SELECT model_name, mark_name, model_desc, model_count FROM TransportModel WHERE model_name LIKE '{0}' + '%'", name);
                DataTable dt = connect.executeQuery(query);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public bool updateType(string oldName, TransportModel newTransportModel)
        {
            try
            {
                string query = String.Format("UPDATE TransportModel SET model_name = '{0}', mark_name= '{1}', model_desc = '{2}', model_count = '{3}' WHERE cargo_type_name = '{4}' ", newTransportModel.ModelName, newTransportModel.MarkName, newTransportModel.ModelDesc, newTransportModel.ModelCount, oldName);
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
