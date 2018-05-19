using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RabtBil_Musteri_Kayit_v2
{
    public partial class FrmYazdir : Form
    {
        public FrmYazdir()
        {
            InitializeComponent();
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

        private void pdcBelge_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font yaziTipi = new Font("Segoe UI", 12, FontStyle.Regular);
            SolidBrush yaziRengi = new SolidBrush(Color.Black);
            e.Graphics.DrawImage(Properties.Resources.RabtBilYaziciSablonu, 0, 0);
            e.Graphics.DrawString(dgvRabtBilDB.CurrentRow?.Cells[1].Value.ToString(), yaziTipi, yaziRengi, 244, 356); //MüşteriAdı
            e.Graphics.DrawString(dgvRabtBilDB.CurrentRow?.Cells[2].Value.ToString(), yaziTipi, yaziRengi, 244, 400); //Telefon
            e.Graphics.DrawString(dgvRabtBilDB.CurrentRow?.Cells[3].Value.ToString(), yaziTipi, yaziRengi, 244, 446); //CihazModeli
            e.Graphics.DrawString(dgvRabtBilDB.CurrentRow?.Cells[4].Value.ToString(), yaziTipi, yaziRengi, 244, 490); //SeriNumarası
            e.Graphics.DrawString(dgvRabtBilDB.CurrentRow?.Cells[5].Value.ToString(), yaziTipi, yaziRengi, 244, 533); //ArızaTanımı
            e.Graphics.DrawString(dgvRabtBilDB.CurrentRow?.Cells[9].Value.ToString(), yaziTipi, yaziRengi, 244, 577); //CihazDurumu
            e.Graphics.DrawString(dgvRabtBilDB.CurrentRow?.Cells[8].Value.ToString(), yaziTipi, yaziRengi, 244, 624); //TakipNumarası
            e.Graphics.DrawString(dgvRabtBilDB.CurrentRow?.Cells[6].Value.ToString(), yaziTipi, yaziRengi, 244, 671); //Aksesuar
            e.Graphics.DrawString(dgvRabtBilDB.CurrentRow?.Cells[10].Value + " ₺", yaziTipi, yaziRengi, 657, 774);
            e.Graphics.DrawString(dgvRabtBilDB.CurrentRow?.Cells[12].Value.ToString(), yaziTipi, yaziRengi, 589, 310); //Tarih
        }
    }
}
