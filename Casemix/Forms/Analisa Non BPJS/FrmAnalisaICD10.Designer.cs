
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
            ((System.ComponentModel.ISupportInitialize)(this.cmbExportXls)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Tgl Masuk Inap";
            // 
            // btnLoad
            // 
            this.btnLoad.AccessibleName = "Button";
            this.btnLoad.BackColor = System.Drawing.Color.Bisque;
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnLoad.Location = new System.Drawing.Point(198, 160);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(112, 32);
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
            this.dtFrom.Location = new System.Drawing.Point(188, 18);
            this.dtFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(143, 27);
            this.dtFrom.TabIndex = 39;
            // 
            // dtTo
            // 
            this.dtTo.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.dtTo.CustomFormat = "dd/MM/yyyy";
            this.dtTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(382, 18);
            this.dtTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(143, 27);
            this.dtTo.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(336, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Dari";
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.AccessibleName = "Button";
            this.btnExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportExcel.BackColor = System.Drawing.Color.Lavender;
            this.btnExportExcel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnExportExcel.Location = new System.Drawing.Point(1144, 694);
            this.btnExportExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(128, 34);
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
            this.cmbExportXls.Location = new System.Drawing.Point(941, 694);
            this.cmbExportXls.Margin = new System.Windows.Forms.Padding(4);
            this.cmbExportXls.Name = "cmbExportXls";
            this.cmbExportXls.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.cmbExportXls.Size = new System.Drawing.Size(195, 34);
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
            this.btnExportWord.Location = new System.Drawing.Point(1280, 694);
            this.btnExportWord.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportWord.Name = "btnExportWord";
            this.btnExportWord.Size = new System.Drawing.Size(128, 34);
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
            this.btnExportPdf.Location = new System.Drawing.Point(1416, 694);
            this.btnExportPdf.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportPdf.Name = "btnExportPdf";
            this.btnExportPdf.Size = new System.Drawing.Size(128, 34);
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
            this.label4.Location = new System.Drawing.Point(751, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(281, 25);
            this.label4.TabIndex = 45;
            this.label4.Text = "Analisa Biaya Berdasar ICD 10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(12, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(744, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = "* Data Yang tampil adalah pasien yang sudah Dipulangkan AKPN dan diisi Diagnosa A" +
    "khir(ICD-10)";
            // 
            // pivotAnalisa
            // 
            this.pivotAnalisa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pivotAnalisa.EditManager = null;
            this.pivotAnalisa.Location = new System.Drawing.Point(9, 200);
            this.pivotAnalisa.Margin = new System.Windows.Forms.Padding(4);
            this.pivotAnalisa.Name = "pivotAnalisa";
            this.pivotAnalisa.Size = new System.Drawing.Size(1512, 477);
            this.pivotAnalisa.TabIndex = 48;
            this.pivotAnalisa.Text = "pivotGridControl1";
            this.pivotAnalisa.UpdateManager = null;
            // 
            // chkBoxSort
            // 
            this.chkBoxSort.AutoSize = true;
            this.chkBoxSort.Location = new System.Drawing.Point(12, 172);
            this.chkBoxSort.Name = "chkBoxSort";
            this.chkBoxSort.Size = new System.Drawing.Size(180, 21);
            this.chkBoxSort.TabIndex = 50;
            this.chkBoxSort.Text = "Can Sorting(Row Mode)";
            this.chkBoxSort.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 51;
            this.label5.Text = "Penanggung";
            // 
            // txtNamaPng
            // 
            this.txtNamaPng.Location = new System.Drawing.Point(257, 59);
            this.txtNamaPng.Name = "txtNamaPng";
            this.txtNamaPng.ReadOnly = true;
            this.txtNamaPng.Size = new System.Drawing.Size(347, 22);
            this.txtNamaPng.TabIndex = 52;
            // 
            // txtKdPng
            // 
            this.txtKdPng.Location = new System.Drawing.Point(188, 59);
            this.txtKdPng.Name = "txtKdPng";
            this.txtKdPng.ReadOnly = true;
            this.txtKdPng.Size = new System.Drawing.Size(63, 22);
            this.txtKdPng.TabIndex = 53;
            // 
            // btnLookup
            // 
            this.btnLookup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLookup.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnLookup.Location = new System.Drawing.Point(608, 59);
            this.btnLookup.Margin = new System.Windows.Forms.Padding(4);
            this.btnLookup.Name = "btnLookup";
            this.btnLookup.Size = new System.Drawing.Size(35, 22);
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
            this.label6.Location = new System.Drawing.Point(12, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 308;
            this.label6.Text = "Diagnosa";
            // 
            // txtIcd
            // 
            this.txtIcd.Location = new System.Drawing.Point(188, 89);
            this.txtIcd.Name = "txtIcd";
            this.txtIcd.ReadOnly = true;
            this.txtIcd.Size = new System.Drawing.Size(63, 22);
            this.txtIcd.TabIndex = 309;
            // 
            // txtDiagnosa
            // 
            this.txtDiagnosa.Location = new System.Drawing.Point(257, 89);
            this.txtDiagnosa.Name = "txtDiagnosa";
            this.txtDiagnosa.ReadOnly = true;
            this.txtDiagnosa.Size = new System.Drawing.Size(597, 22);
            this.txtDiagnosa.TabIndex = 310;
            // 
            // btnPilihDiagnosa
            // 
            this.btnPilihDiagnosa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPilihDiagnosa.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnPilihDiagnosa.Location = new System.Drawing.Point(861, 89);
            this.btnPilihDiagnosa.Margin = new System.Windows.Forms.Padding(4);
            this.btnPilihDiagnosa.Name = "btnPilihDiagnosa";
            this.btnPilihDiagnosa.Size = new System.Drawing.Size(35, 22);
            this.btnPilihDiagnosa.TabIndex = 311;
            this.btnPilihDiagnosa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPilihDiagnosa.UseVisualStyleBackColor = true;
            this.btnPilihDiagnosa.Click += new System.EventHandler(this.btnPilihDiagnosa_Click);
            // 
            // FrmAnalisaICD10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1563, 750);
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
    }
}