using Casemix.Forms.Analisa_BPJS;
using Casemix.Forms.Anti_Fraud;
using Casemix.Forms.Laporan_BPJS;
using Casemix.Util;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casemix.Forms
{

    public partial class FrmMain : Form
    {


        private string cStatus;
        public static string kdJKN = "";
        public string SetAppNameToUpdate
        {
            get
            {
                return clMain.cAppNameToUpdate;
            }

            set
            {
                clMain.cAppNameToUpdate = value;
            }
        }

        public string SetAppVersionToUpdate
        {
            get
            {
                return clMain.cAppVersionToUpdate;
            }

            set
            {
                clMain.cAppVersionToUpdate = value;
            }
        }

        public string StatusOpen
        {
            // properti untuk membaca nama server yang sedang terkoneksi
            get
            {
                return cStatus;
            }

            set
            {
                cStatus = value;
            }
        }

        public string SetUserLogin
        {
            // properti untuk membaca nama server yang sedang terkoneksi
            get
            {
                return clMain.cUserLogIn;
            }

            set
            {
                clMain.cUserLogIn = value;
            }
        }

        public int SetUserLevel
        {
            get
            {
                return clMain.nUserLevel;
            }

            set
            {
                clMain.nUserLevel = value;
            }
        }

        public string SetGugusTugas
        {
            get
            {
                return clMain.cGustu;
            }

            set
            {
                clMain.cGustu = value;
            }
        }

        public string SetIDApps
        {
            get
            {
                return clMain.cIDApps;
            }

            set
            {
                clMain.cIDApps = value;
            }
        }

        public string SetIDModul
        {
            get
            {
                return clMain.cIDModul;
            }

            set
            {
                clMain.cIDModul = value;
            }
        }
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            clMain.ReadValuesINIFiles();

            long openCOnnection = clMain.DBConn.DBOpenConnection();
            if (openCOnnection != 0)
            {
                MsgBoxUtil.MsgError("Gagal Akses Database");
                this.Close();
            }
            clMain.gKdTaripKamar = GetKdTaripKamar();
            ClsUtil.SetDataTableRightOnMenu(clMain.cUserLogIn, clMain.cIDApps, clMain.cIDModul);
            //  ClsUtil.SetDataTableRightOnMenu("wendra", "0202", "2201");
            //  SetMenuAccess();
            kdJKN = ClsUtil.GetSetting("Keu_piut_lookup", "vc_value", "vc_code", "KodeJKN");
        }
        public string GetKdTaripKamar()
        {
            string GetKdTaripKamarRet = default;
            string sSQL;
            SqlDataReader objDataReader;
            var oCmd1 = new SqlCommand();
            GetKdTaripKamarRet = "";
            sSQL = "Select distinct vc_kd_gsklco from RMKamar ";
            oCmd1 = new SqlCommand(sSQL, clMain.DBConn.objConnection);
            objDataReader = oCmd1.ExecuteReader();
            if (objDataReader.HasRows)
            {
                objDataReader.Read();
                GetKdTaripKamarRet = (string)(Convert.IsDBNull(objDataReader["vc_kd_gsklco"]) ? "" : objDataReader["vc_kd_gsklco"]);
            }

            objDataReader.Close();
            return GetKdTaripKamarRet;
        }


        private void SetMenuAccess()
        {
            // cek apakah semua menu visible atau tidak
            IEnumerator IEnum = MenuStrip.Items.GetEnumerator();
            while (IEnum.MoveNext())
            {
                ToolStripMenuItem aToolStripMenuItem = (ToolStripMenuItem)IEnum.Current;
                string code = aToolStripMenuItem.Name.Substring(3);

                // //looping lagi menuitemnya dengan menggunakan recursive
                aToolStripMenuItem.Enabled = ClsUtil.GetMenuRight(code, 0);
                aToolStripMenuItem.Visible = ClsUtil.GetMenuRight(code, 1);
                aToolStripMenuItem.Tag = ClsUtil.GetMenuRight(code, 2);
              AddRecursiveMenuItem(aToolStripMenuItem);
            }
        }

        private void AddRecursiveMenuItem(ToolStripMenuItem ToolStripMenuItemRef)
        {
            {
                for (int i = 0, loopTo = ToolStripMenuItemRef.DropDownItems.Count - 1; i <= loopTo; i++)
                {
                    // //cek apakah menu tsb berupa ToolStripSeparator atau bukan 
                    if (!(ToolStripMenuItemRef.DropDownItems[i] is ToolStripMenuItem))
                        continue;
                    string code = ToolStripMenuItemRef.DropDownItems[i].Name.Substring(3);
                    ToolStripMenuItemRef.DropDownItems[i].Enabled = ClsUtil.GetMenuRight(code, 0);
                    ToolStripMenuItemRef.DropDownItems[i].Visible = ClsUtil.GetMenuRight(code, 1);
                    ToolStripMenuItemRef.DropDownItems[i].Tag = ClsUtil.GetMenuRight(code, 2);
                    AddRecursiveMenuItem((ToolStripMenuItem)ToolStripMenuItemRef.DropDownItems[i]);
                }
            }

        }

        private void mnu020101010000_Click(object sender, EventArgs e)
        {
            FrmAnalisaPerCoding frmAnalisaPerDiagnosa = new FrmAnalisaPerCoding(); // Instantiate a Form3 object.
            frmAnalisaPerDiagnosa.ShowDialog(); // Show Form3 and
            frmAnalisaPerDiagnosa.Close();

        }

        private void mnu020101020000_Click(object sender, EventArgs e)
        {
            FrmAnaliasaPerDokter frmAnalisaPerDiagnosa = new FrmAnaliasaPerDokter(); // Instantiate a Form3 object.
            frmAnalisaPerDiagnosa.ShowDialog(); // Show Form3 and
            frmAnalisaPerDiagnosa.Close();
        }

        private void mnu020107000000_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void mnu020202010000_Click(object sender, EventArgs e)
        {

            FrmUploadInacbg frmUploadIna = new FrmUploadInacbg(); // Instantiate a Form object.
            frmUploadIna.ShowDialog(); // Show Form and
            frmUploadIna.Close();
        }

        private void mnu020202000000_Click(object sender, EventArgs e)
        {

        }

        private void mnu020202020000_Click(object sender, EventArgs e)
        {
            FrmAnalisaPerCoding frmAnalisaPerDiagnosa = new FrmAnalisaPerCoding(); // Instantiate a Form object.
            frmAnalisaPerDiagnosa.ShowDialog(); // Show Form and
            frmAnalisaPerDiagnosa.Close();
        }

        private void mnu020201010000_Click(object sender, EventArgs e)
        {
            FrmPelayananBPJS frmAnalisaPerDiagnosa = new FrmPelayananBPJS(); // Instantiate a Form object.
            frmAnalisaPerDiagnosa.ShowDialog(); // Show Form and
            frmAnalisaPerDiagnosa.Close();
        }

        private void mnu020202030000_Click(object sender, EventArgs e)
        {
            FrmAnaliasaPerDokter frmAnalisaPerDiagnosa = new FrmAnaliasaPerDokter(); // Instantiate a Form object.
            frmAnalisaPerDiagnosa.ShowDialog(); // Show Form and
            frmAnalisaPerDiagnosa.Close();
        }

        private void mnu020203010000_Click(object sender, EventArgs e)
        {
            FrmVariable1 frmVariable1 = new FrmVariable1();
            frmVariable1.ShowDialog();
            frmVariable1.Close();
        }

        private void mnu020203020000_Click(object sender, EventArgs e)
        {
            FrmVariable2 frmVariable2 = new FrmVariable2();
            frmVariable2.ShowDialog();
            frmVariable2.Close();
        }

        private void mnu020203030000_Click(object sender, EventArgs e)
        {

            FrmVariable3 frmVariable3 = new FrmVariable3();
            frmVariable3.ShowDialog();
            frmVariable3.Close();
        }

        private void mnu020203040000_Click(object sender, EventArgs e)
        {
            FrmVariable4 frmVariable4 = new FrmVariable4();
            frmVariable4.ShowDialog();
            frmVariable4.Close();
        }

        private void mnu020201020000_Click(object sender, EventArgs e)
        {
            FrmRincianBiayaAKPN frmRincianBiayaAKPN = new FrmRincianBiayaAKPN();
            frmRincianBiayaAKPN.ShowDialog();
            frmRincianBiayaAKPN.Close();
        }

        private void mnu020203050000_Click(object sender, EventArgs e)
        {
            FrmVariable5 frmVariable5 = new FrmVariable5();
            frmVariable5.ShowDialog();
            frmVariable5.Close();
        }

        private void mnu020203060000_Click(object sender, EventArgs e)
        {
            FrmVariable6 frmVariable6 = new FrmVariable6();
            frmVariable6.ShowDialog();
            frmVariable6.Close();
        }

        private void mnu020201030000_Click(object sender, EventArgs e)
        {

            FrmRincianJKN frmRincianJKN = new FrmRincianJKN();
            frmRincianJKN.ShowDialog();
            frmRincianJKN.Close();
        }

        private void mnu020203070000_Click(object sender, EventArgs e)
        {

            FrmVariable7 frmVariable7 = new FrmVariable7();
            frmVariable7.ShowDialog();
            frmVariable7.Close();
        }

        private void mnu020203100000_Click(object sender, EventArgs e)
        {
            
        }
    }
}
