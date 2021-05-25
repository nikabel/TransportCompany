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
            if ((textBoxName.Text.Equals("")) || (textBoxPos.Text.Equals("")) || (textBoxTel.Text.Equals("")) || (textBoxAddress.Text.Equals(""))
                || (comboBoxSpec.Text.Equals("")) || (comboBoxDep.Text.Equals("")))
                MessageBox.Show("Вы не ввели все необходимые данные!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else this.Close();
        }

        private void textBoxTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char symb = e.KeyChar;
            if ((symb < 'А' || symb > 'я') && symb != '\b' && symb != ' ')
            {
                e.Handled = true;
            }
        }

        private void textBoxPos_KeyPress(object sender, KeyPressEventArgs e)
        {
            char symb = e.KeyChar;
            if ((symb < 'А' || symb > 'я') && symb != '\b' && symb != ' ')
            {
                e.Handled = true;
            }
        }
    }
}
