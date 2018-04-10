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
            this.tsmiAyarlarDil = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAyarlarDilTurkce = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAyarlarDilIngilizce = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAyarlarTema = new System.Windows.Forms.ToolStripMenuItem();
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
            this.btnPdfAktar = new System.Windows.Forms.Button();
            this.tsrKayitlariGoster.SuspendLayout();
            this.mnsKayitlariGoster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRabtBilDB)).BeginInit();
            this.SuspendLayout();
            // 
            // tsrKayitlariGoster
            // 
            this.tsrKayitlariGoster.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsrKayitlariGoster.Font = new System.Drawing.Font("Consolas", 8F);
            this.tsrKayitlariGoster.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TlStripLblAciklama,
            this.tslblTarihSaat});
            this.tsrKayitlariGoster.Location = new System.Drawing.Point(0, 359);
            this.tsrKayitlariGoster.Name = "tsrKayitlariGoster";
            this.tsrKayitlariGoster.Size = new System.Drawing.Size(844, 25);
            this.tsrKayitlariGoster.TabIndex = 34;
            // 
            // TlStripLblAciklama
            // 
            this.TlStripLblAciklama.Name = "TlStripLblAciklama";
            this.TlStripLblAciklama.Size = new System.Drawing.Size(55, 22);
            this.TlStripLblAciklama.Text = "Açıklama";
            // 
            // tslblTarihSaat
            // 
            this.tslblTarihSaat.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tslblTarihSaat.Name = "tslblTarihSaat";
            this.tslblTarihSaat.Size = new System.Drawing.Size(67, 22);
            this.tslblTarihSaat.Text = "Tarih Saat";
            // 
            // mnsKayitlariGoster
            // 
            this.mnsKayitlariGoster.Font = new System.Drawing.Font("Consolas", 8F);
            this.mnsKayitlariGoster.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAyarlar,
            this.tsmiYardım,
            this.tsmiBaskiOnizleme});
            this.mnsKayitlariGoster.Location = new System.Drawing.Point(0, 0);
            this.mnsKayitlariGoster.Name = "mnsKayitlariGoster";
            this.mnsKayitlariGoster.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mnsKayitlariGoster.Size = new System.Drawing.Size(844, 24);
            this.mnsKayitlariGoster.TabIndex = 33;
            // 
            // tsmiAyarlar
            // 
            this.tsmiAyarlar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAyarlarDil,
            this.tsmiAyarlarTema});
            this.tsmiAyarlar.Name = "tsmiAyarlar";
            this.tsmiAyarlar.Size = new System.Drawing.Size(61, 20);
            this.tsmiAyarlar.Text = "Ayarlar";
            // 
            // tsmiAyarlarDil
            // 
            this.tsmiAyarlarDil.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAyarlarDilTurkce,
            this.tsmiAyarlarDilIngilizce});
            this.tsmiAyarlarDil.Name = "tsmiAyarlarDil";
            this.tsmiAyarlarDil.Size = new System.Drawing.Size(98, 22);
            this.tsmiAyarlarDil.Text = "Dil";
            // 
            // tsmiAyarlarDilTurkce
            // 
            this.tsmiAyarlarDilTurkce.Name = "tsmiAyarlarDilTurkce";
            this.tsmiAyarlarDilTurkce.Size = new System.Drawing.Size(128, 22);
            this.tsmiAyarlarDilTurkce.Text = "Türkçe";
            // 
            // tsmiAyarlarDilIngilizce
            // 
            this.tsmiAyarlarDilIngilizce.Name = "tsmiAyarlarDilIngilizce";
            this.tsmiAyarlarDilIngilizce.Size = new System.Drawing.Size(128, 22);
            this.tsmiAyarlarDilIngilizce.Text = "İngilizce";
            // 
            // tsmiAyarlarTema
            // 
            this.tsmiAyarlarTema.Name = "tsmiAyarlarTema";
            this.tsmiAyarlarTema.Size = new System.Drawing.Size(98, 22);
            this.tsmiAyarlarTema.Text = "Tema";
            // 
            // tsmiYardım
            // 
            this.tsmiYardım.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiYardımLisansAnahtarı,
            this.tsmiYardımHakkında});
            this.tsmiYardım.Name = "tsmiYardım";
            this.tsmiYardım.Size = new System.Drawing.Size(55, 20);
            this.tsmiYardım.Text = "Yardım";
            // 
            // tsmiYardımLisansAnahtarı
            // 
            this.tsmiYardımLisansAnahtarı.Name = "tsmiYardımLisansAnahtarı";
            this.tsmiYardımLisansAnahtarı.Size = new System.Drawing.Size(164, 22);
            this.tsmiYardımLisansAnahtarı.Text = "Lisans Anahtarı";
            // 
            // tsmiYardımHakkında
            // 
            this.tsmiYardımHakkında.Name = "tsmiYardımHakkında";
            this.tsmiYardımHakkında.Size = new System.Drawing.Size(164, 22);
            this.tsmiYardımHakkında.Text = "Hakkında";
            // 
            // tsmiBaskiOnizleme
            // 
            this.tsmiBaskiOnizleme.Name = "tsmiBaskiOnizleme";
            this.tsmiBaskiOnizleme.Size = new System.Drawing.Size(103, 20);
            this.tsmiBaskiOnizleme.Text = "Baskı Önizleme";
            this.tsmiBaskiOnizleme.Click += new System.EventHandler(this.tsmiBaskiOnizleme_Click);
            // 
            // dgvRabtBilDB
            // 
            this.dgvRabtBilDB.AllowUserToAddRows = false;
            this.dgvRabtBilDB.AllowUserToOrderColumns = true;
            this.dgvRabtBilDB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRabtBilDB.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRabtBilDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRabtBilDB.Location = new System.Drawing.Point(0, 57);
            this.dgvRabtBilDB.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRabtBilDB.MultiSelect = false;
            this.dgvRabtBilDB.Name = "dgvRabtBilDB";
            this.dgvRabtBilDB.ReadOnly = true;
            this.dgvRabtBilDB.RowHeadersVisible = false;
            this.dgvRabtBilDB.Size = new System.Drawing.Size(844, 304);
            this.dgvRabtBilDB.TabIndex = 35;
            this.dgvRabtBilDB.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRabtBilDB_CellDoubleClick);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(16, 24);
            this.btnSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(100, 29);
            this.btnSil.TabIndex = 36;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // cmbAramaAlanlari
            // 
            this.cmbAramaAlanlari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAramaAlanlari.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbAramaAlanlari.FormattingEnabled = true;
            this.cmbAramaAlanlari.Location = new System.Drawing.Point(378, 28);
            this.cmbAramaAlanlari.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAramaAlanlari.Name = "cmbAramaAlanlari";
            this.cmbAramaAlanlari.Size = new System.Drawing.Size(177, 23);
            this.cmbAramaAlanlari.TabIndex = 37;
            // 
            // txtArama
            // 
            this.txtArama.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtArama.Location = new System.Drawing.Point(559, 28);
            this.txtArama.Margin = new System.Windows.Forms.Padding(2);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(237, 23);
            this.txtArama.TabIndex = 38;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // btnYazdir
            // 
            this.btnYazdir.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazdir.Location = new System.Drawing.Point(120, 24);
            this.btnYazdir.Margin = new System.Windows.Forms.Padding(2);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(100, 29);
            this.btnYazdir.TabIndex = 39;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
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
            this.ppdBaskiOnizleme.Enabled = true;
            this.ppdBaskiOnizleme.Icon = ((System.Drawing.Icon)(resources.GetObject("ppdBaskiOnizleme.Icon")));
            this.ppdBaskiOnizleme.Name = "ppdBaskiOnizleme";
            this.ppdBaskiOnizleme.Visible = false;
            // 
            // btnPdfAktar
            // 
            this.btnPdfAktar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPdfAktar.Location = new System.Drawing.Point(224, 24);
            this.btnPdfAktar.Margin = new System.Windows.Forms.Padding(2);
            this.btnPdfAktar.Name = "btnPdfAktar";
            this.btnPdfAktar.Size = new System.Drawing.Size(100, 29);
            this.btnPdfAktar.TabIndex = 40;
            this.btnPdfAktar.Text = "Pdf\'ye Aktar";
            this.btnPdfAktar.UseVisualStyleBackColor = true;
            // 
            // FrmKayitlariGoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 384);
            this.Controls.Add(this.btnPdfAktar);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.cmbAramaAlanlari);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dgvRabtBilDB);
            this.Controls.Add(this.tsrKayitlariGoster);
            this.Controls.Add(this.mnsKayitlariGoster);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
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
        public System.Windows.Forms.ToolStripMenuItem tsmiAyarlarDil;
        public System.Windows.Forms.ToolStripMenuItem tsmiAyarlarDilTurkce;
        public System.Windows.Forms.ToolStripMenuItem tsmiAyarlarDilIngilizce;
        public System.Windows.Forms.ToolStripMenuItem tsmiAyarlarTema;
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
        public System.Windows.Forms.Button btnPdfAktar;
    }
}