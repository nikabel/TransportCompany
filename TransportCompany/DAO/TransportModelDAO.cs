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

        public string[] getAllTransModels()
        {
            SqlConnection conn = connect.createConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("select model_name from TransportModel", conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                var models = new List<string>();
                while (dr.Read())
                {
                    models.Add(dr.GetString(0));
                }

                string[] modelNames = models.ToArray();
                dr.Close();
                conn.Close();
                return modelNames;
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
                string query = String.Format("Delete from TransportModel where model_name = '{0}'", name);
                connect.executeNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void addType(TransportModel model)
        {
            try
            {
                string query = String.Format("Insert TransportModel values ('{0}', '{1}', '{2}')", model.ModelName, model.MarkName, model.ModelCount);
                connect.executeNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable searchByName(string name)
        {
            try
            {
                string query = String.Format("SELECT model_name, mark_name, model_count FROM TransportModel WHERE model_name LIKE '{0}' + '%'", name);
                DataTable dt = connect.executeQuery(query);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public void updateType(string oldName, TransportModel newTransportModel)
        {
            try
            {
                string query = String.Format("UPDATE TransportModel SET model_name = '{0}', mark_name= '{1}', model_count = '{2}' WHERE cargo_type_name = '{3}' ", newTransportModel.ModelName, newTransportModel.MarkName, newTransportModel.ModelCount, oldName);
                connect.executeNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
