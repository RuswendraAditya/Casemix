namespace Casemix.Forms.Laporan_BPJS
{
    partial class FrmRincianJKN
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
            this.rbTglClose = new System.Windows.Forms.RadioButton();
            this.Label10 = new System.Windows.Forms.Label();
            this.DTAwal = new System.Windows.Forms.DateTimePicker();
            this.DTAkhir = new System.Windows.Forms.DateTimePicker();
            this.Label3 = new System.Windows.Forms.Label();
            this.DTAwalSEP = new System.Windows.Forms.DateTimePicker();
            this.DTAkhirSEP = new System.Windows.Forms.DateTimePicker();
            this.rbTglSEP = new System.Windows.Forms.RadioButton();
            this.Label15 = new System.Windows.Forms.Label();
            this.cmbStatusSEP = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.cmbUmbal = new System.Windows.Forms.ComboBox();
            this.Label17 = new System.Windows.Forms.Label();
            this.cmbTagih = new System.Windows.Forms.ComboBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.chkBoxCOB = new System.Windows.Forms.CheckBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.lblJudul = new System.Windows.Forms.Label();
            this.dgPiutang = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.cmbJenisPel = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgPiutang)).BeginInit();
            this.SuspendLayout();
            // 
            // rbTglClose
            // 
            this.rbTglClose.AutoSize = true;
            this.rbTglClose.Checked = true;
            this.rbTglClose.Location = new System.Drawing.Point(12, 29);
            this.rbTglClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbTglClose.Name = "rbTglClose";
            this.rbTglClose.Size = new System.Drawing.Size(176, 21);
            this.rbTglClose.TabIndex = 355;
            this.rbTglClose.TabStop = true;
            this.rbTglClose.Text = "Tanggal Pulang Pasien";
            this.rbTglClose.UseVisualStyleBackColor = true;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(343, 33);
            this.Label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(27, 17);
            this.Label10.TabIndex = 354;
            this.Label10.Text = "s/d";
            // 
            // DTAwal
            // 
            this.DTAwal.CustomFormat = "dd/MM/yyyy";
            this.DTAwal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTAwal.Location = new System.Drawing.Point(199, 29);
            this.DTAwal.Margin = new System.Windows.Forms.Padding(4);
            this.DTAwal.Name = "DTAwal";
            this.DTAwal.Size = new System.Drawing.Size(135, 22);
            this.DTAwal.TabIndex = 353;
            // 
            // DTAkhir
            // 
            this.DTAkhir.CustomFormat = "dd/MM/yyyy";
            this.DTAkhir.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTAkhir.Location = new System.Drawing.Point(383, 29);
            this.DTAkhir.Margin = new System.Windows.Forms.Padding(4);
            this.DTAkhir.Name = "DTAkhir";
            this.DTAkhir.Size = new System.Drawing.Size(135, 22);
            this.DTAkhir.TabIndex = 352;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(343, 62);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(27, 17);
            this.Label3.TabIndex = 359;
            this.Label3.Text = "s/d";
            // 
            // DTAwalSEP
            // 
            this.DTAwalSEP.CustomFormat = "dd/MM/yyyy";
            this.DTAwalSEP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTAwalSEP.Location = new System.Drawing.Point(199, 57);
            this.DTAwalSEP.Margin = new System.Windows.Forms.Padding(4);
            this.DTAwalSEP.Name = "DTAwalSEP";
            this.DTAwalSEP.Size = new System.Drawing.Size(135, 22);
            this.DTAwalSEP.TabIndex = 358;
            // 
            // DTAkhirSEP
            // 
            this.DTAkhirSEP.CustomFormat = "dd/MM/yyyy";
            this.DTAkhirSEP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTAkhirSEP.Location = new System.Drawing.Point(383, 57);
            this.DTAkhirSEP.Margin = new System.Windows.Forms.Padding(4);
            this.DTAkhirSEP.Name = "DTAkhirSEP";
            this.DTAkhirSEP.Size = new System.Drawing.Size(135, 22);
            this.DTAkhirSEP.TabIndex = 357;
            // 
            // rbTglSEP
            // 
            this.rbTglSEP.AutoSize = true;
            this.rbTglSEP.Location = new System.Drawing.Point(12, 54);
            this.rbTglSEP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbTglSEP.Name = "rbTglSEP";
            this.rbTglSEP.Size = new System.Drawing.Size(112, 21);
            this.rbTglSEP.TabIndex = 356;
            this.rbTglSEP.Text = "Tanggal SEP";
            this.rbTglSEP.UseVisualStyleBackColor = true;
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Arial", 9F);
            this.Label15.Location = new System.Drawing.Point(12, 87);
            this.Label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(76, 17);
            this.Label15.TabIndex = 365;
            this.Label15.Text = "Pelayanan";
            // 
            // cmbStatusSEP
            // 
            this.cmbStatusSEP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusSEP.FormattingEnabled = true;
            this.cmbStatusSEP.Location = new System.Drawing.Point(198, 123);
            this.cmbStatusSEP.Margin = new System.Windows.Forms.Padding(4);
            this.cmbStatusSEP.Name = "cmbStatusSEP";
            this.cmbStatusSEP.Size = new System.Drawing.Size(388, 24);
            this.cmbStatusSEP.TabIndex = 368;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Arial", 9F);
            this.Label1.Location = new System.Drawing.Point(12, 123);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(139, 17);
            this.Label1.TabIndex = 367;
            this.Label1.Text = "Status SEP Terakhir";
            // 
            // cmbUmbal
            // 
            this.cmbUmbal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUmbal.FormattingEnabled = true;
            this.cmbUmbal.Items.AddRange(new object[] {
            "",
            "Belum Input Umbal",
            "Sudah Input Umbal"});
            this.cmbUmbal.Location = new System.Drawing.Point(199, 198);
            this.cmbUmbal.Margin = new System.Windows.Forms.Padding(4);
            this.cmbUmbal.Name = "cmbUmbal";
            this.cmbUmbal.Size = new System.Drawing.Size(388, 24);
            this.cmbUmbal.TabIndex = 370;
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Font = new System.Drawing.Font("Arial", 9F);
            this.Label17.Location = new System.Drawing.Point(12, 200);
            this.Label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(96, 17);
            this.Label17.TabIndex = 369;
            this.Label17.Text = "Status Umbal";
            // 
            // cmbTagih
            // 
            this.cmbTagih.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTagih.FormattingEnabled = true;
            this.cmbTagih.Items.AddRange(new object[] {
            "",
            "Sudah Diajukan",
            "Belum Diajukan"});
            this.cmbTagih.Location = new System.Drawing.Point(198, 158);
            this.cmbTagih.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTagih.Name = "cmbTagih";
            this.cmbTagih.Size = new System.Drawing.Size(388, 24);
            this.cmbTagih.TabIndex = 372;
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Arial", 9F);
            this.Label14.Location = new System.Drawing.Point(12, 158);
            this.Label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(123, 17);
            this.Label14.TabIndex = 371;
            this.Label14.Text = "Status Pengajuan";
            // 
            // chkBoxCOB
            // 
            this.chkBoxCOB.AutoSize = true;
            this.chkBoxCOB.Location = new System.Drawing.Point(199, 228);
            this.chkBoxCOB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkBoxCOB.Name = "chkBoxCOB";
            this.chkBoxCOB.Size = new System.Drawing.Size(92, 21);
            this.chkBoxCOB.TabIndex = 373;
            this.chkBoxCOB.Text = "COB Only";
            this.chkBoxCOB.UseVisualStyleBackColor = true;
            // 
            // Button1
            // 
            this.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button1.Location = new System.Drawing.Point(595, 195);
            this.Button1.Margin = new System.Windows.Forms.Padding(4);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(100, 28);
            this.Button1.TabIndex = 374;
            this.Button1.Text = "Cari";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lblJudul
            // 
            this.lblJudul.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.Location = new System.Drawing.Point(814, 239);
            this.lblJudul.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(319, 23);
            this.lblJudul.TabIndex = 375;
            this.lblJudul.Text = "Laporan Rincian Piutang JKN";
            this.lblJudul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgPiutang
            // 
            this.dgPiutang.AccessibleName = "Table";
            this.dgPiutang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgPiutang.Location = new System.Drawing.Point(12, 275);
            this.dgPiutang.Name = "dgPiutang";
            this.dgPiutang.PreviewRowHeight = 35;
            this.dgPiutang.Size = new System.Drawing.Size(1803, 332);
            this.dgPiutang.TabIndex = 376;
            this.dgPiutang.Text = "sfDataGrid1";
            // 
            // cmbJenisPel
            // 
            this.cmbJenisPel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJenisPel.FormattingEnabled = true;
            this.cmbJenisPel.Location = new System.Drawing.Point(199, 91);
            this.cmbJenisPel.Margin = new System.Windows.Forms.Padding(4);
            this.cmbJenisPel.Name = "cmbJenisPel";
            this.cmbJenisPel.Size = new System.Drawing.Size(388, 24);
            this.cmbJenisPel.TabIndex = 377;
            this.cmbJenisPel.SelectedIndexChanged += new System.EventHandler(this.cmbJenisPel_SelectedIndexChanged);
            // 
            // FrmRincianJKN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1827, 672);
            this.Controls.Add(this.cmbJenisPel);
            this.Controls.Add(this.dgPiutang);
            this.Controls.Add(this.lblJudul);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.chkBoxCOB);
            this.Controls.Add(this.cmbTagih);
            this.Controls.Add(this.Label14);
            this.Controls.Add(this.cmbUmbal);
            this.Controls.Add(this.Label17);
            this.Controls.Add(this.cmbStatusSEP);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label15);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.DTAwalSEP);
            this.Controls.Add(this.DTAkhirSEP);
            this.Controls.Add(this.rbTglSEP);
            this.Controls.Add(this.rbTglClose);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.DTAwal);
            this.Controls.Add(this.DTAkhir);
            this.Name = "FrmRincianJKN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laporan Rincian JKN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmRincianJKN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPiutang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.RadioButton rbTglClose;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.DateTimePicker DTAwal;
        internal System.Windows.Forms.DateTimePicker DTAkhir;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.DateTimePicker DTAwalSEP;
        internal System.Windows.Forms.DateTimePicker DTAkhirSEP;
        internal System.Windows.Forms.RadioButton rbTglSEP;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.ComboBox cmbStatusSEP;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox cmbUmbal;
        internal System.Windows.Forms.Label Label17;
        internal System.Windows.Forms.ComboBox cmbTagih;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.CheckBox chkBoxCOB;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Label lblJudul;
        private Syncfusion.WinForms.DataGrid.SfDataGrid dgPiutang;
        internal System.Windows.Forms.ComboBox cmbJenisPel;
    }
}