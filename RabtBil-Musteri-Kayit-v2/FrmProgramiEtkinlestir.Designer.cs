using System.Drawing;
using System.Windows.Forms;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProgramiEtkinlestir));
            this.lblLisansAnahtari = new System.Windows.Forms.Label();
            this.txtLisansAnahtari = new System.Windows.Forms.TextBox();
            this.lblEpostaAdresi = new System.Windows.Forms.Label();
            this.txtEpostaAdresi = new System.Windows.Forms.TextBox();
            this.btnEtkinlestir = new System.Windows.Forms.Button();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.btnKapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLisansAnahtari
            // 
            this.lblLisansAnahtari.AutoSize = true;
            this.lblLisansAnahtari.Location = new System.Drawing.Point(15, 97);
            this.lblLisansAnahtari.Name = "lblLisansAnahtari";
            this.lblLisansAnahtari.Size = new System.Drawing.Size(119, 21);
            this.lblLisansAnahtari.TabIndex = 13;
            this.lblLisansAnahtari.Text = "Lisans Anahtarı:";
            // 
            // txtLisansAnahtari
            // 
            this.txtLisansAnahtari.Location = new System.Drawing.Point(15, 122);
            this.txtLisansAnahtari.Name = "txtLisansAnahtari";
            this.txtLisansAnahtari.Size = new System.Drawing.Size(300, 29);
            this.txtLisansAnahtari.TabIndex = 1;
            // 
            // lblEpostaAdresi
            // 
            this.lblEpostaAdresi.AutoSize = true;
            this.lblEpostaAdresi.Location = new System.Drawing.Point(15, 39);
            this.lblEpostaAdresi.Name = "lblEpostaAdresi";
            this.lblEpostaAdresi.Size = new System.Drawing.Size(113, 21);
            this.lblEpostaAdresi.TabIndex = 15;
            this.lblEpostaAdresi.Text = "E-posta Adresi:";
            // 
            // txtEpostaAdresi
            // 
            this.txtEpostaAdresi.Location = new System.Drawing.Point(15, 64);
            this.txtEpostaAdresi.Name = "txtEpostaAdresi";
            this.txtEpostaAdresi.Size = new System.Drawing.Size(300, 29);
            this.txtEpostaAdresi.TabIndex = 0;
            // 
            // btnEtkinlestir
            // 
            this.btnEtkinlestir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEtkinlestir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEtkinlestir.ForeColor = System.Drawing.Color.White;
            this.btnEtkinlestir.Location = new System.Drawing.Point(15, 157);
            this.btnEtkinlestir.Name = "btnEtkinlestir";
            this.btnEtkinlestir.Size = new System.Drawing.Size(300, 40);
            this.btnEtkinlestir.TabIndex = 2;
            this.btnEtkinlestir.Text = "Etkinleştir";
            this.btnEtkinlestir.UseVisualStyleBackColor = false;
            this.btnEtkinlestir.Click += new System.EventHandler(this.btnEtkinlestir_Click);
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.BackColor = System.Drawing.Color.White;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(15, 9);
            this.lblBaslik.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(177, 25);
            this.lblBaslik.TabIndex = 17;
            this.lblBaslik.Text = "Programı Etkinleştir";
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.White;
            this.btnKapat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.Image")));
            this.btnKapat.Location = new System.Drawing.Point(297, 1);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(0);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(30, 30);
            this.btnKapat.TabIndex = 3;
            this.btnKapat.TabStop = false;
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // FrmProgramiEtkinlestir
            // 
            this.AcceptButton = this.btnEtkinlestir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnKapat;
            this.ClientSize = new System.Drawing.Size(328, 207);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.btnEtkinlestir);
            this.Controls.Add(this.lblEpostaAdresi);
            this.Controls.Add(this.txtEpostaAdresi);
            this.Controls.Add(this.lblLisansAnahtari);
            this.Controls.Add(this.txtLisansAnahtari);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(328, 207);
            this.MinimumSize = new System.Drawing.Size(328, 207);
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
        private System.Windows.Forms.Label lblBaslik;
        public System.Windows.Forms.Button btnKapat;
    }
}