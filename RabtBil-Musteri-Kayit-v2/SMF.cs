using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RabtBil_Musteri_Kayit_v2
{
    internal class SMF
    {
        public static SqlConnection Baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|RabtBilDB.mdf;Integrated Security=True");
        public static string ProgramSurumu = Application.ProductVersion;
        public static string PrograminAdi = Application.ProductName;
        public static string PrograminTamAdi = $"{PrograminAdi} v{ProgramSurumu}";
        public static Rol Yetki = Rol.Kullanici;
        public static int KullaniciId;
        public static string KullaniciAdi;
        public static string ProfilResmiYolu;
        public static string ProfilKlasoru;
        public static bool YoneticiMi;
        public static bool AdminMi;
        public static bool LisansliMi;

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
            string id = String.Empty;
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

        public static bool LisansiKontrolEt(string eposta, string lisans)
        {
            string x = eposta.ToLower();
            string a = x;
            string b = new string(a.ToCharArray().Reverse().ToArray());
            string A = x.ToUpper();
            string B = new string(A.ToCharArray().Reverse().ToArray());
            string c = GetMd5Hash(a);

            string aa = GetMd5Hash(a);
            string bb = GetMd5Hash(b);
            string AA = GetMd5Hash(A);
            string BB = GetMd5Hash(B);
            string cc = GetMd5Hash(c);

            string aaa = aa.Substring(0, 5);
            string bbb = bb.Substring(0, 5);
            string AAA = AA.Substring(0, 5);
            string BBB = BB.Substring(0, 5);
            string ccc = cc.Substring(0, 5);

            string license = $"{aaa}-{bbb}-{AAA}-{BBB}-{ccc}";
            if (String.Equals(license, lisans, StringComparison.CurrentCultureIgnoreCase))
            {
                return true;
            }

            return false;
        }

        public enum Rol
        {
            Admin,
            Yonetici,
            Kullanici
        }
    }
}