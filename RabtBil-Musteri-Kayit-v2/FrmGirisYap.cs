using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RabtBil_Musteri_Kayit_v2
{
    public partial class FrmGirisYap : Form
    {
        public FrmGirisYap()
        {
            InitializeComponent();
        }

        private void BttnCikisYap_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BttnGirisYap_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(TxtKullaniciAdi.Text) || String.IsNullOrWhiteSpace(TxtSifre.Text))
            {
                MessageBox.Show("Kullanıcı adı veya Şifre boş!", SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                SMF.Baglanti.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Kullanicilar WHERE KullaniciAdi=@KullaniciAdi AND Sifre=@Sifre", SMF.Baglanti);
                cmd.Parameters.AddWithValue("@KullaniciAdi", TxtKullaniciAdi.Text);
                cmd.Parameters.AddWithValue("@Sifre", TxtSifre.Text);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    cmd = new SqlCommand("SELECT Rol FROM Kullanicilar WHERE KullaniciAdi=@KullaniciAdi AND Sifre=@Sifre", SMF.Baglanti);
                    cmd.Parameters.AddWithValue("@KullaniciAdi", TxtKullaniciAdi.Text);
                    cmd.Parameters.AddWithValue("@Sifre", TxtSifre.Text);
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        switch (dr.GetInt32(0))
                        {
                            case (int)SMF.Rol.Admin:
                                SMF.Yetki = (int)SMF.Rol.Admin;
                                MessageBox.Show("SMF.Rol.Admin");
                                break;

                            case (int)SMF.Rol.Yonetici:
                                SMF.Yetki = (int)SMF.Rol.Yonetici;
                                MessageBox.Show("SMF.Rol.Yonetici");
                                break;

                            case (int)SMF.Rol.Kullanici:
                            default:
                                SMF.Yetki = (int)SMF.Rol.Kullanici;
                                MessageBox.Show("SMF.Rol.Kullanici");
                                break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış!", SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
    }
}