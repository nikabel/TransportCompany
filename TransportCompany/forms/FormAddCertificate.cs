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
using Contract = TransportCompany.models.Contract;

namespace TransportCompany.forms
{
    public partial class FormAddCertificate : Form
    {
        ContractDAO contractDAO = new ContractDAO();
        WorkCertificateDAO certificateDAO = new WorkCertificateDAO();
        ServiceDAO serviceDAO = new ServiceDAO();
        public FormAddCertificate()
        {
            InitializeComponent();
            comboBoxContracts.Items.AddRange(contractDAO.getAllContracts());
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if ((textBoxCertificateNum.Text.Equals("")) || (comboBoxContracts.Text.Equals("")))
                MessageBox.Show("Вы не ввели все необходимые данные!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else
            {
                try
                {
                    string num = textBoxCertificateNum.Text.ToString();
                    string contractNum = comboBoxContracts.SelectedItem.ToString();
                    string date = dateSign.Text;
                    WorkCertificate certificate = new WorkCertificate(num, date, contractNum);
                    certificateDAO.addCertificate(certificate);
                    serviceDAO.updateService(num, contractNum);
                    this.Close();

                }
                catch (SqlException odbcEx)
                {
                    MessageBox.Show("Номер акта выполненных работ не должен повторяться!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при формировании акта выполненных работ!");
                }
            }
        }
    }
}
