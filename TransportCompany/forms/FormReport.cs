using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransportCompany.reports;

namespace TransportCompany.forms
{
    public partial class FormReport : Form
    {
        public FormReport(string first, string second)
        {
            InitializeComponent();
            CompletedReport rep = new CompletedReport();
            rep.SetParameterValue("@firstDate", first);
            rep.SetParameterValue("@secondDate", second);
            crystalReportViewer1.ReportSource = rep;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
