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
    public partial class FormAddCargo : Form
    {
        TransportDAO transportDAO = new TransportDAO();
        CargoTypeDAO typeDAO = new CargoTypeDAO();
        CargoDAO cargoDAO = new CargoDAO();
        TransportApplicationDAO taDAO = new TransportApplicationDAO();
        public FormAddCargo(string num)
        {
            InitializeComponent();
            labelApplicationNum.Text = num;
            comboBoxTransport.Items.AddRange(transportDAO.getTransportPlates());
            comboBoxCargoType.Items.AddRange(typeDAO.getTypeNames());
            updateTable(num);
        }

        public void updateTable(string num)
        {
            DataTable data = cargoDAO.getAllByApplication(num);
            data.Columns["cargo_num"].ColumnName = "Номер груза";
            data.Columns["cargo_name"].ColumnName = "Наименование услуги";
            data.Columns["cargo_type_name"].ColumnName = "Наименование вида груза";
            data.Columns["cargo_weight"].ColumnName = "Вес груза";
            data.Columns["cargo_volume"].ColumnName = "Объем груза";
            data.Columns["cargo_cost"].ColumnName = "Стоимость груза";
            data.Columns.Remove("application_num");
            dataGridViewCargo.DataSource = data;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddCargo_Click(object sender, EventArgs e)
        {
            if ((textBoxCargoName.Text.Equals("")) || (textBoxCargoNum.Text.Equals("")) || (textBoxCargoCost.Text.Equals("")) || (textBoxCargoWeight.Text.Equals(""))
                || (textBoxCargoVolume.Text.Equals("")) || (comboBoxTransport.Text.Equals("")) || (comboBoxCargoType.Text.Equals("")))
                MessageBox.Show("Вы не ввели все необходимые данные!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else
            {
                try
                {
                    string num = labelApplicationNum.Text.ToString();
                    string name = textBoxCargoName.Text.ToString();
                    string cargoNum = textBoxCargoNum.Text.ToString();
                    int cost = int.Parse(textBoxCargoCost.Text.ToString());
                    int weight = int.Parse(textBoxCargoWeight.Text.ToString());
                    int volume = int.Parse(textBoxCargoVolume.Text.ToString());
                    string transport = comboBoxTransport.SelectedItem.ToString();
                    string type = comboBoxCargoType.SelectedItem.ToString();
                    Cargo cargo = new Cargo(cargoNum, num, name, type, weight, volume, cost);
                    TransportApplication ta = new TransportApplication(transport, num);
                    cargoDAO.addCargo(cargo);
                    if (taDAO.checkTransportApplication(ta)) taDAO.addTransportApplication(ta);
                    textBoxCargoName.Clear();
                    textBoxCargoNum.Clear();
                    textBoxCargoCost.Clear();
                    textBoxCargoWeight.Clear();
                    textBoxCargoVolume.Clear();
                    updateTable(num);
                }
                catch (SqlException odbcEx)
                {
                    MessageBox.Show("Данный номер груза уже существует! Введите другой номер груза.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при добавлении груза!" + ex);
                }
            }
        }

        private void textBoxCargoName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char symb = e.KeyChar;
            if ((symb < 'А' || symb > 'я') && symb != '\b' && symb != ' ')
            {
                e.Handled = true;
            }
        }

        private void textBoxCargoWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxCargoVolume_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxCargoCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void FormAddCargo_Load(object sender, EventArgs e)
        {

        }

        private void buttonDeleteCargo_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить данные?", "Сообщение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    string app = labelApplicationNum.Text.ToString();
                    int rowNum = dataGridViewCargo.CurrentCell.RowIndex;
                    string num = dataGridViewCargo[0, rowNum].Value.ToString();
                    cargoDAO.deleteCargo(num);
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
