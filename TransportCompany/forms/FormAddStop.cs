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
    public partial class FormAddStop : Form
    {
        public FormAddStop(string num)
        {
            InitializeComponent();
            labelRouteNum.Text = num;
        }

        private void buttonAddStop_Click(object sender, EventArgs e)
        {

        }
    }
}
