using Microsoft.Office.Interop.Excel;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Application = System.Windows.Forms.Application;
using DataTable = System.Data.DataTable;

using Excel = Microsoft.Office.Interop.Excel;

namespace RabtBil_Musteri_Kayit_v2
{
    public partial class FrmKayitlariGoster : Form
    {
        public FrmKayitlariGoster()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        private void FrmKayitlariGoster_Load(object sender, EventArgs e)
        {
            if (SMF.YoneticiMi)
            {
                btnExcelAktar.Enabled = true;
            }

            VerileriGetir();
            cmbRaporlar.SelectedIndex = 0;
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            VerileriGetir();

            txtArama.Clear();
            cmbRaporlar.SelectedIndex = 0;
        }

        private void btnExcelAktar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Tüm Kayıtlar Excel'e Aktarılsın Mı?", SMF.PrograminTamAdi, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.No)
            {
                return;
            }

            try
            {
                Excel.Application excel = new Excel.Application { Visible = true };
                object missing = Type.Missing;
                Workbook workbook = excel.Workbooks.Add(missing);
                Worksheet shet1 = (Worksheet)workbook.Sheets[1];
                const int startCol = 1;
                int startRow = 1;
                for (int j = 0; j < dgvRabtBilDB.Columns.Count; j++)
                {
                    Range myRange = (Range)shet1.Cells[startRow, startCol + j];
                    myRange.Value2 = dgvRabtBilDB.Columns[j].HeaderText;
                }

                startRow++;
                for (int i = 0; i < dgvRabtBilDB.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvRabtBilDB.Columns.Count; j++)
                    {
                        Range myRange = (Range)shet1.Cells[startRow + i, startCol + j];
                        myRange.Value2 = dgvRabtBilDB[j, i].Value == null ? "" : dgvRabtBilDB[j, i].Value;
                        myRange.Select();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SMF.BaglantiKapaliysaAc();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM MusteriBilgileri WHERE MusteriAdi LIKE @Ara OR Telefon LIKE @Ara OR CihazModeli LIKE @Ara OR CihazinSeriNumarasi LIKE @Ara OR ArizaTanimi LIKE @Ara OR Aksesuarlar LIKE @Ara OR EkBilgiler LIKE @Ara OR TakipNumarasi LIKE @Ara OR CihazDurumu LIKE @Ara OR Ucret LIKE @Ara OR TeslimAlan LIKE @Ara", SMF.Baglanti);
                da.SelectCommand.Parameters.AddWithValue("@Ara", $"%{txtArama.Text.ToLower()}%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvRabtBilDB.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
            finally
            {
                SMF.Baglanti.Close();
            }
        }

        private void dgvRabtBilDB_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmPersonelTeknikServisFormu frm = (FrmPersonelTeknikServisFormu)Application.OpenForms["FrmPersonelTeknikServisFormu"];
            frm.cmbCihazDurumu.SelectedIndex = 0;
            frm.lblMusteriNo.Text = dgvRabtBilDB.CurrentRow?.Cells[0].Value.ToString();
            frm.txtMusteriAdi.Text = dgvRabtBilDB.CurrentRow?.Cells[1].Value.ToString();
            frm.mtxTelefon.Text = dgvRabtBilDB.CurrentRow?.Cells[2].Value.ToString();
            frm.txtCihazModeli.Text = dgvRabtBilDB.CurrentRow?.Cells[3].Value.ToString();
            frm.txtCihazinSeriNumarası.Text = dgvRabtBilDB.CurrentRow?.Cells[4].Value.ToString();
            frm.txtArizaninTanimi.Text = dgvRabtBilDB.CurrentRow?.Cells[5].Value.ToString();
            frm.txtAksesuarlar.Text = dgvRabtBilDB.CurrentRow?.Cells[6].Value.ToString();
            frm.txtEkBilgiler.Text = dgvRabtBilDB.CurrentRow?.Cells[7].Value.ToString();
            frm.txtTakipNumarasi.Text = dgvRabtBilDB.CurrentRow?.Cells[8].Value.ToString();
            frm.cmbCihazDurumu.Text = dgvRabtBilDB.CurrentRow?.Cells[9].Value.ToString();
            frm.txtUcret.Text = $"{dgvRabtBilDB.CurrentRow?.Cells[10].Value:#.00}";

            frm.btnYeniKayit.Enabled = true;
            frm.btnKaydet.Enabled = false;
            frm.btnGuncelle.Enabled = true;
            frm.btnTeslimEt.Enabled = true;
            frm.btnYazdir.Enabled = true;
            frm.btnSil.Enabled = true;

            Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void VerileriGetir()
        {
            try
            {
                SMF.BaglantiKapaliysaAc();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM MusteriBilgileri", SMF.Baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvRabtBilDB.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
            finally
            {
                SMF.Baglanti.Close();
            }
        }
    }
}