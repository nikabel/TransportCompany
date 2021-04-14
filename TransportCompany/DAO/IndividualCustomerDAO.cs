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
    public class IndividualCustomerDAO
    {
        DBUtil connect = new DBUtil();

        public DataTable getAll()
        {
            try
            {
                string query = "select * from IndividualCustomer";
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
                string query = String.Format("Delete from IndividualCustomer where customer_name = '{0}'", name);
                connect.executeNonQuery(query);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool addCustomer(IndividualCustomer customer)
        {
            try
            {
                string query = String.Format("Insert IndividualCustomer values ('{0}')",
                    customer.CustomerName);
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
                string query = String.Format("SELECT customer_name FROM IndividualCustomer where customer_name LIKE '{0}' + '%'", str);
                DataTable dt = connect.executeQuery(query);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public bool updateCustomer(string oldName, IndividualCustomer newCustomer)
        {
            try
            {
                string query = String.Format("UPDATE IndividualCustomer SET customer_name = '{0}' WHERE customer_name = '{1}' ",
                    newCustomer.CustomerName, oldName);
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
