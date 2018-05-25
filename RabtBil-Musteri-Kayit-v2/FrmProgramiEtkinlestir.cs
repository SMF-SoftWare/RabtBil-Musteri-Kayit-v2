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
            if (String.IsNullOrWhiteSpace(txtEpostaAdresi.Text))
            {
                MessageBox.Show("E-posta Adresi Boş!", SMF.PrograminTamAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEpostaAdresi.Focus();
                return;
            }

            if (String.IsNullOrWhiteSpace(txtLisansAnahtari.Text))
            {
                MessageBox.Show("Lisans Anahtarı Boş!", SMF.PrograminTamAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLisansAnahtari.Focus();
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
                    MessageBox.Show("Programı Etkinleştirdiğiniz İçin Teşekkür Ederiz!", SMF.PrograminTamAdi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Lisans Bilgileri Yanlış!", SMF.PrograminTamAdi, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEpostaAdresi.Focus();
                }
            }
            else
            {
                MessageBox.Show("Doğru Bir E-posta Adresi Girin!", SMF.PrograminTamAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEpostaAdresi.Focus();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}