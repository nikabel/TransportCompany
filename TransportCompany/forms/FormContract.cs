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
using TransportCompany.models;
using TransportCompany.forms;
using TransportCompany.reports;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using System.Web;
using CrystalDecisions.Shared;

namespace TransportCompany.forms
{
    public partial class FormContract : Form
    {
        DBUtil connect = new DBUtil();
        public FormContract(string contract)
        {
            InitializeComponent();
            CrystalRep rep = new CrystalRep();
            ParameterFields paramFields = new ParameterFields();
            ParameterField paramField = new ParameterField();
            ParameterDiscreteValue paramDiscreteValue = new ParameterDiscreteValue();
            paramField.Name = "@contract";
            paramDiscreteValue.Value = contract;
            paramField.CurrentValues.Add(paramDiscreteValue);
            paramFields.Add(paramField);
            crystalReportViewer1.ReportSource = rep;
            crystalReportViewer1.ParameterFieldInfo = paramFields;
        }

        private void FormContract_Load(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
