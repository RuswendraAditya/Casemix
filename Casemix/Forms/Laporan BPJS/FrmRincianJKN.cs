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



        }

        private DataTable getKartuPiutangJKN_RJ()

        {
            DataTable dt = new DataTable();
            string query = @"SELECT DISTINCT
	                        0 AS nomer,
	                        kartu.vc_no_rm,
	                        kartu.vc_no_regj,
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
	                        iSNULL( sep.vc_kd_status_sep, 0 ),
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
                query = query + " where Convert(DateTime, Convert(Varchar,Isnull(sep.dt_tgl_sep,0),101),101) between  '" + DTAwal.Value.ToShortDateString() + "' and  '" + DTAkhir.Value.ToShortDateString() + "'  ";
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

                    query = query + " AND NOT EXISTS(SELECT 1 from AKPRJ_DTagihan tagih where tagih.vc_no_regj = kartu.vc_no_regj)" ;
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
	                    kartu.vc_no_reg,
	                    pasien.vc_nama_p,
	                    sep.vc_no_sep,
	                    kartu.dc_biaya_rs,
	                    dc_iur_pasien,
	                    dc_potongan,
	                    dc_nominal_instansi_lain,
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
                query = query + " where Convert(DateTime, Convert(Varchar,Isnull(sep.dt_tgl_sep,0),101),101) between  '" + DTAwal.Value.ToShortDateString() + "' and  '" + DTAkhir.Value.ToShortDateString() + "'  ";
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
    }
}
