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
            this.tsrKayitlariGoster = new System.Windows.Forms.ToolStrip();
            this.TlStripLblAciklama = new System.Windows.Forms.ToolStripLabel();
            this.tslblTarihSaat = new System.Windows.Forms.ToolStripLabel();
            this.mnsKayitlariGoster = new System.Windows.Forms.MenuStrip();
            this.tsmiAraclar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAraclarYeniKayit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAraclarGuncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAraclarSil = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAyarlar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAyarlarDil = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAyarlarDilTurkce = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAyarlarDilIngilizce = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAyarlarTema = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiYardım = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiYardımLisansAnahtarı = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiYardımHakkında = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBaskiOnizleme = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCıkısYap = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvRabtBilDB = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.cmbAramaAlanlari = new System.Windows.Forms.ComboBox();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.tmrTarihSaat = new System.Windows.Forms.Timer(this.components);
            this.tsrKayitlariGoster.SuspendLayout();
            this.mnsKayitlariGoster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRabtBilDB)).BeginInit();
            this.SuspendLayout();
            // 
            // tsrKayitlariGoster
            // 
            this.tsrKayitlariGoster.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsrKayitlariGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tsrKayitlariGoster.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TlStripLblAciklama,
            this.tslblTarihSaat});
            this.tsrKayitlariGoster.Location = new System.Drawing.Point(0, 436);
            this.tsrKayitlariGoster.Name = "tsrKayitlariGoster";
            this.tsrKayitlariGoster.Size = new System.Drawing.Size(938, 25);
            this.tsrKayitlariGoster.TabIndex = 34;
            // 
            // TlStripLblAciklama
            // 
            this.TlStripLblAciklama.Name = "TlStripLblAciklama";
            this.TlStripLblAciklama.Size = new System.Drawing.Size(57, 22);
            this.TlStripLblAciklama.Text = "Açıklama";
            // 
            // tslblTarihSaat
            // 
            this.tslblTarihSaat.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tslblTarihSaat.Name = "tslblTarihSaat";
            this.tslblTarihSaat.Size = new System.Drawing.Size(63, 22);
            this.tslblTarihSaat.Text = "Tarih Saat";
            // 
            // mnsKayitlariGoster
            // 
            this.mnsKayitlariGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mnsKayitlariGoster.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAraclar,
            this.tsmiAyarlar,
            this.tsmiYardım,
            this.tsmiBaskiOnizleme,
            this.tsmiCıkısYap});
            this.mnsKayitlariGoster.Location = new System.Drawing.Point(0, 0);
            this.mnsKayitlariGoster.Name = "mnsKayitlariGoster";
            this.mnsKayitlariGoster.Size = new System.Drawing.Size(938, 24);
            this.mnsKayitlariGoster.TabIndex = 33;
            // 
            // tsmiAraclar
            // 
            this.tsmiAraclar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAraclarYeniKayit,
            this.tsmiAraclarGuncelle,
            this.tsmiAraclarSil});
            this.tsmiAraclar.Name = "tsmiAraclar";
            this.tsmiAraclar.Size = new System.Drawing.Size(57, 20);
            this.tsmiAraclar.Text = "Araçlar";
            // 
            // tsmiAraclarYeniKayit
            // 
            this.tsmiAraclarYeniKayit.Name = "tsmiAraclarYeniKayit";
            this.tsmiAraclarYeniKayit.Size = new System.Drawing.Size(127, 22);
            this.tsmiAraclarYeniKayit.Text = "Yeni Kayıt";
            this.tsmiAraclarYeniKayit.Click += new System.EventHandler(this.tsmiAraclarYeniKayit_Click);
            // 
            // tsmiAraclarGuncelle
            // 
            this.tsmiAraclarGuncelle.Name = "tsmiAraclarGuncelle";
            this.tsmiAraclarGuncelle.Size = new System.Drawing.Size(127, 22);
            this.tsmiAraclarGuncelle.Text = "Güncelle";
            // 
            // tsmiAraclarSil
            // 
            this.tsmiAraclarSil.Name = "tsmiAraclarSil";
            this.tsmiAraclarSil.Size = new System.Drawing.Size(127, 22);
            this.tsmiAraclarSil.Text = "Sil";
            // 
            // tsmiAyarlar
            // 
            this.tsmiAyarlar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAyarlarDil,
            this.tsmiAyarlarTema});
            this.tsmiAyarlar.Name = "tsmiAyarlar";
            this.tsmiAyarlar.Size = new System.Drawing.Size(56, 20);
            this.tsmiAyarlar.Text = "Ayarlar";
            // 
            // tsmiAyarlarDil
            // 
            this.tsmiAyarlarDil.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAyarlarDilTurkce,
            this.tsmiAyarlarDilIngilizce});
            this.tsmiAyarlarDil.Name = "tsmiAyarlarDil";
            this.tsmiAyarlarDil.Size = new System.Drawing.Size(106, 22);
            this.tsmiAyarlarDil.Text = "Dil";
            // 
            // tsmiAyarlarDilTurkce
            // 
            this.tsmiAyarlarDilTurkce.Name = "tsmiAyarlarDilTurkce";
            this.tsmiAyarlarDilTurkce.Size = new System.Drawing.Size(119, 22);
            this.tsmiAyarlarDilTurkce.Text = "Türkçe";
            // 
            // tsmiAyarlarDilIngilizce
            // 
            this.tsmiAyarlarDilIngilizce.Name = "tsmiAyarlarDilIngilizce";
            this.tsmiAyarlarDilIngilizce.Size = new System.Drawing.Size(119, 22);
            this.tsmiAyarlarDilIngilizce.Text = "İngilizce";
            // 
            // tsmiAyarlarTema
            // 
            this.tsmiAyarlarTema.Name = "tsmiAyarlarTema";
            this.tsmiAyarlarTema.Size = new System.Drawing.Size(106, 22);
            this.tsmiAyarlarTema.Text = "Tema";
            // 
            // tsmiYardım
            // 
            this.tsmiYardım.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiYardımLisansAnahtarı,
            this.tsmiYardımHakkında});
            this.tsmiYardım.Name = "tsmiYardım";
            this.tsmiYardım.Size = new System.Drawing.Size(58, 20);
            this.tsmiYardım.Text = "Yardım";
            // 
            // tsmiYardımLisansAnahtarı
            // 
            this.tsmiYardımLisansAnahtarı.Name = "tsmiYardımLisansAnahtarı";
            this.tsmiYardımLisansAnahtarı.Size = new System.Drawing.Size(158, 22);
            this.tsmiYardımLisansAnahtarı.Text = "Lisans Anahtarı";
            // 
            // tsmiYardımHakkında
            // 
            this.tsmiYardımHakkında.Name = "tsmiYardımHakkında";
            this.tsmiYardımHakkında.Size = new System.Drawing.Size(158, 22);
            this.tsmiYardımHakkında.Text = "Hakkında";
            // 
            // tsmiBaskiOnizleme
            // 
            this.tsmiBaskiOnizleme.Name = "tsmiBaskiOnizleme";
            this.tsmiBaskiOnizleme.Size = new System.Drawing.Size(105, 20);
            this.tsmiBaskiOnizleme.Text = "Baskı Önizleme";
            // 
            // tsmiCıkısYap
            // 
            this.tsmiCıkısYap.Name = "tsmiCıkısYap";
            this.tsmiCıkısYap.Size = new System.Drawing.Size(69, 20);
            this.tsmiCıkısYap.Text = "Çıkış Yap";
            // 
            // dgvRabtBilDB
            // 
            this.dgvRabtBilDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRabtBilDB.Location = new System.Drawing.Point(0, 80);
            this.dgvRabtBilDB.MultiSelect = false;
            this.dgvRabtBilDB.Name = "dgvRabtBilDB";
            this.dgvRabtBilDB.ReadOnly = true;
            this.dgvRabtBilDB.Size = new System.Drawing.Size(938, 351);
            this.dgvRabtBilDB.TabIndex = 35;
            this.dgvRabtBilDB.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRabtBilDB_CellDoubleClick);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(21, 38);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(100, 35);
            this.btnSil.TabIndex = 36;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // cmbAramaAlanlari
            // 
            this.cmbAramaAlanlari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAramaAlanlari.FormattingEnabled = true;
            this.cmbAramaAlanlari.Location = new System.Drawing.Point(252, 43);
            this.cmbAramaAlanlari.Name = "cmbAramaAlanlari";
            this.cmbAramaAlanlari.Size = new System.Drawing.Size(227, 26);
            this.cmbAramaAlanlari.TabIndex = 37;
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(485, 43);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(303, 24);
            this.txtArama.TabIndex = 38;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // btnYazdir
            // 
            this.btnYazdir.Location = new System.Drawing.Point(127, 38);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(100, 35);
            this.btnYazdir.TabIndex = 39;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            // 
            // tmrTarihSaat
            // 
            this.tmrTarihSaat.Tick += new System.EventHandler(this.tmrTarihSaat_Tick);
            // 
            // FrmKayitlariGoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 461);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.cmbAramaAlanlari);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dgvRabtBilDB);
            this.Controls.Add(this.tsrKayitlariGoster);
            this.Controls.Add(this.mnsKayitlariGoster);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmKayitlariGoster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmKayitlariGoster";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmKayitlariGoster_FormClosing);
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
        public System.Windows.Forms.ToolStripMenuItem tsmiAraclar;
        public System.Windows.Forms.ToolStripMenuItem tsmiAraclarYeniKayit;
        public System.Windows.Forms.ToolStripMenuItem tsmiAraclarGuncelle;
        public System.Windows.Forms.ToolStripMenuItem tsmiAraclarSil;
        public System.Windows.Forms.ToolStripMenuItem tsmiAyarlar;
        public System.Windows.Forms.ToolStripMenuItem tsmiAyarlarDil;
        public System.Windows.Forms.ToolStripMenuItem tsmiAyarlarDilTurkce;
        public System.Windows.Forms.ToolStripMenuItem tsmiAyarlarDilIngilizce;
        public System.Windows.Forms.ToolStripMenuItem tsmiAyarlarTema;
        public System.Windows.Forms.ToolStripMenuItem tsmiYardım;
        public System.Windows.Forms.ToolStripMenuItem tsmiYardımLisansAnahtarı;
        public System.Windows.Forms.ToolStripMenuItem tsmiYardımHakkında;
        public System.Windows.Forms.ToolStripMenuItem tsmiBaskiOnizleme;
        public System.Windows.Forms.ToolStripMenuItem tsmiCıkısYap;
        public System.Windows.Forms.DataGridView dgvRabtBilDB;
        public System.Windows.Forms.Button btnSil;
        public System.Windows.Forms.ComboBox cmbAramaAlanlari;
        public System.Windows.Forms.TextBox txtArama;
        public System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Timer tmrTarihSaat;
    }
}