﻿namespace RabtBil_Musteri_Kayit_v2
{
    partial class FrmPersonelTeknikServisFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonelTeknikServisFormu));
            this.lblTelefon = new System.Windows.Forms.Label();
            this.mtxTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtAksesuarlar = new System.Windows.Forms.TextBox();
            this.txtMusteriAdi = new System.Windows.Forms.TextBox();
            this.lblMusteriAdi = new System.Windows.Forms.Label();
            this.picQrKodu = new System.Windows.Forms.PictureBox();
            this.lblCihazinSeriNumarasi = new System.Windows.Forms.Label();
            this.chkTeslimEdildi = new System.Windows.Forms.CheckBox();
            this.txtUcret = new System.Windows.Forms.TextBox();
            this.lblUcret = new System.Windows.Forms.Label();
            this.txtTakipNumarasi = new System.Windows.Forms.TextBox();
            this.lblTakipNumarasi = new System.Windows.Forms.Label();
            this.txtCihazDurumu = new System.Windows.Forms.TextBox();
            this.lblCihazDurumu = new System.Windows.Forms.Label();
            this.txtArizaninTanimi = new System.Windows.Forms.TextBox();
            this.lblArizaninTanimi = new System.Windows.Forms.Label();
            this.txtCihazinSeriNumarası = new System.Windows.Forms.TextBox();
            this.txtCihazModeli = new System.Windows.Forms.TextBox();
            this.lblCihazModeli = new System.Windows.Forms.Label();
            this.lblMusteriNo = new System.Windows.Forms.Label();
            this.txtEkBilgiler = new System.Windows.Forms.TextBox();
            this.btnYeniKayit = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnKayitlariGoster = new System.Windows.Forms.Button();
            this.btnCikisYap = new System.Windows.Forms.Button();
            this.lblHosgeldin = new System.Windows.Forms.Label();
            this.PcTrBoxProfilResim = new System.Windows.Forms.PictureBox();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.txtFormNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnProgramiEtkinlestir = new System.Windows.Forms.Button();
            this.btnHakkinda = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picQrKodu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcTrBoxProfilResim)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(15, 97);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(62, 21);
            this.lblTelefon.TabIndex = 3;
            this.lblTelefon.Text = "Telefon:";
            // 
            // mtxTelefon
            // 
            this.mtxTelefon.Location = new System.Drawing.Point(15, 122);
            this.mtxTelefon.Mask = "(0999) 000 00 00";
            this.mtxTelefon.Name = "mtxTelefon";
            this.mtxTelefon.Size = new System.Drawing.Size(256, 29);
            this.mtxTelefon.TabIndex = 3;
            // 
            // txtAksesuarlar
            // 
            this.txtAksesuarlar.Location = new System.Drawing.Point(15, 178);
            this.txtAksesuarlar.Multiline = true;
            this.txtAksesuarlar.Name = "txtAksesuarlar";
            this.txtAksesuarlar.Size = new System.Drawing.Size(256, 105);
            this.txtAksesuarlar.TabIndex = 4;
            // 
            // txtMusteriAdi
            // 
            this.txtMusteriAdi.Location = new System.Drawing.Point(15, 64);
            this.txtMusteriAdi.Name = "txtMusteriAdi";
            this.txtMusteriAdi.Size = new System.Drawing.Size(256, 29);
            this.txtMusteriAdi.TabIndex = 2;
            // 
            // lblMusteriAdi
            // 
            this.lblMusteriAdi.AutoSize = true;
            this.lblMusteriAdi.Location = new System.Drawing.Point(15, 39);
            this.lblMusteriAdi.Name = "lblMusteriAdi";
            this.lblMusteriAdi.Size = new System.Drawing.Size(93, 21);
            this.lblMusteriAdi.TabIndex = 2;
            this.lblMusteriAdi.Text = "Müşteri Adı:";
            // 
            // picQrKodu
            // 
            this.picQrKodu.Location = new System.Drawing.Point(208, 507);
            this.picQrKodu.Name = "picQrKodu";
            this.picQrKodu.Size = new System.Drawing.Size(112, 116);
            this.picQrKodu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picQrKodu.TabIndex = 38;
            this.picQrKodu.TabStop = false;
            // 
            // lblCihazinSeriNumarasi
            // 
            this.lblCihazinSeriNumarasi.AutoSize = true;
            this.lblCihazinSeriNumarasi.Location = new System.Drawing.Point(295, 95);
            this.lblCihazinSeriNumarasi.Name = "lblCihazinSeriNumarasi";
            this.lblCihazinSeriNumarasi.Size = new System.Drawing.Size(167, 21);
            this.lblCihazinSeriNumarasi.TabIndex = 7;
            this.lblCihazinSeriNumarasi.Text = "Cihazın Seri Numarası:";
            // 
            // chkTeslimEdildi
            // 
            this.chkTeslimEdildi.AutoSize = true;
            this.chkTeslimEdildi.Location = new System.Drawing.Point(147, 429);
            this.chkTeslimEdildi.Name = "chkTeslimEdildi";
            this.chkTeslimEdildi.Size = new System.Drawing.Size(114, 25);
            this.chkTeslimEdildi.TabIndex = 12;
            this.chkTeslimEdildi.Text = "Teslim Edildi";
            this.chkTeslimEdildi.UseVisualStyleBackColor = true;
            this.chkTeslimEdildi.Click += new System.EventHandler(this.chkTeslimEdildi_Click);
            // 
            // txtUcret
            // 
            this.txtUcret.Location = new System.Drawing.Point(295, 371);
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.Size = new System.Drawing.Size(256, 29);
            this.txtUcret.TabIndex = 11;
            // 
            // lblUcret
            // 
            this.lblUcret.AutoSize = true;
            this.lblUcret.Location = new System.Drawing.Point(295, 346);
            this.lblUcret.Name = "lblUcret";
            this.lblUcret.Size = new System.Drawing.Size(50, 21);
            this.lblUcret.TabIndex = 12;
            this.lblUcret.Text = "Ücret:";
            // 
            // txtTakipNumarasi
            // 
            this.txtTakipNumarasi.Enabled = false;
            this.txtTakipNumarasi.Location = new System.Drawing.Point(295, 429);
            this.txtTakipNumarasi.Name = "txtTakipNumarasi";
            this.txtTakipNumarasi.Size = new System.Drawing.Size(256, 29);
            this.txtTakipNumarasi.TabIndex = 10;
            // 
            // lblTakipNumarasi
            // 
            this.lblTakipNumarasi.AutoSize = true;
            this.lblTakipNumarasi.Location = new System.Drawing.Point(295, 404);
            this.lblTakipNumarasi.Name = "lblTakipNumarasi";
            this.lblTakipNumarasi.Size = new System.Drawing.Size(120, 21);
            this.lblTakipNumarasi.TabIndex = 10;
            this.lblTakipNumarasi.Text = "Takip Numarası:";
            // 
            // txtCihazDurumu
            // 
            this.txtCihazDurumu.Location = new System.Drawing.Point(295, 313);
            this.txtCihazDurumu.Name = "txtCihazDurumu";
            this.txtCihazDurumu.Size = new System.Drawing.Size(256, 29);
            this.txtCihazDurumu.TabIndex = 9;
            // 
            // lblCihazDurumu
            // 
            this.lblCihazDurumu.AutoSize = true;
            this.lblCihazDurumu.Location = new System.Drawing.Point(295, 288);
            this.lblCihazDurumu.Name = "lblCihazDurumu";
            this.lblCihazDurumu.Size = new System.Drawing.Size(113, 21);
            this.lblCihazDurumu.TabIndex = 9;
            this.lblCihazDurumu.Text = "Cihaz Durumu:";
            // 
            // txtArizaninTanimi
            // 
            this.txtArizaninTanimi.Location = new System.Drawing.Point(295, 179);
            this.txtArizaninTanimi.Multiline = true;
            this.txtArizaninTanimi.Name = "txtArizaninTanimi";
            this.txtArizaninTanimi.Size = new System.Drawing.Size(256, 105);
            this.txtArizaninTanimi.TabIndex = 8;
            // 
            // lblArizaninTanimi
            // 
            this.lblArizaninTanimi.AutoSize = true;
            this.lblArizaninTanimi.Location = new System.Drawing.Point(295, 154);
            this.lblArizaninTanimi.Name = "lblArizaninTanimi";
            this.lblArizaninTanimi.Size = new System.Drawing.Size(119, 21);
            this.lblArizaninTanimi.TabIndex = 8;
            this.lblArizaninTanimi.Text = "Arızanın Tanımı:";
            // 
            // txtCihazinSeriNumarası
            // 
            this.txtCihazinSeriNumarası.Location = new System.Drawing.Point(295, 121);
            this.txtCihazinSeriNumarası.Name = "txtCihazinSeriNumarası";
            this.txtCihazinSeriNumarası.Size = new System.Drawing.Size(256, 29);
            this.txtCihazinSeriNumarası.TabIndex = 7;
            // 
            // txtCihazModeli
            // 
            this.txtCihazModeli.Location = new System.Drawing.Point(295, 64);
            this.txtCihazModeli.Name = "txtCihazModeli";
            this.txtCihazModeli.Size = new System.Drawing.Size(256, 29);
            this.txtCihazModeli.TabIndex = 6;
            // 
            // lblCihazModeli
            // 
            this.lblCihazModeli.AutoSize = true;
            this.lblCihazModeli.Location = new System.Drawing.Point(295, 39);
            this.lblCihazModeli.Name = "lblCihazModeli";
            this.lblCihazModeli.Size = new System.Drawing.Size(103, 21);
            this.lblCihazModeli.TabIndex = 6;
            this.lblCihazModeli.Text = "Cihaz Modeli:";
            // 
            // lblMusteriNo
            // 
            this.lblMusteriNo.AutoSize = true;
            this.lblMusteriNo.Location = new System.Drawing.Point(91, 451);
            this.lblMusteriNo.Name = "lblMusteriNo";
            this.lblMusteriNo.Size = new System.Drawing.Size(88, 21);
            this.lblMusteriNo.TabIndex = 36;
            this.lblMusteriNo.Text = "Müşteri No";
            // 
            // txtEkBilgiler
            // 
            this.txtEkBilgiler.Location = new System.Drawing.Point(15, 312);
            this.txtEkBilgiler.Multiline = true;
            this.txtEkBilgiler.Name = "txtEkBilgiler";
            this.txtEkBilgiler.Size = new System.Drawing.Size(256, 105);
            this.txtEkBilgiler.TabIndex = 5;
            // 
            // btnYeniKayit
            // 
            this.btnYeniKayit.BackColor = System.Drawing.Color.Black;
            this.btnYeniKayit.Enabled = false;
            this.btnYeniKayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeniKayit.ForeColor = System.Drawing.Color.White;
            this.btnYeniKayit.Location = new System.Drawing.Point(576, 122);
            this.btnYeniKayit.Name = "btnYeniKayit";
            this.btnYeniKayit.Size = new System.Drawing.Size(150, 40);
            this.btnYeniKayit.TabIndex = 14;
            this.btnYeniKayit.Text = "Yeni Kayıt";
            this.btnYeniKayit.UseVisualStyleBackColor = false;
            this.btnYeniKayit.Click += new System.EventHandler(this.btnYeniKayit_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Black;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(576, 168);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(150, 40);
            this.btnKaydet.TabIndex = 15;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnKayitlariGoster
            // 
            this.btnKayitlariGoster.BackColor = System.Drawing.Color.Black;
            this.btnKayitlariGoster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKayitlariGoster.ForeColor = System.Drawing.Color.White;
            this.btnKayitlariGoster.Location = new System.Drawing.Point(576, 214);
            this.btnKayitlariGoster.Name = "btnKayitlariGoster";
            this.btnKayitlariGoster.Size = new System.Drawing.Size(150, 40);
            this.btnKayitlariGoster.TabIndex = 17;
            this.btnKayitlariGoster.Text = "Kayıtları Göster";
            this.btnKayitlariGoster.UseVisualStyleBackColor = false;
            this.btnKayitlariGoster.Click += new System.EventHandler(this.btnKayitlariGoster_Click);
            // 
            // btnCikisYap
            // 
            this.btnCikisYap.BackColor = System.Drawing.Color.Black;
            this.btnCikisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikisYap.ForeColor = System.Drawing.Color.White;
            this.btnCikisYap.Location = new System.Drawing.Point(576, 397);
            this.btnCikisYap.Name = "btnCikisYap";
            this.btnCikisYap.Size = new System.Drawing.Size(150, 40);
            this.btnCikisYap.TabIndex = 19;
            this.btnCikisYap.Text = "Çıkış Yap";
            this.btnCikisYap.UseVisualStyleBackColor = false;
            this.btnCikisYap.Click += new System.EventHandler(this.btnCikisYap_Click);
            // 
            // lblHosgeldin
            // 
            this.lblHosgeldin.AutoSize = true;
            this.lblHosgeldin.BackColor = System.Drawing.Color.White;
            this.lblHosgeldin.Location = new System.Drawing.Point(16, 430);
            this.lblHosgeldin.Name = "lblHosgeldin";
            this.lblHosgeldin.Size = new System.Drawing.Size(98, 21);
            this.lblHosgeldin.TabIndex = 35;
            this.lblHosgeldin.Text = "Hoş Geldin, !";
            // 
            // PcTrBoxProfilResim
            // 
            this.PcTrBoxProfilResim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PcTrBoxProfilResim.Image = global::RabtBil_Musteri_Kayit_v2.Properties.Resources.varsayilanProfilResmi;
            this.PcTrBoxProfilResim.Location = new System.Drawing.Point(614, 39);
            this.PcTrBoxProfilResim.Name = "PcTrBoxProfilResim";
            this.PcTrBoxProfilResim.Size = new System.Drawing.Size(80, 80);
            this.PcTrBoxProfilResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcTrBoxProfilResim.TabIndex = 33;
            this.PcTrBoxProfilResim.TabStop = false;
            this.PcTrBoxProfilResim.Click += new System.EventHandler(this.PcTrBoxProfilResim_Click);
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(15, 9);
            this.lblBaslik.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(177, 25);
            this.lblBaslik.TabIndex = 38;
            this.lblBaslik.Text = "Teknik Servis Formu";
            // 
            // txtFormNo
            // 
            this.txtFormNo.Location = new System.Drawing.Point(41, 569);
            this.txtFormNo.Name = "txtFormNo";
            this.txtFormNo.Size = new System.Drawing.Size(127, 29);
            this.txtFormNo.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 40;
            this.label2.Text = "Aksesuarlar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 21);
            this.label3.TabIndex = 41;
            this.label3.Text = "Ek Bilgiler:";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Black;
            this.btnGuncelle.Enabled = false;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnGuncelle.Location = new System.Drawing.Point(576, 260);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(150, 40);
            this.btnGuncelle.TabIndex = 18;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(576, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 40);
            this.button1.TabIndex = 42;
            this.button1.Text = "Teslim Et";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(576, 351);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 40);
            this.button2.TabIndex = 43;
            this.button2.Text = "Yazdır";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnProgramiEtkinlestir
            // 
            this.btnProgramiEtkinlestir.BackColor = System.Drawing.Color.White;
            this.btnProgramiEtkinlestir.FlatAppearance.BorderSize = 0;
            this.btnProgramiEtkinlestir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProgramiEtkinlestir.ForeColor = System.Drawing.Color.White;
            this.btnProgramiEtkinlestir.Image = ((System.Drawing.Image)(resources.GetObject("btnProgramiEtkinlestir.Image")));
            this.btnProgramiEtkinlestir.Location = new System.Drawing.Point(647, 0);
            this.btnProgramiEtkinlestir.Margin = new System.Windows.Forms.Padding(0);
            this.btnProgramiEtkinlestir.Name = "btnProgramiEtkinlestir";
            this.btnProgramiEtkinlestir.Size = new System.Drawing.Size(30, 30);
            this.btnProgramiEtkinlestir.TabIndex = 44;
            this.btnProgramiEtkinlestir.UseVisualStyleBackColor = false;
            this.btnProgramiEtkinlestir.Click += new System.EventHandler(this.btnProgramiEtkinlestir_Click);
            // 
            // btnHakkinda
            // 
            this.btnHakkinda.BackColor = System.Drawing.Color.White;
            this.btnHakkinda.FlatAppearance.BorderSize = 0;
            this.btnHakkinda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHakkinda.ForeColor = System.Drawing.Color.White;
            this.btnHakkinda.Image = ((System.Drawing.Image)(resources.GetObject("btnHakkinda.Image")));
            this.btnHakkinda.Location = new System.Drawing.Point(680, 0);
            this.btnHakkinda.Margin = new System.Windows.Forms.Padding(0);
            this.btnHakkinda.Name = "btnHakkinda";
            this.btnHakkinda.Size = new System.Drawing.Size(30, 30);
            this.btnHakkinda.TabIndex = 46;
            this.btnHakkinda.UseVisualStyleBackColor = false;
            this.btnHakkinda.Click += new System.EventHandler(this.btnHakkinda_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.White;
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.Image")));
            this.btnKapat.Location = new System.Drawing.Point(713, 0);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(0);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(30, 30);
            this.btnKapat.TabIndex = 47;
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // FrmPersonelTeknikServisFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(745, 473);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnHakkinda);
            this.Controls.Add(this.btnProgramiEtkinlestir);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.txtUcret);
            this.Controls.Add(this.picQrKodu);
            this.Controls.Add(this.lblUcret);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkTeslimEdildi);
            this.Controls.Add(this.lblCihazinSeriNumarasi);
            this.Controls.Add(this.txtEkBilgiler);
            this.Controls.Add(this.txtAksesuarlar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTakipNumarasi);
            this.Controls.Add(this.txtFormNo);
            this.Controls.Add(this.lblTakipNumarasi);
            this.Controls.Add(this.txtMusteriAdi);
            this.Controls.Add(this.txtCihazDurumu);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.lblCihazDurumu);
            this.Controls.Add(this.mtxTelefon);
            this.Controls.Add(this.txtArizaninTanimi);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblArizaninTanimi);
            this.Controls.Add(this.lblMusteriAdi);
            this.Controls.Add(this.txtCihazinSeriNumarası);
            this.Controls.Add(this.lblHosgeldin);
            this.Controls.Add(this.lblMusteriNo);
            this.Controls.Add(this.txtCihazModeli);
            this.Controls.Add(this.btnCikisYap);
            this.Controls.Add(this.lblCihazModeli);
            this.Controls.Add(this.PcTrBoxProfilResim);
            this.Controls.Add(this.btnKayitlariGoster);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnYeniKayit);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmPersonelTeknikServisFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTeknikServisFormu";
            this.Load += new System.EventHandler(this.FrmPersonelTeknikServisFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picQrKodu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcTrBoxProfilResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblTelefon;
        public System.Windows.Forms.MaskedTextBox mtxTelefon;
        public System.Windows.Forms.TextBox txtAksesuarlar;
        public System.Windows.Forms.TextBox txtUcret;
        public System.Windows.Forms.Label lblUcret;
        public System.Windows.Forms.TextBox txtTakipNumarasi;
        public System.Windows.Forms.Label lblTakipNumarasi;
        public System.Windows.Forms.TextBox txtCihazDurumu;
        public System.Windows.Forms.Label lblCihazDurumu;
        public System.Windows.Forms.TextBox txtArizaninTanimi;
        public System.Windows.Forms.Label lblArizaninTanimi;
        public System.Windows.Forms.TextBox txtCihazinSeriNumarası;
        public System.Windows.Forms.TextBox txtCihazModeli;
        public System.Windows.Forms.Label lblCihazModeli;
        public System.Windows.Forms.TextBox txtEkBilgiler;
        public System.Windows.Forms.Button btnYeniKayit;
        public System.Windows.Forms.Button btnKaydet;
        public System.Windows.Forms.Button btnKayitlariGoster;
        public System.Windows.Forms.PictureBox PcTrBoxProfilResim;
        public System.Windows.Forms.Button btnCikisYap;
        public System.Windows.Forms.Label lblHosgeldin;
        public System.Windows.Forms.CheckBox chkTeslimEdildi;
        public System.Windows.Forms.Label lblCihazinSeriNumarasi;
        public System.Windows.Forms.TextBox txtMusteriAdi;
        public System.Windows.Forms.Label lblMusteriAdi;
        public System.Windows.Forms.Label lblMusteriNo;
        public System.Windows.Forms.PictureBox picQrKodu;
        private System.Windows.Forms.Label lblBaslik;
        public System.Windows.Forms.TextBox txtFormNo;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnGuncelle;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button btnProgramiEtkinlestir;
        public System.Windows.Forms.Button btnHakkinda;
        public System.Windows.Forms.Button btnKapat;
    }
}