using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using TransportCompany.models;
using System.Threading.Tasks;

namespace TransportCompany.DAO
{
    public class StopDAO
    {
        DBUtil connect = new DBUtil();
        public DataTable getAllByRoute(string id)
        {
            try
            {
                string query = String.Format("select * from Stop WHERE route_id = '{0}'", id);
                DataTable dt = connect.executeQuery(query);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void addStop(Stop stop)
        {
            try
            {
                string[] date = stop.PlanStopDate.ToString().Split('.');
                string planDate = date[2] + "-" + date[1] + "-" + date[0];
                string query = String.Format("Insert Stop values ('{0}', '{1}', '{2}', '{3}', '{4}', null)", stop.StopId,
                    stop.StopAddress, stop.OperationName, stop.RouteId, planDate);
                connect.executeNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void updateStop(string newFactDate, string stop)
        {
            try
            {
                string[] date = newFactDate.Split('.');
                string factDate = date[2] + "-" + date[1] + "-" + date[0];
                string query = String.Format("UPDATE Stop SET fact_stop_date = '{0}' WHERE stop_id = '{1}'", factDate, stop);
                connect.executeNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /*public Stop getStopById(string id)
        {
            SqlConnection conn = connect.createConnection();
            try
            {
                string query = String.Format("select * from Stop where stop_id = '{0}'", id);
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                var stops = new List<Stop>();
                while (dr.Read())
                {
                    string stop = dr.GetString(0);
                    string adr = dr.GetString(1);
                    string op = dr.GetString(2);
                    string route = dr.GetString(3);
                    string[] date = dr.GetString(dr.GetOrdinal("plan_stop_date")).Split('-');
                    string planDate = date[2] + "." + date[1] + "." + date[0];
                    string[] d = dr.GetString(dr.GetOrdinal("fact_stop_date")).Split('-');
                    string factDate = date[2] + "." + date[1] + "." + date[0];
                    stops.Add(new Stop(stop, adr, route, op, planDate, factDate));
                }
                Stop[] stopArray = stops.ToArray();
                dr.Close();
                conn.Close();
                return stopArray[0];

            }
            catch (Exception ex)
            {
                return null;
            }
        }*/
    }
}
