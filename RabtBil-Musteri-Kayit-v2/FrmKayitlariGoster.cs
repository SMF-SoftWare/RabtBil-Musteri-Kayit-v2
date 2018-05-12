using Microsoft.Office.Interop.Excel;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
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

        private string daText;
        private string _aramaTuru;
        private readonly string[] _aramaAlanlari = { "Id", "FormNo", "MusteriAdi", "Telefon", "UrunModeli", "UrunKodlari", "ArizaTanimi", "Aksesuarlar", "EkBilgiler", "UrunTakipNo", "UrunDurumu", "Ucret", "KaydiYapanID", "KayitTarihi", "GuncellemeTarihi", "TeslimEdenID", "TeslimAlan", "TeslimTarihi" };

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
                cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(dgvRabtBilDB.CurrentRow?.Cells[0].Value));
                SMF.BaglantiKapaliysaAc();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Resources.secilenKayitSilindi", SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void CmbDoldur()
        {
            cmbAramaAlanlari.Items.Clear();
            cmbAramaAlanlari.Items.AddRange(_aramaAlanlari);
        }

        public void VerileriGetir()
        {
            try
            {
                SMF.BaglantiKapaliysaAc();
                daText = SMF.YoneticiMi ? "SELECT * FROM MusteriBilgileri" : "SELECT * FROM MusteriBilgileri WHERE KaydiYapanID=@KaydiYapanID";
                SqlDataAdapter da = new SqlDataAdapter(daText, SMF.Baglanti);
                da.SelectCommand.Parameters.AddWithValue("@KaydiYapanID", SMF.KullaniciId);
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
            frm.lblMusteriNo.Text = dgvRabtBilDB.CurrentRow?.Cells[0].Value.ToString();
            frm.txtFormNo.Text = dgvRabtBilDB.CurrentRow?.Cells[1].Value.ToString();
            frm.txtMusteriAdi.Text = dgvRabtBilDB.CurrentRow?.Cells[2].Value.ToString();
            frm.mtxTelefon.Text = dgvRabtBilDB.CurrentRow?.Cells[3].Value.ToString();
            frm.txtUrunModeli.Text = dgvRabtBilDB.CurrentRow?.Cells[4].Value.ToString();
            frm.txtUrunKodlari.Text = dgvRabtBilDB.CurrentRow?.Cells[5].Value.ToString();
            frm.txtArizaninTanimi.Text = dgvRabtBilDB.CurrentRow?.Cells[6].Value.ToString();
            frm.txtAksesuarlar.Text = dgvRabtBilDB.CurrentRow?.Cells[7].Value.ToString();
            frm.txtEkBilgiler.Text = dgvRabtBilDB.CurrentRow?.Cells[8].Value.ToString();
            frm.txtTakipNumarası.Text = dgvRabtBilDB.CurrentRow?.Cells[9].Value.ToString();
            frm.txtUrunDurumu.Text = dgvRabtBilDB.CurrentRow?.Cells[10].Value.ToString();
            frm.txtUcret.Text = dgvRabtBilDB.CurrentRow?.Cells[11].Value.ToString();

            try
            {
                SMF.BaglantiKapaliysaAc();
                SqlCommand cmd = new SqlCommand("SELECT TeslimEdenId FROM MusteriBilgileri WHERE ID=@ID", SMF.Baglanti);
                cmd.Parameters.AddWithValue("@ID", frm.lblMusteriNo.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    frm.chkTeslimEdildi.Checked = dr["TeslimEdenId"].ToString() != String.Empty;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
            finally
            {
                SMF.Baglanti.Close();
            }

            frm.KaydetEtkinMi(false);
            frm.GuncelleEtkinMi(true);
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
            try
            {
                ppdBaskiOnizleme.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            try
            {
                PrintDocument pd = new PrintDocument();
                pd.PrinterSettings.PrinterName = cmbYaziciListesi.Text;
                pd.PrintPage += pdcBelge_PrintPage;
                pd.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
        }

        private void pdcBelge_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font yaziTipi = new Font("Consolas", 12, FontStyle.Regular);
            SolidBrush yaziRengi = new SolidBrush(Color.Black);
            e.Graphics.DrawImage(Properties.Resources.RabtBilYaziciSablonu, 0, 0);
            e.Graphics.DrawString(dgvRabtBilDB.CurrentRow?.Cells[1].Value.ToString(), yaziTipi, yaziRengi, 248, 302); //FormNo
            e.Graphics.DrawString(dgvRabtBilDB.CurrentRow?.Cells[2].Value.ToString(), yaziTipi, yaziRengi, 248, 341); //MusteriAdi
            e.Graphics.DrawString(dgvRabtBilDB.CurrentRow?.Cells[3].Value.ToString(), yaziTipi, yaziRengi, 248, 381); //Telefon
            e.Graphics.DrawString(dgvRabtBilDB.CurrentRow?.Cells[4].Value.ToString(), yaziTipi, yaziRengi, 248, 420); //UrunModeli
            e.Graphics.DrawString(dgvRabtBilDB.CurrentRow?.Cells[5].Value.ToString(), yaziTipi, yaziRengi, 248, 464); //UrunKodları
            e.Graphics.DrawString(dgvRabtBilDB.CurrentRow?.Cells[6].Value.ToString(), yaziTipi, yaziRengi, 248, 506); //ArizaTanimi
            e.Graphics.DrawString(dgvRabtBilDB.CurrentRow?.Cells[10].Value.ToString(), yaziTipi, yaziRengi, 248, 543); //UrunDurumu
            e.Graphics.DrawString(dgvRabtBilDB.CurrentRow?.Cells[9].Value.ToString(), yaziTipi, yaziRengi, 248, 583); //TakipNo
            e.Graphics.DrawString(dgvRabtBilDB.CurrentRow?.Cells[7].Value.ToString(), yaziTipi, yaziRengi, 248, 662); //Aksesuarlar
            e.Graphics.DrawString(dgvRabtBilDB.CurrentRow?.Cells[11].Value + " ₺", yaziTipi, yaziRengi, 673, 792); //Ucret
            e.Graphics.DrawString(dgvRabtBilDB.CurrentRow?.Cells[12].Value.ToString(), yaziTipi, yaziRengi, 248, 626); //KaydıYapan
            e.Graphics.DrawString(dgvRabtBilDB.CurrentRow?.Cells[13].Value.ToString(), yaziTipi, yaziRengi, 588, 302); //TarihSaat
        }

        private void btnExcelAktar_Click(object sender, EventArgs e)
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

        private void cmbYaziciListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnYazdir.Enabled = cmbYaziciListesi.Text != "";
        }

        private void varsayilanAciklama_MouseLeave(object sender, EventArgs e)
        {
            tslblAciklama.Text = "Açıklama";
        }

        private void tsmiYardımHakkında_Click_1(object sender, EventArgs e)
        {
            FrmHakkinda frmHakkinda = new FrmHakkinda();
            frmHakkinda.ShowDialog();
        }
    }
}