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
    public partial class FormChangeEntity : Form
    {
        BankDetailsDAO detailsDAO = new BankDetailsDAO();
        public FormChangeEntity(string name, string email, string tel, string adr, string badr, string comp)
        {
            InitializeComponent();
            textBoxName.Text = name;
            textBoxEmail.Text = email;
            textBoxTel.Text = tel;
            textBoxAdr.Text = adr;
            textBoxBiAdr.Text = badr;
            textBoxCompName.Text = comp;

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
            if ((textBoxName.Text.Equals("")) || (textBoxTel.Text.Equals("")) || (textBoxAdr.Text.Equals("")) || (textBoxBiAdr.Text.Equals(""))
                || (textBoxEmail.Text.Equals("")) || (textBoxCompName.Text.Equals("")) || (textBoxACC.Text.Equals("")) || (textBoxINN.Text.Equals(""))
                || (textBoxRCBIC.Equals("")) || (textBoxOGRN.Equals("")) || (textBoxCorrACC.Equals("")) || (textBoxBankName.Equals("")))
                MessageBox.Show("Вы не ввели все необходимые данные!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else if ((textBoxACC.Text.Length != 20) || (textBoxINN.Text.Length != 12) || (textBoxRCBIC.Text.Length != 9) ||
                ((textBoxOGRN.Text.Length !=13) || (textBoxOGRN.Text.Length != 15)) || (textBoxCorrACC.Text.Length != 20))
                MessageBox.Show("Неверное введены банковские данные!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else if (textBoxTel.Text.Length != 11)
                MessageBox.Show("Неверно введен номер телефона!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else this.Close();
        }


        private void textBoxTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char symb = e.KeyChar;
            if ((symb < 'А' || symb > 'я') && symb != '\b' && symb != ' ')
            {
                e.Handled = true;
            }
        }

        private void textBoxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            char symb = e.KeyChar;
            if ((symb < 'a' || symb > 'z') && !Char.IsDigit(symb) && symb != '\b' && symb != '@' && symb != '.' && symb != '_' && symb != '-')
            {
                e.Handled = true;
            }
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
