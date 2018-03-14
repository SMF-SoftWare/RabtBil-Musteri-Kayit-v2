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
    public partial class FrmGirisYap : Form
    {
        public FrmGirisYap()
        {
            InitializeComponent();
        }

        private void BttnCikisYap_Click(object sender, EventArgs e)
        {
            FrmHesapAc _frmHesapAc = new FrmHesapAc();
            _frmHesapAc.Show();
            Close();
        }
    }
}
