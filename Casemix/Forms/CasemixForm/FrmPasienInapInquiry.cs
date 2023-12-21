using Casemix.Forms.Analisa_Non_BPJS;
using Casemix.Util;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
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
    public partial class FrmPasienInapInquiry : Form
    {
        public FrmPasienInapInquiry()
        {
            InitializeComponent();
        }

        private void cmdCariRuang_Click(object sender, EventArgs e)
        {
            using (var form = new FrmLookup("Ruang"))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtKdRuang.Text = form.value;
                    txtNamaRuang.Text = form.texts;
                    //   gridTagihan.DataSource = null;
                    //  gridTagihan.Columns.Clear();
                }
                form.Close();
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            //FormInput formInput = new FormInput();
            // formInput.ShowDialog();
            // formInput.Close();
            getPasien();

        }

        private void getPasien()
        {
            DataTable dt = new DataTable();
            dgPiutang.DataSource = null;
            dgPiutang.Columns.Clear();
            
           string query = @"SELECT
	                    RMP_inap.vc_no_reg,
	                    RMP_inap.vc_no_rm,
	                    RMPasien.vc_nama_p,
	                    RMP_inap.dt_tgl_msk ,RMRuang.VC_n_ruang,(SELECT COUNT(1) formAexists FROM CASEMIX_Form_A
where vc_no_reg  = RMP_inap.vc_no_Reg) formAexists,
(SELECT COUNT(1) formBexists FROM CASEMIX_Form_B
where vc_no_reg  = RMP_inap.vc_no_Reg) formBexists
                    FROM
	                    RMP_inap
	                    INNER JOIN RMKamar ON (
                    CASE
	                    WHEN ( isnull( RMP_inap.vc_kd_kamar_mutasi, '' ) = '' ) THEN
	                    RMP_inap.vc_kd_kamar_masuk ELSE RMP_inap.vc_kd_kamar_mutasi 
                    END 
	                    ) = rmkamar.vc_no_bed
	                    INNER JOIN RMPasien ON RMP_inap.vc_no_rm = RMPasien.vc_no_rm
	                    INNER JOIN SDMDOKTER ON RMP_inap.vc_nid = SDMDOKTER.VC_NID
	                    INNER JOIN RMRuang ON RMKamar.vc_k_gugus = RMRuang.VC_k_ruang
	                    LEFT JOIN RMKelas ON
                    CASE
		
		                    WHEN ( RMP_inap.vc_KLAS_MUT IS NULL OR RMP_inap.vc_KLAS_MUT = '' ) THEN
		                    SUBSTRING ( RMP_inap.vc_K_KLAS_M, 5, 2 ) ELSE SUBSTRING ( RMP_inap.vc_KLAS_MUT, 5, 2 ) 
	                    END = RMKelas.vc_k_kelas 
                    WHERE   CONVERT (
							                    DATETIME,
							                    CONVERT ( VARCHAR, Isnull( RMP_inap.dt_tgl_msk, 0 ), 101 ),
							                    101 
							                    ) BETWEEN @dateFrom 
							                    AND @dateTo ";

            if (txtKdRuang.Text.Length >0)
            {
                query = query + " and RMRuang.VC_k_ruang = @VC_k_ruang";

            }
            if (txtNoRM.Text.Length > 0)
            {
                query = query + " and RMP_inap.vc_no_rm = @vc_no_rm";

            }
            if (txtNoReg.Text.Length > 0)
            {
                query = query + " and RMP_inap.vc_no_reg = @vc_no_reg";

            }
            using (SqlCommand cmd = new SqlCommand(query, clMain.DBConn.objConnection))
            {
                cmd.Parameters.AddWithValue("@dateFrom", dtFrom.Value.ToShortDateString());
                cmd.Parameters.AddWithValue("@dateTo", dtTo.Value.ToShortDateString());
                if (txtKdRuang.Text.Length > 0)
                {
                    cmd.Parameters.AddWithValue("@VC_k_ruang", txtKdRuang.Text);

                }
                if (txtNoRM.Text.Length > 0)
                {
                    cmd.Parameters.AddWithValue("@vc_no_rm", txtNoRM.Text);

                }
                if (txtNoReg.Text.Length > 0)
                {
                    cmd.Parameters.AddWithValue("@vc_no_reg", txtNoReg.Text);

                }

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }

            dgPiutang.DataSource = dt;
            this.dgPiutang.Columns.Add(new GridButtonColumn()
            {
                MappingName = "Test",
                HeaderText = "Pilih Pasien",
                AllowDefaultButtonText = true,
                DefaultButtonText = "Pilih",
               
                Width = 180
            }); ;
            dgPiutang.QueryRowStyle += SfDataGrid_QueryRowStyle1;
            //   this.dgPiutang.CellButtonClick += pilihPasien_click;
        }

        private void SfDataGrid_QueryRowStyle1(object sender, QueryRowStyleEventArgs e)
        {
            if (e.RowData == null || e.RowType != RowType.DefaultRow)

                return;
            int rowIndex = e.RowIndex;
            int adaFormA = int.Parse(ClsUtil.getValueFromGridEvent(dgPiutang, rowIndex, "formAexists"));
            int adaFormB = int.Parse(ClsUtil.getValueFromGridEvent(dgPiutang, rowIndex, "formBexists"));
            if (adaFormA == 1 || adaFormB == 1)
            {

                e.Style.BackColor = Color.CadetBlue;
            }
            if (adaFormA == 1 && adaFormB == 1)
            {

                e.Style.BackColor = Color.GreenYellow;
            }
            if (adaFormA == 0 && adaFormB == 0)
            {

                e.Style.BackColor = Color.LavenderBlush;
            }

        }

        private void pilihPasien_click(object sender, CellButtonClickEventArgs e)
        {
            var noReg = ClsUtil.getValueFromGridEvent(dgPiutang, dgPiutang.CurrentCell.RowIndex, "vc_no_reg");
            var noRM = ClsUtil.getValueFromGridEvent(dgPiutang, dgPiutang.CurrentCell.RowIndex, "vc_no_rm");
            var nama = ClsUtil.getValueFromGridEvent(dgPiutang, dgPiutang.CurrentCell.RowIndex, "vc_nama_p");
            FormInput formInput = new FormInput(noReg,noRM,nama);
            formInput.ShowDialog();
            formInput.Close();
        }

        private void dgPiutang_AutoGeneratingColumn(object sender, Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnArgs e)
        {
            if (e.Column.MappingName == "vc_no_reg")
            {
                e.Column.HeaderText = "No Reg";
                e.Column.Width = 90;
                e.Column.AllowFiltering = true;
            }
            if (e.Column.MappingName == "vc_no_rm")
            {
                e.Column.HeaderText = "No RM";
                e.Column.Width = 70;
                e.Column.AllowFiltering = true;
            }
            if (e.Column.MappingName == "vc_nama_p")
            {
                e.Column.HeaderText = "Nama";
                e.Column.Width = 190;
                e.Column.AllowFiltering = true;
            }
            if (e.Column.MappingName == "dt_tgl_msk")
            {
                e.Column.HeaderText = "Tgl Masuk";
                e.Column.Width = 80;
                e.Column.Format = "dd/MM/yyyy";
                e.Column.AllowFiltering = true;
            }
            if (e.Column.MappingName == "VC_n_ruang")
            {
                e.Column.HeaderText = "Ruang";
                e.Column.Width = 160;
                e.Column.AllowFiltering = true;
            }
            if (e.Column.MappingName == "formAexists")
            {
                e.Column.Visible = false;
            }
            if (e.Column.MappingName == "formBexists")
            {
               e.Column.Visible = false;
            }
        }
    }

		
	
}
