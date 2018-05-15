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
            this.lblGirisBicimi = new System.Windows.Forms.Label();
            this.pbxEye = new System.Windows.Forms.PictureBox();
            this.kapat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEye)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.ForeColor = System.Drawing.Color.Black;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(15, 54);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(98, 21);
            this.lblKullaniciAdi.TabIndex = 0;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.BackColor = System.Drawing.Color.White;
            this.txtKullaniciAdi.ForeColor = System.Drawing.Color.Black;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(15, 79);
            this.txtKullaniciAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(312, 29);
            this.txtKullaniciAdi.TabIndex = 1;
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.BackColor = System.Drawing.Color.Black;
            this.btnGirisYap.FlatAppearance.BorderSize = 0;
            this.btnGirisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGirisYap.ForeColor = System.Drawing.Color.White;
            this.btnGirisYap.Location = new System.Drawing.Point(15, 167);
            this.btnGirisYap.Margin = new System.Windows.Forms.Padding(0);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(316, 40);
            this.btnGirisYap.TabIndex = 5;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = false;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.White;
            this.txtSifre.ForeColor = System.Drawing.Color.Black;
            this.txtSifre.Location = new System.Drawing.Point(15, 135);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(313, 29);
            this.txtSifre.TabIndex = 3;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.ForeColor = System.Drawing.Color.Black;
            this.lblSifre.Location = new System.Drawing.Point(15, 112);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(45, 21);
            this.lblSifre.TabIndex = 2;
            this.lblSifre.Text = "Şifre:";
            // 
            // lblGirisBicimi
            // 
            this.lblGirisBicimi.AutoSize = true;
            this.lblGirisBicimi.BackColor = System.Drawing.Color.Transparent;
            this.lblGirisBicimi.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGirisBicimi.ForeColor = System.Drawing.Color.Black;
            this.lblGirisBicimi.Location = new System.Drawing.Point(93, 2);
            this.lblGirisBicimi.Name = "lblGirisBicimi";
            this.lblGirisBicimi.Size = new System.Drawing.Size(156, 47);
            this.lblGirisBicimi.TabIndex = 6;
            this.lblGirisBicimi.Text = "Giriş Yap";
            // 
            // pbxEye
            // 
            this.pbxEye.Image = global::RabtBil_Musteri_Kayit_v2.Properties.Resources.eye;
            this.pbxEye.Location = new System.Drawing.Point(300, 137);
            this.pbxEye.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbxEye.Name = "pbxEye";
            this.pbxEye.Size = new System.Drawing.Size(25, 25);
            this.pbxEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxEye.TabIndex = 7;
            this.pbxEye.TabStop = false;
            this.pbxEye.Click += new System.EventHandler(this.pbxEye_Click);
            // 
            // kapat
            // 
            this.kapat.AutoSize = true;
            this.kapat.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.kapat.Location = new System.Drawing.Point(320, 2);
            this.kapat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kapat.Name = "kapat";
            this.kapat.Size = new System.Drawing.Size(23, 25);
            this.kapat.TabIndex = 8;
            this.kapat.Text = "X";
            this.kapat.Click += new System.EventHandler(this.kapat_Click);
            // 
            // FrmGirisYap
            // 
            this.AcceptButton = this.btnGirisYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(345, 224);
            this.Controls.Add(this.kapat);
            this.Controls.Add(this.pbxEye);
            this.Controls.Add(this.lblGirisBicimi);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
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
        public System.Windows.Forms.Label lblGirisBicimi;
        private System.Windows.Forms.PictureBox pbxEye;
        private System.Windows.Forms.Label kapat;
    }
}