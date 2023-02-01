﻿using Casemix.Model;
using Syncfusion.PivotAnalysis.Base;
using Syncfusion.PivotConverter;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.PivotAnalysis;
using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casemix.Forms.Analisa_Non_BPJS
{
    public partial class FrmAnalisaICD10 : Form
    {
        FrmAnalisaICD10Dtl FrmAnalisaICD10Dtl;
        public FrmAnalisaICD10()
        {
            InitializeComponent();
            generateComboBox();
        }

        private void generateComboBox()

        {

            List<String> listJenisExportXls = new List<String>();
            listJenisExportXls.Add("Pivot");
            listJenisExportXls.Add("Cell");
            cmbExportXls.DataSource = listJenisExportXls;
        }
       

        private void btnLoad_Click(object sender, EventArgs e)
        {

            pivotGridControl1.ItemSource = null;
            genarateData();
            pivotGridControl1.TableModel.Refresh();
            pivotGridControl1.Refresh();
        }

        private void genarateData()
        {
            DataTable dt = new DataTable();
            this.pivotGridControl1.ItemSource = getDataRawatInapTest();

            this.pivotGridControl1.TableModel.QueryCellInfo += TableModel_QueryCellInfo;

            this.pivotGridControl1.TableControl.CellClick += TableControl_CellClick;

            //tab key navigation set as false to move the next control
            pivotGridControl1.TableControl.WantTabKey = false;
            this.pivotGridControl1.GridVisualStyles = GridVisualStyles.Metro;

            this.pivotGridControl1.PivotRows.Add(new PivotItem { FieldMappingName = "kodeICD10", FieldHeader = "ICD 10", AllowSort = true });
            if (chkBoxSort.Checked)
            {
                this.pivotGridControl1.RowPivotsOnly = true;
            }
            else
            {
                this.pivotGridControl1.RowPivotsOnly = false;
                this.pivotGridControl1.PivotRows.Add(new PivotItem { FieldMappingName = "deskripsiIcd", FieldHeader = "Diagnosa", AllowSort = true });

            }
            this.pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "noReg", FieldHeader = "Total", AllowSort = true });

            this.pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "biayaRS", FieldHeader = "Total Biaya RS", SummaryType = SummaryType.Sum, Format = "#,##0", AllowSort = true });

            this.pivotGridControl1.ShowSubTotals = false;
            this.pivotGridControl1.ShowPivotValueChooser = true;
            this.pivotGridControl1.TableControl.AllowRowPivotFiltering = true;
            this.pivotGridControl1.TableControl.AllowRowResizeUsingCellBoundaries = true;
            this.pivotGridControl1.TableControl.AllowColumnResizeUsingCellBoundaries = true;


            this.pivotGridControl1.Refresh();
            this.pivotGridControl1.ShowPivotTableFieldList = true;
            this.pivotGridControl1.ShowGroupBar = true;

            this.pivotGridControl1.PivotSchemaDesigner.RefreshGridSchemaLayout();
            pivotGridControl1.TableModel.Model.ColWidths[1] = 80;
            pivotGridControl1.TableModel.Model.ColWidths[2] = 500;

        }

        private void TableControl_CellClick(object sender, GridCellClickEventArgs e)
        {
            PivotGridControlBase pivotGridControlBase = sender as PivotGridControlBase;
            if (pivotGridControlBase != null)
            {
                int row = pivotGridControlBase.CurrentCell.RowIndex - 1;
                int col = pivotGridControlBase.CurrentCell.ColIndex - 1;
                if (row != 0)
                {
                    var rawItems = this.pivotGridControl1.PivotEngine.GetRawItemsFor(row, col);


                    //frmAnalisaPerDokterDtl.jenisPerawatan = cmbJenisPel.Text;
                    if (FrmAnalisaICD10Dtl == null)
                    {
                        FrmAnalisaICD10Dtl = new FrmAnalisaICD10Dtl();
                        FrmAnalisaICD10Dtl.rawValue = rawItems;
                        FrmAnalisaICD10Dtl.Show();
                        FrmAnalisaICD10Dtl.Closed += (s, ea) => FrmAnalisaICD10Dtl = null;
                    }

                    // frmAnalisaPerDokterDtl.Close();
                }

            }
        }

        private void FrmAnalisaICD10_Load(object sender, EventArgs e)
        {

        }
    

    private void TableModel_QueryCellInfo(object sender, GridQueryCellInfoEventArgs e)
        {
            if (e.RowIndex > this.pivotGridControl1.PivotColumns.Count + (this.pivotGridControl1.PivotCalculations.Count > 1 && this.pivotGridControl1.PivotEngine.ShowCalculationsAsColumns ? 1 : 0) && e.ColIndex > this.pivotGridControl1.PivotRows.Count + (this.pivotGridControl1.PivotEngine.ShowCalculationsAsColumns ? 0 : 1) && e.Style.CellValue != null)
            {
                e.Style.CellType = "HyperlinkCell";
                e.Style.Tag = null;
            }
        }


        private DataTable getDataRawatInapTest()
        {
            string query = @"DECLARE @cols AS NVARCHAR ( MAX ),
                            @colsNotNULL AS NVARCHAR ( MAX ),
                                @query AS NVARCHAR ( MAX );
                            SET @cols = STUFF(
	                            (
		                            SELECT  DISTINCT
			                            ',' + QUOTENAME( bagian ) 
		                                FROM
			                                (
			                                SELECT DISTINCT(x.vc_nm_bagian) bagian  FROM KeuRincian  cc
				                                INNER JOIN pubbagian x
				                                on x.vc_kd_bagian = SUBSTRING ( cc.vc_no_bukti, 7, 2 )
				                                and DT_Tgl_Trans >= '2020-01-01 00:00:00.000'
			                                ) AS c FOR XML PATH ( '' ),
			                                TYPE 
		                                ).value ( '.', 'NVARCHAR(MAX)' ),
		                                1,
		                                1,		'' 
	                                ) 

                                SET @colsNotNULL = STUFF(
	                                (
		                                SELECT  DISTINCT
			                                ', ISNULL(' + QUOTENAME( c.bagian ) + ',0) AS ' + QUOTENAME( c.bagian ) 
		                                FROM
			                                (
			                                SELECT DISTINCT(x.vc_nm_bagian) bagian  FROM KeuRincian  cc
				                                INNER JOIN pubbagian x
				                                on x.vc_kd_bagian = SUBSTRING ( cc.vc_no_bukti, 7, 2 )
					                                and DT_Tgl_Trans >= '2020-01-01 00:00:00.000'
			                                ) AS c FOR XML PATH ( '' ),
			                                TYPE 
		                                ).value ( '.', 'NVARCHAR(MAX)' ),
		                                1,
		                                1,		'' 
	                                ) 

	                                SET @query = 'SELECT vc_no_reg as noReg,
                                        vc_no_rm as noRM,
                                        vc_nama_p as namaPasien,
                                        vc_kode_icd as kodeICD10,
                                        vc_nama_icd as deskripsiIcd,
                                        vc_k_png as kdPng,
                                        vc_n_png as namaPng, 
                                        dt_tgl_msk,
                                        dt_tgl_pul,
                                        ' + @colsNotNULL + ' ,
                                        totalBiayaRS as biayaRS FROM (SELECT
                                inap.vc_no_reg,
	                                inap.vc_no_rm,
	                                pasien.vc_nama_p,
	                                kamus.vc_kode_icd,
	                                kamus.vc_nama_icd,
	                                png.vc_k_png,
	                                png.vc_n_png,
	                                inap.dt_tgl_msk,
	                                inap.dt_tgl_pul,
	                                ISNULL((
                                SELECT CAST
	                                (
	                                floor( ceiling( SUM ( nu_Sub_total ) + 49 ) / 50 ) * 50 AS DECIMAL ( 18, 2 )) 
                                FROM
	                                KeuRincian 
                                WHERE
	                                VC_no_reg = inap.vc_no_reg 
	                                ),
	                                0 
	                                ) AS totalBiayaRS,
	                                dd.vc_nm_bagian,
	                                ISNULL(SUM ( aa.dc_qty * aa.dc_rupiah ),0) AS dc_tarip 
                                FROM
	                                KeuRinciInapKomponen aa
	                                LEFT JOIN KeuRincian cc ON cc.vc_no_bukti = aa.vc_no_bukti
	                                LEFT JOIN PubBagian dd ON SUBSTRING ( cc.vc_no_bukti, 7, 2 ) = dd.vc_kd_bagian
	                                INNER JOIN RMRanap ranap ON ranap.vc_No_Reg = cc.VC_No_Reg
	                                INNER JOIN RMP_inap inap ON inap.vc_no_reg = ranap.vc_No_Reg
	                                INNER JOIN RMIcdKamus kamus ON kamus.vc_kode_icd = ranap.VC_DiagnosaAkhir
	                                INNER JOIN RMPasien pasien ON pasien.vc_no_rm = inap.vc_no_rm
	                                INNER JOIN PubPng png ON png.vc_k_png = inap.vc_k_png 
                                WHERE
	                                Convert(DateTime, Convert(Varchar,Isnull(inap.dt_tgl_msk,0),101),101) between''@dateFrom''   and  ''@dateTo''
                                GROUP BY
	                                inap.vc_no_reg,	inap.vc_no_rm,
		                                pasien.vc_nama_p,
                                vc_kode_icd,vc_nama_icd,
	                                vc_nm_bagian,
	                                dd.vc_kd_bagian,	png.vc_k_png,
	                                png.vc_n_png,
	                                inap.dt_tgl_msk,
	                                inap.dt_tgl_pul ) hasil
	                                PIVOT
                                (
                                  SUM(dc_tarip)
                                  FOR vc_nm_bagian IN ( ' + @cols + ') 
                                ) AS p;' 
                                EXECUTE ( @query )
                         ";

            query = query.Replace("@dateFrom", dtFrom.Value.ToShortDateString());
            query = query.Replace("@dateTo", dtTo.Value.ToShortDateString());
            DataTable dt = new DataTable();
            using (SqlCommand cmd = new SqlCommand(query, clMain.DBConn.objConnection))
            {
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }
        private List<AnalisaICD10> getDataRawatInap()
        {
            DataTable dt = new DataTable();

            string query = @"SELECT  a.* FROM (SELECT
                                       kamus.vc_kode_icd,
                                       kamus.vc_nama_icd,
                                       inap.vc_no_reg,
                                       inap.vc_no_rm,
                     png.vc_k_png,png.vc_n_png,
                                       pasien.vc_nama_p,
                                       inap.dt_tgl_msk,
                                       inap.dt_tgl_pul,	ISNULL((
            	SELECT CAST
            		(
            		floor(ceiling( SUM ( nu_Sub_total ) + 49 ) / 50 ) * 50 AS DECIMAL ( 18, 2 )) 
            	FROM
            		KeuRincian 
            	WHERE
            		VC_no_reg = inap.vc_no_reg 
            		),
            	0 
            ) AS totalBiayaRS
                                      FROM
                                       RMRanap ranap
                                       INNER JOIN RMP_inap inap ON inap.vc_no_reg = ranap.vc_No_Reg
                                       INNER JOIN RMIcdKamus kamus ON kamus.vc_kode_icd = ranap.VC_DiagnosaAkhir
                                       INNER JOIN RMPasien pasien ON pasien.vc_no_rm = inap.vc_no_rm 
                                        INNER JOIN PubPng png on png.vc_k_png = inap.vc_k_png
                                        AND ISNULL(inap.Dt_tgl_pul,'') <> '' ) a  where a.totalBiayaRS  <> 0.00
                                 AND Convert(DateTime, Convert(Varchar,Isnull(dt_tgl_msk,0),101),101) between '" + dtFrom.Value.ToShortDateString() + "'   and '" + dtTo.Value.ToShortDateString() + "' ";

   

            using (SqlCommand cmd = new SqlCommand(query, clMain.DBConn.objConnection))
            {
                //cmd.Parameters.AddWithValue("@dateFrom", dtFrom.Value.ToShortDateString());

//                cmd.Parameters.AddWithValue("@dateTo", dtTo.Value.ToShortDateString());
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }

            List<AnalisaICD10> analisaICD10s = new List<AnalisaICD10>();
            analisaICD10s = (from System.Data.DataRow dr in dt.Rows
                             select new AnalisaICD10()
                             {
                                 kodeICD10 = dr["vc_kode_icd"].ToString(),
                                 deskripsiIcd = dr["vc_nama_icd"].ToString(),
                                 noReg = dr["vc_no_reg"].ToString(),
                                  noRM = dr["vc_no_rm"].ToString(),
                                 namaPasien = dr["vc_nama_p"].ToString(),
                                 kdPng = dr["vc_k_png"].ToString(),
                                 namaPng = dr["vc_n_png"].ToString(),
                                 biayaRS = (decimal) (dr["totalBiayaRS"])

                             }).ToList();
            return analisaICD10s;

        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            var ExportAsPivotTable = (cmbExportXls.SelectedIndex == 0);



            SaveFileDialog savedialog = new SaveFileDialog();

            savedialog.AddExtension = true;

            savedialog.FileName = "AnalisaICD10";

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

        private void btnExportWord_Click(object sender, EventArgs e)
        {
            SaveFileDialog savedialog = new SaveFileDialog();

            savedialog.AddExtension = true;

            savedialog.FileName = "AnalisaIcd10";

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

        private void btnExportPdf_Click(object sender, EventArgs e)
        {


            SaveFileDialog savedialog = new SaveFileDialog();

            savedialog.AddExtension = true;

            savedialog.FileName = "AnalisaICD10";

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
    }
}
