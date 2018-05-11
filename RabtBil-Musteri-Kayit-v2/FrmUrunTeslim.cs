using System;
using System.Data.SqlClient;
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

        private FrmPersonelTeknikServisFormu frm = (FrmPersonelTeknikServisFormu)Application.OpenForms["FrmPersonelTeknikServisFormu"];

        private void FrmUrunTeslim_Load(object sender, EventArgs e)
        {
            tmrTarihSaat.Enabled = true;
            string teslimEdenId = null;

            try
            {
                SMF.BaglantiKapaliysaAc();
                SqlCommand cmd = new SqlCommand("SELECT TeslimEdenID, TeslimAlan, TeslimTarihi FROM MusteriBilgileri WHERE ID=@ID", SMF.Baglanti);
                cmd.Parameters.AddWithValue("@ID", frm.lblMusteriNo.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    teslimEdenId = dr["TeslimEdenID"].ToString();
                    txtTeslimAlanKisi.Text = dr["TeslimAlan"].ToString();
                    lblTarih.Text = dr["TeslimTarihi"].ToString();
                }
                dr.Close();

                cmd = new SqlCommand("SELECT Adi, Soyadi FROM Kullanicilar WHERE ID=@ID", SMF.Baglanti);
                cmd.Parameters.AddWithValue("@ID", teslimEdenId);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtTeslimEdenPersonel.Text = $"{dr["Adi"]} {dr["Soyadi"]}";
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
            finally
            {
                SMF.Baglanti.Close();
            }
        }

        private void tmrTarihSaat_Tick(object sender, EventArgs e)
        {
            tslblTarihSaat.Text = DateTime.Now.ToString(CultureInfo.CurrentCulture);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtTeslimAlanKisi.Text))
            {
                MessageBox.Show("Teslim Alan Kişiyi Yazın!");
                return;
            }
            try
            {
                SMF.BaglantiKapaliysaAc();
                SqlCommand kaydet = new SqlCommand("UPDATE MusteriBilgileri SET TeslimEdenID=@TeslimEdenID, TeslimAlan=@TeslimAlan, TeslimTarihi=@TeslimTarihi WHERE ID=@ID", SMF.Baglanti);
                kaydet.Parameters.AddWithValue("@TeslimEdenID", SMF.KullaniciId);
                kaydet.Parameters.AddWithValue("@TeslimAlan", txtTeslimAlanKisi.Text);
                kaydet.Parameters.AddWithValue("@TeslimTarihi", DateTime.Now);
                kaydet.Parameters.AddWithValue("@ID", frm.lblMusteriNo.Text);
                kaydet.ExecuteNonQuery();
                MessageBox.Show("Kaydedildi", SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
            finally
            {
                SMF.Baglanti.Close();
            }
        }

        private void FrmUrunTeslim_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                SMF.BaglantiKapaliysaAc();
                SqlCommand cmd = new SqlCommand("SELECT TeslimEdenId FROM MusteriBilgileri WHERE ID=@ID", SMF.Baglanti);
                cmd.Parameters.AddWithValue("@ID", frm.lblMusteriNo.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    frm.chkTeslimEdildi.Checked = dr["TeslimEdenId"].ToString() != "";
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
            finally
            {
                SMF.Baglanti.Close();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtTeslimAlanKisi.Clear();
        }
    }
}