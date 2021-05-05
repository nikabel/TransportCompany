using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportCompany.models;

namespace TransportCompany.DAO
{
    public class ApplicationDAO
    {
        DBUtil connect = new DBUtil();

        public bool addApplication(Application application)
        {
            try
            {
                string[] date = application.SignDate.ToString().Split('.');
                string signDate = date[2] + "-" + date[1] + "-" + date[0];
                string[] d = application.DeliveryDate.ToString().Split('.');
                string delDate = d[2] + "-" + d[1] + "-" + d[0];
                string query = String.Format("Insert ApplicationForm values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", application.ApplicationNum, application.CustomerName, application.FreightSum, signDate, delDate, application.IsInsured, application.ContractNum);
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
