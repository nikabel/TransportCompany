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
    public partial class FormChangeSpec : Form
    {

        public FormChangeSpec(string n)
        {
            InitializeComponent();
            textBoxSpecName.Text = n;
        }

        private void FormChangeSpec_Load(object sender, EventArgs e)
        {

        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
