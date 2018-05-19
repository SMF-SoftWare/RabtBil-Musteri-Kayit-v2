using RabtBil_Musteri_Kayit_v2.Properties;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RabtBil_Musteri_Kayit_v2
{
    public partial class FrmGirisYap : Form
    {
        private bool gozeTiklandiMi;

        public FrmGirisYap()
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

        private void FrmGirisYap_Load(object sender, EventArgs e)
        {
            if (!Settings.Default.LisansliMi || !SMF.LisansiKontrolEt(Settings.Default.Eposta, Settings.Default.LisansAnahtari))
            {
                SMF.LisansliMi = false;
                MessageBox.Show("Programın Deneme Sürümünü Kullanıyorsunuz!", SMF.PrograminTamAdi, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SMF.LisansliMi = true;
            }
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtKullaniciAdi.Text))
            {
                MessageBox.Show("Kullanıcı Adı Alanı Boş!", SMF.PrograminTamAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKullaniciAdi.Focus();
                return;
            }

            if (String.IsNullOrWhiteSpace(txtSifre.Text))
            {
                MessageBox.Show("Şifre Alanı Boş!", SMF.PrograminTamAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSifre.Focus();
                return;
            }

            try
            {
                SMF.BaglantiKapaliysaAc();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Kullanicilar WHERE KullaniciAdi=@KullaniciAdi AND Sifre=@Sifre", SMF.Baglanti);
                cmd.Parameters.AddWithValue("@KullaniciAdi", txtKullaniciAdi.Text);
                cmd.Parameters.AddWithValue("@Sifre", SMF.GetMd5Hash(txtSifre.Text));
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        SMF.KullaniciId = dr.GetInt32(0);
                        SMF.Adi = dr["Adi"].ToString();
                        SMF.Soyadi = dr["Soyadi"].ToString();
                        SMF.ProfilKlasoru = Application.StartupPath + $@"\Profil\{SMF.KullaniciId}";
                        SMF.ProfilResmiYolu = Application.StartupPath + $@"\Profil\{SMF.KullaniciId}\ProfilResmi.SMF";

                        switch (dr.GetInt32(6))
                        {
                            case (int)SMF.Rol.Yonetici:
                                SMF.Yetki = SMF.Rol.Yonetici;
                                break;

                            case (int)SMF.Rol.YetkiliPersonel:
                                SMF.Yetki = SMF.Rol.YetkiliPersonel;
                                break;

                            default:
                                SMF.Yetki = SMF.Rol.Personel;
                                break;
                        }
                    }

                    if (SMF.Yetki == SMF.Rol.Yonetici)
                    {
                        SMF.YoneticiMi = true;
                    }

                    if (SMF.Yetki == SMF.Rol.YetkiliPersonel)
                    {
                        SMF.YetkiliPersonelMi = true;
                    }

                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış!", SMF.PrograminTamAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void picGoz_Click(object sender, EventArgs e)
        {
            if (gozeTiklandiMi)
            {
                picGoz.Image = Resources.eye;
                txtSifre.UseSystemPasswordChar = true;
                gozeTiklandiMi = false;
            }
            else
            {
                picGoz.Image = Resources.eye_off;
                txtSifre.UseSystemPasswordChar = false;
                gozeTiklandiMi = true;
            }
        }
    }
}