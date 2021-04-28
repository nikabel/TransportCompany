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
    public class CustomerDAO
    {
        DBUtil connect = new DBUtil();

        public DataTable getAll()
        {
            try
            {
                string query = "select * from Customer";
                DataTable dt = connect.executeQuery(query);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public string[] getAllCustomers()
        {
            SqlConnection conn = connect.createConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("select customer_name from Customer", conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                var customers = new List<string>();
                while (dr.Read())
                {
                    customers.Add(dr.GetString(0));
                }

                string[] customerNames = customers.ToArray();
                dr.Close();
                conn.Close();
                return customerNames;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public Customer getCustomerByName(string name)
        {
            SqlConnection conn = connect.createConnection();
            try
            {
                string query = String.Format("select * from Customer where customer_name = '{0}'", name);
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                var customers = new List<Customer>();
                while (dr.Read())
                {
                    string fio = dr.GetString(0);
                    string email = dr.GetString(1);
                    string tel = dr.GetString(2);
                    string adr = dr.GetString(3);
                    string badr = dr.GetString(4);
                    customers.Add(new Customer(fio, email, tel, adr, badr));
                }

                Customer[] customerNames = customers.ToArray();
                dr.Close();
                conn.Close();
                return customerNames[0];
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
                string query = String.Format("Delete from Customer where customer_name = '{0}'", name);
                connect.executeNonQuery(query);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool addCustomer(Customer customer)
        {
            try
            {
                string query = String.Format("Insert Customer values ('{0}', '{1}', '{2}', '{3}', '{4}')", 
                    customer.CustomerName, customer.CustomerEmail, customer.CustomerTel, customer.CustomerAddress, customer.CustomerBussinessAddress);
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
                string query = String.Format("SELECT customer_name, email, customer_tel_num, customer_address, customer_business_address FROM Customer where customer_name LIKE '{0}' + '%'", str);
                DataTable dt = connect.executeQuery(query);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public bool updateCustomer(string oldName, Customer newCustomer)
        {
            try
            {
                string query = String.Format("UPDATE Customer SET customer_name = '{0}',email = '{1}', customer_tel_num = '{2}', customer_address = '{3}',  customer_business_address = '{4}' WHERE customer_name = '{5}' ",
                    newCustomer.CustomerName, newCustomer.CustomerEmail, newCustomer.CustomerTel, newCustomer.CustomerAddress, newCustomer.CustomerBussinessAddress, oldName);
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
