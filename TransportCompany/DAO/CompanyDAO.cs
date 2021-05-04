using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TransportCompany.models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany.DAO
{
    public class CompanyDAO
    {
        DBUtil connect = new DBUtil();
        public string[] getCompanyName()
        {
            SqlConnection conn = connect.createConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("select company_name from CargoCompany", conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                var models = new List<string>();
                while (dr.Read())
                {
                    models.Add(dr.GetString(0));
                }

                string[] modelNames = models.ToArray();
                dr.Close();
                conn.Close();
                return modelNames;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
