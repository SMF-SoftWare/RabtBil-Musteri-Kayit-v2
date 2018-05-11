using System;
using System.Windows.Forms;

namespace RabtBil_Musteri_Kayit_v2
{
    public partial class FrmAnaMenu : Form
    {
        public FrmAnaMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPersonelTeknikServisFormu frm = new FrmPersonelTeknikServisFormu(); ;
            frm.ShowDialog();
        }
    }
}