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

namespace TransportCompany.forms
{
    public partial class FormDelayedOrders : Form
    {
        ContractDAO dao = new ContractDAO();
        public FormDelayedOrders()
        {
            InitializeComponent();
            updateTable();
        }

        private void FormDelayedOrders_Load(object sender, EventArgs e)
        {

        }
        public void updateTable()
        {
            try
            {
                DataTable data = dao.getDelayedContract();
                data.Columns["contract_num"].ColumnName = "Номер договора";
                data.Columns["customer_name"].ColumnName = "ФИО заказчика";
                data.Columns["sign_date"].ColumnName = "Дата подписания";
                data.Columns["expiration_date"].ColumnName = "Дата истечения";
                dataGridViewContracts.DataSource = data;
            }
            catch
            {
                MessageBox.Show("Ошибка при получении данных!");
            }
        }
    }
}
