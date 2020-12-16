using Microsoft.VisualBasic;
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
using Microsoft.VisualBasic.Devices;
namespace Casemix.Util
{
    public partial class frmCariData : Form
    {
        private string m_strSQL;
        private string[] m_colName;
        private string m_Result;
        private string m_TglAwal;
        private string m_TglAkhir;
        private string m_SortedColName = "";
        private string m_frmSender;
        private byte m_ResultCol = 0;

        public byte ResultCol
        {
            get
            {
                byte ResultColRet = default;
                ResultColRet = m_ResultCol;
                return ResultColRet;
            }

            set
            {
                m_ResultCol = value;
            }
        }

        public string frmSender
        {
            get
            {
                string frmSenderRet = default;
                frmSenderRet = m_frmSender;
                return frmSenderRet;
            }

            set
            {
                m_frmSender = value;
            }
        }

        public string SortedCol
        {
            get
            {
                string SortedColRet = default;
                SortedColRet = m_SortedColName;
                return SortedColRet;
            }

            set
            {
                m_SortedColName = value;
            }
        }

        public string tglAwal
        {
            get
            {
                string tglAwalRet = default;
                tglAwalRet = m_TglAwal;
                return tglAwalRet;
            }

            set
            {
                m_TglAwal = value;
            }
        }

        public string tglAkhir
        {
            get
            {
                string tglAkhirRet = default;
                tglAkhirRet = m_TglAkhir;
                return tglAkhirRet;
            }

            set
            {
                m_TglAkhir = value;
            }
        }

        public string strSQL
        {
            get
            {
                string strSQLRet = default;
                strSQLRet = m_strSQL;
                return strSQLRet;
            }

            set
            {
                m_strSQL = value;
            }
        }

        public Array colName
        {
            get
            {
                Array colNameRet = default;
                colNameRet = m_colName;
                return colNameRet;
            }

            set
            {
                m_colName = (string[])value;
            }
        }

        public string Result
        {
            get
            {
                string ResultRet = default;
                ResultRet = m_Result;
                return ResultRet;
            }

            set
            {
                m_Result = value;
            }
        }

        private void ShowData()
        {
            byte I;
            string vStrSQL;
            try
            {
                switch (this.m_frmSender)
                {
                    case "frmTrsJurnalUmum":
                        {
                            vStrSQL = this.strSQL + " AND (DT_TGLJURNAL BETWEEN '" + ClsUtil.TglYMD(this.txtTglAwal.Text) + "' AND '" + ClsUtil.TglYMD(this.txtTglAkhir.Text) + "') " + " ORDER BY DT_TGLJURNAL, VC_NO_JURNAL";


                            break;
                        }

                    case "frmDaftarOperasi":
                        {
                            vStrSQL = this.strSQL + " AND (Convert(varchar(10),dt_tgl_trans,20) BETWEEN '" + ClsUtil.TglYMD(this.txtTglAwal.Text) + "' AND '" + ClsUtil.TglYMD(this.txtTglAkhir.Text) + "') " + " ORDER BY vc_no_trans ";


                            break;
                        }

                    case "frmTrsBiayaLain":
                        {
                            vStrSQL = this.strSQL + " AND (Convert(varchar(10),dt_tgl_trans,20) BETWEEN '" + ClsUtil.TglYMD(this.txtTglAwal.Text) + "' AND '" + ClsUtil.TglYMD(this.txtTglAkhir.Text) + "') " + " ORDER BY vc_no_bukti ";


                            break;
                        }

                    default:
                        {
                            vStrSQL = this.strSQL;
                            break;
                        }
                }

                this.TampilDataGrid(vStrSQL);
                var loopTo = (byte)Information.UBound(m_colName);
                for (I = 0; I < loopTo; I++)
                {
                    if (m_colName[I] != "")
                    {
                        this.lstItem.Columns[I].HeaderText = m_colName[I];
                    }
                }
            }
            catch (Exception ex)
            {
                MsgBoxUtil.MsgError(ex.Message);
            }
        }
        public void SetTampilanGrid()
        {
            // Deklarasi dan set model baris dari datagridview
            var ObjAlternatingCellStyle = new DataGridViewCellStyle();
            ObjAlternatingCellStyle.BackColor = Color.Gainsboro;
            lstItem.AlternatingRowsDefaultCellStyle = ObjAlternatingCellStyle;
        }


        public frmCariData()
        {
            InitializeComponent();
        }


        private void TampilDataGrid(string xStrSQL)
        {
            DataView ObjDataView;
            var ObjDataAdapter = new SqlDataAdapter(xStrSQL, clMain.DBConn.objConnection);
            var ObjDataSet = new DataSet();
            try
            {
                lstItem.Columns.Clear();
                ObjDataAdapter.Fill(ObjDataSet, "TbAkun");
                ObjDataView = new DataView(ObjDataSet.Tables["TbAkun"]);
                this.lstItem.DataSource = ObjDataView;
                ObjDataAdapter.Dispose();
                ObjDataSet.Dispose();
            }
            catch (Exception ex)
            {
                MsgBoxUtil.MsgError(ex.Message);
            }
            finally
            {
                ObjDataAdapter = default;
                ObjDataSet = default;
            }
        }

        private void frmCariData_Load(object sender, EventArgs e)
        {
            SetTampilanGrid();
            this.txtTglAwal.Text = this.m_TglAwal;
            this.txtTglAkhir.Text = this.m_TglAkhir;
            ShowData();
            this.lstItem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.lstItem.Sort(lstItem.Columns[1], System.ComponentModel.ListSortDirection.Ascending);
            if (this.m_TglAwal != "")
            {
                Panel1.Height = 348;
                Panel1.Top = 65;
                Panel2.Height = 60;
            }
            else
            {
                Panel1.Height = 375;
                Panel1.Top = 38;
                Panel2.Height = 33;
            } // 34

            this.txtCari.Focus();
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            int I;
            if (this.lstItem.SortOrder != System.Windows.Forms.SortOrder.None)
            {
                var loopTo = lstItem.RowCount - 1;
                for (I = lstItem.CurrentRow.Index; I <= loopTo; I++)
                {
                    if ((Strings.LTrim(txtCari.Text.ToUpper()) ?? "") == (Strings.Mid(Strings.LTrim((string)lstItem.Rows[I].Cells[lstItem.SortedColumn.Index].Value).ToUpper(), 1, Strings.LTrim(txtCari.Text).Length) ?? ""));
                    {
                        this.lstItem.CurrentCell = this.lstItem[lstItem.SortedColumn.Index, I];
                        this.lstItem.FirstDisplayedScrollingRowIndex = this.lstItem.Rows[I].Index;
                        break;
                    }
                }
            }
        }

        private void txtCari_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void lstItem_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // m_Result = lstItem.Rows(m_ResultCol, lstItem.CurrentRow.Index).Value;
                m_Result = (string)lstItem.Rows[lstItem.CurrentRow.Index].Cells[m_ResultCol].Value;
                this.Close();
            }
        }

        private void lstItem_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (lstItem.Rows[e.RowIndex].Cells[0].Value.ToString() != "")
                {
                    m_Result = lstItem.Rows[e.RowIndex].Cells[m_ResultCol].Value.ToString();
             
                    this.Close();
                }
            }
        }

        private void txtTglAwal_Validated(object sender, EventArgs e)
        {
            ShowData();
        }

        private void txtTglAkhir_Validated(object sender, EventArgs e)
        {
            ShowData();
        }
    }
}
