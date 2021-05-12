using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransportCompany.forms;

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
                StopTypeForm form = new StopTypeForm("Operation");
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

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormEmployee form = new FormEmployee();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так!" + ex);
            }
        }

        private void FormMainPage_Load(object sender, EventArgs e)
        {

        }

        private void отделыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                StopTypeForm form = new StopTypeForm("Department");
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так!" + ex);
            }
        }

        private void видыГрузовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                StopTypeForm form = new StopTypeForm("CargoType");
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так!" + ex);
            }
        }

        private void специализацииСотрудниковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                StopTypeForm form = new StopTypeForm("Specialization");
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так!" + ex);
            }
        }

        private void транспортToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                StopTypeForm form = new StopTypeForm("Transport");
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так!" + ex);
            }
        }

        private void транспортныеМоделиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                StopTypeForm form = new StopTypeForm("TransportModel");
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так!" + ex);
            }
        }

        private void заказчикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormCustomer form = new FormCustomer();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так!" + ex);
            }
        }

        private void сведенияОСоответствииГрафикуОказанияУслугToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void сведенияОВыполненныхРаботахЗаУказанныйПериодToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void сведенияОбОбьемеВыполненныхРаботToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void формированиеДоговораToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormAddContract form = new FormAddContract();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так!" + ex);
            }
        }

        private void составлениеЗаявкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormAddApplication form = new FormAddApplication();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так!" + ex);
            }
        }

        private void определениеСотрудниковДляРаботыНадЗаказомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SetWorkChooseContractForm form = new SetWorkChooseContractForm();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так!" + ex);
            }
        }

        private void формированиеМаршрутаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormRoute form = new FormRoute();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так!" + ex);
            }
        }

        private void определениеСтатусаЗаказаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormControlOrderChooseRoute form = new FormControlOrderChooseRoute();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так!" + ex);
            }
        }

        private void оформлениеАктаВыполненныхРаботПоЗаказуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormAddCertificate form = new FormAddCertificate();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так!" + ex);
            }
        }

        private void buttonRequest_Click(object sender, EventArgs e)
        {
            try
            {
                FormAddApplication form = new FormAddApplication();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так!" + ex);
            }
        }

        private void buttonContract_Click(object sender, EventArgs e)
        {
            try
            {
                FormAddContract form = new FormAddContract();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так!" + ex);
            }
        }

        private void buttonCompletedWorks_Click(object sender, EventArgs e)
        {
            try
            {
                FormAddCertificate form = new FormAddCertificate();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так!" + ex);
            }
        }

        private void договорОбОказанииУслугToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormChooseContract form = new FormChooseContract();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так!" + ex);
            }
        }

        private void актВыполненныхРаботToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormChooseCertificate form = new FormChooseCertificate();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так!" + ex);
            }
        }
    }
}
