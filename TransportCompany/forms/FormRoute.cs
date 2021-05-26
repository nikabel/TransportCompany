using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransportCompany.DAO;
using TransportCompany.models;

namespace TransportCompany.forms
{
    public partial class FormRoute : Form
    {
        OfficeEmployeeDAO oeDAO = new OfficeEmployeeDAO();
        ApplicationDAO appDAO = new ApplicationDAO();
        RouteDAO routeDAO = new RouteDAO();
        StopDAO stopDAO = new StopDAO();
        public FormRoute()
        {
            InitializeComponent();
            comboBoxEmployee.Items.AddRange(oeDAO.getAllEmployees());
            comboBoxApplicationNum.Items.AddRange(appDAO.getAllNums());
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddStop_Click(object sender, EventArgs e)
        {
            try
            {
                string num = textBoxRouteNum.Text.ToString();
                string appNum = comboBoxApplicationNum.SelectedItem.ToString();
                int distance = int.Parse(textBoxDistance.Text.ToString());
                string emp = comboBoxEmployee.SelectedItem.ToString();

                string depId = textBoxDepartureNum.Text;
                string depAdr = textBoxDepartureAddress.Text;
                string dateDep = dateDeparture.Text;
                string arrId = textBoxArrivalNum.Text;
                string arrAdr = textBoxArrivalAddress.Text;
                string dateArr = dateArrival.Text;

                if ((textBoxRouteNum.Text.Equals("")) || (comboBoxApplicationNum.Text.Equals("")) || (textBoxDistance.Text.Equals("")) || (comboBoxEmployee.Text.Equals(""))
               || (textBoxDepartureNum.Text.Equals("")) || (textBoxDepartureAddress.Text.Equals("")) || (textBoxArrivalNum.Text.Equals("")) || (textBoxArrivalAddress.Text.Equals("")))
                    MessageBox.Show("Вы не ввели все необходимые данные!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                else if (textBoxDepartureNum.Text == textBoxArrivalNum.Text)
                    MessageBox.Show("Номера прибытия и отправления не должны совпадать! Введите другие номера!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                else
                {
                    Route route = new Route(num, emp, appNum, distance);
                    routeDAO.addRoute(route);
                    Stop dep = new Stop(depId, depAdr, num, "Отправление", dateDep, null);
                    Stop arr = new Stop(arrId, arrAdr, num, "Прибытие", dateArr, null);
                    stopDAO.addStop(dep);
                    stopDAO.addStop(arr);
                    this.Close();
                    FormAddStop form = new FormAddStop(num);
                    form.ShowDialog();
                }
            }
            catch (SqlException odbcEx)
            {
                MessageBox.Show("Номер маршрута не должен повторяться!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при создании маршрута!" + ex);
            }
        }

        private void textBoxDistance_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}
