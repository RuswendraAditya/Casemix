
namespace Casemix.Forms.Laporan_BPJS
{
    partial class FrmMonitoringSEP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgPiutang = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.Label3 = new System.Windows.Forms.Label();
            this.DTAwalSEP = new System.Windows.Forms.DateTimePicker();
            this.DTAkhirSEP = new System.Windows.Forms.DateTimePicker();
            this.Label17 = new System.Windows.Forms.Label();
            this.gridSummary = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStatusSEP = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCari = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgPiutang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSummary)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPiutang
            // 
            this.dgPiutang.AccessibleName = "Table";
            this.dgPiutang.AllowEditing = false;
            this.dgPiutang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgPiutang.Location = new System.Drawing.Point(16, 92);
            this.dgPiutang.Name = "dgPiutang";
            this.dgPiutang.PreviewRowHeight = 35;
            this.dgPiutang.Size = new System.Drawing.Size(1376, 719);
            this.dgPiutang.TabIndex = 377;
            this.dgPiutang.Text = "sfDataGrid1";
            this.dgPiutang.AutoGeneratingColumn += new Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnEventHandler(this.dgPiutang_AutoGeneratingColumn);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(342, 21);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(27, 17);
            this.Label3.TabIndex = 380;
            this.Label3.Text = "s/d";
            // 
            // DTAwalSEP
            // 
            this.DTAwalSEP.CustomFormat = "dd/MM/yyyy";
            this.DTAwalSEP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTAwalSEP.Location = new System.Drawing.Point(199, 21);
            this.DTAwalSEP.Margin = new System.Windows.Forms.Padding(4);
            this.DTAwalSEP.Name = "DTAwalSEP";
            this.DTAwalSEP.Size = new System.Drawing.Size(135, 22);
            this.DTAwalSEP.TabIndex = 379;
            // 
            // DTAkhirSEP
            // 
            this.DTAkhirSEP.CustomFormat = "dd/MM/yyyy";
            this.DTAkhirSEP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTAkhirSEP.Location = new System.Drawing.Point(383, 21);
            this.DTAkhirSEP.Margin = new System.Windows.Forms.Padding(4);
            this.DTAkhirSEP.Name = "DTAkhirSEP";
            this.DTAkhirSEP.Size = new System.Drawing.Size(135, 22);
            this.DTAkhirSEP.TabIndex = 378;
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Font = new System.Drawing.Font("Arial", 9F);
            this.Label17.Location = new System.Drawing.Point(13, 26);
            this.Label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(62, 17);
            this.Label17.TabIndex = 381;
            this.Label17.Text = "Tgl SEP";
            // 
            // gridSummary
            // 
            this.gridSummary.AccessibleName = "Table";
            this.gridSummary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridSummary.Location = new System.Drawing.Point(1398, 92);
            this.gridSummary.Name = "gridSummary";
            this.gridSummary.PreviewRowHeight = 35;
            this.gridSummary.Size = new System.Drawing.Size(488, 356);
            this.gridSummary.TabIndex = 382;
            this.gridSummary.Text = "sfDataGrid1";
            this.gridSummary.AutoGeneratingColumn += new Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnEventHandler(this.gridSummary_AutoGeneratingColumn);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1393, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 27);
            this.label1.TabIndex = 383;
            this.label1.Text = "Summary Status";
            // 
            // cmbStatusSEP
            // 
            this.cmbStatusSEP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusSEP.FormattingEnabled = true;
            this.cmbStatusSEP.Location = new System.Drawing.Point(199, 53);
            this.cmbStatusSEP.Margin = new System.Windows.Forms.Padding(4);
            this.cmbStatusSEP.Name = "cmbStatusSEP";
            this.cmbStatusSEP.Size = new System.Drawing.Size(388, 24);
            this.cmbStatusSEP.TabIndex = 385;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F);
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 384;
            this.label2.Text = "Status SEP Terakhir";
            // 
            // btnCari
            // 
            this.btnCari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCari.Location = new System.Drawing.Point(595, 49);
            this.btnCari.Margin = new System.Windows.Forms.Padding(4);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(100, 28);
            this.btnCari.TabIndex = 386;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label5.Location = new System.Drawing.Point(1162, 818);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 25);
            this.label5.TabIndex = 387;
            this.label5.Text = "Total SEP : ";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblTotal.Location = new System.Drawing.Point(1269, 818);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(23, 25);
            this.lblTotal.TabIndex = 388;
            this.lblTotal.Text = "0";
            // 
            // FrmMonitoringSEP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1924, 852);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.cmbStatusSEP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridSummary);
            this.Controls.Add(this.Label17);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.DTAwalSEP);
            this.Controls.Add(this.DTAkhirSEP);
            this.Controls.Add(this.dgPiutang);
            this.Name = "FrmMonitoringSEP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMonitoringSEP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMonitoringSEP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPiutang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSummary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.WinForms.DataGrid.SfDataGrid dgPiutang;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.DateTimePicker DTAwalSEP;
        internal System.Windows.Forms.DateTimePicker DTAkhirSEP;
        internal System.Windows.Forms.Label Label17;
        private Syncfusion.WinForms.DataGrid.SfDataGrid gridSummary;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.ComboBox cmbStatusSEP;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotal;
    }
}