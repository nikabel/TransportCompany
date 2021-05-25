﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportCompany.forms
{
    public partial class FormChangeDepartment : Form
    {
        public FormChangeDepartment(string n, string cn)
        {
            InitializeComponent();
            textBoxDepName.Text = n;
            textBoxCompName.Text = cn;
        }

        private void buttonChangeStopType_Click(object sender, EventArgs e)
        {
            if ((textBoxDepName.Text.Equals("")) || (textBoxCompName.Text.Equals("")))
                MessageBox.Show("Вы не ввели все необходимые данные!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else this.Close();
        }
        private void textBoxDepName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char symb = e.KeyChar;
            if ((symb < 'А' || symb > 'я') && symb != '\b' && symb != ' ')
            {
                e.Handled = true;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormChangeDepartment_Load(object sender, EventArgs e)
        {

        }
    }
}
