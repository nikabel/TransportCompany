using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportCompany.models;

namespace TransportCompany.DAO
{
    public class RouteDAO
    {
        DBUtil connect = new DBUtil();

        public bool addRoute(Route route)
        {
            try
            {
                string query = String.Format("Insert Route values ('{0}', '{1}', '{2}', '{3}')", route.RouteId,
                    route.EmployeeName, route.ApplicationNum, route.TotalDistance);
                connect.executeNonQuery(query);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public string[] getAllRoutes()
        {
            SqlConnection conn = connect.createConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("select route_id from Route", conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                var routes = new List<string>();
                while (dr.Read())
                {
                    routes.Add(dr.GetString(0));
                }

                string[] routeIds = routes.ToArray();
                dr.Close();
                conn.Close();
                return routeIds;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
