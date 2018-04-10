using System.Data.SqlClient;
using System.Windows.Forms;

namespace RabtBil_Musteri_Kayit_v2
{
    internal class SMF
    {
        public static SqlConnection Baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|RabtBilDB.mdf ;Integrated Security=True");
        public static string UygulamaSurum = Application.ProductVersion;
        public static string UygulamaAdi = $"{Application.ProductName} {UygulamaSurum}";
        public static Rol Yetki = Rol.Kullanici;
        public static int KullaniciId = 0;
        public FrmGirisYap FrmGirisYap = (FrmGirisYap)Application.OpenForms["FrmGirisYap"];
        public FrmPersonelTeknikServisFormu FrmPersonelTeknikServisFormu = (FrmPersonelTeknikServisFormu)Application.OpenForms["FrmPersonelTeknikServisFormu"];
        public FrmKayitlariGoster FrmKayitlariGoster = (FrmKayitlariGoster)Application.OpenForms["FrmKayitlariGoster"];
        public FrmUrunTeslim FrmUrunTeslim = (FrmUrunTeslim)Application.OpenForms["FrmUrunTeslim"];

        public enum Rol
        {
            Admin,
            Yonetici,
            Kullanici
        }
    }
}