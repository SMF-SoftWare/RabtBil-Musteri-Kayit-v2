﻿using RabtBil_Musteri_Kayit_v2.Properties;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RabtBil_Musteri_Kayit_v2
{
    public partial class FrmPersonelEkle : Form
    {
        public FrmPersonelEkle()
        {
            InitializeComponent();
        }

        private int rol;
        private bool gozeTiklandiMi;
        private int secilenId;
        private int secilenRol;

        private void FrmPersonelEkle_Load(object sender, EventArgs e)
        {
            VerileriGetir();

            dgvKullanicilar.Columns[0].HeaderText = "ID";
            dgvKullanicilar.Columns[1].HeaderText = "Kullanıcı Adı";
            dgvKullanicilar.Columns[2].HeaderText = "Adı";
            dgvKullanicilar.Columns[3].HeaderText = "Soyadı";
            dgvKullanicilar.Columns[3].HeaderText = "E-posta";
            dgvKullanicilar.Columns[3].HeaderText = "Rol";
            cmbRoller.SelectedIndex = 0;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(txtKullaniciAdi.Text) || String.IsNullOrWhiteSpace(txtAdi.Text) || String.IsNullOrWhiteSpace(txtSoyadi.Text) || String.IsNullOrWhiteSpace(txtSifre.Text) || String.IsNullOrWhiteSpace(txtSifreyiOnayla.Text))
                {
                    MessageBox.Show("Resources.metinKutulariBos", SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!SMF.EpostaDogruMu(txtEpostaAdresi.Text))
                {
                    MessageBox.Show("Resources.dogruEpostaGir", SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbRoller.SelectedIndex == 0)
                {
                    MessageBox.Show("Bir Rol Seçin!", SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txtSifre.Text == txtSifreyiOnayla.Text)
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Kullanicilar(KullaniciAdi, Sifre, Adi, Soyadi, Eposta, Rol) VALUES(@KullaniciAdi, @Sifre, @Adi, @Soyadi, @Eposta, @Rol)", SMF.Baglanti);
                    cmd.Parameters.AddWithValue("@KullaniciAdi", txtKullaniciAdi.Text);
                    cmd.Parameters.AddWithValue("@Sifre", SMF.GetMd5Hash(txtSifre.Text));
                    cmd.Parameters.AddWithValue("@Adi", txtAdi.Text);
                    cmd.Parameters.AddWithValue("@Soyadi", txtSoyadi.Text);
                    cmd.Parameters.AddWithValue("@Eposta", txtEpostaAdresi.Text);
                    switch (cmbRoller.SelectedIndex)
                    {
                        case 1:
                            rol = 2;
                            break;

                        case 2:
                            rol = 1;
                            break;

                        case 3:
                            rol = 0;
                            break;
                    }
                    cmd.Parameters.AddWithValue("@Rol", rol);
                    SMF.BaglantiKapaliysaAc();
                    cmd.ExecuteNonQuery();
                    EkleEtkinMi(true);
                    GuncelleEtkinMi(false);
                    Temizle();
                    VerileriGetir();
                    MessageBox.Show("Resources.kaydedildi", SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void pbxEye_Click(object sender, EventArgs e)
        {
            if (gozeTiklandiMi)
            {
                pbxEye.Image = Resources.eye;
                txtSifre.UseSystemPasswordChar = true;
                txtSifreyiOnayla.UseSystemPasswordChar = true;
                gozeTiklandiMi = false;
            }
            else
            {
                pbxEye.Image = Resources.eye_off;
                txtSifre.UseSystemPasswordChar = false;
                txtSifreyiOnayla.UseSystemPasswordChar = false;
                gozeTiklandiMi = true;
            }
        }

        public void VerileriGetir()
        {
            try
            {
                SMF.BaglantiKapaliysaAc();
                SqlDataAdapter da = new SqlDataAdapter("SELECT Id,KullaniciAdi,Adi,Soyadi,Eposta,Rol FROM Kullanicilar", SMF.Baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvKullanicilar.DataSource = dt;
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

        public void Temizle()
        {
            txtKullaniciAdi.Clear();
            txtAdi.Clear();
            txtSoyadi.Clear();
            txtEpostaAdresi.Clear();
            txtSifre.Clear();
            txtSifreyiOnayla.Clear();
            cmbRoller.SelectedIndex = 0;

            pbxEye.Image = Resources.eye;
            txtSifre.UseSystemPasswordChar = true;
            txtSifreyiOnayla.UseSystemPasswordChar = true;
            gozeTiklandiMi = false;
        }

        public void GuncelleEtkinMi(bool value)
        {
            btnGuncelle.Enabled = value;
        }

        public void EkleEtkinMi(bool value)
        {
            btnEkle.Enabled = value;
        }

        private void dgvKullanicilar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            secilenId = Convert.ToInt32(dgvKullanicilar.CurrentRow?.Cells[0].Value);
            txtKullaniciAdi.Text = dgvKullanicilar.CurrentRow?.Cells[1].Value.ToString();
            txtAdi.Text = dgvKullanicilar.CurrentRow?.Cells[2].Value.ToString();
            txtSoyadi.Text = dgvKullanicilar.CurrentRow?.Cells[3].Value.ToString();
            txtEpostaAdresi.Text = dgvKullanicilar.CurrentRow?.Cells[4].Value.ToString();

            switch (dgvKullanicilar.CurrentRow?.Cells[5].Value)
            {
                case 0:
                    secilenRol = 3;
                    break;

                case 1:
                    secilenRol = 2;
                    break;

                case 2:
                    secilenRol = 1;
                    break;

                default:
                    secilenRol = 0;
                    break;
            }

            cmbRoller.SelectedIndex = secilenRol;

            btnEkle.Enabled = false;
            btnGuncelle.Enabled = true;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(txtKullaniciAdi.Text) || String.IsNullOrWhiteSpace(txtAdi.Text) || String.IsNullOrWhiteSpace(txtSoyadi.Text) || String.IsNullOrWhiteSpace(txtSifre.Text) || String.IsNullOrWhiteSpace(txtSifreyiOnayla.Text))
                {
                    MessageBox.Show("Resources.metinKutulariBos", SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!SMF.EpostaDogruMu(txtEpostaAdresi.Text))
                {
                    MessageBox.Show("Resources.dogruEpostaGir", SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbRoller.SelectedIndex == 0)
                {
                    MessageBox.Show("Bir Rol Seçin!", SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txtSifre.Text == txtSifreyiOnayla.Text)
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Kullanicilar SET KullaniciAdi=@KullaniciAdi, Sifre=@Sifre, Adi=@Adi, Soyadi=@Soyadi, Eposta=@Eposta, Rol=@Rol WHERE Id=@Id", SMF.Baglanti);
                    cmd.Parameters.AddWithValue("@KullaniciAdi", txtKullaniciAdi.Text);
                    cmd.Parameters.AddWithValue("@Sifre", SMF.GetMd5Hash(txtSifre.Text));
                    cmd.Parameters.AddWithValue("@Adi", txtAdi.Text);
                    cmd.Parameters.AddWithValue("@Soyadi", txtSoyadi.Text);
                    cmd.Parameters.AddWithValue("@Eposta", txtEpostaAdresi.Text);
                    switch (cmbRoller.SelectedIndex)
                    {
                        case 1:
                            rol = 2;
                            break;

                        case 2:
                            rol = 1;
                            break;

                        case 3:
                            rol = 0;
                            break;
                    }
                    cmd.Parameters.AddWithValue("@Rol", rol);
                    cmd.Parameters.AddWithValue("@Id", secilenId);
                    SMF.BaglantiKapaliysaAc();
                    cmd.ExecuteNonQuery();
                    EkleEtkinMi(true);
                    GuncelleEtkinMi(false);
                    Temizle();
                    VerileriGetir();
                    MessageBox.Show("Resources.kaydedildi", SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Kullanicilar WHERE Id=@Id", SMF.Baglanti);
                cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(dgvKullanicilar.CurrentRow?.Cells[0].Value));
                SMF.BaglantiKapaliysaAc();

                DialogResult dr = MessageBox.Show("Seçilen Personel Silinsin mi", SMF.UygulamaAdi, MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dr == DialogResult.No)
                {
                    return;
                }

                cmd.ExecuteNonQuery();
                Temizle();
                VerileriGetir();
                MessageBox.Show("Resources.secilenKayitSilindi", SMF.UygulamaAdi, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}