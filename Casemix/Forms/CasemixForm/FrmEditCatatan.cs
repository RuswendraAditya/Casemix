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

namespace Casemix.Forms.CasemixForm
{
    public partial class FrmEditCatatan : Form
    {
        private int _id;
        public FrmEditCatatan()
        {
            InitializeComponent();
        }
        public FrmEditCatatan(int id,string catatan)
        {
            InitializeComponent();
            _id = id;
            txtCatatan.Text = catatan;
        }
        private void btnSIMPAN_Click(object sender, EventArgs e)
        {
            UpdateData(_id, txtCatatan.Text);

        }

        private void UpdateData(int id, string catatan)
        {
            try
            {



                string query = @"UPDATE [dbo].[CASEMIX_Form_B_Catatan]
                               SET [vc_catatan] = @vc_catatan
                                  ,[vc_last_update_by] =@vc_last_update_by
                             WHERE in_auto = @in_auto";
                ;
                SqlCommand cmd = new SqlCommand(query, clMain.DBConn.objConnection);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@in_auto", id);
                cmd.Parameters.AddWithValue("@vc_catatan", catatan);
             

                cmd.Parameters.AddWithValue("@vc_last_update_by", clMain.cUserLogIn);
                cmd.ExecuteNonQuery();
                
                MsgBoxUtil.MsgInfo("Update Catatan Berhasil Disimpan");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {

                MsgBoxUtil.MsgError(ex.Message);

            }
        }

        private void FrmEditCatatan_Load(object sender, EventArgs e)
        {

        }
    }
}
