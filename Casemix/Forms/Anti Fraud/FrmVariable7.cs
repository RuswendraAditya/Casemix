using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using Syncfusion.WinForms.DataGridConverter;
using Casemix.Util;

namespace Casemix.Forms.Anti_Fraud
{
    public partial class FrmVariable7 : Form
    {
        public FrmVariable7()
        {
            InitializeComponent();
          
            this.dgPiutang.AllowEditing = false;
        }
        
        private void FrmVariable1_Load(object sender, EventArgs e)
        {

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
          
            DateTime dateFrom= new DateTime(dtFrom.Value.Year, dtFrom.Value.Month, 1);
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
	                            ( SELECT
	                            { fn MONTH ( dt_tgl_sep ) } AS Bulan,
	                            YEAR ( dt_tgl_sep ) AS Tahun,
	                            inacbg.SEVERITY AS severity,
	                            COUNT ( SEVERITY ) total 
                            FROM
	                            (SELECT  *,substring(inacbg, 8,12) AS SEVERITY FROM INACBG_RAW_DATA) inacbg
	                            INNER JOIN bpjs_sep sep ON sep.vc_no_sep = inacbg.sep 
	                            AND sep.vc_no_rm = inacbg.mrn 
	                            AND ISNULL( sep.bt_hapus, 0 ) <> 1 
                            WHERE
	                           CONVERT ( DateTime, CONVERT ( VARCHAR, Isnull( sep.dt_tgl_sep, 0 ), 101 ), 101 ) BETWEEN '" + String.Format(dateFrom.ToShortDateString(), "MM/DD/YYY") + "'  and '" + String.Format(dateTo.ToShortDateString(), "MM/DD/YYY") + "' " +
                                "AND SEVERITY <> '0'  " +
                               "GROUP BY " +
                               " { fn MONTH ( dt_tgl_sep ) },  " +
                               " YEAR ( dt_tgl_sep ),  " +
                               " SEVERITY  ) a PIVOT ( SUM ( a.total ) FOR severity IN ( [I], [II], [III] ) ) AS pivot_table   " +
                               " ORDER BY   " +
                               " tahun,     " +
                               " bulan ASC  "  ;
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

            if (e.Column.MappingName == "BulanString")
            {
                e.Column.HeaderText = "Bulan";
                e.Column.Width = 120;
                e.Column.AllowFiltering = true;
          
            }
            if (e.Column.MappingName == "Bulan")
            {
                e.Column.HeaderText = "Bulan";
                e.Column.Width = 120;
                e.Column.AllowFiltering = true;
                e.Column.Visible = false;

            }

            if (e.Column.MappingName == "Tahun")
            {
                e.Column.HeaderText = "Tahun";
                e.Column.Width = 120;
                e.Column.AllowFiltering = true;
            }

          

        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            ClsUtil.DownloadXLs(dgPiutang);
        }
    }
}