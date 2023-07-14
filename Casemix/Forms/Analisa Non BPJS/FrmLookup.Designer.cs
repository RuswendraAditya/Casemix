
namespace Casemix.Forms.Analisa_Non_BPJS
{
    partial class FrmLookup
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.gridLookup = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.btnTutup = new System.Windows.Forms.Button();
            this.btnPilih = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookup)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cari Data";
            // 
            // txtCari
            // 
            this.txtCari.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtCari.Location = new System.Drawing.Point(91, 26);
            this.txtCari.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(712, 27);
            this.txtCari.TabIndex = 7;
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
            // 
            // gridLookup
            // 
            this.gridLookup.AccessibleName = "Table";
            this.gridLookup.AllowEditing = false;
            this.gridLookup.AllowFiltering = true;
            this.gridLookup.AllowGrouping = false;
            this.gridLookup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLookup.Location = new System.Drawing.Point(21, 59);
            this.gridLookup.Margin = new System.Windows.Forms.Padding(4);
            this.gridLookup.Name = "gridLookup";
            this.gridLookup.PreviewRowHeight = 35;
            this.gridLookup.Size = new System.Drawing.Size(1014, 356);
            this.gridLookup.Style.CellStyle.Font.Size = 10F;
            this.gridLookup.TabIndex = 8;
            this.gridLookup.Text = "sfDataGrid1";
            this.gridLookup.AutoGeneratingColumn += new Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnEventHandler(this.gridLookup_AutoGeneratingColumn);
            // 
            // btnTutup
            // 
            this.btnTutup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTutup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTutup.Location = new System.Drawing.Point(144, 430);
            this.btnTutup.Margin = new System.Windows.Forms.Padding(5);
            this.btnTutup.Name = "btnTutup";
            this.btnTutup.Size = new System.Drawing.Size(112, 36);
            this.btnTutup.TabIndex = 11;
            this.btnTutup.Text = "Tutup";
            this.btnTutup.UseVisualStyleBackColor = true;
            this.btnTutup.Click += new System.EventHandler(this.btnTutup_Click);
            // 
            // btnPilih
            // 
            this.btnPilih.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPilih.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPilih.Location = new System.Drawing.Point(21, 430);
            this.btnPilih.Margin = new System.Windows.Forms.Padding(5);
            this.btnPilih.Name = "btnPilih";
            this.btnPilih.Size = new System.Drawing.Size(112, 36);
            this.btnPilih.TabIndex = 10;
            this.btnPilih.Text = "Pilih";
            this.btnPilih.UseVisualStyleBackColor = true;
            this.btnPilih.Click += new System.EventHandler(this.btnPilih_Click);
            // 
            // FrmLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 480);
            this.Controls.Add(this.btnTutup);
            this.Controls.Add(this.btnPilih);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.gridLookup);
            this.Name = "FrmLookup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lookup Data";
            this.Load += new System.EventHandler(this.FrmLookup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridLookup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCari;
        private Syncfusion.WinForms.DataGrid.SfDataGrid gridLookup;
        private System.Windows.Forms.Button btnTutup;
        private System.Windows.Forms.Button btnPilih;
    }
}