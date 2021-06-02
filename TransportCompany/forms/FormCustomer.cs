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
    public partial class FormCustomer : Form
    {
        DBUtil connect = new DBUtil();
        CustomerDAO daoC = new CustomerDAO();
        EntityCustomerDAO daoEC = new EntityCustomerDAO();
        IndividualCustomerDAO daoIC = new IndividualCustomerDAO();
        BankDetailsDAO daoBD = new BankDetailsDAO();

        public FormCustomer(string role)
        {
            InitializeComponent();
            connect.createConnection();
            updateTable();
            if (role == "Логист")
            {
                buttonDeleteCustomer.Enabled = false;
                buttonAddIndividual.Enabled = false;
                buttonAddEntity.Enabled = false;
                buttonChangeIndividual.Enabled = false;
                buttonChangeEntity.Enabled = false;
            }
            else if (role == "Бухгалтер")
            {
                buttonDeleteCustomer.Enabled = false;
                buttonAddIndividual.Enabled = false;
                buttonAddEntity.Enabled = false;
                buttonChangeIndividual.Enabled = false;
                buttonChangeEntity.Enabled = false;
            }
        }

        public void updateTable()
        {
            DataTable dataC = daoC.getAll();
            DataTable dataEC = daoEC.getAll();
            DataTable dataIC = daoIC.getAll();
            dataC.Columns["customer_name"].ColumnName = "ФИО";
            dataC.Columns["email"].ColumnName = "E-mail";
            dataC.Columns["customer_tel_num"].ColumnName = "Номер телефона";
            dataC.Columns["customer_address"].ColumnName = "Фактический адрес";
            dataEC.Columns["entity_director_name"].ColumnName = "ФИО директора";
            dataEC.Columns["entity_company_name"].ColumnName = "Название компании";
            dataEC.Columns["customer_business_address"].ColumnName = "Юридический адрес";
            dataIC.Columns["customer_name"].ColumnName = "ФИО";
            dataGridViewCustomer.DataSource = dataC;
            dataGridViewEntityCustomer.DataSource = dataEC;
            dataGridViewIndividualCustomer.DataSource = dataIC;
        }

        private void buttonSearchCustomer_Click(object sender, EventArgs e)
        {
            string name = textBoxSearchCustomer.Text.ToString();
            DataTable dataC = daoC.searchByName(name);
            DataTable dataEC = daoEC.searchByName(name);
            DataTable dataIC = daoIC.searchByName(name);
            dataC.Columns["customer_name"].ColumnName = "ФИО";
            dataC.Columns["email"].ColumnName = "E-mail";
            dataC.Columns["customer_tel_num"].ColumnName = "Номер телефона";
            dataC.Columns["customer_address"].ColumnName = "Фактический адрес";
            dataEC.Columns["entity_director_name"].ColumnName = "ФИО директора";
            dataEC.Columns["entity_company_name"].ColumnName = "Название компании";
            dataEC.Columns["customer_business_address"].ColumnName = "Юридический адрес";
            dataIC.Columns["customer_name"].ColumnName = "ФИО";
            dataGridViewCustomer.DataSource = dataC;
            dataGridViewEntityCustomer.DataSource = dataEC;
            dataGridViewIndividualCustomer.DataSource = dataIC;
            if (dataC.Rows.Count > 1)
            {
                dataC.Columns["customer_name"].ColumnName = "ФИО";
                dataC.Columns["email"].ColumnName = "E-mail";
                dataC.Columns["customer_tel_num"].ColumnName = "Номер телефона";
                dataC.Columns["customer_address"].ColumnName = "Фактический адрес";
                dataEC.Columns["entity_director_name"].ColumnName = "ФИО директора";
                dataEC.Columns["entity_company_name"].ColumnName = "Название компании";
                dataEC.Columns["customer_business_address"].ColumnName = "Юридический адрес";
                dataIC.Columns["customer_name"].ColumnName = "ФИО";
                dataGridViewCustomer.DataSource = dataC;
                dataGridViewEntityCustomer.DataSource = dataEC;
                dataGridViewIndividualCustomer.DataSource = dataIC;
            }
            else MessageBox.Show("Ничего не найдено!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            textBoxSearchCustomer.Clear();
        }

        private void buttonDeleteCustomer_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить данные?", "Сообщение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    int rowNum = dataGridViewCustomer.CurrentCell.RowIndex;
                    string name = dataGridViewCustomer[0, rowNum].Value.ToString();
                    BankDetails details = daoBD.getBankByName(name);
                    if (details != null)
                    {
                        daoBD.deleteByName(name);
                    }
                    daoC.deleteByName(name);
                    updateTable();
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

        private void buttonAddEntity_Click(object sender, EventArgs e)
        {
            try
            {
                FormChangeEntity form = new FormChangeEntity("", "", "", "", "", "");
                form.ShowDialog();
                string name = form.textBoxName.Text.ToString();
                string email = form.textBoxEmail.Text.ToString();
                string tel = form.textBoxTel.Text.ToString();
                string adr = form.textBoxAdr.Text.ToString();
                string badr = form.textBoxBiAdr.Text.ToString();
                string comp = form.textBoxCompName.Text.ToString();
                Customer customer = new Customer(name, email, tel, adr);
                EntityCustomer entityCustomer = new EntityCustomer(name, email, tel, adr, badr, comp);
                daoC.addCustomer(customer);
                daoEC.addCustomer(entityCustomer);

                string acc = form.textBoxACC.Text.ToString();
                string inn = form.textBoxINN.Text.ToString();
                string rcbic = form.textBoxRCBIC.Text.ToString();
                string ogrn = form.textBoxOGRN.Text.ToString();
                string cacc = form.textBoxCorrACC.Text.ToString();
                string bank = form.textBoxBankName.Text.ToString();
                BankDetails details = new BankDetails(acc, null, name, inn, rcbic, ogrn, cacc, bank);
                daoBD.addBankDetails(details);
                updateTable();
            }
            catch (SqlException odbcEx)
            {
                MessageBox.Show("Имя заказчика не должно повторяться!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении!" + ex);
            }
        }

        private void buttonAddIndividual_Click(object sender, EventArgs e)
        {
            try
            {
                FormChangeIndividual form = new FormChangeIndividual("", "", "", "");
                form.ShowDialog();
                string name = form.textBoxName.Text.ToString();
                string email = form.textBoxEmail.Text.ToString();
                string tel = form.textBoxTel.Text.ToString();
                string adr = form.textBoxAdr.Text.ToString();
                Customer customer = new Customer(name, email, tel, adr);
                IndividualCustomer individualCustomer = new IndividualCustomer(name, email, tel, adr);
                daoC.addCustomer(customer);
                daoIC.addCustomer(individualCustomer);

                string acc = form.textBoxACC.Text.ToString();
                string inn = form.textBoxINN.Text.ToString();
                string rcbic = form.textBoxRCBIC.Text.ToString();
                string ogrn = form.textBoxOGRN.Text.ToString();
                string cacc = form.textBoxCorrACC.Text.ToString();
                string bank = form.textBoxBankName.Text.ToString();
                BankDetails details = new BankDetails(acc, null, name, inn, rcbic, ogrn, cacc, bank);
                daoBD.addBankDetails(details);

                updateTable();
            }
            catch (SqlException odbcEx)
            {
                MessageBox.Show("Имя заказчика не должно повторяться!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении!" + ex);
            }
        }

        private void buttonChangeEntity_Click(object sender, EventArgs e)
        {
            try
            {
                int rowNum = dataGridViewEntityCustomer.CurrentCell.RowIndex;
                string n = dataGridViewEntityCustomer[0, rowNum].Value.ToString();
                string c = dataGridViewEntityCustomer[1, rowNum].Value.ToString();
                string b = dataGridViewEntityCustomer[2, rowNum].Value.ToString();
                Customer cust = daoC.getCustomerByName(n);
                BankDetails details = daoBD.getBankByName(n);
                FormChangeEntity form = new FormChangeEntity(n, cust.CustomerEmail, cust.CustomerTel, cust.CustomerAddress, b, c);                
                form.ShowDialog();
                string name = form.textBoxName.Text.ToString();
                string email = form.textBoxEmail.Text.ToString();
                string tel = form.textBoxTel.Text.ToString();
                string adr = form.textBoxAdr.Text.ToString();
                string badr = form.textBoxBiAdr.Text.ToString();
                string comp = form.textBoxCompName.Text.ToString();
                Customer customer = new Customer(name, email, tel, adr);
                EntityCustomer entityCustomer = new EntityCustomer(name, email, tel, adr, badr, comp);
                daoC.updateCustomer(n, customer);
                daoEC.updateCustomer(n, entityCustomer);

                string acc = form.textBoxACC.Text.ToString();
                string inn = form.textBoxINN.Text.ToString();
                string rcbic = form.textBoxRCBIC.Text.ToString();
                string ogrn = form.textBoxOGRN.Text.ToString();
                string cacc = form.textBoxCorrACC.Text.ToString();
                string bank = form.textBoxBankName.Text.ToString();
                BankDetails det = new BankDetails(acc, null, name, inn, rcbic, ogrn, cacc, bank);
                if (details != null) daoBD.updateBankDetails(details.Acc, det);
                else daoBD.addBankDetails(det);
                updateTable();
            }
            catch (SqlException odbcEx)
            {
                MessageBox.Show("Имя заказчика не должно повторяться!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при изменении!" + ex);
            }
        }

        private void buttonChangeIndividual_Click(object sender, EventArgs e)
        {
            try
            {
                int rowNum = dataGridViewIndividualCustomer.CurrentCell.RowIndex;
                string n = dataGridViewIndividualCustomer[0, rowNum].Value.ToString();
                Customer cust = daoC.getCustomerByName(n);
                BankDetails details = daoBD.getBankByName(n);
                FormChangeIndividual form = new FormChangeIndividual(n, cust.CustomerEmail, cust.CustomerTel, cust.CustomerAddress); 
                form.ShowDialog();
                string name = form.textBoxName.Text.ToString();
                string email = form.textBoxEmail.Text.ToString();
                string tel = form.textBoxTel.Text.ToString();
                string adr = form.textBoxAdr.Text.ToString();
                Customer customer = new Customer(name, email, tel, adr);
                IndividualCustomer indCustomer = new IndividualCustomer(name, email, tel, adr);
                daoC.updateCustomer(n, customer);
                daoIC.updateCustomer(n, indCustomer);

                string acc = form.textBoxACC.Text.ToString();
                string inn = form.textBoxINN.Text.ToString();
                string rcbic = form.textBoxRCBIC.Text.ToString();
                string ogrn = form.textBoxOGRN.Text.ToString();
                string cacc = form.textBoxCorrACC.Text.ToString();
                string bank = form.textBoxBankName.Text.ToString();
                BankDetails det = new BankDetails(acc, null, name, inn, rcbic, ogrn, cacc, bank);
                if (details != null)
                    daoBD.updateBankDetails(details.Acc, det);
                else daoBD.addBankDetails(det);

                updateTable();
            }
            catch (SqlException odbcEx)
            {
                MessageBox.Show("Имя заказчика не должно повторяться!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при изменении!" + ex);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
