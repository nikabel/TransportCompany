using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TransportCompany.DAO
{
    public class DBUtil
    {
        public SqlConnection createConnection()
        {
            SqlConnection conn = new SqlConnection("Data Source=COMPUTER;Initial Catalog=CargoCompany;Integrated Security=True");
            return conn;
        }

        public DataTable executeQuery(string sql)
        {
            SqlConnection conn = createConnection();
            try
            {
                conn.Open();
                SqlDataAdapter ads = new SqlDataAdapter(sql, conn);
                DataTable ds = new DataTable();
                ads.Fill(ds);
                conn.Close();
                return ds;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void executeNonQuery(string sql)
        {
            SqlConnection conn = createConnection();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
            }
        }
    }
}
