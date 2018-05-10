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
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.linkLblSifremiUnuttum = new System.Windows.Forms.LinkLabel();
            this.lblGirisBicimi = new System.Windows.Forms.Label();
            this.pbxEye = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEye)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Consolas", 9F);
            this.lblKullaniciAdi.Location = new System.Drawing.Point(26, 79);
            this.lblKullaniciAdi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(105, 14);
            this.lblKullaniciAdi.TabIndex = 0;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Consolas", 11F);
            this.txtKullaniciAdi.Location = new System.Drawing.Point(30, 100);
            this.txtKullaniciAdi.Margin = new System.Windows.Forms.Padding(2);
            this.txtKullaniciAdi.MaxLength = 20;
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(277, 25);
            this.txtKullaniciAdi.TabIndex = 1;
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Font = new System.Drawing.Font("Consolas", 11F);
            this.btnGirisYap.Location = new System.Drawing.Point(30, 190);
            this.btnGirisYap.Margin = new System.Windows.Forms.Padding(2);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(277, 40);
            this.btnGirisYap.TabIndex = 5;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Consolas", 11F);
            this.txtSifre.Location = new System.Drawing.Point(31, 161);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(2);
            this.txtSifre.MaxLength = 20;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(276, 25);
            this.txtSifre.TabIndex = 3;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Consolas", 9F);
            this.lblSifre.Location = new System.Drawing.Point(27, 140);
            this.lblSifre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(49, 14);
            this.lblSifre.TabIndex = 2;
            this.lblSifre.Text = "Şifre:";
            // 
            // linkLblSifremiUnuttum
            // 
            this.linkLblSifremiUnuttum.AutoSize = true;
            this.linkLblSifremiUnuttum.Font = new System.Drawing.Font("Consolas", 11F);
            this.linkLblSifremiUnuttum.Location = new System.Drawing.Point(169, 232);
            this.linkLblSifremiUnuttum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLblSifremiUnuttum.Name = "linkLblSifremiUnuttum";
            this.linkLblSifremiUnuttum.Size = new System.Drawing.Size(136, 18);
            this.linkLblSifremiUnuttum.TabIndex = 6;
            this.linkLblSifremiUnuttum.TabStop = true;
            this.linkLblSifremiUnuttum.Text = "Şifremi Unuttum?";
            // 
            // lblGirisBicimi
            // 
            this.lblGirisBicimi.AutoSize = true;
            this.lblGirisBicimi.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGirisBicimi.Location = new System.Drawing.Point(60, 24);
            this.lblGirisBicimi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGirisBicimi.Name = "lblGirisBicimi";
            this.lblGirisBicimi.Size = new System.Drawing.Size(225, 32);
            this.lblGirisBicimi.TabIndex = 6;
            this.lblGirisBicimi.Text = "Yönetici Giriş";
            // 
            // pbxEye
            // 
            this.pbxEye.Image = global::RabtBil_Musteri_Kayit_v2.Properties.Resources.eye;
            this.pbxEye.Location = new System.Drawing.Point(277, 164);
            this.pbxEye.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbxEye.Name = "pbxEye";
            this.pbxEye.Size = new System.Drawing.Size(28, 20);
            this.pbxEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxEye.TabIndex = 7;
            this.pbxEye.TabStop = false;
            this.pbxEye.Click += new System.EventHandler(this.pbxEye_Click);
            // 
            // FrmGirisYap
            // 
            this.AcceptButton = this.btnGirisYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.pbxEye);
            this.Controls.Add(this.lblGirisBicimi);
            this.Controls.Add(this.linkLblSifremiUnuttum);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Font = new System.Drawing.Font("Consolas", 11F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmGirisYap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGirisYap";
            this.Load += new System.EventHandler(this.FrmGirisYap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxEye)).EndInit();
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
        private System.Windows.Forms.PictureBox pbxEye;
    }
}