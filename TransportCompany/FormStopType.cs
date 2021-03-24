using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TransportCompany
{    public partial class StopTypeForm : Form
    {
        private static string connectionString = "Data Source=COMPUTER;Initial Catalog=CargoCompany;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);

        public StopTypeForm()
        {
            InitializeComponent();
            connection.Open();
            updateTable();
        }

        public void updateTable()
        {
            SqlDataAdapter command = new SqlDataAdapter("select * from StopType", connection);
            DataTable data = new DataTable();
            command.Fill(data);
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
                string query = "insert into StopType values (@name, @desc)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@desc", desc);
                command.ExecuteNonQuery();
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
            string query = "delete from StopType where (stop_type_name = @name);";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@name", name);
            command.ExecuteNonQuery();
            updateTable();
        }


        private void buttonSearchTransportType_Click(object sender, EventArgs e)
        {
            string name = textBoxSearchStopType.Text.ToString();
            string query = String.Format("SELECT stop_type_name, stop_type_desc FROM StopType WHERE stop_type_name LIKE '{0}' + '%'", name);
            SqlDataAdapter command = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            command.Fill(data);
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
                string query = String.Format("UPDATE StopType SET stop_type_name = '{0}', stop_type_desc = '{1}' WHERE stop_type_name = '{2}' ", name, desc, n);
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                updateTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Вид остановки не должен повторяться!"+ex);
            }
        }
    }
}
