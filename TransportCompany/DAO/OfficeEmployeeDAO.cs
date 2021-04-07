﻿using System;
using System.Data;
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

        public bool deleteByName(string name)
        {
            try
            {
                string query = String.Format("Delete from OfficeEmployee where employee_name = '{0}'", name);
                connect.executeNonQuery(query);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool addDriver(OfficeEmployee emp)
        {
            try
            {
                string query = String.Format("Insert OfficeEmployee values ('{0}', '{1}')", emp.EmployeeName, emp.SpecName);
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
                string query = String.Format("SELECT employee_name, spec_name FROM OfficeEmployee WHERE employee_name LIKE '{0}' + '%'", str);
                DataTable dt = connect.executeQuery(query);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public bool updateEmployee(string oldName, OfficeEmployee newEmp)
        {
            try
            {
                string query = String.Format("UPDATE OfficeEmployee SET employee_name = '{0}', spec_name = '{1}' WHERE employee_name = '{2}' ", newEmp.EmployeeName, newEmp.SpecName, oldName);
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