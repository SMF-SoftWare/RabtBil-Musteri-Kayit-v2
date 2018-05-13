namespace RabtBil_Musteri_Kayit_v2
{
    partial class FrmPersonelEkle
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
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.dgvKullanicilar = new System.Windows.Forms.DataGridView();
            this.lblEpostaAdresi = new System.Windows.Forms.Label();
            this.txtEpostaAdresi = new System.Windows.Forms.TextBox();
            this.lblSoyadi = new System.Windows.Forms.Label();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.lblAdi = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.lblSifreyiOnayla = new System.Windows.Forms.Label();
            this.txtSifreyiOnayla = new System.Windows.Forms.TextBox();
            this.lblPersonelRolu = new System.Windows.Forms.Label();
            this.cmbRoller = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.pbxEye = new System.Windows.Forms.PictureBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanicilar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEye)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Consolas", 9F);
            this.lblKullaniciAdi.Location = new System.Drawing.Point(14, 20);
            this.lblKullaniciAdi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(105, 14);
            this.lblKullaniciAdi.TabIndex = 13;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Consolas", 11F);
            this.txtKullaniciAdi.Location = new System.Drawing.Point(123, 14);
            this.txtKullaniciAdi.Margin = new System.Windows.Forms.Padding(2);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(185, 25);
            this.txtKullaniciAdi.TabIndex = 1;
            // 
            // dgvKullanicilar
            // 
            this.dgvKullanicilar.AllowUserToAddRows = false;
            this.dgvKullanicilar.AllowUserToOrderColumns = true;
            this.dgvKullanicilar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvKullanicilar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvKullanicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKullanicilar.Location = new System.Drawing.Point(314, 14);
            this.dgvKullanicilar.MultiSelect = false;
            this.dgvKullanicilar.Name = "dgvKullanicilar";
            this.dgvKullanicilar.ReadOnly = true;
            this.dgvKullanicilar.RowHeadersVisible = false;
            this.dgvKullanicilar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKullanicilar.Size = new System.Drawing.Size(481, 294);
            this.dgvKullanicilar.TabIndex = 13;
            this.dgvKullanicilar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvKullanicilar_MouseDoubleClick);
            // 
            // lblEpostaAdresi
            // 
            this.lblEpostaAdresi.AutoSize = true;
            this.lblEpostaAdresi.Font = new System.Drawing.Font("Consolas", 9F);
            this.lblEpostaAdresi.Location = new System.Drawing.Point(7, 107);
            this.lblEpostaAdresi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEpostaAdresi.Name = "lblEpostaAdresi";
            this.lblEpostaAdresi.Size = new System.Drawing.Size(112, 14);
            this.lblEpostaAdresi.TabIndex = 31;
            this.lblEpostaAdresi.Text = "E-posta Adresi:";
            // 
            // txtEpostaAdresi
            // 
            this.txtEpostaAdresi.Font = new System.Drawing.Font("Consolas", 11F);
            this.txtEpostaAdresi.Location = new System.Drawing.Point(123, 102);
            this.txtEpostaAdresi.Margin = new System.Windows.Forms.Padding(2);
            this.txtEpostaAdresi.Name = "txtEpostaAdresi";
            this.txtEpostaAdresi.Size = new System.Drawing.Size(186, 25);
            this.txtEpostaAdresi.TabIndex = 4;
            // 
            // lblSoyadi
            // 
            this.lblSoyadi.AutoSize = true;
            this.lblSoyadi.Font = new System.Drawing.Font("Consolas", 9F);
            this.lblSoyadi.Location = new System.Drawing.Point(63, 78);
            this.lblSoyadi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoyadi.Name = "lblSoyadi";
            this.lblSoyadi.Size = new System.Drawing.Size(56, 14);
            this.lblSoyadi.TabIndex = 30;
            this.lblSoyadi.Text = "Soyadı:";
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Font = new System.Drawing.Font("Consolas", 11F);
            this.txtSoyadi.Location = new System.Drawing.Point(123, 72);
            this.txtSoyadi.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(185, 25);
            this.txtSoyadi.TabIndex = 3;
            // 
            // lblAdi
            // 
            this.lblAdi.AutoSize = true;
            this.lblAdi.Font = new System.Drawing.Font("Consolas", 9F);
            this.lblAdi.Location = new System.Drawing.Point(84, 49);
            this.lblAdi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdi.Name = "lblAdi";
            this.lblAdi.Size = new System.Drawing.Size(35, 14);
            this.lblAdi.TabIndex = 29;
            this.lblAdi.Text = "Adı:";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Consolas", 9F);
            this.lblSifre.Location = new System.Drawing.Point(70, 136);
            this.lblSifre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(49, 14);
            this.lblSifre.TabIndex = 28;
            this.lblSifre.Text = "Şifre:";
            // 
            // txtAdi
            // 
            this.txtAdi.Font = new System.Drawing.Font("Consolas", 11F);
            this.txtAdi.Location = new System.Drawing.Point(123, 43);
            this.txtAdi.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(185, 25);
            this.txtAdi.TabIndex = 2;
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Consolas", 11F);
            this.txtSifre.Location = new System.Drawing.Point(123, 130);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(2);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(185, 25);
            this.txtSifre.TabIndex = 5;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // lblSifreyiOnayla
            // 
            this.lblSifreyiOnayla.AutoSize = true;
            this.lblSifreyiOnayla.Font = new System.Drawing.Font("Consolas", 9F);
            this.lblSifreyiOnayla.Location = new System.Drawing.Point(7, 165);
            this.lblSifreyiOnayla.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSifreyiOnayla.Name = "lblSifreyiOnayla";
            this.lblSifreyiOnayla.Size = new System.Drawing.Size(112, 14);
            this.lblSifreyiOnayla.TabIndex = 33;
            this.lblSifreyiOnayla.Text = "Şifreyi Onayla:";
            // 
            // txtSifreyiOnayla
            // 
            this.txtSifreyiOnayla.Font = new System.Drawing.Font("Consolas", 11F);
            this.txtSifreyiOnayla.Location = new System.Drawing.Point(123, 159);
            this.txtSifreyiOnayla.Margin = new System.Windows.Forms.Padding(2);
            this.txtSifreyiOnayla.Name = "txtSifreyiOnayla";
            this.txtSifreyiOnayla.Size = new System.Drawing.Size(185, 25);
            this.txtSifreyiOnayla.TabIndex = 6;
            this.txtSifreyiOnayla.UseSystemPasswordChar = true;
            // 
            // lblPersonelRolu
            // 
            this.lblPersonelRolu.AutoSize = true;
            this.lblPersonelRolu.Font = new System.Drawing.Font("Consolas", 9F);
            this.lblPersonelRolu.Location = new System.Drawing.Point(14, 195);
            this.lblPersonelRolu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPersonelRolu.Name = "lblPersonelRolu";
            this.lblPersonelRolu.Size = new System.Drawing.Size(105, 14);
            this.lblPersonelRolu.TabIndex = 34;
            this.lblPersonelRolu.Text = "Personel Rolü:";
            // 
            // cmbRoller
            // 
            this.cmbRoller.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoller.Font = new System.Drawing.Font("Consolas", 11F);
            this.cmbRoller.FormattingEnabled = true;
            this.cmbRoller.Location = new System.Drawing.Point(123, 189);
            this.cmbRoller.Name = "cmbRoller";
            this.cmbRoller.Size = new System.Drawing.Size(185, 26);
            this.cmbRoller.TabIndex = 8;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Consolas", 11F);
            this.btnEkle.Location = new System.Drawing.Point(16, 226);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(144, 40);
            this.btnEkle.TabIndex = 9;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Enabled = false;
            this.btnGuncelle.Font = new System.Drawing.Font("Consolas", 11F);
            this.btnGuncelle.Location = new System.Drawing.Point(164, 226);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(144, 40);
            this.btnGuncelle.TabIndex = 10;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Consolas", 11F);
            this.btnSil.Location = new System.Drawing.Point(17, 269);
            this.btnSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(144, 40);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // pbxEye
            // 
            this.pbxEye.Image = global::RabtBil_Musteri_Kayit_v2.Properties.Resources.eye;
            this.pbxEye.Location = new System.Drawing.Point(279, 133);
            this.pbxEye.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbxEye.Name = "pbxEye";
            this.pbxEye.Size = new System.Drawing.Size(28, 20);
            this.pbxEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxEye.TabIndex = 35;
            this.pbxEye.TabStop = false;
            this.pbxEye.Click += new System.EventHandler(this.pbxEye_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Consolas", 11F);
            this.btnTemizle.Location = new System.Drawing.Point(164, 269);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(2);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(144, 40);
            this.btnTemizle.TabIndex = 12;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // FrmPersonelEkle
            // 
            this.AcceptButton = this.btnEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 320);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.pbxEye);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.cmbRoller);
            this.Controls.Add(this.lblPersonelRolu);
            this.Controls.Add(this.lblSifreyiOnayla);
            this.Controls.Add(this.txtSifreyiOnayla);
            this.Controls.Add(this.lblEpostaAdresi);
            this.Controls.Add(this.txtEpostaAdresi);
            this.Controls.Add(this.lblSoyadi);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.lblAdi);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.dgvKullanicilar);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.txtKullaniciAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmPersonelEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPersonelEkle";
            this.Load += new System.EventHandler(this.FrmPersonelEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanicilar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblKullaniciAdi;
        public System.Windows.Forms.TextBox txtKullaniciAdi;
        public System.Windows.Forms.Label lblEpostaAdresi;
        public System.Windows.Forms.TextBox txtEpostaAdresi;
        public System.Windows.Forms.Label lblSoyadi;
        public System.Windows.Forms.TextBox txtSoyadi;
        public System.Windows.Forms.Label lblAdi;
        public System.Windows.Forms.Label lblSifre;
        public System.Windows.Forms.TextBox txtAdi;
        public System.Windows.Forms.TextBox txtSifre;
        public System.Windows.Forms.Label lblSifreyiOnayla;
        public System.Windows.Forms.TextBox txtSifreyiOnayla;
        public System.Windows.Forms.Label lblPersonelRolu;
        private System.Windows.Forms.ComboBox cmbRoller;
        public System.Windows.Forms.Button btnEkle;
        public System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.DataGridView dgvKullanicilar;
        public System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.PictureBox pbxEye;
        public System.Windows.Forms.Button btnTemizle;
    }
}