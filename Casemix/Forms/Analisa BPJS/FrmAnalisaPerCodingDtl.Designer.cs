namespace Casemix.Forms.Analisa_BPJS
{
    partial class FrmAnalisaPerCodingDtl
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
            this.btnExportExcel = new Syncfusion.WinForms.Controls.SfButton();
            this.dgPiutang = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.dgPiutang)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.AccessibleName = "Button";
            this.btnExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportExcel.BackColor = System.Drawing.Color.Lavender;
            this.btnExportExcel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnExportExcel.Location = new System.Drawing.Point(1306, 536);
            this.btnExportExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(128, 34);
            this.btnExportExcel.Style.BackColor = System.Drawing.Color.Lavender;
            this.btnExportExcel.Style.Image = global::Casemix.Properties.Resources.excel;
            this.btnExportExcel.TabIndex = 40;
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
            this.dgPiutang.Location = new System.Drawing.Point(12, 29);
            this.dgPiutang.Name = "dgPiutang";
            this.dgPiutang.PreviewRowHeight = 35;
            this.dgPiutang.Size = new System.Drawing.Size(1422, 500);
            this.dgPiutang.TabIndex = 39;
            this.dgPiutang.Text = "sfDataGrid1";
            this.dgPiutang.AutoGeneratingColumn += new Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnEventHandler(this.dgPiutang_AutoGeneratingColumn);
            // 
            // FrmAnalisaPerCodingDtl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1712, 637);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.dgPiutang);
            this.Name = "FrmAnalisaPerCodingDtl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detil Data Per Coding";
            this.Load += new System.EventHandler(this.FrmAnalisaPerCodingDtl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPiutang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Syncfusion.WinForms.Controls.SfButton btnExportExcel;
        private Syncfusion.WinForms.DataGrid.SfDataGrid dgPiutang;
    }
}