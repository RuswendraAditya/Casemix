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
            }
            else
            {
                _isExists = false;
            }
            
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
