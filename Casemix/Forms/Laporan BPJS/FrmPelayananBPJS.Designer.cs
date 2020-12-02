namespace Casemix.Forms.Analisa_BPJS
{
    partial class FrmPelayananBPJS
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
            this.label3 = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoad = new Syncfusion.WinForms.Controls.SfButton();
            this.pbLoading = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            this.btnExportExcel = new Syncfusion.WinForms.Controls.SfButton();
            this.dgPiutang = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.cmbJenisPel = new Syncfusion.WinForms.ListView.SfComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalPiutangRS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalGrouper = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalSelisih = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPiutang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbJenisPel)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Jenis Pelayanan";
            // 
            // dtFrom
            // 
            this.dtFrom.CustomFormat = "dd/MM/yyyy";
            this.dtFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.Location = new System.Drawing.Point(167, 28);
            this.dtFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(143, 27);
            this.dtFrom.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Tanggal SEP";
            // 
            // btnLoad
            // 
            this.btnLoad.AccessibleName = "Button";
            this.btnLoad.BackColor = System.Drawing.Color.Bisque;
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnLoad.Location = new System.Drawing.Point(531, 72);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(112, 32);
            this.btnLoad.Style.BackColor = System.Drawing.Color.Bisque;
            this.btnLoad.TabIndex = 33;
            this.btnLoad.Text = "Generate";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // pbLoading
            // 
            this.pbLoading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbLoading.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.Office2016Colorful;
            this.pbLoading.BackMultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.pbLoading.BackSegments = false;
            this.pbLoading.CustomText = null;
            this.pbLoading.CustomWaitingRender = false;
            this.pbLoading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pbLoading.ForegroundImage = null;
            this.pbLoading.Location = new System.Drawing.Point(584, 395);
            this.pbLoading.MultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.SegmentWidth = 12;
            this.pbLoading.Size = new System.Drawing.Size(400, 23);
            this.pbLoading.TabIndex = 35;
            this.pbLoading.Text = "Loading ...";
            this.pbLoading.Value = 10;
            this.pbLoading.Visible = false;
            this.pbLoading.WaitingGradientWidth = 400;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.AccessibleName = "Button";
            this.btnExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportExcel.BackColor = System.Drawing.Color.Lavender;
            this.btnExportExcel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnExportExcel.Location = new System.Drawing.Point(1422, 548);
            this.btnExportExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(128, 34);
            this.btnExportExcel.Style.BackColor = System.Drawing.Color.Lavender;
            this.btnExportExcel.Style.Image = global::Casemix.Properties.Resources.excel;
            this.btnExportExcel.TabIndex = 36;
            this.btnExportExcel.Text = "Excel";
            this.btnExportExcel.UseVisualStyleBackColor = false;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // dgPiutang
            // 
            this.dgPiutang.AccessibleName = "Table";
            this.dgPiutang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgPiutang.Location = new System.Drawing.Point(16, 162);
            this.dgPiutang.Name = "dgPiutang";
            this.dgPiutang.PreviewRowHeight = 35;
            this.dgPiutang.Size = new System.Drawing.Size(1535, 368);
            this.dgPiutang.TabIndex = 37;
            this.dgPiutang.Text = "sfDataGrid1";
            this.dgPiutang.AutoGeneratingColumn += new Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnEventHandler(this.dgPiutang_AutoGeneratingColumn);
            this.dgPiutang.FilterChanged += new Syncfusion.WinForms.DataGrid.Events.FilterChangedEventHandler(this.dgPiutang_FilterChanged);
            // 
            // cmbJenisPel
            // 
            this.cmbJenisPel.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cmbJenisPel.Location = new System.Drawing.Point(167, 72);
            this.cmbJenisPel.Name = "cmbJenisPel";
            this.cmbJenisPel.Size = new System.Drawing.Size(337, 32);
            this.cmbJenisPel.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbJenisPel.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(814, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(303, 25);
            this.label4.TabIndex = 39;
            this.label4.Text = "Monitoring Data Pelayanan BPJS";
            // 
            // txtTotalPiutangRS
            // 
            this.txtTotalPiutangRS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalPiutangRS.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtTotalPiutangRS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPiutangRS.Location = new System.Drawing.Point(878, 560);
            this.txtTotalPiutangRS.Name = "txtTotalPiutangRS";
            this.txtTotalPiutangRS.Size = new System.Drawing.Size(160, 24);
            this.txtTotalPiutangRS.TabIndex = 40;
            this.txtTotalPiutangRS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(919, 537);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 18);
            this.label5.TabIndex = 41;
            this.label5.Text = "Piutang RS";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1108, 537);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 18);
            this.label6.TabIndex = 42;
            this.label6.Text = "Grouper";
            // 
            // txtTotalGrouper
            // 
            this.txtTotalGrouper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalGrouper.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtTotalGrouper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalGrouper.Location = new System.Drawing.Point(1059, 560);
            this.txtTotalGrouper.Name = "txtTotalGrouper";
            this.txtTotalGrouper.Size = new System.Drawing.Size(160, 24);
            this.txtTotalGrouper.TabIndex = 43;
            this.txtTotalGrouper.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1293, 537);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 18);
            this.label7.TabIndex = 44;
            this.label7.Text = "Selisih";
            // 
            // txtTotalSelisih
            // 
            this.txtTotalSelisih.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalSelisih.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtTotalSelisih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalSelisih.Location = new System.Drawing.Point(1242, 560);
            this.txtTotalSelisih.Name = "txtTotalSelisih";
            this.txtTotalSelisih.Size = new System.Drawing.Size(160, 24);
            this.txtTotalSelisih.TabIndex = 45;
            this.txtTotalSelisih.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(13, 548);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(607, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "* Data Yang tampil adalah pasien yang sudah close AKPRJ / Dipulangkan AKPN";
            // 
            // FrmPelayananBPJS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1563, 637);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotalSelisih);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTotalGrouper);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTotalPiutangRS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbJenisPel);
            this.Controls.Add(this.pbLoading);
            this.Controls.Add(this.dgPiutang);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FrmPelayananBPJS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "x";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPelayananBPJS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPiutang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbJenisPel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label1;
        private Syncfusion.WinForms.Controls.SfButton btnLoad;
        private Syncfusion.Windows.Forms.Tools.ProgressBarAdv pbLoading;
        private Syncfusion.WinForms.Controls.SfButton btnExportExcel;
        private Syncfusion.WinForms.DataGrid.SfDataGrid dgPiutang;
        private Syncfusion.WinForms.ListView.SfComboBox cmbJenisPel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalPiutangRS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalGrouper;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotalSelisih;
        private System.Windows.Forms.Label label2;
    }
}