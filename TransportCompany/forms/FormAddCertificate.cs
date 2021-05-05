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
            try
            {
                string num =textBoxCertificateNum.Text.ToString();
                string contractNum = comboBoxContracts.SelectedItem.ToString();
                string date = dateSign.Text;
                WorkCertificate certificate = new WorkCertificate(num, date, contractNum);
                certificateDAO.addCertificate(certificate);
                serviceDAO.updateService(num, contractNum);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неверно введены данные!");
            }
        }
    }
}
