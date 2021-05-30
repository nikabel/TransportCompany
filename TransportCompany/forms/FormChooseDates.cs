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
    public partial class FormChooseDates : Form
    {
        public FormChooseDates()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (dateFirst.Value.Date > dateSecond.Value.Date)
                    MessageBox.Show("Дата начала периода должна быть раньше даты окончания периода! Выберите другие даты!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                else
                {
                    FormReport form = new FormReport(dateFirst.Text, dateSecond.Text);
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
