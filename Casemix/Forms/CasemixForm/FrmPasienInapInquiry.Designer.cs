
namespace Casemix.Forms.CasemixForm
{
    partial class FrmPasienInapInquiry
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
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdCariRuang = new System.Windows.Forms.Button();
            this.txtNamaRuang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKdRuang = new System.Windows.Forms.TextBox();
            this.btnCari = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNoRM = new System.Windows.Forms.TextBox();
            this.txtNoReg = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgPiutang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPiutang
            // 
            this.dgPiutang.AccessibleName = "Table";
            this.dgPiutang.AllowEditing = false;
            this.dgPiutang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgPiutang.Location = new System.Drawing.Point(15, 169);
            this.dgPiutang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgPiutang.Name = "dgPiutang";
            this.dgPiutang.PreviewRowHeight = 35;
            this.dgPiutang.Size = new System.Drawing.Size(1230, 466);
            this.dgPiutang.TabIndex = 378;
            this.dgPiutang.Text = "sfDataGrid1";
            this.dgPiutang.AutoGeneratingColumn += new Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnEventHandler(this.dgPiutang_AutoGeneratingColumn);
            this.dgPiutang.CellButtonClick += new Syncfusion.WinForms.DataGrid.Events.CellButtonClickEventHandler(this.pilihPasien_click);
            // 
            // dtFrom
            // 
            this.dtFrom.CustomFormat = "dd/MM/yyyy";
            this.dtFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.Location = new System.Drawing.Point(167, 9);
            this.dtFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(143, 27);
            this.dtFrom.TabIndex = 382;
            // 
            // dtTo
            // 
            this.dtTo.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.dtTo.CustomFormat = "dd/MM/yyyy";
            this.dtTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(361, 9);
            this.dtTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(143, 27);
            this.dtTo.TabIndex = 381;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(315, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 380;
            this.label2.Text = "Dari";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 379;
            this.label1.Text = "Tanggal Masuk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 383;
            this.label3.Text = "Ruang";
            // 
            // cmdCariRuang
            // 
            this.cmdCariRuang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdCariRuang.Location = new System.Drawing.Point(585, 44);
            this.cmdCariRuang.Margin = new System.Windows.Forms.Padding(4);
            this.cmdCariRuang.Name = "cmdCariRuang";
            this.cmdCariRuang.Size = new System.Drawing.Size(33, 28);
            this.cmdCariRuang.TabIndex = 384;
            this.cmdCariRuang.Text = "...";
            this.cmdCariRuang.UseVisualStyleBackColor = true;
            this.cmdCariRuang.Click += new System.EventHandler(this.cmdCariRuang_Click);
            // 
            // txtNamaRuang
            // 
            this.txtNamaRuang.Enabled = false;
            this.txtNamaRuang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaRuang.Location = new System.Drawing.Point(240, 44);
            this.txtNamaRuang.Margin = new System.Windows.Forms.Padding(4);
            this.txtNamaRuang.MaxLength = 13;
            this.txtNamaRuang.Name = "txtNamaRuang";
            this.txtNamaRuang.Size = new System.Drawing.Size(337, 26);
            this.txtNamaRuang.TabIndex = 385;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(443, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 25);
            this.label4.TabIndex = 386;
            this.label4.Text = "Pasien Rawat Inap";
            // 
            // txtKdRuang
            // 
            this.txtKdRuang.Enabled = false;
            this.txtKdRuang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKdRuang.Location = new System.Drawing.Point(167, 44);
            this.txtKdRuang.Margin = new System.Windows.Forms.Padding(4);
            this.txtKdRuang.MaxLength = 13;
            this.txtKdRuang.Name = "txtKdRuang";
            this.txtKdRuang.Size = new System.Drawing.Size(65, 26);
            this.txtKdRuang.TabIndex = 387;
            // 
            // btnCari
            // 
            this.btnCari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCari.Location = new System.Drawing.Point(291, 111);
            this.btnCari.Margin = new System.Windows.Forms.Padding(4);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(100, 28);
            this.btnCari.TabIndex = 388;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 389;
            this.label5.Text = "No RM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 390;
            this.label6.Text = "No Reg";
            // 
            // txtNoRM
            // 
            this.txtNoRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoRM.Location = new System.Drawing.Point(167, 78);
            this.txtNoRM.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoRM.MaxLength = 13;
            this.txtNoRM.Name = "txtNoRM";
            this.txtNoRM.Size = new System.Drawing.Size(115, 26);
            this.txtNoRM.TabIndex = 391;
            // 
            // txtNoReg
            // 
            this.txtNoReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoReg.Location = new System.Drawing.Point(167, 112);
            this.txtNoReg.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoReg.MaxLength = 13;
            this.txtNoReg.Name = "txtNoReg";
            this.txtNoReg.Size = new System.Drawing.Size(115, 26);
            this.txtNoReg.TabIndex = 392;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBox1.Location = new System.Drawing.Point(16, 651);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 393;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox2.BackColor = System.Drawing.Color.CadetBlue;
            this.textBox2.Location = new System.Drawing.Point(16, 679);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 394;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox3.BackColor = System.Drawing.Color.GreenYellow;
            this.textBox3.Location = new System.Drawing.Point(15, 707);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 395;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(134, 651);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 20);
            this.label7.TabIndex = 396;
            this.label7.Text = "Blm Ada Input Data";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(134, 679);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(325, 20);
            this.label8.TabIndex = 397;
            this.label8.Text = "Sudah Ada Input Form A Atau Form B";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(134, 707);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(292, 20);
            this.label9.TabIndex = 398;
            this.label9.Text = "Form A dan Form B sudah diinput";
            // 
            // FrmPasienInapInquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1257, 751);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtNoReg);
            this.Controls.Add(this.txtNoRM);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.txtKdRuang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmdCariRuang);
            this.Controls.Add(this.txtNamaRuang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgPiutang);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmPasienInapInquiry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daftar Pasien Inap";
            ((System.ComponentModel.ISupportInitialize)(this.dgPiutang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.WinForms.DataGrid.SfDataGrid dgPiutang;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Button cmdCariRuang;
        internal System.Windows.Forms.TextBox txtNamaRuang;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox txtKdRuang;
        internal System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox txtNoRM;
        internal System.Windows.Forms.TextBox txtNoReg;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}