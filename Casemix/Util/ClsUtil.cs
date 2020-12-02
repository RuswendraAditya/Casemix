using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casemix.Util
{
    class ClsUtil
    {
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
            DataRow[] foundRows = clMain.dtAccess.Select("vc_codemenu = '" + cKode.Trim() + "'");
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
                        catch (Exception ex) { }
                    }
                }
                return objT;
            }).ToList();
        }
    }
}
