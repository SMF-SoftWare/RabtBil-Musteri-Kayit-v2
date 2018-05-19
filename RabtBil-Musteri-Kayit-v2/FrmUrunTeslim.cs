using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RabtBil_Musteri_Kayit_v2
{
    public partial class FrmUrunTeslim : Form
    {
        public FrmUrunTeslim()
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

        private readonly FrmPersonelTeknikServisFormu frm = (FrmPersonelTeknikServisFormu)Application.OpenForms["FrmPersonelTeknikServisFormu"];

        private void FrmUrunTeslim_Load(object sender, EventArgs e)
        {
            string teslimEdenId = String.Empty;

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
                else
                {
                    lblTeslimEdenPersonel.Text = "Teslim Edecek Olan Personel";
                    txtTeslimEdenPersonel.Text = $"{SMF.Adi} {SMF.Soyadi}";
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

        private void btnTeslimEt_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtTeslimAlanKisi.Text))
            {
                MessageBox.Show("Teslim Alacak Olan Kişiyi Yazın!");
                txtTeslimAlanKisi.Focus();
                return;
            }

            DialogResult dr = MessageBox.Show("Cihaz Teslim Edilsin Mi?", SMF.PrograminTamAdi, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.No)
            {
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
                MessageBox.Show("Cihaz Teslim Edildi!", SMF.PrograminTamAdi, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}