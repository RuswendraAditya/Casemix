using clMainLib.General;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casemix
{
    public class clMain
    {
        public static string cAppsname, cRSName, cRSID, cCopyRight, cUnit;
        public static string cGustu, cIDApps, cIDModul;
        public static string cNamaServer, cNamaDatabase, cNamaUser, cPassUser;
        public static string cModulName, cSubModulName, cHeaderMsg;
        public static string cAlamatRS, cKotaRS, cKodePosRS, cTelpRS, cFaxRS, cEmailRS;
        public static int nUserLevel = 1;
        public static string cUserLogIn = "";
        // Public Shared nUserLevel As Integer = 0
        public static string gKdTaripKamar = "";
        public static string gKd_KomponenDokter ="" ;
        public static MemoryStream xLogo1 = new MemoryStream();
        public static MemoryStream xLogo2 = new MemoryStream();
        public static DataTable dtAccess;
        public static DateTime TglServer;
        public static clsGeneral DBConn = new clsGeneral();
        public static clsGeneral DBConn1 = new clsGeneral();
        public static string KdKry1, KdKry2;
        public static string cSubGustu;
        public static string dTglBtsOL;
        public static string cKetTghn;
        public static string cAppNameToUpdate = "";
        public static string cAppVersionToUpdate = "";
        public static string cUpdateLink = "";
        

        public static void ReadValuesINIFiles()
        {
            string cINIFileName = Application.StartupPath + @"\" + "Application.ini";
            cAppsname = clMain.DBConn.ReadValueINIFile("Application", "Name", cINIFileName);
            cRSName = clMain.DBConn.ReadValueINIFile("Application", "RSName", cINIFileName);
            cRSID = clMain.DBConn.ReadValueINIFile("Application", "RSID", cINIFileName);
            cCopyRight = clMain.DBConn.ReadValueINIFile("Application", "Copyright", cINIFileName);
            cUnit = clMain.DBConn.ReadValueINIFile("Application", "Unit", cINIFileName);
            cRSID = clMain.DBConn.ReadValueINIFile("Application", "RSID", cINIFileName);
            cUpdateLink = clMain.DBConn.ReadValueINIFile("Variable", "UpdateLink", cINIFileName);


            cModulName = clMain.DBConn.ReadValueINIFile("Modul", "Piutang RS Bethesda", cINIFileName);
            cSubModulName = clMain.DBConn.ReadValueINIFile("Modul", "Piutang Instansi", cINIFileName);
            cHeaderMsg = cModulName;

            cNamaServer = clMain.DBConn.ConvertPass(clMain.DBConn.ReadValueINIFile("Connection", "ServerName_", cINIFileName), "D");
            cNamaDatabase = clMain.DBConn.ConvertPass(clMain.DBConn.ReadValueINIFile("Connection", "DBName_", cINIFileName), "D");
            cNamaUser = clMain.DBConn.ConvertPass(clMain.DBConn.ReadValueINIFile("Connection", "UN_", cINIFileName), "D");
            cPassUser = clMain.DBConn.ConvertPass(clMain.DBConn.ReadValueINIFile("Connection", "Pwd_", cINIFileName), "D");
            clMain.gKd_KomponenDokter = "21";


            DBConn.NamaServer = cNamaServer;
            DBConn.NamaDatabase = cNamaDatabase;
            DBConn.NamaUser = cNamaUser;
            DBConn.PassUser = cPassUser;

        }
    }
}
