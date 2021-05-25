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

namespace TransportCompany.forms
{
    public partial class FormCargoType : Form
    {
        DBUtil connect = new DBUtil();
        CargoTypeDAO dao = new CargoTypeDAO();
        public FormCargoType(string n)
        {
            InitializeComponent();
            textBoxCargoTypeName.Text = n;
        }

        private void FormCargoType_Load(object sender, EventArgs e)
        {

        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if ((textBoxCargoTypeName.Text.Equals("")))
                MessageBox.Show("Вы не ввели все необходимые данные!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else this.Close();
        }

        private void textBoxCargoTypeName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char symb = e.KeyChar;
            if ((symb < 'А' || symb > 'я') && symb != '\b' && symb != ' ')
            {
                e.Handled = true;
            }
        }
    }
}
