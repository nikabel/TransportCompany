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

namespace TransportCompany.forms
{
    public partial class FormApplication : Form
    {
        DBUtil connect = new DBUtil();
        public FormApplication(string app)
        {
            InitializeComponent();
            ApplicationForm rep = new ApplicationForm();
            ParameterFields paramFields = new ParameterFields();
            ParameterField paramField = new ParameterField();
            ParameterDiscreteValue paramDiscreteValue = new ParameterDiscreteValue();
            paramField.Name = "@application";
            paramDiscreteValue.Value = app;
            paramField.CurrentValues.Add(paramDiscreteValue);
            paramFields.Add(paramField);
            crystalReportViewer1.ReportSource = rep;
            crystalReportViewer1.ParameterFieldInfo = paramFields;
        }

        private void FormApplication_Load(object sender, EventArgs e)
        {

        }
    }
}
