﻿using System;
using System.Data.SqlClient;
using TransportCompany.models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany.DAO
{
    public class BankDetailsDAO
    {
        DBUtil connect = new DBUtil();
        public BankDetails getBankByName(string name)
        {
            SqlConnection conn = connect.createConnection();
            try
            {
                string query = String.Format("select * from BankDetails where customer_name = '{0}'", name);
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                var details = new List<BankDetails>();
                while (dr.Read())
                {
                    string acc = dr.GetString(0);
                    string inn = dr.GetString(3);
                    string rcbic = dr.GetString(4);
                    string ogrn = dr.GetString(5);
                    string corr = dr.GetString(6);
                    details.Add(new BankDetails(acc, null, name, inn, rcbic, ogrn, corr));
                }

                BankDetails[] detailsArr = details.ToArray();
                dr.Close();
                conn.Close();
                return detailsArr[0];
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
                string query = String.Format("Delete from BankDetails where customer_name = '{0}'", name);
                connect.executeNonQuery(query);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool addBankDetails(BankDetails details)
        {
            try
            {
                string query = String.Format("Insert BankDetails values ('{0}', null, '{1}', '{2}', '{3}', '{4}')",
                    details.Acc, details.CustomerName, details.Inn, details.Rcbic, details.Ogrn, details.CorrAcc);
                connect.executeNonQuery(query);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool updateBankDetails(string oldAcc, BankDetails details)
        {
            try
            {
                string query = String.Format("UPDATE BankDetails SET acc = '{0}', company_name = null, customer_name = '{1}', inn = '{2}', rcbic = '{3}', ogrn = '{4}', corr_acc = '{5}' WHERE acc = '{6}' ",
                    details.Acc, details.CustomerName, details.Inn, details.Rcbic, details.Ogrn, details.CorrAcc, oldAcc);
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
