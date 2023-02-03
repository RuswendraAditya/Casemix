
namespace Casemix.Forms.Analisa_Non_BPJS
{
    partial class FrmAnalisaICD10Dtl_Lvl2
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
            this.txtNoRM = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNoReg = new System.Windows.Forms.TextBox();
            this.txtNamPasien = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgPiutang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPiutang
            // 
            this.dgPiutang.AccessibleName = "Table";
            this.dgPiutang.AllowEditing = false;
            this.dgPiutang.AllowFiltering = true;
            this.dgPiutang.AllowResizingColumns = true;
            this.dgPiutang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgPiutang.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgPiutang.Location = new System.Drawing.Point(13, 151);
            this.dgPiutang.Margin = new System.Windows.Forms.Padding(4);
            this.dgPiutang.Name = "dgPiutang";
            this.dgPiutang.PreviewRowHeight = 35;
            this.dgPiutang.Size = new System.Drawing.Size(774, 226);
            this.dgPiutang.TabIndex = 41;
            this.dgPiutang.Text = "sfDataGrid1";
            // 
            // txtNoRM
            // 
            this.txtNoRM.Location = new System.Drawing.Point(142, 24);
            this.txtNoRM.Name = "txtNoRM";
            this.txtNoRM.ReadOnly = true;
            this.txtNoRM.Size = new System.Drawing.Size(135, 22);
            this.txtNoRM.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 54;
            this.label5.Text = "No RM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 56;
            this.label1.Text = "No Reg";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 57;
            this.label2.Text = "Nama Pasien";
            // 
            // txtNoReg
            // 
            this.txtNoReg.Location = new System.Drawing.Point(142, 54);
            this.txtNoReg.Name = "txtNoReg";
            this.txtNoReg.ReadOnly = true;
            this.txtNoReg.Size = new System.Drawing.Size(148, 22);
            this.txtNoReg.TabIndex = 58;
            // 
            // txtNamPasien
            // 
            this.txtNamPasien.Location = new System.Drawing.Point(142, 88);
            this.txtNamPasien.Name = "txtNamPasien";
            this.txtNamPasien.ReadOnly = true;
            this.txtNamPasien.Size = new System.Drawing.Size(602, 22);
            this.txtNamPasien.TabIndex = 59;
            // 
            // FrmAnalisaICD10Dtl_Lvl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 415);
            this.Controls.Add(this.txtNamPasien);
            this.Controls.Add(this.txtNoReg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNoRM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgPiutang);
            this.MinimizeBox = false;
            this.Name = "FrmAnalisaICD10Dtl_Lvl2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diagnosa Sekunder";
            ((System.ComponentModel.ISupportInitialize)(this.dgPiutang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.WinForms.DataGrid.SfDataGrid dgPiutang;
        private System.Windows.Forms.TextBox txtNoRM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNoReg;
        private System.Windows.Forms.TextBox txtNamPasien;
    }
}