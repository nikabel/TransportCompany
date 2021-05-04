using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransportCompany.DAO;
using TransportCompany.models;
using Contract = TransportCompany.models.Contract;

namespace TransportCompany.forms
{
    public partial class FormAddContract : Form
    {
        CustomerDAO customerDAO = new CustomerDAO();
        CompanyDAO companyDAO = new CompanyDAO();
        ContractDAO contractDAO = new ContractDAO();
        public FormAddContract()
        {
            InitializeComponent();
            comboBoxCustomer.Items.AddRange(customerDAO.getAllCustomers());
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string num = textBoxContractNum.Text.ToString();
                string customer = comboBoxCustomer.SelectedItem.ToString();
                string sign = dateSign.Text;
                string exp = dateExpierience.Text;
                Contract contract = new Contract(num, sign, exp, customer, companyDAO.getCompanyName()[0]);
                contractDAO.addContract(contract);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неверно введены данные!");
            }
        }

        private void dateSign_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
