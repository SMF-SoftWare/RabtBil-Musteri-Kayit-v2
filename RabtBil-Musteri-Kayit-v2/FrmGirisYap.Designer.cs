namespace RabtBil_Musteri_Kayit_v2
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
            this.LblKullaniciAdi = new System.Windows.Forms.Label();
            this.TxtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.BttnGirisYap = new System.Windows.Forms.Button();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.LblSifre = new System.Windows.Forms.Label();
            this.LinkLblSifremiUnuttum = new System.Windows.Forms.LinkLabel();
            this.LblGirisBicimi = new System.Windows.Forms.Label();
            this.BttnCikisYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblKullaniciAdi
            // 
            this.LblKullaniciAdi.AutoSize = true;
            this.LblKullaniciAdi.Location = new System.Drawing.Point(21, 78);
            this.LblKullaniciAdi.Name = "LblKullaniciAdi";
            this.LblKullaniciAdi.Size = new System.Drawing.Size(90, 18);
            this.LblKullaniciAdi.TabIndex = 0;
            this.LblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // TxtKullaniciAdi
            // 
            this.TxtKullaniciAdi.Location = new System.Drawing.Point(24, 99);
            this.TxtKullaniciAdi.MaxLength = 20;
            this.TxtKullaniciAdi.Name = "TxtKullaniciAdi";
            this.TxtKullaniciAdi.Size = new System.Drawing.Size(247, 24);
            this.TxtKullaniciAdi.TabIndex = 1;
            // 
            // BttnGirisYap
            // 
            this.BttnGirisYap.Location = new System.Drawing.Point(24, 189);
            this.BttnGirisYap.Name = "BttnGirisYap";
            this.BttnGirisYap.Size = new System.Drawing.Size(247, 40);
            this.BttnGirisYap.TabIndex = 2;
            this.BttnGirisYap.Text = "Giriş Yap";
            this.BttnGirisYap.UseVisualStyleBackColor = true;
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(24, 159);
            this.TxtSifre.MaxLength = 20;
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(247, 24);
            this.TxtSifre.TabIndex = 4;
            // 
            // LblSifre
            // 
            this.LblSifre.AutoSize = true;
            this.LblSifre.Location = new System.Drawing.Point(21, 138);
            this.LblSifre.Name = "LblSifre";
            this.LblSifre.Size = new System.Drawing.Size(42, 18);
            this.LblSifre.TabIndex = 3;
            this.LblSifre.Text = "Şifre:";
            // 
            // LinkLblSifremiUnuttum
            // 
            this.LinkLblSifremiUnuttum.AutoSize = true;
            this.LinkLblSifremiUnuttum.Location = new System.Drawing.Point(149, 284);
            this.LinkLblSifremiUnuttum.Name = "LinkLblSifremiUnuttum";
            this.LinkLblSifremiUnuttum.Size = new System.Drawing.Size(122, 18);
            this.LinkLblSifremiUnuttum.TabIndex = 5;
            this.LinkLblSifremiUnuttum.TabStop = true;
            this.LinkLblSifremiUnuttum.Text = "Şifremi Unuttum?";
            // 
            // LblGirisBicimi
            // 
            this.LblGirisBicimi.AutoSize = true;
            this.LblGirisBicimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblGirisBicimi.Location = new System.Drawing.Point(59, 24);
            this.LblGirisBicimi.Name = "LblGirisBicimi";
            this.LblGirisBicimi.Size = new System.Drawing.Size(174, 31);
            this.LblGirisBicimi.TabIndex = 6;
            this.LblGirisBicimi.Text = "Yönetici Giriş";
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
            this.Controls.Add(this.LblGirisBicimi);
            this.Controls.Add(this.LinkLblSifremiUnuttum);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.LblSifre);
            this.Controls.Add(this.BttnGirisYap);
            this.Controls.Add(this.TxtKullaniciAdi);
            this.Controls.Add(this.LblKullaniciAdi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmGirisYap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGirisYap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label LblKullaniciAdi;
        public System.Windows.Forms.TextBox TxtKullaniciAdi;
        public System.Windows.Forms.Button BttnGirisYap;
        public System.Windows.Forms.TextBox TxtSifre;
        public System.Windows.Forms.Label LblSifre;
        public System.Windows.Forms.LinkLabel LinkLblSifremiUnuttum;
        public System.Windows.Forms.Label LblGirisBicimi;
        public System.Windows.Forms.Button BttnCikisYap;
    }
}