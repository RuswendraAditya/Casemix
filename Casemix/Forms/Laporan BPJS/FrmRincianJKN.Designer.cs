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
            this.Label13 = new System.Windows.Forms.Label();
            this.txtTotalSaldo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSatuEpisode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalUnklaim = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalSelisih = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalUmbal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalGrouper = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotalPiutangRS = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotalCOB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotalPotongan = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTotalIuranPasien = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTotalBiayaRS = new System.Windows.Forms.TextBox();
            this.btnExportExcel = new Syncfusion.WinForms.Controls.SfButton();
            this.label18 = new System.Windows.Forms.Label();
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
            this.dgPiutang.Size = new System.Drawing.Size(1688, 332);
            this.dgPiutang.TabIndex = 376;
            this.dgPiutang.Text = "sfDataGrid1";
            this.dgPiutang.AutoGeneratingColumn += new Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnEventHandler(this.dgPiutang_AutoGeneratingColumn);
            this.dgPiutang.DrawCell += new Syncfusion.WinForms.DataGrid.Events.DrawCellEventHandler(this.dgPiutang_DrawCell);
            this.dgPiutang.FilterChanged += new Syncfusion.WinForms.DataGrid.Events.FilterChangedEventHandler(this.dgPiutang_FilterChanged);
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
            // Label13
            // 
            this.Label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.ForeColor = System.Drawing.Color.DarkRed;
            this.Label13.Location = new System.Drawing.Point(1462, 610);
            this.Label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(46, 18);
            this.Label13.TabIndex = 379;
            this.Label13.Text = "Saldo";
            // 
            // txtTotalSaldo
            // 
            this.txtTotalSaldo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalSaldo.Location = new System.Drawing.Point(1420, 633);
            this.txtTotalSaldo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalSaldo.Name = "txtTotalSaldo";
            this.txtTotalSaldo.ReadOnly = true;
            this.txtTotalSaldo.Size = new System.Drawing.Size(139, 24);
            this.txtTotalSaldo.TabIndex = 378;
            this.txtTotalSaldo.TabStop = false;
            this.txtTotalSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(1288, 610);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 381;
            this.label2.Text = "Satu Episode";
            // 
            // txtSatuEpisode
            // 
            this.txtSatuEpisode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSatuEpisode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSatuEpisode.Location = new System.Drawing.Point(1271, 633);
            this.txtSatuEpisode.Margin = new System.Windows.Forms.Padding(4);
            this.txtSatuEpisode.Name = "txtSatuEpisode";
            this.txtSatuEpisode.ReadOnly = true;
            this.txtSatuEpisode.Size = new System.Drawing.Size(139, 24);
            this.txtSatuEpisode.TabIndex = 380;
            this.txtSatuEpisode.TabStop = false;
            this.txtSatuEpisode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(1154, 610);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 383;
            this.label4.Text = "Unklaim";
            // 
            // txtTotalUnklaim
            // 
            this.txtTotalUnklaim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalUnklaim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalUnklaim.Location = new System.Drawing.Point(1124, 633);
            this.txtTotalUnklaim.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalUnklaim.Name = "txtTotalUnklaim";
            this.txtTotalUnklaim.ReadOnly = true;
            this.txtTotalUnklaim.Size = new System.Drawing.Size(139, 24);
            this.txtTotalUnklaim.TabIndex = 382;
            this.txtTotalUnklaim.TabStop = false;
            this.txtTotalUnklaim.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(1005, 610);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 18);
            this.label5.TabIndex = 385;
            this.label5.Text = "Selisih";
            // 
            // txtTotalSelisih
            // 
            this.txtTotalSelisih.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalSelisih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalSelisih.Location = new System.Drawing.Point(975, 633);
            this.txtTotalSelisih.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalSelisih.Name = "txtTotalSelisih";
            this.txtTotalSelisih.ReadOnly = true;
            this.txtTotalSelisih.Size = new System.Drawing.Size(139, 24);
            this.txtTotalSelisih.TabIndex = 384;
            this.txtTotalSelisih.TabStop = false;
            this.txtTotalSelisih.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(851, 610);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 18);
            this.label6.TabIndex = 387;
            this.label6.Text = "Umbal";
            // 
            // txtTotalUmbal
            // 
            this.txtTotalUmbal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalUmbal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalUmbal.Location = new System.Drawing.Point(821, 633);
            this.txtTotalUmbal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalUmbal.Name = "txtTotalUmbal";
            this.txtTotalUmbal.ReadOnly = true;
            this.txtTotalUmbal.Size = new System.Drawing.Size(139, 24);
            this.txtTotalUmbal.TabIndex = 386;
            this.txtTotalUmbal.TabStop = false;
            this.txtTotalUmbal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(700, 610);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 18);
            this.label7.TabIndex = 389;
            this.label7.Text = "Grouper";
            // 
            // txtTotalGrouper
            // 
            this.txtTotalGrouper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalGrouper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalGrouper.Location = new System.Drawing.Point(670, 633);
            this.txtTotalGrouper.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalGrouper.Name = "txtTotalGrouper";
            this.txtTotalGrouper.ReadOnly = true;
            this.txtTotalGrouper.Size = new System.Drawing.Size(139, 24);
            this.txtTotalGrouper.TabIndex = 388;
            this.txtTotalGrouper.TabStop = false;
            this.txtTotalGrouper.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(546, 610);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 18);
            this.label8.TabIndex = 391;
            this.label8.Text = "Piutang RS";
            // 
            // txtTotalPiutangRS
            // 
            this.txtTotalPiutangRS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalPiutangRS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPiutangRS.Location = new System.Drawing.Point(516, 633);
            this.txtTotalPiutangRS.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalPiutangRS.Name = "txtTotalPiutangRS";
            this.txtTotalPiutangRS.ReadOnly = true;
            this.txtTotalPiutangRS.Size = new System.Drawing.Size(139, 24);
            this.txtTotalPiutangRS.TabIndex = 390;
            this.txtTotalPiutangRS.TabStop = false;
            this.txtTotalPiutangRS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(392, 610);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 18);
            this.label9.TabIndex = 393;
            this.label9.Text = "COB";
            // 
            // txtTotalCOB
            // 
            this.txtTotalCOB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalCOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCOB.Location = new System.Drawing.Point(362, 633);
            this.txtTotalCOB.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalCOB.Name = "txtTotalCOB";
            this.txtTotalCOB.ReadOnly = true;
            this.txtTotalCOB.Size = new System.Drawing.Size(139, 24);
            this.txtTotalCOB.TabIndex = 392;
            this.txtTotalCOB.TabStop = false;
            this.txtTotalCOB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkRed;
            this.label11.Location = new System.Drawing.Point(240, 610);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 18);
            this.label11.TabIndex = 395;
            this.label11.Text = "Potongan";
            // 
            // txtTotalPotongan
            // 
            this.txtTotalPotongan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalPotongan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPotongan.Location = new System.Drawing.Point(210, 633);
            this.txtTotalPotongan.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalPotongan.Name = "txtTotalPotongan";
            this.txtTotalPotongan.ReadOnly = true;
            this.txtTotalPotongan.Size = new System.Drawing.Size(139, 24);
            this.txtTotalPotongan.TabIndex = 394;
            this.txtTotalPotongan.TabStop = false;
            this.txtTotalPotongan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkRed;
            this.label12.Location = new System.Drawing.Point(91, 610);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 18);
            this.label12.TabIndex = 397;
            this.label12.Text = "Iur Pasien";
            // 
            // txtTotalIuranPasien
            // 
            this.txtTotalIuranPasien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalIuranPasien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalIuranPasien.Location = new System.Drawing.Point(61, 633);
            this.txtTotalIuranPasien.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalIuranPasien.Name = "txtTotalIuranPasien";
            this.txtTotalIuranPasien.ReadOnly = true;
            this.txtTotalIuranPasien.Size = new System.Drawing.Size(139, 24);
            this.txtTotalIuranPasien.TabIndex = 396;
            this.txtTotalIuranPasien.TabStop = false;
            this.txtTotalIuranPasien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label16
            // 
            this.label16.AllowDrop = true;
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.DarkRed;
            this.label16.Location = new System.Drawing.Point(-60, 610);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 18);
            this.label16.TabIndex = 399;
            this.label16.Text = "Biaya RS";
            // 
            // txtTotalBiayaRS
            // 
            this.txtTotalBiayaRS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalBiayaRS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalBiayaRS.Location = new System.Drawing.Point(-90, 633);
            this.txtTotalBiayaRS.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalBiayaRS.Name = "txtTotalBiayaRS";
            this.txtTotalBiayaRS.ReadOnly = true;
            this.txtTotalBiayaRS.Size = new System.Drawing.Size(139, 24);
            this.txtTotalBiayaRS.TabIndex = 398;
            this.txtTotalBiayaRS.TabStop = false;
            this.txtTotalBiayaRS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.AccessibleName = "Button";
            this.btnExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportExcel.BackColor = System.Drawing.Color.Lavender;
            this.btnExportExcel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnExportExcel.Location = new System.Drawing.Point(1571, 623);
            this.btnExportExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(128, 34);
            this.btnExportExcel.Style.BackColor = System.Drawing.Color.Lavender;
            this.btnExportExcel.Style.Image = global::Casemix.Properties.Resources.excel;
            this.btnExportExcel.TabIndex = 400;
            this.btnExportExcel.Text = "Excel";
            this.btnExportExcel.UseVisualStyleBackColor = false;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(12, 252);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(607, 20);
            this.label18.TabIndex = 401;
            this.label18.Text = "* Data Yang tampil adalah pasien yang sudah close AKPRJ / Dipulangkan AKPN";
            // 
            // FrmRincianJKN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1712, 672);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtTotalBiayaRS);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtTotalIuranPasien);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTotalPotongan);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTotalCOB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTotalPiutangRS);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTotalGrouper);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTotalUmbal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTotalSelisih);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTotalUnklaim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSatuEpisode);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.txtTotalSaldo);
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
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.TextBox txtTotalSaldo;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtSatuEpisode;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox txtTotalUnklaim;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox txtTotalSelisih;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox txtTotalUmbal;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox txtTotalGrouper;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.TextBox txtTotalPiutangRS;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.TextBox txtTotalCOB;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.TextBox txtTotalPotongan;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.TextBox txtTotalIuranPasien;
        internal System.Windows.Forms.Label label16;
        internal System.Windows.Forms.TextBox txtTotalBiayaRS;
        private Syncfusion.WinForms.Controls.SfButton btnExportExcel;
        private System.Windows.Forms.Label label18;
    }
}