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
using TransportCompany.reports;
using CrystalDecisions.Shared;
using Application = TransportCompany.reports.Application;

namespace TransportCompany.forms
{
    public partial class FormApplication : Form
    {
        DBUtil connect = new DBUtil();
        public FormApplication(string app)
        {
            InitializeComponent();
            Application rep = new Application();
            rep.SetParameterValue("@application", app);
            crystalReportViewer1.ReportSource = rep;
        }

        private void FormApplication_Load(object sender, EventArgs e)
        {

        }
    }
}
