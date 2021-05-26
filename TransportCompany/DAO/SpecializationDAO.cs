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
    public class SpecializationDAO
    {
        DBUtil connect = new DBUtil();

        public DataTable getAll()
        {
            try
            {
                string query = "select * from Specialization";
                DataTable dt = connect.executeQuery(query);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string[] getAllSpecializations()
        {
            SqlConnection conn = connect.createConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("select spec_name from Specialization", conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                var specs = new List<string>();
                while (dr.Read())
                {
                    specs.Add(dr.GetString(0));
                }

                string[] specNames = specs.ToArray();
                dr.Close();
                conn.Close();
                return specNames;
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
                string query = String.Format("Delete from Specialization where spec_name = '{0}'", name);
                connect.executeNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void addType(Specialization spec)
        {
            try
            {
                string query = String.Format("Insert Specialization values ('{0}')", spec.SpecName);
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
                string query = String.Format("SELECT spec_name FROM Specialization WHERE spec_name LIKE '{0}' + '%'", name);
                DataTable dt = connect.executeQuery(query);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void updateType(string oldName, Specialization newSpec)
        {
            try
            {
                string query = String.Format("UPDATE Specialization SET spec_name = '{0}' WHERE spec_name = '{2}' ", newSpec.SpecName, oldName);
                connect.executeNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
