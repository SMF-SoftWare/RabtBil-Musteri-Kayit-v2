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

        private void BttnGirisYap_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtKullaniciAdi.Text) || String.IsNullOrWhiteSpace(txtSifre.Text))
            {
                MessageBox.Show("Resources.kullaniciAdiveSifreBos", SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                SMF.Baglanti.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Kullanicilar WHERE KullaniciAdi=@KullaniciAdi AND Sifre=@Sifre", SMF.Baglanti);
                cmd.Parameters.AddWithValue("@KullaniciAdi", txtKullaniciAdi.Text);
                cmd.Parameters.AddWithValue("@Sifre", txtSifre.Text);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    cmd = new SqlCommand("SELECT Id,Rol FROM Kullanicilar WHERE KullaniciAdi=@KullaniciAdi AND Sifre=@Sifre", SMF.Baglanti);
                    cmd.Parameters.AddWithValue("@KullaniciAdi", txtKullaniciAdi.Text);
                    cmd.Parameters.AddWithValue("@Sifre", txtSifre.Text);
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        SMF.KullaniciId = dr.GetInt32(0);

                        switch (dr.GetInt32(1))
                        {
                            case (int)SMF.Rol.Admin:
                                SMF.Yetki = SMF.Rol.Admin;
                                break;

                            case (int)SMF.Rol.Yonetici:
                                SMF.Yetki = SMF.Rol.Yonetici;
                                break;

                            default:
                                SMF.Yetki = SMF.Rol.Kullanici;
                                break;
                        }
                    }

                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Resources.kullaniciAdiveSifreYanlis", SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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