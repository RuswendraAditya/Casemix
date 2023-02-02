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
    public partial class FrmLookup : Form
    {
        public string value { get; set; }
        public string texts { get; set; }
        DataTable dt;
        public FrmLookup()
        {
            InitializeComponent();
            gridLookup.DataSource = getDataPenanggung("");
        }

        private DataTable getDataPenanggung(string param)
        {
            dt = new DataTable();

            string query = @"SELECT vc_k_png,vc_n_png from pubPng where vc_n_png like '%" + param + "%'  order by vc_n_png asc";
            using (SqlCommand cmd = new SqlCommand(query, clMain.DBConn.objConnection))
            {

                cmd.CommandTimeout = 0;
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }


            return dt;
        }

        private void FrmLookup_Load(object sender, EventArgs e)
        {
         
        }

        private void btnPilih_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            var selectedItem = this.gridLookup.CurrentItem as DataRowView;
            var dataRow = (selectedItem as DataRowView).Row;
            this.value = dataRow["vc_k_png"].ToString();
            this.texts = dataRow["vc_n_png"].ToString();
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridLookup_AutoGeneratingColumn(object sender, Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnArgs e)
        {

            if (e.Column.MappingName == "vc_k_png")
            {
                e.Column.HeaderText = "Kode Penanggung";
                e.Column.Width = 100;
                e.Column.AllowFiltering = true;

            }
            if (e.Column.MappingName == "vc_n_png")
            {
                e.Column.HeaderText = "Nama Penanggung";
                e.Column.Width = 400;
                e.Column.AllowFiltering = true;

            }
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            gridLookup.DataSource = getDataPenanggung(txtCari.Text);
        }
    }
}
