﻿using System;
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
    public partial class SetWorkChooseContractForm : Form
    {
        ContractDAO contractDAO = new ContractDAO();
        public SetWorkChooseContractForm()
        {
            InitializeComponent();
            comboBoxContracts.Items.AddRange(contractDAO.getAllContracts());
        }

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxContracts.Text.Equals(""))
                    MessageBox.Show("Выберите номер договора!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                else
                {
                    this.Close();
                    FormChooseEmployee form = new FormChooseEmployee(comboBoxContracts.SelectedItem.ToString());
                    form.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так!" + ex);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxContracts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
