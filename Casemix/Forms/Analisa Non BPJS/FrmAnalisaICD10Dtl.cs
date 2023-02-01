using Casemix.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casemix.Forms.Analisa_Non_BPJS
{
    public partial class FrmAnalisaICD10Dtl : Form
    {
        public List<object> rawValue { get; set; }
        public FrmAnalisaICD10Dtl()
        {
            InitializeComponent();
        }

        private void FrmAnalisaICD10Dtl_Load(object sender, EventArgs e)
        {
            dgPiutang.AllowEditing = false;
            dgPiutang.AllowResizingColumns = true;
            dgPiutang.DataSource = rawValue;
        }

        private void dgPiutang_AutoGeneratingColumn(object sender, Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnArgs e)
        {
            e.Column.Width = 180;
            e.Column.HeaderStyle.Font.Size = 8;
            e.Column.CellStyle.Font.Size = 8;
            if (e.Column.MappingName == "kodeICD10")
            {
                e.Column.HeaderText = "ICD 10";
                e.Column.Width = 60;
                

            }


            if (e.Column.MappingName == "deskripsiIcd")
            {
                e.Column.HeaderText = "Diagnosa";
                e.Column.Width = 150;
                e.Column.Visible = false;
            }

       
            if (e.Column.MappingName == "noRM")
            {
                e.Column.HeaderText = "No RM";
                e.Column.Width = 80;

            }

            if (e.Column.MappingName == "noReg")
            {
                e.Column.HeaderText = "No Reg";
                e.Column.Width = 90;


            }
            if (e.Column.MappingName == "namaPasien")
            {
                e.Column.HeaderText = "Nama";
                e.Column.Width = 200;


            }
            if (e.Column.MappingName == "kdPng")
            {
                e.Column.HeaderText = "KodePng";
                e.Column.Width =60;
               

            }
            if (e.Column.MappingName == "namaPng")
            {
                e.Column.HeaderText = "Penanggung";
                e.Column.Width = 200;


            }
            if (e.Column.MappingName == "dt_tgl_msk")
            {
                e.Column.HeaderText = "Tgl Masuk";
                e.Column.Width = 80;
                e.Column.Format = "dd-MM-yyyy";

            }
            if (e.Column.MappingName == "dt_tgl_pul")
            {
                e.Column.HeaderText = "Tgl Pulang";
                e.Column.Width = 80;
                e.Column.Format = "dd-MM-yyyy";

            }
            if (e.Column.MappingName == "namaPng")
            {
                e.Column.HeaderText = "Penanggung";
                e.Column.Width = 150;


            }
            if (e.Column.MappingName == "biayaRS")
            {
                e.Column.HeaderText = "Total Biaya RS";
                e.Column.Format = "#,##0.00";
                e.Column.Width = 150;
            }
           
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            ClsUtil.DownloadXLs(dgPiutang);
        }
    }
}
