using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace RabtBil_Musteri_Kayit_v2
{
    public partial class FrmYazdir : Form
    {
        public FrmYazdir()
        {
            InitializeComponent();
        }

        private void FrmYazdir_Load(object sender, EventArgs e)
        {
            YazicilariListele();
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Yazdırılsın Mı?", SMF.PrograminTamAdi, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.No)
            {
                return;
            }

            try
            {
                PrintDocument pd = new PrintDocument { PrinterSettings = { PrinterName = cmbYaziciListesi.Text } };
                pd.PrintPage += pdcBelge_PrintPage;
                pd.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
        }

        private void btnBaskiOnizleme_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Baskı Önizlemesi Açılsın Mı?", SMF.PrograminTamAdi, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.No)
            {
                return;
            }

            try
            {
                ppdBaskiOnizleme.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbYaziciListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnYazdir.Enabled = cmbYaziciListesi.Text != String.Empty;
        }

        private void pdcBelge_PrintPage(object sender, PrintPageEventArgs e)
        {
            FrmPersonelTeknikServisFormu frm = (FrmPersonelTeknikServisFormu)Application.OpenForms["FrmPersonelTeknikServisFormu"];

            Font yaziTipi = new Font("Segoe UI", 12, FontStyle.Regular);
            SolidBrush yaziRengi = new SolidBrush(Color.Black);
            e.Graphics.DrawImage(Properties.Resources.RabtBilYaziciSablonu, 0, 0);
            if (frm != null)
            {
                e.Graphics.DrawString(frm.txtMusteriAdi.Text, yaziTipi, yaziRengi, 244, 356); //MüşteriAdı
                e.Graphics.DrawString(frm.mtxTelefon.Text, yaziTipi, yaziRengi, 244, 400); //Telefon
                e.Graphics.DrawString(frm.txtCihazModeli.Text, yaziTipi, yaziRengi, 244, 446); //CihazModeli
                e.Graphics.DrawString(frm.txtCihazinSeriNumarası.Text, yaziTipi, yaziRengi, 244, 490); //SeriNumarası
                e.Graphics.DrawString(frm.txtArizaninTanimi.Text, yaziTipi, yaziRengi, 244, 533); //ArızaTanımı
                e.Graphics.DrawString(frm.cmbCihazDurumu.Text, yaziTipi, yaziRengi, 244, 577); //CihazDurumu
                e.Graphics.DrawString(frm.txtTakipNumarasi.Text, yaziTipi, yaziRengi, 244, 624); //TakipNumarası
                e.Graphics.DrawString(frm.txtAksesuarlar.Text, yaziTipi, yaziRengi, 244, 671); //Aksesuar
                e.Graphics.DrawString(frm.txtUcret.Text + " ₺", yaziTipi, yaziRengi, 657, 774);
                e.Graphics.DrawString(DateTime.Now.ToString(), yaziTipi, yaziRengi, 589, 310); //Tarih
            }
        }

        public void YazicilariListele()
        {
            try
            {
                foreach (String yazici in PrinterSettings.InstalledPrinters)
                {
                    cmbYaziciListesi.Items.Add(yazici);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
        }
    }
}