using System;
using System.Globalization;
using System.Windows.Forms;

namespace RabtBil_Musteri_Kayit_v2
{
    public partial class FrmUrunTeslim : Form
    {
        public FrmUrunTeslim()
        {
            InitializeComponent();
        }

        private void FrmUrunTeslim_Load(object sender, EventArgs e)
        {
            tmrTarihSaat.Enabled = true;
        }

        private void tmrTarihSaat_Tick(object sender, EventArgs e)
        {
            tslblTarihSaat.Text = DateTime.Now.ToString(CultureInfo.CurrentCulture);
        }
    }
}