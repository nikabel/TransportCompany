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
    public class CargoDAO
    {
        DBUtil connect = new DBUtil();

        public DataTable getAllByApplication(string num)
        {
            try
            {
                string query = String.Format("select * from Cargo WHERE application_num = '{0}'", num);
                DataTable dt = connect.executeQuery(query);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void addCargo(Cargo cargo)
        {
            try
            {
                string query = String.Format("Insert Cargo values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", cargo.CargoNum,
                    cargo.ApplicationNum, cargo.CargoName, cargo.CargoTypeName, cargo.CargoWeight, cargo.CargoVolume, cargo.CargoCost);
                connect.executeNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
