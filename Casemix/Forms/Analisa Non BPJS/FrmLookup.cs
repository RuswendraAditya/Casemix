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
        private string _source;

        public FrmLookup()
        {
            InitializeComponent();
           
        }

        public FrmLookup(string source)
        {
            InitializeComponent();
            this._source = source;
            switch (this._source)
            {
                case "Penanggung":

                    gridLookup.DataSource = getDataPenanggung("");
                    break;

                case "Diagnosa":
                    gridLookup.DataSource = getDataICD("");
                    break;
                case "Ruang":
                    gridLookup.DataSource = getRuang("");
                    break;
                default:
                    break;
            }
          
              
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
        private DataTable getDataICD(string param)
        {
            dt = new DataTable();

            string query = @"SELECT vc_kode_icd,vc_nama_icd FROM RMICDKamus  where vc_nama_icd like '%" + param + "%' order by vc_kode_icd asc";
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

        private DataTable getRuang(string param)
        {
            dt = new DataTable();

            string query = @"SELECT VC_k_ruang,VC_n_ruang FROM RMRuang  where VC_n_ruang like '%" + param + "%' order by VC_n_ruang asc";
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
            if (_source == "Penanggung")
            {
                this.DialogResult = DialogResult.OK;
                var selectedItem = this.gridLookup.CurrentItem as DataRowView;
                var dataRow = (selectedItem as DataRowView).Row;
                this.value = dataRow["vc_k_png"].ToString();
                this.texts = dataRow["vc_n_png"].ToString();
            }
            if (_source == "Diagnosa")
            {
                this.DialogResult = DialogResult.OK;
                var selectedItem = this.gridLookup.CurrentItem as DataRowView;
                var dataRow = (selectedItem as DataRowView).Row;
                this.value = dataRow["vc_kode_icd"].ToString();
                this.texts = dataRow["vc_nama_icd"].ToString();
            }
            if (_source == "Ruang")
            {
                this.DialogResult = DialogResult.OK;
                var selectedItem = this.gridLookup.CurrentItem as DataRowView;
                var dataRow = (selectedItem as DataRowView).Row;
                this.value = dataRow["VC_k_ruang"].ToString();
                this.texts = dataRow["VC_n_ruang"].ToString();
            }
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridLookup_AutoGeneratingColumn(object sender, Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnArgs e)
        {
            if (_source == "Penanggung")
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
            if (_source == "Diagnosa")
            {
                if (e.Column.MappingName == "vc_kode_icd")
                {
                    e.Column.HeaderText = "ICD 10";
                    e.Column.Width = 100;
                    e.Column.AllowFiltering = true;

                }
                if (e.Column.MappingName == "vc_nama_icd")
                {
                    e.Column.HeaderText = "Diagnosa";
                    e.Column.Width = 400;
                    e.Column.AllowFiltering = true;

                }
            }

            if (_source == "Ruang")
            {
                if (e.Column.MappingName == "VC_k_ruang")
                {
                    e.Column.HeaderText = "Kode ";
                    e.Column.Width = 100;
                    e.Column.AllowFiltering = true;

                }
                if (e.Column.MappingName == "VC_n_ruang")
                {
                    e.Column.HeaderText = "Ruang";
                    e.Column.Width = 400;
                    e.Column.AllowFiltering = true;

                }
            }
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            switch (this._source)
            {
                case "Penanggung":

                    gridLookup.DataSource = getDataPenanggung(txtCari.Text);
                    break;

                case "Diagnosa":
                    gridLookup.DataSource = getDataICD(txtCari.Text);
                    break;
                case "Ruang":
                    gridLookup.DataSource = getRuang(txtCari.Text);
                    break;
                default:
                    break;
            }
        }
    }
}
