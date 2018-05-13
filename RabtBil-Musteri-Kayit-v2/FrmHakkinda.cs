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
    }
}