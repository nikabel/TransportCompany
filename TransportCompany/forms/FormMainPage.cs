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
    public partial class FormMainPage : Form
    {
        public FormMainPage()
        {
            InitializeComponent();
        }

        private void отToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void отчетПоТранспортуToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void отчетОЗанятостиТранспортаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void видыОстановокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                StopTypeForm form = new StopTypeForm();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так!" + ex);
            }
        }

        private void выходИзСистемыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти?", "Выход", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
