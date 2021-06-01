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
    public class DriverDAO
    {
        DBUtil connect = new DBUtil();

        public DataTable getAll()
        {
            try
            {
                string query = "select * from Driver";
                DataTable dt = connect.executeQuery(query);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataTable getFreeDriver()
        {
            try
            {
                string query = "SELECT DISTINCT d.driver_name, e.employee_tel_num FROM Driver d join Employee e On d.driver_name=e.employee_name INNER Join Transport t on d.driver_name = t.driver_name INNER Join TransportApplication ta ON t.license_plate=ta.license_plate INNER Join ApplicationForm a ON ta.application_num=a.application_num INNER JOIN Contract c ON a.contract_num=c.contract_num where c.completion in ('Завершен')";
                DataTable dt = connect.executeQuery(query);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataTable getOccupiedDriver()
        {
            try
            {
                string query = "SELECT d.driver_name, e.employee_tel_num, t.license_plate, c.contract_num FROM Driver d join Employee e On d.driver_name=e.employee_name INNER Join Transport t on d.driver_name = t.driver_name INNER Join TransportApplication ta ON t.license_plate=ta.license_plate INNER Join ApplicationForm a ON ta.application_num=a.application_num INNER JOIN Contract c ON a.contract_num=c.contract_num where c.completion in ('В работе')";
                DataTable dt = connect.executeQuery(query);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public string[] getAllDriverNames()
        {
            SqlConnection conn = connect.createConnection();
            try
            { 
                SqlCommand cmd = new SqlCommand("select driver_name from Driver", conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                var drivers = new List<string>();
                while (dr.Read())
                {
                    drivers.Add(dr.GetString(0));
                }
                
                string[] driverNames = drivers.ToArray();
                dr.Close();
                conn.Close();
                return driverNames;
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
                string query = String.Format("Delete from Driver where driver_name = '{0}'", name);
                connect.executeNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void addDriver(Driver driver)
        {
            try
            {
                string query = String.Format("Insert Driver values ('{0}', '{1}', '{2}')", driver.EmployeeName, driver.DrivingExperience, driver.LicenseCategory);
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
                string query = String.Format("SELECT driver_name, driving_experience, license_category FROM Driver WHERE driver_name LIKE '{0}' + '%'", str);
                DataTable dt = connect.executeQuery(query);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public void updateEmployee(string oldName, Driver newDriver)
        {
            try
            {
                string query = String.Format("UPDATE Driver SET driver_name = '{0}', driving_experience = '{1}', license_category = '{2}' WHERE driver_name = '{3}' ", newDriver.EmployeeName, newDriver.DrivingExperience, newDriver.LicenseCategory, oldName);
                connect.executeNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
