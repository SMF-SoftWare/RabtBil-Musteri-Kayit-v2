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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonelEkle));
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
            this.picGoz = new System.Windows.Forms.PictureBox();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.btnKapat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanicilar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGoz)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(15, 39);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(98, 21);
            this.lblKullaniciAdi.TabIndex = 13;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.BackColor = System.Drawing.Color.White;
            this.txtKullaniciAdi.ForeColor = System.Drawing.Color.Black;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(15, 64);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(276, 29);
            this.txtKullaniciAdi.TabIndex = 0;
            // 
            // dgvKullanicilar
            // 
            this.dgvKullanicilar.AllowUserToAddRows = false;
            this.dgvKullanicilar.AllowUserToOrderColumns = true;
            this.dgvKullanicilar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvKullanicilar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvKullanicilar.BackgroundColor = System.Drawing.Color.White;
            this.dgvKullanicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKullanicilar.Location = new System.Drawing.Point(309, 39);
            this.dgvKullanicilar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvKullanicilar.MultiSelect = false;
            this.dgvKullanicilar.Name = "dgvKullanicilar";
            this.dgvKullanicilar.ReadOnly = true;
            this.dgvKullanicilar.RowHeadersVisible = false;
            this.dgvKullanicilar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKullanicilar.Size = new System.Drawing.Size(538, 402);
            this.dgvKullanicilar.TabIndex = 10;
            this.dgvKullanicilar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvKullanicilar_MouseDoubleClick);
            // 
            // lblEpostaAdresi
            // 
            this.lblEpostaAdresi.AutoSize = true;
            this.lblEpostaAdresi.Location = new System.Drawing.Point(15, 213);
            this.lblEpostaAdresi.Name = "lblEpostaAdresi";
            this.lblEpostaAdresi.Size = new System.Drawing.Size(113, 21);
            this.lblEpostaAdresi.TabIndex = 31;
            this.lblEpostaAdresi.Text = "E-posta Adresi:";
            // 
            // txtEpostaAdresi
            // 
            this.txtEpostaAdresi.BackColor = System.Drawing.Color.White;
            this.txtEpostaAdresi.ForeColor = System.Drawing.Color.Black;
            this.txtEpostaAdresi.Location = new System.Drawing.Point(15, 238);
            this.txtEpostaAdresi.Name = "txtEpostaAdresi";
            this.txtEpostaAdresi.Size = new System.Drawing.Size(277, 29);
            this.txtEpostaAdresi.TabIndex = 3;
            // 
            // lblSoyadi
            // 
            this.lblSoyadi.AutoSize = true;
            this.lblSoyadi.Location = new System.Drawing.Point(15, 155);
            this.lblSoyadi.Name = "lblSoyadi";
            this.lblSoyadi.Size = new System.Drawing.Size(60, 21);
            this.lblSoyadi.TabIndex = 30;
            this.lblSoyadi.Text = "Soyadı:";
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.BackColor = System.Drawing.Color.White;
            this.txtSoyadi.ForeColor = System.Drawing.Color.Black;
            this.txtSoyadi.Location = new System.Drawing.Point(15, 180);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(276, 29);
            this.txtSoyadi.TabIndex = 2;
            // 
            // lblAdi
            // 
            this.lblAdi.AutoSize = true;
            this.lblAdi.Location = new System.Drawing.Point(15, 97);
            this.lblAdi.Name = "lblAdi";
            this.lblAdi.Size = new System.Drawing.Size(36, 21);
            this.lblAdi.TabIndex = 29;
            this.lblAdi.Text = "Adı:";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(15, 271);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(45, 21);
            this.lblSifre.TabIndex = 28;
            this.lblSifre.Text = "Şifre:";
            // 
            // txtAdi
            // 
            this.txtAdi.BackColor = System.Drawing.Color.White;
            this.txtAdi.ForeColor = System.Drawing.Color.Black;
            this.txtAdi.Location = new System.Drawing.Point(15, 122);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(276, 29);
            this.txtAdi.TabIndex = 1;
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.White;
            this.txtSifre.ForeColor = System.Drawing.Color.Black;
            this.txtSifre.Location = new System.Drawing.Point(15, 296);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(276, 29);
            this.txtSifre.TabIndex = 4;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // lblSifreyiOnayla
            // 
            this.lblSifreyiOnayla.AutoSize = true;
            this.lblSifreyiOnayla.Location = new System.Drawing.Point(15, 329);
            this.lblSifreyiOnayla.Name = "lblSifreyiOnayla";
            this.lblSifreyiOnayla.Size = new System.Drawing.Size(110, 21);
            this.lblSifreyiOnayla.TabIndex = 33;
            this.lblSifreyiOnayla.Text = "Şifreyi Onayla:";
            // 
            // txtSifreyiOnayla
            // 
            this.txtSifreyiOnayla.BackColor = System.Drawing.Color.White;
            this.txtSifreyiOnayla.ForeColor = System.Drawing.Color.Black;
            this.txtSifreyiOnayla.Location = new System.Drawing.Point(15, 354);
            this.txtSifreyiOnayla.Name = "txtSifreyiOnayla";
            this.txtSifreyiOnayla.Size = new System.Drawing.Size(276, 29);
            this.txtSifreyiOnayla.TabIndex = 5;
            this.txtSifreyiOnayla.UseSystemPasswordChar = true;
            // 
            // lblPersonelRolu
            // 
            this.lblPersonelRolu.AutoSize = true;
            this.lblPersonelRolu.Location = new System.Drawing.Point(15, 387);
            this.lblPersonelRolu.Name = "lblPersonelRolu";
            this.lblPersonelRolu.Size = new System.Drawing.Size(108, 21);
            this.lblPersonelRolu.TabIndex = 34;
            this.lblPersonelRolu.Text = "Personel Rolü:";
            // 
            // cmbRoller
            // 
            this.cmbRoller.BackColor = System.Drawing.Color.White;
            this.cmbRoller.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRoller.ForeColor = System.Drawing.Color.Black;
            this.cmbRoller.FormattingEnabled = true;
            this.cmbRoller.Location = new System.Drawing.Point(15, 412);
            this.cmbRoller.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbRoller.Name = "cmbRoller";
            this.cmbRoller.Size = new System.Drawing.Size(276, 29);
            this.cmbRoller.TabIndex = 6;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Location = new System.Drawing.Point(15, 446);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(0);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(150, 40);
            this.btnEkle.TabIndex = 7;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGuncelle.Enabled = false;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnGuncelle.Location = new System.Drawing.Point(165, 446);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(0);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(150, 40);
            this.btnGuncelle.TabIndex = 8;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(315, 446);
            this.btnSil.Margin = new System.Windows.Forms.Padding(0);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(150, 40);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // picGoz
            // 
            this.picGoz.Image = global::RabtBil_Musteri_Kayit_v2.Properties.Resources.eye;
            this.picGoz.Location = new System.Drawing.Point(264, 298);
            this.picGoz.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.picGoz.Name = "picGoz";
            this.picGoz.Size = new System.Drawing.Size(25, 25);
            this.picGoz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGoz.TabIndex = 35;
            this.picGoz.TabStop = false;
            this.picGoz.Click += new System.EventHandler(this.picGoz_Click);
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(15, 9);
            this.lblBaslik.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(123, 25);
            this.lblBaslik.TabIndex = 37;
            this.lblBaslik.Text = "Personel Ekle";
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.White;
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.Image")));
            this.btnKapat.Location = new System.Drawing.Point(839, 0);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(0);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(30, 30);
            this.btnKapat.TabIndex = 11;
            this.btnKapat.TabStop = false;
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // FrmPersonelEkle
            // 
            this.AcceptButton = this.btnEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(870, 497);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.picGoz);
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
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPersonelEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPersonelEkle";
            this.Load += new System.EventHandler(this.FrmPersonelEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanicilar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGoz)).EndInit();
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
        private System.Windows.Forms.PictureBox picGoz;
        private System.Windows.Forms.Label lblBaslik;
        public System.Windows.Forms.Button btnKapat;
    }
}