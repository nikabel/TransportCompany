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
    public partial class FormChangeIndividual : Form
    {
        BankDetailsDAO detailsDAO = new BankDetailsDAO();
        public FormChangeIndividual(string name, string email, string tel, string adr)
        {
            InitializeComponent();
            textBoxName.Text = name;
            textBoxEmail.Text = email;
            textBoxTel.Text = tel;
            textBoxAdr.Text = adr;

            BankDetails details = detailsDAO.getBankByName(name);
            if (details != null)
            {
                textBoxACC.Text = details.Acc;
                textBoxINN.Text = details.Inn;
                textBoxRCBIC.Text = details.Rcbic;
                textBoxOGRN.Text = details.Ogrn;
                textBoxCorrACC.Text = details.CorrAcc;
                textBoxBankName.Text = details.BankName;
            }
            else
            {
                textBoxACC.Text = "";
                textBoxINN.Text = "";
                textBoxRCBIC.Text = "";
                textBoxOGRN.Text = "";
                textBoxCorrACC.Text = "";
                textBoxBankName.Text = "";
            }
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void textBoxACC_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
        private void textBoxINN_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
        private void textBoxRCBIC_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
        private void textBoxOGRN_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
        private void textBoxCorrACC_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}
