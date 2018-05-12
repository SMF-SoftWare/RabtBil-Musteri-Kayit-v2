using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RabtBil_Musteri_Kayit_v2
{
    internal class SMF
    {
        public static SqlConnection Baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|RabtBilDB.mdf;Integrated Security=True");
        public static string UygulamaSurum = Application.ProductVersion;
        public static string UygulamaAdi = $"{Application.ProductName} {UygulamaSurum}";
        public static Rol Yetki = Rol.Kullanici;
        public static int KullaniciId;
        public static string KullaniciAdi;
        public static string ProfilResmiYolu;
        public static string ProfilKlasoru;

        public static bool EpostaDogruMu(string eposta)
        {
            return Regex.IsMatch(eposta, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }

        public static string GetMd5Hash(string yazi)
        {
            MD5 md5 = MD5.Create();
            byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(yazi));
            StringBuilder sb = new StringBuilder();
            foreach (var i in data)
            {
                sb.Append(i.ToString("x2").ToUpper());
            }
            return sb.ToString();
        }

        public static string TakipKoduOlustur()
        {
            DateTime simdi = DateTime.Now;
            string id = null;
            int gun = simdi.Day;
            int saat = simdi.Hour;
            int ay = simdi.Month;
            int dakika = simdi.Minute;
            string yil = simdi.ToString("yy");
            int saniye = simdi.Second;

            try
            {
                BaglantiKapaliysaAc();
                SqlCommand cmd = new SqlCommand("SELECT MAX(ID)+1 as SonId FROM MusteriBilgileri", Baglanti);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    id = dr["SonId"].ToString();
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
            finally
            {
                Baglanti.Close();
            }
            return $"SMF{id}{gun}{saat}{ay}{dakika}{yil}{saniye}";
        }

        public static void BaglantiKapaliysaAc()
        {
            if (Baglanti.State != ConnectionState.Open)
                Baglanti.Open();
        }

        public enum Rol
        {
            Admin,
            Yonetici,
            Kullanici
        }
    }
}