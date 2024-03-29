﻿using Casemix.Model;
using Syncfusion.PivotAnalysis.Base;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.PivotAnalysis;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.PivotConverter;
using Syncfusion.XlsIO;
using System.Diagnostics;
using Syncfusion.WinForms.Input;
namespace Casemix.Forms.Analisa_BPJS
{
    public partial class FrmAnalisaPerCoding : Form
    {
        public FrmAnalisaPerCoding()
        {
            InitializeComponent();

            generateComboBox();
       
        }


    
        private void FrmAnalisaPerDiagnosa_Load(object sender, EventArgs e)
        {

        }
        private void genarateData()
        {   if(cmbJenisPel.Text.Equals("Rawat Jalan"))
            {
                this.pivotGridControl1.ItemSource = getDataRawatJalan();

            }
             else
            {
                this.pivotGridControl1.ItemSource = getDataRawatInap();
            }

            if (chkBoxSort.Checked)
            {
                this.pivotGridControl1.RowPivotsOnly = true;
            }
            else
            {
                this.pivotGridControl1.RowPivotsOnly = false;
                this.pivotGridControl1.PivotRows.Add(new PivotItem { FieldMappingName = "diagnosa_grouper", FieldHeader = "Diagnosa", AllowSort = true });

            }

            this.pivotGridControl1.GridVisualStyles = GridVisualStyles.Metro;
              this.pivotGridControl1.PivotRows.Add(new PivotItem { FieldMappingName = "deskripsi", FieldHeader = "Deskripsi", AllowSort = true });
            this.pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "no_sep", FieldHeader = "Total Kasus(SEP)", AllowSort = true });
            
            this.pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "biaya_rs", FieldHeader = "Biaya RS", SummaryType = SummaryType.Sum, Format = "#,##0", AllowSort = true });

            this.pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "iurPasien", FieldHeader = "Iuran Pasien", SummaryType = SummaryType.Sum, Format = "#,##0", AllowSort = true });

            this.pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "potongan", FieldHeader = "Potongan", SummaryType = SummaryType.Sum, Format = "#,##0", AllowSort = true });

            this.pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "COB", FieldHeader = "COB", SummaryType = SummaryType.Sum, Format = "#,##0", AllowSort = true });



            this.pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "piutangRS", FieldHeader = "Piutang RS", SummaryType = SummaryType.Sum, Format = "#,##0", AllowSort = true, FieldCaption = "Piutang RS" });
            this.pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "umbal", FieldHeader = "Umbal BPJS", SummaryType = SummaryType.Sum, Format = "#,##0", AllowSort = true });
            this.pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "selisihUmbal", FieldHeader = "Selisih Dgn Umbal", SummaryType = SummaryType.Sum, Format = "#,##0", AllowSort = true, FieldCaption = "Selisih Umbal" });

            this.pivotGridControl1.ShowSubTotals = false;
            this.pivotGridControl1.ShowPivotValueChooser = true;
            this.pivotGridControl1.TableControl.AllowRowPivotFiltering = true;
            this.pivotGridControl1.TableControl.AllowRowResizeUsingCellBoundaries = true;
            this.pivotGridControl1.TableControl.AllowColumnResizeUsingCellBoundaries = true;
            
           // this.pivotGridControl1.RowPivotsOnly = true;
            this.pivotGridControl1.AllowSorting = true;
            pivotGridControl1.TableControl.FreezeHeaders = true;
            NewRuleConditionalFormat newRule1 = new NewRuleConditionalFormat();
            newRule1.RuleType = RuleType.FormatOnlyCellsThatContain;
            newRule1.SummaryElement = "Selisih";

            ConditionalFormat condition1 = new ConditionalFormat();
            condition1.ConditionType = PivotGridDataConditionType.LessThan;
            condition1.StartValue = 0;
            newRule1.Conditions.Add(condition1);

            PivotGridNewRuleConditionalFormat newRuleFormat1 = new PivotGridNewRuleConditionalFormat();
            newRuleFormat1.NewRuleCollections.Add(newRule1);
            newRuleFormat1.PivotCellStyle.BackColor = Color.Pink;
            newRuleFormat1.PivotCellStyle.TextColor = Color.White;
            this.pivotGridControl1.TableControl.NewRuleConditionalFormat.Add(newRuleFormat1);
            this.pivotGridControl1.Refresh();
            this.pivotGridControl1.ShowPivotTableFieldList = true;


            this.pivotGridControl1.ShowGroupBar = true;
            this.pivotGridControl1.PivotSchemaDesigner.RefreshGridSchemaLayout();
            pivotGridControl1.TableModel.Model.ColWidths[1] = 100;
            pivotGridControl1.TableModel.Model.ColWidths[2] = 400;

        }
        private void generateComboBox()

        {
            //cmbJenisPel.AutoCompleteMode = AutoCompleteMode.Append;
            List<string> listJenisPel = new List<string>();
            listJenisPel.Add("Rawat Jalan");
            listJenisPel.Add("Rawat Inap");
            cmbJenisPel.DataSource = listJenisPel;

            List<String> listJenisExportXls = new List<String>();
            listJenisExportXls.Add("Pivot");
            listJenisExportXls.Add("Cell");
            cmbExportXls.DataSource = listJenisExportXls;
        }
        //private void generateDataGridTest()
        //{
        //    this.sfDataGrid1.AutoGenerateColumns = false;
        //    sfDataGrid1.DataSource = getDataRawatJalan();
        //    this.sfDataGrid1.AllowGrouping = true;
        //    this.sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "vc_diagnosa_grouper", HeaderText = "Kode Ina" });
        //    this.sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "vc_deskripsi", HeaderText = "Deskripsi" });
        //    this.sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "vc_no_sep", HeaderText = "No SEP" });
        //    this.sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "dc_biaya_rs", HeaderText = "Tarif RS" });
        //    this.sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "dc_grouper", HeaderText = "Tarif Grouper" });
        //    sfDataGrid1.AutoSizeColumnsMode = AutoSizeColumnsMode.ColumnHeader;
        //    this.sfDataGrid1.GroupColumnDescriptions.Add(new GroupColumnDescription() { ColumnName = "vc_diagnosa_grouper" });
        //    //this.sfDataGrid1.GroupColumnDescriptions.Add(new GroupColumnDescription() { ColumnName = "vc_deskripsi" });
        //    this.sfDataGrid1.ExpandAllGroup();
        //    this.sfDataGrid1.AutoFitGroupDropAreaItem = true;

        //}

        private List<DiagnosaBpjs> getDataRawatJalan()
        {
            DataTable dt = new DataTable();

            string query = @"SELECT
	                            tagihan.vc_diagnosa_grouper,
	                            inacbg.vc_deskripsi,
	                            tagihan.vc_no_sep,
	                            kartuPiutang.dc_biaya_rs,
								kartuPiutang.dc_iur_pasien,
	                            kartuPiutang.dc_potongan,
                                kartuPiutang.dc_piutang_rs,
                                ISNULL(tagihan.dc_umbal,0) as dc_umbal,
                                ISNULL(tagihan.dc_umbal,0)-kartuPiutang.dc_piutang_rs as selisihUmbal,
                                dokter.vc_nama_kry
                            FROM
	                            AKPRJ_DTagihan tagihan
	                            INNER JOIN bpjs_sep sep ON sep.vc_no_sep = tagihan.vc_no_sep
	                            LEFT JOIN AKPRJ_KODE_INACBG inacbg ON inacbg.vc_kode_inacbg = tagihan.vc_diagnosa_grouper
	                            INNER JOIN AKPRJ_Kartu_piutang_JKN kartuPiutang ON kartuPiutang.vc_no_regj = tagihan.vc_no_regj
                                LEFT JOIN SDMDOKTER dokter ON dokter.vc_nid = tagihan.vc_nid_dpjp
                            WHERE
	                            ISNULL( sep.bt_hapus, '0' ) <> 1 
                                AND ISNULL(tagihan.dc_umbal,0) > 0
	                            AND Convert(DateTime, Convert(Varchar,Isnull(sep.dt_tgl_sep,0),101),101) between '" + dtFrom.Value.ToShortDateString() + "'   and '" + dtTo.Value.ToShortDateString() + "' ";
            using (SqlCommand cmd = new SqlCommand(query, clMain.DBConn.objConnection))
            {
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }

            List<DiagnosaBpjs> diagnosaBpjsList = new List<DiagnosaBpjs>();
            diagnosaBpjsList = (from System.Data.DataRow dr in dt.Rows
                                select new DiagnosaBpjs()
                                {
                                    diagnosa_grouper = dr["vc_diagnosa_grouper"].ToString(),
                                    deskripsi = dr["vc_deskripsi"].ToString(),
                                    no_sep = dr["vc_no_sep"].ToString(),
                                    biaya_rs = (decimal)dr["dc_biaya_rs"],
                                    iurPasien = (decimal)dr["dc_iur_pasien"],
                                    potongan = (decimal)dr["dc_potongan"],
                                    COB = (decimal)0.00,
                                    piutangRS = (decimal)dr["dc_piutang_rs"],
                                    umbal = (decimal)dr["dc_umbal"],
                                    namaDokter = dr["vc_nama_kry"].ToString(),
                                    selisihUmbal = (decimal)dr["selisihUmbal"]
                                }).ToList();
            return diagnosaBpjsList;

        }


        private List<DiagnosaBpjs> getDataRawatInap()
        {
            DataTable dt = new DataTable();

            string query = @"SELECT
	                            ISNULL(tagihan.vc_diagnosa_grouper,'') vc_diagnosa_grouper,
	                            ISNULL( inacbg.vc_deskripsi,'-') vc_deskripsi,
	                            tagihan.vc_no_sep,
	                            kartuPiutang.dc_biaya_rs,
								kartuPiutang.dc_iur_pasien,
	                            kartuPiutang.dc_potongan,
								kartuPiutang.dc_nominal_instansi_lain,
                                kartuPiutang.dc_piutang_rs,
                                ISNULL(tagihan.dc_umbal,0) as dc_umbal,
                                ISNULL(tagihan.dc_umbal,0)-kartuPiutang.dc_piutang_rs as selisihUmbal,
                                dokter.vc_nama_kry
                            FROM
	                            AKPRI_DTagihan tagihan
	                            INNER JOIN bpjs_sep sep ON sep.vc_no_sep = tagihan.vc_no_sep
	                            LEFT JOIN AKPRI_KODE_INACBG inacbg ON inacbg.vc_kode_inacbg = tagihan.vc_diagnosa_grouper
	                            INNER JOIN AKPRI_Kartu_piutang_JKN kartuPiutang ON kartuPiutang.vc_no_reg = tagihan.vc_no_reg
                                 LEFT JOIN SDMDOKTER dokter ON dokter.vc_nid = tagihan.vc_nid_dpjp
                            WHERE
	                            ISNULL( sep.bt_hapus, '0' ) <> 1 
                            	AND ISNULL(kartuPiutang.dc_umbal,'0') <> 0
	                            AND Convert(DateTime, Convert(Varchar,Isnull(sep.dt_tgl_sep,0),101),101) between '" + dtFrom.Value.ToShortDateString() + "'   and '" + dtTo.Value.ToShortDateString() + "' ";
            
            string queryCOB = @"SELECT
	                            ISNULL(dtagih.vc_diagnosa_grouper,'') vc_diagnosa_grouper,
	                            ISNULL( inacbg.vc_deskripsi,'-') vc_deskripsi,
	                            dtagih.vc_no_sep,
	                            kartuPiutang.dc_biaya_rs,
								kartuPiutang.dc_iur_pasien,
	                            kartuPiutang.dc_potongan,
								kartuPiutang.dc_nominal_instansi_lain,
                                kartuPiutang.dc_piutang_rs,
                                ISNULL(dtagih.dc_umbal,0) as dc_umbal,
                                ISNULL(dtagih.dc_umbal,0)-kartuPiutang.dc_piutang_rs as selisihUmbal,
	                            dokter.vc_nama_kry 
                            FROM
	                            AKPRI_COB_HTagihan htagih
	                            INNER JOIN AKPRI_COB_DTagihan dtagih ON htagih.vc_kd_tagihan = dtagih.vc_kd_tagihan
	                            INNER JOIN bpjs_sep sep ON sep.vc_no_sep = dtagih.vc_no_sep
	                            LEFT JOIN AKPRI_KODE_INACBG inacbg ON inacbg.vc_kode_inacbg = dtagih.vc_diagnosa_grouper
	                            INNER JOIN AKPRI_Kartu_piutang_JKN kartuPiutang ON kartuPiutang.vc_no_reg = dtagih.vc_no_reg
	                            INNER JOIN RMP_inap inap ON inap.vc_no_reg = dtagih.vc_no_reg
	                            LEFT JOIN SDMDOKTER dokter ON dokter.vc_nid = inap.vc_nid 
                            WHERE
	                            htagih.vc_k_png = '4ye'
	                            AND ISNULL(kartuPiutang.dc_umbal,'0') <> 0
                                AND ISNULL( sep.bt_hapus, '0' ) <> 1 
	                            AND Convert(DateTime, Convert(Varchar,Isnull(sep.dt_tgl_sep,0),101),101) between '" + dtFrom.Value.ToShortDateString() + "'   and '" + dtTo.Value.ToShortDateString() + "' ";

            string queryAll = query + " UNION ALL " + queryCOB;
            using (SqlCommand cmd = new SqlCommand(queryAll, clMain.DBConn.objConnection))
            {
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }

            List<DiagnosaBpjs> diagnosaBpjsList = new List<DiagnosaBpjs>();
            diagnosaBpjsList = (from System.Data.DataRow dr in dt.Rows
                                select new DiagnosaBpjs()
                                {
                                    diagnosa_grouper = dr["vc_diagnosa_grouper"].ToString(),
                                    deskripsi = dr["vc_deskripsi"].ToString(),
                                    no_sep = dr["vc_no_sep"].ToString(),
                                    biaya_rs = (decimal)dr["dc_biaya_rs"],
                                    iurPasien = (decimal)dr["dc_iur_pasien"],
                                    potongan = (decimal)dr["dc_potongan"],
                                    COB = (decimal)0.00,
                                    piutangRS = (decimal)dr["dc_piutang_rs"],
                                    umbal = (decimal)dr["dc_umbal"],
                                    namaDokter = dr["vc_nama_kry"].ToString(),
                                    selisihUmbal = (decimal)dr["selisihUmbal"]
                                }).ToList();
            return diagnosaBpjsList;

        }

        private void btnExportXls_Click(object sender, EventArgs e)
        {
            var ExportAsPivotTable = (cmbExportXls.SelectedIndex == 0);



            SaveFileDialog savedialog = new SaveFileDialog();

            savedialog.AddExtension = true;

            savedialog.FileName = "Sample";

            savedialog.DefaultExt = "xlsx";

            savedialog.Filter = @"Excel file (.xlsx)|*.xlsx";



            if (savedialog.ShowDialog() == DialogResult.OK)

            {

                ExcelExport excelExport = new ExcelExport(pivotGridControl1, ExcelVersion.Excel2010);

                excelExport.ExportMode = (ExportAsPivotTable) ? ExportModes.PivotTable : ExportModes.Cell;

                excelExport.Export(savedialog.FileName);



                if (MessageBox.Show(@"Export Success! Do you want to open the exported file?", Text, MessageBoxButtons.YesNo) == DialogResult.Yes)

                {

                    var p = new Process();

                    p.StartInfo = new ProcessStartInfo(savedialog.FileName)

                    {

                        UseShellExecute = true

                    };

                    p.Start();

                }



            }
        }

        private void btnExportPdf_Click(object sender, EventArgs e)
        {


            SaveFileDialog savedialog = new SaveFileDialog();

            savedialog.AddExtension = true;

            savedialog.FileName = "AnalisaBPJS";

            savedialog.DefaultExt = "pdf";

            savedialog.Filter = @"Pdf file (.pdf)|*.pdf";

            if (savedialog.ShowDialog() == DialogResult.OK)

            {

                PivotPdfExport pdfExport = new PivotPdfExport(pivotGridControl1);

                pdfExport.Export(savedialog.FileName);

                if (MessageBox.Show(@"Export Success! Do you want to open the exported file?", Text, MessageBoxButtons.YesNo) == DialogResult.Yes)



                {

                    var p = new Process();

                    p.StartInfo = new ProcessStartInfo(savedialog.FileName)

                    {

                        UseShellExecute = true

                    };

                    p.Start();

                }




            }

        }

        private void btnExportWord_Click(object sender, EventArgs e)
        {
            SaveFileDialog savedialog = new SaveFileDialog();

            savedialog.AddExtension = true;

            savedialog.FileName = "Sample";

            savedialog.DefaultExt = "Doc";

            savedialog.Filter = @"Word file (.Doc)|*.Doc";

            if (savedialog.ShowDialog() == DialogResult.OK)

            {

                PivotWordExport wordExport = new PivotWordExport(pivotGridControl1);

                wordExport.pivotGridToWord(savedialog.FileName);



                if (MessageBox.Show(@"Export Success! Do you want to open the exported file?", Text, MessageBoxButtons.YesNo) == DialogResult.Yes)



                {

                    var p = new Process();

                    p.StartInfo = new ProcessStartInfo(savedialog.FileName)

                    {

                        UseShellExecute = true

                    };

                    p.Start();

                }



            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if(cmbJenisPel.Text.Equals(""))
            {
                MsgBoxUtil.MsgError("Jenis Pelayanan Belum Dipilih");
                return;
            }
            genarateData();
        }

 
    }
}



