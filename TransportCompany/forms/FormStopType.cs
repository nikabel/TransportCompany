using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TransportCompany.DAO;
using TransportCompany.models;

namespace TransportCompany
{    public partial class StopTypeForm : Form
    {
        DBUtil connect= new DBUtil();
        StopTypeDAO daoST = new StopTypeDAO();
        DepartmentDAO daoDep = new DepartmentDAO();
        SpecializationDAO daoSpec = new SpecializationDAO();
        CargoTypeDAO daoCT = new CargoTypeDAO();
        TransportDAO daoTrans = new TransportDAO();
        TransportModelDAO daoTransModel = new TransportModelDAO();
        String directory;

        public StopTypeForm(string type)
        {
            InitializeComponent();
            connect.createConnection();
            directory = type;
            updateTable();
        }

        public void updateTable()
        {
            switch (directory)
            {
                case "StopType":
                    {
                        DataTable data = daoST.getAll();
                        data.Columns["stop_type_name"].ColumnName = "Наименование типа остановки";
                        data.Columns["stop_type_desc"].ColumnName = "Описание типа остановки";
                        dataGridViewStopType.DataSource = data;
                        break;
                    }
                case "Department":
                    {
                        DataTable data = daoDep.getAll();
                        data.Columns["department_name"].ColumnName = "Наименование отдела";
                        data.Columns["department_desc"].ColumnName = "Описание отдела";
                        dataGridViewStopType.DataSource = data;
                        break;
                    }
                case "CargoType":
                    {
                        DataTable data = daoCT.getAll();
                        data.Columns["cargo_type_name"].ColumnName = "Наименование типа груза";
                        data.Columns["cargo_type_desc"].ColumnName = "Описание типа груза";
                        dataGridViewStopType.DataSource = data;
                        break;
                    }
                case "Specialization":
                    {
                        DataTable data = daoSpec.getAll();
                        data.Columns["spec_name"].ColumnName = "Наименование специализации";
                        data.Columns["spec_desc"].ColumnName = "Описание специализации";
                        dataGridViewStopType.DataSource = data;
                        break;
                    }
                case "Transport":
                    {
                        DataTable data = daoTrans.getAll();
                        data.Columns["license_plate"].ColumnName = "Гос. номер транспорта";
                        data.Columns["driver_name"].ColumnName = "ФИО водителя";
                        data.Columns["model_name"].ColumnName = "Наименование модели";
                        dataGridViewStopType.DataSource = data;
                        break;
                    }
                case "TransportModel":
                    {
                        DataTable data = daoTransModel.getAll();
                        data.Columns["model_name"].ColumnName = "Наименование модели";
                        data.Columns["mark_name"].ColumnName = "Наименование марки";
                        data.Columns["model_desc"].ColumnName = "Характеристика модели";
                        data.Columns["model_count"].ColumnName = "Количество в автопарке";
                        dataGridViewStopType.DataSource = data;
                        break;
                    }
            }
            
        }         

        private void StopTypeForm_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonAddStopType_Click(object sender, EventArgs e)
        {
            try
            {
                FormChangeStopType form = new FormChangeStopType("");
                form.ShowDialog();
                string name = form.textBoxUpdateStopTypeName.Text.ToString();
                string desc = form.textBoxUpdateStopTypeDesc.Text.ToString();
                StopType stopType = new StopType(name, desc);
                daoST.addType(stopType);
                updateTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Вид остановки не должен повторяться!"+ex);
            }

        }

        private void buttonDeleteStopType_Click(object sender, EventArgs e)
        {
            int rowNum = dataGridViewStopType.CurrentCell.RowIndex;
            string name = dataGridViewStopType[0, rowNum].Value.ToString();
            daoST.deleteByName(name);
            updateTable();
        }


        private void buttonSearchTransportType_Click(object sender, EventArgs e)
        {
            string name = textBoxSearchStopType.Text.ToString();
            DataTable data = daoST.searchByName(name);
            data.Columns["stop_type_name"].ColumnName = "Наименование типа остановки";
            data.Columns["stop_type_desc"].ColumnName = "Описание типа остановки";
            dataGridViewStopType.DataSource = data;
            textBoxSearchStopType.Clear();
        }

        private void buttonChangeStopType_Click(object sender, EventArgs e)
        {
            try
            {
                int rowNum = dataGridViewStopType.CurrentCell.RowIndex;
                string n = dataGridViewStopType[0, rowNum].Value.ToString();
                FormChangeStopType form = new FormChangeStopType(n);
                form.ShowDialog();
                string name = form.textBoxUpdateStopTypeName.Text.ToString();
                string desc = form.textBoxUpdateStopTypeDesc.Text.ToString();
                StopType stopType = new StopType(name, desc);
                daoST.updateType(n, stopType);
                updateTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Вид остановки не должен повторяться!"+ex);
            }
        }
    }
}
