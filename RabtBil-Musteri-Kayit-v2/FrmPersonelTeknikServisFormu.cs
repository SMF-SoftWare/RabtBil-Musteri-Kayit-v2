using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RabtBil_Musteri_Kayit_v2
{
    public partial class FrmPersonelTeknikServisFormu : Form
    {
        public FrmPersonelTeknikServisFormu()
        {
            InitializeComponent();
        }

        private void chckboxTeslimEdildi_CheckedChanged(object sender, EventArgs e)
        {
            FrmUrunTeslim frmUrunTeslim = new FrmUrunTeslim();
            frmUrunTeslim.ShowDialog();
        }

        private void btnKayitlariGoster_Click(object sender, EventArgs e)
        {
            SMF.FrmKayitlariGoster.Show();
            Hide();
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            SMF.FrmGirisYap.Show();
            base.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand kaydet = new SqlCommand("INSERT INTO musteribilgileri (FormNo,MusteriAdi,Telefon,UrunModeli,UrunKodlari,ArizaTanimi,Aksesuarlar,EkBilgiler,UrunTakipNo,UrunDurumu,Ucret,KaydiYapanID) VALUES(@FormNo,@MusteriAdi,@Telefon,@UrunModeli,@UrunKodlari,@ArizaTanimi,@Aksesuarlar,@EkBilgiler,@UrunTakipNo,@UrunDurumu,@Ucret,@KaydiYapanID)", SMF.Baglanti);
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
            kaydet.Parameters.AddWithValue("@Ucret", double.Parse(txtUcret.Text));
            kaydet.Parameters.AddWithValue("@KaydiYapanID", SMF.KullaniciID);
            //  kaydet.Parameters.AddWithValue("@KayitTarihi", txtKayitTarihi.Text);
            SMF.Baglanti.Open();
            kaydet.ExecuteNonQuery();
            SMF.Baglanti.Close();
            MessageBox.Show("Kayıt Eklendi");
            //MessageBox.Show(Resources.kaydedildi, SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtMusteriAdi.Text = "";
            txtFormNo.Text = "";
            mtxTelefon.Text = "";
            txtAksesuarlar.Text = "";
            txtEkBilgiler.Text = "";
            txtUrunModeli.Text = "";
            txtUrunKodlari.Text = "";
            txtArizaninTanimi.Text = "";
            txtUrunDurumu.Text = "";
            txtTakipNumarası.Text = "";
            txtUcret.Text = "";
            picQrKodu.Image = null;
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            txtMusteriAdi.Text = "";
            txtFormNo.Text = "";
            mtxTelefon.Text = "";
            txtAksesuarlar.Text = "";
            txtEkBilgiler.Text = "";
            txtUrunModeli.Text = "";
            txtUrunKodlari.Text = "";
            txtArizaninTanimi.Text = "";
            txtUrunDurumu.Text = "";
            txtTakipNumarası.Text = "";
            txtUcret.Text = "";
            picQrKodu.Image = null;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand kaydet = new SqlCommand("UPDATE musteribilgileri SET FormNo=@FormNo,MusteriAdi=@MusteriAdi,Telefon=@Telefon,UrunModeli=@UrunModeli,UrunKodlari=@UrunKodlari,ArizaTanimi=@ArizaTanimi,Aksesuarlar=@Aksesuarlar,EkBilgiler=@EkBilgiler,UrunTakipNo=@UrunTakipNo,UrunDurumu=@UrunDurumu,Ucret=@Ucret,KaydiYapanID=@KaydiYapanID WHERE ID=@ID", SMF.Baglanti);
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
            kaydet.Parameters.AddWithValue("@Ucret", double.Parse(txtUcret.Text));
            kaydet.Parameters.AddWithValue("@KaydiYapanID", SMF.KullaniciID);
            kaydet.Parameters.AddWithValue("@ID", SMF.FrmKayitlariGoster.dgvRabtBilDB.CurrentRow?.Cells[0].Value.ToString());

            //  kaydet.Parameters.AddWithValue("@KayitTarihi", txtKayitTarihi.Text);
            SMF.Baglanti.Open();
            kaydet.ExecuteNonQuery();
            SMF.Baglanti.Close();
            MessageBox.Show("Kayıt Güncellendi.");
            //MessageBox.Show(Resources.kaydedildi, SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}