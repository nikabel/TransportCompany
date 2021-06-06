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
    public partial class FormChooseEmployee : Form
    {
        ServiceDAO daoS = new ServiceDAO();
        EmployeeDAO daoE = new EmployeeDAO();
        public FormChooseEmployee(string num)
        {
            InitializeComponent();
            labelContractNum.Text = num;
            comboBoxName.Items.AddRange(daoE.getAllEmployees());
            updateTable(num);
        }
        public void updateTable(string num)
        {
            DataTable data = daoS.getAllByContract(num);
            data.Columns["service_name"].ColumnName = "Наименование услуги";
            data.Columns["employee_name"].ColumnName = "ФИО сотрудника";
            data.Columns["service_cost"].ColumnName = "Стоимость услуги";
            data.Columns["service_date"].ColumnName = "Дата оказания";
            data.Columns.Remove("certificate_num");
            data.Columns.Remove("contract_num");
            dataGridViewServices.DataSource = data;
        }

        private void textBoxCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxService_KeyPress(object sender, KeyPressEventArgs e)
        {
            char symb = e.KeyChar;
            if ((symb < 'А' || symb > 'я') && symb != '\b' && symb != ' ')
            {
                e.Handled = true;
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormChooseEmployee_Load(object sender, EventArgs e)
        {

        }

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            if ((textBoxService.Text.Equals("")) || (textBoxCost.Text.Equals("")) || (comboBoxName.Text.Equals("")))
                MessageBox.Show("Вы не ввели все необходимые данные!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else
            {
                try
                {
                    string num = labelContractNum.Text.ToString();
                    string name = textBoxService.Text.ToString();
                    int cost = int.Parse(textBoxCost.Text.ToString());
                    string employee = comboBoxName.SelectedItem.ToString();
                    string date = dateService.Text;
                    Service service = new Service(name, employee, cost, date, null, num);
                    daoS.addService(service);
                    textBoxService.Clear();
                    textBoxCost.Clear();
                    updateTable(num);
                }
                catch (SqlException odbcEx)
                {
                    MessageBox.Show("Наименование услуги не должно повторяться!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при назначении!" + ex);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelContractNum_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить данные?", "Сообщение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    string num = labelContractNum.Text.ToString();
                    int rowNum = dataGridViewServices.CurrentCell.RowIndex;
                    string name = dataGridViewServices[0, rowNum].Value.ToString();
                    daoS.deleteService(name, num);
                    updateTable(num);
                }
                catch (SqlException odbcEx)
                {
                    MessageBox.Show("Невозможно удалить данные, так как они используются!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при удалении!" + ex);
                }
            }
        }
    }
}
