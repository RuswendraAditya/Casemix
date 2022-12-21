namespace Casemix.Forms
{
    partial class FrmMain
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
            this.Panel1 = new System.Windows.Forms.Panel();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.mnu020201000000 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu020201010000 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu020201020000 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu020201030000 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu020201040000 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu020202000000 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu020202010000 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu020202020000 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu020202030000 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu020203000000 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu020203010000 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu020203020000 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu020203030000 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu020203040000 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu020203050000 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu020203060000 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu020203070000 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu020203100000 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu020204000000 = new System.Windows.Forms.ToolStripMenuItem();
            this.PicLogo1 = new System.Windows.Forms.PictureBox();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.Panel1.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackgroundImage = global::Casemix.Properties.Resources.backgrond;
            this.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel1.Controls.Add(this.MenuStrip);
            this.Panel1.Controls.Add(this.PicLogo1);
            this.Panel1.Controls.Add(this.PicLogo);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(992, 524);
            this.Panel1.TabIndex = 15;
            // 
            // MenuStrip
            // 
            this.MenuStrip.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu020201000000,
            this.mnu020202000000,
            this.mnu020203000000,
            this.mnu020204000000});
            this.MenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(992, 28);
            this.MenuStrip.TabIndex = 4;
            this.MenuStrip.Text = "MenuStrip1";
            // 
            // mnu020201000000
            // 
            this.mnu020201000000.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.mnu020201000000.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem4,
            this.mnu020201010000,
            this.mnu020201020000,
            this.mnu020201030000,
            this.mnu020201040000});
            this.mnu020201000000.Name = "mnu020201000000";
            this.mnu020201000000.Size = new System.Drawing.Size(136, 22);
            this.mnu020201000000.Text = "Monitoring BPJS";
            // 
            // ToolStripMenuItem4
            // 
            this.ToolStripMenuItem4.Name = "ToolStripMenuItem4";
            this.ToolStripMenuItem4.Size = new System.Drawing.Size(275, 6);
            // 
            // mnu020201010000
            // 
            this.mnu020201010000.Name = "mnu020201010000";
            this.mnu020201010000.Size = new System.Drawing.Size(278, 26);
            this.mnu020201010000.Text = "Monitoring Pelayanan BPJS";
            this.mnu020201010000.Click += new System.EventHandler(this.mnu020201010000_Click);
            // 
            // mnu020201020000
            // 
            this.mnu020201020000.Name = "mnu020201020000";
            this.mnu020201020000.Size = new System.Drawing.Size(278, 26);
            this.mnu020201020000.Text = "Rincian Biaya AKPN";
            this.mnu020201020000.Visible = false;
            this.mnu020201020000.Click += new System.EventHandler(this.mnu020201020000_Click);
            // 
            // mnu020201030000
            // 
            this.mnu020201030000.Name = "mnu020201030000";
            this.mnu020201030000.Size = new System.Drawing.Size(278, 26);
            this.mnu020201030000.Text = "Rincian Biaya JKN ";
            this.mnu020201030000.Click += new System.EventHandler(this.mnu020201030000_Click);
            // 
            // mnu020201040000
            // 
            this.mnu020201040000.Name = "mnu020201040000";
            this.mnu020201040000.Size = new System.Drawing.Size(278, 26);
            this.mnu020201040000.Text = "Monitoring Status SEP";
            this.mnu020201040000.Click += new System.EventHandler(this.mnu020201040000_Click);
            // 
            // mnu020202000000
            // 
            this.mnu020202000000.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu020202010000,
            this.mnu020202020000,
            this.mnu020202030000});
            this.mnu020202000000.Name = "mnu020202000000";
            this.mnu020202000000.Size = new System.Drawing.Size(110, 22);
            this.mnu020202000000.Text = "Analisa BPJS";
            this.mnu020202000000.Click += new System.EventHandler(this.mnu020202000000_Click);
            // 
            // mnu020202010000
            // 
            this.mnu020202010000.Name = "mnu020202010000";
            this.mnu020202010000.Size = new System.Drawing.Size(266, 26);
            this.mnu020202010000.Text = "Upload Data From Inacbg";
            this.mnu020202010000.Visible = false;
            this.mnu020202010000.Click += new System.EventHandler(this.mnu020202010000_Click);
            // 
            // mnu020202020000
            // 
            this.mnu020202020000.Name = "mnu020202020000";
            this.mnu020202020000.Size = new System.Drawing.Size(266, 26);
            this.mnu020202020000.Text = "Per Coding Inacbg";
            this.mnu020202020000.Click += new System.EventHandler(this.mnu020202020000_Click);
            // 
            // mnu020202030000
            // 
            this.mnu020202030000.Name = "mnu020202030000";
            this.mnu020202030000.Size = new System.Drawing.Size(266, 26);
            this.mnu020202030000.Text = "Per Dokter DPJP";
            this.mnu020202030000.Click += new System.EventHandler(this.mnu020202030000_Click);
            // 
            // mnu020203000000
            // 
            this.mnu020203000000.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu020203010000,
            this.mnu020203020000,
            this.mnu020203030000,
            this.mnu020203040000,
            this.mnu020203050000,
            this.mnu020203060000,
            this.mnu020203070000,
            this.mnu020203100000});
            this.mnu020203000000.Name = "mnu020203000000";
            this.mnu020203000000.Size = new System.Drawing.Size(94, 22);
            this.mnu020203000000.Text = "Anti Fraud";
            this.mnu020203000000.Visible = false;
            // 
            // mnu020203010000
            // 
            this.mnu020203010000.Name = "mnu020203010000";
            this.mnu020203010000.Size = new System.Drawing.Size(389, 26);
            this.mnu020203010000.Text = "Variable 1 (Jumlah Kasus Per Bulan)";
            this.mnu020203010000.Click += new System.EventHandler(this.mnu020203010000_Click);
            // 
            // mnu020203020000
            // 
            this.mnu020203020000.Name = "mnu020203020000";
            this.mnu020203020000.Size = new System.Drawing.Size(389, 26);
            this.mnu020203020000.Text = "Variable 2 (Jumlah Tagihan Per Bulan)";
            this.mnu020203020000.Click += new System.EventHandler(this.mnu020203020000_Click);
            // 
            // mnu020203030000
            // 
            this.mnu020203030000.Name = "mnu020203030000";
            this.mnu020203030000.Size = new System.Drawing.Size(389, 26);
            this.mnu020203030000.Text = "Variable 3 (Jumlah Kasus Ranap per Kelas)";
            this.mnu020203030000.Click += new System.EventHandler(this.mnu020203030000_Click);
            // 
            // mnu020203040000
            // 
            this.mnu020203040000.Name = "mnu020203040000";
            this.mnu020203040000.Size = new System.Drawing.Size(389, 26);
            this.mnu020203040000.Text = "Variable 4 (Jumlah Rata-Rata LOS)";
            this.mnu020203040000.Click += new System.EventHandler(this.mnu020203040000_Click);
            // 
            // mnu020203050000
            // 
            this.mnu020203050000.Name = "mnu020203050000";
            this.mnu020203050000.Size = new System.Drawing.Size(389, 26);
            this.mnu020203050000.Text = "Variable 5 (Jumlah Cara Pulang)";
            this.mnu020203050000.Click += new System.EventHandler(this.mnu020203050000_Click);
            // 
            // mnu020203060000
            // 
            this.mnu020203060000.Name = "mnu020203060000";
            this.mnu020203060000.Size = new System.Drawing.Size(389, 26);
            this.mnu020203060000.Text = "Variable 6 (Total Tarif Rill RS)";
            this.mnu020203060000.Click += new System.EventHandler(this.mnu020203060000_Click);
            // 
            // mnu020203070000
            // 
            this.mnu020203070000.Name = "mnu020203070000";
            this.mnu020203070000.Size = new System.Drawing.Size(389, 26);
            this.mnu020203070000.Text = "Variable 7 (Jumlah Kasus per Severity Level)";
            this.mnu020203070000.Click += new System.EventHandler(this.mnu020203070000_Click);
            // 
            // mnu020203100000
            // 
            this.mnu020203100000.Name = "mnu020203100000";
            this.mnu020203100000.Size = new System.Drawing.Size(389, 26);
            this.mnu020203100000.Text = "Variable 19";
            this.mnu020203100000.Click += new System.EventHandler(this.mnu020203100000_Click);
            // 
            // mnu020204000000
            // 
            this.mnu020204000000.Name = "mnu020204000000";
            this.mnu020204000000.Size = new System.Drawing.Size(66, 22);
            this.mnu020204000000.Text = "&Selesai";
            this.mnu020204000000.Click += new System.EventHandler(this.mnu020107000000_Click);
            // 
            // PicLogo1
            // 
            this.PicLogo1.Location = new System.Drawing.Point(71, 591);
            this.PicLogo1.Name = "PicLogo1";
            this.PicLogo1.Size = new System.Drawing.Size(128, 57);
            this.PicLogo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicLogo1.TabIndex = 3;
            this.PicLogo1.TabStop = false;
            this.PicLogo1.Visible = false;
            // 
            // PicLogo
            // 
            this.PicLogo.Location = new System.Drawing.Point(12, 591);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(57, 57);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicLogo.TabIndex = 2;
            this.PicLogo.TabStop = false;
            this.PicLogo.Visible = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 524);
            this.Controls.Add(this.Panel1);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Casemix";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.PictureBox PicLogo1;
        internal System.Windows.Forms.PictureBox PicLogo;
        internal System.Windows.Forms.MenuStrip MenuStrip;
        internal System.Windows.Forms.ToolStripMenuItem mnu020201000000;
        internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem4;
        internal System.Windows.Forms.ToolStripMenuItem mnu020204000000;
        private System.Windows.Forms.ToolStripMenuItem mnu020202000000;
        private System.Windows.Forms.ToolStripMenuItem mnu020202010000;
        private System.Windows.Forms.ToolStripMenuItem mnu020202020000;
        private System.Windows.Forms.ToolStripMenuItem mnu020202030000;
        private System.Windows.Forms.ToolStripMenuItem mnu020201010000;
        internal System.Windows.Forms.ToolStripMenuItem mnu020203000000;
        private System.Windows.Forms.ToolStripMenuItem mnu020203010000;
        private System.Windows.Forms.ToolStripMenuItem mnu020203020000;
        private System.Windows.Forms.ToolStripMenuItem mnu020203030000;
        private System.Windows.Forms.ToolStripMenuItem mnu020203040000;
        private System.Windows.Forms.ToolStripMenuItem mnu020201020000;
        private System.Windows.Forms.ToolStripMenuItem mnu020203050000;
        private System.Windows.Forms.ToolStripMenuItem mnu020203060000;
        private System.Windows.Forms.ToolStripMenuItem mnu020201030000;
        private System.Windows.Forms.ToolStripMenuItem mnu020203070000;
        private System.Windows.Forms.ToolStripMenuItem mnu020203100000;
        private System.Windows.Forms.ToolStripMenuItem mnu020201040000;
    }
}