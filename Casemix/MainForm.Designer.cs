namespace Casemix
{
    partial class MainForm
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
            this.mnu020101000000 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu020101010000 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu020107000000 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.PicLogo1 = new System.Windows.Forms.PictureBox();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.mnu020101020000 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip.SuspendLayout();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // mnu020101000000
            // 
            this.mnu020101000000.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.mnu020101000000.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem4,
            this.mnu020101010000,
            this.mnu020101020000});
            this.mnu020101000000.Name = "mnu020101000000";
            this.mnu020101000000.Size = new System.Drawing.Size(110, 22);
            this.mnu020101000000.Text = "Analisa BPJS";
            // 
            // ToolStripMenuItem4
            // 
            this.ToolStripMenuItem4.Name = "ToolStripMenuItem4";
            this.ToolStripMenuItem4.Size = new System.Drawing.Size(221, 6);
            // 
            // mnu020101010000
            // 
            this.mnu020101010000.Name = "mnu020101010000";
            this.mnu020101010000.Size = new System.Drawing.Size(224, 26);
            this.mnu020101010000.Text = "Per Coding Inacbg";
            this.mnu020101010000.Click += new System.EventHandler(this.mnu020101010000_Click);
            // 
            // mnu020107000000
            // 
            this.mnu020107000000.Name = "mnu020107000000";
            this.mnu020107000000.Size = new System.Drawing.Size(66, 22);
            this.mnu020107000000.Text = "&Selesai";
            // 
            // MenuStrip
            // 
            this.MenuStrip.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu020101000000,
            this.mnu020107000000});
            this.MenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(1010, 28);
            this.MenuStrip.TabIndex = 2;
            this.MenuStrip.Text = "MenuStrip1";
            // 
            // Panel1
            // 
            this.Panel1.BackgroundImage = global::Casemix.Properties.Resources.backgrond;
            this.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel1.Controls.Add(this.PicLogo1);
            this.Panel1.Controls.Add(this.PicLogo);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(0, 28);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1010, 569);
            this.Panel1.TabIndex = 14;
            // 
            // PicLogo1
            // 
            this.PicLogo1.Location = new System.Drawing.Point(71, 591);
            this.PicLogo1.Name = "PicLogo1";
            this.PicLogo1.Size = new System.Drawing.Size(128, 57);
            this.PicLogo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicLogo1.TabIndex = 3;
            this.PicLogo1.TabStop = false;
            // 
            // PicLogo
            // 
            this.PicLogo.Location = new System.Drawing.Point(12, 591);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(57, 57);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicLogo.TabIndex = 2;
            this.PicLogo.TabStop = false;
            // 
            // mnu020101020000
            // 
            this.mnu020101020000.Name = "mnu020101020000";
            this.mnu020101020000.Size = new System.Drawing.Size(224, 26);
            this.mnu020101020000.Text = "Per Dokter DPJP";
            this.mnu020101020000.Click += new System.EventHandler(this.mnu020101020000_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 597);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.MenuStrip);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Casemix";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.PictureBox PicLogo1;
        internal System.Windows.Forms.PictureBox PicLogo;
        internal System.Windows.Forms.ToolStripMenuItem mnu020101000000;
        internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem4;
        internal System.Windows.Forms.ToolStripMenuItem mnu020101010000;
        internal System.Windows.Forms.ToolStripMenuItem mnu020107000000;
        internal System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnu020101020000;
    }
}

