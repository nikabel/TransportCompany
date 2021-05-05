﻿using System;
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

        public bool addCargo(Cargo cargo)
        {
            try
            {
                string[] date = service.ServiceDate.ToString().Split('.');
                string serviceDate = date[2] + "-" + date[1] + "-" + date[0];
                string query = String.Format("Insert Service values ('{0}', '{1}', '{2}', '{3}', '{4}', null)", service.ServiceName, service.ContractNum, service.EmployeeName, service.ServiceCost, serviceDate);
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