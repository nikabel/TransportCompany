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
    public partial class FormChangeEmployee : Form
    {
        DepartmentDAO departmentDAO = new DepartmentDAO();
        SpecializationDAO specializationDAO = new SpecializationDAO();
        public FormChangeEmployee(string name, string pos, string tel, string adr, string spec, string dep)
        {
            InitializeComponent();
            textBoxName.Text = name;
            textBoxPos.Text = pos;
            textBoxTel.Text = tel;
            textBoxAddress.Text = adr;
            comboBoxSpec.Items.AddRange(specializationDAO.getAllSpecializations());
            comboBoxSpec.SelectedItem = spec;
            comboBoxDep.Items.AddRange(departmentDAO.getAllDepartments());
            comboBoxDep.SelectedItem = dep;
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
