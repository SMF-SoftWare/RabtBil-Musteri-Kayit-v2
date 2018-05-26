namespace RabtBil_Musteri_Kayit_v2
{
    partial class FrmKayitlariGoster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKayitlariGoster));
            this.dgvRabtBilDB = new System.Windows.Forms.DataGridView();
            this.cmbRaporlar = new System.Windows.Forms.ComboBox();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.btnExcelAktar = new System.Windows.Forms.Button();
            this.lblAlanSecin = new System.Windows.Forms.Label();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnYenile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRabtBilDB)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRabtBilDB
            // 
            this.dgvRabtBilDB.AllowUserToAddRows = false;
            this.dgvRabtBilDB.AllowUserToOrderColumns = true;
            this.dgvRabtBilDB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRabtBilDB.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRabtBilDB.BackgroundColor = System.Drawing.Color.White;
            this.dgvRabtBilDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRabtBilDB.Location = new System.Drawing.Point(15, 81);
            this.dgvRabtBilDB.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRabtBilDB.MultiSelect = false;
            this.dgvRabtBilDB.Name = "dgvRabtBilDB";
            this.dgvRabtBilDB.ReadOnly = true;
            this.dgvRabtBilDB.RowHeadersVisible = false;
            this.dgvRabtBilDB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRabtBilDB.Size = new System.Drawing.Size(849, 412);
            this.dgvRabtBilDB.TabIndex = 4;
            this.dgvRabtBilDB.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRabtBilDB_CellDoubleClick);
            // 
            // cmbRaporlar
            // 
            this.cmbRaporlar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRaporlar.Enabled = false;
            this.cmbRaporlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRaporlar.FormattingEnabled = true;
            this.cmbRaporlar.Items.AddRange(new object[] {
            "Rapor Seçin!",
            "Günlük Rapor",
            "Haftalık Rapor",
            "Aylık Rapor",
            "Yıllık Rapor",
            "Garantili Ürünler",
            "Garanti Dışı Ürünler",
            "Bakım Sözleşmeli Ürünler",
            "Teslim Edilen Ürünler",
            "Teslim Edilmeyen Ürünler"});
            this.cmbRaporlar.Location = new System.Drawing.Point(328, 45);
            this.cmbRaporlar.Margin = new System.Windows.Forms.Padding(2);
            this.cmbRaporlar.Name = "cmbRaporlar";
            this.cmbRaporlar.Size = new System.Drawing.Size(227, 29);
            this.cmbRaporlar.TabIndex = 2;
            this.cmbRaporlar.SelectedIndexChanged += new System.EventHandler(this.cmbRaporlar_SelectedIndexChanged);
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(653, 45);
            this.txtArama.Margin = new System.Windows.Forms.Padding(2);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(211, 29);
            this.txtArama.TabIndex = 3;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // btnExcelAktar
            // 
            this.btnExcelAktar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExcelAktar.Enabled = false;
            this.btnExcelAktar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcelAktar.ForeColor = System.Drawing.Color.White;
            this.btnExcelAktar.Location = new System.Drawing.Point(169, 38);
            this.btnExcelAktar.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcelAktar.Name = "btnExcelAktar";
            this.btnExcelAktar.Size = new System.Drawing.Size(150, 40);
            this.btnExcelAktar.TabIndex = 1;
            this.btnExcelAktar.Text = "Excel\'e Aktar";
            this.btnExcelAktar.UseVisualStyleBackColor = false;
            this.btnExcelAktar.Click += new System.EventHandler(this.btnExcelAktar_Click);
            // 
            // lblAlanSecin
            // 
            this.lblAlanSecin.AutoSize = true;
            this.lblAlanSecin.Location = new System.Drawing.Point(560, 48);
            this.lblAlanSecin.Name = "lblAlanSecin";
            this.lblAlanSecin.Size = new System.Drawing.Size(88, 21);
            this.lblAlanSecin.TabIndex = 44;
            this.lblAlanSecin.Text = "Arama Yap:";
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lblBaslik.Location = new System.Drawing.Point(15, 9);
            this.lblBaslik.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(177, 25);
            this.lblBaslik.TabIndex = 45;
            this.lblBaslik.Text = "Teknik Servis Formu";
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.White;
            this.btnKapat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.Image")));
            this.btnKapat.Location = new System.Drawing.Point(848, 1);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(0);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(30, 30);
            this.btnKapat.TabIndex = 46;
            this.btnKapat.TabStop = false;
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYenile.ForeColor = System.Drawing.Color.White;
            this.btnYenile.Location = new System.Drawing.Point(15, 38);
            this.btnYenile.Margin = new System.Windows.Forms.Padding(2);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(150, 40);
            this.btnYenile.TabIndex = 0;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = false;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // FrmKayitlariGoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnKapat;
            this.ClientSize = new System.Drawing.Size(879, 510);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.lblAlanSecin);
            this.Controls.Add(this.btnExcelAktar);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.cmbRaporlar);
            this.Controls.Add(this.dgvRabtBilDB);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(879, 510);
            this.MinimumSize = new System.Drawing.Size(879, 510);
            this.Name = "FrmKayitlariGoster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmKayitlariGoster";
            this.Load += new System.EventHandler(this.FrmKayitlariGoster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRabtBilDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dgvRabtBilDB;
        public System.Windows.Forms.ComboBox cmbRaporlar;
        public System.Windows.Forms.TextBox txtArama;
        public System.Windows.Forms.Button btnExcelAktar;
        private System.Windows.Forms.Label lblAlanSecin;
        private System.Windows.Forms.Label lblBaslik;
        public System.Windows.Forms.Button btnKapat;
        public System.Windows.Forms.Button btnYenile;
    }
}