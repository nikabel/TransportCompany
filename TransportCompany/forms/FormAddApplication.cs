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
using Application = TransportCompany.models.Application;
using Contract = TransportCompany.models.Contract;

namespace TransportCompany.forms
{
    public partial class FormAddApplication : Form
    {
        ContractDAO contractDAO = new ContractDAO();
        ApplicationDAO applicationDAO = new ApplicationDAO();
        public FormAddApplication()
        {
            InitializeComponent();
            comboBoxContracts.Items.AddRange(contractDAO.getAllContracts());
            comboBoxInsurance.Items.AddRange(new string[] {"Да", "Нет"});
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string num = textBoxApplicationNum.Text.ToString();
                string contractNum = comboBoxContracts.SelectedItem.ToString();
                string date = dateSign.Text;
                string dateDel = dateDelivery.Text;
                int freight = int.Parse(textBoxFreight.Text.ToString());
                string insurance = comboBoxInsurance.SelectedItem.ToString();
                string customer = contractDAO.getContractByNum(contractNum);
                Application application = new Application(num, contractNum, customer, date, freight, insurance, dateDel);
                applicationDAO.addApplication(application);
                if ((textBoxApplicationNum.Text.Equals("")) || (comboBoxContracts.Text.Equals("")) || (textBoxFreight.Text.Equals(""))
                    || (comboBoxInsurance.Text.Equals("")))
                    MessageBox.Show("Вы не ввели все необходимые данные!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                else
                {
                    this.Close();
                    FormAddCargo form = new FormAddCargo(num);
                    form.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так!" + ex);
            }
        }

        private void textBoxFreight_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}
