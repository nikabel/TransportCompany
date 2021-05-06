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
    public class TransportApplicationDAO
    {
        DBUtil connect = new DBUtil();
        public bool addTransportApplication(TransportApplication ta)
        {
            try
            {
                string query = String.Format("Insert TransportApplication values ('{0}', '{1}')", ta.LicensePlate, ta.ApplicationNum);
                connect.executeNonQuery(query);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool checkTransportApplication(TransportApplication ta)
        {
            try
            {
                string query = String.Format("select * from TransportApplication WHERE license_plate = '{0}' AND application_num = '{1}'", ta.LicensePlate, ta.ApplicationNum);
                DataTable dt = connect.executeQuery(query);
                if (dt.Rows.Count == 0) return true;
                else return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
