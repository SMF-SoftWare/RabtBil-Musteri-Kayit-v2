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
        //public static FrmGirisYap FrmGirisYap = (FrmGirisYap)Application.OpenForms["FrmGirisYap"];
        //public static FrmPersonelTeknikServisFormu FrmPersonelTeknikServisFormu = (FrmPersonelTeknikServisFormu)Application.OpenForms["FrmPersonelTeknikServisFormu"];
        //public static FrmKayitlariGoster FrmKayitlariGoster = (FrmKayitlariGoster)Application.OpenForms["FrmKayitlariGoster"];
        //public static FrmUrunTeslim FrmUrunTeslim = (FrmUrunTeslim)Application.OpenForms["FrmUrunTeslim"];

        public static bool EpostaDogruMu(string eposta)
        {
            return Regex.IsMatch(eposta, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }

        public static string GetMd5Hash(string text)
        {
            MD5 md5 = MD5.Create();
            byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(text));
            StringBuilder sb = new StringBuilder();
            foreach (var i in data)
            {
                sb.Append(i.ToString("x2").ToUpper());
            }
            return sb.ToString();
        }

        public enum Rol
        {
            Admin,
            Yonetici,
            Kullanici
        }
    }
}