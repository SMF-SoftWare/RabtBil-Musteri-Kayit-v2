﻿namespace RabtBil_Musteri_Kayit_v2
{
    partial class FrmGirisYap
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
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.linkLblSifremiUnuttum = new System.Windows.Forms.LinkLabel();
            this.lblGirisBicimi = new System.Windows.Forms.Label();
            this.BttnCikisYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(21, 78);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(90, 18);
            this.lblKullaniciAdi.TabIndex = 0;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(24, 99);
            this.txtKullaniciAdi.MaxLength = 20;
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(247, 24);
            this.txtKullaniciAdi.TabIndex = 1;
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Location = new System.Drawing.Point(24, 189);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(247, 40);
            this.btnGirisYap.TabIndex = 2;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.BttnGirisYap_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(24, 159);
            this.txtSifre.MaxLength = 20;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(247, 24);
            this.txtSifre.TabIndex = 4;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(21, 138);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(42, 18);
            this.lblSifre.TabIndex = 3;
            this.lblSifre.Text = "Şifre:";
            // 
            // linkLblSifremiUnuttum
            // 
            this.linkLblSifremiUnuttum.AutoSize = true;
            this.linkLblSifremiUnuttum.Location = new System.Drawing.Point(149, 284);
            this.linkLblSifremiUnuttum.Name = "linkLblSifremiUnuttum";
            this.linkLblSifremiUnuttum.Size = new System.Drawing.Size(122, 18);
            this.linkLblSifremiUnuttum.TabIndex = 5;
            this.linkLblSifremiUnuttum.TabStop = true;
            this.linkLblSifremiUnuttum.Text = "Şifremi Unuttum?";
            // 
            // lblGirisBicimi
            // 
            this.lblGirisBicimi.AutoSize = true;
            this.lblGirisBicimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGirisBicimi.Location = new System.Drawing.Point(59, 24);
            this.lblGirisBicimi.Name = "lblGirisBicimi";
            this.lblGirisBicimi.Size = new System.Drawing.Size(174, 31);
            this.lblGirisBicimi.TabIndex = 6;
            this.lblGirisBicimi.Text = "Yönetici Giriş";
            // 
            // BttnCikisYap
            // 
            this.BttnCikisYap.Location = new System.Drawing.Point(24, 235);
            this.BttnCikisYap.Name = "BttnCikisYap";
            this.BttnCikisYap.Size = new System.Drawing.Size(247, 40);
            this.BttnCikisYap.TabIndex = 7;
            this.BttnCikisYap.Text = "Çıkış Yap";
            this.BttnCikisYap.UseVisualStyleBackColor = true;
            this.BttnCikisYap.Click += new System.EventHandler(this.BttnCikisYap_Click);
            // 
            // FrmGirisYap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 313);
            this.Controls.Add(this.BttnCikisYap);
            this.Controls.Add(this.lblGirisBicimi);
            this.Controls.Add(this.linkLblSifremiUnuttum);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGirisYap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGirisYap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblKullaniciAdi;
        public System.Windows.Forms.TextBox txtKullaniciAdi;
        public System.Windows.Forms.Button btnGirisYap;
        public System.Windows.Forms.TextBox txtSifre;
        public System.Windows.Forms.Label lblSifre;
        public System.Windows.Forms.LinkLabel linkLblSifremiUnuttum;
        public System.Windows.Forms.Label lblGirisBicimi;
        public System.Windows.Forms.Button BttnCikisYap;
    }
}