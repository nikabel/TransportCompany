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
    public partial class FormRoute : Form
    {
        public FormRoute()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddStop_Click(object sender, EventArgs e)
        {
            try
            {
                FormAddStop form = new FormAddStop();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так!" + ex);
            }
        }
    }
}