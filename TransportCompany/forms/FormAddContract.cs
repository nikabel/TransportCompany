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
    public partial class FormAddContract : Form
    {
        CustomerDAO customerDAO = new CustomerDAO();
        public FormAddContract()
        {
            InitializeComponent();
            comboBoxCustomer.Items.AddRange(customerDAO.getAllCustomers());
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            
        }
    }
}
