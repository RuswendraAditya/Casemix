using Casemix.Forms.Analisa_BPJS;
using System;
using System.Windows.Forms;



namespace Casemix
{
    public partial class MainForm : Form
    {




        private void Form1_Load(object sender, EventArgs e)
        {
            //clMain.ReadValuesINIFiles();

            //long openCOnnection = clMain.DBConn.DBOpenConnection();
            //if (openCOnnection != 0)
            //{
            //    MsgBoxUtil.MsgError("Gagal Akses Database");
            //    this.Close();
            //}



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
    }
}
