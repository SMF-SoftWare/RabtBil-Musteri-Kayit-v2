using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RabtBil_Musteri_Kayit_v2.Properties;

namespace RabtBil_Musteri_Kayit_v2
{
    public partial class FrmProgramiEtkinlestir : Form
    {
        public FrmProgramiEtkinlestir()
        {
            InitializeComponent();
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
                    Settings.Default.LisansliMi = true;
                    Settings.Default.LisansAnahtari = txtLisansAnahtari.Text.ToUpper();
                    Settings.Default.Eposta = txtEpostaAdresi.Text.ToUpper();
                    Settings.Default.Save();
                    MessageBox.Show("Resources.lisansBasarili", SMF.PrograminTamAdi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    Settings.Default.LisansliMi = false;
                    Settings.Default.LisansAnahtari = null;
                    Settings.Default.Eposta = null;
                    Settings.Default.Save();
                    MessageBox.Show("Resources.lisansTekrarDene", SMF.PrograminTamAdi, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Resources.dogruBirEpostaGirin", SMF.PrograminTamAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
