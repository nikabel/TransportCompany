using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransportCompany.DAO;
using TransportCompany.models;
using TransportCompany.forms;
using TransportCompany.reports;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using System.Web;
using CrystalDecisions.Shared;
using WorkCertificate = TransportCompany.reports.WorkCertificate;

namespace TransportCompany.forms
{
    public partial class FormWorkCertificate : Form
    {
        public FormWorkCertificate(string cert)
        {
            InitializeComponent();
            WorkCertificate rep = new WorkCertificate();
            ParameterFields paramFields = new ParameterFields();
            ParameterField paramField = new ParameterField();
            ParameterDiscreteValue paramDiscreteValue = new ParameterDiscreteValue();
            paramField.Name = "@certificate";
            paramDiscreteValue.Value = cert;
            paramField.CurrentValues.Add(paramDiscreteValue);
            paramFields.Add(paramField);
            crystalReportViewer1.ReportSource = rep;
            crystalReportViewer1.ParameterFieldInfo = paramFields;
        }

        private void FormWorkCertificate_Load(object sender, EventArgs e)
        {

        }
    }
}
