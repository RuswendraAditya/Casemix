using Casemix.Model;
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

namespace Casemix.Forms.Analisa_BPJS
{
    public partial class FrmAnaliasaPerDokter : Form
    {
        FrmAnalisaPerDokterDtl frmAnalisaPerDokterDtl;
        public FrmAnaliasaPerDokter()
        {
            InitializeComponent();
            generateComboBox();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (cmbJenisPel.Text.Equals(""))
            {
                MsgBoxUtil.MsgError("Jenis Pelayanan Belum Dipilih");
                return;
            }

          
            genarateData();
            pivotGridControl1.TableModel.Refresh();
            pivotGridControl1.Refresh();
        }

        private void genarateData()
        {
            if (cmbJenisPel.Text.Equals("Rawat Jalan"))
            {
                this.pivotGridControl1.ItemSource = getDataRawatJalan();

            }
            if (cmbJenisPel.Text.Equals("Rawat Inap"))
                {
                this.pivotGridControl1.ItemSource = getDataRawatInap();
            }

            this.pivotGridControl1.TableModel.QueryCellInfo += TableModel_QueryCellInfo;

            this.pivotGridControl1.TableControl.CellClick += TableControl_CellClick;

            //tab key navigation set as false to move the next control
            pivotGridControl1.TableControl.WantTabKey = false;
            this.pivotGridControl1.GridVisualStyles = GridVisualStyles.Metro;
           
            this.pivotGridControl1.PivotRows.Add(new PivotItem { FieldMappingName = "namaDokter", FieldHeader = "Nama Dokter", AllowSort = true });
            if (chkBoxSort.Checked)
            {
                this.pivotGridControl1.RowPivotsOnly = true;
            }
            else
            {
                this.pivotGridControl1.RowPivotsOnly = false;
                this.pivotGridControl1.PivotRows.Add(new PivotItem { FieldMappingName = "spesialisasi", FieldHeader = "Spesialisasi", AllowSort = true });

            }
            this.pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "no_sep", FieldHeader = "Total Kasus(SEP)", AllowSort = true });
           
            this.pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "biaya_rs", FieldHeader = "Biaya RS", SummaryType = SummaryType.Sum, Format = "#,##0", AllowSort = true });

            this.pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "iurPasien", FieldHeader = "Iuran Pasien", SummaryType = SummaryType.Sum, Format = "#,##0", AllowSort = true });

            this.pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "potongan", FieldHeader = "Potongan", SummaryType = SummaryType.Sum, Format = "#,##0", AllowSort = true });

            this.pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "COB", FieldHeader = "COB", SummaryType = SummaryType.Sum, Format = "#,##0", AllowSort = true });



            this.pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "piutangRS", FieldHeader = "Piutang RS", SummaryType = SummaryType.Sum, Format = "#,##0", AllowSort = true, FieldCaption = "Piutang RS" });
            this.pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "umbal", FieldHeader = "Umbal BPJS", SummaryType = SummaryType.Sum, Format = "#,##0", AllowSort = true });
            this.pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "selisihUmbal", FieldHeader = "Selisih DUmbal", SummaryType = SummaryType.Sum, Format = "#,##0", AllowSort = true, FieldCaption = "Selisih Umbal" });
           

            if (cmbJenisPel.Text.Equals("Rawat Inap"))
            {
                this.pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "los", FieldHeader = "LOS", SummaryType =SummaryType.Average,  AllowSort = true });

            }

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
            pivotGridControl1.TableModel.Model.ColWidths[1] = 300;
            pivotGridControl1.TableModel.Model.ColWidths[2] = 200;
        
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
                    if (frmAnalisaPerDokterDtl==null)
                    {
                        frmAnalisaPerDokterDtl = new FrmAnalisaPerDokterDtl();
                        frmAnalisaPerDokterDtl.rawValue = rawItems;
                        frmAnalisaPerDokterDtl.Show();
                        frmAnalisaPerDokterDtl.Closed += (s, ea) => frmAnalisaPerDokterDtl = null;
                    }
                   
                    // frmAnalisaPerDokterDtl.Close();
                }

            }
        }
        private void Window_Closed(object sender, EventArgs e)
        {
            if (frmAnalisaPerDokterDtl != null) frmAnalisaPerDokterDtl.Close();
        }
        private void TableControl_HyperlinkCellClick(object sender, HyperlinkCellClickEventArgs e)
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

       
        private void generateComboBox()

        {
            //cmbJenisPel.AutoCompleteMode = AutoCompleteMode.Append;
            List<string> listJenisPel = new List<string>();
            listJenisPel.Add("Rawat Jalan");
            listJenisPel.Add("Rawat Inap");
            cmbJenisPel.DataSource = listJenisPel;
            cmbJenisPel.SelectedIndex = 0;
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

        private List<AnalisaDokter> getDataRawatJalan()
        {
            DataTable dt = new DataTable();

            string query = @"SELECT
	                            dokter.vc_nama_kry,
								spesialis.vc_n_jpend,
	                            tagihan.vc_no_sep,
                                tagihan.vc_no_rm,
                                tagihan.vc_no_regj,
                                pasien.vc_nama_p,
	                            kartuPiutang.dc_biaya_rs,
								kartuPiutang.dc_iur_pasien,
	                            kartuPiutang.dc_potongan,
                                kartuPiutang.dc_piutang_rs,
                                ISNULL(tagihan.dc_umbal,0) as dc_umbal,
                                ISNULL(tagihan.dc_umbal,0)-kartuPiutang.dc_piutang_rs as selisihUmbal,vc_n_klinik as klinik
                            FROM
	                            AKPRJ_DTagihan tagihan
	                            INNER JOIN bpjs_sep sep ON sep.vc_no_sep = tagihan.vc_no_sep
	                            LEFT JOIN SDMDOKTER dokter ON dokter.vc_nid = tagihan.vc_nid_dpjp
                                INNER JOIN RMKunjung kunjung on kunjung.vc_no_regj = tagihan.vc_no_regj
                                INNER JOIN RMpasien pasien on pasien.vc_no_rm = kunjung.vc_no_rm
	                            INNER JOIN AKPRJ_Kartu_piutang_JKN_V kartuPiutang ON kartuPiutang.vc_no_regj = tagihan.vc_no_regj 
                                INNER JOIN RMKLINIK klinik on klinik.vc_k_klinik = kunjung.VC_K_KLINIK
								left join SDMJ_Pend spesialis on spesialis.vc_k_jpend = dokter.vc_k_jpend
                            WHERE
	                            ISNULL( sep.bt_hapus, '0' ) <> 1
								AND ISNULL(tagihan.dc_umbal,0) <> 0
	                            AND Convert(DateTime, Convert(Varchar,Isnull(sep.dt_tgl_sep,0),101),101) between '" + dtFrom.Value.ToShortDateString() + "'   and '" + dtTo.Value.ToShortDateString() + "' ";
            using (SqlCommand cmd = new SqlCommand(query, clMain.DBConn.objConnection))
            {
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }
           
            List<AnalisaDokter> diagnosaBpjsList = new List<AnalisaDokter>();
            diagnosaBpjsList.Clear();
            diagnosaBpjsList = (from System.Data.DataRow dr in dt.Rows
                                select new AnalisaDokter()
                                {
                                    namaDokter= dr["vc_nama_kry"].ToString(),
                                    spesialisasi = dr["vc_n_jpend"].ToString(),
                                    no_sep = dr["vc_no_sep"].ToString(),
                                    noRM = dr["vc_no_rm"].ToString(),
                                    noReg = dr["vc_no_regj"].ToString(),
                                    namaPasien = dr["vc_nama_p"].ToString(),
                                    biaya_rs = (decimal)dr["dc_biaya_rs"],
                                    iurPasien = (decimal)dr["dc_iur_pasien"],
                                    potongan = (decimal)dr["dc_potongan"],
                                    COB = (decimal)0.00,
                                    piutangRS = (decimal)dr["dc_piutang_rs"],
                                    umbal = (decimal)dr["dc_umbal"],
                                    selisihUmbal = (decimal)dr["selisihUmbal"],
                                    analisaTarifs = getTarifRJByReg(dr["vc_no_regj"].ToString()),
                                    klinik = dr["klinik"].ToString()
                                }).ToList();
            return diagnosaBpjsList;

        }

        private List<AnalisaTarif> getTarifRJByReg(string noReg)
        {
            List<AnalisaTarif> analisaTarifs = new List<AnalisaTarif>();
            DataTable dt = new DataTable();

            string query = @"
                            SELECT VC_No_RegJ noReg,KeuRincianRJ.VC_No_Bukti nobukti,KeuRinciPiutRJ.VC_Kd_GsKlCo kodetarif
                            ,KeuTaripDasar.VC_Nm_Tarip namatarip,DC_Qty qty,DC_Rupiah rupiah, CAST(DC_Qty* DC_Rupiah  AS DECIMAL(18,2)) total
                            FROM KeuRincianRJ INNER JOIN KeuRinciPiutRJ 
                            on KeuRincianRJ.VC_No_Bukti = KeuRinciPiutRJ.VC_No_Bukti
                            INNER JOIN KeuTaripDasar on KeuTaripDasar.VC_Kd_GsKlCo = KeuRinciPiutRJ.VC_Kd_GsKlCo
                            where VC_No_RegJ = '" + noReg + "' ";
            using (SqlCommand cmd = new SqlCommand(query, clMain.DBConn.objConnection))
            {
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }
            analisaTarifs = (from System.Data.DataRow dr in dt.Rows
                             select new AnalisaTarif()
                             {
                                 namaTarif = dr["namatarip"].ToString(),
                                 kodeTarif = dr["kodetarif"].ToString(),
                                 noReg = dr["noReg"].ToString(),
                                 quantity = (decimal)dr["qty"],
                                 rupiah = (decimal)dr["rupiah"],
                                 total = (decimal)dr["total"],
                             }).ToList();



            return analisaTarifs;
        }

        private List<AnalisaTarif> getTarifRIByReg(string noReg)
        {
            List<AnalisaTarif> analisaTarifs = new List<AnalisaTarif>();
            DataTable dt = new DataTable();

            string query = @"
                            SELECT VC_No_Reg noReg,KeuRincian.VC_No_Bukti nobukti,KeuRinciInap.VC_Kd_GsKlCo kodetarif
                            ,KeuTaripDasar.VC_Nm_Tarip namatarip,DC_Qty qty,DC_Rupiah rupiah, CAST(DC_Qty* DC_Rupiah  AS DECIMAL(18,2)) total
                            FROM KeuRincian INNER JOIN KeuRinciInap 
                            on KeuRincian.VC_No_Bukti = KeuRinciInap.VC_No_Bukti
                            INNER JOIN KeuTaripDasar on KeuTaripDasar.VC_Kd_GsKlCo = KeuRinciInap.VC_Kd_GsKlCo
                            where VC_No_Reg = '" + noReg + "' ";
            using (SqlCommand cmd = new SqlCommand(query, clMain.DBConn.objConnection))
            {
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }
            analisaTarifs = (from System.Data.DataRow dr in dt.Rows
                             select new AnalisaTarif()
                             {
                                 namaTarif = dr["namatarip"].ToString(),
                                 kodeTarif = dr["kodetarif"].ToString(),
                                 noReg = dr["noReg"].ToString(),
                                 quantity = (decimal)dr["qty"],
                                 rupiah = (decimal)dr["rupiah"],
                                 total = (decimal)dr["total"],
                             }).ToList();



            return analisaTarifs;
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
	                                INNER JOIN AKPRI_Kartu_piutang_JKN_V kartuPiutang ON kartuPiutang.vc_no_reg = dtagih.vc_no_reg
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
                                    los = (int)dr["los"],
                                    analisaTarifs = getTarifRIByReg(dr["vc_no_reg"].ToString())
                                }).ToList();
            return diagnosaBpjsList;

        }

        private void btnExportXls_Click(object sender, EventArgs e)
        {
            //  ExcelExport excelExport = new ExcelExport(this.pivotGridControl1, Syncfusion.XlsIO.ExcelVersion.Excel2010);
            // excelExport.Export(@"D:\PivotGrid.xlsx");
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FrmAnaliasaPerDokter_Load(object sender, EventArgs e)
        {

        }

        private void chkBoxSort_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
