using RabtBil_Musteri_Kayit_v2.Properties;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace RabtBil_Musteri_Kayit_v2
{
    public partial class FrmProfil : Form
    {
        public FrmProfil()
        {
            InitializeComponent();
        }

        private bool gozeTiklandiMi = true;

        private void FrmProfil_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM kullanicilar WHERE Id=@Id", SMF.Baglanti);
                cmd.Parameters.AddWithValue("@Id", SMF.KullaniciId);
                if (SMF.Baglanti.State != ConnectionState.Open)
                    SMF.Baglanti.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtKullaniciAdi.Text = dr["KullaniciAdi"].ToString();
                    txtAdi.Text = dr["Adi"].ToString();
                    txtSoyadi.Text = dr["Soyadi"].ToString();
                    txtEpostaAdresi.Text = dr["Eposta"].ToString();
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

            try
            {
                PcTrBoxProfiliDuzenle.Image = File.Exists(SMF.ProfilResmiYolu) ? Image.FromFile(SMF.ProfilResmiYolu) : Resources.varsayilanProfilResmi;
            }
            catch (Exception)
            {
                PcTrBoxProfiliDuzenle.Image = Resources.varsayilanProfilResmi;
            }
        }

        private void tsmiGucluSifreOlustur_Click(object sender, EventArgs e)
        {
            FrmGucluSifreOlustur frm = new FrmGucluSifreOlustur();
            frm.ShowDialog();
        }

        private void tsmiHakkinda_Click(object sender, EventArgs e)
        {
            FrmHakkinda frmHakkinda = new FrmHakkinda();
            frmHakkinda.ShowDialog();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtKullaniciAdi.Text))
            {
                MessageBox.Show("Resources.kullaniciAdiBosOlamaz", SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (String.IsNullOrWhiteSpace(txtMevcutSifre.Text))
            {
                MessageBox.Show("Mevcut Şifrenizi Girin!", SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (String.IsNullOrWhiteSpace(txtEpostaAdresi.Text) || !SMF.EpostaDogruMu(txtEpostaAdresi.Text))
            {
                MessageBox.Show("Resources.dogruEpostaGir", SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (String.IsNullOrWhiteSpace(txtYeniSifre.Text) || String.IsNullOrWhiteSpace(txtYeniSifreyiOnayla.Text))
            {
                if (SMF.Baglanti.State != ConnectionState.Open)
                    SMF.Baglanti.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Kullanicilar WHERE Id=@Id AND Sifre=@Sifre", SMF.Baglanti);
                cmd.Parameters.AddWithValue("@Id", SMF.KullaniciId);
                cmd.Parameters.AddWithValue("@Sifre", txtMevcutSifre.Text);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    cmd = new SqlCommand("UPDATE Kullanicilar SET KullaniciAdi=@KullaniciAdi, Adi=@Adi, Soyadi=@Soyadi, Eposta=@Eposta WHERE Id=@Id", SMF.Baglanti);
                    cmd.Parameters.AddWithValue("@KullaniciAdi", txtKullaniciAdi.Text);
                    cmd.Parameters.AddWithValue("@Adi", txtAdi.Text);
                    cmd.Parameters.AddWithValue("@Soyadi", txtSoyadi.Text);
                    cmd.Parameters.AddWithValue("@Eposta", txtEpostaAdresi.Text);
                    cmd.Parameters.AddWithValue("@Id", SMF.KullaniciId);
                    if (SMF.Baglanti.State != ConnectionState.Open)
                        SMF.Baglanti.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bilgileriniz Güncellendi!", SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Restart();
                }
                else
                {
                    MessageBox.Show("Mevcut Şifreniz Yanlış!", SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return;
            }

            if (txtYeniSifre.Text == txtYeniSifreyiOnayla.Text)
            {
                SqlCommand cmd = new SqlCommand("UPDATE Kullanicilar SET KullaniciAdi=@KullaniciAdi, Adi=@Adi, Soyadi=@Soyadi, Eposta=@Eposta, Sifre=@Sifre WHERE Id=@Id", SMF.Baglanti);
                cmd.Parameters.AddWithValue("@KullaniciAdi", txtKullaniciAdi.Text);
                cmd.Parameters.AddWithValue("@Adi", txtAdi.Text);
                cmd.Parameters.AddWithValue("@Soyadi", txtSoyadi.Text);
                cmd.Parameters.AddWithValue("@Eposta", txtEpostaAdresi.Text);
                cmd.Parameters.AddWithValue("@Sifre", txtYeniSifre.Text);
                cmd.Parameters.AddWithValue("@Id", SMF.KullaniciId);
                if (SMF.Baglanti.State != ConnectionState.Open)
                    SMF.Baglanti.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Bilgileriniz Güncellendi!", SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();
            }
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PcTrBoxProfiliDuzenle_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog resimSec = new OpenFileDialog())
            {
                FrmPersonelTeknikServisFormu frm = (FrmPersonelTeknikServisFormu)Application.OpenForms["FrmPersonelTeknikServisFormu"];
                resimSec.Title = "Profil resminizi seçin";
                resimSec.Filter = "Resim Dosyaları(*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|SMF Biçimi(*.smf)|*.smf";
                if (resimSec.ShowDialog() == DialogResult.OK)
                {
                    string kaynakResimYolu = resimSec.FileName;
                    if (!Directory.Exists(SMF.ProfilKlasoru))
                    {
                        Directory.CreateDirectory(SMF.ProfilKlasoru);
                    }
                    PcTrBoxProfiliDuzenle.Image?.Dispose();
                    frm.PcTrBoxProfilResim.Image?.Dispose();
                    try
                    {
                        File.Copy(kaynakResimYolu, SMF.ProfilResmiYolu, true);
                        PcTrBoxProfiliDuzenle.Image = File.Exists(SMF.ProfilResmiYolu) ? Image.FromFile(SMF.ProfilResmiYolu) : Resources.varsayilanProfilResmi;
                        frm.PcTrBoxProfilResim.Image = File.Exists(SMF.ProfilResmiYolu) ? Image.FromFile(SMF.ProfilResmiYolu) : Resources.varsayilanProfilResmi;
                    }
                    catch (Exception)
                    {
                        PcTrBoxProfiliDuzenle.Image = Resources.varsayilanProfilResmi;
                    }
                }
            }
        }

        private void pbxEye_Click(object sender, EventArgs e)
        {
            if (gozeTiklandiMi)
            {
                pbxEye.Image = Resources.eye_off;
                txtMevcutSifre.UseSystemPasswordChar = false;
                txtYeniSifre.UseSystemPasswordChar = false;
                txtYeniSifreyiOnayla.UseSystemPasswordChar = false;
                gozeTiklandiMi = false;
            }
            else
            {
                pbxEye.Image = Resources.eye;
                txtMevcutSifre.UseSystemPasswordChar = true;
                txtYeniSifre.UseSystemPasswordChar = true;
                txtYeniSifreyiOnayla.UseSystemPasswordChar = true;
                gozeTiklandiMi = true;
            }
        }
    }
}