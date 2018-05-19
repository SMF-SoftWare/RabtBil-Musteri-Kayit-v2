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
    }
}
