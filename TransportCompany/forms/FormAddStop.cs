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
    public partial class FormAddStop : Form
    {
        OperationDAO operationDAO = new OperationDAO();
        StopDAO stopDAO = new StopDAO();
        public FormAddStop(string num)
        {
            InitializeComponent();
            labelRouteNum.Text = num;
            comboBoxOperation.Items.AddRange(operationDAO.getAllOperations());
            updateTable(num);
        }

        public void updateTable(string num)
        {
            DataTable data = stopDAO.getAllByRoute(num);
            data.Columns["stop_id"].ColumnName = "Id остановки";
            data.Columns["stop_address"].ColumnName = "Адрес остановки";
            data.Columns["operation_name"].ColumnName = "Наименование операции";
            data.Columns["plan_stop_date"].ColumnName = "Планируемая дата";
            data.Columns.Remove("route_id");
            data.Columns.Remove("fact_stop_date");
            dataGridViewStops.DataSource = data;
        }

        private void buttonAddStop_Click(object sender, EventArgs e)
        {
            if ((textBoxStopNum.Text.Equals("")) || (textBoxStopAddress.Text.Equals("")) || (comboBoxOperation.Text.Equals("")))
                MessageBox.Show("Вы не ввели все необходимые данные!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else
            {
                try
                {
                    string num = labelRouteNum.Text.ToString();
                    string id = textBoxStopNum.Text.ToString();
                    string address = textBoxStopAddress.Text.ToString();
                    string operation = comboBoxOperation.SelectedItem.ToString();
                    string planDate = dateStop.Text;
                    Stop stop = new Stop(id, address, num, operation, planDate, null);
                    stopDAO.addStop(stop);
                    textBoxStopNum.Clear();
                    textBoxStopAddress.Clear();
                    updateTable(num);
                }
                catch (SqlException odbcEx)
                {
                    MessageBox.Show("Номер остановки не должен повторяться!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при добавлении остановки!" + ex);
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить данные?", "Сообщение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    string app = labelRouteNum.Text.ToString();
                    int rowNum = dataGridViewStops.CurrentCell.RowIndex;
                    string num = dataGridViewStops[0, rowNum].Value.ToString();
                    stopDAO.deleteStop(num);
                    updateTable(app);
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
