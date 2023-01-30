using Casemix.Model;
using Syncfusion.PivotAnalysis.Base;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.PivotAnalysis;
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

namespace Casemix.Forms.Analisa_Non_BPJS
{
    public partial class FrmAnalisaICD10 : Form
    {
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
        private List<AnalisaDokter> getDataRawatInap()
        {
            DataTable dt = new DataTable();
            //non cob            
            string query = @"SELECT
	                            dokter.vc_nama_kry,
	                            spesialis.vc_n_jpend,
	                            tagihan.vc_no_sep,
                                tagihan.vc_no_rm,
                                tagihan.vc_no_reg,
                                pasien.vc_nama_p,
	                            kartuPiutang.dc_biaya_rs,
								kartuPiutang.dc_iur_pasien,
	                            kartuPiutang.dc_potongan,
								kartuPiutang.dc_nominal_instansi_lain,
                                kartuPiutang.dc_piutang_rs,
                                ISNULL(tagihan.dc_umbal,0) as dc_umbal,
                                ISNULL(tagihan.dc_umbal,0)-kartuPiutang.dc_piutang_rs as selisihUmbal,
                            CASE
	
	                            WHEN DATEDIFF(
	                            DAY,
	                            (
                            SELECT CONVERT
	                            ( VARCHAR, inap.dt_tgl_msk, 23 )),
	                            ( SELECT CONVERT ( VARCHAR, inap.dt_tgl_pul, 23 ) )) = 0 THEN
	                            1 ELSE DATEDIFF(
	                            DAY,
	                            (
                            SELECT CONVERT
	                            ( VARCHAR, inap.dt_tgl_msk, 23 )),
	                            ( SELECT CONVERT ( VARCHAR, inap.dt_tgl_pul, 23 ) )) 
	                            END AS LOS 
                            FROM
	                            AKPRI_DTagihan tagihan
	                            INNER JOIN bpjs_sep sep ON sep.vc_no_sep = tagihan.vc_no_sep
	                            LEFT JOIN SDMDOKTER dokter ON dokter.vc_nid = tagihan.vc_nid_dpjp
	                            INNER JOIN AKPRI_Kartu_piutang_JKN_V kartuPiutang ON kartuPiutang.vc_no_reg = tagihan.vc_no_reg
	                            left join SDMJ_Pend spesialis ON spesialis.vc_k_jpend = dokter.vc_k_jpend
	                            INNER JOIN RMP_inap inap ON inap.vc_no_reg = tagihan.vc_no_reg 
                                INNER JOIN RMpasien pasien on pasien.vc_no_rm = inap.vc_no_rm
                            WHERE
	                            ISNULL( sep.bt_hapus, '0' ) <> 1
								AND ISNULL(kartuPiutang.dc_umbal,'0') <> 0
                                AND Convert(DateTime, Convert(Varchar,Isnull(sep.dt_tgl_sep,0),101),101) between '" + dtFrom.Value.ToShortDateString() + "'   and '" + dtTo.Value.ToShortDateString() + "' ";

            //cob
            string query_cob = @"SELECT
	                                dokter.vc_nama_kry,
	                                spesialis.vc_n_jpend,
	                                dtagih.vc_no_sep,
                                    dtagih.vc_no_rm,
                                    dtagih.vc_no_reg,
                                    pasien.vc_nama_p,
	                            kartuPiutang.dc_biaya_rs,
								kartuPiutang.dc_iur_pasien,
	                            kartuPiutang.dc_potongan,
								kartuPiutang.dc_nominal_instansi_lain,
                                kartuPiutang.dc_piutang_rs,
                                ISNULL(dtagih.dc_umbal,0) as dc_umbal,
                                ISNULL(dtagih.dc_umbal,0)-kartuPiutang.dc_piutang_rs as selisihUmbal,
                                CASE
	
	                                WHEN DATEDIFF(
	                                DAY,
	                                (
                                SELECT CONVERT
	                                ( VARCHAR, inap.dt_tgl_msk, 23 )),
	                                ( SELECT CONVERT ( VARCHAR, inap.dt_tgl_pul, 23 ) )) = 0 THEN
	                                1 ELSE DATEDIFF(
	                                DAY,
	                                (
                                SELECT CONVERT
	                                ( VARCHAR, inap.dt_tgl_msk, 23 )),
	                                ( SELECT CONVERT ( VARCHAR, inap.dt_tgl_pul, 23 ) )) 
	                                END AS LOS
                                FROM
	                                AKPRI_COB_HTagihan htagih
	                                INNER JOIN AKPRI_COB_DTagihan dtagih ON htagih.vc_kd_tagihan = dtagih.vc_kd_tagihan
	                                INNER JOIN bpjs_sep sep ON sep.vc_no_sep = dtagih.vc_no_sep
	                                INNER JOIN AKPRI_Kartu_piutang_JKN kartuPiutang ON kartuPiutang.vc_no_reg = dtagih.vc_no_reg
	                                INNER JOIN RMP_inap inap ON inap.vc_no_reg = dtagih.vc_no_reg
                                    INNER JOIN RMpasien pasien on pasien.vc_no_rm = dtagih.vc_no_rm
	                                LEFT JOIN SDMDOKTER dokter ON dokter.vc_nid = inap.vc_nid
	                               left join  SDMJ_Pend spesialis ON spesialis.vc_k_jpend = dokter.vc_k_jpend 
                                WHERE
	                                ISNULL( sep.bt_hapus, '0' ) <> 1 
									AND ISNULL(kartuPiutang.dc_umbal,'0') <> 0
	                                AND htagih.vc_k_png = @pngJKN  
                                    AND Convert(DateTime, Convert(Varchar,Isnull(sep.dt_tgl_sep,0),101),101) between '" + dtFrom.Value.ToShortDateString() + "'   and '" + dtTo.Value.ToShortDateString() + "' ";

            string queryAll = query + " UNION ALL " + query_cob;

            using (SqlCommand cmd = new SqlCommand(queryAll, clMain.DBConn.objConnection))
            {
                cmd.Parameters.AddWithValue("@pngJKN", FrmMain.kdJKN);
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }

            List<AnalisaDokter> diagnosaBpjsList = new List<AnalisaDokter>();
            diagnosaBpjsList = (from System.Data.DataRow dr in dt.Rows
                                select new AnalisaDokter()
                                {
                                    namaDokter = dr["vc_nama_kry"].ToString(),
                                    spesialisasi = dr["vc_n_jpend"].ToString(),
                                    no_sep = dr["vc_no_sep"].ToString(),
                                    noRM = dr["vc_no_rm"].ToString(),
                                    noReg = dr["vc_no_reg"].ToString(),
                                    namaPasien = dr["vc_nama_p"].ToString(),
                                    biaya_rs = (decimal)dr["dc_biaya_rs"],
                                    iurPasien = (decimal)dr["dc_iur_pasien"],
                                    potongan = (decimal)dr["dc_potongan"],
                                    COB = (decimal)dr["dc_nominal_instansi_lain"],
                                    piutangRS = (decimal)dr["dc_piutang_rs"],
                                    umbal = (decimal)dr["dc_umbal"],
                                    selisihUmbal = (decimal)dr["selisihUmbal"],
                                    los = (int)dr["los"]
                                }).ToList();
            return diagnosaBpjsList;

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
            this.pivotGridControl1.ItemSource = getDataRawatInapOld();

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
                this.pivotGridControl1.PivotRows.Add(new PivotItem { FieldMappingName = "deskripsiIcd", FieldHeader = "Deskripsi", AllowSort = true });

            }
            this.pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "noReg", FieldHeader = "Total", AllowSort = true });

            this.pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "biayaRS", FieldHeader = "Biaya RS", SummaryType = SummaryType.Sum, Format = "#,##0", AllowSort = true });

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
            //  throw new NotImplementedException();
        }

        private void TableModel_QueryCellInfo(object sender, GridQueryCellInfoEventArgs e)
        {
            // throw new NotImplementedException();
        }

        private List<AnalisaICD10> getDataRawatInapOld()
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

    }
}
