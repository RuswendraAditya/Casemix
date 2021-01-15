
using Syncfusion.Data;
using System;
using System.Collections.Generic;

using System.Data;
using System.Data.SqlClient;

using System.Windows.Forms;

namespace Casemix.Forms.Laporan_BPJS
{

    public partial class FrmRincianJKN : Form
    {
        public string typeTrans = "";
        public FrmRincianJKN()
        {
            InitializeComponent();
            generateComboBox();
        }
        private void generateComboBox()

        {
            //cmbJenisPel.AutoCompleteMode = AutoCompleteMode.Append;
            List<string> listJenisPel = new List<string>();
            listJenisPel.Add("Rawat Jalan");
            listJenisPel.Add("Rawat Inap");
            cmbJenisPel.DataSource = listJenisPel;
            cmbJenisPel.SelectedIndex = 0;
            loadStatusSEP();
        }

        private void loadStatusSEP()
        {
            cmbStatusSEP.DisplayMember = "Text";
            cmbStatusSEP.ValueMember = "Value";
            DataTable tb = new DataTable();
            tb.Columns.Add("Text", typeof(string));
            tb.Columns.Add("Value", typeof(int));
            string strsql = "SELECT vc_nm_status_sep,vc_kd_status_sep FROM bpjs_status_sep order by vc_kd_status_sep asc";
            SqlCommand objcommand = new SqlCommand(strsql, clMain.DBConn.objConnection);
            SqlDataReader objdatareader;
            objdatareader = objcommand.ExecuteReader();
            while (objdatareader.Read())
            {
                tb.Rows.Add(objdatareader[0], objdatareader[1]);
            }

            cmbStatusSEP.DataSource = tb;
            objdatareader.Close();
            cmbStatusSEP.SelectedIndex = 0;
        }

        private void FrmRincianJKN_Load(object sender, EventArgs e)
        {

        }

        private void cmbJenisPel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbJenisPel.SelectedIndex == 0)
            {
                lblJudul.Text = "Laporan Rincian Piutang JKN Rawat Jalan";
                rbTglClose.Text = "Tanggal Close AKPRJ";
                chkBoxCOB.Enabled = false;
                typeTrans = "RJ";
            }
            else
            {
                lblJudul.Text = "Laporan Rincian Piutang JKN Rawat Inap";
                rbTglClose.Text = "Tanggal Pulang Pasien ";
                chkBoxCOB.Enabled = true;
                typeTrans = "RI";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (typeTrans == "RI")
            {
                dgPiutang.DataSource = getKartuPiutangJKN_RI();

            }
            else
            {
                dgPiutang.DataSource = getKartuPiutangJKN_RJ();

            }

            getSaldoTOtal();
            this.dgPiutang.AllowEditing = false;
        }

        private void getSaldoTOtal()
        {
            int rowNum = 0;
            decimal totalBiayaRS = 0;
            decimal totalIurPasien = 0;
            decimal totalPotongan = 0;
            decimal totalCOB = 0;
            decimal totalPiutangRS = 0;
            decimal totalGrouper = 0;
            decimal totalUmbal = 0;
            decimal totalSelisih = 0;
            decimal totalUnklaim = 0;
            decimal totalSatuEpisode = 0;
            decimal totalSaldo= 0;  
            foreach (RecordEntry record in dgPiutang.View.Records)
            {

                var dataRowView = record.Data as DataRowView;

                if (dataRowView != null)
                {
                    rowNum++;
                    totalBiayaRS = totalBiayaRS + (decimal)dataRowView.Row["dc_biaya_rs"];
                    totalIurPasien = totalIurPasien + (decimal)dataRowView.Row["dc_iur_pasien"];
                    totalPotongan = totalPotongan + (decimal)dataRowView.Row["dc_potongan"];
                    totalCOB = totalCOB + (decimal)dataRowView.Row["dc_potongan"];
                    totalPiutangRS = totalPiutangRS + (decimal)dataRowView.Row["dc_piutang_rs"];
                    totalGrouper = totalGrouper + (decimal)dataRowView.Row["dc_grouper"];
                    totalUmbal = totalUmbal + (decimal)dataRowView.Row["dc_umbal"];
                    totalSelisih = totalSelisih + (decimal)dataRowView.Row["selisih"];
                    totalUnklaim = totalUnklaim + (decimal)dataRowView.Row["dc_unklaim"];
                    totalSatuEpisode = totalSatuEpisode + (decimal)dataRowView.Row["dc_satu_episode"];
                    totalSaldo = totalSaldo + (decimal)dataRowView.Row["dc_saldo"];
                    dataRowView.Row["nomer"] = rowNum;
                }
               
            }
            this.txtTotalBiayaRS.Text = String.Format("{0:N2}", double.Parse(totalBiayaRS.ToString()));

            this.txtTotalIuranPasien.Text = String.Format("{0:N2}", double.Parse(totalIurPasien.ToString()));
            this.txtTotalPotongan.Text = String.Format("{0:N2}", double.Parse(totalPotongan.ToString()));

            this.txtTotalCOB.Text = String.Format("{0:N2}", double.Parse(totalCOB.ToString()));

            this.txtTotalPiutangRS.Text = String.Format("{0:N2}", double.Parse(totalPiutangRS.ToString()));
            this.txtTotalGrouper.Text = String.Format("{0:N2}", double.Parse(totalGrouper.ToString()));
            this.txtTotalUmbal.Text = String.Format("{0:N2}", double.Parse(totalUmbal.ToString()));
            this.txtTotalSelisih.Text = String.Format("{0:N2}", double.Parse(totalSelisih.ToString()));
            this.txtTotalUnklaim.Text = String.Format("{0:N2}", double.Parse(totalUnklaim.ToString()));
            this.txtSatuEpisode.Text = String.Format("{0:N2}", double.Parse(totalSatuEpisode.ToString()));
            this.txtTotalSaldo.Text = String.Format("{0:N2}", double.Parse(totalSaldo.ToString()));
        }

        private DataTable getKartuPiutangJKN_RJ()

        {
            DataTable dt = new DataTable();
            string query = @"SELECT DISTINCT
	                        0 AS nomer,
	                        kartu.vc_no_rm ,
	                        kartu.vc_no_regj as noReg,
	                        pasien.vc_nama_p,
	                        sep.vc_no_sep,
	                        kartu.dc_biaya_rs,
	                        dc_iur_pasien,
	                        dc_potongan,
	                        0 AS cob,
	                        kartu.dc_piutang_rs,
	                        dc_grouper,
	                        dc_umbal,
                        CASE
	                        WHEN dc_umbal > 0 THEN
	                        dc_umbal - dc_piutang_rs ELSE 0 
	                        END selisih,
	                        dc_unklaim,
	                        dc_satu_episode,
	                        dc_saldo,
	                        iSNULL( sep.vc_kd_status_sep, 0 ) as kodeSEP,
	                        ISNULL( status.vc_nm_status_sep, '' ) Status 
                        FROM
	                        akprj_kartu_piutang_JKN kartu
	                        INNER JOIN RMPasien pasien ON pasien.vc_no_rm = kartu.vc_no_rm
	                        INNER JOIN bpjs_sep sep ON sep.vc_no_regj = kartu.vc_no_regj 
	                        AND ISNULL( bt_hapus, '0' ) = '0'
	                        INNER JOIN AKPRJ_Validasi_close akprj ON akprj.vc_no_regj = kartu.vc_no_regj 
	                        AND akprj.vc_k_png = kartu.vc_k_png
                        INNER JOIN BPJS_Status_SEP status ON status.vc_kd_status_sep = ISNULL( sep.vc_kd_status_sep, 0 ) ";
            if (rbTglClose.Checked)
            {
                query = query + " where Convert(DateTime, Convert(Varchar,Isnull(akprj.dt_tgl_close,0),101),101) between  '" + DTAwal.Value.ToShortDateString() + "' and  '" + DTAkhir.Value.ToShortDateString() + "'  ";

            }

            if (rbTglSEP.Checked)
            {
                query = query + " where Convert(DateTime, Convert(Varchar,Isnull(sep.dt_tgl_sep,0),101),101) between  '" + DTAwalSEP.Value.ToShortDateString() + "' and  '" + DTAkhirSEP.Value.ToShortDateString() + "'  ";
            }
            if (cmbStatusSEP.SelectedValue.ToString() != "0")
            {
                query = query + " and iSNULL(sep.vc_kd_status_sep,0) = '" + cmbStatusSEP.SelectedValue + "' ";

            }

            if (cmbUmbal.SelectedIndex == 1)
            {
                query = query + " and dc_umbal = 0 ";
            }

            if (cmbUmbal.SelectedIndex == 2)
            {
                query = query + " and dc_umbal > 0 ";
            }

            if (cmbTagih.SelectedIndex == 1)
            {
                query = query + "AND EXISTS(SELECT 1 from AKPRJ_DTagihan tagih where tagih.vc_no_regj = kartu.vc_no_regj) ";
            }
            if (cmbTagih.SelectedIndex == 2)
            {

                query = query + " AND NOT EXISTS(SELECT 1 from AKPRJ_DTagihan tagih where tagih.vc_no_regj = kartu.vc_no_regj)";
            }


            query = query + "	order by vc_nama_p asc ";

            using (SqlCommand cmd = new SqlCommand(query, clMain.DBConn.objConnection))
            {
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }

            return dt;
        }
        private DataTable getKartuPiutangJKN_RI()
        {
            DataTable dt = new DataTable();
            string query = @"SELECT DISTINCT
	                    0 AS nomer,
	                    kartu.vc_no_rm,
	                    kartu.vc_no_reg as noReg,
	                    pasien.vc_nama_p,
	                    sep.vc_no_sep,
	                    kartu.dc_biaya_rs,
	                    dc_iur_pasien,
	                    dc_potongan,
	                    dc_nominal_instansi_lain as cob,
	                    kartu.dc_piutang_rs,
	                    dc_grouper,
	                    dc_umbal,
                    CASE
	
	                    WHEN dc_umbal > 0 THEN
	                    dc_umbal - dc_piutang_rs ELSE 0 
	                    END selisih,
	                    dc_unklaim,
	                    dc_satu_episode,
	                    dc_saldo,
	                    iSNULL( sep.vc_kd_status_sep, 0 ) as kodeSEP,
	                    ISNULL( status.vc_nm_status_sep, '' ) StatusSEP 
                    FROM
	                    akpri_kartu_piutang_JKN kartu
	                    INNER JOIN RMPasien pasien ON pasien.vc_no_rm = kartu.vc_no_rm
	                    INNER JOIN bpjs_sep sep ON sep.vc_no_regj = kartu.vc_no_reg 
	                    AND ISNULL( bt_hapus, '0' ) = '0'
	                    INNER JOIN rmP_inap inap ON inap.vc_no_reg = kartu.vc_no_reg
                    INNER JOIN BPJS_Status_SEP status ON status.vc_kd_status_sep = ISNULL( sep.vc_kd_status_sep, 0 ) ";
            if (rbTglClose.Checked)
            {
                query = query + " where Convert(DateTime, Convert(Varchar,Isnull(inap.dt_tgl_pul,0),101),101) between  '" + DTAwal.Value.ToShortDateString() + "' and  '" + DTAkhir.Value.ToShortDateString() + "'  ";

            }

            if (rbTglSEP.Checked)
            {
                query = query + " where Convert(DateTime, Convert(Varchar,Isnull(sep.dt_tgl_sep,0),101),101) between  '" + DTAwalSEP.Value.ToShortDateString() + "' and  '" + DTAkhirSEP.Value.ToShortDateString() + "'  ";
            }
            if (cmbStatusSEP.SelectedValue.ToString() != "0")
            {
                query = query + " and iSNULL(sep.vc_kd_status_sep,0) = '" + cmbStatusSEP.SelectedValue + "' ";

            }

            if (cmbUmbal.SelectedIndex == 1)
            {
                query = query + " and dc_umbal = 0 ";
            }

            if (cmbUmbal.SelectedIndex == 2)
            {
                query = query + " and dc_umbal > 0 ";
            }

            if (cmbTagih.SelectedIndex == 1)
            {
                query = query + "AND (EXISTS (" + "SELECT" + "	1 " + "FROM" + "	" +
                    "           AKPRI_COB_HTagihan tagihanH" + "	" +
                    "           INNER JOIN AKPRI_COB_DTagihan tagihanD ON tagihanH.VC_Kd_Tagihan = tagihanD.VC_Kd_Tagihan " +
                                "	AND vc_k_png = '" + FrmMain.kdJKN + "' " +
                                "	AND tagihanD.vc_no_reg = kartu.vc_no_reg " + "	) " +
                                "OR EXISTS (" + "SELECT" + "	1 " + "FROM" + "	" +
                                "AKPRI_HTagihan tagihanH" + "	INNER JOIN AKPRI_DTagihan tagihanD" +
                                " ON tagihanH.VC_Kd_Tagihan = tagihanD.VC_Kd_Tagihan " +
                                "	AND vc_k_png = '" + FrmMain.kdJKN + "' " + "	AND tagihanD.vc_no_reg = kartu.vc_no_reg " + "	) ) ";

            }
            if (cmbTagih.SelectedIndex == 2)
            {
                query = query + "AND (NOT EXISTS (" + "SELECT" + "	1 " + "FROM" + "	AKPRI_COB_HTagihan tagihanH" + "	INNER JOIN AKPRI_COB_DTagihan tagihanD ON tagihanH.VC_Kd_Tagihan = tagihanD.VC_Kd_Tagihan " + "	AND vc_k_png = '" + FrmMain.kdJKN + "' " + "	AND tagihanD.vc_no_reg = kartu.vc_no_reg " + "	) AND NOT EXISTS (" + "SELECT" + "	1 " + "FROM" + "	AKPRI_HTagihan tagihanH" + "	INNER JOIN AKPRI_DTagihan tagihanD ON tagihanH.VC_Kd_Tagihan = tagihanD.VC_Kd_Tagihan " + "	AND vc_k_png = '" + FrmMain.kdJKN + "' " + "	AND tagihanD.vc_no_reg = kartu.vc_no_reg " + "	) ) ";

            }

            if (chkBoxCOB.Checked)
            {
                query = query + " and inap.vc_png_lain = 'COB' ";
            }

            query = query + "	order by vc_nama_p asc ";

            using (SqlCommand cmd = new SqlCommand(query, clMain.DBConn.objConnection))
            {
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }

            return dt;

        }

        private void dgPiutang_AutoGeneratingColumn(object sender, Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnArgs e)
        {
            if (e.Column.MappingName == "nomer")
            {
                e.Column.HeaderText = "No";
                e.Column.Width = 40;
              

            }
            if (e.Column.MappingName == "vc_no_rm")
            {
                e.Column.HeaderText = "No RM";
                e.Column.Width = 75;
                e.Column.AllowFiltering = true;

            }

            if (e.Column.MappingName == "noReg")
            {
                e.Column.HeaderText = "No Reg";
                e.Column.Width = 100;
                e.Column.AllowFiltering = true;
            }
            if (e.Column.MappingName == "vc_nama_p")
            {
                e.Column.HeaderText = "Nama Pasien";
                e.Column.Width = 180;
                e.Column.AllowFiltering = true;

            }
            if (e.Column.MappingName == "vc_no_sep")
            {
                e.Column.HeaderText = "No SEP";
                e.Column.Width = 135;
                e.Column.AllowFiltering = true;
            }

            if (e.Column.MappingName == "dc_biaya_rs")
            {
                e.Column.HeaderText = "Piutang RS";
                e.Column.Format = "#,##0.00";
                e.Column.AllowFiltering = true;
                e.Column.Width = 100;
            }

            if (e.Column.MappingName == "dc_iur_pasien")
            {
                e.Column.HeaderText = "Iur Pasien";
                e.Column.Format = "#,##0.00";
                e.Column.AllowFiltering = true;
                e.Column.Width =95;
            }
            if (e.Column.MappingName == "dc_potongan")
            {
                e.Column.HeaderText = "Potongan";
                e.Column.Format = "#,##0.00";
                e.Column.AllowFiltering = true;
                e.Column.Width = 100;
            }

            if (e.Column.MappingName == "cob")
            {
                e.Column.HeaderText = "COB";
                e.Column.Format = "#,##0.00";
                e.Column.AllowFiltering = true;
                e.Column.Width = 100;
            }
            if (e.Column.MappingName == "dc_piutang_rs")
            {
                e.Column.HeaderText = "Piutang RS";
                e.Column.Format = "#,##0.00";
                e.Column.AllowFiltering = true;
                e.Column.Width = 95;
            }
            if (e.Column.MappingName == "dc_grouper")
            {
                e.Column.HeaderText = "Grouper";
                e.Column.Format = "#,##0.00";
                e.Column.AllowFiltering = true;
                e.Column.Width = 95;
            }
            if (e.Column.MappingName == "dc_umbal")
            {
                e.Column.HeaderText = "Umbal";
                e.Column.Format = "#,##0.00";
                e.Column.AllowFiltering = true;
                e.Column.Width = 95;
            }
            if (e.Column.MappingName == "selisih")
            {
                e.Column.HeaderText = "Selisih";
                e.Column.Format = "#,##0.00";
                e.Column.AllowFiltering = true;
                e.Column.Width = 95;
            }
            if (e.Column.MappingName == "dc_unklaim")
            {
                e.Column.HeaderText = "Unklaim";
                e.Column.Format = "#,##0.00";
                e.Column.AllowFiltering = true;
                e.Column.Width = 92;
            }
            if (e.Column.MappingName == "dc_satu_episode")
            {
                e.Column.HeaderText = "Satu Episode";
                e.Column.Format = "#,##0.00";
                e.Column.AllowFiltering = true;
                e.Column.Width = 92;
            }
            if (e.Column.MappingName == "dc_saldo")
            {
                e.Column.HeaderText = "Saldo";
                e.Column.Format = "#,##0.00";
                e.Column.AllowFiltering = true;
                e.Column.Width =100;
            }
            if (e.Column.MappingName == "kodeSEP")
            {
                e.Column.Visible = false;

            }
            if (e.Column.MappingName == "StatusSEP")
            {
                e.Column.HeaderText = "Status SEP";
            }
        }

        private void dgPiutang_DrawCell(object sender, Syncfusion.WinForms.DataGrid.Events.DrawCellEventArgs e)
        {

        }

        private void dgPiutang_FilterChanged(object sender, Syncfusion.WinForms.DataGrid.Events.FilterChangedEventArgs e)
        {
            getSaldoTOtal();
        }
    }
}
