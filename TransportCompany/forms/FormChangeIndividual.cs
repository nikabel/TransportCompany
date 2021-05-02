using System;
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
    public partial class FormChangeIndividual : Form
    {
        public FormChangeIndividual(string name, string email, string tel, string adr)
        {
            InitializeComponent();
            textBoxName.Text = name;
            textBoxEmail.Text = email;
            textBoxTel.Text = tel;
            textBoxAdr.Text = adr;
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
