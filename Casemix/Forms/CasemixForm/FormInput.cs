using Microsoft.Reporting.WinForms;
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
            getDataExists();
        }
        public void getDataExists()
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

            }
            else
            {
                _isExists = false;
            }
            dr.Close();
            
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
            MsgBoxUtil.MsgError("Blm tersedia fitur ini");
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
                                   ,[vc_operator])
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
                                   ,@vc_operator)";
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
           


                cmd.Parameters.AddWithValue("@vc_operator", clMain.cUserLogIn);
                cmd.ExecuteNonQuery();
                  MsgBoxUtil.MsgInfo("Data Berhasil Disimpan");
            }
            catch (Exception ex)
            {
                MsgBoxUtil.MsgError(ex.Message);
            }
        }
    }
}
