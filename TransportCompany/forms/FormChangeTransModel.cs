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
            this.Close();
        }
    }
}
