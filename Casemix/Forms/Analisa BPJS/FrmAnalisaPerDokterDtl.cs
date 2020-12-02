using Syncfusion.WinForms.DataGridConverter;
using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Casemix.Forms.Analisa_BPJS
{
    public partial class FrmAnalisaPerDokterDtl : Form
    {
        public List<object> rawValue { get; set; }
    
        public FrmAnalisaPerDokterDtl()
        { 
            InitializeComponent();

            dgPiutang.DataSource = null;
        }

        private void FrmAnalisaPerDokterDtl_Load(object sender, EventArgs e)
        {
            dgPiutang.AllowEditing = false;

            dgPiutang.DataSource = rawValue;
      
        }

      

        private void FrmAnalisaPerDokterDtl_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void dgPiutang_AutoGeneratingColumn(object sender, Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnArgs e)
        {
            
        }

        private void dgPiutang_AutoGeneratingColumn_1(object sender, Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnArgs e)
        {
            if (e.Column.MappingName == "namaDokter")
            {
                e.Column.HeaderText = "Dokter";
                e.Column.Width = 250;


            }

            if (e.Column.MappingName == "spesialisasi")
            {
                e.Column.HeaderText = "Spesialisasi";
                e.Column.Width = 180;
                e.Column.Visible = false;
            }

            if (e.Column.MappingName == "no_sep")
            {
                e.Column.HeaderText = "No SEP";
                e.Column.Width = 140;

            }
            if (e.Column.MappingName == "noRM")
            {
                e.Column.HeaderText = "No RM";
                e.Column.Width = 80;

            }

            if (e.Column.MappingName == "noReg")
            {
                e.Column.HeaderText = "No Reg";
                e.Column.Width = 120;


            }
            if (e.Column.MappingName == "namaPasien")
            {
                e.Column.HeaderText = "Nama";
                e.Column.Width = 200;


            }
            if (e.Column.MappingName == "biaya_rs")
            {
                e.Column.HeaderText = "Biaya RS";
                e.Column.Format = "#,##0.00";

            }
            if (e.Column.MappingName == "iurPasien")
            {
                e.Column.HeaderText = "Iuran Pasien";

                e.Column.Format = "#,##0.00";
            }
            if (e.Column.MappingName == "potongan")
            {
                e.Column.HeaderText = "Potongan";

                e.Column.Format = "#,##0.00";
            }
            if (e.Column.MappingName == "COB")
            {
                e.Column.HeaderText = "COB";

                e.Column.Format = "#,##0.00";

            }
            if (e.Column.MappingName == "umbal")
            {
                e.Column.HeaderText = "Umbal";

                e.Column.Format = "#,##0.00";
            }
            if (e.Column.MappingName == "piutangRS")
            {
                e.Column.HeaderText = "Piutang RS";

                e.Column.Format = "#,##0.00";
            }

            if (e.Column.MappingName == "selisihUmbal")
            {
                e.Column.HeaderText = "Selisih";

                e.Column.Format = "#,##0.00";
            }
            if (e.Column.MappingName == "los")
            {
                e.Column.HeaderText = "Los";

            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            var options = new ExcelExportingOptions();
            options.ExcelVersion = ExcelVersion.Excel2013;
            //   options.CellExporting += CellExportingHandler;
            var excelEngine = dgPiutang.ExportToExcel(dgPiutang.View, options);
            var workBook = excelEngine.Excel.Workbooks[0];

            SaveFileDialog saveFilterDialog = new SaveFileDialog
            {
                FilterIndex = 2,
                Filter = "Excel 97 to 2003 Files(*.xls)|*.xls|Excel 2007 to 2010 Files(*.xlsx)|*.xlsx|Excel 2013 File(*.xlsx)|*.xlsx"
            };

            if (saveFilterDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (Stream stream = saveFilterDialog.OpenFile())
                {
                    if (saveFilterDialog.FilterIndex == 1)
                        workBook.Version = ExcelVersion.Excel97to2003;
                    else if (saveFilterDialog.FilterIndex == 2)
                        workBook.Version = ExcelVersion.Excel2010;
                    else
                        workBook.Version = ExcelVersion.Excel2013;
                    workBook.SaveAs(stream);
                }

                if (MessageBox.Show(this.dgPiutang, "Do you want to view the workbook?", "Workbook has been created",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    System.Diagnostics.Process.Start(saveFilterDialog.FileName);
                }
            }
        }
    }
}
