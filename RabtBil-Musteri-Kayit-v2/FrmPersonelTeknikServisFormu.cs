using RabtBil_Musteri_Kayit_v2.Properties;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace RabtBil_Musteri_Kayit_v2
{
    public partial class FrmPersonelTeknikServisFormu : Form
    {
        public FrmPersonelTeknikServisFormu()
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

        private void FrmPersonelTeknikServisFormu_Load(object sender, EventArgs e)
        {
            if (SMF.LisansliMi)
            {
                btnProgramiEtkinlestir.Enabled = false;
            }

            txtTakipNumarasi.Text = SMF.TakipKoduOlustur();
            cmbCihazDurumu.SelectedIndex = 0;

            try
            {
                picProfilResmi.Image = File.Exists(SMF.ProfilResmiYolu) ? Image.FromFile(SMF.ProfilResmiYolu) : Resources.varsayilanProfilResmi;
            }
            catch
            {
                picProfilResmi.Image = Resources.varsayilanProfilResmi;
            }
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Yeni Kayıt Açılsın Mı?", SMF.PrograminTamAdi, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.No)
            {
                return;
            }

            Temizle();
            btnYeniKayit.Enabled = false;
            btnKaydet.Enabled = true;
            btnGuncelle.Enabled = false;
            btnTeslimEt.Enabled = false;
            btnYazdir.Enabled = false;
            btnSil.Enabled = false;
            txtTakipNumarasi.Text = SMF.TakipKoduOlustur();
            lblMusteriNo.Text = String.Empty;
            txtMusteriAdi.Focus();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtMusteriAdi.Text))
            {
                MessageBox.Show("Müşteri Adı Boş!", SMF.PrograminTamAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMusteriAdi.Focus();
                return;
            }

            if (mtxTelefon.Text == @"(    )        ")
            {
                MessageBox.Show("Telefon Boş!", SMF.PrograminTamAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtxTelefon.Focus();
                return;
            }

            if (String.IsNullOrWhiteSpace(txtAksesuarlar.Text))
            {
                MessageBox.Show("Aksesuarlar Boş!", SMF.PrograminTamAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAksesuarlar.Focus();
                return;
            }

            if (String.IsNullOrWhiteSpace(txtEkBilgiler.Text))
            {
                MessageBox.Show("Ek Bilgiler Boş!", SMF.PrograminTamAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEkBilgiler.Focus();
                return;
            }

            if (String.IsNullOrWhiteSpace(txtCihazModeli.Text))
            {
                MessageBox.Show("Cihaz Modeli Boş!", SMF.PrograminTamAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCihazModeli.Focus();
                return;
            }

            if (String.IsNullOrWhiteSpace(txtCihazinSeriNumarası.Text))
            {
                MessageBox.Show("Cihazın Seri Numarası Boş!", SMF.PrograminTamAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCihazinSeriNumarası.Focus();
                return;
            }

            if (String.IsNullOrWhiteSpace(txtArizaninTanimi.Text))
            {
                MessageBox.Show("Arızanın Tanımı Boş!", SMF.PrograminTamAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtArizaninTanimi.Focus();
                return;
            }

            if (cmbCihazDurumu.SelectedIndex == 0)
            {
                MessageBox.Show("Cihaz Durumu Boş!", SMF.PrograminTamAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCihazDurumu.Focus();
                return;
            }

            if (String.IsNullOrWhiteSpace(txtUcret.Text))
            {
                MessageBox.Show("Ücret Boş!", SMF.PrograminTamAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUcret.Focus();
                return;
            }

            DialogResult dr = MessageBox.Show("Kayıt Eklensin Mi?", SMF.PrograminTamAdi, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.No)
            {
                return;
            }

            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO MusteriBilgileri(MusteriAdi, Telefon, Aksesuarlar, EkBilgiler, CihazModeli, CihazinSeriNumarasi, ArizaTanimi, CihazDurumu, Ucret, TakipNumarasi, KaydiYapanID, KayitTarihi) VALUES(@MusteriAdi, @Telefon, @Aksesuarlar, @EkBilgiler, @CihazModeli, @CihazinSeriNumarasi, @ArizaTanimi, @CihazDurumu, @Ucret, @TakipNumarasi, @KaydiYapanID, @KayitTarihi); SELECT SCOPE_IDENTITY()", SMF.Baglanti);
                cmd.Parameters.AddWithValue("@MusteriAdi", txtMusteriAdi.Text);
                cmd.Parameters.AddWithValue("@Telefon", mtxTelefon.Text);
                cmd.Parameters.AddWithValue("@Aksesuarlar", txtAksesuarlar.Text);
                cmd.Parameters.AddWithValue("@EkBilgiler", txtEkBilgiler.Text);
                cmd.Parameters.AddWithValue("@CihazModeli", txtCihazModeli.Text);
                cmd.Parameters.AddWithValue("@CihazinSeriNumarasi", txtCihazinSeriNumarası.Text);
                cmd.Parameters.AddWithValue("@ArizaTanimi", txtArizaninTanimi.Text);
                cmd.Parameters.AddWithValue("@CihazDurumu", cmbCihazDurumu.Text);
                cmd.Parameters.AddWithValue("@Ucret", Convert.ToDouble(txtUcret.Text));
                cmd.Parameters.AddWithValue("@TakipNumarasi", txtTakipNumarasi.Text);
                cmd.Parameters.AddWithValue("@KaydiYapanID", SMF.KullaniciId);
                cmd.Parameters.AddWithValue("@KayitTarihi", DateTime.Now);
                SMF.BaglantiKapaliysaAc();
                lblMusteriNo.Text = cmd.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
            finally
            {
                SMF.Baglanti.Close();
            }

            btnYeniKayit.Enabled = true;
            btnKaydet.Enabled = false;
            btnGuncelle.Enabled = true;
            btnTeslimEt.Enabled = true;
            btnYazdir.Enabled = true;
            btnSil.Enabled = true;
        }

        private void btnKayitlariGoster_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM MusteriBilgileri", SMF.Baglanti);
                cmd.Parameters.AddWithValue("@KaydiYapanID", SMF.KullaniciId);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                if (dt.Rows.Count < 1)
                {
                    MessageBox.Show("Veritabanında Hiç Kayıt Yok!", SMF.PrograminTamAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtMusteriAdi.Text))
            {
                MessageBox.Show("Müşteri Adı Boş!", SMF.PrograminTamAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMusteriAdi.Focus();
                return;
            }

            if (mtxTelefon.Text == @"(    )        ")
            {
                MessageBox.Show("Telefon Boş!", SMF.PrograminTamAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtxTelefon.Focus();
                return;
            }

            if (String.IsNullOrWhiteSpace(txtAksesuarlar.Text))
            {
                MessageBox.Show("Aksesuarlar Boş!", SMF.PrograminTamAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAksesuarlar.Focus();
                return;
            }

            if (String.IsNullOrWhiteSpace(txtEkBilgiler.Text))
            {
                MessageBox.Show("Ek Bilgiler Boş!", SMF.PrograminTamAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEkBilgiler.Focus();
                return;
            }

            if (String.IsNullOrWhiteSpace(txtCihazModeli.Text))
            {
                MessageBox.Show("Cihaz Modeli Boş!", SMF.PrograminTamAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCihazModeli.Focus();
                return;
            }

            if (String.IsNullOrWhiteSpace(txtCihazinSeriNumarası.Text))
            {
                MessageBox.Show("Cihazın Seri Numarası Boş!", SMF.PrograminTamAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCihazinSeriNumarası.Focus();
                return;
            }

            if (String.IsNullOrWhiteSpace(txtArizaninTanimi.Text))
            {
                MessageBox.Show("Arızanın Tanımı Boş!", SMF.PrograminTamAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtArizaninTanimi.Focus();
                return;
            }

            if (cmbCihazDurumu.SelectedIndex == 0)
            {
                MessageBox.Show("Cihaz Durumu Boş!", SMF.PrograminTamAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCihazDurumu.Focus();
                return;
            }

            if (String.IsNullOrWhiteSpace(txtUcret.Text))
            {
                MessageBox.Show("Ücret Boş!", SMF.PrograminTamAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUcret.Focus();
                return;
            }

            DialogResult dr = MessageBox.Show("Kayıt Güncellensin Mi?", SMF.PrograminTamAdi, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.No)
            {
                return;
            }

            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE MusteriBilgileri SET MusteriAdi=@MusteriAdi, Telefon=@Telefon, Aksesuarlar=@Aksesuarlar, EkBilgiler=@EkBilgiler, CihazModeli=@CihazModeli, CihazinSeriNumarasi=@CihazinSeriNumarasi, ArizaTanimi=@ArizaTanimi, CihazDurumu=@CihazDurumu, Ucret=@Ucret, TakipNumarasi=@TakipNumarasi, GuncelleyenID=@GuncelleyenID, GuncellemeTarihi=@GuncellemeTarihi WHERE ID=@ID", SMF.Baglanti);
                cmd.Parameters.AddWithValue("@MusteriAdi", txtMusteriAdi.Text);
                cmd.Parameters.AddWithValue("@Telefon", mtxTelefon.Text);
                cmd.Parameters.AddWithValue("@Aksesuarlar", txtAksesuarlar.Text);
                cmd.Parameters.AddWithValue("@EkBilgiler", txtEkBilgiler.Text);
                cmd.Parameters.AddWithValue("@CihazModeli", txtCihazModeli.Text);
                cmd.Parameters.AddWithValue("@CihazinSeriNumarasi", txtCihazinSeriNumarası.Text);
                cmd.Parameters.AddWithValue("@ArizaTanimi", txtArizaninTanimi.Text);
                cmd.Parameters.AddWithValue("@CihazDurumu", cmbCihazDurumu.Text);
                cmd.Parameters.AddWithValue("@Ucret", Convert.ToDouble(txtUcret.Text));
                cmd.Parameters.AddWithValue("@TakipNumarasi", txtTakipNumarasi.Text);
                cmd.Parameters.AddWithValue("@GuncelleyenID", SMF.KullaniciId);
                cmd.Parameters.AddWithValue("@GuncellemeTarihi", DateTime.Now);
                cmd.Parameters.AddWithValue("@ID", lblMusteriNo.Text);
                SMF.BaglantiKapaliysaAc();
                cmd.ExecuteNonQuery();
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
            FrmUrunTeslim frm = new FrmUrunTeslim();
            frm.ShowDialog();
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            FrmYazdir frm = new FrmYazdir();
            frm.ShowDialog();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bu Kayıt Silinsin Mi?", SMF.PrograminTamAdi, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.No)
            {
                return;
            }

            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM MusteriBilgileri WHERE Id=@Id", SMF.Baglanti);
                cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(lblMusteriNo.Text));
                SMF.BaglantiKapaliysaAc();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
            finally
            {
                SMF.Baglanti.Close();
            }

            Temizle();
            btnYeniKayit.Enabled = false;
            btnKaydet.Enabled = true;
            btnGuncelle.Enabled = false;
            btnTeslimEt.Enabled = false;
            btnYazdir.Enabled = false;
            btnSil.Enabled = false;
            txtTakipNumarasi.Text = SMF.TakipKoduOlustur();
            lblMusteriNo.Text = String.Empty;
            txtMusteriAdi.Focus();
        }

        private void PcTrBoxProfilResim_Click(object sender, EventArgs e)
        {
            FrmProfil frm = new FrmProfil();
            frm.ShowDialog();
        }

        private void btnProgramiEtkinlestir_Click(object sender, EventArgs e)
        {
            FrmProgramiEtkinlestir frm = new FrmProgramiEtkinlestir();
            frm.ShowDialog();
        }

        private void btnHakkinda_Click(object sender, EventArgs e)
        {
            FrmHakkinda frm = new FrmHakkinda();
            frm.ShowDialog();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void Temizle()
        {
            txtMusteriAdi.Clear();
            mtxTelefon.Clear();
            txtAksesuarlar.Clear();
            txtEkBilgiler.Clear();
            txtCihazModeli.Clear();
            txtCihazinSeriNumarası.Clear();
            txtArizaninTanimi.Clear();
            cmbCihazDurumu.SelectedIndex = 0;
            txtUcret.Clear();
        }
    }
}