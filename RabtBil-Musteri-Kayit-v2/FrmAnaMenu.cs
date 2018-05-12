using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RabtBil_Musteri_Kayit_v2
{
    public partial class FrmAnaMenu : Form
    {
        public FrmAnaMenu()
        {
            InitializeComponent();
        }

        private void btnTeknikServisFormu_Click(object sender, EventArgs e)
        {
            FrmPersonelTeknikServisFormu frm = new FrmPersonelTeknikServisFormu();
            frm.ShowDialog();
        }

        private void btnKayitlariGoster_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM MusteriBilgileri", SMF.Baglanti);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                if (dt.Rows.Count < 1)
                {
                    MessageBox.Show("Veritabanında Hiç Kayıt Yok!", SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
            finally
            {
                SMF.Baglanti.Close();
            }

            FrmKayitlariGoster frm = new FrmKayitlariGoster();
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
    }
}