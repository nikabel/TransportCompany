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

namespace TransportCompany.forms
{
    public partial class FormChooseCertificate : Form
    {
        WorkCertificateDAO dao = new WorkCertificateDAO();
        public FormChooseCertificate()
        {
            InitializeComponent();
            comboBoxCertificates.Items.AddRange(dao.getAllCertificates());
        }

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            try
            {
                FormWorkCertificate form = new FormWorkCertificate(comboBoxCertificates.SelectedItem.ToString());
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