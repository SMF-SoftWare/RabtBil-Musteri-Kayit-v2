namespace RabtBil_Musteri_Kayit_v2
{
    partial class FrmProgramiEtkinlestir
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
            this.lblLisansAnahtari = new System.Windows.Forms.Label();
            this.txtLisansAnahtari = new System.Windows.Forms.TextBox();
            this.lblEpostaAdresi = new System.Windows.Forms.Label();
            this.txtEpostaAdresi = new System.Windows.Forms.TextBox();
            this.btnEtkinlestir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLisansAnahtari
            // 
            this.lblLisansAnahtari.AutoSize = true;
            this.lblLisansAnahtari.Font = new System.Drawing.Font("Consolas", 9F);
            this.lblLisansAnahtari.Location = new System.Drawing.Point(11, 47);
            this.lblLisansAnahtari.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLisansAnahtari.Name = "lblLisansAnahtari";
            this.lblLisansAnahtari.Size = new System.Drawing.Size(119, 14);
            this.lblLisansAnahtari.TabIndex = 13;
            this.lblLisansAnahtari.Text = "Lisans Anahtarı:";
            // 
            // txtLisansAnahtari
            // 
            this.txtLisansAnahtari.Font = new System.Drawing.Font("Consolas", 11F);
            this.txtLisansAnahtari.Location = new System.Drawing.Point(134, 41);
            this.txtLisansAnahtari.Margin = new System.Windows.Forms.Padding(2);
            this.txtLisansAnahtari.Name = "txtLisansAnahtari";
            this.txtLisansAnahtari.Size = new System.Drawing.Size(277, 25);
            this.txtLisansAnahtari.TabIndex = 1;
            // 
            // lblEpostaAdresi
            // 
            this.lblEpostaAdresi.AutoSize = true;
            this.lblEpostaAdresi.Font = new System.Drawing.Font("Consolas", 9F);
            this.lblEpostaAdresi.Location = new System.Drawing.Point(18, 18);
            this.lblEpostaAdresi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEpostaAdresi.Name = "lblEpostaAdresi";
            this.lblEpostaAdresi.Size = new System.Drawing.Size(112, 14);
            this.lblEpostaAdresi.TabIndex = 15;
            this.lblEpostaAdresi.Text = "E-posta Adresi:";
            // 
            // txtEpostaAdresi
            // 
            this.txtEpostaAdresi.Font = new System.Drawing.Font("Consolas", 11F);
            this.txtEpostaAdresi.Location = new System.Drawing.Point(134, 12);
            this.txtEpostaAdresi.Margin = new System.Windows.Forms.Padding(2);
            this.txtEpostaAdresi.Name = "txtEpostaAdresi";
            this.txtEpostaAdresi.Size = new System.Drawing.Size(277, 25);
            this.txtEpostaAdresi.TabIndex = 0;
            // 
            // btnEtkinlestir
            // 
            this.btnEtkinlestir.Font = new System.Drawing.Font("Consolas", 11F);
            this.btnEtkinlestir.Location = new System.Drawing.Point(134, 70);
            this.btnEtkinlestir.Margin = new System.Windows.Forms.Padding(2);
            this.btnEtkinlestir.Name = "btnEtkinlestir";
            this.btnEtkinlestir.Size = new System.Drawing.Size(277, 40);
            this.btnEtkinlestir.TabIndex = 2;
            this.btnEtkinlestir.Text = "Etkinleştir";
            this.btnEtkinlestir.UseVisualStyleBackColor = true;
            this.btnEtkinlestir.Click += new System.EventHandler(this.btnEtkinlestir_Click);
            // 
            // FrmProgramiEtkinlestir
            // 
            this.AcceptButton = this.btnEtkinlestir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 121);
            this.Controls.Add(this.btnEtkinlestir);
            this.Controls.Add(this.lblEpostaAdresi);
            this.Controls.Add(this.txtEpostaAdresi);
            this.Controls.Add(this.lblLisansAnahtari);
            this.Controls.Add(this.txtLisansAnahtari);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmProgramiEtkinlestir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProgramiEtkinlestir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblLisansAnahtari;
        public System.Windows.Forms.TextBox txtLisansAnahtari;
        public System.Windows.Forms.Label lblEpostaAdresi;
        public System.Windows.Forms.TextBox txtEpostaAdresi;
        public System.Windows.Forms.Button btnEtkinlestir;
    }
}