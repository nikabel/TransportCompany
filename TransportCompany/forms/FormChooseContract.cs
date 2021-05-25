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
    public partial class FormChooseContract : Form
    {
        ContractDAO contractDAO = new ContractDAO();
        public FormChooseContract()
        {
            InitializeComponent();
            comboBoxContracts.Items.AddRange(contractDAO.getAllContracts());
        }

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            try
            {
                FormContract form = new FormContract(comboBoxContracts.SelectedItem.ToString());
                this.Close();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так!" + ex);
            }
        }
    }
}