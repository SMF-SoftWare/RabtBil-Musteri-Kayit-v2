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

        private void btnTeknikServisFormu_Click(object sender, EventArgs e)
        {
            FrmPersonelTeknikServisFormu frm = new FrmPersonelTeknikServisFormu();
            frm.ShowDialog();
        }

        private void btnProfiliDuzenle_Click(object sender, EventArgs e)
        {
            FrmProfil frm = new FrmProfil();
            frm.ShowDialog();
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            FrmPersonelEkle frm = new FrmPersonelEkle();
            frm.ShowDialog();
        }

        private void btnProgramHakkinda_Click(object sender, EventArgs e)
        {
            FrmHakkinda frm = new FrmHakkinda();
            frm.ShowDialog();
        }

        private void btnProgramiEtkinlestir_Click(object sender, EventArgs e)
        {
            FrmProgramiEtkinlestir frm = new FrmProgramiEtkinlestir();
            frm.ShowDialog();
        }

        private void FrmAnaMenu_Load(object sender, EventArgs e)
        {
            if (SMF.LisansliMi && SMF.AdminMi)
            {
                btnProgramiEtkinlestir.Enabled = true;
            }
            else if (SMF.LisansliMi)
            {
                btnProgramiEtkinlestir.Enabled = false;
            }
        }

        private void kapat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}