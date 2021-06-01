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

namespace TransportCompany.forms
{
    public partial class FormOccupation : Form
    {
        TransportDAO daoTrans = new TransportDAO();
        DriverDAO daoDriver = new DriverDAO();
        public FormOccupation()
        {
            InitializeComponent();
            tabPage1.Text = "Сведения о транспорте";
            tabPage2.Text = "Сведения о водителях";
            updateTable();
        }

        private void FormOccupation_Load(object sender, EventArgs e)
        {
            
        }
        public void updateTable()
        {
            try
            {
                DataTable data = daoTrans.getFreeTrans();
                data.Columns["license_plate"].ColumnName = "Гос. номер транспорта";
               // data.Columns["driver_name"].ColumnName = "ФИО водителя";
                data.Columns["model_name"].ColumnName = "Наименование модели";
                data.Columns["mark_name"].ColumnName = "Наименование марки";
                dataGridViewFreeTrans.DataSource = data;

                DataTable dataOcc = daoTrans.getOccupiedTrans();
                dataOcc.Columns["license_plate"].ColumnName = "Гос. номер транспорта";
                dataOcc.Columns["driver_name"].ColumnName = "ФИО водителя";
                dataOcc.Columns["model_name"].ColumnName = "Наименование модели";
                dataOcc.Columns["mark_name"].ColumnName = "Наименование марки";
                dataOcc.Columns["contract_num"].ColumnName = "Номер договора";
                dataGridViewOccTrans.DataSource = dataOcc;

                DataTable dataWD = daoDriver.getOccupiedDriver();
                dataWD.Columns["license_plate"].ColumnName = "Гос. номер транспорта";
                dataWD.Columns["driver_name"].ColumnName = "ФИО водителя";
                dataWD.Columns["employee_tel_num"].ColumnName = "Телефонный номер водителя";
                dataWD.Columns["contract_num"].ColumnName = "Номер договора";
                dataGridViewOccDriver.DataSource = dataWD;

                DataTable dataFD = daoDriver.getFreeDriver();
                dataFD.Columns["driver_name"].ColumnName = "ФИО водителя";
                dataFD.Columns["employee_tel_num"].ColumnName = "Телефонный номер водителя";
                dataGridViewFreeDriver.DataSource = dataFD;
            }
            catch
            {
                MessageBox.Show("Ошибка при получении данных!");
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
