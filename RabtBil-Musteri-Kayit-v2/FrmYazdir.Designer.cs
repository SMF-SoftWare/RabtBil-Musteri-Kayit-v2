namespace RabtBil_Musteri_Kayit_v2
{
    partial class FrmYazdir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYazdir));
            this.btnBaskiOnizleme = new System.Windows.Forms.Button();
            this.lblYaziciSecin = new System.Windows.Forms.Label();
            this.cmbYaziciListesi = new System.Windows.Forms.ComboBox();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.btnKapat = new System.Windows.Forms.Button();
            this.ppdBaskiOnizleme = new System.Windows.Forms.PrintPreviewDialog();
            this.pdcBelge = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // btnBaskiOnizleme
            // 
            this.btnBaskiOnizleme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBaskiOnizleme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaskiOnizleme.ForeColor = System.Drawing.Color.White;
            this.btnBaskiOnizleme.Location = new System.Drawing.Point(171, 96);
            this.btnBaskiOnizleme.Name = "btnBaskiOnizleme";
            this.btnBaskiOnizleme.Size = new System.Drawing.Size(150, 40);
            this.btnBaskiOnizleme.TabIndex = 51;
            this.btnBaskiOnizleme.Text = "Baskı Önizleme";
            this.btnBaskiOnizleme.UseVisualStyleBackColor = false;
            this.btnBaskiOnizleme.Click += new System.EventHandler(this.btnBaskiOnizleme_Click);
            // 
            // lblYaziciSecin
            // 
            this.lblYaziciSecin.AutoSize = true;
            this.lblYaziciSecin.Location = new System.Drawing.Point(15, 39);
            this.lblYaziciSecin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYaziciSecin.Name = "lblYaziciSecin";
            this.lblYaziciSecin.Size = new System.Drawing.Size(152, 21);
            this.lblYaziciSecin.TabIndex = 50;
            this.lblYaziciSecin.Text = "Lütfen Yazıcıyı Seçin:";
            // 
            // cmbYaziciListesi
            // 
            this.cmbYaziciListesi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYaziciListesi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbYaziciListesi.FormattingEnabled = true;
            this.cmbYaziciListesi.Location = new System.Drawing.Point(15, 64);
            this.cmbYaziciListesi.Name = "cmbYaziciListesi";
            this.cmbYaziciListesi.Size = new System.Drawing.Size(306, 29);
            this.cmbYaziciListesi.TabIndex = 49;
            // 
            // btnYazdir
            // 
            this.btnYazdir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnYazdir.Enabled = false;
            this.btnYazdir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYazdir.ForeColor = System.Drawing.Color.White;
            this.btnYazdir.Location = new System.Drawing.Point(15, 96);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(150, 40);
            this.btnYazdir.TabIndex = 48;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = false;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lblBaslik.Location = new System.Drawing.Point(15, 9);
            this.lblBaslik.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(177, 25);
            this.lblBaslik.TabIndex = 52;
            this.lblBaslik.Text = "Teknik Servis Formu";
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.White;
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.Image")));
            this.btnKapat.Location = new System.Drawing.Point(303, 1);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(0);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(30, 30);
            this.btnKapat.TabIndex = 53;
            this.btnKapat.TabStop = false;
            this.btnKapat.UseVisualStyleBackColor = false;
            // 
            // ppdBaskiOnizleme
            // 
            this.ppdBaskiOnizleme.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppdBaskiOnizleme.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppdBaskiOnizleme.ClientSize = new System.Drawing.Size(400, 300);
            this.ppdBaskiOnizleme.Document = this.pdcBelge;
            this.ppdBaskiOnizleme.Enabled = true;
            this.ppdBaskiOnizleme.Icon = ((System.Drawing.Icon)(resources.GetObject("ppdBaskiOnizleme.Icon")));
            this.ppdBaskiOnizleme.Name = "ppdBaskiOnizleme";
            this.ppdBaskiOnizleme.Visible = false;
            // 
            // FrmYazdir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(334, 150);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.btnBaskiOnizleme);
            this.Controls.Add(this.lblYaziciSecin);
            this.Controls.Add(this.cmbYaziciListesi);
            this.Controls.Add(this.btnYazdir);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmYazdir";
            this.Text = "FrmYazdir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnBaskiOnizleme;
        private System.Windows.Forms.Label lblYaziciSecin;
        public System.Windows.Forms.ComboBox cmbYaziciListesi;
        public System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Label lblBaslik;
        public System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.PrintPreviewDialog ppdBaskiOnizleme;
        private System.Drawing.Printing.PrintDocument pdcBelge;
    }
}