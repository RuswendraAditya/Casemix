using Syncfusion.Data;
using System;
using System.Collections.Generic;

using System.Data;
using System.Data.SqlClient;

using System.Windows.Forms;
using Syncfusion.XlsIO;
using System.IO;

using Syncfusion.WinForms.DataGrid.Events;
using System.Drawing;
using Syncfusion.WinForms.DataGridConverter;
using Casemix.Util;

namespace Casemix.Forms.Analisa_BPJS
{
    public partial class FrmPelayananBPJS : Form
    {
        public FrmPelayananBPJS()
        {
            InitializeComponent();
            generateComboBox();
        }

        private DataTable getDataRawatJalan()
        {
            DataTable dt = new DataTable();

            string query = @"SELECT akprj.vc_no_rm,akprj.vc_no_regj,sep.vc_no_sep,
                            pasien.vc_nama_p ,dokter.vc_nama_kry as dokter,dc_total_RS, 
                            ISNULL((SELECT ISNULL(SUM(titipan.DC_Dibayar),0) FROM AKPRj_Titipan titipan WHERE titipan.VC_No_Regj =AKPRJ.vc_no_regJ  and titipan.vc_k_png = akprj.vc_k_png AND   vc_k_bayar IN('1','2') and  BT_Validasi = 1 ) ,0) AS totalBayarPasien,
                            ISNULL((SELECT ISNULL(SUM(titipan.DC_Dibayar),0) FROM AKPRj_Titipan titipan WHERE titipan.VC_No_Regj =AKPRJ.vc_no_regJ  and titipan.vc_k_png = akprj.vc_k_png AND   vc_k_bayar IN('3') and  BT_Validasi = 1 ) ,0) AS potongan,
                            0 as piutangRS,0 as grouper,0 as selisih,'' as grouping,'' deskripsiGrouping , sep.vc_nama_kelas_tanggungan as hakKelas
                            FROM AKPRJ_Validasi_close akprj 
                            inner join bpjs_sep sep
                            on sep.vc_no_regj = akprj.vc_no_regj
                            inner join RMPasien pasien on
                            pasien.vc_no_rm = akprj.vc_no_rm
                            LEFT JOIN SDMDokter dokter on dokter.vc_nid = akprj.vc_nid_dpjp
                            where  akprj.vc_k_png =  @pngJKN
                            and ISNULL(sep.bt_hapus,0) <> 1 
                            AND Convert(DateTime, Convert(Varchar,Isnull(sep.dt_tgl_sep,0),101),101) = '" + dtFrom.Value.ToShortDateString() + "' ";

            using (SqlCommand cmd = new SqlCommand(query, clMain.DBConn.objConnection))
            {
                cmd.Parameters.AddWithValue("@pngJKN", FrmMain.kdJKN);
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                   
                    da.Fill(dt);
                }
            }

            return dt;

        }


        private DataTable getDataRawatInap()
        {
            DataTable dt = new DataTable();

            string query = @"SELECT inap.vc_no_rm,
                               inap.vc_no_reg vc_no_regj ,sep.vc_no_sep,   pasien.vc_nama_p ,dokter.vc_nama_kry as dokter,
							(SELECT SUM(ISNULL(NU_Sub_Total,0)) from KeuRincian where VC_No_Reg = inap.vc_no_reg)  as dc_total_RS,
							(SELECT ISNULL((SELECT ISNULL(SUM(MO_Rupiah),0) FROM KEUBAYAR bayar WHERE VC_No_Reg =inap.vc_no_reg AND  BT_Validasi = 1 ),0) ) + 
							(SELECT ISNULL((SELECT ISNULL(SUM(titipan.DC_Dibayar),0) FROM AKPRI_Titipan titipan WHERE VC_No_Reg =inap.vc_no_reg AND  BT_Validasi = 1 and vc_k_bayar ='2' ),0) ) as totalBayarPasien,
							(SELECT ISNULL((SELECT ISNULL(SUM(titipan.DC_Dibayar),0) FROM AKPRI_Titipan titipan WHERE VC_No_Reg =inap.vc_no_reg AND  BT_Validasi = 1 and vc_k_bayar ='3' ),0))  as potongan,
							0 as piutangRS,0 as grouper,0 as selisih,'' as grouping,'' deskripsiGrouping, sep.vc_nama_kelas_tanggungan as hakKelas, klas.vc_n_kelas Kelas
                            FROM RMP_inap inap 
                            inner join bpjs_sep sep
                            on sep.vc_no_regj = inap.vc_no_reg
                             INNer JOIN RMKelas klas ON Case When 
                            ISNULL(inap.vc_kd_klas_mutasi,0) = 0 Then inap.vc_kd_klas_masuk
                            Else inap.vc_kd_klas_mutasi End = klas.vc_k_kelas
                            inner join RMPasien pasien on
                            pasien.vc_no_rm = inap.vc_no_rm
                            LEFT JOIN SDMDokter dokter on dokter.vc_nid = inap.vc_nid
                            where  (inap.vc_k_png = @pngJKN or exists(SELECT 1 from KeuPngLain lain where lain.vc_No_Reg = inap.vc_no_reg and lain.vc_Kd_Png = @pngJKN))
                            and ISNULL(sep.bt_hapus,0) <> 1 
                            AND ISNULL(inap.dt_tgl_pul,'') <> ''
                            AND Convert(DateTime, Convert(Varchar,Isnull(sep.dt_tgl_sep,0),101),101) = '" + dtFrom.Value.ToShortDateString() + "'   ";

            using (SqlCommand cmd = new SqlCommand(query, clMain.DBConn.objConnection))
            {
                cmd.Parameters.AddWithValue("@pngJKN", FrmMain.kdJKN);
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }

            return dt;

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

            getDataBPJS();

        }

        private void generateComboBox()

        {
            //cmbJenisPel.AutoCompleteMode = AutoCompleteMode.Append;
            List<string> listJenisPel = new List<string>();
            listJenisPel.Add("Rawat Jalan");
            listJenisPel.Add("Rawat Inap");
            cmbJenisPel.DataSource = listJenisPel;
            cmbJenisPel.SelectedIndex = 0;
        }
        private void getDataBPJS()
        {
            pbLoading.Value = 0;
            pbLoading.Visible = true;
            string Xconsid = ClsUtil.GetSetting("bpjs_setting", "vc_keterangan", "vc_kode", "KodeInacbgRS");
            string url = ClsUtil.GetSetting("bpjs_setting", "vc_keterangan", "vc_kode", "UrlWSInacbg");
            string SecretKey = ClsUtil.GetSetting("bpjs_setting", "vc_keterangan", "vc_kode", "keyinacbg");
            if (cmbJenisPel.Text.Equals("Rawat Jalan"))
            {
                dgPiutang.DataSource = getDataRawatJalan();
            }
            if (cmbJenisPel.Text.Equals("Rawat Inap"))
            {
                dgPiutang.DataSource = getDataRawatInap();
            }
          
            int increment = 0;
            int counter = 0;
            int totalRow = dgPiutang.RowCount;
            decimal totalPiutRS = 0;
            decimal totalGrouper = 0;
            decimal totalSelisih = 0;
            foreach (RecordEntry record in dgPiutang.View.Records)
            {

                var dataRowView = record.Data as DataRowView;

                if (dataRowView != null)
                {
                    counter++;
                    decimal totalRS = (decimal)dataRowView.Row["dc_total_RS"];
                    totalRS = (decimal)clMain.DBConn.Bulat50((double)Math.Ceiling(totalRS));
                    decimal iurPasien = (decimal)dataRowView.Row["totalBayarPasien"];
                    iurPasien = (decimal)clMain.DBConn.Bulat50((double)Math.Ceiling(iurPasien));
                    decimal totalPotongan = (decimal)dataRowView.Row["potongan"];
                    decimal piutangRS = totalRS - iurPasien - totalPotongan;
                    decimal grouper = GetBiayaGrouper((string)dataRowView.Row["vc_no_sep"], Xconsid, url, SecretKey);
                    dataRowView.Row["dc_total_RS"] = totalRS;
                    dataRowView.Row["totalBayarPasien"] = iurPasien;
                    dataRowView.Row["piutangRS"] = piutangRS;
                    dataRowView.Row["grouper"] = grouper;
                    dataRowView.Row["selisih"] = grouper - piutangRS;
                    dataRowView.Row["grouping"] = GetDiagnosa((string)dataRowView.Row["vc_no_sep"], Xconsid, url, SecretKey);
                    dataRowView.Row["deskripsiGrouping"] = GetDescDiagnosa((string)dataRowView.Row["vc_no_sep"], Xconsid, url, SecretKey);
                    increment = (int)Math.Round((double)(100 * counter) / totalRow);
                    if (increment >= pbLoading.Maximum)
                    {
                        increment = pbLoading.Maximum;
                    }
                    pbLoading.Value = increment;
                    totalPiutRS = totalPiutRS + piutangRS;

                    totalGrouper  = totalGrouper + grouper;
                    totalSelisih = totalSelisih + (grouper - piutangRS);

                }
            }    //Search and filter without highlighting the search text.
            this.dgPiutang.SearchController.AllowFiltering = true;
            this.dgPiutang.AllowEditing = false;
            this.dgPiutang.QueryCellStyle += dgPiutang_QueryCellStyle;
            this.txtTotalPiutangRS.Text =  String.Format("{0:N2}", double.Parse(totalPiutRS.ToString()));
            this.txtTotalGrouper.Text = String.Format("{0:N2}", double.Parse(totalGrouper.ToString()));
            this.txtTotalSelisih.Text = String.Format("{0:N2}", double.Parse(totalSelisih.ToString()));
            pbLoading.Visible = false;


           }

        private void dgPiutang_QueryCellStyle(object sender, QueryCellStyleEventArgs e)
        {
            if (e.Column.MappingName == "selisih")
            {
                var cellValue = e.DisplayText == null ? string.Empty : e.DisplayText.ToString();
                  float value = float.Parse(cellValue);
                if (value < 0)
                {
                    e.Style.BackColor = Color.Pink;

                 
                }
                
            }
        }

        private decimal GetBiayaGrouper(string SEP, string Xconsid, string url, string SecretKey)
        {
            double nBiayaGrouper = 0;
            double nBiayaRS = 0;
            string cStatusKirim = "";
            string cTglKirim = "";
            string cStatusKlaim = "";
            string cBpjs_klaim_status_nm = "";
            string CBG = "";
            try
            {
                nBiayaGrouper = inacbglib.mainlib.GetBiayaGrouper(Xconsid, SecretKey, url, ref SEP, ref nBiayaGrouper, ref nBiayaRS, ref cStatusKirim, ref cTglKirim, ref cStatusKlaim, ref cBpjs_klaim_status_nm, ref CBG);
            }
            catch 
            {
                nBiayaGrouper = 0;
            }
            return Convert.ToDecimal(nBiayaGrouper);

        }

        private string GetDiagnosa(string SEP, string Xconsid, string url, string SecretKey)
        {
            double nBiayaGrouper = 0;
            double nBiayaRS = 0;
            string cStatusKirim = "";
            string cTglKirim = "";
            string cStatusKlaim = "";
            string cBpjs_klaim_status_nm = "";
            string CBG = "";
            string codeIna = "";
            try
            {
                string hasil = inacbglib.mainlib.GetDataInacbg(Xconsid, SecretKey, url, ref SEP, ref nBiayaGrouper, ref nBiayaRS, ref cStatusKirim, ref cTglKirim, ref cStatusKlaim, ref cBpjs_klaim_status_nm, ref CBG);
                hasil = inacbglib.mainlib.GetValueRange(hasil, "grouper");
                codeIna = inacbglib.mainlib.GetValue(hasil, "code");
                if (codeIna.Equals("Null"))
                {
                    codeIna = "";
                }
            }
            catch 
            {
                nBiayaGrouper = 0;
            }
            return codeIna;

        }
        private string GetDescDiagnosa(string SEP, string Xconsid, string url, string SecretKey)
        {
            double nBiayaGrouper = 0;
            double nBiayaRS = 0;
            string cStatusKirim = "";
            string cTglKirim = "";
            string cStatusKlaim = "";
            string cBpjs_klaim_status_nm = "";
            string CBG = "";
            string codeIna = "";
            try
            {
                string hasil = inacbglib.mainlib.GetDataInacbg(Xconsid, SecretKey, url, ref SEP, ref nBiayaGrouper, ref nBiayaRS, ref cStatusKirim, ref cTglKirim, ref cStatusKlaim, ref cBpjs_klaim_status_nm, ref CBG);
                hasil = inacbglib.mainlib.GetValueRange(hasil, "grouper");
                codeIna = inacbglib.mainlib.GetValue(hasil, "description");
                if (codeIna.Equals("Null"))
                {
                    codeIna = "";
                }
            }
            catch 
            {
                codeIna = "";
            }
            return codeIna;
          


        }
       


        private void FrmPelayananBPJS_Load(object sender, EventArgs e)
        {

        }

        private void dgPiutang_AutoGeneratingColumn(object sender, Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnArgs e)
        {
            if (e.Column.MappingName == "vc_no_rm")
            {
                e.Column.HeaderText = "No RM";
                e.Column.Width = 80;
                e.Column.AllowFiltering = true;
               
            }

            if (e.Column.MappingName == "vc_no_regj")
            {
                e.Column.HeaderText = "No Reg";
                e.Column.Width = 110;
                e.Column.AllowFiltering = true;
            }

            if (e.Column.MappingName == "vc_no_sep")
            {
                e.Column.HeaderText = "No SEP";
                e.Column.Width = 140;
                e.Column.AllowFiltering = true;
            }


            if (e.Column.MappingName == "vc_nama_p")
            {
                e.Column.HeaderText = "Nama Pasien";
                e.Column.Width = 240;
                e.Column.AllowFiltering = true;

            }

            if (e.Column.MappingName == "dokter")
            {
                e.Column.HeaderText = "Nama Dokter";
                e.Column.Width = 240;
                e.Column.AllowFiltering = true;

            }
            if (e.Column.MappingName == "dc_total_RS")
            {
                e.Column.HeaderText = "Biaya RS";
                e.Column.AllowFiltering = true;

            }
            if (e.Column.MappingName == "totalBayarPasien")
            {
                e.Column.HeaderText = "Iuran Pasien";
                e.Column.AllowFiltering = true;

            }
            if (e.Column.MappingName == "potongan")
            {
                e.Column.HeaderText = "Potongan";
                e.Column.AllowFiltering = true;

            }
            if (e.Column.MappingName == "piutangRS")
            {
                e.Column.HeaderText = "Piutang RS";
                e.Column.Format = "#,##0.00";
                e.Column.AllowFiltering = true;

            }
            if (e.Column.MappingName == "grouper")
            {
                e.Column.HeaderText = "Grouper";
                e.Column.Format = "#,##0.00";
                e.Column.AllowFiltering = true;

            }
            if (e.Column.MappingName == "selisih")
            {
                e.Column.HeaderText = "Selisih";
                e.Column.Format = "#,##0.00";
                e.Column.AllowFiltering = true;

            }
            if (e.Column.MappingName == "grouping")
            {
                e.Column.HeaderText = "Grouping";
                e.Column.Width = 70;
                e.Column.AllowFiltering = true;
            }
            if (e.Column.MappingName == "deskripsiGrouping")
            {
                e.Column.HeaderText = "Desc";
                e.Column.Width = 400;
                e.Column.AllowFiltering = true;
            }
            if (e.Column.MappingName == "hakKelas")
            {
                e.Column.HeaderText = "Hak Kelas";
                e.Column.Width = 150;
                e.Column.AllowFiltering = true;
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            ClsUtil.DownloadXLs(dgPiutang);

        }

   
        private void dgPiutang_FilterChanged(object sender, FilterChangedEventArgs e)
        {
            decimal totalPiutRS = 0;
            decimal totalGrouper = 0;
            decimal totalSelisih = 0;
            foreach (RecordEntry record in dgPiutang.View.Records)
            {

                var dataRowView = record.Data as DataRowView;

                if (dataRowView != null)
                {
                   
                    decimal totalRS = (decimal)dataRowView.Row["dc_total_RS"];
                    decimal iurPasien = (decimal)dataRowView.Row["totalBayarPasien"];
                    decimal totalPotongan = (decimal)dataRowView.Row["potongan"];
                    decimal piutangRS = totalRS - iurPasien - totalPotongan;
                    decimal grouper = Convert.ToDecimal(dataRowView.Row["grouper"]);


                    totalPiutRS = totalPiutRS + piutangRS;

                    totalGrouper = totalGrouper + grouper;
                    totalSelisih = totalSelisih + (grouper - piutangRS);

                }
            }    //Search and filter without highlighting the search text.

            this.txtTotalPiutangRS.Text = String.Format("{0:N2}", double.Parse(totalPiutRS.ToString()));
            this.txtTotalGrouper.Text = String.Format("{0:N2}", double.Parse(totalGrouper.ToString()));
            this.txtTotalSelisih.Text = String.Format("{0:N2}", double.Parse(totalSelisih.ToString()));
        }
    }
}
    

