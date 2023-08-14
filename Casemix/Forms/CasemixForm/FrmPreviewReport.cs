using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casemix.Forms.CasemixForm
{
    public partial class FrmPreviewReport : Form
    {

        private string _reportNameSpace = @"Casemix.Reports.{0}.rdlc";
        public FrmPreviewReport()
        {
            InitializeComponent();
        }

        public FrmPreviewReport(string header, string reportName, ReportDataSource reportDataSource, IEnumerable<ReportParameter> parameters = null, bool isPreview = false)
        : this()
        {
            this.Text = header;


            reportName = string.Format(_reportNameSpace, reportName);

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = reportName;

            if (!(parameters == null))
                this.reportViewer1.LocalReport.SetParameters(parameters);

            this.reportViewer1.ShowPrintButton = !isPreview;

            this.reportViewer1.RefreshReport();
        }
        public static void ShowReport(string header, string reportName, ReportDataSource reportDataSource, IEnumerable<ReportParameter> parameters = null)
        {
            var frmPreview = new FrmPreviewReport(header, reportName, reportDataSource, parameters);
            frmPreview.ShowDialog();
        }


        private void FrmPreviewReport_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
