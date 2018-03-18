using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace RabtBil_Musteri_Kayit_v2
{
    public partial class FrmKayitlariGoster : Form
    {
        public FrmKayitlariGoster()
        {
            InitializeComponent();
        }

        private string _aramaTuru;

        private readonly string[] _aramaAlanlari = { "Id", "FormNo", "MusteriAdi", "Telefon", "UrunModeli", "UrunKodlari", "ArizaTanimi", "Aksesuarlar", "EkBilgiler", "UrunTakipNo", "UrunDurumu", "Ucret", "KaydiYapanID", "KayitTarihi", "GuncellemeTarihi", "TeslimEdenID", "TeslimAlan", "TeslimTarihi" };

        private void FrmKayitlariGoster_Load(object sender, EventArgs e)
        {
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

        private void tsmiAraclarYeniKayit_Click(object sender, EventArgs e)
        {
            SMF.FrmPersonelTeknikServisFormu.Show();
            Hide();
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
            MessageBox.Show("Resources.secilenKaydiDuzenliyorsun", SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            SMF.FrmPersonelTeknikServisFormu.Show();
            Hide();
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
        
        private void FrmKayitlariGoster_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                SMF.FrmPersonelTeknikServisFormu.Show();
                Hide();
                e.Cancel = true;
            }

        }
    }
}