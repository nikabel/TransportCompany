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
    public partial class FormChangeDepartment : Form
    {
        DBUtil connect = new DBUtil();
        DepartmentDAO dao = new DepartmentDAO();
        public FormChangeDepartment(string n, string cn, string d)
        {
            InitializeComponent();
            textBoxDepName.Text = n;
            textBoxCompName.Text = cn;
            textBoxDepDesc.Text = d;
        }

        private void buttonChangeStopType_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormChangeDepartment_Load(object sender, EventArgs e)
        {

        }
    }
}
