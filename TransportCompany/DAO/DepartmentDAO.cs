using System;
using System.Data;
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
                string query = String.Format("Insert Department values ('{0}', '{1}', '{2}')", dep.DepartmentName, dep.CompanyName, dep.DepartmentDesc);
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
                string query = String.Format("SELECT department_name, company_name, department_desc FROM Department WHERE department_name LIKE '{0}' + '%'", name);
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
                string query = String.Format("UPDATE Department SET department_name = '{0}', company_name = '{1}', department_desc = '{2}'  WHERE spec_name = '{3}' ", newDep.DepartmentName, newDep.CompanyName, newDep.DepartmentDesc, oldName);
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
