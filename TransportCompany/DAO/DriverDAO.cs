using System;
using System.Data;
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

        public bool deleteByName(string name)
        {
            try
            {
                string query = String.Format("Delete from Driver where driver_name = '{0}'", name);
                connect.executeNonQuery(query);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool addDriver(Driver driver)
        {
            try
            {
                string query = String.Format("Insert Driver values ('{0}', '{1}', '{2}')", driver.EmployeeName, driver.DrivingExperience, driver.LicenseCategory);
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
                string query = String.Format("SELECT driver_name, driving_experience, license_category FROM Driver WHERE driver_name LIKE '{0}' + '%'", str);
                DataTable dt = connect.executeQuery(query);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public bool updateEmployee(string oldName, Driver newDriver)
        {
            try
            {
                string query = String.Format("UPDATE Driver SET driver_name = '{0}', driving_experience = '{1}', license_category = '{2}' WHERE driver_name = '{3}' ", newDriver.EmployeeName, newDriver.DrivingExperience, newDriver.LicenseCategory, oldName);
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
