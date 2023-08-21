using Casemix.Util;
using Microsoft.Reporting.WinForms;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Events;
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

namespace Casemix.Forms.CasemixForm
{
    public partial class FormInput : Form
    {
        private string _noRM;
        private string _nama;
        private string _noReg;
        private bool _isExists;
        private bool _isExistsB;
        private int _hdridB=0;
        public FormInput()
        {
            InitializeComponent();
        }

        public FormInput(string noReg, string noRM, string nama) 
        {
            InitializeComponent();
            this._noRM = noRM;
            this._nama = nama;
            this._noReg = noReg;
            lblNama.Text = _nama;
            lblNoReg.Text = _noReg;
            lblNoRM.Text = _noRM;
            getDataExistsA();
            getDataExistsB();
            getCatatan();
            
            this.dgPiutang.CellButtonClick += deleteCatatan_click;
        }
        public void getDataExistsA()
        {
           
            var sqlCmd = new SqlCommand();
            string query = "Select * FROM CASEMIX_Form_A where vc_no_reg = @vc_no_reg ";
            sqlCmd = new SqlCommand(query, clMain.DBConn.objConnection);
            sqlCmd.Parameters.AddWithValue("@vc_no_reg", _noReg);
            SqlDataReader dr  = sqlCmd.ExecuteReader();
            if (dr.HasRows)
            {
                _isExists = true;
                dr.Read();

                //skrining
                chkBoxSkriningUsia18.Checked = (bool)dr["bt_skrining_usia18"];
                chkBoxSkriningUsia60.Checked = (bool)dr["bt_skrining_usia60"];
                chkBoxSkriningUsia75.Checked = (bool)dr["bt_skrining_usia75"];
                chkBoxSkriningCritical.Checked = (bool)dr["bt_skrining_pasien_critical"];
                chkBoxSkriningBiaya10jt.Checked = (bool)dr["bt_skrining_pasien_biaya10jt"];
                chkBoxSkriningBPJSLos5.Checked = (bool)dr["bt_skrining_pasienBPJS_los5"];
                chkBoxSkriningBPJSOverINA.Checked = (bool)dr["bt_skrining_pasienBJPS_overINA"];
                chkBoxSkriningPrioritas.Checked = (bool)dr["bt_skrining_pasien_prioritas"];
                chkBoxSkriningResikoKomplain.Checked = (bool)dr["bt_skrining_pasien_resikokomplain"];
                chkBoxSkriningRumit.Checked = (bool)dr["bt_skrining_pasien_kompleksrumit"];
                chkBoxSkriningBiayaKompleks.Checked = (bool)dr["bt_skrining_pasien_biayakompleks"];
                chkBoxSkriningKognitif.Checked = (bool)dr["bt_skrining_pasien_koginitifrendah"];
                chkBoxSkriningKronis.Checked = (bool)dr["bt_skrining_pasien_kronis"];
                chkBoxSkriningFungsionalRendah.Checked = (bool)dr["bt_skrining_pasien_fungsional_rendah"];
                chkBoxSkriningPasienDiidintifikasi.Checked = (bool)dr["bt_skrining_pasien_identifikasi_rencanapulang"];
                chkBoxAssesmentMandiriPenuh.Checked = (bool)dr["bt_assesmen_pasien_mandiri_penuh"];
                chkBoxAssesmentMandiriSebagian.Checked = (bool)dr["bt_assesmen_pasien_mandiri_sebagian"];
                chkBoxAssesmentTotalBantuan.Checked = (bool)dr["bt_assesmen_pasien_total_bantuan"];
                chkBoxAssesmentTdkPernahDirawat.Checked = (bool)dr["bt_assesmen_pasien_riwayat_tdk_pernah_dirawat"];
                chkBoxAssesmentPernahDirawat.Checked = (bool)dr["bt_assesmen_pasien_riwayat_pernah_dirawat"];
                txtPernahDirawat.Text = dr["vc_assesmen_pasien_riwayat_pernah_dirawat"].ToString();
                chkBoxAssesmentPerilakuTenang.Checked = (bool)dr["bt_assesmen_pasien_psikokultural_tenang"];
                chkBoxAssesmentPerilakuCemas.Checked = (bool)dr["bt_assesmen_pasien_psikokultural_cemas"];
                chkBoxAssesmentPerilakuDepresi.Checked = (bool)dr["bt_assesmen_pasien_psikokultural_depresi"];
                chkBoxAssesmentPerilakuMarah.Checked = (bool)dr["bt_assesmen_pasien_psikokultural_marah"];
                chkBoxAssesmentPerilakuLain.Checked = (bool)dr["bt_assesmen_pasien_psikokultural_lain"];
                txtAssesmentPerilakuLain.Text = dr["vc_assesmen_pasien_psikokultural_lain"].ToString();
                chkBoxAssesmentMentalAdaRiwayat.Checked = (bool)dr["bt_assesmen_pasien_mental_adariwayat"];
                chkBoxAssesmentMentalTidakAdaGangguan.Checked = (bool)dr["bt_assesmen_pasien_mental_tidakada"];
                chkBoxAssesmentMentalDlmPengobatan.Checked = (bool)dr["bt_assesmen_pasien_mental_dalampengobatan"];
                chkBoxAssesmentMentalGagalPengobatan.Checked = (bool)dr["bt_assesmen_pasien_mental_gagalpengobatan"];
                chkBoxAssesmentMentalGangguanSerius.Checked = (bool)dr["bt_assesmen_pasien_mental_gangguanserius"];
              
                chkBoxAssesmentDukunganKeluargaHandal.Checked = (bool)dr["bt_assesmen_pasien_dukungankeluarga_handal"];
                chkBoxAssesmentDukunganKeluargaDipertanyakan.Checked = (bool)dr["bt_assesmen_pasien_dukungankeluarga_dipertanyakan"];
                chkBoxAssesmentDukunganKeluargaKrisis.Checked = (bool)dr["bt_assesmen_pasien_dukungankeluarga_krisis"];
                chkBoxAssesmentDukunganKeluargaTidakAda.Checked = (bool)dr["bt_assesmen_pasien_dukungankeluarga_tidakada"];
                chkBoxAssesmentFinansialPNS.Checked = (bool)dr["bt_assesmen_pasien_finansial_pegawainegeri"];
                chkBoxAssesmentFinansialBuruh.Checked = (bool)dr["bt_assesmen_pasien_finansial_buruh"];
                chkBoxAssesmentFinansialTdkKerja.Checked = (bool)dr["bt_assesmen_pasien_finansial_tdkkerja"];
                chkBoxAssesmentFinansialWiraswasta.Checked = (bool)dr["bt_assesmen_pasien_finansial_wiraswasta"];
                chkBoxAssesmentFinansialPensiunan.Checked = (bool)dr["bt_assesmen_pasien_finansial_pensiunan"];
                chkBoxAssesmentFinansialLain.Checked = (bool)dr["bt_assesmen_pasien_finansial_lain"];
                TxtAssesmentFinansialLain.Text = dr["vc_assesmen_pasien_finansial_lain"].ToString();
                chkBoxAssesmentAsuransiAdaAktif.Checked = (bool)dr["bt_assesmen_pasien_asuransi_adaaktif"];
                chkBoxAssesmentAsuransiAdaTdkAktif.Checked = (bool)dr["bt_assesmen_pasien_asuransi_adatidakaktif"];
                chkBoxAssesmentAsuransiTidakAda.Checked = (bool)dr["bt_assesmen_pasien_asuransi_tidakada"];
                chkBoxAssesmentNapzaYa.Checked = (bool)dr["bt_assesmen_pasien_napza_ya"];
                chkBoxAssesmentNapzaTidak.Checked = (bool)dr["bt_assesmen_pasien_napza_tidak"];

                chkBoxAssesmentTraumaYa.Checked = (bool)dr["bt_assesmen_pasien_trauma_ya"];
                chkBoxAssesmentTraumaTidak.Checked = (bool)dr["bt_assesmen_pasien_trauma_tidak"];

                chkBoxAssesmentPemecahanPahamPatuh.Checked = (bool)dr["bt_assesmen_pasien_pemecahankesehatan_pahampatuh"];
                chkBoxAssesmentPemecahanTidakPatuh.Checked = (bool)dr["bt_assesmen_pasien_pemecahankesehatan_tidakpatuh"];
                chkBoxAssesmentPemecahanPahamTidakPatuh.Checked = (bool)dr["bt_assesmen_pasien_pemecahankesehatan_pahamtidakpatuh"];
                chkBoxAssesmentPerubahanMampu.Checked = (bool)dr["bt_assesmen_pasien_kemampuan_adaptasi"];
                chkBoxAssesmentPerubahanTdkMampu.Checked = (bool)dr["bt_assesmen_pasien_kemampuan_tidakadaptasi"];
                chkBoxAssesmentLegalAda.Checked = (bool)dr["bt_assesmen_pasien_aspeklegal_ada"];
                chkBoxAssesmentLegalTdk.Checked = (bool)dr["bt_assesmen_pasien_aspeklegal_tidakada"];
                chkBoxAssesmentPemecahanPahamPatuh.Checked = (bool)dr["bt_identifikasi_tidaksesuaikebutuhan"];
                chkBoxIdentifikasiOverUtiisasi.Checked = (bool)dr["bt_identifikasi_overunderutilisasi"];
                chkBoxIdentifikasiTidakSesuaiKebutuhan.Checked = (bool)dr["bt_identifikasi_tidaksesuaikebutuhan"];
                chkBoxIdentifikasiOverUtiisasi.Checked = (bool)dr["bt_identifikasi_overunderutilisasi"];
                chkBoxIdentifikasiKetidakpatuhan.Checked  = (bool)dr["bt_identifikasi_ketidakpatuhan"];
                chkBoxIdentifikasiEdukasi.Checked = (bool)dr["bt_identifikasi_edukasi"];
                chkBoxIdentifikasiDukunganKeluarga.Checked = (bool)dr["bt_identifikasi_kurangdukungankeluarga"];
                chkBoxIdentifikasiPenurunanDeterminasiPasien.Checked = (bool)dr["bt_identifikasi_penurunandeterminasi"];
                chkBoxIdentifikasiKendalaKeuangan.Checked = (bool)dr["bt_identifikasi_kendalakeuangan"];
                chkBoxIdentifikasiPemulanganPasien.Checked = (bool)dr["bt_identifikasi_pemulanganpasien"];
                chkBoxIdentifikasiLain.Checked = (bool)dr["bt_identifikasi_lain"];
                txtIdentifikasiLain.Text = dr["vc_identifikasi_lain"].ToString();
                chkBoxPerencanaanIdentifikasi.Checked  =(bool)dr["bt_monitoring_identifikasidiagnosis"];
                chkBoxPerencanaanPastikanRencanaAsuhan.Checked = (bool)dr["bt_monitoring_rencanaasuhan"];
                chkBoxPerencanaanFasilitasi.Checked = (bool)dr["bt_monitoring_fasilitasi"];
                chkBoxPerencanaanRencanakanPemberianInformasi.Checked = (bool)dr["bt_monitoring_rencanakanpemberianinformasi"];
                chkBoxPerencanaanRencanakanKeterlibatanPasien.Checked = (bool)dr["bt_monitoring_rencanakanketerlibatanpasien"];
                chkBoxPerencanaanMonitor.Checked= (bool)dr["bt_monitoring_pembiayaan"];
                chkBoxPerencanaanLain.Checked = (bool)dr["bt_monitoring_lain"];
                txtPerencanaanLain.Text  = dr["vc_monitoring_lain"].ToString();
            }
            else
            {
                _isExists = false;
            }
            dr.Close();
            
        }
        public void getDataExistsB()
        {

            var sqlCmd = new SqlCommand();
            string query = "Select * FROM CASEMIX_Form_B where vc_no_reg = @vc_no_reg ";
            sqlCmd = new SqlCommand(query, clMain.DBConn.objConnection);
            sqlCmd.Parameters.AddWithValue("@vc_no_reg", _noReg);
            SqlDataReader dr = sqlCmd.ExecuteReader();
            if (dr.HasRows)
            {
                _isExistsB = true;
                dr.Read();
                _hdridB = (int)dr["in_auto"];
                chkBoxPelaksanaanMemastikanDiagnosis.Checked = (bool)dr["bt_pelaksaan_memastikandiagnosis"];
                chkBoxPelaksanaanKebutuhanEdukasi.Checked = (bool)dr["bt_pelaksaan_kebutuhanedukasi"];
                chkBoxPelaksanaanPartisipasiKeluarga.Checked = (bool)dr["bt_pelaksaan_partisipasikeluarga"];
                chkBoxPelaksanaanPertemuaanDPJP.Checked = (bool)dr["bt_pelaksaan_pertemuandpjp"];
                chkBoxPelaksanaanMemastikanBiaya.Checked = (bool)dr["bt_pelaksaan_jaminanbiaya"];
                chkBoxMonitoringCatatanPerkembangan.Checked = (bool)dr["bt_monitoring_catatanperkembangan"];
                chkBoxMonitoringKolaborasi.Checked = (bool)dr["bt_monitoring_kolaborasi"];
                chkBoxMonitoringEdukasi.Checked = (bool)dr["bt_monitoring_edukasi"];
                chkBoxMonitoringPembiayaan.Checked = (bool)dr["bt_monitoring_pembiayaan"];

                chkBoxFasilitasiDiskusi.Checked = (bool)dr["bt_fasilitasi_diskusi"];
                chkBoxFasilitasiKoordinasiAhliGizi.Checked = (bool)dr["bt_fasilitasi_koordinasiahligizi"];
                chkBoxFasilitasiMediasi.Checked = (bool)dr["bt_fasilitasi_mediasinegosiasi"];
                chkBoxFasilitasiKoordinasiPemulangan.Checked = (bool)dr["bt_fasilitasi_koordinasipemulanganpasien"];
                chkBoxAdvokasiPasien.Checked = (bool)dr["bt_advokasi_pasien"];

                chkBoxHasilPelayananPasienPaham.Checked = (bool)dr["bt_hasilpelayanan_pasienpaham"];
                chkBoxHasilPelayananPembahasanDPJP.Checked = (bool)dr["bt_hasilpelayanan_pembahasandpjp"];
                chkBoxTerminasiPemantauan.Checked = (bool)dr["bt_terminasi_pemantauanpelayanan"];
                chkBoxTerminasiMemastikanBiaya.Checked = (bool)dr["bt_terminasi_memastikanbiaya"];
                chkBoxTerminasiAlasanMengakhiri.Checked = (bool)dr["bt_terminasi_alasanmengakhiri"];
                txtTerminasiAlasan1.Text = dr["vc_terminasi_alasan1"].ToString();
                txtTerminasiAlasan2.Text = dr["vc_terminasi_alasan2"].ToString();

            }
            else
            {
                _isExistsB = false;
            }
            dr.Close();

        }

        public int getDataHdrFormB()
        {
            int id = 0;
            var sqlCmd = new SqlCommand();
            string query = "Select in_auto FROM CASEMIX_Form_B where vc_no_reg = @vc_no_reg ";
            sqlCmd = new SqlCommand(query, clMain.DBConn.objConnection);
            sqlCmd.Parameters.AddWithValue("@vc_no_reg", _noReg);
            SqlDataReader dr = sqlCmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                id = (int)dr["in_auto"]; 
            }
            else
            {
                id = 0;
            }
            dr.Close();
            return id;

        }
        private void FormInput_Load(object sender, EventArgs e)
        {
            //tabPage1.AutoScroll = true;
        }

        private void btnPreviewReport_Click(object sender, EventArgs e)
        {
          //  DataSetBukuPiutang dataSetBukuPiutang = getDataSetBukuPiutang();
            ReportDataSource reportDataSource = new ReportDataSource();

            var parameters = new List<ReportParameter>();
            parameters.Add(new ReportParameter("NoRM", "00590724"));
            parameters.Add(new ReportParameter("NamaPasien", "WENDRA"));
          

            FrmPreviewReport.ShowReport("Laporan Form A", "RptFormA", reportDataSource, parameters);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_isExists)
            {
                updateData();
            }
            else
            {
                simpanData();
            }
           
        }

        private void updateData()
        {
            try
            {



                string query = @"UPDATE [dbo].[CASEMIX_Form_A]
                           SET [bt_skrining_usia18] = @bt_skrining_usia18
                              ,[bt_skrining_usia60] = @bt_skrining_usia60
                              ,[bt_skrining_usia75] = @bt_skrining_usia75
                              ,[bt_skrining_pasien_critical] = @bt_skrining_pasien_critical
                              ,[bt_skrining_pasien_biaya10jt] = @bt_skrining_pasien_biaya10jt
                              ,[bt_skrining_pasienBPJS_los5] = @bt_skrining_pasienBPJS_los5
                              ,[bt_skrining_pasienBJPS_overINA] =@bt_skrining_pasienBJPS_overINA
                              ,[bt_skrining_pasien_prioritas] =@bt_skrining_pasien_prioritas
                              ,[bt_skrining_pasien_resikokomplain] = @bt_skrining_pasien_resikokomplain
                              ,[bt_skrining_pasien_kompleksrumit] = @bt_skrining_pasien_kompleksrumit
                              ,[bt_skrining_pasien_biayakompleks] =@bt_skrining_pasien_biayakompleks
                              ,[bt_skrining_pasien_koginitifrendah] = @bt_skrining_pasien_koginitifrendah
                              ,[bt_skrining_pasien_kronis] =@bt_skrining_pasien_kronis
                              ,[bt_skrining_pasien_fungsional_rendah] =@bt_skrining_pasien_fungsional_rendah
                              ,[bt_skrining_pasien_identifikasi_rencanapulang] = @bt_skrining_pasien_identifikasi_rencanapulang
                              ,[bt_assesmen_pasien_mandiri_penuh] = @bt_assesmen_pasien_mandiri_penuh
                              ,[bt_assesmen_pasien_mandiri_sebagian] =@bt_assesmen_pasien_mandiri_sebagian
                              ,[bt_assesmen_pasien_total_bantuan] =@bt_assesmen_pasien_total_bantuan
                              ,[bt_assesmen_pasien_riwayat_tdk_pernah_dirawat] = @bt_assesmen_pasien_riwayat_tdk_pernah_dirawat
                              ,[bt_assesmen_pasien_riwayat_pernah_dirawat] =@bt_assesmen_pasien_riwayat_pernah_dirawat
                              ,[vc_assesmen_pasien_riwayat_pernah_dirawat] =@vc_assesmen_pasien_riwayat_pernah_dirawat
                              ,[bt_assesmen_pasien_psikokultural_tenang] = @bt_assesmen_pasien_psikokultural_tenang
                              ,[bt_assesmen_pasien_psikokultural_cemas] =@bt_assesmen_pasien_psikokultural_cemas
                              ,[bt_assesmen_pasien_psikokultural_depresi] = @bt_assesmen_pasien_psikokultural_depresi
                              ,[bt_assesmen_pasien_psikokultural_marah] = @bt_assesmen_pasien_psikokultural_marah
                              ,[bt_assesmen_pasien_psikokultural_lain] = @bt_assesmen_pasien_psikokultural_lain
                              ,[vc_assesmen_pasien_psikokultural_lain] = @vc_assesmen_pasien_psikokultural_lain
                              ,[bt_assesmen_pasien_mental_adariwayat] =@bt_assesmen_pasien_mental_adariwayat
                              ,[bt_assesmen_pasien_mental_tidakada] = @bt_assesmen_pasien_mental_tidakada
                              ,[bt_assesmen_pasien_mental_dalampengobatan] = @bt_assesmen_pasien_mental_dalampengobatan
                              ,[bt_assesmen_pasien_mental_gagalpengobatan] = @bt_assesmen_pasien_mental_gagalpengobatan
                              ,[bt_assesmen_pasien_mental_gangguanserius] = @bt_assesmen_pasien_mental_gangguanserius
                              ,[bt_assesmen_pasien_dukungankeluarga_handal] = @bt_assesmen_pasien_dukungankeluarga_handal
                              ,[bt_assesmen_pasien_dukungankeluarga_dipertanyakan] =@bt_assesmen_pasien_dukungankeluarga_dipertanyakan
                              ,[bt_assesmen_pasien_dukungankeluarga_krisis] = @bt_assesmen_pasien_dukungankeluarga_krisis
                              ,[bt_assesmen_pasien_dukungankeluarga_tidakada] = @bt_assesmen_pasien_dukungankeluarga_tidakada
                              ,[bt_assesmen_pasien_finansial_pegawainegeri] = @bt_assesmen_pasien_finansial_pegawainegeri
                              ,[bt_assesmen_pasien_finansial_buruh] = @bt_assesmen_pasien_finansial_buruh
                              ,[bt_assesmen_pasien_finansial_tdkkerja] = @bt_assesmen_pasien_finansial_tdkkerja
                              ,[bt_assesmen_pasien_finansial_wiraswasta] = @bt_assesmen_pasien_finansial_wiraswasta
                              ,[bt_assesmen_pasien_finansial_pensiunan] =@bt_assesmen_pasien_finansial_pensiunan
                              ,[bt_assesmen_pasien_finansial_lain] = @bt_assesmen_pasien_finansial_lain
                              ,[vc_assesmen_pasien_finansial_lain] = @vc_assesmen_pasien_finansial_lain
                              ,[bt_assesmen_pasien_asuransi_adaaktif] = @bt_assesmen_pasien_asuransi_adaaktif
                              ,[bt_assesmen_pasien_asuransi_adatidakaktif] =@bt_assesmen_pasien_asuransi_adatidakaktif
                              ,[bt_assesmen_pasien_asuransi_tidakada] = @bt_assesmen_pasien_asuransi_tidakada
                              ,[bt_assesmen_pasien_napza_ya] = @bt_assesmen_pasien_napza_ya
                              ,[bt_assesmen_pasien_napza_tidak] = @bt_assesmen_pasien_napza_tidak
                              ,[bt_assesmen_pasien_trauma_ya] =@bt_assesmen_pasien_trauma_ya
                              ,[bt_assesmen_pasien_trauma_tidak] = @bt_assesmen_pasien_trauma_tidak
                              ,[bt_assesmen_pasien_pemecahankesehatan_pahampatuh] = @bt_assesmen_pasien_pemecahankesehatan_pahampatuh
                              ,[bt_assesmen_pasien_pemecahankesehatan_tidakpatuh] = @bt_assesmen_pasien_pemecahankesehatan_tidakpatuh
                              ,[bt_assesmen_pasien_pemecahankesehatan_pahamtidakpatuh] = @bt_assesmen_pasien_pemecahankesehatan_pahamtidakpatuh
                              ,[bt_assesmen_pasien_kemampuan_adaptasi] = @bt_assesmen_pasien_kemampuan_adaptasi
                              ,[bt_assesmen_pasien_kemampuan_tidakadaptasi] =@bt_assesmen_pasien_kemampuan_tidakadaptasi
                              ,[bt_assesmen_pasien_aspeklegal_ada] = @bt_assesmen_pasien_aspeklegal_ada
                              ,[bt_assesmen_pasien_aspeklegal_tidakada] = @bt_assesmen_pasien_aspeklegal_tidakada
                              ,[bt_identifikasi_tidaksesuaikebutuhan] = @bt_identifikasi_tidaksesuaikebutuhan
                              ,[bt_identifikasi_overunderutilisasi] = @bt_identifikasi_overunderutilisasi
                              ,[bt_identifikasi_ketidakpatuhan] = @bt_identifikasi_ketidakpatuhan
                              ,[bt_identifikasi_edukasi] =@bt_identifikasi_edukasi
                              ,[bt_identifikasi_kurangdukungankeluarga] =@bt_identifikasi_kurangdukungankeluarga
                              ,[bt_identifikasi_penurunandeterminasi] = @bt_identifikasi_penurunandeterminasi
                              ,[bt_identifikasi_kendalakeuangan] = @bt_identifikasi_kendalakeuangan
                              ,[bt_identifikasi_pemulanganpasien] = @bt_identifikasi_pemulanganpasien
                              ,[bt_identifikasi_lain] = @bt_identifikasi_lain
                              ,[vc_identifikasi_lain] = @vc_identifikasi_lain
                              ,[bt_monitoring_identifikasidiagnosis] =@bt_monitoring_identifikasidiagnosis
                              ,[bt_monitoring_rencanaasuhan] = @bt_monitoring_rencanaasuhan
                              ,[bt_monitoring_fasilitasi] = @bt_monitoring_fasilitasi
                              ,[bt_monitoring_rencanakanpemberianinformasi] =@bt_monitoring_rencanakanpemberianinformasi
                              ,[bt_monitoring_rencanakanketerlibatanpasien] = @bt_monitoring_rencanakanketerlibatanpasien
                              ,[bt_monitoring_pembiayaan] = @bt_monitoring_pembiayaan
                              ,[bt_monitoring_lain] = @bt_monitoring_lain
                              ,[vc_monitoring_lain] = @vc_monitoring_lain
                              ,[vc_last_update_by] = @vc_last_update_by
                         WHERE vc_no_reg = @vc_no_reg and vc_no_rm = @vc_no_rm";
                ;
                SqlCommand cmd = new SqlCommand(query, clMain.DBConn.objConnection);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@vc_no_reg", _noReg);
                cmd.Parameters.AddWithValue("@vc_no_rm", _noRM);
                cmd.Parameters.AddWithValue("@bt_skrining_usia18", chkBoxSkriningUsia18.Checked);
                cmd.Parameters.AddWithValue("@bt_skrining_usia60", chkBoxSkriningUsia60.Checked);
                cmd.Parameters.AddWithValue("@bt_skrining_usia75", chkBoxSkriningUsia75.Checked);
                cmd.Parameters.AddWithValue("@bt_skrining_pasien_critical", chkBoxSkriningCritical.Checked);
                cmd.Parameters.AddWithValue("@bt_skrining_pasien_biaya10jt", chkBoxSkriningBiaya10jt.Checked);
                cmd.Parameters.AddWithValue("@bt_skrining_pasienBPJS_los5", chkBoxSkriningBPJSLos5.Checked);
                cmd.Parameters.AddWithValue("@bt_skrining_pasienBJPS_overINA", chkBoxSkriningBPJSOverINA.Checked);
                cmd.Parameters.AddWithValue("@bt_skrining_pasien_prioritas", chkBoxSkriningPrioritas.Checked);
                cmd.Parameters.AddWithValue("@bt_skrining_pasien_resikokomplain", chkBoxSkriningResikoKomplain.Checked);
                cmd.Parameters.AddWithValue("@bt_skrining_pasien_kompleksrumit", chkBoxSkriningRumit.Checked);
                
                cmd.Parameters.AddWithValue("@bt_skrining_pasien_biayakompleks", chkBoxSkriningBiayaKompleks.Checked);
                cmd.Parameters.AddWithValue("@bt_skrining_pasien_koginitifrendah", chkBoxSkriningKognitif.Checked);
                cmd.Parameters.AddWithValue("@bt_skrining_pasien_kronis", chkBoxSkriningKronis.Checked);
                cmd.Parameters.AddWithValue("@bt_skrining_pasien_fungsional_rendah", chkBoxSkriningFungsionalRendah.Checked);
                cmd.Parameters.AddWithValue("@bt_skrining_pasien_identifikasi_rencanapulang", chkBoxSkriningPasienDiidintifikasi.Checked);
                cmd.Parameters.AddWithValue("@bt_assesmen_pasien_mandiri_penuh", chkBoxAssesmentMandiriPenuh.Checked);
                cmd.Parameters.AddWithValue("@bt_assesmen_pasien_mandiri_sebagian", chkBoxAssesmentMandiriSebagian.Checked);
                cmd.Parameters.AddWithValue("@bt_assesmen_pasien_total_bantuan", chkBoxAssesmentTotalBantuan.Checked);

                cmd.Parameters.AddWithValue("@bt_assesmen_pasien_riwayat_tdk_pernah_dirawat", chkBoxAssesmentTdkPernahDirawat.Checked);
                cmd.Parameters.AddWithValue("@bt_assesmen_pasien_riwayat_pernah_dirawat", chkBoxAssesmentPernahDirawat.Checked);
                cmd.Parameters.AddWithValue("@vc_assesmen_pasien_riwayat_pernah_dirawat", txtPernahDirawat.Text);
                cmd.Parameters.AddWithValue("@bt_assesmen_pasien_psikokultural_tenang", chkBoxAssesmentPerilakuTenang.Checked);
                cmd.Parameters.AddWithValue("@bt_assesmen_pasien_psikokultural_cemas", chkBoxAssesmentPerilakuCemas.Checked);
                cmd.Parameters.AddWithValue("@bt_assesmen_pasien_psikokultural_depresi", chkBoxAssesmentPerilakuDepresi.Checked);
                cmd.Parameters.AddWithValue("@bt_assesmen_pasien_psikokultural_marah", chkBoxAssesmentPerilakuMarah.Checked);
                cmd.Parameters.AddWithValue("@bt_assesmen_pasien_psikokultural_lain", chkBoxAssesmentPerilakuLain.Checked);
                cmd.Parameters.AddWithValue("@vc_assesmen_pasien_psikokultural_lain", txtAssesmentPerilakuLain.Text);
                cmd.Parameters.AddWithValue("@bt_assesmen_pasien_mental_adariwayat", chkBoxAssesmentMentalAdaRiwayat.Checked);
                cmd.Parameters.AddWithValue("@bt_assesmen_pasien_mental_tidakada", chkBoxAssesmentMentalTidakAdaGangguan.Checked);
                cmd.Parameters.AddWithValue("@bt_assesmen_pasien_mental_dalampengobatan", chkBoxAssesmentMentalDlmPengobatan.Checked);
                cmd.Parameters.AddWithValue("@bt_assesmen_pasien_mental_gagalpengobatan", chkBoxAssesmentMentalGagalPengobatan.Checked);
                cmd.Parameters.AddWithValue("@bt_assesmen_pasien_mental_gangguanserius", chkBoxAssesmentMentalGangguanSerius.Checked);
                cmd.Parameters.AddWithValue("@bt_assesmen_pasien_dukungankeluarga_handal", chkBoxAssesmentDukunganKeluargaHandal.Checked);
                cmd.Parameters.AddWithValue("@bt_assesmen_pasien_dukungankeluarga_dipertanyakan", chkBoxAssesmentDukunganKeluargaDipertanyakan.Checked);
                cmd.Parameters.AddWithValue("@bt_assesmen_pasien_dukungankeluarga_krisis", chkBoxAssesmentDukunganKeluargaKrisis.Checked);
                cmd.Parameters.AddWithValue("@bt_assesmen_pasien_dukungankeluarga_tidakada", chkBoxAssesmentDukunganKeluargaTidakAda.Checked);
                cmd.Parameters.AddWithValue("@bt_assesmen_pasien_finansial_pegawainegeri", chkBoxAssesmentFinansialPNS.Checked);
                cmd.Parameters.AddWithValue("@bt_assesmen_pasien_finansial_buruh", chkBoxAssesmentFinansialBuruh.Checked);
                cmd.Parameters.AddWithValue("@bt_assesmen_pasien_finansial_tdkkerja", chkBoxAssesmentFinansialTdkKerja.Checked);
                cmd.Parameters.AddWithValue("@bt_assesmen_pasien_finansial_wiraswasta", chkBoxAssesmentFinansialWiraswasta.Checked);
                cmd.Parameters.AddWithValue("@bt_assesmen_pasien_finansial_pensiunan", chkBoxAssesmentFinansialPensiunan.Checked);
                cmd.Parameters.AddWithValue("@bt_assesmen_pasien_finansial_lain", chkBoxAssesmentFinansialLain.Checked);
                cmd.Parameters.AddWithValue("@vc_assesmen_pasien_finansial_lain", TxtAssesmentFinansialLain.Text);
                cmd.Parameters.AddWithValue("@bt_assesmen_pasien_asuransi_adaaktif", chkBoxAssesmentAsuransiAdaAktif.Checked);
                cmd.Parameters.AddWithValue("@bt_assesmen_pasien_asuransi_adatidakaktif", chkBoxAssesmentAsuransiAdaTdkAktif.Checked);
                cmd.Parameters.AddWithValue("@bt_assesmen_pasien_asuransi_tidakada", chkBoxAssesmentAsuransiTidakAda.Checked);
                cmd.Parameters.AddWithValue("@bt_assesmen_pasien_napza_ya", chkBoxAssesmentNapzaYa.Checked);
                cmd.Parameters.AddWithValue("@bt_assesmen_pasien_napza_tidak", chkBoxAssesmentNapzaTidak.Checked);
                cmd.Parameters.AddWithValue("@bt_assesmen_pasien_trauma_ya", chkBoxAssesmentTraumaYa.Checked);
                cmd.Parameters.AddWithValue("@bt_assesmen_pasien_trauma_tidak", chkBoxAssesmentTraumaTidak.Checked);
                cmd.Parameters.AddWithValue("@bt_assesmen_pasien_pemecahankesehatan_pahampatuh", chkBoxAssesmentPemecahanPahamPatuh.Checked);
                cmd.Parameters.AddWithValue("@bt_assesmen_pasien_pemecahankesehatan_tidakpatuh", chkBoxAssesmentPemecahanTidakPatuh.Checked);
                cmd.Parameters.AddWithValue("@bt_assesmen_pasien_pemecahankesehatan_pahamtidakpatuh", chkBoxAssesmentPemecahanPahamTidakPatuh.Checked);
                cmd.Parameters.AddWithValue("@bt_assesmen_pasien_kemampuan_adaptasi", chkBoxAssesmentPerubahanMampu.Checked);
                cmd.Parameters.AddWithValue("@bt_assesmen_pasien_kemampuan_tidakadaptasi", chkBoxAssesmentPerubahanTdkMampu.Checked);
                cmd.Parameters.AddWithValue("@bt_assesmen_pasien_aspeklegal_ada", chkBoxAssesmentLegalAda.Checked);
                cmd.Parameters.AddWithValue("@bt_assesmen_pasien_aspeklegal_tidakada", chkBoxAssesmentLegalTdk.Checked);


                cmd.Parameters.AddWithValue("@bt_identifikasi_tidaksesuaikebutuhan", chkBoxIdentifikasiTidakSesuaiKebutuhan.Checked);
                cmd.Parameters.AddWithValue("@bt_identifikasi_overunderutilisasi", chkBoxIdentifikasiOverUtiisasi.Checked);
                cmd.Parameters.AddWithValue("@bt_identifikasi_ketidakpatuhan", chkBoxIdentifikasiKetidakpatuhan.Checked);
                cmd.Parameters.AddWithValue("@bt_identifikasi_edukasi", chkBoxIdentifikasiEdukasi.Checked);
                cmd.Parameters.AddWithValue("@bt_identifikasi_kurangdukungankeluarga", chkBoxIdentifikasiDukunganKeluarga.Checked);
                cmd.Parameters.AddWithValue("@bt_identifikasi_penurunandeterminasi", chkBoxIdentifikasiPenurunanDeterminasiPasien.Checked);
                cmd.Parameters.AddWithValue("@bt_identifikasi_kendalakeuangan", chkBoxIdentifikasiKendalaKeuangan.Checked);
                cmd.Parameters.AddWithValue("@bt_identifikasi_pemulanganpasien", chkBoxIdentifikasiPemulanganPasien.Checked);
                cmd.Parameters.AddWithValue("@bt_identifikasi_lain", chkBoxIdentifikasiLain.Checked);
                cmd.Parameters.AddWithValue("@vc_identifikasi_lain", txtIdentifikasiLain.Text);
                cmd.Parameters.AddWithValue("@bt_monitoring_identifikasidiagnosis", chkBoxPerencanaanIdentifikasi.Checked);
                cmd.Parameters.AddWithValue("@bt_monitoring_rencanaasuhan", chkBoxPerencanaanPastikanRencanaAsuhan.Checked);
                cmd.Parameters.AddWithValue("@bt_monitoring_fasilitasi", chkBoxPerencanaanFasilitasi.Checked);
                cmd.Parameters.AddWithValue("@bt_monitoring_rencanakanpemberianinformasi", chkBoxPerencanaanRencanakanPemberianInformasi.Checked);
                cmd.Parameters.AddWithValue("@bt_monitoring_rencanakanketerlibatanpasien", chkBoxPerencanaanRencanakanKeterlibatanPasien.Checked);
                cmd.Parameters.AddWithValue("@bt_monitoring_pembiayaan", chkBoxPerencanaanMonitor.Checked);
                cmd.Parameters.AddWithValue("@bt_monitoring_lain", chkBoxPerencanaanLain.Checked);
                cmd.Parameters.AddWithValue("@vc_monitoring_lain", txtPerencanaanLain.Text);

                cmd.Parameters.AddWithValue("@vc_last_update_by", clMain.cUserLogIn);
                cmd.ExecuteNonQuery();
              
                MsgBoxUtil.MsgInfo("Update Form A Berhasil Disimpan");

            }
            catch (Exception ex)
            {
            
                MsgBoxUtil.MsgError(ex.Message);

            }
        }

        private void simpanData()
        {
            try
            {



                string query = @"INSERT INTO [dbo].[CASEMIX_Form_A]
                                   ([vc_no_reg]
                                   ,[vc_no_rm]
                                   ,[bt_skrining_usia18]
                                   ,[bt_skrining_usia60]
                                   ,[bt_skrining_usia75]
                                   ,[bt_skrining_pasien_critical]
                                   ,[bt_skrining_pasien_biaya10jt]
                                   ,[bt_skrining_pasienBPJS_los5]
                                   ,[bt_skrining_pasienBJPS_overINA]
                                   ,[bt_skrining_pasien_prioritas]
                                   ,[bt_skrining_pasien_resikokomplain]
                                   ,[bt_skrining_pasien_kompleksrumit]
                                   ,[bt_skrining_pasien_biayakompleks]
                                   ,[bt_skrining_pasien_koginitifrendah]
                                   ,[bt_skrining_pasien_kronis]
                                   ,[bt_skrining_pasien_fungsional_rendah]
                                   ,[bt_skrining_pasien_identifikasi_rencanapulang]
                                   ,[bt_assesmen_pasien_mandiri_penuh]
                                   ,[bt_assesmen_pasien_mandiri_sebagian]
                                   ,[bt_assesmen_pasien_total_bantuan]
                                   ,[bt_assesmen_pasien_riwayat_tdk_pernah_dirawat]
                                   ,[bt_assesmen_pasien_riwayat_pernah_dirawat]
                                   ,[vc_assesmen_pasien_riwayat_pernah_dirawat]
                                   ,[bt_assesmen_pasien_psikokultural_tenang]
                                   ,[bt_assesmen_pasien_psikokultural_cemas]
                                   ,[bt_assesmen_pasien_psikokultural_depresi]
                                   ,[bt_assesmen_pasien_psikokultural_marah]
                                   ,[bt_assesmen_pasien_psikokultural_lain]
                                   ,[vc_assesmen_pasien_psikokultural_lain]
                                   ,[bt_assesmen_pasien_mental_adariwayat]
                                   ,[bt_assesmen_pasien_mental_tidakada]
                                   ,[bt_assesmen_pasien_mental_dalampengobatan]
                                   ,[bt_assesmen_pasien_mental_gagalpengobatan]
                                   ,[bt_assesmen_pasien_mental_gangguanserius]
                                   ,[bt_assesmen_pasien_dukungankeluarga_handal]
                                   ,[bt_assesmen_pasien_dukungankeluarga_dipertanyakan]
                                   ,[bt_assesmen_pasien_dukungankeluarga_krisis]
                                   ,[bt_assesmen_pasien_dukungankeluarga_tidakada]
                                   ,[bt_assesmen_pasien_finansial_pegawainegeri]
                                   ,[bt_assesmen_pasien_finansial_buruh]
                                   ,[bt_assesmen_pasien_finansial_tdkkerja]
                                   ,[bt_assesmen_pasien_finansial_wiraswasta]
                                   ,[bt_assesmen_pasien_finansial_pensiunan]
                                   ,[bt_assesmen_pasien_finansial_lain]
                                   ,[vc_assesmen_pasien_finansial_lain]
                                   ,[bt_assesmen_pasien_asuransi_adaaktif]
                                   ,[bt_assesmen_pasien_asuransi_adatidakaktif]
                                   ,[bt_assesmen_pasien_asuransi_tidakada]
                                   ,[bt_assesmen_pasien_napza_ya]
                                   ,[bt_assesmen_pasien_napza_tidak]
                                   ,[bt_assesmen_pasien_trauma_ya]
                                   ,[bt_assesmen_pasien_trauma_tidak]
                                   ,[bt_assesmen_pasien_pemecahankesehatan_pahampatuh]
                                   ,[bt_assesmen_pasien_pemecahankesehatan_tidakpatuh]
                                   ,[bt_assesmen_pasien_pemecahankesehatan_pahamtidakpatuh]
                                   ,[bt_assesmen_pasien_kemampuan_adaptasi]
                                   ,[bt_assesmen_pasien_kemampuan_tidakadaptasi]
                                   ,[bt_assesmen_pasien_aspeklegal_ada]
                                   ,[bt_assesmen_pasien_aspeklegal_tidakada]
                                   ,[bt_identifikasi_tidaksesuaikebutuhan]
                                   ,[bt_identifikasi_overunderutilisasi]
                                   ,[bt_identifikasi_ketidakpatuhan]
                                   ,[bt_identifikasi_edukasi]
                                   ,[bt_identifikasi_kurangdukungankeluarga]
                                   ,[bt_identifikasi_penurunandeterminasi]
                                   ,[bt_identifikasi_kendalakeuangan]
                                   ,[bt_identifikasi_pemulanganpasien]
                                   ,[bt_identifikasi_lain]
                                   ,[vc_identifikasi_lain]
                                   ,[bt_monitoring_identifikasidiagnosis]
                                   ,[bt_monitoring_rencanaasuhan]
                                   ,[bt_monitoring_fasilitasi]
                                   ,[bt_monitoring_rencanakanpemberianinformasi]
                                   ,[bt_monitoring_rencanakanketerlibatanpasien]
                                   ,[bt_monitoring_pembiayaan]
                                   ,[bt_monitoring_lain]
                                   ,[vc_monitoring_lain]
                                   ,[vc_create_by])
                             VALUES
                                   (@vc_no_reg
                                   ,@vc_no_rm
                                   ,@bt_skrining_usia18
                                   ,@bt_skrining_usia60
                                   ,@bt_skrining_usia75
                                   ,@bt_skrining_pasien_critical
                                   ,@bt_skrining_pasien_biaya10jt
                                   ,@bt_skrining_pasienBPJS_los5
                                   ,@bt_skrining_pasienBJPS_overINA
                                   ,@bt_skrining_pasien_prioritas
                                   ,@bt_skrining_pasien_resikokomplain
                                   ,@bt_skrining_pasien_kompleksrumit
                                   ,@bt_skrining_pasien_biayakompleks
                                   ,@bt_skrining_pasien_koginitifrendah
                                   ,@bt_skrining_pasien_kronis
                                   ,@bt_skrining_pasien_fungsional_rendah
                                   ,@bt_skrining_pasien_identifikasi_rencanapulang
                                   ,@bt_assesmen_pasien_mandiri_penuh
                                   ,@bt_assesmen_pasien_mandiri_sebagian
                                   ,@bt_assesmen_pasien_total_bantuan
                                   ,@bt_assesmen_pasien_riwayat_tdk_pernah_dirawat
                                   ,@bt_assesmen_pasien_riwayat_pernah_dirawat
                                   ,@vc_assesmen_pasien_riwayat_pernah_dirawat
                                   ,@bt_assesmen_pasien_psikokultural_tenang
                                   ,@bt_assesmen_pasien_psikokultural_cemas
                                   ,@bt_assesmen_pasien_psikokultural_depresi
                                   ,@bt_assesmen_pasien_psikokultural_marah
                                   ,@bt_assesmen_pasien_psikokultural_lain
                                   ,@vc_assesmen_pasien_psikokultural_lain
                                   ,@bt_assesmen_pasien_mental_adariwayat
                                   ,@bt_assesmen_pasien_mental_tidakada
                                   ,@bt_assesmen_pasien_mental_dalampengobatan
                                   ,@bt_assesmen_pasien_mental_gagalpengobatan
                                   ,@bt_assesmen_pasien_mental_gangguanserius
                                   ,@bt_assesmen_pasien_dukungankeluarga_handal
                                   ,@bt_assesmen_pasien_dukungankeluarga_dipertanyakan
                                   ,@bt_assesmen_pasien_dukungankeluarga_krisis
                                   ,@bt_assesmen_pasien_dukungankeluarga_tidakada
                                   ,@bt_assesmen_pasien_finansial_pegawainegeri
                                   ,@bt_assesmen_pasien_finansial_buruh
                                   ,@bt_assesmen_pasien_finansial_tdkkerja
                                   ,@bt_assesmen_pasien_finansial_wiraswasta
                                   ,@bt_assesmen_pasien_finansial_pensiunan
                                   ,@bt_assesmen_pasien_finansial_lain
                                   ,@vc_assesmen_pasien_finansial_lain
                                   ,@bt_assesmen_pasien_asuransi_adaaktif
                                   ,@bt_assesmen_pasien_asuransi_adatidakaktif
                                   ,@bt_assesmen_pasien_asuransi_tidakada
                                   ,@bt_assesmen_pasien_napza_ya
                                   ,@bt_assesmen_pasien_napza_tidak
                                   ,@bt_assesmen_pasien_trauma_ya
                                   ,@bt_assesmen_pasien_trauma_tidak
                                   ,@bt_assesmen_pasien_pemecahankesehatan_pahampatuh
                                   ,@bt_assesmen_pasien_pemecahankesehatan_tidakpatuh
                                   ,@bt_assesmen_pasien_pemecahankesehatan_pahamtidakpatuh
                                   ,@bt_assesmen_pasien_kemampuan_adaptasi
                                   ,@bt_assesmen_pasien_kemampuan_tidakadaptasi
                                   ,@bt_assesmen_pasien_aspeklegal_ada
                                   ,@bt_assesmen_pasien_aspeklegal_tidakada
                                   ,@bt_identifikasi_tidaksesuaikebutuhan
                                   ,@bt_identifikasi_overunderutilisasi
                                   ,@bt_identifikasi_ketidakpatuhan
                                   ,@bt_identifikasi_edukasi
                                   ,@bt_identifikasi_kurangdukungankeluarga
                                   ,@bt_identifikasi_penurunandeterminasi
                                   ,@bt_identifikasi_kendalakeuangan
                                   ,@bt_identifikasi_pemulanganpasien
                                   ,@bt_identifikasi_lain
                                   ,@vc_identifikasi_lain
                                   ,@bt_monitoring_identifikasidiagnosis
                                   ,@bt_monitoring_rencanaasuhan
                                   ,@bt_monitoring_fasilitasi
                                   ,@bt_monitoring_rencanakanpemberianinformasi
                                   ,@bt_monitoring_rencanakanketerlibatanpasien
                                   ,@bt_monitoring_pembiayaan
                                   ,@bt_monitoring_lain
                                   ,@vc_monitoring_lain
                                   ,@vc_create_by)";
                ;
                  SqlCommand cmd = new SqlCommand(query, clMain.DBConn.objConnection);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@vc_no_reg", _noReg);
                    cmd.Parameters.AddWithValue("@vc_no_rm", _noRM);
                    cmd.Parameters.AddWithValue("@bt_skrining_usia18", chkBoxSkriningUsia18.Checked);
                    cmd.Parameters.AddWithValue("@bt_skrining_usia60", chkBoxSkriningUsia60.Checked);
                    cmd.Parameters.AddWithValue("@bt_skrining_usia75", chkBoxSkriningUsia75.Checked);
                    cmd.Parameters.AddWithValue("@bt_skrining_pasien_critical", chkBoxSkriningCritical.Checked);
                    cmd.Parameters.AddWithValue("@bt_skrining_pasien_biaya10jt", chkBoxSkriningBiaya10jt.Checked);
                    cmd.Parameters.AddWithValue("@bt_skrining_pasienBPJS_los5", chkBoxSkriningBPJSLos5.Checked);
                    cmd.Parameters.AddWithValue("@bt_skrining_pasienBJPS_overINA", chkBoxSkriningBPJSOverINA.Checked);
                    cmd.Parameters.AddWithValue("@bt_skrining_pasien_prioritas", chkBoxSkriningPrioritas.Checked);
                    cmd.Parameters.AddWithValue("@bt_skrining_pasien_resikokomplain", chkBoxSkriningResikoKomplain.Checked);
                   cmd.Parameters.AddWithValue("@bt_skrining_pasien_kompleksrumit", chkBoxSkriningRumit.Checked);
                   cmd.Parameters.AddWithValue("@bt_skrining_pasien_biayakompleks", chkBoxSkriningBiayaKompleks.Checked);
                    cmd.Parameters.AddWithValue("@bt_skrining_pasien_koginitifrendah", chkBoxSkriningKognitif.Checked);
                    cmd.Parameters.AddWithValue("@bt_skrining_pasien_kronis", chkBoxSkriningKronis.Checked);
                    cmd.Parameters.AddWithValue("@bt_skrining_pasien_fungsional_rendah", chkBoxSkriningFungsionalRendah.Checked);
                    cmd.Parameters.AddWithValue("@bt_skrining_pasien_identifikasi_rencanapulang", chkBoxSkriningPasienDiidintifikasi.Checked);
                    cmd.Parameters.AddWithValue("@bt_assesmen_pasien_mandiri_penuh", chkBoxAssesmentMandiriPenuh.Checked);
                    cmd.Parameters.AddWithValue("@bt_assesmen_pasien_mandiri_sebagian", chkBoxAssesmentMandiriSebagian.Checked);
                    cmd.Parameters.AddWithValue("@bt_assesmen_pasien_total_bantuan", chkBoxAssesmentTotalBantuan.Checked);

                    cmd.Parameters.AddWithValue("@bt_assesmen_pasien_riwayat_tdk_pernah_dirawat", chkBoxAssesmentTdkPernahDirawat.Checked);
                    cmd.Parameters.AddWithValue("@bt_assesmen_pasien_riwayat_pernah_dirawat", chkBoxAssesmentPernahDirawat.Checked);
                    cmd.Parameters.AddWithValue("@vc_assesmen_pasien_riwayat_pernah_dirawat", txtPernahDirawat.Text);
                    cmd.Parameters.AddWithValue("@bt_assesmen_pasien_psikokultural_tenang", chkBoxAssesmentPerilakuTenang.Checked);
                    cmd.Parameters.AddWithValue("@bt_assesmen_pasien_psikokultural_cemas", chkBoxAssesmentPerilakuCemas.Checked);
                    cmd.Parameters.AddWithValue("@bt_assesmen_pasien_psikokultural_depresi", chkBoxAssesmentPerilakuDepresi.Checked);
                    cmd.Parameters.AddWithValue("@bt_assesmen_pasien_psikokultural_marah", chkBoxAssesmentPerilakuMarah.Checked);
                    cmd.Parameters.AddWithValue("@bt_assesmen_pasien_psikokultural_lain", chkBoxAssesmentPerilakuLain.Checked);
                    cmd.Parameters.AddWithValue("@vc_assesmen_pasien_psikokultural_lain", txtAssesmentPerilakuLain.Text);
                    cmd.Parameters.AddWithValue("@bt_assesmen_pasien_mental_adariwayat", chkBoxAssesmentMentalAdaRiwayat.Checked);
                    cmd.Parameters.AddWithValue("@bt_assesmen_pasien_mental_tidakada", chkBoxAssesmentMentalTidakAdaGangguan.Checked);
                    cmd.Parameters.AddWithValue("@bt_assesmen_pasien_mental_dalampengobatan", chkBoxAssesmentMentalDlmPengobatan.Checked);
                    cmd.Parameters.AddWithValue("@bt_assesmen_pasien_mental_gagalpengobatan", chkBoxAssesmentMentalGagalPengobatan.Checked);
                    cmd.Parameters.AddWithValue("@bt_assesmen_pasien_mental_gangguanserius", chkBoxAssesmentMentalGangguanSerius.Checked);
                    cmd.Parameters.AddWithValue("@bt_assesmen_pasien_dukungankeluarga_handal", chkBoxAssesmentDukunganKeluargaHandal.Checked);
                    cmd.Parameters.AddWithValue("@bt_assesmen_pasien_dukungankeluarga_dipertanyakan", chkBoxAssesmentDukunganKeluargaDipertanyakan.Checked);
                    cmd.Parameters.AddWithValue("@bt_assesmen_pasien_dukungankeluarga_krisis", chkBoxAssesmentDukunganKeluargaKrisis.Checked);
                    cmd.Parameters.AddWithValue("@bt_assesmen_pasien_dukungankeluarga_tidakada", chkBoxAssesmentDukunganKeluargaTidakAda.Checked);
                    cmd.Parameters.AddWithValue("@bt_assesmen_pasien_finansial_pegawainegeri", chkBoxAssesmentFinansialPNS.Checked);
                    cmd.Parameters.AddWithValue("@bt_assesmen_pasien_finansial_buruh", chkBoxAssesmentFinansialBuruh.Checked);
                    cmd.Parameters.AddWithValue("@bt_assesmen_pasien_finansial_tdkkerja", chkBoxAssesmentFinansialTdkKerja.Checked);
                    cmd.Parameters.AddWithValue("@bt_assesmen_pasien_finansial_wiraswasta", chkBoxAssesmentFinansialWiraswasta.Checked);
                    cmd.Parameters.AddWithValue("@bt_assesmen_pasien_finansial_pensiunan", chkBoxAssesmentFinansialPensiunan.Checked);
                    cmd.Parameters.AddWithValue("@bt_assesmen_pasien_finansial_lain", chkBoxAssesmentFinansialLain.Checked);
                    cmd.Parameters.AddWithValue("@vc_assesmen_pasien_finansial_lain", TxtAssesmentFinansialLain.Text);
                    cmd.Parameters.AddWithValue("@bt_assesmen_pasien_asuransi_adaaktif", chkBoxAssesmentAsuransiAdaAktif.Checked);
                    cmd.Parameters.AddWithValue("@bt_assesmen_pasien_asuransi_adatidakaktif", chkBoxAssesmentAsuransiAdaTdkAktif.Checked);
                    cmd.Parameters.AddWithValue("@bt_assesmen_pasien_asuransi_tidakada", chkBoxAssesmentAsuransiTidakAda.Checked);
                    cmd.Parameters.AddWithValue("@bt_assesmen_pasien_napza_ya", chkBoxAssesmentNapzaYa.Checked);
                    cmd.Parameters.AddWithValue("@bt_assesmen_pasien_napza_tidak", chkBoxAssesmentNapzaTidak.Checked);
                    cmd.Parameters.AddWithValue("@bt_assesmen_pasien_trauma_ya", chkBoxAssesmentTraumaYa.Checked);
                    cmd.Parameters.AddWithValue("@bt_assesmen_pasien_trauma_tidak", chkBoxAssesmentTraumaTidak.Checked);
                    cmd.Parameters.AddWithValue("@bt_assesmen_pasien_pemecahankesehatan_pahampatuh", chkBoxAssesmentPemecahanPahamPatuh.Checked);
                    cmd.Parameters.AddWithValue("@bt_assesmen_pasien_pemecahankesehatan_tidakpatuh", chkBoxAssesmentPemecahanTidakPatuh.Checked);
                    cmd.Parameters.AddWithValue("@bt_assesmen_pasien_pemecahankesehatan_pahamtidakpatuh", chkBoxAssesmentPemecahanPahamTidakPatuh.Checked);
                    cmd.Parameters.AddWithValue("@bt_assesmen_pasien_kemampuan_adaptasi", chkBoxAssesmentPerubahanMampu.Checked);
                    cmd.Parameters.AddWithValue("@bt_assesmen_pasien_kemampuan_tidakadaptasi", chkBoxAssesmentPerubahanTdkMampu.Checked);
                    cmd.Parameters.AddWithValue("@bt_assesmen_pasien_aspeklegal_ada", chkBoxAssesmentLegalAda.Checked);
                    cmd.Parameters.AddWithValue("@bt_assesmen_pasien_aspeklegal_tidakada", chkBoxAssesmentLegalTdk.Checked);
            
                    
                    cmd.Parameters.AddWithValue("@bt_identifikasi_tidaksesuaikebutuhan", chkBoxIdentifikasiTidakSesuaiKebutuhan.Checked);
                    cmd.Parameters.AddWithValue("@bt_identifikasi_overunderutilisasi", chkBoxIdentifikasiOverUtiisasi.Checked);
                    cmd.Parameters.AddWithValue("@bt_identifikasi_ketidakpatuhan", chkBoxIdentifikasiKetidakpatuhan.Checked);
                    cmd.Parameters.AddWithValue("@bt_identifikasi_edukasi", chkBoxIdentifikasiEdukasi.Checked);
                    cmd.Parameters.AddWithValue("@bt_identifikasi_kurangdukungankeluarga",chkBoxIdentifikasiDukunganKeluarga.Checked);
                    cmd.Parameters.AddWithValue("@bt_identifikasi_penurunandeterminasi", chkBoxIdentifikasiPenurunanDeterminasiPasien.Checked);
                    cmd.Parameters.AddWithValue("@bt_identifikasi_kendalakeuangan", chkBoxIdentifikasiKendalaKeuangan.Checked);
                    cmd.Parameters.AddWithValue("@bt_identifikasi_pemulanganpasien", chkBoxIdentifikasiPemulanganPasien.Checked);
                    cmd.Parameters.AddWithValue("@bt_identifikasi_lain", chkBoxIdentifikasiLain.Checked);
                    cmd.Parameters.AddWithValue("@vc_identifikasi_lain", txtIdentifikasiLain.Text);
                    cmd.Parameters.AddWithValue("@bt_monitoring_identifikasidiagnosis", chkBoxPerencanaanIdentifikasi.Checked);
                    cmd.Parameters.AddWithValue("@bt_monitoring_rencanaasuhan", chkBoxPerencanaanPastikanRencanaAsuhan.Checked);
                    cmd.Parameters.AddWithValue("@bt_monitoring_fasilitasi", chkBoxPerencanaanFasilitasi.Checked);
                    cmd.Parameters.AddWithValue("@bt_monitoring_rencanakanpemberianinformasi", chkBoxPerencanaanRencanakanPemberianInformasi.Checked);
                    cmd.Parameters.AddWithValue("@bt_monitoring_rencanakanketerlibatanpasien", chkBoxPerencanaanRencanakanKeterlibatanPasien.Checked);
                    cmd.Parameters.AddWithValue("@bt_monitoring_pembiayaan", chkBoxPerencanaanMonitor.Checked);
                    cmd.Parameters.AddWithValue("@bt_monitoring_lain", chkBoxPerencanaanLain.Checked);
                    cmd.Parameters.AddWithValue("@vc_monitoring_lain", txtPerencanaanLain.Text);                
                             
                    cmd.Parameters.AddWithValue("@vc_create_by", clMain.cUserLogIn);
                    cmd.ExecuteNonQuery();
                    _isExists = true;
                    MsgBoxUtil.MsgInfo("Data Form A Berhasil Disimpan");
                
            }
            catch (Exception ex)
            {
                _isExists = false;
                MsgBoxUtil.MsgError(ex.Message);
               
            }
        }

        private void btnSimpanB_Click(object sender, EventArgs e)
        {

        }

        private void updateDataB()
        {
            try
            {



                string query = @"UPDATE [dbo].[CASEMIX_Form_B]
                            SET [bt_pelaksaan_memastikandiagnosis] = @bt_pelaksaan_memastikandiagnosis
                              ,[bt_pelaksaan_kebutuhanedukasi] =@bt_pelaksaan_kebutuhanedukasi
                              ,[bt_pelaksaan_partisipasikeluarga] = @bt_pelaksaan_partisipasikeluarga
                              ,[bt_pelaksaan_pertemuandpjp] = @bt_pelaksaan_pertemuandpjp
                              ,[bt_pelaksaan_jaminanbiaya] = @bt_pelaksaan_jaminanbiaya
                              ,[bt_monitoring_catatanperkembangan] = @bt_monitoring_catatanperkembangan
                              ,[bt_monitoring_kolaborasi] =@bt_monitoring_kolaborasi
                              ,[bt_monitoring_edukasi] = @bt_monitoring_edukasi
                              ,[bt_monitoring_pembiayaan] = @bt_monitoring_pembiayaan
                              ,[bt_fasilitasi_diskusi] = @bt_fasilitasi_diskusi
                              ,[bt_fasilitasi_koordinasiahligizi] =@bt_fasilitasi_koordinasiahligizi
                              ,[bt_fasilitasi_mediasinegosiasi] =@bt_fasilitasi_mediasinegosiasi
                              ,[bt_fasilitasi_koordinasipemulanganpasien] =@bt_fasilitasi_koordinasipemulanganpasien
                              ,[bt_advokasi_pasien] = @bt_advokasi_pasien
                              ,[bt_hasilpelayanan_pasienpaham] = @bt_hasilpelayanan_pasienpaham
                              ,[bt_hasilpelayanan_pembahasandpjp] =@bt_hasilpelayanan_pembahasandpjp
                              ,[bt_terminasi_pemantauanpelayanan] = @bt_terminasi_pemantauanpelayanan
                              ,[bt_terminasi_memastikanbiaya] = @bt_terminasi_memastikanbiaya
                              ,[bt_terminasi_alasanmengakhiri] = @bt_terminasi_alasanmengakhiri
                              ,[vc_terminasi_alasan1] = @vc_terminasi_alasan1
                              ,[vc_terminasi_alasan2] = @vc_terminasi_alasan2
                              ,[vc_last_update_by] = @vc_last_update_by
                         WHERE vc_no_reg = @vc_no_reg and vc_no_rm = @vc_no_rm";
                ;
                SqlCommand cmd = new SqlCommand(query, clMain.DBConn.objConnection);
                cmd.CommandType = CommandType.Text;


                cmd.Parameters.AddWithValue("@vc_no_reg", _noReg);
                cmd.Parameters.AddWithValue("@vc_no_rm", _noRM);
                cmd.Parameters.AddWithValue("@bt_pelaksaan_memastikandiagnosis", chkBoxPelaksanaanMemastikanDiagnosis.Checked);
                cmd.Parameters.AddWithValue("@bt_pelaksaan_kebutuhanedukasi", chkBoxPelaksanaanKebutuhanEdukasi.Checked);
                cmd.Parameters.AddWithValue("@bt_pelaksaan_partisipasikeluarga", chkBoxPelaksanaanPartisipasiKeluarga.Checked);
                cmd.Parameters.AddWithValue("@bt_pelaksaan_pertemuandpjp", chkBoxPelaksanaanPertemuaanDPJP.Checked);
                cmd.Parameters.AddWithValue("@bt_pelaksaan_jaminanbiaya", chkBoxPelaksanaanMemastikanBiaya.Checked);
                cmd.Parameters.AddWithValue("@bt_monitoring_catatanperkembangan", chkBoxMonitoringCatatanPerkembangan.Checked);
                cmd.Parameters.AddWithValue("@bt_monitoring_kolaborasi", chkBoxMonitoringKolaborasi.Checked);
                cmd.Parameters.AddWithValue("@bt_monitoring_edukasi", chkBoxMonitoringEdukasi.Checked);
                cmd.Parameters.AddWithValue("@bt_monitoring_pembiayaan", chkBoxMonitoringPembiayaan.Checked);



                cmd.Parameters.AddWithValue("@bt_fasilitasi_diskusi", chkBoxFasilitasiDiskusi.Checked);
                cmd.Parameters.AddWithValue("@bt_fasilitasi_koordinasiahligizi", chkBoxFasilitasiKoordinasiAhliGizi.Checked);
                cmd.Parameters.AddWithValue("@bt_fasilitasi_mediasinegosiasi", chkBoxFasilitasiMediasi.Checked);
                cmd.Parameters.AddWithValue("@bt_fasilitasi_koordinasipemulanganpasien", chkBoxFasilitasiKoordinasiPemulangan.Checked);


                cmd.Parameters.AddWithValue("@bt_advokasi_pasien", chkBoxAdvokasiPasien.Checked);

                cmd.Parameters.AddWithValue("@bt_hasilpelayanan_pasienpaham", chkBoxHasilPelayananPasienPaham.Checked);
                cmd.Parameters.AddWithValue("@bt_hasilpelayanan_pembahasandpjp", chkBoxHasilPelayananPembahasanDPJP.Checked);


                cmd.Parameters.AddWithValue("@bt_terminasi_pemantauanpelayanan", chkBoxTerminasiPemantauan.Checked);
                cmd.Parameters.AddWithValue("@bt_terminasi_memastikanbiaya", chkBoxTerminasiMemastikanBiaya.Checked);
                cmd.Parameters.AddWithValue("@bt_terminasi_alasanmengakhiri", chkBoxTerminasiAlasanMengakhiri.Checked);
                cmd.Parameters.AddWithValue("@vc_terminasi_alasan1", txtTerminasiAlasan1.Text);
                cmd.Parameters.AddWithValue("@vc_terminasi_alasan2", txtTerminasiAlasan2.Text);
                cmd.Parameters.AddWithValue("@vc_last_update_by", clMain.cUserLogIn);
                cmd.ExecuteNonQuery();
                MsgBoxUtil.MsgInfo("Update Form B Berhasil Disimpan");

            }
            catch (Exception ex)
            {
               
                MsgBoxUtil.MsgError(ex.Message);

            }
        }

        private void simpanDataB()
        {
            try
            {



                string query = @"INSERT INTO [dbo].[CASEMIX_Form_B]
                                   ([vc_no_reg]
                                   ,[vc_no_rm]
                                   ,[bt_pelaksaan_memastikandiagnosis]
                                   ,[bt_pelaksaan_kebutuhanedukasi]
                                   ,[bt_pelaksaan_partisipasikeluarga]
                                   ,[bt_pelaksaan_pertemuandpjp]
                                   ,[bt_pelaksaan_jaminanbiaya]
                                   ,[bt_monitoring_catatanperkembangan]
                                   ,[bt_monitoring_kolaborasi]
                                   ,[bt_monitoring_edukasi]
                                   ,[bt_monitoring_pembiayaan]
                                   ,[bt_fasilitasi_diskusi]
                                   ,[bt_fasilitasi_koordinasiahligizi]
                                   ,[bt_fasilitasi_mediasinegosiasi]
                                   ,[bt_fasilitasi_koordinasipemulanganpasien]
                                   ,[bt_advokasi_pasien]
                                   ,[bt_hasilpelayanan_pasienpaham]
                                   ,[bt_hasilpelayanan_pembahasandpjp]
                                   ,[bt_terminasi_pemantauanpelayanan]
                                   ,[bt_terminasi_memastikanbiaya]
                                   ,[bt_terminasi_alasanmengakhiri]
                                   ,[vc_terminasi_alasan1]
                                   ,[vc_terminasi_alasan2]
                                   ,[vc_create_by])
                             VALUES
                                   (@vc_no_reg
                                   ,@vc_no_rm
                                   ,@bt_pelaksaan_memastikandiagnosis
                                   ,@bt_pelaksaan_kebutuhanedukasi
                                   ,@bt_pelaksaan_partisipasikeluarga
                                   ,@bt_pelaksaan_pertemuandpjp
                                   ,@bt_pelaksaan_jaminanbiaya
                                   ,@bt_monitoring_catatanperkembangan
                                   ,@bt_monitoring_kolaborasi
                                   ,@bt_monitoring_edukasi
                                   ,@bt_monitoring_pembiayaan
                                   ,@bt_fasilitasi_diskusi
                                   ,@bt_fasilitasi_koordinasiahligizi
                                   ,@bt_fasilitasi_mediasinegosiasi
                                   ,@bt_fasilitasi_koordinasipemulanganpasien
                                   ,@bt_advokasi_pasien
                                   ,@bt_hasilpelayanan_pasienpaham
                                   ,@bt_hasilpelayanan_pembahasandpjp
                                   ,@bt_terminasi_pemantauanpelayanan
                                   ,@bt_terminasi_memastikanbiaya
                                   ,@bt_terminasi_alasanmengakhiri
                                   ,@vc_terminasi_alasan1
                                   ,@vc_terminasi_alasan2
                                   ,@vc_create_by)";
                                 
                ;
                SqlCommand cmd = new SqlCommand(query, clMain.DBConn.objConnection);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@vc_no_reg", _noReg);
                cmd.Parameters.AddWithValue("@vc_no_rm", _noRM);
                cmd.Parameters.AddWithValue("@bt_pelaksaan_memastikandiagnosis", chkBoxPelaksanaanMemastikanDiagnosis.Checked);
                cmd.Parameters.AddWithValue("@bt_pelaksaan_kebutuhanedukasi", chkBoxPelaksanaanKebutuhanEdukasi.Checked);
                cmd.Parameters.AddWithValue("@bt_pelaksaan_partisipasikeluarga", chkBoxPelaksanaanPartisipasiKeluarga.Checked);
                cmd.Parameters.AddWithValue("@bt_pelaksaan_pertemuandpjp", chkBoxPelaksanaanPertemuaanDPJP.Checked);
                cmd.Parameters.AddWithValue("@bt_pelaksaan_jaminanbiaya", chkBoxPelaksanaanMemastikanBiaya.Checked);
                cmd.Parameters.AddWithValue("@bt_monitoring_catatanperkembangan", chkBoxMonitoringCatatanPerkembangan.Checked);
                cmd.Parameters.AddWithValue("@bt_monitoring_kolaborasi", chkBoxMonitoringKolaborasi.Checked);
                cmd.Parameters.AddWithValue("@bt_monitoring_edukasi", chkBoxMonitoringEdukasi.Checked);
                cmd.Parameters.AddWithValue("@bt_monitoring_pembiayaan", chkBoxMonitoringPembiayaan.Checked);



                cmd.Parameters.AddWithValue("@bt_fasilitasi_diskusi", chkBoxFasilitasiDiskusi.Checked);
                cmd.Parameters.AddWithValue("@bt_fasilitasi_koordinasiahligizi", chkBoxFasilitasiKoordinasiAhliGizi.Checked);
                cmd.Parameters.AddWithValue("@bt_fasilitasi_mediasinegosiasi", chkBoxFasilitasiMediasi.Checked);
                cmd.Parameters.AddWithValue("@bt_fasilitasi_koordinasipemulanganpasien", chkBoxFasilitasiKoordinasiPemulangan.Checked);


                cmd.Parameters.AddWithValue("@bt_advokasi_pasien", chkBoxAdvokasiPasien.Checked);
                
                cmd.Parameters.AddWithValue("@bt_hasilpelayanan_pasienpaham", chkBoxHasilPelayananPasienPaham.Checked);
                cmd.Parameters.AddWithValue("@bt_hasilpelayanan_pembahasandpjp", chkBoxHasilPelayananPembahasanDPJP.Checked);
              
                
                cmd.Parameters.AddWithValue("@bt_terminasi_pemantauanpelayanan", chkBoxTerminasiPemantauan.Checked);
                cmd.Parameters.AddWithValue("@bt_terminasi_memastikanbiaya", chkBoxTerminasiMemastikanBiaya.Checked);
                cmd.Parameters.AddWithValue("@bt_terminasi_alasanmengakhiri", chkBoxTerminasiAlasanMengakhiri.Checked);
                cmd.Parameters.AddWithValue("@vc_terminasi_alasan1", txtTerminasiAlasan1.Text);
                cmd.Parameters.AddWithValue("@vc_terminasi_alasan2", txtTerminasiAlasan2.Text);
                
                cmd.Parameters.AddWithValue("@vc_create_by", clMain.cUserLogIn);
                cmd.ExecuteNonQuery();
                _isExistsB = true;
                MsgBoxUtil.MsgInfo("Data Form B Berhasil Disimpan");

            }
            catch (Exception ex)
            {
                _isExistsB = false;
                MsgBoxUtil.MsgError(ex.Message);

            }
        }

        private void btnSimpanB_Click_1(object sender, EventArgs e)
        {
            if (_isExistsB)
            {
                updateDataB();
            }
            else
            {
                simpanDataB();
            }
        }

        private void btnSIMPAN_Click(object sender, EventArgs e)
        {
            if (!_isExistsB)
            {
                MsgBoxUtil.MsgError("DATA FORM B Harus Disimpan dahulu , sebelum membuat catatan");
            }
            else
            {
                simpanDataCatatan();
              
            }
        }

        private void getCatatan()
        {
            DataTable dt = new DataTable();
            dgPiutang.DataSource = null;
            this.dgPiutang.DataMember = null;
            this.dgPiutang.Columns.Clear();
            this.dgPiutang.Refresh();
          

            string query = @"SELECT cat.in_auto, cat.dt_create_date, cat.vc_catatan
                          FROM [yakkumdatabase].[dbo].[CASEMIX_Form_B_Catatan]  cat INNER JOIN CASEMIX_Form_B b
                          on cat.in_auto_hdr = b.in_auto
                          and b.vc_no_reg = @vc_no_reg order by dt_create_Date asc";

        
            using (SqlCommand cmd = new SqlCommand(query, clMain.DBConn.objConnection))
            {
                cmd.Parameters.AddWithValue("@vc_no_reg", _noReg);
               
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }

            dgPiutang.DataSource = dt;
            this.dgPiutang.Columns.Add(new GridButtonColumn()
            {
                MappingName = "Edit",
                HeaderText = "Edit",
                AllowDefaultButtonText = true,
                DefaultButtonText = "Edit",

                Width = 180
            }); ;
            this.dgPiutang.Columns.Add(new GridButtonColumn()
            {
                MappingName = "Hapus",
                HeaderText = "Hapus",
                AllowDefaultButtonText = true,
                DefaultButtonText = "Delete",

                Width = 180
            }); ;

        }
        private void deleteCatatan_click(object sender, CellButtonClickEventArgs e)
        {

            int id = 0;
            var catatan = "";
            if (dgPiutang.CurrentCell.RowIndex >= 0) { 
               id= int.Parse(ClsUtil.getValueFromGridEvent(dgPiutang, dgPiutang.CurrentCell.RowIndex, "in_auto"));
               catatan = (ClsUtil.getValueFromGridEvent(dgPiutang, dgPiutang.CurrentCell.RowIndex, "vc_catatan"));
            }



            if (e.ColumnIndex == 3)
            {

                using (var form = new FrmEditCatatan(id, catatan))
                {

                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        getCatatan();
                        form.Close();
                    }

                }

            }

            if (e.ColumnIndex == 4)
            {

                if (MsgBoxUtil.MsgDelete())
                    DeleteDataCatatan(id);

            }



        }

        private void simpanDataCatatan()
        {
            try
            {

                if (_hdridB == 0)
                {
                    _hdridB =  getDataHdrFormB();
                }

                string query = @"
                                INSERT INTO [dbo].[CASEMIX_Form_B_Catatan]
                                           ([in_auto_hdr]
                                           ,[vc_catatan]
                                           ,[vc_create_by])
                                     VALUES
                                           (@in_auto_hdr
                                           ,@vc_catatan
                                           ,@vc_create_by)";

                ;
                SqlCommand cmd = new SqlCommand(query, clMain.DBConn.objConnection);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@in_auto_hdr", _hdridB);
                cmd.Parameters.AddWithValue("@vc_catatan", txtCatatan.Text);
                cmd.Parameters.AddWithValue("@vc_create_by", clMain.cUserLogIn);
                cmd.ExecuteNonQuery();
                getCatatan();
                MsgBoxUtil.MsgInfo("Data Catatan Berhasil Disimpan");

            }
            catch (Exception ex)
            {
               
                MsgBoxUtil.MsgError(ex.Message);

            }
        }


        private void DeleteDataCatatan(int id)
        {
            try
            {

            
                string query = @"
                                DELETE FROM   [dbo].[CASEMIX_Form_B_Catatan]
                                       WHERE in_auto = @in_auto ";

                ;
                SqlCommand cmd = new SqlCommand(query, clMain.DBConn.objConnection);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@in_auto", id);
             
                cmd.ExecuteNonQuery();
                getCatatan();
                MsgBoxUtil.MsgInfo("Data Catatan Berhasil Dihapus");

            }
            catch (Exception ex)
            {

                MsgBoxUtil.MsgError(ex.Message);

            }
        }
        private void dgPiutang_AutoGeneratingColumn(object sender, Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnArgs e)
        {
            if (e.Column.MappingName == "in_auto")
            {
                e.Column.HeaderText = "Id";
                e.Column.Width = 40;
                e.Column.Visible = false;
              
            }
            if (e.Column.MappingName == "dt_create_date")
            {
                e.Column.HeaderText = "Tgl";
                e.Column.Width = 150;
                e.Column.AllowFiltering = true;
                e.Column.Format = "dd/MM/yyyy HH:mm:ss";
            }
            if (e.Column.MappingName == "vc_catatan")
            {
                e.Column.HeaderText = "Catatan";
                e.Column.Width = 400;
                e.Column.AllowFiltering = true;
            }
           
        }
    }
}
