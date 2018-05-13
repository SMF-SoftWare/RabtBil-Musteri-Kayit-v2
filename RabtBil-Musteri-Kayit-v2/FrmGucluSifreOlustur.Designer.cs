namespace RabtBil_Musteri_Kayit_v2
{
    partial class FrmGucluSifreOlustur
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
            this.lblSifreUzunluguDeger = new System.Windows.Forms.Label();
            this.trbSifreUzunlugu = new System.Windows.Forms.TrackBar();
            this.lblGucluSifreniz = new System.Windows.Forms.Label();
            this.lblSifreUzunlugu = new System.Windows.Forms.Label();
            this.btnKopyala = new System.Windows.Forms.Button();
            this.txtGucluSifre = new System.Windows.Forms.TextBox();
            this.chkSemboller = new System.Windows.Forms.CheckBox();
            this.chkSayilar = new System.Windows.Forms.CheckBox();
            this.chkBuyukHarfler = new System.Windows.Forms.CheckBox();
            this.chkKucukHarfler = new System.Windows.Forms.CheckBox();
            this.btnYenidenOlustur = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trbSifreUzunlugu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSifreUzunluguDeger
            // 
            this.lblSifreUzunluguDeger.AutoSize = true;
            this.lblSifreUzunluguDeger.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.lblSifreUzunluguDeger.Location = new System.Drawing.Point(129, 8);
            this.lblSifreUzunluguDeger.Name = "lblSifreUzunluguDeger";
            this.lblSifreUzunluguDeger.Size = new System.Drawing.Size(14, 15);
            this.lblSifreUzunluguDeger.TabIndex = 21;
            this.lblSifreUzunluguDeger.Text = "0";
            // 
            // trbSifreUzunlugu
            // 
            this.trbSifreUzunlugu.Location = new System.Drawing.Point(12, 26);
            this.trbSifreUzunlugu.Maximum = 20;
            this.trbSifreUzunlugu.Minimum = 4;
            this.trbSifreUzunlugu.Name = "trbSifreUzunlugu";
            this.trbSifreUzunlugu.Size = new System.Drawing.Size(257, 45);
            this.trbSifreUzunlugu.TabIndex = 20;
            this.trbSifreUzunlugu.Value = 4;
            this.trbSifreUzunlugu.Scroll += new System.EventHandler(this.trbSifreUzunlugu_Scroll);
            // 
            // lblGucluSifreniz
            // 
            this.lblGucluSifreniz.AutoSize = true;
            this.lblGucluSifreniz.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.lblGucluSifreniz.Location = new System.Drawing.Point(12, 92);
            this.lblGucluSifreniz.Name = "lblGucluSifreniz";
            this.lblGucluSifreniz.Size = new System.Drawing.Size(112, 15);
            this.lblGucluSifreniz.TabIndex = 19;
            this.lblGucluSifreniz.Text = "Güçlü Şifreniz:";
            // 
            // lblSifreUzunlugu
            // 
            this.lblSifreUzunlugu.AutoSize = true;
            this.lblSifreUzunlugu.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.lblSifreUzunlugu.Location = new System.Drawing.Point(12, 8);
            this.lblSifreUzunlugu.Name = "lblSifreUzunlugu";
            this.lblSifreUzunlugu.Size = new System.Drawing.Size(112, 15);
            this.lblSifreUzunlugu.TabIndex = 18;
            this.lblSifreUzunlugu.Text = "Şifre Uzunluğu:";
            // 
            // btnKopyala
            // 
            this.btnKopyala.Location = new System.Drawing.Point(303, 110);
            this.btnKopyala.Name = "btnKopyala";
            this.btnKopyala.Size = new System.Drawing.Size(75, 26);
            this.btnKopyala.TabIndex = 17;
            this.btnKopyala.Text = "Kopyala";
            this.btnKopyala.UseVisualStyleBackColor = true;
            this.btnKopyala.Click += new System.EventHandler(this.btnKopyala_Click);
            // 
            // txtGucluSifre
            // 
            this.txtGucluSifre.Location = new System.Drawing.Point(12, 114);
            this.txtGucluSifre.Name = "txtGucluSifre";
            this.txtGucluSifre.ReadOnly = true;
            this.txtGucluSifre.Size = new System.Drawing.Size(174, 20);
            this.txtGucluSifre.TabIndex = 16;
            // 
            // chkSemboller
            // 
            this.chkSemboller.AutoSize = true;
            this.chkSemboller.Location = new System.Drawing.Point(291, 80);
            this.chkSemboller.Name = "chkSemboller";
            this.chkSemboller.Size = new System.Drawing.Size(72, 17);
            this.chkSemboller.TabIndex = 15;
            this.chkSemboller.Text = "Semboller";
            this.chkSemboller.UseVisualStyleBackColor = true;
            this.chkSemboller.CheckedChanged += new System.EventHandler(this.btnYenidenOlustur_Click);
            // 
            // chkSayilar
            // 
            this.chkSayilar.AutoSize = true;
            this.chkSayilar.Location = new System.Drawing.Point(291, 57);
            this.chkSayilar.Name = "chkSayilar";
            this.chkSayilar.Size = new System.Drawing.Size(57, 17);
            this.chkSayilar.TabIndex = 14;
            this.chkSayilar.Text = "Sayılar";
            this.chkSayilar.UseVisualStyleBackColor = true;
            this.chkSayilar.CheckedChanged += new System.EventHandler(this.btnYenidenOlustur_Click);
            // 
            // chkBuyukHarfler
            // 
            this.chkBuyukHarfler.AutoSize = true;
            this.chkBuyukHarfler.Location = new System.Drawing.Point(291, 34);
            this.chkBuyukHarfler.Name = "chkBuyukHarfler";
            this.chkBuyukHarfler.Size = new System.Drawing.Size(90, 17);
            this.chkBuyukHarfler.TabIndex = 13;
            this.chkBuyukHarfler.Text = "Büyük Harfler";
            this.chkBuyukHarfler.UseVisualStyleBackColor = true;
            this.chkBuyukHarfler.CheckedChanged += new System.EventHandler(this.btnYenidenOlustur_Click);
            // 
            // chkKucukHarfler
            // 
            this.chkKucukHarfler.AutoSize = true;
            this.chkKucukHarfler.Location = new System.Drawing.Point(293, 11);
            this.chkKucukHarfler.Name = "chkKucukHarfler";
            this.chkKucukHarfler.Size = new System.Drawing.Size(91, 17);
            this.chkKucukHarfler.TabIndex = 12;
            this.chkKucukHarfler.Text = "Küçük Harfler";
            this.chkKucukHarfler.UseVisualStyleBackColor = true;
            this.chkKucukHarfler.CheckedChanged += new System.EventHandler(this.btnYenidenOlustur_Click);
            // 
            // btnYenidenOlustur
            // 
            this.btnYenidenOlustur.Location = new System.Drawing.Point(194, 110);
            this.btnYenidenOlustur.Name = "btnYenidenOlustur";
            this.btnYenidenOlustur.Size = new System.Drawing.Size(103, 26);
            this.btnYenidenOlustur.TabIndex = 22;
            this.btnYenidenOlustur.Text = "Yeniden Oluştur";
            this.btnYenidenOlustur.UseVisualStyleBackColor = true;
            this.btnYenidenOlustur.Click += new System.EventHandler(this.btnYenidenOlustur_Click);
            // 
            // FrmGucluSifreOlustur
            // 
            this.AcceptButton = this.btnKopyala;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 150);
            this.Controls.Add(this.btnYenidenOlustur);
            this.Controls.Add(this.lblSifreUzunluguDeger);
            this.Controls.Add(this.trbSifreUzunlugu);
            this.Controls.Add(this.lblGucluSifreniz);
            this.Controls.Add(this.lblSifreUzunlugu);
            this.Controls.Add(this.btnKopyala);
            this.Controls.Add(this.txtGucluSifre);
            this.Controls.Add(this.chkSemboller);
            this.Controls.Add(this.chkSayilar);
            this.Controls.Add(this.chkBuyukHarfler);
            this.Controls.Add(this.chkKucukHarfler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmGucluSifreOlustur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGucluSifreOlustur";
            this.Load += new System.EventHandler(this.FrmGucluSifreOlustur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trbSifreUzunlugu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSifreUzunluguDeger;
        private System.Windows.Forms.TrackBar trbSifreUzunlugu;
        private System.Windows.Forms.Label lblGucluSifreniz;
        private System.Windows.Forms.Label lblSifreUzunlugu;
        private System.Windows.Forms.Button btnKopyala;
        private System.Windows.Forms.TextBox txtGucluSifre;
        private System.Windows.Forms.CheckBox chkSemboller;
        private System.Windows.Forms.CheckBox chkSayilar;
        private System.Windows.Forms.CheckBox chkBuyukHarfler;
        private System.Windows.Forms.CheckBox chkKucukHarfler;
        private System.Windows.Forms.Button btnYenidenOlustur;
    }
}