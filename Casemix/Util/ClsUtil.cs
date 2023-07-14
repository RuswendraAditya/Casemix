using Microsoft.VisualBasic;
using Syncfusion.Data;
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

        public static string GetSetting(string table, string column, string where, string param)
        {
            string result = "";
            SqlDataReader dr;

            string SQLText = "SELECT " + column + " as result from " + table + " where " + where + "='" + param + "'";
            SqlCommand objcommand = new SqlCommand(SQLText, clMain.DBConn.objConnection);
            dr = objcommand.ExecuteReader();
            while (dr.Read())
            {
                result = (string)dr["result"];
            }


            dr.Close();
            return result;
        }

        public static string getValueFromGridEvent(SfDataGrid dataGrid, int rowIndex, string model)
        {
            var record = dataGrid.View.Records[dataGrid.TableControl.ResolveToRecordIndex(rowIndex)];
            var value = dataGrid.View.GetPropertyAccessProvider().GetValue((record as RecordEntry).Data, model);
            return value.ToString();
        }
        public static string Replicate(int n, string cCharacter)
        {
            string ReplicateRet = default;
            int i;
            ReplicateRet = "";
            i = 1;
            while (i <= n)
            {
                ReplicateRet = ReplicateRet + cCharacter;
                i = i + 1;
            }

            return ReplicateRet;
        }

        public static string AddSpace(string xVariabel, int xPJ, byte LCR, string CharSpace)
        {
            string AddSpaceRet = default;
            // LCR=left,center,right
            int Kiri;
            int Kanan;
            int Tambahan;
            AddSpaceRet = "";
            if (xPJ > Strings.Len(xVariabel))
            {
                switch (LCR)
                {
                    case 1:
                        {
                            AddSpaceRet = xVariabel + Replicate(xPJ - Strings.Len(xVariabel), CharSpace);
                            break;
                        }

                    case 2:
                        {
                            Tambahan = xPJ - Strings.Len(xVariabel);
                            Kiri = (int)Math.Round(Tambahan / 2d);
                            Kanan = Tambahan - Kiri;
                            if (Kiri > Kanan)
                            {
                                Kiri = Kiri - 1;
                                Kanan = Kanan + 1;
                            }

                            AddSpaceRet = Replicate(Kiri, CharSpace) + xVariabel + Replicate(Kanan, CharSpace);
                            break;
                        }

                    case 3:
                        {
                            AddSpaceRet = Replicate(xPJ - Strings.Len(xVariabel), CharSpace) + xVariabel;
                            break;
                        }
                }
            }
            else
            {
                AddSpaceRet = Strings.Left(xVariabel, xPJ);
            }

            return AddSpaceRet;
        }


        public static void DownloadXLs(SfDataGrid sfDataGrid)
        {
            var options = new ExcelExportingOptions();
            options.AllowOutlining = true;
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

                if (MessageBox.Show(sfDataGrid, "Apakah anda ingin membuka file excel hasil download ?", "Download Sukses!!",
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

        public static string TglDMY(string Kata)
        {
            string TglDMYRet = default;
            TglDMYRet = Strings.Right(Kata, 2) + "-" + Strings.Mid(Kata, 6, 2) + "-" + Strings.Left(Kata, 4);
            return TglDMYRet;
        }

        public static string TglYMD(string Kata)
        {
            string TglYMDRet = default;
            TglYMDRet = Strings.Right(Kata, 4) + "-" + Strings.Mid(Kata, 4, 2) + "-" + Strings.Left(Kata, 2);
            return TglYMDRet;
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
