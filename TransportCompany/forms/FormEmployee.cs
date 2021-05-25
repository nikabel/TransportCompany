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
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить данные?", "Сообщение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    int rowNum = dataGridViewEmployee.CurrentCell.RowIndex;
                    string name = dataGridViewEmployee[0, rowNum].Value.ToString();
                    daoEmp.deleteByName(name);
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

        private void buttonChangeStopType_Click(object sender, EventArgs e)
        {
            try
            {
                int rowNum = dataGridViewOfficeEmployee.CurrentCell.RowIndex;
                string n = dataGridViewOfficeEmployee[0, rowNum].Value.ToString();
                string s = dataGridViewOfficeEmployee[1, rowNum].Value.ToString();
                Employee emp = daoEmp.getEmployeeByName(n);
                FormChangeEmployee form = new FormChangeEmployee(n, emp.EmployeePos, emp.EmployeeTel, emp.EmployeeAddress, s, emp.DepartmentName);
                form.ShowDialog();
                string name = form.textBoxName.Text.ToString();
                string pos = form.textBoxPos.Text.ToString();
                string tel = form.textBoxTel.Text.ToString();
                string adr = form.textBoxAddress.Text.ToString();
                string spec = form.comboBoxSpec.SelectedItem.ToString();
                string dep = form.comboBoxDep.SelectedItem.ToString();
                Employee newEmp = new Employee(name, dep, pos, tel, adr);
                OfficeEmployee officeEmployee = new OfficeEmployee(name, dep, pos, tel, adr, spec);
                daoEmp.updateEmployee(n, newEmp);
                daoOf.updateEmployee(n, officeEmployee);
                updateTable();
            }
            catch (SqlException odbcEx)
            {
                MessageBox.Show("Имя сотрудника не должно повторяться!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при изменении!" + ex);
            }
        }

        private void buttonAddStopType_Click(object sender, EventArgs e)
        {
            try
            {
                FormChangeEmployee form = new FormChangeEmployee("", "", "", "", "", "");
                form.ShowDialog();
                string name = form.textBoxName.Text.ToString();
                string pos = form.textBoxPos.Text.ToString();
                string tel = form.textBoxTel.Text.ToString();
                string adr = form.textBoxAddress.Text.ToString();
                string spec = form.comboBoxSpec.SelectedItem.ToString();
                string dep = form.comboBoxDep.SelectedItem.ToString();
                Employee emp = new Employee(name, dep, pos, tel, adr);
                OfficeEmployee officeEmployee = new OfficeEmployee(name, dep, pos, tel, adr, spec);
                daoEmp.addEmployee(emp);
                daoOf.addEmployee(officeEmployee);
                updateTable();
            }
            catch (SqlException odbcEx)
            {
                MessageBox.Show("Имя сотрудника не должно повторяться!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении!" + ex);
            }
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
            if (dataEmp.Rows.Count > 1)
            {
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
            textBoxSearchEmployee.Clear();
        }

        private void dataGridViewDriver_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddDriver_Click(object sender, EventArgs e)
        {
            try
            {
                FormChangeDriver form = new FormChangeDriver("", "", "", "", "", "", "");
                form.ShowDialog();
                string name = form.textBoxName.Text.ToString();
                string pos = form.textBoxPos.Text.ToString();
                string tel = form.textBoxTel.Text.ToString();
                string adr = form.textBoxAddress.Text.ToString();
                string cat = form.textBoxLicense.Text.ToString();
                string exp = form.textBoxExp.Text.ToString();
                string dep = form.comboBoxDep.SelectedItem.ToString();
                Employee emp = new Employee(name, dep, pos, tel, adr);
                Driver driver;
                driver = new Driver(name, dep, pos, tel, adr, Int32.Parse(exp), cat);
                daoEmp.addEmployee(emp);
                daoDr.addDriver(driver);
                updateTable();
            }
            catch (SqlException odbcEx)
            {
                MessageBox.Show("Имя водителя не должно повторяться!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении!" + ex);
            }
        }

        private void buttonChangeDriver_Click(object sender, EventArgs e)
        {
            try
            {
                int rowNum = dataGridViewOfficeEmployee.CurrentCell.RowIndex;
                string n = dataGridViewDriver[0, rowNum].Value.ToString();
                string experience = dataGridViewDriver[1, rowNum].Value.ToString();
                string c = dataGridViewDriver[2, rowNum].Value.ToString();
                Employee emp = daoEmp.getEmployeeByName(n);
                FormChangeDriver form = new FormChangeDriver(n, emp.EmployeePos, emp.EmployeeTel, emp.EmployeeAddress, experience, c, emp.DepartmentName);
                form.ShowDialog();
                string name = form.textBoxName.Text.ToString();
                string pos = form.textBoxPos.Text.ToString();
                string tel = form.textBoxTel.Text.ToString();
                string adr = form.textBoxAddress.Text.ToString();
                string cat = form.textBoxLicense.Text.ToString();
                string exp = form.textBoxExp.Text.ToString();
                string dep = form.comboBoxDep.SelectedItem.ToString();
                Employee employee = new Employee(name, dep, pos, tel, adr);
                Driver driver;
                driver = new Driver(name, dep, pos, tel, adr, Int32.Parse(exp), cat);
                daoEmp.updateEmployee(n, employee);
                daoDr.updateEmployee(n, driver);
                updateTable();
            }
            catch (SqlException odbcEx)
            {
                MessageBox.Show("Имя водителя не должно повторяться!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при изменении!" + ex);
            }
        }
    }
}
