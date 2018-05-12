using System;
using System.Windows.Forms;

namespace RabtBil_Musteri_Kayit_v2
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FrmGirisYap frm = new FrmGirisYap();
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                Application.Run(new FrmPersonelTeknikServisFormu());
            }
        }
    }
}