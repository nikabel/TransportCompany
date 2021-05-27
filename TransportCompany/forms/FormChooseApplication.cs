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
    public partial class FormChooseApplication : Form
    {
        ApplicationDAO dao = new ApplicationDAO();
        public FormChooseApplication()
        {
            InitializeComponent();
            comboBoxApps.Items.AddRange(dao.getAllNums());
        }

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxApps.Text.Equals(""))
                    MessageBox.Show("Выберите номер заявки на перевозку груза!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                else
                {
                    FormApplication form = new FormApplication(comboBoxApps.SelectedItem.ToString());
                    this.Close();
                    form.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так!" + ex);
            }
        }
    }
}
