namespace Casemix.Forms.Analisa_BPJS
{
    partial class FrmAnalisaPerCoding
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
            this.components = new System.ComponentModel.Container();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.btnLoad = new Syncfusion.WinForms.Controls.SfButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pivotGridControl1 = new Syncfusion.Windows.Forms.PivotAnalysis.PivotGridControl(this.components);
            this.btnExportPdf = new Syncfusion.WinForms.Controls.SfButton();
            this.btnExportWord = new Syncfusion.WinForms.Controls.SfButton();
            this.btnExportExcel = new Syncfusion.WinForms.Controls.SfButton();
            this.cmbExportXls = new Syncfusion.WinForms.ListView.SfComboBox();
            this.chkBoxSort = new System.Windows.Forms.CheckBox();
            this.cmbJenisPel = new Syncfusion.WinForms.ListView.SfComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbExportXls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbJenisPel)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // btnLoad
            // 
            this.btnLoad.AccessibleName = "Button";
            this.btnLoad.BackColor = System.Drawing.Color.Bisque;
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnLoad.Location = new System.Drawing.Point(285, 98);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(112, 32);
            this.btnLoad.Style.BackColor = System.Drawing.Color.Bisque;
            this.btnLoad.TabIndex = 20;
            this.btnLoad.Text = "Generate";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tanggal SEP";
            // 
            // dtFrom
            // 
            this.dtFrom.CustomFormat = "dd/MM/yyyy";
            this.dtFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.Location = new System.Drawing.Point(175, 18);
            this.dtFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(143, 27);
            this.dtFrom.TabIndex = 23;
            // 
            // dtTo
            // 
            this.dtTo.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.dtTo.CustomFormat = "dd/MM/yyyy";
            this.dtTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(369, 18);
            this.dtTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(143, 27);
            this.dtTo.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(323, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Dari";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Jenis Pelayanan";
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pivotGridControl1.EditManager = null;
            this.pivotGridControl1.Location = new System.Drawing.Point(24, 158);
            this.pivotGridControl1.Margin = new System.Windows.Forms.Padding(4);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(1512, 462);
            this.pivotGridControl1.TabIndex = 26;
            this.pivotGridControl1.Text = "pivotGridControl1";
            this.pivotGridControl1.UpdateManager = null;
            // 
            // btnExportPdf
            // 
            this.btnExportPdf.AccessibleName = "Button";
            this.btnExportPdf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportPdf.BackColor = System.Drawing.Color.Lavender;
            this.btnExportPdf.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnExportPdf.Location = new System.Drawing.Point(1387, 648);
            this.btnExportPdf.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportPdf.Name = "btnExportPdf";
            this.btnExportPdf.Size = new System.Drawing.Size(128, 34);
            this.btnExportPdf.Style.BackColor = System.Drawing.Color.Lavender;
            this.btnExportPdf.Style.Image = global::Casemix.Properties.Resources.pdf;
            this.btnExportPdf.TabIndex = 27;
            this.btnExportPdf.Text = "PDF";
            this.btnExportPdf.UseVisualStyleBackColor = false;
            this.btnExportPdf.Click += new System.EventHandler(this.btnExportPdf_Click);
            // 
            // btnExportWord
            // 
            this.btnExportWord.AccessibleName = "Button";
            this.btnExportWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportWord.BackColor = System.Drawing.Color.Lavender;
            this.btnExportWord.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnExportWord.Location = new System.Drawing.Point(1251, 648);
            this.btnExportWord.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportWord.Name = "btnExportWord";
            this.btnExportWord.Size = new System.Drawing.Size(128, 34);
            this.btnExportWord.Style.BackColor = System.Drawing.Color.Lavender;
            this.btnExportWord.Style.Image = global::Casemix.Properties.Resources.word;
            this.btnExportWord.TabIndex = 28;
            this.btnExportWord.Text = "Word";
            this.btnExportWord.UseVisualStyleBackColor = false;
            this.btnExportWord.Click += new System.EventHandler(this.btnExportWord_Click);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.AccessibleName = "Button";
            this.btnExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportExcel.BackColor = System.Drawing.Color.Lavender;
            this.btnExportExcel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnExportExcel.Location = new System.Drawing.Point(1115, 648);
            this.btnExportExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(128, 34);
            this.btnExportExcel.Style.BackColor = System.Drawing.Color.Lavender;
            this.btnExportExcel.Style.Image = global::Casemix.Properties.Resources.excel;
            this.btnExportExcel.TabIndex = 30;
            this.btnExportExcel.Text = "Excel";
            this.btnExportExcel.UseVisualStyleBackColor = false;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportXls_Click);
            // 
            // cmbExportXls
            // 
            this.cmbExportXls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbExportXls.Location = new System.Drawing.Point(912, 648);
            this.cmbExportXls.Margin = new System.Windows.Forms.Padding(4);
            this.cmbExportXls.Name = "cmbExportXls";
            this.cmbExportXls.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.cmbExportXls.Size = new System.Drawing.Size(195, 34);
            this.cmbExportXls.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbExportXls.TabIndex = 29;
            // 
            // chkBoxSort
            // 
            this.chkBoxSort.AutoSize = true;
            this.chkBoxSort.Location = new System.Drawing.Point(175, 108);
            this.chkBoxSort.Name = "chkBoxSort";
            this.chkBoxSort.Size = new System.Drawing.Size(104, 21);
            this.chkBoxSort.TabIndex = 31;
            this.chkBoxSort.Text = "Can Sorting";
            this.chkBoxSort.UseVisualStyleBackColor = true;
            // 
            // cmbJenisPel
            // 
            this.cmbJenisPel.Location = new System.Drawing.Point(175, 53);
            this.cmbJenisPel.Name = "cmbJenisPel";
            this.cmbJenisPel.Size = new System.Drawing.Size(337, 32);
            this.cmbJenisPel.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbJenisPel.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(802, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(305, 25);
            this.label4.TabIndex = 40;
            this.label4.Text = "Analisa BPJS Berdasar Diagnosa";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(20, 648);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 20);
            this.label5.TabIndex = 48;
            this.label5.Text = "* Klik Data Untuk Melihat Detil";
            // 
            // FrmAnalisaPerCoding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1563, 718);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbJenisPel);
            this.Controls.Add(this.chkBoxSort);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.cmbExportXls);
            this.Controls.Add(this.btnExportWord);
            this.Controls.Add(this.btnExportPdf);
            this.Controls.Add(this.pivotGridControl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoad);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmAnalisaPerCoding";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analisa Diagnosa BPJS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAnalisaPerDiagnosa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbExportXls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbJenisPel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    
        private Syncfusion.WinForms.Controls.SfButton btnLoad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Syncfusion.Windows.Forms.PivotAnalysis.PivotGridControl pivotGridControl1;
        private Syncfusion.WinForms.Controls.SfButton btnExportPdf;
        private Syncfusion.WinForms.Controls.SfButton btnExportWord;
 
        private Syncfusion.WinForms.Controls.SfButton btnExportExcel;
        private Syncfusion.WinForms.ListView.SfComboBox cmbExportXls;
        private System.Windows.Forms.CheckBox chkBoxSort;
        private Syncfusion.WinForms.ListView.SfComboBox cmbJenisPel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}