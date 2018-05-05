using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Font = System.Drawing.Font;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;

namespace RabtBil_Musteri_Kayit_v2
{
    public partial class FrmKayitlariGoster : Form
    {
        private SMF SMF = new SMF();

        public FrmKayitlariGoster()
        {
            InitializeComponent();
        }

        private string _aramaTuru;

        private readonly string[] _aramaAlanlari = { "Id", "FormNo", "MusteriAdi", "Telefon", "UrunModeli", "UrunKodlari", "ArizaTanimi", "Aksesuarlar", "EkBilgiler", "UrunTakipNo", "UrunDurumu", "Ucret", "KaydiYapanID", "KayitTarihi", "GuncellemeTarihi", "TeslimEdenID", "TeslimAlan", "TeslimTarihi" };

        public void YazicilariListele()
        {
            foreach (String yazici in PrinterSettings.InstalledPrinters)
            {
                cmbYaziciListesi.Items.Add(yazici);
            }
        }

        private void FrmKayitlariGoster_Load(object sender, EventArgs e)
        {
            YazicilariListele();
            VerileriGetir();
            CmbDoldur();
            cmbAramaAlanlari.SelectedIndex = 0;
            tmrTarihSaat.Enabled = true;
        }

        private void dgvRabtBilDB_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Guncelle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM MusteriBilgileri WHERE Id=@Id", SMF.Baglanti);
                cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(dgvRabtBilDB.CurrentRow?.Cells[0].Value.ToString()));
                if (SMF.Baglanti.State != ConnectionState.Open)
                    SMF.Baglanti.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Resources.secilenKayitSilindi", SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                VerileriGetir();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Resources.Hata");
            }
            finally
            {
                SMF.Baglanti.Close();
            }
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            try
            {
                switch (cmbAramaAlanlari.SelectedIndex)
                {
                    case (int)AramaTuru.Id:
                        _aramaTuru = _aramaAlanlari[0];
                        break;

                    case (int)AramaTuru.FormNo:
                        _aramaTuru = _aramaAlanlari[1];
                        break;

                    case (int)AramaTuru.MusteriAdi:
                        _aramaTuru = _aramaAlanlari[2];
                        break;

                    case (int)AramaTuru.Telefon:
                        _aramaTuru = _aramaAlanlari[3];
                        break;

                    case (int)AramaTuru.UrunModeli:
                        _aramaTuru = _aramaAlanlari[4];
                        break;

                    case (int)AramaTuru.UrunKodlari:
                        _aramaTuru = _aramaAlanlari[5];
                        break;

                    case (int)AramaTuru.ArizaTanimi:
                        _aramaTuru = _aramaAlanlari[6];
                        break;

                    case (int)AramaTuru.Aksesuarlar:
                        _aramaTuru = _aramaAlanlari[7];
                        break;

                    case (int)AramaTuru.EkBilgiler:
                        _aramaTuru = _aramaAlanlari[8];
                        break;

                    case (int)AramaTuru.UrunTakipNo:
                        _aramaTuru = _aramaAlanlari[9];
                        break;

                    case (int)AramaTuru.UrunDurumu:
                        _aramaTuru = _aramaAlanlari[10];
                        break;

                    case (int)AramaTuru.Ucret:
                        _aramaTuru = _aramaAlanlari[11];
                        break;

                    case (int)AramaTuru.KaydiYapanID:
                        _aramaTuru = _aramaAlanlari[12];
                        break;

                    case (int)AramaTuru.KayitTarihi:
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
                if (SMF.Baglanti.State != ConnectionState.Open)
                    SMF.Baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter($"Select * From MusteriBilgileri Where {_aramaTuru} Like @Ara", SMF.Baglanti);
                da.SelectCommand.Parameters.AddWithValue("@Ara", $"%{txtArama.Text.ToLower()}%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvRabtBilDB.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Resources.Hata");
            }
            finally
            {
                SMF.Baglanti.Close();
            }
        }

        public void CmbDoldur()
        {
            cmbAramaAlanlari.Items.Clear();
            cmbAramaAlanlari.Items.AddRange(_aramaAlanlari);
        }

        public void VerileriGetir()
        {
            try
            {
                if (SMF.Baglanti.State != ConnectionState.Open)
                    SMF.Baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * From MusteriBilgileri", SMF.Baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvRabtBilDB.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Resources.Hata");
            }
            finally
            {
                SMF.Baglanti.Close();
            }
        }

        public void Guncelle()
        {
            SMF.FrmPersonelTeknikServisFormu.lblMusteriNo.Text = dgvRabtBilDB.CurrentRow?.Cells[0].Value.ToString();
            SMF.FrmPersonelTeknikServisFormu.txtFormNo.Text = dgvRabtBilDB.CurrentRow?.Cells[1].Value.ToString();
            SMF.FrmPersonelTeknikServisFormu.txtMusteriAdi.Text = dgvRabtBilDB.CurrentRow?.Cells[2].Value.ToString();
            SMF.FrmPersonelTeknikServisFormu.mtxTelefon.Text = dgvRabtBilDB.CurrentRow?.Cells[3].Value.ToString();
            SMF.FrmPersonelTeknikServisFormu.txtUrunModeli.Text = dgvRabtBilDB.CurrentRow?.Cells[4].Value.ToString();
            SMF.FrmPersonelTeknikServisFormu.txtUrunKodlari.Text = dgvRabtBilDB.CurrentRow?.Cells[5].Value.ToString();
            SMF.FrmPersonelTeknikServisFormu.txtArizaninTanimi.Text = dgvRabtBilDB.CurrentRow?.Cells[6].Value.ToString();
            SMF.FrmPersonelTeknikServisFormu.txtAksesuarlar.Text = dgvRabtBilDB.CurrentRow?.Cells[7].Value.ToString();
            SMF.FrmPersonelTeknikServisFormu.txtEkBilgiler.Text = dgvRabtBilDB.CurrentRow?.Cells[8].Value.ToString();
            SMF.FrmPersonelTeknikServisFormu.txtTakipNumarası.Text = dgvRabtBilDB.CurrentRow?.Cells[9].Value.ToString();
            SMF.FrmPersonelTeknikServisFormu.txtUrunDurumu.Text = dgvRabtBilDB.CurrentRow?.Cells[10].Value.ToString();
            SMF.FrmPersonelTeknikServisFormu.txtUcret.Text = dgvRabtBilDB.CurrentRow?.Cells[11].Value.ToString();
            SMF.FrmPersonelTeknikServisFormu.KaydetEtkinMi(false);
            SMF.FrmPersonelTeknikServisFormu.GuncelleEtkinMi(true);
            Close();
        }

        private enum AramaTuru
        {
            Id,
            FormNo,
            MusteriAdi,
            Telefon,
            UrunModeli,
            UrunKodlari,
            ArizaTanimi,
            Aksesuarlar,
            EkBilgiler,
            UrunTakipNo,
            UrunDurumu,
            Ucret,
            KaydiYapanID,
            KayitTarihi,
            GuncellemeTarihi,
            TeslimEdenID,
            TeslimAlan,
            TeslimTarihi
        }

        private void tmrTarihSaat_Tick(object sender, EventArgs e)
        {
            tslblTarihSaat.Text = DateTime.Now.ToString(CultureInfo.CurrentCulture);
        }

        private void tsmiBaskiOnizleme_Click(object sender, EventArgs e)
        {
            ppdBaskiOnizleme.ShowDialog();
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrinterSettings.PrinterName = cmbYaziciListesi.Text;
            pd.PrintPage += new PrintPageEventHandler(this.pdcBelge_PrintPage);
            pd.Print();
        }

        private void pdcBelge_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font YaziFontlari = new Font("Consolas", 12, FontStyle.Regular);
            SolidBrush YaziRenk = new SolidBrush(Color.Black);
            e.Graphics.DrawImage(Properties.Resources.RabtBilYaziciSablonu, 0, 0);
            e.Graphics.DrawString(dgvRabtBilDB.CurrentRow?.Cells[1].Value.ToString(), YaziFontlari, YaziRenk, 248, 302);//FormNo
            e.Graphics.DrawString(dgvRabtBilDB.CurrentRow?.Cells[2].Value.ToString(), YaziFontlari, YaziRenk, 248, 341);//MusteriAdi
            e.Graphics.DrawString(dgvRabtBilDB.CurrentRow?.Cells[3].Value.ToString(), YaziFontlari, YaziRenk, 248, 381);//Telefon
            e.Graphics.DrawString(dgvRabtBilDB.CurrentRow?.Cells[4].Value.ToString(), YaziFontlari, YaziRenk, 248, 420);//UrunModeli
            e.Graphics.DrawString(dgvRabtBilDB.CurrentRow?.Cells[5].Value.ToString(), YaziFontlari, YaziRenk, 248, 464);//UrunKodları
            e.Graphics.DrawString(dgvRabtBilDB.CurrentRow?.Cells[6].Value.ToString(), YaziFontlari, YaziRenk, 248, 506);//ArizaTanimi
            e.Graphics.DrawString(dgvRabtBilDB.CurrentRow?.Cells[10].Value.ToString(), YaziFontlari, YaziRenk, 248, 543);//UrunDurumu
            e.Graphics.DrawString(dgvRabtBilDB.CurrentRow?.Cells[9].Value.ToString(), YaziFontlari, YaziRenk, 248, 583);//TakipNo
            e.Graphics.DrawString(dgvRabtBilDB.CurrentRow?.Cells[7].Value.ToString(), YaziFontlari, YaziRenk, 248, 662);//Aksesuarlar
            e.Graphics.DrawString(dgvRabtBilDB.CurrentRow?.Cells[11].Value.ToString() + " ₺", YaziFontlari, YaziRenk, 673, 792);//Ucret
            e.Graphics.DrawString(dgvRabtBilDB.CurrentRow?.Cells[12].Value.ToString(), YaziFontlari, YaziRenk, 248, 626);//KaydıYapan
            e.Graphics.DrawString(dgvRabtBilDB.CurrentRow?.Cells[13].Value.ToString(), YaziFontlari, YaziRenk, 588, 302);//TarihSaat
        }

        private void btnPdfAktar_Click(object sender, EventArgs e)
        {
        }

        private void btnExcelAktar_Click(object sender, EventArgs e)
        {
            Excel.Application excel = new Excel.Application();
            excel.Visible = true;
            object Missing = Type.Missing;
            Workbook workbook = excel.Workbooks.Add(Missing);
            Worksheet shet1 = (Worksheet)workbook.Sheets[1];
            int StartCol = 1;
            int StartRow = 1;
            for (int j = 0; j < dgvRabtBilDB.Columns.Count; j++)
            {
                Range MyRange = (Range)shet1.Cells[StartRow, StartCol + j];
                MyRange.Value2 = dgvRabtBilDB.Columns[j].HeaderText;
            }

            StartRow++;
            for (int i = 0; i < dgvRabtBilDB.Rows.Count; i++)
            {
                for (int j = 0; j < dgvRabtBilDB.Columns.Count; j++)
                {
                    Range MyRange = (Range)shet1.Cells[StartRow + i, StartCol + j];
                    MyRange.Value2 = dgvRabtBilDB[j, i].Value == null ? "" : dgvRabtBilDB[j, i].Value;
                    MyRange.Select();
                }
            }
        }

        private void cmbYaziciListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbYaziciListesi.Text!="")
            {
                btnYazdir.Enabled = true;
            }
            else
            {
                btnYazdir.Enabled = false;
            }
        }

        private void VarsayilanAciklama_MouseLeave(object sender, EventArgs e)
        {
            TlStripLblAciklama.Text = "Açıklama";
        }

        private void btnSil_MouseHover(object sender, EventArgs e)
        {
            TlStripLblAciklama.Text = "Seçili olan müşterileri siler";
        }

        private void btnExcelAktar_MouseHover(object sender, EventArgs e)
        {
            TlStripLblAciklama.Text = "Kayıtlı müşterileri bir tuşla excel'e aktarın";
        }

        private void cmbAramaAlanlari_MouseHover(object sender, EventArgs e)
        {
            TlStripLblAciklama.Text = "Seçili arama alanlarına göre arama yapar";
        }

        private void cmbYaziciListesi_MouseHover(object sender, EventArgs e)
        {
            TlStripLblAciklama.Text = "Yazıcı listesini gösterir";
        }

        private void btnYazdir_MouseHover(object sender, EventArgs e)
        {
            TlStripLblAciklama.Text = "Seçili yazıcı tipine göre yazdırma işlemleri yapar";
        }

        private void tsmiAyarlarDil_MouseHover(object sender, EventArgs e)
        {
            TlStripLblAciklama.Text = "Dil seçimi programı kolaylaştırır";
        }

        private void tsmiAyarlarTema_MouseHover(object sender, EventArgs e)
        {
            TlStripLblAciklama.Text = "Programın görünümünü güzelleştirmeye yarar";
        }

        private void tsmiYardımLisansAnahtarı_MouseHover(object sender, EventArgs e)
        {
            TlStripLblAciklama.Text = "Lisansınızın durumunu gösterir";
        }

        private void tsmiYardımHakkında_MouseHover(object sender, EventArgs e)
        {
            TlStripLblAciklama.Text = "Program hakkında bilgi almaya yarar";
        }

        private void tsmiBaskiOnizleme_MouseHover(object sender, EventArgs e)
        {
            TlStripLblAciklama.Text = "Yazdırılacak bilgi için bir ön izleme sunar";
        }
    }
}