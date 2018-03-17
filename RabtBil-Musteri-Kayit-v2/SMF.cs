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
        public static int KullaniciID=0;
        public static FrmGirisYap FrmGirisYap = new FrmGirisYap();
        public static FrmPersonelTeknikServisFormu FrmPersonelTeknikServisFormu = new FrmPersonelTeknikServisFormu();
        public static FrmKayitlariGoster FrmKayitlariGoster = new FrmKayitlariGoster();
        public static FrmUrunTeslim FrmUrunTeslim = new FrmUrunTeslim();

        public enum Rol
        {
            Admin,
            Yonetici,
            Kullanici
        }
    }
}