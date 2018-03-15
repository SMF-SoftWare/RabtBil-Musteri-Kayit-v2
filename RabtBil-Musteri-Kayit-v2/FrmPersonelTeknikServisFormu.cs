using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RabtBil_Musteri_Kayit_v2
{
    public partial class FrmPersonelTeknikServisFormu : Form
    {
        public FrmPersonelTeknikServisFormu()
        {
            InitializeComponent();
        }

        private void chckboxTeslimEdildi_CheckedChanged(object sender, EventArgs e)
        {
            FrmUrunTeslim frmUrunTeslim = new FrmUrunTeslim();
            frmUrunTeslim.ShowDialog();
        }

        private void btnKayitlariGoster_Click(object sender, EventArgs e)
        {
            SMF.FrmKayitlariGoster.Show();
            Hide();
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            SMF.FrmGirisYap.Show();
            base.Close();
        }
    }
}
