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
    public class OfficeEmployeeDAO
    {
        DBUtil connect = new DBUtil();

        public DataTable getAll()
        {
            try
            {
                string query = "select * from OfficeEmployee";
                DataTable dt = connect.executeQuery(query);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public string[] getLogistBuch()
        {
            SqlConnection conn = connect.createConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("select e.employee_name from OfficeEmployee oe JOIN Employee e ON oe.employee_name=e.employee_name WHERE e.department_name='Логистический отдел' OR e.department_name='Бухгалтерия'", conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                var employees = new List<string>();
                while (dr.Read())
                {
                    employees.Add(dr.GetString(0));
                }

                string[] employeeNames = employees.ToArray();
                dr.Close();
                conn.Close();
                return employeeNames;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public string[] getAllEmployees()
        {
            SqlConnection conn = connect.createConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("select employee_name from OfficeEmployee", conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                var employees = new List<string>();
                while (dr.Read())
                {
                    employees.Add(dr.GetString(0));
                }

                string[] employeeNames = employees.ToArray();
                dr.Close();
                conn.Close();
                return employeeNames;
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
                string query = String.Format("Delete from OfficeEmployee where employee_name = '{0}'", name);
                connect.executeNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void addEmployee(OfficeEmployee emp)
        {
            try
            {
                string query = String.Format("Insert OfficeEmployee values ('{0}', '{1}')", emp.EmployeeName, emp.SpecName);
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
                string query = String.Format("SELECT employee_name, spec_name FROM OfficeEmployee WHERE employee_name LIKE '{0}' + '%'", str);
                DataTable dt = connect.executeQuery(query);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public void updateEmployee(string oldName, OfficeEmployee newEmp)
        {
            try
            {
                string query = String.Format("UPDATE OfficeEmployee SET employee_name = '{0}', spec_name = '{1}' WHERE employee_name = '{2}' ", newEmp.EmployeeName, newEmp.SpecName, oldName);
                connect.executeNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
