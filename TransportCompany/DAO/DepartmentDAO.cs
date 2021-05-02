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
    public class DepartmentDAO
    {
        DBUtil connect = new DBUtil();

        public DataTable getAll()
        {
            try
            {
                string query = "select * from Department";
                DataTable dt = connect.executeQuery(query);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public string[] getAllDepartments()
        {
            SqlConnection conn = connect.createConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("select department_name from Department", conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                var deps = new List<string>();
                while (dr.Read())
                {
                    deps.Add(dr.GetString(0));
                }

                string[] depNames = deps.ToArray();
                dr.Close();
                conn.Close();
                return depNames;
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
                string query = String.Format("Delete from Department where department_name = '{0}'", name);
                connect.executeNonQuery(query);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool addType(Department dep)
        {
            try
            {
                string query = String.Format("Insert Department values ('{0}', '{1}')", dep.DepartmentName, dep.CompanyName);
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
                string query = String.Format("SELECT department_name, company_name FROM Department WHERE department_name LIKE '{0}' + '%'", name);
                DataTable dt = connect.executeQuery(query);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public bool updateType(string oldName, Department newDep)
        {
            try
            {
                string query = String.Format("UPDATE Department SET department_name = '{0}', company_name = '{1}' WHERE department_name = '{2}' ", newDep.DepartmentName, newDep.CompanyName, oldName);
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
