using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TransportCompany.DAO;
using TransportCompany.models;
using TransportCompany.forms;

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
            switch (directory)
            {
                case "StopType":
                    {
                        this.Text = "Информация о видах остановок";
                        labelSearch.Text = "Вид остановки";
                        groupBox3.Text= "Поиск информации о видах остановок";
                        break;
                    }
                case "Department":
                    {
                        this.Text = "Информация об отделах";
                        labelSearch.Text = "Наименование отдела";
                        groupBox3.Text = "Поиск информация об отделах";
                        break;
                    }
                case "CargoType":
                    {
                        this.Text = "Информация о типах грузов";
                        labelSearch.Text = "Тип груза";
                        groupBox3.Text = "Поиск информации о типах грузов";
                        break;
                    }
                case "Specialization":
                    {
                        this.Text = "Информация о специализациях";
                        labelSearch.Text = "СпециализациЯ";
                        groupBox3.Text = "Поиск информации о специализациях";
                        break;
                    }
                case "Transport":
                    {
                        this.Text = "Информация о транспорте";
                        labelSearch.Text = "Номер транспорта";
                        groupBox3.Text = "Поиск информации о транспорте";
                        break;
                    }
                case "TransportModel":
                    {
                        this.Text = "Информация о моделях транспорта";
                        labelSearch.Text = "Наименование модели";
                        groupBox3.Text = "Поиск информация о моделях транспорта";
                        break;
                    }
            }
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
                        data.Columns["company_name"].ColumnName = "Наименование компании";
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
            switch (directory)
            {
                case "StopType":
                    {
                        try
                        {
                            FormChangeStopType form = new FormChangeStopType("", "");
                            form.ShowDialog();
                            string name = form.textBoxUpdateStopTypeName.Text.ToString();
                            string desc = form.textBoxUpdateStopTypeDesc.Text.ToString();
                            StopType stopType = new StopType(name, desc);
                            daoST.addType(stopType);
                            updateTable();
                            break;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Вид остановки не должен повторяться!" + ex);
                            break;
                        }
                    }
                case "Department":
                    {
                        try
                        {
                            FormChangeDepartment form = new FormChangeDepartment("", "", "");
                            form.ShowDialog();
                            string name = form.textBoxDepName.Text.ToString();
                            string compName = form.textBoxCompName.Text.ToString();
                            string desc = form.textBoxDepDesc.Text.ToString();
                            Department department = new Department(name, desc, compName);
                            daoDep.addType(department);
                            updateTable();
                            break;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Отдел не должен повторяться!" + ex);
                            break;
                        }
                    }
                case "CargoType":
                    {
                        try
                        {
                            FormCargoType form = new FormCargoType("", "");
                            form.ShowDialog();
                            string name = form.textBoxCargoTypeName.Text.ToString();
                            string desc = form.textBoxCargoTypeDesc.Text.ToString();
                            CargoType cargoType = new CargoType(name, desc);
                            daoCT.addType(cargoType);
                            updateTable();
                            break;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Вид груза не должен повторяться!" + ex);
                            break;
                        }
                    }
                case "Specialization":
                    {
                        try
                        {
                            FormChangeSpec form = new FormChangeSpec("", "");
                            form.ShowDialog();
                            string name = form.textBoxSpecName.Text.ToString();
                            string desc = form.textBoxSpecDesc.Text.ToString();
                            Specialization spec = new Specialization(name, desc);
                            daoSpec.addType(spec);
                            updateTable();
                            break;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Специализация не должна повторяться!" + ex);
                            break;
                        }
                    }
                case "TransportModel":
                    {
                        try
                        {
                            FormChangeTransModel form = new FormChangeTransModel("", "", "", "");
                            form.ShowDialog();
                            string modelName = form.textBoxModelName.Text.ToString();
                            string markName = form.textBoxMarkName.Text.ToString();
                            string desc = form.textBoxModelDesc.Text.ToString();
                            string count = form.textBoxModelCount.Text.ToString();
                            TransportModel model;
                            if (Int32.TryParse(count, out int c))
                            {
                                model = new TransportModel(modelName, markName, desc, c);
                                daoTransModel.addType(model);
                                updateTable();
                            }
                            else { 
                                MessageBox.Show("Неверно введено количество моделей в автопарке!");
                                break;
                            }
                            break;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Модел не должна повторяться!" + ex);
                            break;
                        }
                    }
            }

        }

        private void buttonDeleteStopType_Click(object sender, EventArgs e)
        {
            switch (directory)
            {
                case "StopType":
                    {
                        int rowNum = dataGridViewStopType.CurrentCell.RowIndex;
                        string name = dataGridViewStopType[0, rowNum].Value.ToString();
                        daoST.deleteByName(name);
                        updateTable();
                        break;
                    }
                case "Department":
                    {
                        int rowNum = dataGridViewStopType.CurrentCell.RowIndex;
                        string name = dataGridViewStopType[0, rowNum].Value.ToString();
                        daoDep.deleteByName(name);
                        updateTable();
                        break;
                    }
                case "CargoType":
                    {
                        DataTable data = daoCT.getAll();
                        int rowNum = dataGridViewStopType.CurrentCell.RowIndex;
                        string name = dataGridViewStopType[0, rowNum].Value.ToString();
                        daoCT.deleteByName(name);
                        updateTable();
                        break;
                    }
                case "Specialization":
                    {
                        int rowNum = dataGridViewStopType.CurrentCell.RowIndex;
                        string name = dataGridViewStopType[0, rowNum].Value.ToString();
                        daoSpec.deleteByName(name);
                        updateTable();
                        break;
                    }
                case "Transport":
                    {
                        int rowNum = dataGridViewStopType.CurrentCell.RowIndex;
                        string name = dataGridViewStopType[0, rowNum].Value.ToString();
                        daoTrans.deleteByName(name);
                        updateTable();
                        break;
                    }
                case "TransportModel":
                    {
                        int rowNum = dataGridViewStopType.CurrentCell.RowIndex;
                        string name = dataGridViewStopType[0, rowNum].Value.ToString();
                        daoTransModel.deleteByName(name);
                        updateTable();
                        break;
                    }
            }
        }


        private void buttonSearchTransportType_Click(object sender, EventArgs e)
        {
            switch (directory)
            {
                case "StopType":
                    {
                        string name = textBoxSearchStopType.Text.ToString();
                        DataTable data = daoST.searchByName(name);
                        data.Columns["stop_type_name"].ColumnName = "Наименование типа остановки";
                        data.Columns["stop_type_desc"].ColumnName = "Описание типа остановки";
                        dataGridViewStopType.DataSource = data;
                        textBoxSearchStopType.Clear();
                        break;
                    }
                case "Department":
                    {
                        string name = textBoxSearchStopType.Text.ToString();
                        DataTable data = daoDep.searchByName(name);
                        data.Columns["department_name"].ColumnName = "Наименование отдела";
                        data.Columns["company_name"].ColumnName = "Наименование компании";
                        data.Columns["department_desc"].ColumnName = "Описание отдела";
                        dataGridViewStopType.DataSource = data;
                        break;
                    }
                case "CargoType":
                    {
                        string name = textBoxSearchStopType.Text.ToString();
                        DataTable data = daoCT.searchByName(name);
                        data.Columns["cargo_type_name"].ColumnName = "Наименование типа груза";
                        data.Columns["cargo_type_desc"].ColumnName = "Описание типа груза";
                        dataGridViewStopType.DataSource = data;
                        break;
                    }
                case "Specialization":
                    {
                        string name = textBoxSearchStopType.Text.ToString();
                        DataTable data = daoSpec.searchByName(name);
                        data.Columns["spec_name"].ColumnName = "Наименование специализации";
                        data.Columns["spec_desc"].ColumnName = "Описание специализации";
                        dataGridViewStopType.DataSource = data;
                        break;
                    }
                case "Transport":
                    {
                        string name = textBoxSearchStopType.Text.ToString();
                        DataTable data = daoTrans.searchByName(name);
                        data.Columns["license_plate"].ColumnName = "Гос. номер транспорта";
                        data.Columns["driver_name"].ColumnName = "ФИО водителя";
                        data.Columns["model_name"].ColumnName = "Наименование модели";
                        dataGridViewStopType.DataSource = data;
                        break;
                    }
                case "TransportModel":
                    {
                        string name = textBoxSearchStopType.Text.ToString();
                        DataTable data = daoTransModel.searchByName(name);
                        data.Columns["model_name"].ColumnName = "Наименование модели";
                        data.Columns["mark_name"].ColumnName = "Наименование марки";
                        data.Columns["model_desc"].ColumnName = "Характеристика модели";
                        data.Columns["model_count"].ColumnName = "Количество в автопарке";
                        dataGridViewStopType.DataSource = data;
                        break;
                    }
            }
        }

        private void buttonChangeStopType_Click(object sender, EventArgs e)
        {
            switch (directory)
            {
                case "StopType":
                    {
                        try
                        {
                            int rowNum = dataGridViewStopType.CurrentCell.RowIndex;
                            string n = dataGridViewStopType[0, rowNum].Value.ToString();
                            string d = dataGridViewStopType[1, rowNum].Value.ToString();
                            FormChangeStopType form = new FormChangeStopType(n, d);
                            form.ShowDialog();
                            string name = form.textBoxUpdateStopTypeName.Text.ToString();
                            string desc = form.textBoxUpdateStopTypeDesc.Text.ToString();
                            StopType stopType = new StopType(name, desc);
                            daoST.updateType(n, stopType);
                            updateTable();
                            break;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Вид остановки не должен повторяться!" + ex);
                            break;
                        }
                    }
                case "Department":
                    {
                        try
                        {
                            int rowNum = dataGridViewStopType.CurrentCell.RowIndex;
                            string n = dataGridViewStopType[0, rowNum].Value.ToString();
                            string cn = dataGridViewStopType[1, rowNum].Value.ToString();
                            string d = dataGridViewStopType[2, rowNum].Value.ToString();
                            FormChangeDepartment form = new FormChangeDepartment(n, cn, d);
                            form.ShowDialog();
                            string name = form.textBoxDepName.Text.ToString();
                            string compName = form.textBoxCompName.Text.ToString();
                            string desc = form.textBoxDepDesc.Text.ToString();
                            Department department = new Department(name, desc, compName);
                            daoDep.updateType(n, department);
                            updateTable();
                            break;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Отдел не должен повторяться!" + ex);
                            break;
                        }
                    }
                case "CargoType":
                    {
                        try
                        {
                            int rowNum = dataGridViewStopType.CurrentCell.RowIndex;
                            string n = dataGridViewStopType[0, rowNum].Value.ToString();
                            string d = dataGridViewStopType[1, rowNum].Value.ToString();
                            FormCargoType form = new FormCargoType(n, d);
                            form.ShowDialog();
                            string name = form.textBoxCargoTypeName.Text.ToString();
                            string desc = form.textBoxCargoTypeDesc.Text.ToString();
                            CargoType cargoType = new CargoType(name, desc);
                            daoCT.updateType(n, cargoType);
                            updateTable();
                            break;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Вид груза не должен повторяться!" + ex);
                            break;
                        }
                    }
                case "Specialization":
                    {
                        try
                        {
                            int rowNum = dataGridViewStopType.CurrentCell.RowIndex;
                            string n = dataGridViewStopType[0, rowNum].Value.ToString();
                            string d = dataGridViewStopType[1, rowNum].Value.ToString();
                            FormChangeSpec form = new FormChangeSpec(n, d);
                            form.ShowDialog();
                            string name = form.textBoxSpecName.Text.ToString();
                            string desc = form.textBoxSpecDesc.Text.ToString();
                            Specialization spec = new Specialization(name, desc);
                            daoSpec.updateType(n, spec);
                            updateTable();
                            break;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Специализация не должна повторяться!" + ex);
                            break;
                        }
                    }
                case "TransportModel":
                    {
                        try
                        {
                            int rowNum = dataGridViewStopType.CurrentCell.RowIndex;
                            string n = dataGridViewStopType[0, rowNum].Value.ToString();
                            string mn = dataGridViewStopType[1, rowNum].Value.ToString();
                            string d = dataGridViewStopType[2, rowNum].Value.ToString();
                            string mc = dataGridViewStopType[3, rowNum].Value.ToString();
                            FormChangeTransModel form = new FormChangeTransModel(n, mn, d, mc);
                            form.ShowDialog();
                            string modelName = form.textBoxModelName.Text.ToString();
                            string markName = form.textBoxMarkName.Text.ToString();
                            string desc = form.textBoxModelDesc.Text.ToString();
                            string count = form.textBoxModelCount.Text.ToString();
                            TransportModel model;
                            if (Int32.TryParse(count, out int c))
                            {
                                model = new TransportModel(modelName, markName, desc, c);
                                daoTransModel.updateType(n, model);
                                updateTable();
                            }
                            else
                            {
                                MessageBox.Show("Неверно введено количество моделей в автопарке!");
                                break;
                            }
                            break;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Модел не должна повторяться!" + ex);
                            break;
                        }
                    }
            }
                    
        }
    }
}
