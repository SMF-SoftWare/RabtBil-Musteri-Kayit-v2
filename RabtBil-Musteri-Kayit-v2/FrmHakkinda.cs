using System;
using System.Drawing;
using System.Windows.Forms;

namespace RabtBil_Musteri_Kayit_v2
{
    public partial class FrmHakkinda : Form
    {
        public FrmHakkinda()
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

        private void FrmHakkinda_Load(object sender, System.EventArgs e)
        {
            lblProgramAdi.Text = SMF.PrograminAdi;
            lblSurumNumarasi.Text = SMF.ProgramSurumu;
            if (SMF.LisansliMi)
            {
                lblLisans.Text = "Lisanslı";
                lblLisans.ForeColor = Color.Green;
            }
            else
            {
                lblLisans.Text = "Lisanssız";
                lblLisans.ForeColor = Color.Red;
            }
        }

        private void kapat_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}