using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casemix.Forms.Laporan_BPJS
{
    public partial class FrmMonitoringSEP : Form
    {
        public FrmMonitoringSEP()
		{
		

			InitializeComponent();
            LoadStatusSEP();
        }

        private void FrmMonitoringSEP_Load(object sender, EventArgs e)
        {

        }


        private void LoadStatusSEP()
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

        private void btnCari_Click(object sender, EventArgs e)
        {
			dgPiutang.DataSource =   GetDateSEP();
			gridSummary.DataSource = GetTotalSEP();
			var danishCulture = CultureInfo.CreateSpecificCulture("da-DK");
			var totalROw = dgPiutang.RowCount;
			lblTotal.Text = String.Format(danishCulture,"{0:n0}",totalROw);
		}

		private DataTable GetTotalSEP()
        {
			DataTable dt = new DataTable();
			string query = @"SELECT
								ISNULL(status_sep,'--') status,COUNT(vc_no_SEP) jumlah 
						FROM
							(
						SELECT
							vc_no_sep,
							dt_tgl_sep,
							sep.vc_no_rm,
							sep.vc_no_regj,
							pasien.vc_nama_p,
							sep.vc_jenis_perawatan,
							ISNULL( statuss.vc_nm_status_sep, '' ) status_sep,
							Isnull( vc_ket_status_sep, '' ) keterangan,
							Isnull( sep.vc_kd_status_sep, 0 ) kd_status
						FROM
							bpjs_sep sep
							INNER JOIN rmpasien pasien ON pasien.vc_no_rm = sep.vc_no_rm
							LEFT JOIN bpjs_status_sep statuss ON statuss.vc_kd_status_sep = ISNULL( sep.vc_kd_status_sep, 0 ) 
						WHERE
							Isnull( bt_hapus, '0' ) <> 1 
							AND CONVERT (
							DATETIME,
							CONVERT ( VARCHAR, Isnull( dt_tgl_sep, 0 ), 101 ),
							101 
							) BETWEEN @dateFrom 
							AND  @dateTo
							AND vc_jenis_perawatan = 'Rawat Inap' UNION ALL
						SELECT
							vc_no_sep,
							dt_tgl_sep,
							sep.vc_no_rm,
							sep.vc_no_regj,
							pasien.vc_nama_p,
							sep.vc_jenis_perawatan,
							ISNULL( statuss.vc_nm_status_sep, '' ) status_sep,
							Isnull( vc_ket_status_sep, '' ) keterangan,
							Isnull( sep.vc_kd_status_sep, 0 ) kd_status
						FROM
							bpjs_sep sep
							INNER JOIN rmpasien pasien ON pasien.vc_no_rm = sep.vc_no_rm
							INNER JOIN bpjs_status_sep statuss ON statuss.vc_kd_status_sep = ISNULL( sep.vc_kd_status_sep, 0 ) 
						WHERE
							Isnull( bt_hapus, '0' ) <> 1 
							AND CONVERT (
							DATETIME,
							CONVERT ( VARCHAR, Isnull( dt_tgl_sep, 0 ), 101 ),
							101 
							) BETWEEN @dateFrom 
							AND @dateTo 
							AND vc_jenis_perawatan = 'Rawat Jalan' 
							) temp";
			if (cmbStatusSEP.SelectedValue.ToString() != "0")
			{
				query = query + " where temp.kd_status = '" + cmbStatusSEP.SelectedValue + "' ";

			}
			query = query + " GROUP BY status_sep ";
			using (SqlCommand cmd = new SqlCommand(query, clMain.DBConn.objConnection))
			{
				cmd.Parameters.AddWithValue("@dateFrom", DTAwalSEP.Value.ToShortDateString());
				cmd.Parameters.AddWithValue("@dateTo", DTAkhirSEP.Value.ToShortDateString());
				using (SqlDataAdapter da = new SqlDataAdapter(cmd))
				{
					da.Fill(dt);
				}
			}

			return dt;
		}

        private DataTable GetDateSEP()
		{
			DataTable dt = new DataTable();
			string query = @"SELECT
							* 
						FROM
							(
						SELECT
							vc_no_sep,
							dt_tgl_sep,
							sep.vc_no_rm,
							sep.vc_no_regj,
							pasien.vc_nama_p,
							sep.vc_jenis_perawatan,
							ISNULL( statuss.vc_nm_status_sep, '' ) status_sep,
							Isnull( vc_ket_status_sep, '' ) keterangan,
							Isnull( sep.vc_kd_status_sep, 0 ) kd_status
						FROM
							bpjs_sep sep
							INNER JOIN rmpasien pasien ON pasien.vc_no_rm = sep.vc_no_rm
							LEFT JOIN bpjs_status_sep statuss ON statuss.vc_kd_status_sep = ISNULL( sep.vc_kd_status_sep, 0 ) 
						WHERE
							Isnull( bt_hapus, '0' ) <> 1 
							AND CONVERT (
							DATETIME,
							CONVERT ( VARCHAR, Isnull( dt_tgl_sep, 0 ), 101 ),
							101 
							) BETWEEN @dateFrom 
							AND  @dateTo
							AND vc_jenis_perawatan = 'Rawat Inap' UNION ALL
						SELECT
							vc_no_sep,
							dt_tgl_sep,
							sep.vc_no_rm,
							sep.vc_no_regj,
							pasien.vc_nama_p,
							sep.vc_jenis_perawatan,
							ISNULL( statuss.vc_nm_status_sep, '' ) status_sep,
							Isnull( vc_ket_status_sep, '' ) keterangan,
							Isnull( sep.vc_kd_status_sep, 0 ) kd_status
						FROM
							bpjs_sep sep
							INNER JOIN rmpasien pasien ON pasien.vc_no_rm = sep.vc_no_rm
							INNER JOIN bpjs_status_sep statuss ON statuss.vc_kd_status_sep = ISNULL( sep.vc_kd_status_sep, 0 ) 
						WHERE
							Isnull( bt_hapus, '0' ) <> 1 
							AND CONVERT (
							DATETIME,
							CONVERT ( VARCHAR, Isnull( dt_tgl_sep, 0 ), 101 ),
							101 
							) BETWEEN @dateFrom 
							AND @dateTo 
							AND vc_jenis_perawatan = 'Rawat Jalan' 
							) temp";
			if (cmbStatusSEP.SelectedValue.ToString() != "0")
			{
				query = query + " where temp.kd_status = '" + cmbStatusSEP.SelectedValue + "' ";

			}
			using (SqlCommand cmd = new SqlCommand(query, clMain.DBConn.objConnection))
			{
				cmd.Parameters.AddWithValue("@dateFrom", DTAwalSEP.Value.ToShortDateString());
				cmd.Parameters.AddWithValue("@dateTo", DTAkhirSEP.Value.ToShortDateString());
				using (SqlDataAdapter da = new SqlDataAdapter(cmd))
				{
					da.Fill(dt);
				}
			}

			return dt;

		}

        private void dgPiutang_AutoGeneratingColumn(object sender, Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnArgs e)
        {
			if (e.Column.MappingName == "vc_no_sep")
			{
				e.Column.HeaderText = "No SEP";
				e.Column.Width = 140;
				e.Column.AllowFiltering = true;
			}
			if (e.Column.MappingName == "dt_tgl_sep")
			{
				e.Column.HeaderText = "Tgl SEP";
				e.Column.Width = 120;
				e.Column.Format = "dd-MMM-yyyy";
				e.Column.AllowFiltering = true;
			}
			if (e.Column.MappingName == "dt_tgl_sep")
			{
				e.Column.HeaderText = "Tgl SEP";
				e.Column.Width = 120;
				e.Column.Format = "dd-MMM-yyyy";
				e.Column.AllowFiltering = true;
			}
			if (e.Column.MappingName == "vc_no_regj")
			{
				e.Column.HeaderText = "No Reg";
				e.Column.Width = 100;
				e.Column.AllowFiltering = true;
			}

			if (e.Column.MappingName == "vc_no_rm")
			{
				e.Column.HeaderText = "No RM";
				e.Column.Width = 100;
				e.Column.AllowFiltering = true;

			}
			if (e.Column.MappingName == "vc_nama_p")
			{
				e.Column.HeaderText = "Nama Pasien";
				e.Column.Width = 240;
				e.Column.AllowFiltering = true;

			}
			if (e.Column.MappingName == "vc_jenis_perawatan")
			{
				e.Column.HeaderText = "Jenis Perawatan";
				e.Column.Width = 140;
				e.Column.AllowFiltering = true;
			}
			if (e.Column.MappingName == "status_sep")
			{
				e.Column.HeaderText = "Status";
				e.Column.Width = 140;
				e.Column.AllowFiltering = true;

			}
			if (e.Column.MappingName == "keterangan")
			{
				e.Column.HeaderText = "Keterangan";
				e.Column.Width = 140;
				e.Column.AllowFiltering = true;

			}
			if (e.Column.MappingName == "kd_status")
			{
				e.Column.HeaderText = "Kode Status";
				e.Column.Width = 140;
				e.Column.AllowFiltering = true;
				e.Column.Visible = false;
			}
		}

        private void gridSummary_AutoGeneratingColumn(object sender, Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnArgs e)
        {
			if (e.Column.MappingName == "status")
			{
				e.Column.HeaderText = "Status";
				e.Column.Width = 140;

			
			}

			if (e.Column.MappingName == "jumlah")
			{
				e.Column.HeaderText = "Jumlah";
				e.Column.Width = 110;
				e.Column.Format = "{0:n0}";
				
				


			}
		}
    }
}
