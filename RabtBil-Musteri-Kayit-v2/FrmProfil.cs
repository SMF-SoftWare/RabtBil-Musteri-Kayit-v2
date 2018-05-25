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

        private bool gozeTiklandiMi;

        private void FrmProfil_Load(object sender, EventArgs e)
        {
            if (SMF.YoneticiMi || SMF.YetkiliPersonelMi)
            {
                txtKullaniciAdi.Enabled = true;
            }

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM kullanicilar WHERE Id=@Id", SMF.Baglanti);
                cmd.Parameters.AddWithValue("@Id", SMF.KullaniciId);
                SMF.BaglantiKapaliysaAc();
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
                picProfilResmi.Image = File.Exists(SMF.ProfilResmiYolu) ? Image.FromFile(SMF.ProfilResmiYolu) : Resources.varsayilanProfilResmi;
            }
            catch
            {
                picProfilResmi.Image = Resources.varsayilanProfilResmi;
            }
        }

        private void picProfilResmi_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog resimSec = new OpenFileDialog())
            {
                FrmPersonelTeknikServisFormu frm = (FrmPersonelTeknikServisFormu)Application.OpenForms["FrmPersonelTeknikServisFormu"];
                resimSec.Title = "Profil Resminizi Seçin";
                resimSec.Filter = "Resim Dosyaları(*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|SMF Biçimi(*.smf)|*.smf";
                if (resimSec.ShowDialog() == DialogResult.OK)
                {
                    string kaynakResimYolu = resimSec.FileName;
                    if (!Directory.Exists(SMF.ProfilKlasoru))
                    {
                        Directory.CreateDirectory(SMF.ProfilKlasoru);
                    }
                    picProfilResmi.Image?.Dispose();
                    frm.picProfilResmi.Image?.Dispose();
                    try
                    {
                        File.Copy(kaynakResimYolu, SMF.ProfilResmiYolu, true);
                        picProfilResmi.Image = File.Exists(SMF.ProfilResmiYolu) ? Image.FromFile(SMF.ProfilResmiYolu) : Resources.varsayilanProfilResmi;
                        frm.picProfilResmi.Image = File.Exists(SMF.ProfilResmiYolu) ? Image.FromFile(SMF.ProfilResmiYolu) : Resources.varsayilanProfilResmi;
                    }
                    catch
                    {
                        picProfilResmi.Image = Resources.varsayilanProfilResmi;
                    }
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtKullaniciAdi.Text))
            {
                MessageBox.Show("Kullanıcı Adı Boş!", SMF.PrograminTamAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKullaniciAdi.Focus();
                return;
            }

            if (String.IsNullOrWhiteSpace(txtMevcutSifre.Text))
            {
                MessageBox.Show("Mevcut Şifrenizi Girin!", SMF.PrograminTamAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMevcutSifre.Focus();
                return;
            }

            if (String.IsNullOrWhiteSpace(txtAdi.Text))
            {
                MessageBox.Show("Adı Boş!", SMF.PrograminTamAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAdi.Focus();
                return;
            }

            if (String.IsNullOrWhiteSpace(txtSoyadi.Text))
            {
                MessageBox.Show("Soyadı Boş!", SMF.PrograminTamAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoyadi.Focus();
                return;
            }

            if (String.IsNullOrWhiteSpace(txtEpostaAdresi.Text) || !SMF.EpostaDogruMu(txtEpostaAdresi.Text))
            {
                MessageBox.Show("Doğru Bir E-posta Adresi Girin!", SMF.PrograminTamAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEpostaAdresi.Focus();
                return;
            }

            if (String.IsNullOrWhiteSpace(txtYeniSifre.Text) || String.IsNullOrWhiteSpace(txtYeniSifreyiOnayla.Text))
            {
                SMF.BaglantiKapaliysaAc();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Kullanicilar WHERE Id=@Id AND Sifre=@Sifre", SMF.Baglanti);
                cmd.Parameters.AddWithValue("@Id", SMF.KullaniciId);
                cmd.Parameters.AddWithValue("@Sifre", SMF.GetMd5Hash(txtMevcutSifre.Text));
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
                    SMF.BaglantiKapaliysaAc();
                    cmd.ExecuteNonQuery();

                    SMF.Adi = txtAdi.Text;
                    SMF.Soyadi = txtSoyadi.Text;

                    MessageBox.Show("Bilgileriniz Güncellendi!", SMF.PrograminTamAdi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Mevcut Şifreniz Yanlış!", SMF.PrograminTamAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                cmd.Parameters.AddWithValue("@Sifre", SMF.GetMd5Hash(txtMevcutSifre.Text));
                cmd.Parameters.AddWithValue("@Id", SMF.KullaniciId);
                SMF.BaglantiKapaliysaAc();
                cmd.ExecuteNonQuery();

                SMF.Adi = txtAdi.Text;
                SMF.Soyadi = txtSoyadi.Text;

                MessageBox.Show("Bilgileriniz Güncellendi!", SMF.PrograminTamAdi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void btnGucluSifreOlustur_Click(object sender, EventArgs e)
        {
            FrmGucluSifreOlustur frm = new FrmGucluSifreOlustur();
            frm.ShowDialog();
        }

        private void picGoz_Click(object sender, EventArgs e)
        {
            if (gozeTiklandiMi)
            {
                picGoz.Image = Resources.eye;
                txtMevcutSifre.UseSystemPasswordChar = true;
                txtYeniSifre.UseSystemPasswordChar = true;
                txtYeniSifreyiOnayla.UseSystemPasswordChar = true;
                gozeTiklandiMi = false;
            }
            else
            {
                picGoz.Image = Resources.eye_off;
                txtMevcutSifre.UseSystemPasswordChar = false;
                txtYeniSifre.UseSystemPasswordChar = false;
                txtYeniSifreyiOnayla.UseSystemPasswordChar = false;
                gozeTiklandiMi = true;
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}