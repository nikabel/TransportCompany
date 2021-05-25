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
    public partial class FormChangeTransModel : Form
    {

        public FormChangeTransModel(string n, string mn, string mc)
        {
            InitializeComponent();
            textBoxModelName.Text = n;
            textBoxMarkName.Text = mn;
            textBoxModelCount.Text = mc;
        }

    private void FormChangeTransModel_Load(object sender, EventArgs e)
        {

        }

        private void buttonChangeStopType_Click(object sender, EventArgs e)
        {
            if ((textBoxModelName.Text.Equals("")) || (textBoxMarkName.Text.Equals("")) || (textBoxModelCount.Text.Equals("")))
                MessageBox.Show("Вы не ввели все необходимые данные!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else this.Close();
        }

        private void textBoxModelCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}
