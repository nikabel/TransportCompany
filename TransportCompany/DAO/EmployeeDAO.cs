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
    public class EmployeeDAO
    {
        DBUtil connect = new DBUtil();

        public DataTable getAll()
        {
            try
            {
                string query = "select * from Employee";
                DataTable dt = connect.executeQuery(query);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Employee getEmployeeByName(string name)
        {
            SqlConnection conn = connect.createConnection();
            try
            {
                string query = String.Format("select * from Employee where employee_name = '{0}'", name);
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                var emps = new List<Employee>();
                while (dr.Read())
                {
                    string fio = dr.GetString(0);
                    string pos = dr.GetString(1);
                    string tel = dr.GetString(2);
                    string adr = dr.GetString(3);
                    string dep = dr.GetString(4);
                    emps.Add(new Employee(fio, dep, pos, tel, adr));
                }

                Employee[] empNames = emps.ToArray();
                dr.Close();
                conn.Close();
                return empNames[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string[] getAllEmployees()
        {
            SqlConnection conn = connect.createConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("select employee_name from Employee", conn);
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
                throw ex;
            }
        }

        public void deleteByName(string name)
        {
            try
            {
                string query = String.Format("Delete from Employee where employee_name = '{0}'", name);
                connect.executeNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void addEmployee(Employee employee)
        {
            try
            {
                string query = String.Format("Insert Employee values ('{0}', '{1}', '{2}', '{3}', '{4}')", employee.EmployeeName, employee.EmployeePos, employee.EmployeeTel, employee.EmployeeAddress, employee.DepartmentName);
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
                string query = String.Format("SELECT employee_name, position, employee_tel_num, employee_address, department_name FROM Employee WHERE employee_name LIKE '{0}' + '%'", str);
                DataTable dt = connect.executeQuery(query);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void updateEmployee(string oldName, Employee newEmployee)
        {
            try
            {
                string query = String.Format("UPDATE Employee SET employee_name = '{0}', position = '{1}', employee_tel_num = '{2}', employee_address = '{3}', department_name = '{4}' WHERE employee_name = '{5}' ", newEmployee.EmployeeName, newEmployee.EmployeePos, newEmployee.EmployeeTel, newEmployee.EmployeeAddress, newEmployee.DepartmentName, oldName);
                connect.executeNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
