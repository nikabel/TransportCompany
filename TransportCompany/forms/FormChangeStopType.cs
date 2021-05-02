using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportCompany
{
    public partial class FormChangeStopType : Form
    {
        public FormChangeStopType(string n)
        {
            InitializeComponent();
            textBoxUpdateStopTypeName.Text = n;
        }

        private void FormChangeStopType_Load(object sender, EventArgs e)
        {

        }

        private void buttonChangeStopType_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
