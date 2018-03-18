﻿using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace RabtBil_Musteri_Kayit_v2
{
    public partial class FrmPersonelTeknikServisFormu : Form
    {
        public FrmPersonelTeknikServisFormu()
        {
            InitializeComponent();
        }

        private void FrmPersonelTeknikServisFormu_Load(object sender, EventArgs e)
        {
            GuncelleEtkinMi(false);
            tmrTarihSaat.Enabled = true;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(txtFormNo.Text) || String.IsNullOrWhiteSpace(txtMusteriAdi.Text) || mtxTelefon.Text == @"(    )        " || String.IsNullOrWhiteSpace(txtAksesuarlar.Text) || String.IsNullOrWhiteSpace(txtEkBilgiler.Text) || String.IsNullOrWhiteSpace(txtUrunModeli.Text) || String.IsNullOrWhiteSpace(txtUrunKodlari.Text) || String.IsNullOrWhiteSpace(txtArizaninTanimi.Text) || String.IsNullOrWhiteSpace(txtUrunDurumu.Text) || String.IsNullOrWhiteSpace(txtTakipNumarası.Text) || String.IsNullOrWhiteSpace(txtUcret.Text))
                {
                    MessageBox.Show("Resources.metinKutulariBos", SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SqlCommand cmd = new SqlCommand("INSERT INTO MusteriBilgileri(FormNo, MusteriAdi, Telefon, UrunModeli, UrunKodlari, ArizaTanimi, Aksesuarlar, EkBilgiler, UrunTakipNo, UrunDurumu, Ucret, KaydiYapanID, KayitTarihi) VALUES(@FormNo, @MusteriAdi, @Telefon, @UrunModeli, @UrunKodlari, @ArizaTanimi, @Aksesuarlar, @EkBilgiler, @UrunTakipNo, @UrunDurumu, @Ucret, @KaydiYapanID, @KayitTarihi)", SMF.Baglanti);
                cmd.Parameters.AddWithValue("@FormNo", txtFormNo.Text);
                cmd.Parameters.AddWithValue("@MusteriAdi", txtMusteriAdi.Text);
                cmd.Parameters.AddWithValue("@Telefon", mtxTelefon.Text);
                cmd.Parameters.AddWithValue("@UrunModeli", txtUrunModeli.Text);
                cmd.Parameters.AddWithValue("@UrunKodlari", txtUrunKodlari.Text);
                cmd.Parameters.AddWithValue("@ArizaTanimi", txtArizaninTanimi.Text);
                cmd.Parameters.AddWithValue("@Aksesuarlar", txtAksesuarlar.Text);
                cmd.Parameters.AddWithValue("@EkBilgiler", txtEkBilgiler.Text);
                cmd.Parameters.AddWithValue("@UrunTakipNo", txtTakipNumarası.Text);
                cmd.Parameters.AddWithValue("@UrunDurumu", txtUrunDurumu.Text);
                cmd.Parameters.AddWithValue("@Ucret", Convert.ToDouble(txtUcret.Text));
                cmd.Parameters.AddWithValue("@KaydiYapanID", SMF.KullaniciId);
                cmd.Parameters.AddWithValue("@KayitTarihi", DateTime.Now);
                SMF.Baglanti.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Resources.kaydedildi", SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Resources.metinKutulariBos", SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                SMF.Baglanti.Close();
            }
            Temizle();
            GuncelleEtkinMi(false);
            KaydetEtkinMi(true);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(txtFormNo.Text) || String.IsNullOrWhiteSpace(txtMusteriAdi.Text) || mtxTelefon.Text == @"(    )        " || String.IsNullOrWhiteSpace(txtAksesuarlar.Text) || String.IsNullOrWhiteSpace(txtEkBilgiler.Text) || String.IsNullOrWhiteSpace(txtUrunModeli.Text) || String.IsNullOrWhiteSpace(txtUrunKodlari.Text) || String.IsNullOrWhiteSpace(txtArizaninTanimi.Text) || String.IsNullOrWhiteSpace(txtUrunDurumu.Text) || String.IsNullOrWhiteSpace(txtTakipNumarası.Text) || String.IsNullOrWhiteSpace(txtUcret.Text))
                {
                    MessageBox.Show("Resources.metinKutulariBos", SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SqlCommand kaydet = new SqlCommand("UPDATE MusteriBilgileri SET FormNo=@FormNo,MusteriAdi=@MusteriAdi,Telefon=@Telefon,UrunModeli=@UrunModeli,UrunKodlari=@UrunKodlari,ArizaTanimi=@ArizaTanimi,Aksesuarlar=@Aksesuarlar,EkBilgiler=@EkBilgiler,UrunTakipNo=@UrunTakipNo,UrunDurumu=@UrunDurumu,Ucret=@Ucret,GuncelleyenID=@GuncelleyenID,GuncellemeTarihi=@GuncellemeTarihi WHERE ID=@ID", SMF.Baglanti);
                kaydet.Parameters.AddWithValue("@FormNo", txtMusteriAdi.Text);
                kaydet.Parameters.AddWithValue("@MusteriAdi", txtFormNo.Text);
                kaydet.Parameters.AddWithValue("@Telefon", mtxTelefon.Text);
                kaydet.Parameters.AddWithValue("@UrunModeli", txtUrunModeli.Text);
                kaydet.Parameters.AddWithValue("@UrunKodlari", txtUrunKodlari.Text);
                kaydet.Parameters.AddWithValue("@ArizaTanimi", txtArizaninTanimi.Text);
                kaydet.Parameters.AddWithValue("@Aksesuarlar", txtAksesuarlar.Text);
                kaydet.Parameters.AddWithValue("@EkBilgiler", txtEkBilgiler.Text);
                kaydet.Parameters.AddWithValue("@UrunTakipNo", txtTakipNumarası.Text);
                kaydet.Parameters.AddWithValue("@UrunDurumu", txtUrunDurumu.Text);
                kaydet.Parameters.AddWithValue("@Ucret", Convert.ToDouble(txtUcret.Text));
                kaydet.Parameters.AddWithValue("@GuncelleyenID", SMF.KullaniciId);
                kaydet.Parameters.AddWithValue("@GuncellemeTarihi", DateTime.Now);
                kaydet.Parameters.AddWithValue("@ID", SMF.FrmKayitlariGoster.dgvRabtBilDB.CurrentRow?.Cells[0].Value.ToString());
                SMF.Baglanti.Open();
                kaydet.ExecuteNonQuery();
                MessageBox.Show("Resources.kaydedildi", SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
            finally
            {
                SMF.Baglanti.Close();
            }
            Temizle();
            GuncelleEtkinMi(false);
            KaydetEtkinMi(true);
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            SMF.FrmGirisYap.Show();
            Hide();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            Temizle();
            GuncelleEtkinMi(false);
            KaydetEtkinMi(true);
        }

        private void btnKayitlariGoster_Click(object sender, EventArgs e)
        {
            SMF.FrmKayitlariGoster.VerileriGetir();
            SMF.FrmKayitlariGoster.Show();
            Hide();
        }

        private void chckboxTeslimEdildi_CheckedChanged(object sender, EventArgs e)
        {
            SMF.FrmUrunTeslim.ShowDialog();
        }

        public void Temizle()
        {
            txtMusteriAdi.Clear();
            txtFormNo.Clear();
            mtxTelefon.Clear();
            txtAksesuarlar.Clear();
            txtEkBilgiler.Clear();
            txtUrunModeli.Clear();
            txtUrunKodlari.Clear();
            txtArizaninTanimi.Clear();
            txtUrunDurumu.Clear();
            txtTakipNumarası.Clear();
            txtUcret.Clear();
            picQrKodu.Image = null;
        }

        public void GuncelleEtkinMi(bool value)
        {
            if (value)
            {
                btnGuncelle.Enabled = true;
                mnsAraclarGuncelle.Enabled = true;
            }
            else
            {
                btnGuncelle.Enabled = false;
                mnsAraclarGuncelle.Enabled = false;
            }
        }

        public void KaydetEtkinMi(bool value)
        {
            if (value)
            {
                btnKaydet.Enabled = true;
                mnsAraclarKaydet.Enabled = true;
            }
            else
            {
                btnKaydet.Enabled = false;
                mnsAraclarKaydet.Enabled = false;
            }
        }

        private void tmrTarihSaat_Tick(object sender, EventArgs e)
        {
            tslblTarihSaat.Text = DateTime.Now.ToString(CultureInfo.CurrentCulture);
        }

        private void FrmPersonelTeknikServisFormu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}