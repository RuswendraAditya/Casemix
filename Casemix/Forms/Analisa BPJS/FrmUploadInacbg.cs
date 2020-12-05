using Casemix.Model;
using Casemix.Util;
using Excel;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;

using System.Data;
using System.Data.SqlClient;
using System.IO;

using System.Windows.Forms;

namespace Casemix.Forms.Analisa_BPJS
{


    public partial class FrmUploadInacbg : Form
    {
        DataTable dt;
        SqlTransaction sqlTrans;
        public FrmUploadInacbg()
        {
            InitializeComponent();
            dt = new DataTable();
        }


        private void ImportExcelFile()
        {
            try
            {
                string strFileName = ""; OpenFileDialog openFileDialog = new OpenFileDialog();

                openFileDialog.Filter = "Excel Files|*.xls;*.xlsx";
                // openFileDialog.DefaultExt = ".xls";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                   
                    dgPiutang.DataSource = null;
                    strFileName = openFileDialog.FileName;
                    txtFileName.Text = strFileName;
                    #region Get Correct Worksheet in excel file
                    DateTime dtStart = DateTime.Now;
                    ExcelEngine excelEngine = new ExcelEngine();
                    IApplication application = excelEngine.Excel;
                    IWorkbook workbook = application.Workbooks.Open(strFileName);
                    IWorksheet sheet = workbook.Worksheets[0];
                    #endregion

                    dt.Clear();

                    dt = sheet.ExportDataTable(sheet.UsedRange, ExcelExportDataTableOptions.ColumnNames);


                    //Close the workbook.
                    workbook.Close();

                    //No exception will be thrown if there are unsaved workbooks.
                    excelEngine.ThrowNotSavedOnDestroy = false;
                    excelEngine.Dispose();
                    dgPiutang.DataSource = dt;
                    dgPiutang.AutoSizeColumnsMode = AutoSizeColumnsMode.AllCells;



                }
            }

            catch (Exception err)
            {
                MsgBoxUtil.MsgError(err.Message.ToString());
            }
        }

        private void btnUploadExcel_Click(object sender, EventArgs e)
        {
            ImportExcelFile();
        }
        public bool BulkInsertDataTable(string tableName, DataTable dataTable)
        {
            bool isSuccuss;
            try
            {
                SqlBulkCopy bulkCopy = new SqlBulkCopy(clMain.DBConn.objConnection, SqlBulkCopyOptions.TableLock | SqlBulkCopyOptions.FireTriggers | SqlBulkCopyOptions.UseInternalTransaction, null);
                bulkCopy.DestinationTableName = tableName;
                bulkCopy.WriteToServer(dataTable);
                isSuccuss = true;
            }
            catch (Exception ex)
            {
                isSuccuss = false;
                MsgBoxUtil.MsgError(ex.Message);
            }
            return isSuccuss;
        }

        private void deleteTempData()
        {
            try
            {
                SqlCommand xcmd = new SqlCommand();
                sqlTrans = clMain.DBConn.objConnection.BeginTransaction();
                xcmd.Transaction = sqlTrans;
                xcmd.CommandTimeout = 60;
                string SQLText = @"DELETE FROM  INACBG_RAW_DATA_TEMP";
                clMain.DBConn.GeneralCommand(SQLText, ref xcmd);
                xcmd.ExecuteNonQuery();
                sqlTrans.Commit();
                sqlTrans.Dispose();
                sqlTrans = null;
            }
           catch
            {
                sqlTrans.Rollback();
                sqlTrans.Dispose();
                sqlTrans = null;
            }
         
        }

        private void deleteSEPOld()
        {
            try
            {
                SqlCommand xcmd = new SqlCommand();
                sqlTrans = clMain.DBConn.objConnection.BeginTransaction();
                xcmd.Transaction = sqlTrans;
                xcmd.CommandTimeout = 60;
                string SQLText = @"DELETE INACBG_RAW_DATA where sep IN 
                                        ( SELECT sep from INACBG_RAW_DATA_TEMP ) ";
                clMain.DBConn.GeneralCommand(SQLText, ref xcmd);
                xcmd.ExecuteNonQuery();

                SQLText = @"DELETE FROM  INACBG_RAW_DATA_TEMP";
                clMain.DBConn.GeneralCommand(SQLText, ref xcmd);
                xcmd.ExecuteNonQuery();
                sqlTrans.Commit();
                sqlTrans.Dispose();
                sqlTrans = null;
            }
            catch
            {
                sqlTrans.Rollback();
                sqlTrans.Dispose();
                sqlTrans = null;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dt.Rows.Count == 0)
            {
                MsgBoxUtil.MsgError("Tidak Ada Data Yang Disimpan!!!");
            }
            else
            {
              
                try
                {
                    //foreach (DataRow row in dt.Rows)
                    //{

                    //    //delete data lama dlu jika ada
                    //    var sep = row["sep"].ToString();
                    //    string SQLText = "DELETE INACBG_RAW_DATA where sep =  '" + sep + "'";
                    //    clMain.DBConn.GeneralCommand(SQLText, ref xcmd);
                    //    xcmd.ExecuteNonQuery();
                    //}
                    //sqlTrans.Commit();
                    //sqlTrans.Dispose();
                    //sqlTrans = null;
                   
                    deleteTempData();
                   
                    BulkInsertDataTable("INACBG_RAW_DATA_TEMP", dt);

                    deleteSEPOld();
     

                    bool result = BulkInsertDataTable("INACBG_RAW_DATA", dt);
                  
                    if (result)
                    {
                        MsgBoxUtil.MsgInfo("Save Data Berhasil");
                    }
                    else
                    {
                        MsgBoxUtil.MsgInfo("Data Gagal Disimpan");
                    }
                }
                catch (Exception ex)
                {
                    MsgBoxUtil.MsgError(ex.Message);
                    sqlTrans.Rollback();
                    sqlTrans.Dispose();
                }
            }
        }

        private void FrmUploadInacbg_Load(object sender, EventArgs e)
        {

        }
    }
}