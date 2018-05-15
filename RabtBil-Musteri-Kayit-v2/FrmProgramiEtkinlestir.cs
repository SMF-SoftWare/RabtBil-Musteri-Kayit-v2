using RabtBil_Musteri_Kayit_v2.Properties;
using System;
using System.Windows.Forms;

namespace RabtBil_Musteri_Kayit_v2
{
    public partial class FrmProgramiEtkinlestir : Form
    {
        public FrmProgramiEtkinlestir()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        private void btnEtkinlestir_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtEpostaAdresi.Text) || String.IsNullOrWhiteSpace(txtLisansAnahtari.Text))
            {
                MessageBox.Show("Resources.epostaVeyaLisansAnahtariBos", SMF.PrograminTamAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (SMF.EpostaDogruMu(txtEpostaAdresi.Text))
            {
                if (SMF.LisansiKontrolEt(txtEpostaAdresi.Text, txtLisansAnahtari.Text))
                {
                    SMF.LisansliMi = true;
                    Settings.Default.LisansliMi = true;
                    Settings.Default.LisansAnahtari = txtLisansAnahtari.Text.ToUpper();
                    Settings.Default.Eposta = txtEpostaAdresi.Text.ToUpper();
                    Settings.Default.Save();
                    MessageBox.Show("Resources.lisansBasarili", SMF.PrograminTamAdi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Resources.lisansTekrarDene", SMF.PrograminTamAdi, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Resources.dogruBirEpostaGirin", SMF.PrograminTamAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void kapat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}