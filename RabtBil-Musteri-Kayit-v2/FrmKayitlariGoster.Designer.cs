namespace RabtBil_Musteri_Kayit_v2
{
    partial class FrmKayitlariGoster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKayitlariGoster));
            this.dgvRabtBilDB = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.cmbAramaAlanlari = new System.Windows.Forms.ComboBox();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.pdcBelge = new System.Drawing.Printing.PrintDocument();
            this.ppdBaskiOnizleme = new System.Windows.Forms.PrintPreviewDialog();
            this.btnExcelAktar = new System.Windows.Forms.Button();
            this.cmbYaziciListesi = new System.Windows.Forms.ComboBox();
            this.lblYaziciSecin = new System.Windows.Forms.Label();
            this.lblAlanSecin = new System.Windows.Forms.Label();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnBaskiOnizleme = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRabtBilDB)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRabtBilDB
            // 
            this.dgvRabtBilDB.AllowUserToAddRows = false;
            this.dgvRabtBilDB.AllowUserToOrderColumns = true;
            this.dgvRabtBilDB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRabtBilDB.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRabtBilDB.BackgroundColor = System.Drawing.Color.White;
            this.dgvRabtBilDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRabtBilDB.Location = new System.Drawing.Point(15, 82);
            this.dgvRabtBilDB.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRabtBilDB.MultiSelect = false;
            this.dgvRabtBilDB.Name = "dgvRabtBilDB";
            this.dgvRabtBilDB.ReadOnly = true;
            this.dgvRabtBilDB.RowHeadersVisible = false;
            this.dgvRabtBilDB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRabtBilDB.Size = new System.Drawing.Size(977, 412);
            this.dgvRabtBilDB.TabIndex = 35;
            this.dgvRabtBilDB.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRabtBilDB_CellDoubleClick);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(15, 38);
            this.btnSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(137, 41);
            this.btnSil.TabIndex = 36;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // cmbAramaAlanlari
            // 
            this.cmbAramaAlanlari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAramaAlanlari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAramaAlanlari.FormattingEnabled = true;
            this.cmbAramaAlanlari.Location = new System.Drawing.Point(432, 45);
            this.cmbAramaAlanlari.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAramaAlanlari.Name = "cmbAramaAlanlari";
            this.cmbAramaAlanlari.Size = new System.Drawing.Size(227, 29);
            this.cmbAramaAlanlari.TabIndex = 37;
            this.cmbAramaAlanlari.SelectedIndexChanged += new System.EventHandler(this.cmbAramaAlanlari_SelectedIndexChanged);
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(662, 45);
            this.txtArama.Margin = new System.Windows.Forms.Padding(2);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(330, 29);
            this.txtArama.TabIndex = 38;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // btnYazdir
            // 
            this.btnYazdir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnYazdir.Enabled = false;
            this.btnYazdir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYazdir.ForeColor = System.Drawing.Color.White;
            this.btnYazdir.Location = new System.Drawing.Point(574, 497);
            this.btnYazdir.Margin = new System.Windows.Forms.Padding(2);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(137, 41);
            this.btnYazdir.TabIndex = 39;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = false;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // pdcBelge
            // 
            this.pdcBelge.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdcBelge_PrintPage);
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
            // btnExcelAktar
            // 
            this.btnExcelAktar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExcelAktar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcelAktar.ForeColor = System.Drawing.Color.White;
            this.btnExcelAktar.Location = new System.Drawing.Point(156, 38);
            this.btnExcelAktar.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcelAktar.Name = "btnExcelAktar";
            this.btnExcelAktar.Size = new System.Drawing.Size(137, 41);
            this.btnExcelAktar.TabIndex = 41;
            this.btnExcelAktar.Text = "Excel\'e Aktar";
            this.btnExcelAktar.UseVisualStyleBackColor = false;
            this.btnExcelAktar.Click += new System.EventHandler(this.btnExcelAktar_Click);
            // 
            // cmbYaziciListesi
            // 
            this.cmbYaziciListesi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYaziciListesi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbYaziciListesi.FormattingEnabled = true;
            this.cmbYaziciListesi.Location = new System.Drawing.Point(344, 504);
            this.cmbYaziciListesi.Margin = new System.Windows.Forms.Padding(2);
            this.cmbYaziciListesi.Name = "cmbYaziciListesi";
            this.cmbYaziciListesi.Size = new System.Drawing.Size(227, 29);
            this.cmbYaziciListesi.TabIndex = 42;
            this.cmbYaziciListesi.SelectedIndexChanged += new System.EventHandler(this.cmbYaziciListesi_SelectedIndexChanged);
            // 
            // lblYaziciSecin
            // 
            this.lblYaziciSecin.AutoSize = true;
            this.lblYaziciSecin.Location = new System.Drawing.Point(188, 507);
            this.lblYaziciSecin.Name = "lblYaziciSecin";
            this.lblYaziciSecin.Size = new System.Drawing.Size(152, 21);
            this.lblYaziciSecin.TabIndex = 43;
            this.lblYaziciSecin.Text = "Lütfen Yazıcıyı Seçin:";
            // 
            // lblAlanSecin
            // 
            this.lblAlanSecin.AutoSize = true;
            this.lblAlanSecin.Location = new System.Drawing.Point(297, 48);
            this.lblAlanSecin.Name = "lblAlanSecin";
            this.lblAlanSecin.Size = new System.Drawing.Size(131, 21);
            this.lblAlanSecin.TabIndex = 44;
            this.lblAlanSecin.Text = "Lütfen alan Seçin:";
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lblBaslik.Location = new System.Drawing.Point(15, 9);
            this.lblBaslik.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(177, 25);
            this.lblBaslik.TabIndex = 45;
            this.lblBaslik.Text = "Teknik Servis Formu";
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.White;
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.Image")));
            this.btnKapat.Location = new System.Drawing.Point(982, 1);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(0);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(30, 30);
            this.btnKapat.TabIndex = 46;
            this.btnKapat.TabStop = false;
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnBaskiOnizleme
            // 
            this.btnBaskiOnizleme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBaskiOnizleme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaskiOnizleme.ForeColor = System.Drawing.Color.White;
            this.btnBaskiOnizleme.Location = new System.Drawing.Point(715, 497);
            this.btnBaskiOnizleme.Margin = new System.Windows.Forms.Padding(2);
            this.btnBaskiOnizleme.Name = "btnBaskiOnizleme";
            this.btnBaskiOnizleme.Size = new System.Drawing.Size(137, 41);
            this.btnBaskiOnizleme.TabIndex = 47;
            this.btnBaskiOnizleme.Text = "Baskı Önizleme";
            this.btnBaskiOnizleme.UseVisualStyleBackColor = false;
            this.btnBaskiOnizleme.Click += new System.EventHandler(this.btnBaskiOnizleme_Click);
            // 
            // FrmKayitlariGoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1013, 553);
            this.Controls.Add(this.btnBaskiOnizleme);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.lblAlanSecin);
            this.Controls.Add(this.lblYaziciSecin);
            this.Controls.Add(this.cmbYaziciListesi);
            this.Controls.Add(this.btnExcelAktar);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.cmbAramaAlanlari);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dgvRabtBilDB);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "FrmKayitlariGoster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmKayitlariGoster";
            this.Load += new System.EventHandler(this.FrmKayitlariGoster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRabtBilDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dgvRabtBilDB;
        public System.Windows.Forms.Button btnSil;
        public System.Windows.Forms.ComboBox cmbAramaAlanlari;
        public System.Windows.Forms.TextBox txtArama;
        public System.Windows.Forms.Button btnYazdir;
        private System.Drawing.Printing.PrintDocument pdcBelge;
        private System.Windows.Forms.PrintPreviewDialog ppdBaskiOnizleme;
        public System.Windows.Forms.Button btnExcelAktar;
        public System.Windows.Forms.ComboBox cmbYaziciListesi;
        private System.Windows.Forms.Label lblYaziciSecin;
        private System.Windows.Forms.Label lblAlanSecin;
        private System.Windows.Forms.Label lblBaslik;
        public System.Windows.Forms.Button btnKapat;
        public System.Windows.Forms.Button btnBaskiOnizleme;
    }
}