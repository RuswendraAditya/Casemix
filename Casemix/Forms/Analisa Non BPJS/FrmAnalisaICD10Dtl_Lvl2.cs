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

namespace Casemix.Forms.Analisa_Non_BPJS
{
    public partial class FrmAnalisaICD10Dtl_Lvl2 : Form
    {
        public FrmAnalisaICD10Dtl_Lvl2(string noReg,string noRM,string namaPasien)
        {
            InitializeComponent();
            txtNamPasien.Text = namaPasien;
            txtNoReg.Text = noReg;
            txtNoRM.Text = noRM;
			dgPiutang.DataSource = getDataDiagnosaSekunder(noReg);
			dgPiutang.Columns[0].Width = 90;
			dgPiutang.Columns[1].Width = 350;
		}

		private DataTable getDataDiagnosaSekunder(string noReg)
		{
			DataTable dt = new DataTable();
			string query = @"SELECT kamus.vc_kode_icd Icd10,kamus.vc_nama_icd Diagnosa 
								FROM RMICDSekunderRanap ranap INNER JOIN RMIcdKamus kamus
								on kamus.vc_kode_icd = ranap.vc_kode_icd
								where vc_no_reg = @noReg";
			
			using (SqlCommand cmd = new SqlCommand(query, clMain.DBConn.objConnection))
			{
				cmd.Parameters.AddWithValue("@noReg", noReg);

				using (SqlDataAdapter da = new SqlDataAdapter(cmd))
				{
					da.Fill(dt);
				}
			}

			return dt;

		}

        private void FrmAnalisaICD10Dtl_Lvl2_Load(object sender, EventArgs e)
        {

        }
    }
}
