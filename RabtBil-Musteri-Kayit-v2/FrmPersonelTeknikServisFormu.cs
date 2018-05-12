using QRCoder;
using RabtBil_Musteri_Kayit_v2.Properties;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace RabtBil_Musteri_Kayit_v2
{
    public partial class FrmPersonelTeknikServisFormu : Form
    {
        public FrmPersonelTeknikServisFormu()
        {
            InitializeComponent();
        }

        private bool yenidenBaslat;

        private void FrmPersonelTeknikServisFormu_Load(object sender, EventArgs e)
        {
            GuncelleEtkinMi(false);
            tmrTarihSaat.Enabled = true;
            lblHosgeldin.Text = $"Hoş Geldin, {SMF.KullaniciAdi}!";
            txtTakipNumarası.Text = SMF.TakipKoduOlustur();
            QrKoduOlustur();

            try
            {
                PcTrBoxProfilResim.Image = File.Exists(SMF.ProfilResmiYolu) ? Image.FromFile(SMF.ProfilResmiYolu) : Resources.varsayilanProfilResmi;
            }
            catch (Exception)
            {
                PcTrBoxProfilResim.Image = Resources.varsayilanProfilResmi;
            }
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
                SMF.BaglantiKapaliysaAc();
                cmd.ExecuteNonQuery();
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
                kaydet.Parameters.AddWithValue("@ID", lblMusteriNo.Text);
                SMF.BaglantiKapaliysaAc();
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
            yenidenBaslat = true;
            Application.Exit();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            if (txtFormNo.TextLength > 0 || txtMusteriAdi.TextLength > 0 || mtxTelefon.Text != @"(    )        " || txtAksesuarlar.TextLength > 0 || txtEkBilgiler.TextLength > 0 || txtUrunModeli.TextLength > 0 || txtUrunKodlari.TextLength > 0 || txtArizaninTanimi.TextLength > 0 || txtUrunDurumu.TextLength > 0 || txtUcret.TextLength > 0)
            {
                DialogResult dr = MessageBox.Show("Bu Sayfayı Kapatırsanız Yaptığınız Değişiklikler Kaybolacaktır!", SMF.UygulamaAdi, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.No)
                {
                    return;
                }
            }

            Temizle();
            GuncelleEtkinMi(false);
            KaydetEtkinMi(true);
            chkTeslimEdildi.Checked = false;
            txtTakipNumarası.Text = SMF.TakipKoduOlustur();
            QrKoduOlustur();
        }

        private void btnKayitlariGoster_Click(object sender, EventArgs e)
        {
            if (txtFormNo.TextLength > 0 || txtMusteriAdi.TextLength > 0 || mtxTelefon.Text != @"(    )        " || txtAksesuarlar.TextLength > 0 || txtEkBilgiler.TextLength > 0 || txtUrunModeli.TextLength > 0 || txtUrunKodlari.TextLength > 0 || txtArizaninTanimi.TextLength > 0 || txtUrunDurumu.TextLength > 0 || txtUcret.TextLength > 0)
            {
                DialogResult dr = MessageBox.Show("Bu Sayfayı Kapatırsanız Yaptığınız Değişiklikler Kaybolacaktır!", SMF.UygulamaAdi, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.No)
                {
                    return;
                }
            }

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM MusteriBilgileri", SMF.Baglanti);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                if (dt.Rows.Count < 1)
                {
                    MessageBox.Show("Veritabanında Hiç Soru Yok!", SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
            finally
            {
                SMF.Baglanti.Close();
            }

            FrmKayitlariGoster frm = new FrmKayitlariGoster();
            frm.ShowDialog();
        }

        private void VarsayilanAciklama_MouseLeave(object sender, EventArgs e)
        {
            TlStripLblAciklama.Text = "Açıklama";
        }

        private void btnYeniKayit_MouseHover(object sender, EventArgs e)
        {
            TlStripLblAciklama.Text = "Yeni bir kayıt oluşturur";
        }

        private void btnKaydet_MouseHover(object sender, EventArgs e)
        {
            TlStripLblAciklama.Text = "Müşterileri kayıt eder";
        }

        private void btnTemizle_MouseHover(object sender, EventArgs e)
        {
            TlStripLblAciklama.Text = "Text'lerin içini temizler";
        }

        private void btnKayitlariGoster_MouseHover(object sender, EventArgs e)
        {
            TlStripLblAciklama.Text = "Kaydedilen müşterileri listeler";
        }

        private void btnGuncelle_MouseHover(object sender, EventArgs e)
        {
            TlStripLblAciklama.Text = "Müşteri bilgilerinde değişiklik yapar";
        }

        private void btnCikisYap_MouseHover(object sender, EventArgs e)
        {
            TlStripLblAciklama.Text = "Oturumdan Çıkar";
        }

        private void chkTeslimEdildi_Click(object sender, EventArgs e)
        {
            FrmUrunTeslim frm = new FrmUrunTeslim();
            frm.ShowDialog();
        }

        private void PcTrBoxProfilResim_Click(object sender, EventArgs e)
        {
            FrmProfil frm = new FrmProfil();
            frm.ShowDialog();
        }

        private void mnsAyarlarDil_MouseHover(object sender, EventArgs e)
        {
            TlStripLblAciklama.Text = "Dil seçimi programı kolaylaştırır";
        }

        private void mnsAyarlarTema_MouseHover(object sender, EventArgs e)
        {
            TlStripLblAciklama.Text = "Programın görünümünü güzelleştirmeye yarar";
        }

        private void mnsYardimLisansAnahtari_MouseHover(object sender, EventArgs e)
        {
            TlStripLblAciklama.Text = "Lisansınızın durumunu gösterir";
        }

        private void mnsYardimHakkinda_MouseHover(object sender, EventArgs e)
        {
            TlStripLblAciklama.Text = "Program hakkında bilgi almaya yarar";
        }

        private void mnsYardimHakkinda_Click(object sender, EventArgs e)
        {
            FrmHakkinda frmHakkinda = new FrmHakkinda();
            frmHakkinda.ShowDialog();
        }

        private void FrmPersonelTeknikServisFormu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txtFormNo.TextLength > 0 || txtMusteriAdi.TextLength > 0 || mtxTelefon.Text != @"(    )        " || txtAksesuarlar.TextLength > 0 || txtEkBilgiler.TextLength > 0 || txtUrunModeli.TextLength > 0 || txtUrunKodlari.TextLength > 0 || txtArizaninTanimi.TextLength > 0 || txtUrunDurumu.TextLength > 0 || txtUcret.TextLength > 0)
            {
                DialogResult dr = MessageBox.Show("Bu Sayfayı Kapatırsanız Yaptığınız Değişiklikler Kaybolacaktır!", SMF.UygulamaAdi, MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dr == DialogResult.No)
                {
                    e.Cancel = true;
                    yenidenBaslat = false;
                    return;
                }
            }

            if (yenidenBaslat)
            {
                Application.Restart();
            }
        }

        private void tmrTarihSaat_Tick(object sender, EventArgs e)
        {
            tslblTarihSaat.Text = DateTime.Now.ToString(CultureInfo.CurrentCulture);
        }

        public void GuncelleEtkinMi(bool value)
        {
            if (value)
            {
                btnGuncelle.Enabled = true;
                tsmiGuncelle.Enabled = true;
                chkTeslimEdildi.Enabled = true;
            }
            else
            {
                btnGuncelle.Enabled = false;
                tsmiGuncelle.Enabled = false;
                chkTeslimEdildi.Enabled = false;
            }
        }

        public void KaydetEtkinMi(bool value)
        {
            if (value)
            {
                btnKaydet.Enabled = true;
                tsmiKaydet.Enabled = true;
            }
            else
            {
                btnKaydet.Enabled = false;
                tsmiKaydet.Enabled = false;
            }
        }

        public void QrKoduOlustur()
        {
            PayloadGenerator.Url generator = new PayloadGenerator.Url($@"localhost:1337\takipno\{txtTakipNumarası.Text}");
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(generator, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeAsBitmap = qrCode.GetGraphic(5);
            picQrKodu.Image = qrCodeAsBitmap;
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
            txtUcret.Clear();
        }
    }
}