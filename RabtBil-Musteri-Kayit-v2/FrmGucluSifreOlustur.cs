using System;
using System.Text;
using System.Windows.Forms;

namespace RabtBil_Musteri_Kayit_v2
{
    public partial class FrmGucluSifreOlustur : Form
    {
        public FrmGucluSifreOlustur()
        {
            InitializeComponent();
        }

        private string sifre;

        private void FrmGucluSifreOlustur_Load(object sender, EventArgs e)
        {
            chkBuyukHarfler.Checked = true;
            chkKucukHarfler.Checked = true;

            sifre = GucluSifreOlustur(trbSifreUzunlugu.Value);
            txtGucluSifre.Text = sifre;
            lblSifreUzunluguDeger.Text = trbSifreUzunlugu.Value.ToString();
        }

        private void trbSifreUzunlugu_Scroll(object sender, EventArgs e)
        {
            try
            {
                sifre = GucluSifreOlustur(trbSifreUzunlugu.Value);
                txtGucluSifre.Text = sifre;
                lblSifreUzunluguDeger.Text = trbSifreUzunlugu.Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
        }

        private void btnYenidenOlustur_Click(object sender, EventArgs e)
        {
            sifre = GucluSifreOlustur(trbSifreUzunlugu.Value);
            txtGucluSifre.Text = sifre;
        }

        private void btnKopyala_Click(object sender, EventArgs e)
        {
            if (sifre != null) Clipboard.SetText(sifre);
            MessageBox.Show("Oluşturulan Şifre Panoya Kopyalandı!", SMF.PrograminTamAdi, MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        public string GucluSifreOlustur(int uzunluk)
        {
            const string kucukHarfler = "abcdefghijklmnopqrstuvwxyz";
            const string buyukHarfler = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string sayilar = "1234567890";
            const string semboller = "@#$&*-+!?%^._:'\\/{}[]=()<>";

            if (!chkKucukHarfler.Checked && !chkBuyukHarfler.Checked && !chkSayilar.Checked && !chkSemboller.Checked)
            {
                MessageBox.Show("En Az Bir Seçeneği İşaretlemeniz Gerekiyor!");
                return "Hata!";
            }

            if (chkKucukHarfler.Checked)
            {
                sifre += kucukHarfler;
            }

            if (chkBuyukHarfler.Checked)
            {
                sifre += buyukHarfler;
            }

            if (chkSayilar.Checked)
            {
                sifre += sayilar;
            }

            if (chkSemboller.Checked)
            {
                sifre += semboller;
            }

            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();

            while (0 < uzunluk--)
            {
                sb.Append(sifre[rnd.Next(sifre.Length)]);
            }

            return sb.ToString();
        }
    }
}