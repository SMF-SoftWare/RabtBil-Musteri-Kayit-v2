namespace RabtBil_Musteri_Kayit_v2
{
    partial class FrmHesapAc
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
            this.BttnYoneticiGiris = new System.Windows.Forms.Button();
            this.BttnPersonelGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BttnYoneticiGiris
            // 
            this.BttnYoneticiGiris.Location = new System.Drawing.Point(45, 38);
            this.BttnYoneticiGiris.Name = "BttnYoneticiGiris";
            this.BttnYoneticiGiris.Size = new System.Drawing.Size(269, 47);
            this.BttnYoneticiGiris.TabIndex = 0;
            this.BttnYoneticiGiris.Text = "Yönetici Girişi";
            this.BttnYoneticiGiris.UseVisualStyleBackColor = true;
            this.BttnYoneticiGiris.Click += new System.EventHandler(this.BttnYoneticiGiris_Click);
            // 
            // BttnPersonelGiris
            // 
            this.BttnPersonelGiris.Location = new System.Drawing.Point(45, 113);
            this.BttnPersonelGiris.Name = "BttnPersonelGiris";
            this.BttnPersonelGiris.Size = new System.Drawing.Size(269, 47);
            this.BttnPersonelGiris.TabIndex = 1;
            this.BttnPersonelGiris.Text = "Personel Girişi";
            this.BttnPersonelGiris.UseVisualStyleBackColor = true;
            this.BttnPersonelGiris.Click += new System.EventHandler(this.BttnPersonelGiris_Click);
            // 
            // FrmHesapAc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 208);
            this.Controls.Add(this.BttnPersonelGiris);
            this.Controls.Add(this.BttnYoneticiGiris);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmHesapAc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hesap Aç";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BttnYoneticiGiris;
        private System.Windows.Forms.Button BttnPersonelGiris;
    }
}

