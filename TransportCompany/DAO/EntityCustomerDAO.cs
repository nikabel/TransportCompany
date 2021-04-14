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
    public class EntityCustomerDAO
    {
        DBUtil connect = new DBUtil();

        public DataTable getAll()
        {
            try
            {
                string query = "select * from EntityCustomer";
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
                string query = String.Format("Delete from EntityCustomer where entity_director_name = '{0}'", name);
                connect.executeNonQuery(query);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool addCustomer(EntityCustomer customer)
        {
            try
            {
                string query = String.Format("Insert EntityCustomer values ('{0}', '{1}')",
                    customer.CustomerName, customer.OrgName);
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
                string query = String.Format("SELECT entity_director_name, entity_company_name FROM EntityCustomer where entity_director_name LIKE '{0}' + '%'", str);
                DataTable dt = connect.executeQuery(query);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public bool updateCustomer(string oldName, EntityCustomer newCustomer)
        {
            try
            {
                string query = String.Format("UPDATE EntityCustomer SET entity_director_name = '{0}', entity_company_name = '{1}' WHERE entity_director_name = '{2}' ",
                    newCustomer.CustomerName, newCustomer.OrgName, oldName);
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
