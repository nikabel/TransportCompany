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

namespace TransportCompany
{
    public partial class FormAuthentication : Form
    {
        UserDAO dao = new UserDAO();
        public FormAuthentication()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            if ((textBoxLogin.Text.Equals("")) || (textBoxPassword.Text.Equals("")))
                MessageBox.Show("Вы не ввели все необходимые данные!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else
            {
                if (dao.checkUser(textBoxLogin.Text, textBoxPassword.Text))
                {
                    try
                    {
                        string role;
                        if (textBoxLogin.Text == "admin") role = "Администратор";
                        else role = dao.getUserDepartment(textBoxLogin.Text);
                        FormMainPage form = new FormMainPage(role);
                        form.ShowDialog();
                        textBoxLogin.Clear();
                        textBoxPassword.Clear();
                        this.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Что-то пошло не так!" + ex);
                    }
                }
                else MessageBox.Show("Неверно введены данные!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        private void textBoxLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            char symb = e.KeyChar;
            if (!Char.IsDigit(symb) && (symb < 'A' || symb > 'z') && symb != '\b' && symb != '-' && symb != '_' && symb != '.')
            {
                e.Handled = true;
            }
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            char symb = e.KeyChar;
            if (!Char.IsDigit(symb) && (symb < 'A' || symb > 'z') && symb != '\b' && symb != '-' && symb != '_' && symb != '.')
            {
                e.Handled = true;
            }
        }
    }
}
