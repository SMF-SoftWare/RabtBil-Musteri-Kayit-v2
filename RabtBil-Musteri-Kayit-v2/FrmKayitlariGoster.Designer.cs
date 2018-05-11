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
            this.tsrKayitlariGoster = new System.Windows.Forms.ToolStrip();
            this.TlStripLblAciklama = new System.Windows.Forms.ToolStripLabel();
            this.tslblTarihSaat = new System.Windows.Forms.ToolStripLabel();
            this.mnsKayitlariGoster = new System.Windows.Forms.MenuStrip();
            this.tsmiAyarlar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDil = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTurkce = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiIngilizce = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTema = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiYardım = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiYardımLisansAnahtarı = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiYardımHakkında = new System.Windows.Forms.ToolStripMenuItem();
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tsrKayitlariGoster.SuspendLayout();
            this.mnsKayitlariGoster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRabtBilDB)).BeginInit();
            this.SuspendLayout();
            // 
            // tsrKayitlariGoster
            // 
            this.tsrKayitlariGoster.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsrKayitlariGoster.Font = new System.Drawing.Font("Consolas", 9F);
            this.tsrKayitlariGoster.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TlStripLblAciklama,
            this.tslblTarihSaat});
            this.tsrKayitlariGoster.Location = new System.Drawing.Point(0, 461);
            this.tsrKayitlariGoster.Name = "tsrKayitlariGoster";
            this.tsrKayitlariGoster.Size = new System.Drawing.Size(970, 25);
            this.tsrKayitlariGoster.TabIndex = 34;
            // 
            // TlStripLblAciklama
            // 
            this.TlStripLblAciklama.Name = "TlStripLblAciklama";
            this.TlStripLblAciklama.Size = new System.Drawing.Size(63, 22);
            this.TlStripLblAciklama.Text = "Açıklama";
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
            this.tsmiDil.Size = new System.Drawing.Size(180, 22);
            this.tsmiDil.Text = "Dil";
            this.tsmiDil.MouseLeave += new System.EventHandler(this.varsayilanAciklama_MouseLeave);
            this.tsmiDil.MouseHover += new System.EventHandler(this.tsmiAyarlarDil_MouseHover);
            // 
            // tsmiTurkce
            // 
            this.tsmiTurkce.Name = "tsmiTurkce";
            this.tsmiTurkce.Size = new System.Drawing.Size(180, 22);
            this.tsmiTurkce.Text = "Türkçe";
            // 
            // tsmiIngilizce
            // 
            this.tsmiIngilizce.Name = "tsmiIngilizce";
            this.tsmiIngilizce.Size = new System.Drawing.Size(180, 22);
            this.tsmiIngilizce.Text = "İngilizce";
            // 
            // tsmiTema
            // 
            this.tsmiTema.Name = "tsmiTema";
            this.tsmiTema.Size = new System.Drawing.Size(180, 22);
            this.tsmiTema.Text = "Tema";
            this.tsmiTema.MouseLeave += new System.EventHandler(this.varsayilanAciklama_MouseLeave);
            this.tsmiTema.MouseHover += new System.EventHandler(this.tsmiAyarlarTema_MouseHover);
            // 
            // tsmiYardım
            // 
            this.tsmiYardım.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiYardımLisansAnahtarı,
            this.tsmiYardımHakkında});
            this.tsmiYardım.Name = "tsmiYardım";
            this.tsmiYardım.Size = new System.Drawing.Size(61, 20);
            this.tsmiYardım.Text = "Yardım";
            // 
            // tsmiYardımLisansAnahtarı
            // 
            this.tsmiYardımLisansAnahtarı.Name = "tsmiYardımLisansAnahtarı";
            this.tsmiYardımLisansAnahtarı.Size = new System.Drawing.Size(180, 22);
            this.tsmiYardımLisansAnahtarı.Text = "Lisans Anahtarı";
            this.tsmiYardımLisansAnahtarı.MouseLeave += new System.EventHandler(this.varsayilanAciklama_MouseLeave);
            this.tsmiYardımLisansAnahtarı.MouseHover += new System.EventHandler(this.tsmiYardımLisansAnahtarı_MouseHover);
            // 
            // tsmiYardımHakkında
            // 
            this.tsmiYardımHakkında.Name = "tsmiYardımHakkında";
            this.tsmiYardımHakkında.Size = new System.Drawing.Size(180, 22);
            this.tsmiYardımHakkında.Text = "Hakkında";
            this.tsmiYardımHakkında.Click += new System.EventHandler(this.tsmiYardımHakkında_Click_1);
            this.tsmiYardımHakkında.MouseLeave += new System.EventHandler(this.varsayilanAciklama_MouseLeave);
            this.tsmiYardımHakkında.MouseHover += new System.EventHandler(this.tsmiYardımHakkında_MouseHover);
            // 
            // tsmiBaskiOnizleme
            // 
            this.tsmiBaskiOnizleme.Name = "tsmiBaskiOnizleme";
            this.tsmiBaskiOnizleme.Size = new System.Drawing.Size(117, 20);
            this.tsmiBaskiOnizleme.Text = "Baskı Önizleme";
            this.tsmiBaskiOnizleme.Click += new System.EventHandler(this.tsmiBaskiOnizleme_Click);
            this.tsmiBaskiOnizleme.MouseLeave += new System.EventHandler(this.varsayilanAciklama_MouseLeave);
            this.tsmiBaskiOnizleme.MouseHover += new System.EventHandler(this.tsmiBaskiOnizleme_MouseHover);
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
            this.btnSil.MouseHover += new System.EventHandler(this.btnSil_MouseHover);
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
            this.cmbAramaAlanlari.MouseHover += new System.EventHandler(this.cmbAramaAlanlari_MouseHover);
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
            this.btnYazdir.MouseHover += new System.EventHandler(this.btnYazdir_MouseHover);
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
            this.btnExcelAktar.MouseHover += new System.EventHandler(this.btnExcelAktar_MouseHover);
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
            this.cmbYaziciListesi.MouseHover += new System.EventHandler(this.cmbYaziciListesi_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9F);
            this.label1.Location = new System.Drawing.Point(218, 435);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 14);
            this.label1.TabIndex = 43;
            this.label1.Text = "Lütfen Yazıcıyı Seçin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9F);
            this.label2.Location = new System.Drawing.Point(347, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 14);
            this.label2.TabIndex = 44;
            this.label2.Text = "Lütfen alan Seçin:";
            // 
            // FrmKayitlariGoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 486);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbYaziciListesi);
            this.Controls.Add(this.btnExcelAktar);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.cmbAramaAlanlari);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dgvRabtBilDB);
            this.Controls.Add(this.tsrKayitlariGoster);
            this.Controls.Add(this.mnsKayitlariGoster);
            this.Font = new System.Drawing.Font("Consolas", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimizeBox = false;
            this.Name = "FrmKayitlariGoster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmKayitlariGoster";
            this.Load += new System.EventHandler(this.FrmKayitlariGoster_Load);
            this.tsrKayitlariGoster.ResumeLayout(false);
            this.tsrKayitlariGoster.PerformLayout();
            this.mnsKayitlariGoster.ResumeLayout(false);
            this.mnsKayitlariGoster.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRabtBilDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ToolStrip tsrKayitlariGoster;
        public System.Windows.Forms.ToolStripLabel TlStripLblAciklama;
        public System.Windows.Forms.ToolStripLabel tslblTarihSaat;
        public System.Windows.Forms.MenuStrip mnsKayitlariGoster;
        public System.Windows.Forms.ToolStripMenuItem tsmiAyarlar;
        public System.Windows.Forms.ToolStripMenuItem tsmiDil;
        public System.Windows.Forms.ToolStripMenuItem tsmiTurkce;
        public System.Windows.Forms.ToolStripMenuItem tsmiIngilizce;
        public System.Windows.Forms.ToolStripMenuItem tsmiTema;
        public System.Windows.Forms.ToolStripMenuItem tsmiYardım;
        public System.Windows.Forms.ToolStripMenuItem tsmiYardımLisansAnahtarı;
        public System.Windows.Forms.ToolStripMenuItem tsmiYardımHakkında;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}