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
