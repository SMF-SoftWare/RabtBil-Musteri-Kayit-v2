using Microsoft.Office.Interop.Excel;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using Application = System.Windows.Forms.Application;
using DataTable = System.Data.DataTable;

using Excel = Microsoft.Office.Interop.Excel;

using Font = System.Drawing.Font;

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

        private string _aramaTuru;
        private readonly string[] _aramaAlanlari = { "Id", "MusteriAdi", "Telefon", "CihazModeli", "CihazinSeriNumarasi", "ArizaTanimi", "Aksesuarlar", "EkBilgiler", "TakipNumarasi", "CihazDurumu", "Ucret", "KaydiYapanID", "KayitTarihi", "GuncelleyenID", "GuncellemeTarihi", "TeslimEdenID", "TeslimAlan", "TeslimTarihi" };

        private void FrmKayitlariGoster_Load(object sender, EventArgs e)
        {
            if (SMF.YoneticiMi)
            {
                btnExcelAktar.Enabled = true;
            }

            YazicilariListele();
            VerileriGetir();

            cmbAramaAlanlari.Items.AddRange(_aramaAlanlari);
            cmbAramaAlanlari.SelectedIndex = 0;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Seçilen Kayıt Silinsin Mi?", SMF.PrograminTamAdi, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.No)
            {
                return;
            }

            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM MusteriBilgileri WHERE Id=@Id", SMF.Baglanti);
                cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(dgvRabtBilDB.CurrentRow?.Cells[0].Value));
                SMF.BaglantiKapaliysaAc();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Seçilen Kayıt Silindi", SMF.PrograminTamAdi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                VerileriGetir();
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

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Yazdırılsın Mı?", SMF.PrograminTamAdi, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.No)
            {
                return;
            }

            try
            {
                PrintDocument pd = new PrintDocument { PrinterSettings = { PrinterName = cmbYaziciListesi.Text } };
                pd.PrintPage += pdcBelge_PrintPage;
                pd.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
        }

        private void btnBaskiOnizleme_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Baskı Önizlemesi Açılsın Mı?", SMF.PrograminTamAdi, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.No)
            {
                return;
            }

            try
            {
                ppdBaskiOnizleme.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            AramaYap();
        }

        private void dgvRabtBilDB_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Guncelle();
        }

        private void cmbAramaAlanlari_SelectedIndexChanged(object sender, EventArgs e)
        {
            AramaYap();
        }

        private void cmbYaziciListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnYazdir.Enabled = cmbYaziciListesi.Text != "";
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pdcBelge_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font yaziTipi = new Font("Segoe UI", 12, FontStyle.Regular);
            SolidBrush yaziRengi = new SolidBrush(Color.Black);
            e.Graphics.DrawImage(Properties.Resources.RabtBilYaziciSablonu, 0, 0);
            e.Graphics.DrawString(dgvRabtBilDB.CurrentRow?.Cells[1].Value.ToString(), yaziTipi, yaziRengi, 244, 356); //MüşteriAdı
            e.Graphics.DrawString(dgvRabtBilDB.CurrentRow?.Cells[2].Value.ToString(), yaziTipi, yaziRengi, 244, 400); //Telefon
            e.Graphics.DrawString(dgvRabtBilDB.CurrentRow?.Cells[3].Value.ToString(), yaziTipi, yaziRengi, 244, 446); //CihazModeli
            e.Graphics.DrawString(dgvRabtBilDB.CurrentRow?.Cells[4].Value.ToString(), yaziTipi, yaziRengi, 244, 490); //SeriNumarası
            e.Graphics.DrawString(dgvRabtBilDB.CurrentRow?.Cells[5].Value.ToString(), yaziTipi, yaziRengi, 244, 533); //ArızaTanımı
            e.Graphics.DrawString(dgvRabtBilDB.CurrentRow?.Cells[9].Value.ToString(), yaziTipi, yaziRengi, 244, 577); //CihazDurumu
            e.Graphics.DrawString(dgvRabtBilDB.CurrentRow?.Cells[8].Value.ToString(), yaziTipi, yaziRengi, 244, 624); //TakipNumarası
            e.Graphics.DrawString(dgvRabtBilDB.CurrentRow?.Cells[6].Value.ToString(), yaziTipi, yaziRengi, 244, 671); //Aksesuar
            e.Graphics.DrawString(dgvRabtBilDB.CurrentRow?.Cells[10].Value + " ₺", yaziTipi, yaziRengi, 657, 774);
            e.Graphics.DrawString(dgvRabtBilDB.CurrentRow?.Cells[12].Value.ToString(), yaziTipi, yaziRengi, 589, 310); //Tarih
        }

        public void AramaYap()
        {
            try
            {
                switch (cmbAramaAlanlari.SelectedIndex)
                {
                    case (int)AramaTuru.Id:
                        _aramaTuru = _aramaAlanlari[0];
                        break;

                    case (int)AramaTuru.MusteriAdi:
                        _aramaTuru = _aramaAlanlari[1];
                        break;

                    case (int)AramaTuru.Telefon:
                        _aramaTuru = _aramaAlanlari[2];
                        break;

                    case (int)AramaTuru.CihazModeli:
                        _aramaTuru = _aramaAlanlari[3];
                        break;

                    case (int)AramaTuru.CihazinSeriNumarasi:
                        _aramaTuru = _aramaAlanlari[4];
                        break;

                    case (int)AramaTuru.ArizaTanimi:
                        _aramaTuru = _aramaAlanlari[5];
                        break;

                    case (int)AramaTuru.Aksesuarlar:
                        _aramaTuru = _aramaAlanlari[6];
                        break;

                    case (int)AramaTuru.EkBilgiler:
                        _aramaTuru = _aramaAlanlari[7];
                        break;

                    case (int)AramaTuru.TakipNumarasi:
                        _aramaTuru = _aramaAlanlari[8];
                        break;

                    case (int)AramaTuru.CihazDurumu:
                        _aramaTuru = _aramaAlanlari[9];
                        break;

                    case (int)AramaTuru.Ucret:
                        _aramaTuru = _aramaAlanlari[10];
                        break;

                    case (int)AramaTuru.KaydiYapanID:
                        _aramaTuru = _aramaAlanlari[11];
                        break;

                    case (int)AramaTuru.KayitTarihi:
                        _aramaTuru = _aramaAlanlari[12];
                        break;

                    case (int)AramaTuru.GuncelleyenID:
                        _aramaTuru = _aramaAlanlari[13];
                        break;

                    case (int)AramaTuru.GuncellemeTarihi:
                        _aramaTuru = _aramaAlanlari[14];
                        break;

                    case (int)AramaTuru.TeslimEdenID:
                        _aramaTuru = _aramaAlanlari[15];
                        break;

                    case (int)AramaTuru.TeslimAlan:
                        _aramaTuru = _aramaAlanlari[16];
                        break;

                    case (int)AramaTuru.TeslimTarihi:
                        _aramaTuru = _aramaAlanlari[17];
                        break;
                }
                SMF.BaglantiKapaliysaAc();
                SqlDataAdapter da = new SqlDataAdapter($"SELECT * FROM MusteriBilgileri WHERE {_aramaTuru} LIKE @Ara", SMF.Baglanti);
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

        public void Guncelle()
        {
            FrmPersonelTeknikServisFormu frm = (FrmPersonelTeknikServisFormu)Application.OpenForms["FrmPersonelTeknikServisFormu"];
            if (frm != null)
            {
                frm.lblMusteriNo.Text = dgvRabtBilDB.CurrentRow?.Cells[0].Value.ToString();
                frm.txtMusteriAdi.Text = dgvRabtBilDB.CurrentRow?.Cells[1].Value.ToString();
                frm.mtxTelefon.Text = dgvRabtBilDB.CurrentRow?.Cells[2].Value.ToString();
                frm.txtCihazModeli.Text = dgvRabtBilDB.CurrentRow?.Cells[3].Value.ToString();
                frm.txtCihazinSeriNumarası.Text = dgvRabtBilDB.CurrentRow?.Cells[4].Value.ToString();
                frm.txtArizaninTanimi.Text = dgvRabtBilDB.CurrentRow?.Cells[5].Value.ToString();
                frm.txtAksesuarlar.Text = dgvRabtBilDB.CurrentRow?.Cells[6].Value.ToString();
                frm.txtEkBilgiler.Text = dgvRabtBilDB.CurrentRow?.Cells[7].Value.ToString();
                frm.txtTakipNumarasi.Text = dgvRabtBilDB.CurrentRow?.Cells[8].Value.ToString();
                frm.txtCihazDurumu.Text = dgvRabtBilDB.CurrentRow?.Cells[9].Value.ToString();
                frm.txtUcret.Text = $"{dgvRabtBilDB.CurrentRow?.Cells[10].Value:#.00}";

                frm.btnYeniKayit.Enabled = true;
                frm.btnKaydet.Enabled = false;
                frm.btnGuncelle.Enabled = true;
                frm.btnTeslimEt.Enabled = true;
                frm.btnYazdir.Enabled = true;
            }

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

        public void YazicilariListele()
        {
            try
            {
                foreach (String yazici in PrinterSettings.InstalledPrinters)
                {
                    cmbYaziciListesi.Items.Add(yazici);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
        }

        private enum AramaTuru
        {
            Id,
            MusteriAdi,
            Telefon,
            CihazModeli,
            CihazinSeriNumarasi,
            ArizaTanimi,
            Aksesuarlar,
            EkBilgiler,
            TakipNumarasi,
            CihazDurumu,
            Ucret,
            KaydiYapanID,
            KayitTarihi,
            GuncelleyenID,
            GuncellemeTarihi,
            TeslimEdenID,
            TeslimAlan,
            TeslimTarihi,
        }
    }
}