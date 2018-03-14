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
    public partial class FrmHesapAc : Form
    {
        public FrmHesapAc()
        {
            InitializeComponent();
        }

        private void BttnYoneticiGiris_Click(object sender, EventArgs e)
        {
            FrmGirisYap _frmGirisYap = new FrmGirisYap();
            _frmGirisYap.Show();
            Hide();
            _frmGirisYap.LblGirisBicimi.Text = "Yönetici Giriş";
        }

        private void BttnPersonelGiris_Click(object sender, EventArgs e)
        {
            FrmGirisYap _frmGirisYap = new FrmGirisYap();
            _frmGirisYap.Show();
            Hide();
            _frmGirisYap.LblGirisBicimi.Text = "Personel Giriş";
        }
    }
}
