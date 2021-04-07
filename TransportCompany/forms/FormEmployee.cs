using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TransportCompany.DAO;
using TransportCompany.models;

namespace TransportCompany.forms
{
    public partial class FormEmployee : Form
    {
        DBUtil connect = new DBUtil();
        EmployeeDAO daoEmp = new EmployeeDAO();
        DriverDAO daoDr = new DriverDAO();
        OfficeEmployeeDAO daoOf = new OfficeEmployeeDAO();
        public FormEmployee()
        {
            InitializeComponent();
            connect.createConnection();
            updateTable();
        }
        public void updateTable()
        {
            DataTable dataEmp = daoEmp.getAll();
            DataTable dataDr = daoDr.getAll();
            DataTable dataOf = daoOf.getAll();
            dataEmp.Columns["employee_name"].ColumnName = "ФИО";
            dataEmp.Columns["position"].ColumnName = "Должность";
            dataEmp.Columns["employee_tel_num"].ColumnName = "Номер телефона";
            dataEmp.Columns["employee_address"].ColumnName = "Адрес";
            dataEmp.Columns["department_name"].ColumnName = "Наименование отдела";
            dataDr.Columns["driver_name"].ColumnName = "ФИО";
            dataDr.Columns["driving_experience"].ColumnName = "Водительский стаж";
            dataDr.Columns["license_category"].ColumnName = "Категория прав";
            dataOf.Columns["employee_name"].ColumnName = "ФИО";
            dataOf.Columns["spec_name"].ColumnName = "Специализация";
            dataGridViewEmployee.DataSource = dataEmp;
            dataGridViewDriver.DataSource = dataDr;
            dataGridViewOfficeEmployee.DataSource = dataOf;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void buttonDeleteStopType_Click(object sender, EventArgs e)
        {
            int rowNum = dataGridViewEmployee.CurrentCell.RowIndex;
            string name = dataGridViewEmployee[0, rowNum].Value.ToString();
            daoEmp.deleteByName(name);
            updateTable();
        }

        private void buttonChangeStopType_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddStopType_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewStopType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearchEmployee_Click(object sender, EventArgs e)
        {
            string name = textBoxSearchEmployee.Text.ToString();
            DataTable dataEmp = daoEmp.searchByName(name);
            DataTable dataDr = daoDr.searchByName(name);
            DataTable dataOf = daoOf.searchByName(name);
            dataEmp.Columns["employee_name"].ColumnName = "ФИО";
            dataEmp.Columns["position"].ColumnName = "Должность";
            dataEmp.Columns["employee_tel_num"].ColumnName = "Номер телефона";
            dataEmp.Columns["employee_address"].ColumnName = "Адрес";
            dataEmp.Columns["department_name"].ColumnName = "Наименование отдела";
            dataDr.Columns["driver_name"].ColumnName = "ФИО";
            dataDr.Columns["driving_experience"].ColumnName = "Водительский стаж";
            dataDr.Columns["license_category"].ColumnName = "Категория прав";
            dataOf.Columns["employee_name"].ColumnName = "ФИО";
            dataOf.Columns["spec_name"].ColumnName = "Специализация";
            dataGridViewEmployee.DataSource = dataEmp;
            dataGridViewDriver.DataSource = dataDr;
            dataGridViewOfficeEmployee.DataSource = dataOf;
            textBoxSearchEmployee.Clear();
        }

        private void dataGridViewDriver_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
