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
        StopTypeDAO dao = new StopTypeDAO();

        public StopTypeForm()
        {
            InitializeComponent();
            connect.createConnection();
            updateTable();
        }

        public void updateTable()
        {
            DataTable data = dao.getAll();
            data.Columns["stop_type_name"].ColumnName = "Наименование типа остановки";
            data.Columns["stop_type_desc"].ColumnName = "Описание типа остановки";
            dataGridViewStopType.DataSource = data;
        }         

        private void StopTypeForm_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonAddStopType_Click(object sender, EventArgs e)
        {
            try
            {
                FormChangeStopType form = new FormChangeStopType("", "");
                form.ShowDialog();
                string name = form.textBoxUpdateStopTypeName.Text.ToString();
                string desc = form.textBoxUpdateStopTypeDesc.Text.ToString();
                StopType stopType = new StopType(name, desc);
                dao.addType(stopType);
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
            dao.deleteByName(name);
            updateTable();
        }


        private void buttonSearchTransportType_Click(object sender, EventArgs e)
        {
            string name = textBoxSearchStopType.Text.ToString();
            DataTable data = dao.searchByName(name);
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
                string d = dataGridViewStopType[1, rowNum].Value.ToString();
                FormChangeStopType form = new FormChangeStopType(n, d);
                form.ShowDialog();
                string name = form.textBoxUpdateStopTypeName.Text.ToString();
                string desc = form.textBoxUpdateStopTypeDesc.Text.ToString();
                StopType stopType = new StopType(name, desc);
                dao.updateType(n, stopType);
                updateTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Вид остановки не должен повторяться!"+ex);
            }
        }
    }
}
