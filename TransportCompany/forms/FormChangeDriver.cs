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
    public partial class FormChangeDriver : Form
    {
        DepartmentDAO departmentDAO = new DepartmentDAO();
        public FormChangeDriver(string name, string pos, string tel, string adr, string exp, string cat, string dep)
        {
            InitializeComponent();
            textBoxName.Text = name;
            textBoxPos.Text = pos;
            textBoxTel.Text = tel;
            textBoxAddress.Text = adr;
            textBoxExp.Text = exp;
            textBoxLicense.Text = cat;
            comboBoxDep.Items.AddRange(departmentDAO.getAllDepartments());
            comboBoxDep.SelectedItem = dep;
        }

        private void FormChangeDriver_Load(object sender, EventArgs e)
        {

        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxExp_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}
