using System;
using System.Data;
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
                return null;
            }
        }

        public bool deleteByName(string name)
        {
            try
            {
                string query = String.Format("Delete from Employee where employee_name = '{0}'", name);
                connect.executeNonQuery(query);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool addEmployee(Employee employee)
        {
            try
            {
                string query = String.Format("Insert Employee values ('{0}', '{1}', '{2}', '{3}', '{4}')", employee.EmployeeName, employee.EmployeePos, employee.EmployeeTel, employee.EmployeeAddress, employee.DepartmentName);
                connect.executeNonQuery(query);
                return true;
            }
            catch (Exception ex)
            {
                return false;
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
                return null;
            }

        }

        public bool updateEmployee(string oldName, Employee newEmployee)
        {
            try
            {
                string query = String.Format("UPDATE Employee SET employee_name = '{0}', position = '{1}', employee_tel_num = '{2}', employee_address = '{3}', department_name = '{4}' WHERE employee_name = '{5}' ", newEmployee.EmployeeName, newEmployee.EmployeePos, newEmployee.EmployeeTel, newEmployee.EmployeeAddress, newEmployee.DepartmentName, oldName);
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
