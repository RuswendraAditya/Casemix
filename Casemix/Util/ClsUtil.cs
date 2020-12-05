using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGridConverter;
using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casemix.Util
{
    class ClsUtil
    {


        public static void DownloadXLs(SfDataGrid sfDataGrid)
        {
            var options = new ExcelExportingOptions();
            options.ExcelVersion = ExcelVersion.Excel2013;
            //   options.CellExporting += CellExportingHandler;
            var excelEngine = sfDataGrid.ExportToExcel(sfDataGrid.View, options);
            var workBook = excelEngine.Excel.Workbooks[0];

            SaveFileDialog saveFilterDialog = new SaveFileDialog
            {
                FilterIndex = 2,
                Filter = "Excel 97 to 2003 Files(*.xls)|*.xls|Excel 2007 to 2010 Files(*.xlsx)|*.xlsx|Excel 2013 File(*.xlsx)|*.xlsx"
            };

            if (saveFilterDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (Stream stream = saveFilterDialog.OpenFile())
                {
                    if (saveFilterDialog.FilterIndex == 1)
                        workBook.Version = ExcelVersion.Excel97to2003;
                    else if (saveFilterDialog.FilterIndex == 2)
                        workBook.Version = ExcelVersion.Excel2010;
                    else
                        workBook.Version = ExcelVersion.Excel2013;
                    workBook.SaveAs(stream);
                }

                if (MessageBox.Show(sfDataGrid, "Do you want to view the workbook?", "Workbook has been created",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    System.Diagnostics.Process.Start(saveFilterDialog.FileName);
                }
            }
        }
        public static void SetDataTableRightOnMenu(string cUser, string cAppsID, string cOwner)

        {
            var objComm = new SqlCommand();
            var objDS = new DataSet();
            var objDT = new DataTable();
            var objDA = new SqlDataAdapter();
            try
            {
                objComm.Connection = clMain.DBConn.objConnection;
                objDS = clMain.DBConn.SetDataTableRightOnMenu(cUser, cAppsID, cOwner, ref objComm);
                objDA.SelectCommand = objComm;
                objDA.Fill(objDS);
                objDT = objDS.Tables[0];
                clMain.dtAccess = objDT;
            }
            catch (Exception ex)
            {
                MsgBoxUtil.MsgError(ex.Message);
            }
            finally
            {
                objComm.Dispose();
                objDS.Dispose();
                objDA.Dispose();
                objDT.Dispose();
            }
        }



        public static bool GetMenuRight(string cKode, byte nType)
        {
            
            bool GetMenuRightRet = false;
            System.Data.DataRow[] foundRows = clMain.dtAccess.Select("vc_codemenu = '" + cKode.Trim() + "'");
            switch (nType)
            {
                case 0: // cek status enable
                    {
                        if (foundRows.Length > 0)
                        {
                            GetMenuRightRet = (bool)foundRows[0]["bt_enable"];
                        }
                           
                        break;
                    }

                case 1: // cek status visible
                    {
                        if (foundRows.Length > 0)
                        {
                            GetMenuRightRet = (bool)foundRows[0]["bt_visible"];
                        }
                           
                        break;
                    }

                case 2: // cek status access
                    {
                        if (foundRows.Length > 0)
                        {
                            GetMenuRightRet = (bool)foundRows[0]["bt_access"];
                        }
                            
                        break;
                    }
            }

            return GetMenuRightRet;
        }

    }

    public static class CommonMethod
    {
        public static List<T> ConvertToList<T>(DataTable dt)
        {
            var columnNames = dt.Columns.Cast<DataColumn>().Select(c => c.ColumnName.ToLower()).ToList();
            var properties = typeof(T).GetProperties();
            return dt.AsEnumerable().Select(row => {
                var objT = Activator.CreateInstance<T>();
                foreach (var pro in properties)
                {
                    if (columnNames.Contains(pro.Name.ToLower()))
                    {
                        try
                        {
                            pro.SetValue(objT, row[pro.Name]);
                        }
                        catch (Exception ex) {
                        
                        }
                    }
                }
                return objT;
            }).ToList();
        }
    }
}
