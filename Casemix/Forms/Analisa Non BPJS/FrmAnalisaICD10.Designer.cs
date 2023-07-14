
namespace Casemix.Forms.Analisa_Non_BPJS
{
    partial class FrmAnalisaICD10
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoad = new Syncfusion.WinForms.Controls.SfButton();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExportExcel = new Syncfusion.WinForms.Controls.SfButton();
            this.cmbExportXls = new Syncfusion.WinForms.ListView.SfComboBox();
            this.btnExportWord = new Syncfusion.WinForms.Controls.SfButton();
            this.btnExportPdf = new Syncfusion.WinForms.Controls.SfButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pivotAnalisa = new Syncfusion.Windows.Forms.PivotAnalysis.PivotGridControl(this.components);
            this.chkBoxSort = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNamaPng = new System.Windows.Forms.TextBox();
            this.txtKdPng = new System.Windows.Forms.TextBox();
            this.btnLookup = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIcd = new System.Windows.Forms.TextBox();
            this.txtDiagnosa = new System.Windows.Forms.TextBox();
            this.btnPilihDiagnosa = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cmbExportXls)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Tgl Masuk Inap";
            // 
            // btnLoad
            // 
            this.btnLoad.AccessibleName = "Button";
            this.btnLoad.BackColor = System.Drawing.Color.Bisque;
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnLoad.Location = new System.Drawing.Point(148, 130);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(84, 26);
            this.btnLoad.Style.BackColor = System.Drawing.Color.Bisque;
            this.btnLoad.TabIndex = 34;
            this.btnLoad.Text = "Generate";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // dtFrom
            // 
            this.dtFrom.CustomFormat = "dd/MM/yyyy";
            this.dtFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.Location = new System.Drawing.Point(141, 15);
            this.dtFrom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(108, 23);
            this.dtFrom.TabIndex = 39;
            // 
            // dtTo
            // 
            this.dtTo.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.dtTo.CustomFormat = "dd/MM/yyyy";
            this.dtTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(286, 15);
            this.dtTo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(108, 23);
            this.dtTo.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(252, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Dari";
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.AccessibleName = "Button";
            this.btnExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportExcel.BackColor = System.Drawing.Color.Lavender;
            this.btnExportExcel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnExportExcel.Location = new System.Drawing.Point(620, 564);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(96, 28);
            this.btnExportExcel.Style.BackColor = System.Drawing.Color.Lavender;
            this.btnExportExcel.Style.Image = global::Casemix.Properties.Resources.excel;
            this.btnExportExcel.TabIndex = 43;
            this.btnExportExcel.Text = "Excel";
            this.btnExportExcel.UseVisualStyleBackColor = false;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // cmbExportXls
            // 
            this.cmbExportXls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbExportXls.Location = new System.Drawing.Point(468, 564);
            this.cmbExportXls.Name = "cmbExportXls";
            this.cmbExportXls.Size = new System.Drawing.Size(146, 28);
            this.cmbExportXls.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cmbExportXls.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbExportXls.TabIndex = 42;
            // 
            // btnExportWord
            // 
            this.btnExportWord.AccessibleName = "Button";
            this.btnExportWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportWord.BackColor = System.Drawing.Color.Lavender;
            this.btnExportWord.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnExportWord.Location = new System.Drawing.Point(722, 564);
            this.btnExportWord.Name = "btnExportWord";
            this.btnExportWord.Size = new System.Drawing.Size(96, 28);
            this.btnExportWord.Style.BackColor = System.Drawing.Color.Lavender;
            this.btnExportWord.Style.Image = global::Casemix.Properties.Resources.word;
            this.btnExportWord.TabIndex = 41;
            this.btnExportWord.Text = "Word";
            this.btnExportWord.UseVisualStyleBackColor = false;
            this.btnExportWord.Click += new System.EventHandler(this.btnExportWord_Click);
            // 
            // btnExportPdf
            // 
            this.btnExportPdf.AccessibleName = "Button";
            this.btnExportPdf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportPdf.BackColor = System.Drawing.Color.Lavender;
            this.btnExportPdf.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnExportPdf.Location = new System.Drawing.Point(824, 564);
            this.btnExportPdf.Name = "btnExportPdf";
            this.btnExportPdf.Size = new System.Drawing.Size(96, 28);
            this.btnExportPdf.Style.BackColor = System.Drawing.Color.Lavender;
            this.btnExportPdf.Style.Image = global::Casemix.Properties.Resources.pdf;
            this.btnExportPdf.TabIndex = 40;
            this.btnExportPdf.Text = "PDF";
            this.btnExportPdf.UseVisualStyleBackColor = false;
            this.btnExportPdf.Click += new System.EventHandler(this.btnExportPdf_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(418, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "Analisa Biaya Berdasar ICD 10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(9, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(629, 17);
            this.label3.TabIndex = 47;
            this.label3.Text = "* Data Yang tampil adalah pasien yang sudah Dipulangkan AKPN dan diisi Diagnosa A" +
    "khir(ICD-10)";
            // 
            // pivotAnalisa
            // 
            this.pivotAnalisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pivotAnalisa.EditManager = null;
            this.pivotAnalisa.Location = new System.Drawing.Point(7, 162);
            this.pivotAnalisa.Name = "pivotAnalisa";
            this.pivotAnalisa.Size = new System.Drawing.Size(913, 388);
            this.pivotAnalisa.TabIndex = 48;
            this.pivotAnalisa.Text = "pivotGridControl1";
            this.pivotAnalisa.UpdateManager = null;
            // 
            // chkBoxSort
            // 
            this.chkBoxSort.AutoSize = true;
            this.chkBoxSort.Location = new System.Drawing.Point(9, 140);
            this.chkBoxSort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkBoxSort.Name = "chkBoxSort";
            this.chkBoxSort.Size = new System.Drawing.Size(139, 17);
            this.chkBoxSort.TabIndex = 50;
            this.chkBoxSort.Text = "Can Sorting(Row Mode)";
            this.chkBoxSort.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 51;
            this.label5.Text = "Penanggung";
            // 
            // txtNamaPng
            // 
            this.txtNamaPng.Location = new System.Drawing.Point(193, 48);
            this.txtNamaPng.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNamaPng.Name = "txtNamaPng";
            this.txtNamaPng.ReadOnly = true;
            this.txtNamaPng.Size = new System.Drawing.Size(261, 20);
            this.txtNamaPng.TabIndex = 52;
            // 
            // txtKdPng
            // 
            this.txtKdPng.Location = new System.Drawing.Point(141, 48);
            this.txtKdPng.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtKdPng.Name = "txtKdPng";
            this.txtKdPng.ReadOnly = true;
            this.txtKdPng.Size = new System.Drawing.Size(48, 20);
            this.txtKdPng.TabIndex = 53;
            // 
            // btnLookup
            // 
            this.btnLookup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLookup.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnLookup.Location = new System.Drawing.Point(456, 48);
            this.btnLookup.Name = "btnLookup";
            this.btnLookup.Size = new System.Drawing.Size(26, 18);
            this.btnLookup.TabIndex = 307;
            this.btnLookup.Text = "...";
            this.btnLookup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLookup.UseVisualStyleBackColor = true;
            this.btnLookup.Click += new System.EventHandler(this.btnLookup_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 72);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 308;
            this.label6.Text = "Diagnosa";
            // 
            // txtIcd
            // 
            this.txtIcd.Location = new System.Drawing.Point(141, 72);
            this.txtIcd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIcd.Name = "txtIcd";
            this.txtIcd.ReadOnly = true;
            this.txtIcd.Size = new System.Drawing.Size(48, 20);
            this.txtIcd.TabIndex = 309;
            // 
            // txtDiagnosa
            // 
            this.txtDiagnosa.Location = new System.Drawing.Point(193, 72);
            this.txtDiagnosa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDiagnosa.Name = "txtDiagnosa";
            this.txtDiagnosa.ReadOnly = true;
            this.txtDiagnosa.Size = new System.Drawing.Size(449, 20);
            this.txtDiagnosa.TabIndex = 310;
            // 
            // btnPilihDiagnosa
            // 
            this.btnPilihDiagnosa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPilihDiagnosa.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnPilihDiagnosa.Location = new System.Drawing.Point(646, 72);
            this.btnPilihDiagnosa.Name = "btnPilihDiagnosa";
            this.btnPilihDiagnosa.Size = new System.Drawing.Size(27, 24);
            this.btnPilihDiagnosa.TabIndex = 311;
            this.btnPilihDiagnosa.Text = "....";
            this.btnPilihDiagnosa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPilihDiagnosa.UseVisualStyleBackColor = true;
            this.btnPilihDiagnosa.Click += new System.EventHandler(this.btnPilihDiagnosa_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnReset.Location = new System.Drawing.Point(679, 72);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(44, 24);
            this.btnReset.TabIndex = 312;
            this.btnReset.Text = "Reset";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // FrmAnalisaICD10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(934, 609);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPilihDiagnosa);
            this.Controls.Add(this.txtDiagnosa);
            this.Controls.Add(this.txtIcd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLookup);
            this.Controls.Add(this.txtKdPng);
            this.Controls.Add(this.txtNamaPng);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chkBoxSort);
            this.Controls.Add(this.pivotAnalisa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.cmbExportXls);
            this.Controls.Add(this.btnExportWord);
            this.Controls.Add(this.btnExportPdf);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoad);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmAnalisaICD10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analisa ICD 10";
            this.Load += new System.EventHandler(this.FrmAnalisaICD10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbExportXls)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Syncfusion.WinForms.Controls.SfButton btnLoad;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label label2;
        private Syncfusion.WinForms.Controls.SfButton btnExportExcel;
        private Syncfusion.WinForms.ListView.SfComboBox cmbExportXls;
        private Syncfusion.WinForms.Controls.SfButton btnExportWord;
        private Syncfusion.WinForms.Controls.SfButton btnExportPdf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Syncfusion.Windows.Forms.PivotAnalysis.PivotGridControl pivotAnalisa;
        private System.Windows.Forms.CheckBox chkBoxSort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNamaPng;
        private System.Windows.Forms.TextBox txtKdPng;
        private System.Windows.Forms.Button btnLookup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIcd;
        private System.Windows.Forms.TextBox txtDiagnosa;
        private System.Windows.Forms.Button btnPilihDiagnosa;
        private System.Windows.Forms.Button btnReset;
    }
}