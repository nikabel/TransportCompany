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
    public partial class FormChangeTrans : Form
    {
        DriverDAO daoDriver = new DriverDAO();
        TransportModelDAO daoModel = new TransportModelDAO();

        public FormChangeTrans(string num, string dn, string mn)
        {
            InitializeComponent();
            textBoxLicensePlate.Text = num;
            comboBoxDrivers.Items.AddRange(daoDriver.getAllDriverNames());
            comboBoxDrivers.SelectedItem = dn;
            comboBoxModels.Items.AddRange(daoModel.getAllTransModels());
            comboBoxModels.SelectedItem = mn;
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxDrivers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBoxLicensePlate_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxModels_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
