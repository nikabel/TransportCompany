using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                string dateDep = dateDeparture.Text;
                string dateArr = dateArrival.Text;
                int distance = int.Parse(textBoxDistance.Text.ToString());
                string emp = comboBoxEmployee.SelectedItem.ToString();
                Route route = new Route(num, emp, appNum, distance, dateDep, dateArr, null, null);
                routeDAO.addRoute(route);
                FormAddStop form = new FormAddStop(num);
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так!" + ex);
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
