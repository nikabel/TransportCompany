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
                throw ex;
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
                throw ex;
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
                    customers.Add(new Customer(fio, email, tel, adr));
                }

                Customer[] customerNames = customers.ToArray();
                dr.Close();
                conn.Close();
                return customerNames[0];
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
                string query = String.Format("Delete from Customer where customer_name = '{0}'", name);
                connect.executeNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void addCustomer(Customer customer)
        {
            try
            {
                string query = String.Format("Insert Customer values ('{0}', '{1}', '{2}', '{3}')", 
                    customer.CustomerName, customer.CustomerEmail, customer.CustomerTel, customer.CustomerAddress);
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
                string query = String.Format("SELECT customer_name, email, customer_tel_num, customer_address FROM Customer where customer_name LIKE '{0}' + '%'", str);
                DataTable dt = connect.executeQuery(query);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void updateCustomer(string oldName, Customer newCustomer)
        {
            try
            {
                string query = String.Format("UPDATE Customer SET customer_name = '{0}',email = '{1}', customer_tel_num = '{2}', customer_address = '{3}' WHERE customer_name = '{4}' ",
                    newCustomer.CustomerName, newCustomer.CustomerEmail, newCustomer.CustomerTel, newCustomer.CustomerAddress, oldName);
                connect.executeNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
