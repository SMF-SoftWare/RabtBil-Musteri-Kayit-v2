namespace RabtBil_Musteri_Kayit_v2
{
    partial class FrmUrunTeslim
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
            this.components = new System.ComponentModel.Container();
            this.lblTeslimEdenPersonel = new System.Windows.Forms.Label();
            this.txtTeslimEdenPersonel = new System.Windows.Forms.TextBox();
            this.txtTeslimAlanKisi = new System.Windows.Forms.TextBox();
            this.lblTeslimAlanKisi = new System.Windows.Forms.Label();
            this.lblTeslimTarihi = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.tlStrip = new System.Windows.Forms.ToolStrip();
            this.tslblTarihSaat = new System.Windows.Forms.ToolStripLabel();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.tmrTarihSaat = new System.Windows.Forms.Timer(this.components);
            this.tlStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTeslimEdenPersonel
            // 
            this.lblTeslimEdenPersonel.AutoSize = true;
            this.lblTeslimEdenPersonel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTeslimEdenPersonel.Location = new System.Drawing.Point(18, 16);
            this.lblTeslimEdenPersonel.Name = "lblTeslimEdenPersonel";
            this.lblTeslimEdenPersonel.Size = new System.Drawing.Size(133, 13);
            this.lblTeslimEdenPersonel.TabIndex = 0;
            this.lblTeslimEdenPersonel.Text = "Teslim Eden Personel:";
            // 
            // txtTeslimEdenPersonel
            // 
            this.txtTeslimEdenPersonel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTeslimEdenPersonel.Location = new System.Drawing.Point(15, 32);
            this.txtTeslimEdenPersonel.MaxLength = 30;
            this.txtTeslimEdenPersonel.Name = "txtTeslimEdenPersonel";
            this.txtTeslimEdenPersonel.Size = new System.Drawing.Size(244, 23);
            this.txtTeslimEdenPersonel.TabIndex = 1;
            // 
            // txtTeslimAlanKisi
            // 
            this.txtTeslimAlanKisi.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTeslimAlanKisi.Location = new System.Drawing.Point(15, 79);
            this.txtTeslimAlanKisi.MaxLength = 30;
            this.txtTeslimAlanKisi.Name = "txtTeslimAlanKisi";
            this.txtTeslimAlanKisi.Size = new System.Drawing.Size(244, 23);
            this.txtTeslimAlanKisi.TabIndex = 3;
            // 
            // lblTeslimAlanKisi
            // 
            this.lblTeslimAlanKisi.AutoSize = true;
            this.lblTeslimAlanKisi.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTeslimAlanKisi.Location = new System.Drawing.Point(17, 63);
            this.lblTeslimAlanKisi.Name = "lblTeslimAlanKisi";
            this.lblTeslimAlanKisi.Size = new System.Drawing.Size(109, 13);
            this.lblTeslimAlanKisi.TabIndex = 2;
            this.lblTeslimAlanKisi.Text = "Teslim Alan Kişi:";
            // 
            // lblTeslimTarihi
            // 
            this.lblTeslimTarihi.AutoSize = true;
            this.lblTeslimTarihi.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTeslimTarihi.Location = new System.Drawing.Point(16, 110);
            this.lblTeslimTarihi.Name = "lblTeslimTarihi";
            this.lblTeslimTarihi.Size = new System.Drawing.Size(91, 13);
            this.lblTeslimTarihi.TabIndex = 4;
            this.lblTeslimTarihi.Text = "Teslim Tarihi:";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.Location = new System.Drawing.Point(113, 110);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(37, 13);
            this.lblTarih.TabIndex = 5;
            this.lblTarih.Text = "Tarih";
            // 
            // tlStrip
            // 
            this.tlStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlStrip.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tlStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblTarihSaat});
            this.tlStrip.Location = new System.Drawing.Point(0, 173);
            this.tlStrip.Name = "tlStrip";
            this.tlStrip.Size = new System.Drawing.Size(275, 25);
            this.tlStrip.TabIndex = 6;
            this.tlStrip.Text = "toolStrip1";
            // 
            // tslblTarihSaat
            // 
            this.tslblTarihSaat.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tslblTarihSaat.Name = "tslblTarihSaat";
            this.tslblTarihSaat.Size = new System.Drawing.Size(61, 22);
            this.tslblTarihSaat.Text = "TarihSaat";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(15, 135);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(72, 31);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(92, 135);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(72, 31);
            this.btnTemizle.TabIndex = 8;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            // 
            // tmrTarihSaat
            // 
            this.tmrTarihSaat.Tick += new System.EventHandler(this.tmrTarihSaat_Tick);
            // 
            // FrmUrunTeslim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 198);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.tlStrip);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblTeslimTarihi);
            this.Controls.Add(this.txtTeslimAlanKisi);
            this.Controls.Add(this.lblTeslimAlanKisi);
            this.Controls.Add(this.txtTeslimEdenPersonel);
            this.Controls.Add(this.lblTeslimEdenPersonel);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUrunTeslim";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmUrunTeslim_Load);
            this.tlStrip.ResumeLayout(false);
            this.tlStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTeslimEdenPersonel;
        private System.Windows.Forms.TextBox txtTeslimEdenPersonel;
        private System.Windows.Forms.TextBox txtTeslimAlanKisi;
        private System.Windows.Forms.Label lblTeslimAlanKisi;
        private System.Windows.Forms.Label lblTeslimTarihi;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.ToolStrip tlStrip;
        private System.Windows.Forms.ToolStripLabel tslblTarihSaat;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Timer tmrTarihSaat;
    }
}