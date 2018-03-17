using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RabtBil_Musteri_Kayit_v2
{
    public partial class FrmKayitlariGoster : Form
    {
        public FrmKayitlariGoster()
        {
            InitializeComponent();
        }

        private string[] AramaAlanlari = { "Id", "FormNo", "MusteriAdi", "Telefon", "UrunModeli", "UrunKodlari", "UrunTakipNo", "UrunDurumu", "KaydiYapanID", "TeslimEdenID", "TeslimAlan", "GuncellemeTarihi", "TeslimTarihi" };

        public void cmbDoldur()
        {
            cmbAramaAlanlari.Items.Clear();
            cmbAramaAlanlari.Items.AddRange(AramaAlanlari);
        }

        public void VerileriGetir()
        {
            SMF.Baglanti.Open();
            SqlDataAdapter verileriGetir = new SqlDataAdapter("Select * From musteribilgileri", SMF.Baglanti);
            DataTable dataTable1 = new DataTable();
            verileriGetir.Fill(dataTable1);
            dgvRabtBilDB.DataSource = dataTable1;
            SMF.Baglanti.Close();
        }

        public void Guncelle()
        {
            MessageBox.Show("Resources.secilenKaydiDuzenliyorsun", SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Information);
            SMF.FrmPersonelTeknikServisFormu.btnKaydet.Enabled = false;
            SMF.FrmPersonelTeknikServisFormu.mnsAraclarKaydet.Enabled = false;
            SMF.FrmPersonelTeknikServisFormu.btnGuncelle.Enabled = true;
            SMF.FrmPersonelTeknikServisFormu.mnsAraclarGuncelle.Enabled = true;
            SMF.FrmPersonelTeknikServisFormu.lblMusteriNo.Text = dgvRabtBilDB.CurrentRow?.Cells[0].Value.ToString();
            SMF.FrmPersonelTeknikServisFormu.txtFormNo.Text = dgvRabtBilDB.CurrentRow?.Cells[1].Value.ToString();
            SMF.FrmPersonelTeknikServisFormu.txtMusteriAdi.Text = dgvRabtBilDB.CurrentRow?.Cells[2].Value.ToString();
            SMF.FrmPersonelTeknikServisFormu.mtxTelefon.Text = dgvRabtBilDB.CurrentRow?.Cells[3].Value.ToString();
            SMF.FrmPersonelTeknikServisFormu.txtUrunModeli.Text = dgvRabtBilDB.CurrentRow?.Cells[4].Value.ToString();
            SMF.FrmPersonelTeknikServisFormu.txtUrunKodlari.Text = dgvRabtBilDB.CurrentRow?.Cells[5].Value.ToString();
            SMF.FrmPersonelTeknikServisFormu.txtArizaninTanimi.Text = dgvRabtBilDB.CurrentRow?.Cells[6].Value.ToString();
            SMF.FrmPersonelTeknikServisFormu.txtAksesuarlar.Text = dgvRabtBilDB.CurrentRow?.Cells[7].Value.ToString();
            SMF.FrmPersonelTeknikServisFormu.txtEkBilgiler.Text = dgvRabtBilDB.CurrentRow?.Cells[8].Value.ToString();
            SMF.FrmPersonelTeknikServisFormu.txtTakipNumarası.Text = dgvRabtBilDB.CurrentRow?.Cells[9].Value.ToString();
            SMF.FrmPersonelTeknikServisFormu.txtUrunDurumu.Text = dgvRabtBilDB.CurrentRow?.Cells[10].Value.ToString();
            SMF.FrmPersonelTeknikServisFormu.txtUcret.Text = dgvRabtBilDB.CurrentRow?.Cells[11].Value.ToString();
            //SMF.FrmPersonelTeknikServisFormu.SMF.Text = dgvRabtBilDB.CurrentRow?.Cells[12].Value.ToString();KaydiYapanID
            SMF.FrmPersonelTeknikServisFormu.Show();
            Hide();
        }

        private void FrmKayitlariGoster_Load(object sender, EventArgs e)
        {
            VerileriGetir();
            cmbDoldur();
        }

        private void dgvRabtBilDB_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Guncelle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sil = new SqlCommand("DELETE FROM musteribilgileri WHERE Id=@Id", SMF.Baglanti);
                sil.Parameters.AddWithValue("@Id", Convert.ToInt32(dgvRabtBilDB.CurrentRow?.Cells[0].Value.ToString()));
                SMF.Baglanti.Open();
                sil.ExecuteNonQuery();
                MessageBox.Show("Resources.secilenKayitSilindi", SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                SMF.Baglanti.Close();
                VerileriGetir();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Resources.Hata");
            }
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            //switch (cmbAramaAlanlari.Text)
            //{
            //    case AramaAlanlari[0]:
            //        MessageBox.Show("Id'ye Göre");
            //        break;
            //    case "FormNo":
            //        MessageBox.Show("Id'ye Göre");
            //        break;
            //}
            //    txtArama.ReadOnly = false;
            //    SqlDataAdapter arama = new SqlDataAdapter("SELECT * FROM musteribilgileri WHERE FormNo LIKE @Ara", SMF.Baglanti);
            //    arama.SelectCommand.Parameters.AddWithValue("@Ara", "%" + txtArama.Text + "%");
            //    DataSet dataset = new DataSet();
            //    SMF.Baglanti.Open();
            //    arama.Fill(dataset, "musteribilgileri");
            //    dgvRabtBilDB.DataSource = dataset.Tables["musteribilgileri"];
            //    SMF.Baglanti.Close();
        }
    }
}