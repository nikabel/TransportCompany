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
    public partial class FormChangeSpec : Form
    {
        DBUtil connect = new DBUtil();
        SpecializationDAO dao = new SpecializationDAO();

        public FormChangeSpec(string n, string d)
        {
            InitializeComponent();
            textBoxSpecName.Text = n;
            textBoxSpecDesc.Text = d;
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
