using Casemix.Util;
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

namespace Casemix.Forms.Anti_Fraud
{
    public partial class FrmVariable3 : Form
    {
        public FrmVariable3()
        {
            InitializeComponent();
            dgPiutang.AllowEditing = false;
        }
       

        private void btnLoad_Click(object sender, EventArgs e)
        {
            
            getData();
        }

        private void getData()
        {
            dgPiutang.DataSource = getDataReport();
          
        }

        private DataTable getDataReport()
        {
            DataTable dt = new DataTable();

            DateTime dateFrom = new DateTime(dtFrom.Value.Year, dtFrom.Value.Month, 1);
            DateTime firstdateTo = new DateTime(dtTo.Value.Year, dtTo.Value.Month, 1);
            DateTime dateTo = firstdateTo.AddMonths(1).AddDays(-1);

            string query = @"SELECT
                            CASE
	                            bulan 
	                            WHEN 1 THEN
	                            'JAN' 
	                            WHEN 2 THEN
	                            'FEB' 
	                            WHEN 3 THEN
	                            'MAR' 
	                            WHEN 4 THEN
	                            'APR' 
	                            WHEN 5 THEN
	                            'MAY' 
	                            WHEN 6 THEN
	                            'JUN' 
	                            WHEN 7 THEN
	                            'JUL' 
	                            WHEN 8 THEN
	                            'AUG' 
	                            WHEN 9 THEN
	                            'SEP' 
	                            WHEN 10 THEN
	                            'OCT' 
	                            WHEN 11 THEN
	                            'NOV' 
	                            WHEN 12 THEN
	                            'DEC' 
	                            END AS BulanString, * 
                            FROM
	                            (
                            SELECT
	                            { fn MONTH ( dt_tgl_sep ) } AS Bulan,
	                            YEAR ( dt_tgl_sep ) AS Tahun,
	                            inacbg.KELAS_RAWAT AS kelas,
	                            COUNT ( kelas_rawat ) total 
                            FROM
	                            INACBG_RAW_DATA inacbg
	                            INNER JOIN bpjs_sep sep ON sep.vc_no_sep = inacbg.sep 
	                            AND sep.vc_no_rm = inacbg.mrn 
	                            AND ISNULL( sep.bt_hapus, 0 ) <> 1 
                            WHERE
	                            vc_Jenis_perawatan = 'Rawat Inap' 
	                            AND CONVERT ( DateTime, CONVERT ( VARCHAR, Isnull( sep.dt_tgl_sep, 0 ), 101 ), 101 ) BETWEEN '" + String.Format(dateFrom.ToShortDateString(), "MM/DD/YYY") + "'  and '" + String.Format(dateTo.ToShortDateString(), "MM/DD/YYY") + "' " +
                                "GROUP BY " +
                                "{ fn MONTH ( dt_tgl_sep ) }, " +
                                "YEAR ( dt_tgl_sep ), " +
                                "KELAS_RAWAT  " +
                                ") a PIVOT ( SUM ( a.total ) FOR kelas IN ( [1], [2], [3] ) ) AS pivot_table  " +
                                "ORDER BY  " +
                                "tahun, " +
                                "bulan ASC"; 
            using (SqlCommand cmd = new SqlCommand(query, clMain.DBConn.objConnection))
            {
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }

            return dt;
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            ClsUtil.DownloadXLs(dgPiutang);
        }

        private void dgPiutang_AutoGeneratingColumn(object sender, Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnArgs e)
        {

            if (e.Column.MappingName == "BulanString")
            {
                
                e.Column.Width = 120;
                e.Column.AllowFiltering = true;
            }
            if (e.Column.MappingName == "Bulan")
            {
                
                e.Column.Visible = false;
            }

            if (e.Column.MappingName == "Tahun")
            {
                e.Column.HeaderText = "Tahun";
                e.Column.Width = 120;
                e.Column.AllowFiltering = true;
            }

            if (e.Column.MappingName == "1")
            {
                e.Column.HeaderText = "Kelas 1";
                e.Column.Width = 120;
                e.Column.AllowFiltering = true;
            }

            if (e.Column.MappingName == "2")
            {
                e.Column.HeaderText = "Kelas 2";
                e.Column.Width = 120;
                e.Column.AllowFiltering = true;
            }

            if (e.Column.MappingName == "3")
            {
                e.Column.HeaderText = "Kelas 2";
                e.Column.Width = 120;
                e.Column.AllowFiltering = true;
            }
        }
    }



}
