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
                throw ex;
            }
        }

        public void deleteByName(string name)
        {
            try
            {
                string query = String.Format("Delete from EntityCustomer where entity_director_name = '{0}'", name);
                connect.executeNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void addCustomer(EntityCustomer customer)
        {
            try
            {
                string query = String.Format("Insert EntityCustomer values ('{0}', '{1}', '{2}')",
                    customer.CustomerName, customer.OrgName, customer.CustomerBussinessAddress);
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
                string query = String.Format("SELECT entity_director_name, entity_company_name, customer_business_address FROM EntityCustomer where entity_director_name LIKE '{0}' + '%'", str);
                DataTable dt = connect.executeQuery(query);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void updateCustomer(string oldName, EntityCustomer newCustomer)
        {
            try
            {
                string query = String.Format("UPDATE EntityCustomer SET entity_director_name = '{0}', entity_company_name = '{1}', customer_business_address = '{2}' WHERE entity_director_name = '{3}' ",
                    newCustomer.CustomerName, newCustomer.OrgName, newCustomer.CustomerBussinessAddress, oldName);
                connect.executeNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
