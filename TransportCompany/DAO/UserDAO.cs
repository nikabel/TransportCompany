using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany.DAO
{
    public class UserDAO
    {
        DBUtil connect = new DBUtil();

        public DataTable getAll()
        {
            try
            {
                string query = "select * from UserEmployee";
                DataTable dt = connect.executeQuery(query);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void deleteByLogin(string login)
        {
            try
            {
                string query = String.Format("Delete from UserEmployee where user_login = '{0}'", login);
                connect.executeNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void addUser(string login, string employee, string password)
        {
            try
            {
                string query = String.Format("Insert UserEmployee values ('{0}', '{1}', '{2}')", login, employee, password);
                connect.executeNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool checkUser(string login, string password)
        {
            try
            {
                string query = String.Format("Select * from UserEmployee where user_login='{0}' and user_password='{1}'", login, password);
                DataTable dt = connect.executeQuery(query);
                if (dt.Rows.Count > 0)
                {
                    return true;
                }
                else return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public string getUserDepartment(string login)
        {
            try
            {
                string query = String.Format("Select e.department_name from UserEmployee ue Join OfficeEmployee oe On ue.employee_name=oe.employee_name Join Employee e ON oe.employee_name=e.employee_name where ue.user_login='{0}'", login);
                DataTable dt = connect.executeQuery(query);
                string dep = dt.Rows[0].Field<string>("department_name");
                if (dep=="Логистический отдел")
                {
                    return "Логист";
                }
                else if (dep == "Бухгалтерия")
                {
                    return "Бухгалтер";
                }
                else return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
