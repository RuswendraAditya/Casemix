
namespace Casemix.Forms.CasemixForm
{
    partial class FrmEditCatatan
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
            this.txtCatatan = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.btnSIMPAN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCatatan
            // 
            this.txtCatatan.Location = new System.Drawing.Point(12, 53);
            this.txtCatatan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCatatan.Multiline = true;
            this.txtCatatan.Name = "txtCatatan";
            this.txtCatatan.Size = new System.Drawing.Size(1069, 173);
            this.txtCatatan.TabIndex = 383;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(12, 26);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(142, 24);
            this.label25.TabIndex = 382;
            this.label25.Text = "EDIT CATATAN";
            // 
            // btnSIMPAN
            // 
            this.btnSIMPAN.BackColor = System.Drawing.Color.Bisque;
            this.btnSIMPAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSIMPAN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSIMPAN.Location = new System.Drawing.Point(12, 254);
            this.btnSIMPAN.Margin = new System.Windows.Forms.Padding(4);
            this.btnSIMPAN.Name = "btnSIMPAN";
            this.btnSIMPAN.Size = new System.Drawing.Size(1065, 43);
            this.btnSIMPAN.TabIndex = 390;
            this.btnSIMPAN.Text = "SIMPAN";
            this.btnSIMPAN.UseVisualStyleBackColor = false;
            this.btnSIMPAN.Click += new System.EventHandler(this.btnSIMPAN_Click);
            // 
            // FrmEditCatatan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1090, 340);
            this.Controls.Add(this.btnSIMPAN);
            this.Controls.Add(this.txtCatatan);
            this.Controls.Add(this.label25);
            this.Name = "FrmEditCatatan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Catatan";
            this.Load += new System.EventHandler(this.FrmEditCatatan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCatatan;
        private System.Windows.Forms.Label label25;
        internal System.Windows.Forms.Button btnSIMPAN;
    }
}