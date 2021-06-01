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
    public partial class FormCompleteOrder : Form
    {
        ContractDAO dao = new ContractDAO();
        public FormCompleteOrder()
        {
            InitializeComponent();
            updateTable();
        }

        public void updateTable()
        {
            DataTable data = dao.getAll();
            data.Columns["contract_num"].ColumnName = "Номер договора";
            data.Columns["customer_name"].ColumnName = "ФИО заказчика";
            data.Columns["sign_date"].ColumnName = "Дата подписания";
            data.Columns["expiration_date"].ColumnName = "Дата истечения";
            data.Columns["completion"].ColumnName = "Статус заказа";
            data.Columns["completion_date"].ColumnName = "Дата завершения";
            data.Columns.Remove("company_name");
            dataGridViewContracts.DataSource = data;
        }

        private void buttonComplete_Click(object sender, EventArgs e)
        {
            int rowNum = dataGridViewContracts.CurrentCell.RowIndex;
            if (dataGridViewContracts[4, rowNum].Value.ToString() != "Завершен")
            {
                try
                {
                    string n = dataGridViewContracts[0, rowNum].Value.ToString();
                    DateTime thisDay = DateTime.Today;
                    string date =thisDay.ToString("yyyy-MM-dd");
                    dao.updateContract(n, date);
                    updateTable();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при изменении!" + ex);
                }
            }
            else MessageBox.Show("Заказ уже завершен! Выберите другой заказ", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }
    }
}
