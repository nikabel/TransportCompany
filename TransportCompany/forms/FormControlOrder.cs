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

namespace TransportCompany.forms
{
    public partial class FormControlOrder : Form
    {
        StopDAO stopDAO = new StopDAO();
        public FormControlOrder(string id)
        {
            InitializeComponent();
            labelRouteId.Text = id;
            updateTable(id);
        }

        public void updateTable(string num)
        {
            DataTable data = stopDAO.getAllByRoute(num);
            data.Columns["stop_id"].ColumnName = "Id остановки";
            data.Columns["stop_address"].ColumnName = "Адрес остановки";
            data.Columns["operation_name"].ColumnName = "Наименование операции";
            data.Columns["plan_stop_date"].ColumnName = "Планируемая дата";
            data.Columns["fact_stop_date"].ColumnName = "Фактическая дата";
            data.Columns.Remove("route_id");
            dataGridViewStops.DataSource = data;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddStop_Click(object sender, EventArgs e)
        {
            try
            {
                string num = labelRouteId.Text.ToString();
                string factDate = dateStop.Text;
                int rowNum = dataGridViewStops.CurrentCell.RowIndex;
                string id = dataGridViewStops[0, rowNum].Value.ToString();
                stopDAO.updateStop(factDate, id);
                updateTable(num);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неверно введены данные!");
            }
        }
    }
}
