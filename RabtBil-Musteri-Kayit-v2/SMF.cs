using System.Data.SqlClient;
using System.Windows.Forms;

namespace RabtBil_Musteri_Kayit_v2
{
    internal class SMF
    {
        public static SqlConnection Baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|RabtBilDB.mdf ;Integrated Security=True");
        public static string UygulamaSurum = "v1.0";
        public static string UygulamaAdi = $"RabtBil Müşteri Kayıt {UygulamaSurum}";
        public static int Yetki = 2;
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