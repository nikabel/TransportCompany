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
    public partial class FormControlOrderChooseRoute : Form
    {
        RouteDAO routeDAO = new RouteDAO();
        public FormControlOrderChooseRoute()
        {
            InitializeComponent();
            comboBoxRoute.Items.AddRange(routeDAO.getAllRoutes());
        }

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxRoute.Text.Equals(""))
                    MessageBox.Show("Выберите номер маршрута!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                else
                {
                    this.Close();
                    FormControlOrder form = new FormControlOrder(comboBoxRoute.SelectedItem.ToString());
                    form.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так!" + ex);
            }
        }
    }
}
