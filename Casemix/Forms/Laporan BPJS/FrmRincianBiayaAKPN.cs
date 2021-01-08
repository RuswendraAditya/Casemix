using Casemix.Util;
using Microsoft.VisualBasic;
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
    public partial class FrmRincianBiayaAKPN : Form
    {

        string m_nmrRegistrasi;
        string sSQL;
        double xFaTotal;
        int xHariRawat;
        bool m_Hak_AKPN = false;
        bool m_Pulang = false;
        bool m_KuitPrinted = false;
        DateTime vTglHariIni = clMain.DBConn.GetCurrentDate();
        DateTime m_TglMasuk;
        double m_Bayar;
        string m_KlasTrans;
        DateTime m_CetakTglPul;

        public FrmRincianBiayaAKPN()
        {
            InitializeComponent();
        }

        private void cmdCariReg_Click(object sender, EventArgs e)
        {
            frmCariData frmCariData = new frmCariData();
            var button = (Button)sender;
            var arrColumn = new string[5];
            arrColumn[0] = "No.Reg";
            arrColumn[1] = "No.RM";
            arrColumn[2] = "Nama Pasien";
            arrColumn[3] = "Alamat";
            {
                var withBlock = frmCariData;
                withBlock.ResultCol = 0;
                withBlock.Result = txtNoReg.Text.Trim();
                withBlock.colName = arrColumn;
                withBlock.strSQL = " SELECT  RMP_inap.vc_no_reg,RMP_inap.vc_no_rm, RMPasien.vc_nama_p, " + "         RMPasien.vc_alamat" + " FROM    RMP_inap INNER JOIN " + "         RMPasien ON RMP_inap.vc_no_rm = RMPasien.vc_no_rm " + " WHERE   dt_tgl_pul Is Null ";



                frmCariData.ShowDialog();
                switch (button.Name)
                {
                    case "cmdCariReg":
                        {
                            this.txtNoReg.Focus();
                            txtNoReg.Text = withBlock.Result;
                            break;
                        }
                }
            }
        }


        public string SQLCariPasien(string NoReg, bool Pulang)
        {
            string sSQL;
            sSQL = " SELECT  RMP_inap.vc_no_reg, RMP_inap.vc_no_rm, " + "      " +
                     "   RMPasien.vc_nama_p, bt_hak_akpn, " + "         RMPasien.vc_alamat, RMPasien.vc_kelurahan, " + "     " +
                     "   RMPasien.vc_kecamatan, RMPasien.vc_kota, " + "         RMPasien.in_umurth, RMPasien.in_umurbl, " + " " +
                     "   RMPasien.in_umurhr, RMP_inap.dt_tgl_pul, " + "         RMPasien.vc_jenis_k, " + "         ( " + "             Select	vc_n_kelas " + "             From    RMKelas " + "             Where	vc_k_kelas = CASE WHEN isnull(RMP_inap.vc_kd_klas_mutasi,'')='' " + "                                  " +
                     "THEN RMP_inap.vc_kd_klas_masuk " + "                                  ELSE RMP_inap.vc_kd_klas_mutasi " + "                                  END " + "         ) vc_kelas, " + "         (	" + "             Select	vc_nama " + "             From     RMKamar " + "             Where	RMKamar.vc_no_bed = CASE WHEN isnull(RMP_inap.vc_kd_kamar_mutasi,'')='' " + "                                         THEN RMP_inap.vc_kd_kamar_masuk " + "                                         ELSE RMP_inap.vc_kd_kamar_mutasi " + "                                         END " + "         ) vc_nama, " + "         RMP_inap.vc_nid, " + "         SDMDOKTER.VC_NAMA_KRY, " + "         ( " + "             Select	VC_n_ruang " + "             From    RMRuang " + "            " +
                     " Where	RMRuang.VC_k_ruang = CASE WHEN isnull(RMP_inap.vc_kd_ruang_mutasi,'')='' " + "                                         THEN RMP_inap.vc_kd_ruang_masuk " + "                                         ELSE RMP_inap.vc_kd_ruang_mutasi " + "                                         END	" + "         ) VC_n_ruang, " + "         bt_print_pulang, " + "         RMP_Inap.dt_tgl_msk, " + "         isnull(PubPng.vc_k_png,'') as vc_k_png, " + "         isnull(PubPng.vc_n_png,'') as vc_n_png, " + "         ( " + "             CASE WHEN isnull(RMP_inap.vc_kd_Ruang_mutasi,'')='' " + "             THEN RMP_inap.vc_kd_Ruang_masuk " + "             ELSE RMP_inap.vc_kd_Ruang_mutasi " + "             END " + "         ) vc_kd_gsklco, " + "         ( " + "             CASE WHEN isnull(RMP_inap.vc_kd_klas_mutasi,'')='' " + "             THEN RMP_inap.vc_kd_klas_masuk " + "             ELSE RMP_inap.vc_kd_klas_mutasi " + "             END " + "         ) vc_k_kelas,isnull(rmp_inap.vc_k_lunasan,'') as vc_k_lunasan, " + "         ( " + "             CASE WHEN isnull(RMP_inap.vc_kd_ruang_mutasi,'')='' " + "             THEN RMP_inap.vc_kd_ruang_masuk " + "             ELSE RMP_inap.vc_kd_ruang_mutasi " + "             END " + "         ) vc_k_gugus ,RMP_Inap.vc_k_png " + " FROM    RMP_Inap " + "         INNER JOIN  RMPasien ON RMP_inap.vc_no_rm = RMPasien.vc_no_rm " + "         INNER JOIN  SDMDOKTER ON RMP_inap.vc_nid = SDMDOKTER.VC_NID " + "         LEFT JOIN PubPng ON RMP_Inap.vc_k_png = PubPng.vc_k_png " + " WHERE   RMP_inap.vc_no_reg = '" + NoReg + "' ";

            // "         RMRuang.VC_n_ruang, RMKamar.vc_no_bed, RMKelas.vc_k_kelas,bt_print_pulang,RMP_Inap.dt_tgl_msk,isnull(PubPng.vc_n_png,'') as vc_n_png " & _

            if (Pulang)
            {
                sSQL += "     AND RMP_inap.dt_tgl_pul IS NULL ";
            }

            return sSQL;
        }


        private void ClearVariable(bool xAll)
        {
            System.Windows.Forms.Control aControl;
            foreach (System.Windows.Forms.Control currentAControl in gbDataSosial.Controls)
            {
                aControl = currentAControl;
                if (aControl is TextBox)
                {
                    if ((aControl.Name.ToLower()) == "txtnoreg" & xAll == false)
                    {
                        aControl.Text = aControl.Text;
                    }
                    else
                    {
                        aControl.Text = "";
                    }
                }

                if (aControl is Label)
                {
                    switch ((aControl.Name.ToLower()))
                    {
                        case "lblnama":
                        case "lblalamat":
                        case "lblkel":
                        case "lblkec":
                        case "lblkota":
                        case "lbltahun":
                        case "lblbulan":
                        case "lblhari":
                        case "lbljnskel":
                        case "lblruang":
                        case "lblkelas":
                        case "lblkamar":
                        case "lblkddr":
                        case "lblpng":
                            {
                                aControl.Text = "";
                                break;
                            }
                    }
                }
            }

            foreach (System.Windows.Forms.Control currentAControl1 in pnlRincian.Controls)
            {
                aControl = currentAControl1;
                if (aControl is MaskedTextBox)
                {
                    aControl.Text = String.Format(aControl.Text, 0.0d);
                }

                if (aControl is DataGridView)
                {
                    lstItem.Rows.Clear();
                }
            }
        }

        public void CariPasien(string NoReg)
        {
            string SQL;
            SqlDataReader ObjReader;
            bool vAda = true;
            SqlCommand oCmd = default;
            SQL = SQLCariPasien(NoReg, false);
            if (clMain.DBConn.DBOpenConnection() == 0)
            {
                oCmd = new SqlCommand(SQL, clMain.DBConn.objConnection);
                // oCmd.Connection = clMain.clUtama.objConnection
                oCmd.CommandTimeout = 0;
                ObjReader = oCmd.ExecuteReader(); // clMain.clUtama.GeneralQuery(SQL)
                oCmd.Dispose();
                if (ObjReader.HasRows)
                {
                    ObjReader.Read();
                    txtNoReg.Text = ObjReader["vc_no_reg"].ToString();
                    txtNoRM.Text = ObjReader["vc_no_rm"].ToString();
                    LblNama.Text = ObjReader["vc_nama_p"].ToString();
                    LblAlamat.Text = ObjReader["vc_alamat"].ToString();
                    LblKel.Text = ObjReader["vc_kelurahan"].ToString();
                    LblKec.Text = ObjReader["vc_kecamatan"].ToString();
                    LblKota.Text = ObjReader["vc_kota"].ToString();
                    LblTahun.Text = ObjReader["in_umurth"].ToString() + " Tahun";
                    LblBulan.Text = ObjReader["in_umurbl"].ToString() + " Bulan";
                    LblHari.Text = ObjReader["in_umurhr"].ToString() + " Hari";
                    LblJnsKel.Text = ObjReader["vc_jenis_k"].ToString();
                    LblKelas.Text = ObjReader["vc_kelas"].ToString();
                    LblKamar.Text = ObjReader["vc_nama"].ToString();
                    LblKdDr.Text = ObjReader["vc_nid"].ToString() + "  -" + ObjReader["vc_NAMA_KRY"].ToString();
                    LblRuang.Text = ObjReader["vc_n_ruang"].ToString();
                    m_TglMasuk = (DateTime)ObjReader["dt_tgl_msk"];
                    this.dtTglAwal.Value = m_TglMasuk;
                    lblPng.Text = ObjReader["vc_n_png"].ToString();
                    LblKodePng.Text = ObjReader["vc_k_png"].ToString();
                    m_KlasTrans = ObjReader["vc_kd_gsklco"].ToString() + ObjReader["vc_k_kelas"].ToString();
                    if (Information.IsDBNull(ObjReader["bt_hak_akpn"]) == true)
                    {
                        m_Hak_AKPN = false;
                    }
                    else if ((bool)ObjReader["bt_hak_akpn"] == true)
                    {
                        m_Hak_AKPN = true;
                    }
                    else
                    {
                        m_Hak_AKPN = false;
                    }

                    if (Information.IsDBNull(ObjReader["dt_tgl_pul"]))
                    {
                        m_Pulang = false;
                    }
                    else if (ObjReader["dt_tgl_pul"].ToString() != "")
                    {
                        m_Pulang = true;
                    }
                    else
                    {
                        m_Pulang = false;
                    }

                    if (Information.IsDBNull(ObjReader["bt_print_pulang"]) == true)
                    {
                        m_KuitPrinted = false;
                    }
                    else if ((bool)ObjReader["bt_print_pulang"] == true)
                    {
                        m_KuitPrinted = true;
                    }
                    else
                    {
                        m_KuitPrinted = false;
                    }
                    // Mengambil Data Keubayar

                }
                else
                {
                    vAda = false;
                    MsgBoxUtil.MsgInfo("Data pasien tidak ditemukan !");
                }

                ObjReader.Close();
            }

            this.Refresh();
            if (vAda)
            {
                m_Bayar = GetKuitansiBayar(txtNoReg.Text);
                FillGridRincian();
                HitungTotal();
            }
        }

        private void HitungTotal()
        {
            int I = 0;
            double TotBiaya = 0d;
            double TotTitipan = 0d;
            var loopTo = lstItem.RowCount - 1;
            for (I = 0; I <= loopTo; I++)
            {
              
                if ((bool) lstItem["bt_detil", I].Value == false)
                {
                    switch (lstItem["vc_index", I].Value)
                    {
                        case 3:
                            {
                                TotTitipan += double.Parse(lstItem["dc_nominal", I].Value.ToString());
                                break;
                            }

                        default:
                            {
                                TotBiaya += double.Parse(lstItem["dc_nominal", I].Value.ToString());
                                break;
                            }
                    }
                }
            }

            this.txtNTotBiaya.Text = Strings.Format(TotBiaya, "standard");
            this.txtNPembulatan.Text = Strings.Format(clMain.DBConn.Bulat50(Math.Ceiling(TotBiaya)), "###,##0.00");
            this.txtNTotTitipan.Text = Strings.Format(TotTitipan, "standard");
            double total = double.Parse(txtNPembulatan.Text) - double.Parse(txtNTotTitipan.Text);
            this.txtNTotBayar.Text = Strings.Format(total, "standard");
            if (m_Pulang == true)
            {
                this.txtNTotBayar.Text = Strings.Format(double.Parse(txtNTotBayar.Text) - m_Bayar, "standard");
            }
        }

        private void TambahBaris(ref DataGridView xGrid, string xKeterangan, double xNominal, bool xDetil, byte xIndex, string xKdBagian)

        {
            Font oFont;
            int I;
            if (xDetil)
            {
                oFont = new System.Drawing.Font("Tahoma", 8, FontStyle.Regular);
                xGrid.Rows.Add("", xKeterangan, xNominal, xDetil, xIndex, true, xKdBagian);
                var loopTo = xGrid.Columns.Count - 1;
                for (I = 0; I <= loopTo; I++)
                {
                    lstItem[I, xGrid.Rows.Count - 1].Style.Font = oFont;
                    lstItem[I, xGrid.Rows.Count - 1].Style.BackColor = Color.Snow;
                }
            }
            else
            {
                oFont = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                xGrid.Rows.Add("-", xKeterangan, xNominal, xDetil, xIndex, true, xKdBagian);
                var loopTo1 = xGrid.Columns.Count - 1;
                for (I = 0; I <= loopTo1; I++)
                {
                    lstItem[I, xGrid.Rows.Count - 1].Style.Font = oFont;
                    lstItem[I, xGrid.Rows.Count - 1].Style.BackColor = Color.Gainsboro;
                    lstItem[I, xGrid.Rows.Count - 1].Style.ForeColor = Color.Navy;
                }
            }

            oFont.Dispose();
        }
        private string SQLDetilRawatTaripBaru(string vNoReg)
        {
            string sSQL;
            sSQL = " SELECT	1 as urut,dd.vc_kd_bagian,vc_nm_bagian," +
                    "sum(aa.dc_qty * aa.dc_rupiah) dc_tarip  " + " FROM	KeuRinciInapKomponen aa " + "       " +
                    " Left Join KeuRincian cc ON cc.vc_no_bukti = aa.vc_no_bukti " + "        " +
                    "Left Join PubBagian dd On substring(cc.vc_no_bukti,7,2) = dd.vc_kd_bagian " +
                    " WHERE	cc.vc_no_reg ='" + vNoReg + " ' " + "    AND aa.vc_kd_Gsklco  <> '" +
                    clMain.gKdTaripKamar + "' " + "    and aa.vc_kd_sub_komponen <> '" + clMain.gKd_KomponenDokter + " ' " + " GROUP BY vc_nm_bagian, dd.vc_kd_bagian  " + " UNION ALL " + " SELECT	2 as urut, " + "       " +
                    " isnull(bb.vc_nik1,'') as vc_kd_bagian, " + "        isnull(vc_nama_kry,'') as vc_nm_bagian,sum(aa.dc_qty * aa.dc_rupiah) dc_tarip " + " FROM	KeuRinciInapKomponen aa " + "        " +
                    "Left Join Keurinciinap bb on aa.vc_no_bukti = bb.vc_no_bukti and aa.vc_kd_gsklco = bb.vc_kd_gsklco and aa.in_order = bb.in_order " + "        " +
                    "Left Join KeuRincian cc ON cc.vc_no_bukti = bb.vc_no_bukti " + "        Left JOin SDMDokter ee ON  ee.vc_nid = bb.vc_nik1 " + " WHERE	cc.vc_no_reg ='" + vNoReg + "' " + "    AND bb.vc_kd_Gsklco  <> '" + clMain.gKdTaripKamar + "' " + "    and aa.vc_kd_sub_komponen = '" + clMain.gKd_KomponenDokter + " ' " + " GROUP BY   bb.vc_nik1, vc_nama_kry " + " ORDER BY urut,vc_kd_bagian";



















            return sSQL;


        }

        private void FillGridRincian()
        {
            string vSQL = "";
            SqlDataReader oReader = default;
            SqlCommand oCmd;
            double vTotalTitipan = 0d;
            int vBarisTitipan = 0;
            int vBarisRuangH = 0;
            int vBarisRuangD = 0;
            string vBed = "";
            int vHariPerKamar = 0;
            double vSubTotalRuang = 0d;
            double vTotalRuang = 0d;
            int vBarisRawat = 0;
            double vTotalRawat = 0d;
            int vCounterTgl = 0;
            DateTime dtTampTgl = m_TglMasuk;
            lstItem.Rows.Clear();

            // ======================================================
            // BIAYA RUANG PERAWATAN
            // ======================================================
            TambahBaris(ref lstItem, "Biaya Ruang Perawatan", 0, false, 1, "");
            vBarisRuangH = lstItem.RowCount - 1;
            xHariRawat = 0;


            // *== EDIT PEMBAYARAN KAMAR * END
            DataSet dsPembebanan = SetBebanKamar(txtNoReg.Text, dtTglAwal.Value);
            DataTable dtPembebanan = dsPembebanan.Tables["BebanKamar"];
            xHariRawat = 0;
            foreach (DataRow r in dtPembebanan.Rows)
            {

                TambahBaris(ref lstItem, "       " + r["tgl_awal"] + " -- " + r["tgl_akhir"] + " = " + r["jml_hari"] + " Hari @ " + r["dc_harga"], Convert.ToDouble(r["dc_rupiah"]), true, 1, "");
                vBarisRuangD = lstItem.RowCount - 1;
                lstItem["dc_nominal", vBarisRuangD].Value = Strings.Format(r["dc_rupiah"], "standard");
                lstItem["dt_tgl_detil", vBarisRuangD].Value = r["tgl_awal"]; // Format(r("tgl_awal"), "dd-MM-yyyy HH:mm")
                lstItem["vc_hide_ket", vBarisRuangD].Value = r["vc_nama"]; // oReader("vc_nama")
                vTotalRuang = vTotalRuang + Convert.ToDouble(r["dc_rupiah"]);
                xHariRawat = xHariRawat + Convert.ToInt32(r["jml_hari"]);
            }

            lstItem["dc_nominal", vBarisRuangH].Value = vTotalRuang;
            dtPembebanan.Dispose();
            dsPembebanan.Dispose();
            // lblKondisiP.Text = lblKondisiP.Text & "(Hitung Detil Biaya)"
            this.Refresh();




            vSQL = SQLDetilRawatTaripBaru(txtNoReg.Text);
            TambahBaris(ref lstItem, "Detil Biaya Perawatan", 0, false, 2, "");
            vBarisRawat = lstItem.RowCount - 1;
            oCmd = new SqlCommand(vSQL, clMain.DBConn.objConnection);
            oCmd.CommandTimeout = 0;
            oReader = oCmd.ExecuteReader();
            oCmd.Dispose();

            // oReader = clMain.clUtama.GeneralQuery(vSQL) '==== edited 19 August 2009
            if (oReader.HasRows)
            {
                while (oReader.Read())
                {
                    if (oReader["vc_kd_bagian"].ToString() != "02")
                    {
                        TambahBaris(ref lstItem, "       " + oReader["vc_kd_bagian"].ToString() + "   " + oReader["vc_nm_bagian"], Convert.ToDouble(oReader["dc_tarip"]), true, 2, oReader["vc_kd_bagian"].ToString());
                    }
                    else
                    {
                        TambahBaris(ref lstItem, "       " + oReader["vc_kd_bagian"].ToString() + "   " + "KONSUL DOKTER / ELEKTRODIAGNOSTIK", Convert.ToDouble(oReader["dc_tarip"]), true, 2, oReader["vc_kd_bagian"].ToString());
                    }

                    vTotalRawat += Convert.ToDouble(oReader["dc_tarip"]);
                }

                lstItem["dc_nominal", vBarisRawat].Value = Strings.Format(vTotalRawat, "standard");
            }

            oReader.Close();
            this.Refresh();
            // ======================================================
            // TITIPAN
            // ======================================================
            TambahBaris(ref lstItem, "Titipan Pasien", 0, false, 3, "");
            vBarisTitipan = lstItem.RowCount - 1;
            vSQL = " SELECT     AKPN_TitipanD.vc_no_bukti, KeuBayar.DT_tgl_bayar, KeuBayar.MO_rupiah, isnull(KeuBayar.vc_no_kwit,'') as vc_no_kwit," + "            (SELECT sum(dc_titipan) tot_titipan " + "             FROM   akpn_titipand INNER JOIN " + "                    KeuBayar ON AKPN_TitipanD.vc_no_bukti = KeuBayar.VC_no_bukti  And akpn_titipand.vc_no_reg = KeuBayar.vc_no_reg And keubayar.bt_validasi = 1 " + "             WHERE  akpn_titipand.vc_no_reg='" + this.txtNoReg.Text + "' " + "            ) as tot_titipan " + " FROM       AKPN_TitipanD INNER JOIN " + "            KeuBayar ON AKPN_TitipanD.vc_no_bukti = KeuBayar.VC_no_bukti And keubayar.bt_validasi = 1" + " WHERE      akpn_titipand.vc_no_reg ='" + this.txtNoReg.Text + "'";







            oCmd = new SqlCommand(vSQL, clMain.DBConn.objConnection);
            oCmd.CommandTimeout = 0;
            oReader = oCmd.ExecuteReader();
            // oReader = clMain.clUtama.GeneralQuery(vSQL)
            oCmd.Dispose();
            if (oReader.HasRows)
            {
                while (oReader.Read())
                {
                    double rupiah = Convert.ToDouble(oReader["mo_rupiah"]);
                    string rupiahString = rupiah.ToString();
                    TambahBaris(ref lstItem, ClsUtil.Replicate(5, " ") + "  " + ClsUtil.AddSpace(Strings.Format(oReader["dt_tgl_bayar"].ToString(), "dd-MM-yyyy"), 10, 2, " ") +
                        ClsUtil.AddSpace(" No. Bukti : " + oReader["vc_no_kwit"], 24, 1, " "),
                        rupiah, true, 3, "");
                    vTotalTitipan = Convert.ToDouble(oReader["tot_titipan"]);
                    lstItem["dt_tgl_detil", lstItem.RowCount - 1].Value = oReader["dt_tgl_bayar"];
                    lstItem["vc_kd_detil", lstItem.RowCount - 1].Value = oReader["vc_no_bukti"];
                }
            }

            oReader.Close();
            lstItem["dc_nominal", vBarisTitipan].Value = Strings.Format(vTotalTitipan, "standard");
        }

        private double GetKuitansiBayar(string xNoReg)
        {
            double rupiah = 0;

            SqlDataReader oReader;
            string vSQL;
            SqlCommand oCmd = default;
            vSQL = " SELECT vc_no_reg,sum(mo_rupiah) as mo_rupiah " + " FROM   KeuBayar " + " WHERE  vc_no_reg ='" + xNoReg + "'" + "    And vc_k_bayar ='1' " + "    And bt_validasi =1 " + " GROUP BY vc_no_reg ";

            oCmd = new SqlCommand(vSQL, clMain.DBConn.objConnection);

            oReader = oCmd.ExecuteReader(); // clMain.clUtama.GeneralQuery(SQL)
            if (oReader.HasRows)
            {
                oReader.Read();
                rupiah = Convert.ToDouble(oReader["mo_rupiah"]);
            }
            else
            {
                rupiah = 0;
            }

            oReader.Close();

            return rupiah;

        }

        public void SettingMenu()
        {
            if (txtNoReg.Text != "")
            {
                if (m_Hak_AKPN == true)
                {
                    if (m_KuitPrinted == true) // pasien lunas
                    {
                        if (m_Pulang)
                        {
                            // Pulang Lunas
                            lblKondisiP.Text = "PASIEN SUDAH DIPULANGKAN (LUNAS)";

                        }
                        else
                        {
                            lblKondisiP.Text = "PASIEN AKAN PULANG (SUDAH CETAK KUITANSI)";

                        }
                    }
                    else if (m_Pulang) // pasien piutang
                    {
                        lblKondisiP.Text = "PASIEN SUDAH DIPULANGKAN (PIUTANG)";

                    }
                    else
                    {
                        lblKondisiP.Text = "PASIEN AKAN PULANG";

                    }
                }
                else
                {
                    lblKondisiP.Text = "";

                }
            }
            else
            {
                lblKondisiP.Text = "";

            }
        }

        private DataSet SetBebanKamar(string xNoReg, DateTime xTglAwal)
        {
            DataSet SetBebanKamarRet = default;
            string sSQL;
            byte I = 0;
            byte J = 0;
            SqlDataReader oReader = default;
            var oCmd1 = new SqlCommand();
            string sTampKamar;
            DateTime vTglAwal;
            DateTime vTglAkhir;
            var vJmlKamar = default(byte);
            decimal vJmlRupiah = 0;
            decimal vHarga = 0;
            string vNama = "";
            var dsBebanKamar = new DataSet();
            DataTable dtBebanKamar = dsBebanKamar.Tables.Add("BebanKamar");
            dtBebanKamar.Columns.Add("noreg");
            dtBebanKamar.Columns.Add("tgl_awal");
            dtBebanKamar.Columns.Add("tgl_akhir");
            dtBebanKamar.Columns.Add("jml_hari");
            dtBebanKamar.Columns.Add("vc_nama");
            dtBebanKamar.Columns.Add("dc_harga");
            dtBebanKamar.Columns.Add("dc_rupiah");
            vTglAwal = xTglAwal;
            vTglAkhir = xTglAwal;

            // dtBebanKamar.Rows.Add(xNoReg, "", "", "", "", "", "")

            SetBebanKamarRet = default;
            if (!string.IsNullOrEmpty(Strings.Trim(xNoReg)))
            {
                // sSQL = " select	aa.vc_no_reg,aa.dt_tgl_trans,dc_rupiah dc_harga , (dc_qty * dc_rupiah) as dc_rupiah,bb.vc_kd_gsklco,vc_nama " _
                // & " from	keurincian aa " _
                // & "        inner join keurinciinap bb ON aa.vc_no_bukti = bb.vc_no_bukti " _
                // & "        inner Join vw_rmtarakaripbed cc ON bb.vc_kd_gsklco = cc.vc_kd_gsklco " _
                // & "        inner Join RMKamar dd ON cc.vc_no_bed = dd.vc_no_bed " _
                // & " where	aa.vc_no_reg = '" & xNoReg & "' " _
                // & " order by aa.vc_no_bukti"
                // 'sSQL = " select	aa.vc_no_reg,aa.dt_tgl_trans,dc_rupiah dc_harga , (dc_qty * dc_rupiah) as dc_rupiah,bb.vc_kd_gsklco,vc_nama " _
                // '     & " from	KeuRincian aa " _
                // '     & "        Inner join KeuRinciinap bb ON bb.vc_no_bukti = aa.vc_no_bukti " _
                // '     & "        Left join  RMKamar dd on aa.vc_no_reg = dd.vc_no_reg, Rmtarakarip cc " _
                // '     & " where	aa.vc_no_reg = '" & xNoReg & "' " _
                // '     & "    and	bb.vc_kd_gsklco = cc.vc_kd_gsklco"
                // EDIT TARIP'
                // =========='
                sSQL = "select	aa.vc_no_reg,aa.dt_tgl_trans,dc_rupiah dc_harga , " + "        (dc_qty * dc_rupiah) as dc_rupiah,bb.vc_kd_gsklco,(vc_nama + CAST((dc_qty* dc_rupiah) as varchar(18)) ) as vc_nama " + "from	keurincian aa " + "        inner join keurinciinap bb ON aa.vc_no_bukti = bb.vc_no_bukti " + "        inner join RMKamar cc on aa.vc_no_bed = cc.vc_no_bed " + "where	aa.vc_no_reg = '" + xNoReg + "' " + "    and	bb.VC_Kd_Gsklco = '" + clMain.gKdTaripKamar + "' " + "order by aa.vc_no_bukti";








                // RENCANA EDIT HITUNG BIAYA KAMAR DENGAN PENAMBAHAN TABEL BARU "KeuRinciInapKamar"
                // -===============================================================================
                // sSQL = "select	aa.vc_no_reg,aa.dt_tgl_trans,dc_rupiah dc_harga , " _
                // & "        (dc_qty * dc_rupiah) as dc_rupiah,bb.vc_kd_gsklco,vc_nama " _
                // & "from	keurincian aa " _
                // & "        inner join keurinciinapKamar bb ON aa.vc_no_bukti = bb.vc_no_bukti " _
                // & "        inner join RMKamar cc on aa.vc_no_bed = cc.vc_no_bed " _
                // & "where	aa.vc_no_reg = '" & xNoReg & "' " _
                // & "order by aa.vc_no_bukti"
                // ===============================================================================


                oCmd1 = new SqlCommand(sSQL, clMain.DBConn.objConnection);
                oCmd1.CommandTimeout = 0;
                oReader = oCmd1.ExecuteReader();
                oCmd1.Dispose();
                if (oReader.HasRows)
                {
                    sTampKamar = "";
                    J = 0;
                    while (oReader.Read())
                    {
                        if (sTampKamar != oReader["vc_nama"].ToString().Trim())
                        {
                            if (!string.IsNullOrEmpty(sTampKamar))
                            {
                                // tambah record
                                dtBebanKamar.Rows.Add(xNoReg, Strings.Format(vTglAwal, "dd-MM-yyyy"), Strings.Format(vTglAkhir, "dd-MM-yyyy"), vJmlKamar, vNama, vHarga, vJmlRupiah);
                                // setting awal
                                vTglAwal = vTglAkhir;
                                vJmlKamar = 0;
                                vJmlRupiah = 0;
                                vHarga = 0;
                            }

                            vTglAkhir = (DateTime)oReader["dt_tgl_trans"];
                            vJmlKamar = (byte)(vJmlKamar + 1);
                            vJmlRupiah = vJmlRupiah + (decimal)oReader["dc_rupiah"];
                            vHarga = (decimal)oReader["dc_harga"];
                        }
                        else
                        {
                            // edit record
                            vTglAkhir = (DateTime)oReader["dt_tgl_trans"];
                            vJmlKamar = (byte)(vJmlKamar + 1);
                            vJmlRupiah = vJmlRupiah + (decimal)oReader["dc_rupiah"];
                        }

                        sTampKamar = oReader["vc_nama"].ToString().Trim();
                        vNama = oReader["vc_nama"].ToString();
                    }
                    // tambah 1 record
                    dtBebanKamar.Rows.Add(xNoReg, Strings.Format(vTglAwal, "dd-MM-yyyy"), Strings.Format(vTglAkhir, "dd-MM-yyyy"), vJmlKamar, vNama, vHarga, vJmlRupiah);
                }

                oReader.Close();
                SetBebanKamarRet = dsBebanKamar;
                dtBebanKamar.Dispose();
                dsBebanKamar.Dispose();
            }

            return SetBebanKamarRet;
        }

        private void txtNoReg_Validated(object sender, EventArgs e)
        {
            try
            {
                this.TxtNoSEP.Text = "";
                if (txtNoReg.Text != "")
                {
                    ClearVariable(false);
                    this.Cursor = Cursors.WaitCursor;
                    this.lblKondisiP.Text = "W A I T I N G . . . ";
                    this.Refresh();
                    CariPasien(this.txtNoReg.Text);
                    // this.TxtNoSEP.Text =ClsUtil.GetSettings("vc_no_regj", "vc_no_sep", "bpjs_sep", this.txtNoReg.Text, "");
                    this.TxtNoSEP.Text = ClsUtil.GetSetting("bpjs_sep", "vc_no_sep", "vc_no_regj", this.txtNoReg.Text);
                }
                else
                {
                    ClearVariable(true);
                }

                SettingMenu();
                vTglHariIni = clMain.DBConn.GetCurrentDate();
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MsgBoxUtil.MsgError("Proses Gagal, Informasi Tidak Dapat Ditampilkan!!" + Constants.vbCrLf + " Silakan Mengulang Pengisian No.Register.. " + Constants.vbCrLf + ex.Message);
                ClearVariable(false);
            }
        }

        private void FrmRincianBiayaAKPN_Load(object sender, EventArgs e)
        {

        }
    }
}
