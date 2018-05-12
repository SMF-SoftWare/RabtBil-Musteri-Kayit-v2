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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKayitlariGoster));
            this.tsKayitlariGoster = new System.Windows.Forms.ToolStrip();
            this.tslblAciklama = new System.Windows.Forms.ToolStripLabel();
            this.tslblTarihSaat = new System.Windows.Forms.ToolStripLabel();
            this.mnsKayitlariGoster = new System.Windows.Forms.MenuStrip();
            this.tsmiAyarlar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDil = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTurkce = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiIngilizce = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTema = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiYardım = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLisansAnahtarı = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHakkinda = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBaskiOnizleme = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvRabtBilDB = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.cmbAramaAlanlari = new System.Windows.Forms.ComboBox();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.tmrTarihSaat = new System.Windows.Forms.Timer(this.components);
            this.pdcBelge = new System.Drawing.Printing.PrintDocument();
            this.ppdBaskiOnizleme = new System.Windows.Forms.PrintPreviewDialog();
            this.btnExcelAktar = new System.Windows.Forms.Button();
            this.cmbYaziciListesi = new System.Windows.Forms.ComboBox();
            this.lblYaziciSecin = new System.Windows.Forms.Label();
            this.lblAlanSecin = new System.Windows.Forms.Label();
            this.tsKayitlariGoster.SuspendLayout();
            this.mnsKayitlariGoster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRabtBilDB)).BeginInit();
            this.SuspendLayout();
            // 
            // tsKayitlariGoster
            // 
            this.tsKayitlariGoster.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsKayitlariGoster.Font = new System.Drawing.Font("Consolas", 9F);
            this.tsKayitlariGoster.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblAciklama,
            this.tslblTarihSaat});
            this.tsKayitlariGoster.Location = new System.Drawing.Point(0, 461);
            this.tsKayitlariGoster.Name = "tsKayitlariGoster";
            this.tsKayitlariGoster.Size = new System.Drawing.Size(970, 25);
            this.tsKayitlariGoster.TabIndex = 34;
            // 
            // tslblAciklama
            // 
            this.tslblAciklama.Name = "tslblAciklama";
            this.tslblAciklama.Size = new System.Drawing.Size(63, 22);
            this.tslblAciklama.Text = "Açıklama";
            // 
            // tslblTarihSaat
            // 
            this.tslblTarihSaat.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tslblTarihSaat.Name = "tslblTarihSaat";
            this.tslblTarihSaat.Size = new System.Drawing.Size(77, 22);
            this.tslblTarihSaat.Text = "Tarih Saat";
            // 
            // mnsKayitlariGoster
            // 
            this.mnsKayitlariGoster.Font = new System.Drawing.Font("Consolas", 9F);
            this.mnsKayitlariGoster.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAyarlar,
            this.tsmiYardım,
            this.tsmiBaskiOnizleme});
            this.mnsKayitlariGoster.Location = new System.Drawing.Point(0, 0);
            this.mnsKayitlariGoster.Name = "mnsKayitlariGoster";
            this.mnsKayitlariGoster.Size = new System.Drawing.Size(970, 24);
            this.mnsKayitlariGoster.TabIndex = 33;
            // 
            // tsmiAyarlar
            // 
            this.tsmiAyarlar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDil,
            this.tsmiTema});
            this.tsmiAyarlar.Name = "tsmiAyarlar";
            this.tsmiAyarlar.Size = new System.Drawing.Size(68, 20);
            this.tsmiAyarlar.Text = "Ayarlar";
            // 
            // tsmiDil
            // 
            this.tsmiDil.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTurkce,
            this.tsmiIngilizce});
            this.tsmiDil.Name = "tsmiDil";
            this.tsmiDil.Size = new System.Drawing.Size(102, 22);
            this.tsmiDil.Text = "Dil";
            this.tsmiDil.MouseLeave += new System.EventHandler(this.varsayilanAciklama_MouseLeave);
            // 
            // tsmiTurkce
            // 
            this.tsmiTurkce.Name = "tsmiTurkce";
            this.tsmiTurkce.Size = new System.Drawing.Size(137, 22);
            this.tsmiTurkce.Text = "Türkçe";
            // 
            // tsmiIngilizce
            // 
            this.tsmiIngilizce.Name = "tsmiIngilizce";
            this.tsmiIngilizce.Size = new System.Drawing.Size(137, 22);
            this.tsmiIngilizce.Text = "İngilizce";
            // 
            // tsmiTema
            // 
            this.tsmiTema.Name = "tsmiTema";
            this.tsmiTema.Size = new System.Drawing.Size(102, 22);
            this.tsmiTema.Text = "Tema";
            this.tsmiTema.MouseLeave += new System.EventHandler(this.varsayilanAciklama_MouseLeave);
            // 
            // tsmiYardım
            // 
            this.tsmiYardım.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLisansAnahtarı,
            this.tsmiHakkinda});
            this.tsmiYardım.Name = "tsmiYardım";
            this.tsmiYardım.Size = new System.Drawing.Size(61, 20);
            this.tsmiYardım.Text = "Yardım";
            // 
            // tsmiLisansAnahtarı
            // 
            this.tsmiLisansAnahtarı.Name = "tsmiLisansAnahtarı";
            this.tsmiLisansAnahtarı.Size = new System.Drawing.Size(179, 22);
            this.tsmiLisansAnahtarı.Text = "Lisans Anahtarı";
            this.tsmiLisansAnahtarı.MouseLeave += new System.EventHandler(this.varsayilanAciklama_MouseLeave);
            // 
            // tsmiHakkinda
            // 
            this.tsmiHakkinda.Name = "tsmiHakkinda";
            this.tsmiHakkinda.Size = new System.Drawing.Size(179, 22);
            this.tsmiHakkinda.Text = "Hakkında";
            this.tsmiHakkinda.Click += new System.EventHandler(this.tsmiYardımHakkında_Click_1);
            this.tsmiHakkinda.MouseLeave += new System.EventHandler(this.varsayilanAciklama_MouseLeave);
            // 
            // tsmiBaskiOnizleme
            // 
            this.tsmiBaskiOnizleme.Name = "tsmiBaskiOnizleme";
            this.tsmiBaskiOnizleme.Size = new System.Drawing.Size(117, 20);
            this.tsmiBaskiOnizleme.Text = "Baskı Önizleme";
            this.tsmiBaskiOnizleme.Click += new System.EventHandler(this.tsmiBaskiOnizleme_Click);
            this.tsmiBaskiOnizleme.MouseLeave += new System.EventHandler(this.varsayilanAciklama_MouseLeave);
            // 
            // dgvRabtBilDB
            // 
            this.dgvRabtBilDB.AllowUserToAddRows = false;
            this.dgvRabtBilDB.AllowUserToOrderColumns = true;
            this.dgvRabtBilDB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRabtBilDB.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRabtBilDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRabtBilDB.Location = new System.Drawing.Point(11, 68);
            this.dgvRabtBilDB.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRabtBilDB.MultiSelect = false;
            this.dgvRabtBilDB.Name = "dgvRabtBilDB";
            this.dgvRabtBilDB.ReadOnly = true;
            this.dgvRabtBilDB.RowHeadersVisible = false;
            this.dgvRabtBilDB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRabtBilDB.Size = new System.Drawing.Size(948, 353);
            this.dgvRabtBilDB.TabIndex = 35;
            this.dgvRabtBilDB.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRabtBilDB_CellDoubleClick);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Consolas", 11F);
            this.btnSil.Location = new System.Drawing.Point(11, 29);
            this.btnSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(122, 35);
            this.btnSil.TabIndex = 36;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            this.btnSil.MouseLeave += new System.EventHandler(this.varsayilanAciklama_MouseLeave);
            // 
            // cmbAramaAlanlari
            // 
            this.cmbAramaAlanlari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAramaAlanlari.Font = new System.Drawing.Font("Consolas", 11F);
            this.cmbAramaAlanlari.FormattingEnabled = true;
            this.cmbAramaAlanlari.Location = new System.Drawing.Point(485, 34);
            this.cmbAramaAlanlari.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAramaAlanlari.Name = "cmbAramaAlanlari";
            this.cmbAramaAlanlari.Size = new System.Drawing.Size(202, 26);
            this.cmbAramaAlanlari.TabIndex = 37;
            this.cmbAramaAlanlari.MouseLeave += new System.EventHandler(this.varsayilanAciklama_MouseLeave);
            // 
            // txtArama
            // 
            this.txtArama.Font = new System.Drawing.Font("Consolas", 11F);
            this.txtArama.Location = new System.Drawing.Point(692, 34);
            this.txtArama.Margin = new System.Windows.Forms.Padding(2);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(267, 25);
            this.txtArama.TabIndex = 38;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // btnYazdir
            // 
            this.btnYazdir.Enabled = false;
            this.btnYazdir.Font = new System.Drawing.Font("Consolas", 11F);
            this.btnYazdir.Location = new System.Drawing.Point(590, 424);
            this.btnYazdir.Margin = new System.Windows.Forms.Padding(2);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(122, 35);
            this.btnYazdir.TabIndex = 39;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            this.btnYazdir.MouseLeave += new System.EventHandler(this.varsayilanAciklama_MouseLeave);
            // 
            // tmrTarihSaat
            // 
            this.tmrTarihSaat.Tick += new System.EventHandler(this.tmrTarihSaat_Tick);
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
            this.btnExcelAktar.Font = new System.Drawing.Font("Consolas", 11F);
            this.btnExcelAktar.Location = new System.Drawing.Point(138, 29);
            this.btnExcelAktar.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcelAktar.Name = "btnExcelAktar";
            this.btnExcelAktar.Size = new System.Drawing.Size(122, 35);
            this.btnExcelAktar.TabIndex = 41;
            this.btnExcelAktar.Text = "Excel\'e Aktar";
            this.btnExcelAktar.UseVisualStyleBackColor = true;
            this.btnExcelAktar.Click += new System.EventHandler(this.btnExcelAktar_Click);
            this.btnExcelAktar.MouseLeave += new System.EventHandler(this.varsayilanAciklama_MouseLeave);
            // 
            // cmbYaziciListesi
            // 
            this.cmbYaziciListesi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYaziciListesi.Font = new System.Drawing.Font("Consolas", 11F);
            this.cmbYaziciListesi.FormattingEnabled = true;
            this.cmbYaziciListesi.Location = new System.Drawing.Point(384, 430);
            this.cmbYaziciListesi.Margin = new System.Windows.Forms.Padding(2);
            this.cmbYaziciListesi.Name = "cmbYaziciListesi";
            this.cmbYaziciListesi.Size = new System.Drawing.Size(202, 26);
            this.cmbYaziciListesi.TabIndex = 42;
            this.cmbYaziciListesi.SelectedIndexChanged += new System.EventHandler(this.cmbYaziciListesi_SelectedIndexChanged);
            this.cmbYaziciListesi.MouseLeave += new System.EventHandler(this.varsayilanAciklama_MouseLeave);
            // 
            // lblYaziciSecin
            // 
            this.lblYaziciSecin.AutoSize = true;
            this.lblYaziciSecin.Font = new System.Drawing.Font("Consolas", 9F);
            this.lblYaziciSecin.Location = new System.Drawing.Point(218, 435);
            this.lblYaziciSecin.Name = "lblYaziciSecin";
            this.lblYaziciSecin.Size = new System.Drawing.Size(161, 14);
            this.lblYaziciSecin.TabIndex = 43;
            this.lblYaziciSecin.Text = "Lütfen Yazıcıyı Seçin:";
            // 
            // lblAlanSecin
            // 
            this.lblAlanSecin.AutoSize = true;
            this.lblAlanSecin.Font = new System.Drawing.Font("Consolas", 9F);
            this.lblAlanSecin.Location = new System.Drawing.Point(347, 40);
            this.lblAlanSecin.Name = "lblAlanSecin";
            this.lblAlanSecin.Size = new System.Drawing.Size(133, 14);
            this.lblAlanSecin.TabIndex = 44;
            this.lblAlanSecin.Text = "Lütfen alan Seçin:";
            // 
            // FrmKayitlariGoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 486);
            this.Controls.Add(this.lblAlanSecin);
            this.Controls.Add(this.lblYaziciSecin);
            this.Controls.Add(this.cmbYaziciListesi);
            this.Controls.Add(this.btnExcelAktar);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.cmbAramaAlanlari);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dgvRabtBilDB);
            this.Controls.Add(this.tsKayitlariGoster);
            this.Controls.Add(this.mnsKayitlariGoster);
            this.Font = new System.Drawing.Font("Consolas", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimizeBox = false;
            this.Name = "FrmKayitlariGoster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmKayitlariGoster";
            this.Load += new System.EventHandler(this.FrmKayitlariGoster_Load);
            this.tsKayitlariGoster.ResumeLayout(false);
            this.tsKayitlariGoster.PerformLayout();
            this.mnsKayitlariGoster.ResumeLayout(false);
            this.mnsKayitlariGoster.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRabtBilDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ToolStrip tsKayitlariGoster;
        public System.Windows.Forms.ToolStripLabel tslblAciklama;
        public System.Windows.Forms.ToolStripLabel tslblTarihSaat;
        public System.Windows.Forms.MenuStrip mnsKayitlariGoster;
        public System.Windows.Forms.ToolStripMenuItem tsmiAyarlar;
        public System.Windows.Forms.ToolStripMenuItem tsmiDil;
        public System.Windows.Forms.ToolStripMenuItem tsmiTurkce;
        public System.Windows.Forms.ToolStripMenuItem tsmiIngilizce;
        public System.Windows.Forms.ToolStripMenuItem tsmiTema;
        public System.Windows.Forms.ToolStripMenuItem tsmiYardım;
        public System.Windows.Forms.ToolStripMenuItem tsmiLisansAnahtarı;
        public System.Windows.Forms.ToolStripMenuItem tsmiHakkinda;
        public System.Windows.Forms.ToolStripMenuItem tsmiBaskiOnizleme;
        public System.Windows.Forms.DataGridView dgvRabtBilDB;
        public System.Windows.Forms.Button btnSil;
        public System.Windows.Forms.ComboBox cmbAramaAlanlari;
        public System.Windows.Forms.TextBox txtArama;
        public System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Timer tmrTarihSaat;
        private System.Drawing.Printing.PrintDocument pdcBelge;
        private System.Windows.Forms.PrintPreviewDialog ppdBaskiOnizleme;
        public System.Windows.Forms.Button btnExcelAktar;
        public System.Windows.Forms.ComboBox cmbYaziciListesi;
        private System.Windows.Forms.Label lblYaziciSecin;
        private System.Windows.Forms.Label lblAlanSecin;
    }
}