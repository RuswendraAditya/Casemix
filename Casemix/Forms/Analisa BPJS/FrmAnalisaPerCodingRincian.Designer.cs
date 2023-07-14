
namespace Casemix.Forms.Analisa_BPJS
{
    partial class FrmAnalisaPerCodingRincian
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
            ((System.ComponentModel.ISupportInitialize)(this.dgPiutang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPiutang
            // 
            this.dgPiutang.AccessibleName = "Table";
            this.dgPiutang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgPiutang.Location = new System.Drawing.Point(12, 12);
            this.dgPiutang.Name = "dgPiutang";
            this.dgPiutang.PreviewRowHeight = 35;
            this.dgPiutang.Size = new System.Drawing.Size(1336, 616);
            this.dgPiutang.TabIndex = 40;
            this.dgPiutang.Text = "sfDataGrid1";
            // 
            // FrmAnalisaPerCodingRincian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 662);
            this.Controls.Add(this.dgPiutang);
            this.Name = "FrmAnalisaPerCodingRincian";
            this.Text = "FrmAnalisaPerCodingRincian";
            ((System.ComponentModel.ISupportInitialize)(this.dgPiutang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.WinForms.DataGrid.SfDataGrid dgPiutang;
    }
}