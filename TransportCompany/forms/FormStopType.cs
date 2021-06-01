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
        OperationDAO daoST = new OperationDAO();
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
                case "Operation":
                    {
                        this.Text = "Информация об операциях";
                        labelSearch.Text = "Наименование операции";
                        groupBox3.Text= "Поиск информации об операциях";
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
                        labelSearch.Text = "Специализация";
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
                case "Operation":
                    {
                        DataTable data = daoST.getAll();
                        data.Columns["operation_name"].ColumnName = "Наименование операции";
                        dataGridViewStopType.DataSource = data;
                        break;
                    }
                case "Department":
                    {
                        DataTable data = daoDep.getAll();
                        data.Columns["department_name"].ColumnName = "Наименование отдела";
                        data.Columns["company_name"].ColumnName = "Наименование компании";
                        dataGridViewStopType.DataSource = data;
                        break;
                    }
                case "CargoType":
                    {
                        DataTable data = daoCT.getAll();
                        data.Columns["cargo_type_name"].ColumnName = "Наименование типа груза";
                        dataGridViewStopType.DataSource = data;
                        break;
                    }
                case "Specialization":
                    {
                        DataTable data = daoSpec.getAll();
                        data.Columns["spec_name"].ColumnName = "Наименование специализации";
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
                case "Operation":
                    {
                        try
                        {
                            FormChangeStopType form = new FormChangeStopType("");
                            form.ShowDialog();
                            string name = form.textBoxUpdateStopTypeName.Text.ToString();
                            Operation stopType = new Operation(name);
                            daoST.addType(stopType);

                        }
                        catch (SqlException odbcEx)
                        {
                            MessageBox.Show("Наименование операции не должно повторяться!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка при добавлении!" + ex);
                        }
                        break;
                    }
                case "Department":
                    {
                        try
                        {
                            FormChangeDepartment form = new FormChangeDepartment("", "ООО \"СДК-Магистраль\"");
                            form.ShowDialog();
                            string name = form.textBoxDepName.Text.ToString();
                            string compName = form.textBoxCompName.Text.ToString();
                            Department department = new Department(name, compName);
                            daoDep.addType(department);
                        }
                        catch (SqlException odbcEx)
                        {
                            MessageBox.Show("Наименование отдела не должно повторяться!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка при добавлении!" + ex);
                        }
                        break;
                    }
                case "CargoType":
                    {
                        try
                        {
                            FormCargoType form = new FormCargoType("");
                            form.ShowDialog();
                            string name = form.textBoxCargoTypeName.Text.ToString();
                            CargoType cargoType = new CargoType(name);
                            daoCT.addType(cargoType);
                        }
                        catch (SqlException odbcEx)
                        {
                            MessageBox.Show("Наименование вида груза не должно повторяться!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка при добавлении!" + ex);
                        }
                        break;
                    }
                case "Specialization":
                    {
                        try
                        {
                            FormChangeSpec form = new FormChangeSpec("");
                            form.ShowDialog();
                            string name = form.textBoxSpecName.Text.ToString();
                            Specialization spec = new Specialization(name);
                            daoSpec.addType(spec);
                        }
                        catch (SqlException odbcEx)
                        {
                            MessageBox.Show("Наименование специализация не должно повторяться!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка при добавлении!" + ex);
                        }
                        break;
                    }
                case "Transport":
                    {
                        try
                        {
                            FormChangeTrans form = new FormChangeTrans("", "", "");
                            form.ShowDialog();
                            string num = form.textBoxLicensePlate.Text.ToString();
                            string driver = form.comboBoxDrivers.SelectedItem.ToString();
                            string model = form.comboBoxModels.SelectedItem.ToString();
                            Transport trans = new Transport(model, driver, num);
                            daoTrans.addType(trans);
                        }
                        catch (SqlException odbcEx)
                        {
                            MessageBox.Show("Транспортный номер не должен повторяться!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка при добавлении!" + ex);
                        }
                        break;
                    }
                case "TransportModel":
                    {
                        try
                        {
                            FormChangeTransModel form = new FormChangeTransModel("", "", "");
                            form.ShowDialog();
                            string modelName = form.textBoxModelName.Text.ToString();
                            string markName = form.textBoxMarkName.Text.ToString();
                            string count = form.textBoxModelCount.Text.ToString();
                            TransportModel model;
                            if (Int32.TryParse(count, out int c))
                            {
                                model = new TransportModel(modelName, markName, c);
                                daoTransModel.addType(model);
                            }
                            else
                            {
                                MessageBox.Show("Неверно введено количество моделей в автопарке!");
                            }
                        }
                        catch (SqlException odbcEx)
                        {
                            MessageBox.Show("Модель не должна повторяться!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка при добавлении!" + ex);
                        }
                        break;
                    }
            }
            updateTable();

        }

        private void buttonDeleteStopType_Click(object sender, EventArgs e)
        {
           DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить данные?", "Сообщение", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                switch (directory)
                {
                    case "Operation":
                        {
                            try
                            {
                                int rowNum = dataGridViewStopType.CurrentCell.RowIndex;
                                string name = dataGridViewStopType[0, rowNum].Value.ToString();
                                daoST.deleteByName(name);
                            }
                            catch (SqlException odbcEx)
                            {
                                MessageBox.Show("Невозможно удалить данные, так как они используются!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Ошибка при удалении!" + ex);
                            }
                            break;
                        }
                    case "Department":
                        {
                            try
                            {
                                int rowNum = dataGridViewStopType.CurrentCell.RowIndex;
                                string name = dataGridViewStopType[0, rowNum].Value.ToString();
                                daoDep.deleteByName(name);
                            }
                            catch (SqlException odbcEx)
                            {
                                MessageBox.Show("Невозможно удалить данные, так как они используются!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Ошибка при удалении!" + ex);
                            }
                            break;
                        }
                    case "CargoType":
                        {
                            try
                            {
                                int rowNum = dataGridViewStopType.CurrentCell.RowIndex;
                                string name = dataGridViewStopType[0, rowNum].Value.ToString();
                                daoCT.deleteByName(name);
                            }
                            catch (SqlException odbcEx)
                            {
                                MessageBox.Show("Невозможно удалить данные, так как они используются!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Ошибка при удалении!" + ex);
                            }
                            break;
                        }
                    case "Specialization":
                        {
                            try
                            {
                                int rowNum = dataGridViewStopType.CurrentCell.RowIndex;
                                string name = dataGridViewStopType[0, rowNum].Value.ToString();
                                daoSpec.deleteByName(name);
                            }
                            catch (SqlException odbcEx)
                            {
                                MessageBox.Show("Невозможно удалить данные, так как они используются!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Ошибка при удалении!" + ex);
                            }
                            break;
                        }
                    case "Transport":
                        {
                            try
                            {
                                int rowNum = dataGridViewStopType.CurrentCell.RowIndex;
                                string name = dataGridViewStopType[0, rowNum].Value.ToString();
                                daoTrans.deleteByName(name);
                            }
                            catch (SqlException odbcEx)
                            {
                                MessageBox.Show("Невозможно удалить данные, так как они используются!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Ошибка при удалении!" + ex);
                            }
                            break;
                        }
                    case "TransportModel":
                        {
                            try
                            {
                                int rowNum = dataGridViewStopType.CurrentCell.RowIndex;
                                string name = dataGridViewStopType[0, rowNum].Value.ToString();
                                daoTransModel.deleteByName(name);
                            }
                            catch (SqlException odbcEx)
                            {
                                MessageBox.Show("Невозможно удалить данные, так как они используются!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Ошибка при удалении!" + ex);
                            }
                            break;
                        }
                }
                updateTable();
            }
        }


        private void buttonSearchTransportType_Click(object sender, EventArgs e)
        {
            switch (directory)
            {
                case "Operation":
                    {
                        string name = textBoxSearchStopType.Text.ToString();
                        DataTable data = daoST.searchByName(name);
                        if (data.Rows.Count>1)
                        {
                            data.Columns["operation_name"].ColumnName = "Наименование операции";
                            dataGridViewStopType.DataSource = data;
                        }
                        else MessageBox.Show("Ничего не найдено!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        textBoxSearchStopType.Clear();
                        break;
                    }
                case "Department":
                    {
                        string name = textBoxSearchStopType.Text.ToString();
                        DataTable data = daoDep.searchByName(name);
                        if (data.Rows.Count > 1)
                        {
                            data.Columns["department_name"].ColumnName = "Наименование отдела";
                            data.Columns["company_name"].ColumnName = "Наименование компании";
                            dataGridViewStopType.DataSource = data;
                        }
                        else MessageBox.Show("Ничего не найдено!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        textBoxSearchStopType.Clear();
                        break;
                    }
                case "CargoType":
                    {
                        string name = textBoxSearchStopType.Text.ToString();
                        DataTable data = daoCT.searchByName(name);
                        if (data.Rows.Count > 1)
                        {
                            data.Columns["cargo_type_name"].ColumnName = "Наименование типа груза";
                            dataGridViewStopType.DataSource = data;
                        }
                        else MessageBox.Show("Ничего не найдено!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        textBoxSearchStopType.Clear();
                        break;
                    }
                case "Specialization":
                    {
                        string name = textBoxSearchStopType.Text.ToString();
                        DataTable data = daoSpec.searchByName(name);
                        if (data.Rows.Count > 1)
                        {
                            data.Columns["spec_name"].ColumnName = "Наименование специализации";
                            dataGridViewStopType.DataSource = data;
                        }
                        else MessageBox.Show("Ничего не найдено!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        textBoxSearchStopType.Clear(); 
                        break;
                    }
                case "Transport":
                    {
                        string name = textBoxSearchStopType.Text.ToString();
                        DataTable data = daoTrans.searchByName(name);
                        if (data.Rows.Count > 1)
                        {
                            data.Columns["license_plate"].ColumnName = "Гос. номер транспорта";
                            data.Columns["driver_name"].ColumnName = "ФИО водителя";
                            data.Columns["model_name"].ColumnName = "Наименование модели";
                            dataGridViewStopType.DataSource = data;
                        }
                        else MessageBox.Show("Ничего не найдено!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        textBoxSearchStopType.Clear();
                        break;
                    }
                case "TransportModel":
                    {
                        string name = textBoxSearchStopType.Text.ToString();
                        DataTable data = daoTransModel.searchByName(name);
                        if (data.Rows.Count > 1)
                        {
                            data.Columns["model_name"].ColumnName = "Наименование модели";
                            data.Columns["mark_name"].ColumnName = "Наименование марки";
                            data.Columns["model_count"].ColumnName = "Количество в автопарке";
                            dataGridViewStopType.DataSource = data;
                        }
                        else MessageBox.Show("Ничего не найдено!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        textBoxSearchStopType.Clear();
                        break;
                    }
            }
        }

        private void buttonChangeStopType_Click(object sender, EventArgs e)
        {
            switch (directory)
            {
                case "Operation":
                    {
                        try
                        {
                            int rowNum = dataGridViewStopType.CurrentCell.RowIndex;
                            string n = dataGridViewStopType[0, rowNum].Value.ToString();
                            FormChangeStopType form = new FormChangeStopType(n);
                            form.ShowDialog();
                            string name = form.textBoxUpdateStopTypeName.Text.ToString();
                            Operation stopType = new Operation(name);
                            daoST.updateType(n, stopType);
                        }
                        catch (SqlException odbcEx)
                        {
                            MessageBox.Show("Наименование операции не должно повторяться!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка при изменении!" + ex);
                        }
                        break;
                    }
                case "Department":
                    {
                        try
                        {
                            int rowNum = dataGridViewStopType.CurrentCell.RowIndex;
                            string n = dataGridViewStopType[0, rowNum].Value.ToString();
                            string cn = dataGridViewStopType[1, rowNum].Value.ToString();
                            FormChangeDepartment form = new FormChangeDepartment(n, cn);
                            form.ShowDialog();
                            string name = form.textBoxDepName.Text.ToString();
                            string compName = form.textBoxCompName.Text.ToString();
                            Department department = new Department(name, compName);
                            daoDep.updateType(n, department);
                        }
                        catch (SqlException odbcEx)
                        {
                            MessageBox.Show("Наименование отдела не должно повторяться!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка при изменении!" + ex);
                        }
                        break;
                    }
                case "CargoType":
                    {
                        try
                        {
                            int rowNum = dataGridViewStopType.CurrentCell.RowIndex;
                            string n = dataGridViewStopType[0, rowNum].Value.ToString();
                            FormCargoType form = new FormCargoType(n);
                            form.ShowDialog();
                            string name = form.textBoxCargoTypeName.Text.ToString();
                            CargoType cargoType = new CargoType(name);
                            daoCT.updateType(n, cargoType);
                        }
                        catch (SqlException odbcEx)
                        {
                            MessageBox.Show("Наименование вида груза не должно повторяться!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка при изменении!" + ex);
                        }
                        break;
                    }
                case "Specialization":
                    {
                        try
                        {
                            int rowNum = dataGridViewStopType.CurrentCell.RowIndex;
                            string n = dataGridViewStopType[0, rowNum].Value.ToString();
                            FormChangeSpec form = new FormChangeSpec(n);
                            form.ShowDialog();
                            string name = form.textBoxSpecName.Text.ToString();
                            Specialization spec = new Specialization(name);
                            daoSpec.updateType(n, spec);
                        }
                        catch (SqlException odbcEx)
                        {
                            MessageBox.Show("Наименование специализации не должно повторяться!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка при изменении!" + ex);
                        }
                        break;
                    }
                case "Transport":
                    {
                        try
                        {
                            int rowNum = dataGridViewStopType.CurrentCell.RowIndex;
                            string n = dataGridViewStopType[0, rowNum].Value.ToString();
                            string d = dataGridViewStopType[1, rowNum].Value.ToString();
                            string m = dataGridViewStopType[2, rowNum].Value.ToString();
                            FormChangeTrans form = new FormChangeTrans(n, d, m);
                            form.ShowDialog();
                            string num = form.textBoxLicensePlate.Text.ToString();
                            string driver = form.comboBoxDrivers.SelectedItem.ToString();
                            string model = form.comboBoxModels.SelectedItem.ToString();
                            Transport trans = new Transport(num, driver, model);
                            daoTrans.updateType(n, trans);
                        }
                        catch (SqlException odbcEx)
                        {
                            MessageBox.Show("Транспортный номер не должно повторяться!" + odbcEx, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка при изменении!" + ex);
                        }
                        break;
                    }
                case "TransportModel":
                    {
                        try
                        {
                            int rowNum = dataGridViewStopType.CurrentCell.RowIndex;
                            string n = dataGridViewStopType[0, rowNum].Value.ToString();
                            string mn = dataGridViewStopType[1, rowNum].Value.ToString();
                            string mc = dataGridViewStopType[2, rowNum].Value.ToString();
                            FormChangeTransModel form = new FormChangeTransModel(n, mn, mc);
                            form.ShowDialog();
                            string modelName = form.textBoxModelName.Text.ToString();
                            string markName = form.textBoxMarkName.Text.ToString();
                            string count = form.textBoxModelCount.Text.ToString();
                            TransportModel model;
                            if (Int32.TryParse(count, out int c))
                            {
                                model = new TransportModel(modelName, markName, c);
                                daoTransModel.updateType(n, model);
                            }
                            else
                            {
                                MessageBox.Show("Неверно введено количество моделей в автопарке!");
                            }
                        }
                        catch (SqlException odbcEx)
                        {
                            MessageBox.Show("Название модели не должно повторяться!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка при изменении!" + ex);
                        }
                        break;
                    }
            }
            updateTable();
        }
    }
}
