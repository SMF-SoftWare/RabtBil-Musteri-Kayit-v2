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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGucluSifreOlustur));
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trbSifreUzunlugu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSifreUzunluguDeger
            // 
            this.lblSifreUzunluguDeger.AutoSize = true;
            this.lblSifreUzunluguDeger.Location = new System.Drawing.Point(128, 39);
            this.lblSifreUzunluguDeger.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSifreUzunluguDeger.Name = "lblSifreUzunluguDeger";
            this.lblSifreUzunluguDeger.Size = new System.Drawing.Size(19, 21);
            this.lblSifreUzunluguDeger.TabIndex = 21;
            this.lblSifreUzunluguDeger.Text = "0";
            // 
            // trbSifreUzunlugu
            // 
            this.trbSifreUzunlugu.LargeChange = 1;
            this.trbSifreUzunlugu.Location = new System.Drawing.Point(15, 65);
            this.trbSifreUzunlugu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trbSifreUzunlugu.Maximum = 20;
            this.trbSifreUzunlugu.Minimum = 4;
            this.trbSifreUzunlugu.Name = "trbSifreUzunlugu";
            this.trbSifreUzunlugu.Size = new System.Drawing.Size(386, 45);
            this.trbSifreUzunlugu.TabIndex = 20;
            this.trbSifreUzunlugu.Value = 4;
            this.trbSifreUzunlugu.Scroll += new System.EventHandler(this.trbSifreUzunlugu_Scroll);
            // 
            // lblGucluSifreniz
            // 
            this.lblGucluSifreniz.AutoSize = true;
            this.lblGucluSifreniz.Location = new System.Drawing.Point(15, 142);
            this.lblGucluSifreniz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGucluSifreniz.Name = "lblGucluSifreniz";
            this.lblGucluSifreniz.Size = new System.Drawing.Size(109, 21);
            this.lblGucluSifreniz.TabIndex = 19;
            this.lblGucluSifreniz.Text = "Güçlü Şifreniz:";
            // 
            // lblSifreUzunlugu
            // 
            this.lblSifreUzunlugu.AutoSize = true;
            this.lblSifreUzunlugu.Location = new System.Drawing.Point(15, 39);
            this.lblSifreUzunlugu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSifreUzunlugu.Name = "lblSifreUzunlugu";
            this.lblSifreUzunlugu.Size = new System.Drawing.Size(116, 21);
            this.lblSifreUzunlugu.TabIndex = 18;
            this.lblSifreUzunlugu.Text = "Şifre Uzunluğu:";
            // 
            // btnKopyala
            // 
            this.btnKopyala.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnKopyala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKopyala.ForeColor = System.Drawing.Color.White;
            this.btnKopyala.Location = new System.Drawing.Point(421, 157);
            this.btnKopyala.Margin = new System.Windows.Forms.Padding(0);
            this.btnKopyala.Name = "btnKopyala";
            this.btnKopyala.Size = new System.Drawing.Size(112, 40);
            this.btnKopyala.TabIndex = 17;
            this.btnKopyala.Text = "Kopyala";
            this.btnKopyala.UseVisualStyleBackColor = false;
            this.btnKopyala.Click += new System.EventHandler(this.btnKopyala_Click);
            // 
            // txtGucluSifre
            // 
            this.txtGucluSifre.BackColor = System.Drawing.Color.White;
            this.txtGucluSifre.ForeColor = System.Drawing.Color.Black;
            this.txtGucluSifre.Location = new System.Drawing.Point(15, 167);
            this.txtGucluSifre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGucluSifre.Name = "txtGucluSifre";
            this.txtGucluSifre.ReadOnly = true;
            this.txtGucluSifre.Size = new System.Drawing.Size(244, 29);
            this.txtGucluSifre.TabIndex = 16;
            // 
            // chkSemboller
            // 
            this.chkSemboller.AutoSize = true;
            this.chkSemboller.Location = new System.Drawing.Point(410, 128);
            this.chkSemboller.Margin = new System.Windows.Forms.Padding(0);
            this.chkSemboller.Name = "chkSemboller";
            this.chkSemboller.Size = new System.Drawing.Size(100, 25);
            this.chkSemboller.TabIndex = 15;
            this.chkSemboller.Text = "Semboller";
            this.chkSemboller.UseVisualStyleBackColor = true;
            this.chkSemboller.CheckedChanged += new System.EventHandler(this.btnYenidenOlustur_Click);
            // 
            // chkSayilar
            // 
            this.chkSayilar.AutoSize = true;
            this.chkSayilar.Location = new System.Drawing.Point(410, 98);
            this.chkSayilar.Margin = new System.Windows.Forms.Padding(0);
            this.chkSayilar.Name = "chkSayilar";
            this.chkSayilar.Size = new System.Drawing.Size(76, 25);
            this.chkSayilar.TabIndex = 14;
            this.chkSayilar.Text = "Sayılar";
            this.chkSayilar.UseVisualStyleBackColor = true;
            this.chkSayilar.CheckedChanged += new System.EventHandler(this.btnYenidenOlustur_Click);
            // 
            // chkBuyukHarfler
            // 
            this.chkBuyukHarfler.AutoSize = true;
            this.chkBuyukHarfler.Location = new System.Drawing.Point(410, 68);
            this.chkBuyukHarfler.Margin = new System.Windows.Forms.Padding(0);
            this.chkBuyukHarfler.Name = "chkBuyukHarfler";
            this.chkBuyukHarfler.Size = new System.Drawing.Size(124, 25);
            this.chkBuyukHarfler.TabIndex = 13;
            this.chkBuyukHarfler.Text = "Büyük Harfler";
            this.chkBuyukHarfler.UseVisualStyleBackColor = true;
            this.chkBuyukHarfler.CheckedChanged += new System.EventHandler(this.btnYenidenOlustur_Click);
            // 
            // chkKucukHarfler
            // 
            this.chkKucukHarfler.AutoSize = true;
            this.chkKucukHarfler.Location = new System.Drawing.Point(410, 38);
            this.chkKucukHarfler.Margin = new System.Windows.Forms.Padding(0);
            this.chkKucukHarfler.Name = "chkKucukHarfler";
            this.chkKucukHarfler.Size = new System.Drawing.Size(123, 25);
            this.chkKucukHarfler.TabIndex = 12;
            this.chkKucukHarfler.Text = "Küçük Harfler";
            this.chkKucukHarfler.UseVisualStyleBackColor = true;
            this.chkKucukHarfler.CheckedChanged += new System.EventHandler(this.btnYenidenOlustur_Click);
            // 
            // btnYenidenOlustur
            // 
            this.btnYenidenOlustur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnYenidenOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYenidenOlustur.ForeColor = System.Drawing.Color.White;
            this.btnYenidenOlustur.Location = new System.Drawing.Point(263, 157);
            this.btnYenidenOlustur.Margin = new System.Windows.Forms.Padding(0);
            this.btnYenidenOlustur.Name = "btnYenidenOlustur";
            this.btnYenidenOlustur.Size = new System.Drawing.Size(154, 40);
            this.btnYenidenOlustur.TabIndex = 22;
            this.btnYenidenOlustur.Text = "Yeniden Oluştur";
            this.btnYenidenOlustur.UseVisualStyleBackColor = false;
            this.btnYenidenOlustur.Click += new System.EventHandler(this.btnYenidenOlustur_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Güçlü Şifre Oluştur";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(514, 0);
            this.button6.Margin = new System.Windows.Forms.Padding(0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(30, 30);
            this.button6.TabIndex = 49;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.kapat_Click);
            // 
            // FrmGucluSifreOlustur
            // 
            this.AcceptButton = this.btnKopyala;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(545, 211);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label1);
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
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button button6;
    }
}