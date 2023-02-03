using Casemix.Util;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Events;
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
            this.dgPiutang.Columns.Add(new GridButtonColumn()
            {
                MappingName="Test",
                HeaderText = "Diagnosa Sekunder",
                AllowDefaultButtonText = true,
                DefaultButtonText = "Diagnosa Sekunder",
                Width = 180
            }); ;
            this.dgPiutang.CellButtonClick += diagnosa_click;
        }

        private void diagnosa_click(object sender, CellButtonClickEventArgs e)
        {
            var noReg = ClsUtil.getValueFromGridEvent(dgPiutang, dgPiutang.CurrentCell.RowIndex, "NoReg");
            var noRM = ClsUtil.getValueFromGridEvent(dgPiutang, dgPiutang.CurrentCell.RowIndex, "NoRM");
            var nama = ClsUtil.getValueFromGridEvent(dgPiutang, dgPiutang.CurrentCell.RowIndex, "NamaPasien");
            // MsgBoxUtil.MsgInfo(id);
            FrmAnalisaICD10Dtl_Lvl2 frm = new FrmAnalisaICD10Dtl_Lvl2(noReg,noRM,nama);
            frm.ShowDialog();
            frm.Close();
        }

        private void dgPiutang_AutoGeneratingColumn(object sender, Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnArgs e)
        {
            e.Column.Width = 180;
            e.Column.HeaderStyle.Font.Size = 8;
            e.Column.CellStyle.Font.Size = 8;
            e.Column.AllowFiltering = false;
            if (e.Column.MappingName == "ICD10")
            {
                e.Column.HeaderText = "ICD 10";
                e.Column.Width = 60;
                e.Column.AllowFiltering = true;

            }


            if (e.Column.MappingName == "Diagnosa")
            {
                e.Column.HeaderText = "Diagnosa";
                e.Column.Width = 150;
                
                e.Column.AllowFiltering = true;
            }

       
            if (e.Column.MappingName == "NoRM")
            {
                e.Column.HeaderText = "No RM";
                e.Column.Width = 80;

            }

            if (e.Column.MappingName == "NoReg")
            {
                e.Column.HeaderText = "No Reg";
                e.Column.Width = 90;
                e.Column.AllowFiltering = true;

            }
            if (e.Column.MappingName == "NamaPasien")
            {
                e.Column.HeaderText = "Nama";
                e.Column.Width = 200;
                e.Column.AllowFiltering = true;

            }
            if (e.Column.MappingName == "KodePenanggung")
            {
                e.Column.HeaderText = "Kode Penanggung";
                e.Column.Width =60;
                e.Column.AllowFiltering = true;

            }
            if (e.Column.MappingName == "Penanggung")
            {
                e.Column.HeaderText = "Penanggung";
                e.Column.Width = 200;
                e.Column.AllowFiltering = true;

            }
            if (e.Column.MappingName == "Tgl_Masuk")
            {
                e.Column.HeaderText = "Tgl Masuk";
                e.Column.Width = 80;
                e.Column.Format = "dd-MM-yyyy";
                e.Column.AllowFiltering = true;
            }
            if (e.Column.MappingName == "Tgl_Pulang")
            {
                e.Column.HeaderText = "Tgl Pulang";
                e.Column.Width = 80;
                e.Column.Format = "dd-MM-yyyy";
                e.Column.AllowFiltering = true;
            }
         
            if (e.Column.MappingName == "biayaRS")
            {
                e.Column.HeaderText = "Total Biaya RS";
                e.Column.Format = "#,##0.00";
                e.Column.Width = 150;
                e.Column.AllowFiltering = true;
            }
            if (e.Column.MappingName == "KelasKamar")
            {
                e.Column.HeaderText = "Kelas";
                e.Column.Width = 120;
                e.Column.AllowFiltering = true;
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            ClsUtil.DownloadXLs(dgPiutang);
        }
    }
}
