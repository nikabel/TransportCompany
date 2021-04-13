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
        public FormCargoType(string n, string d)
        {
            InitializeComponent();
            textBoxCargoTypeName.Text = n;
            textBoxCargoTypeDesc.Text = d;
        }

        private void FormCargoType_Load(object sender, EventArgs e)
        {

        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
