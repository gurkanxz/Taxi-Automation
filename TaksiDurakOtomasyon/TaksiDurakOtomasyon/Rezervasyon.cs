using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TaksiDurakOtomasyon.Anasayfa;

namespace TaksiDurakOtomasyon
{

    public partial class Rezervasyon : Form
    {
        DLLislemleri.Veritabani vt = new DLLislemleri.Veritabani(ayarlar.Default.SunucuAdi, ayarlar.Default.VeritabaniAdi, ayarlar.Default.UzakSunucuBaglantisi, ayarlar.Default.UserID, ayarlar.Default.Password);
        public Rezervasyon()
        {
            InitializeComponent();
        }
        public string ad, yetki;
        public int personel_id = 1;
        public int yetki_id = 1;
        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Anasayfa a = new Anasayfa();
            a.ad = ad;
            a.yetki = yetki;
            a.yetki_id = yetki_id;
            a.Show();
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            Durak k = new Durak();
            k.yetki_id = yetki_id;
            k.ad = ad;
            k.yetki = yetki;
            if (yetki_id == 1)
            {

            }//tüm yetkiler
            else if (yetki_id == 2)
            {
                k.btn_guncelle.Enabled = false;
                k.ts_guncelle.Enabled = false;
            }//sadece ekle-sil
            else if (yetki_id == 3)
            {
                k.btn_sil.Enabled = false;
                k.ts_sil.Enabled = false;
            }//ekle-güncelle
            else if (yetki_id == 4)
            {
                k.btn_ekle.Enabled = false;
                k.ts_ekle.Enabled = false;
            }//sil-güncelle
            else if (yetki_id == 5)
            {
                k.btn_sil.Enabled = false;
                k.btn_guncelle.Enabled = false;
                k.ts_sil.Enabled = false;
                k.ts_guncelle.Enabled = false;
            }//ekle
            else if (yetki_id == 6)
            {
                k.btn_ekle.Enabled = false;
                k.btn_guncelle.Enabled = false;
                k.ts_ekle.Enabled = false;
                k.ts_guncelle.Enabled = false;
            }//sil
            else if (yetki_id == 7)
            {
                k.btn_ekle.Enabled = false;
                k.btn_sil.Enabled = false;
                k.ts_ekle.Enabled = false;
                k.ts_sil.Enabled = false;
            }//güncelle
            else if (yetki_id == 8)
            {
                k.btn_ekle.Enabled = false;
                k.btn_sil.Enabled = false;
                k.btn_guncelle.Enabled = false;
                k.ts_ekle.Enabled = false;
                k.ts_sil.Enabled = false;
                k.ts_guncelle.Enabled = false;
            }//sadece görüntüleme yetkisi
            else
            {
                MessageBox.Show("Yetkiniz bulunmuyor lütfen yöneticiyle iletişime geçiniz...");
                return;
            }//yetkisiz
            k.Show();
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
            Taksi k = new Taksi();
            k.yetki_id = yetki_id;
            k.ad = ad;
            k.yetki = yetki;
            if (yetki_id == 1)
            {

            }//tüm yetkiler
            else if (yetki_id == 2)
            {
                k.btn_guncelle.Enabled = false;
                k.ts_guncelle.Enabled = false;
            }//sadece ekle-sil
            else if (yetki_id == 3)
            {
                k.btn_sil.Enabled = false;
                k.ts_sil.Enabled = false;
            }//ekle-güncelle
            else if (yetki_id == 4)
            {
                k.btn_ekle.Enabled = false;
                k.ts_ekle.Enabled = false;
            }//sil-güncelle
            else if (yetki_id == 5)
            {
                k.btn_sil.Enabled = false;
                k.btn_guncelle.Enabled = false;
                k.ts_sil.Enabled = false;
                k.ts_guncelle.Enabled = false;
            }//ekle
            else if (yetki_id == 6)
            {
                k.btn_ekle.Enabled = false;
                k.btn_guncelle.Enabled = false;
                k.ts_ekle.Enabled = false;
                k.ts_guncelle.Enabled = false;
            }//sil
            else if (yetki_id == 7)
            {
                k.btn_ekle.Enabled = false;
                k.btn_sil.Enabled = false;
                k.ts_ekle.Enabled = false;
                k.ts_sil.Enabled = false;
            }//güncelle
            else if (yetki_id == 8)
            {
                k.btn_ekle.Enabled = false;
                k.btn_sil.Enabled = false;
                k.btn_guncelle.Enabled = false;
                k.ts_ekle.Enabled = false;
                k.ts_sil.Enabled = false;
                k.ts_guncelle.Enabled = false;
            }//sadece görüntüleme yetkisi
            else
            {
                MessageBox.Show("Yetkiniz bulunmuyor lütfen yöneticiyle iletişime geçiniz...");
                return;
            }//yetkisiz
            k.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Close();
            Personel k = new Personel();
            k.ad = ad;
            k.yetki = yetki;
            k.yetki_id = yetki_id;
            if (yetki_id == 1)
            {

            }//tüm yetkiler
            else if (yetki_id == 2)
            {
                k.btn_guncelle.Enabled = false;
                k.ts_guncelle.Enabled = false;
            }//sadece ekle-sil
            else if (yetki_id == 3)
            {
                k.btn_sil.Enabled = false;
                k.ts_sil.Enabled = false;
            }//ekle-güncelle
            else if (yetki_id == 4)
            {
                k.btn_ekle.Enabled = false;
                k.ts_ekle.Enabled = false;
            }//sil-güncelle
            else if (yetki_id == 5)
            {
                k.btn_sil.Enabled = false;
                k.btn_guncelle.Enabled = false;
                k.ts_sil.Enabled = false;
                k.ts_guncelle.Enabled = false;
            }//ekle
            else if (yetki_id == 6)
            {
                k.btn_ekle.Enabled = false;
                k.btn_guncelle.Enabled = false;
                k.ts_ekle.Enabled = false;
                k.ts_guncelle.Enabled = false;
            }//sil
            else if (yetki_id == 7)
            {
                k.btn_ekle.Enabled = false;
                k.btn_sil.Enabled = false;
                k.ts_ekle.Enabled = false;
                k.ts_sil.Enabled = false;
            }//güncelle
            else if (yetki_id == 8)
            {
                k.btn_ekle.Enabled = false;
                k.btn_sil.Enabled = false;
                k.btn_guncelle.Enabled = false;
                k.ts_ekle.Enabled = false;
                k.ts_sil.Enabled = false;
                k.ts_guncelle.Enabled = false;
            }//sadece görüntüleme yetkisi
            else
            {
                MessageBox.Show("Yetkiniz bulunmuyor lütfen yöneticiyle iletişime geçiniz...");
                return;
            }//yetkisiz
            k.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
            PersonelTur k = new PersonelTur();
            k.ad = ad;
            k.yetki = yetki;
            k.yetki_id = yetki_id;
            if (yetki_id == 1)
            {

            }//tüm yetkiler
            else if (yetki_id == 2)
            {
                k.btn_guncelle.Enabled = false;
                k.ts_guncelle.Enabled = false;
            }//sadece ekle-sil
            else if (yetki_id == 3)
            {
                k.btn_sil.Enabled = false;
                k.ts_sil.Enabled = false;
            }//ekle-güncelle
            else if (yetki_id == 4)
            {
                k.btn_ekle.Enabled = false;
                k.ts_ekle.Enabled = false;
            }//sil-güncelle
            else if (yetki_id == 5)
            {
                k.btn_sil.Enabled = false;
                k.btn_guncelle.Enabled = false;
                k.ts_sil.Enabled = false;
                k.ts_guncelle.Enabled = false;
            }//ekle
            else if (yetki_id == 6)
            {
                k.btn_ekle.Enabled = false;
                k.btn_guncelle.Enabled = false;
                k.ts_ekle.Enabled = false;
                k.ts_guncelle.Enabled = false;
            }//sil
            else if (yetki_id == 7)
            {
                k.btn_ekle.Enabled = false;
                k.btn_sil.Enabled = false;
                k.ts_ekle.Enabled = false;
                k.ts_sil.Enabled = false;
            }//güncelle
            else if (yetki_id == 8)
            {
                k.btn_ekle.Enabled = false;
                k.btn_sil.Enabled = false;
                k.btn_guncelle.Enabled = false;
                k.ts_ekle.Enabled = false;
                k.ts_sil.Enabled = false;
                k.ts_guncelle.Enabled = false;
            }//sadece görüntüleme yetkisi
            else
            {
                MessageBox.Show("Yetkiniz bulunmuyor lütfen yöneticiyle iletişime geçiniz...");
                return;
            }//yetkisiz
            k.Show();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            this.Close();
            Sofor k = new Sofor();
            k.ad = ad;
            k.yetki = yetki;
            k.yetki_id = yetki_id;
            if (yetki_id == 1)
            {

            }//tüm yetkiler
            else if (yetki_id == 2)
            {
                k.btn_guncelle.Enabled = false;
                k.ts_guncelle.Enabled = false;
            }//sadece ekle-sil
            else if (yetki_id == 3)
            {
                k.btn_sil.Enabled = false;
                k.ts_sil.Enabled = false;
            }//ekle-güncelle
            else if (yetki_id == 4)
            {
                k.btn_ekle.Enabled = false;
                k.ts_ekle.Enabled = false;
            }//sil-güncelle
            else if (yetki_id == 5)
            {
                k.btn_sil.Enabled = false;
                k.btn_guncelle.Enabled = false;
                k.ts_sil.Enabled = false;
                k.ts_guncelle.Enabled = false;
            }//ekle
            else if (yetki_id == 6)
            {
                k.btn_ekle.Enabled = false;
                k.btn_guncelle.Enabled = false;
                k.ts_ekle.Enabled = false;
                k.ts_guncelle.Enabled = false;
            }//sil
            else if (yetki_id == 7)
            {
                k.btn_ekle.Enabled = false;
                k.btn_sil.Enabled = false;
                k.ts_ekle.Enabled = false;
                k.ts_sil.Enabled = false;
            }//güncelle
            else if (yetki_id == 8)
            {
                k.btn_ekle.Enabled = false;
                k.btn_sil.Enabled = false;
                k.btn_guncelle.Enabled = false;
                k.ts_ekle.Enabled = false;
                k.ts_sil.Enabled = false;
                k.ts_guncelle.Enabled = false;
            }//sadece görüntüleme yetkisi
            else
            {
                MessageBox.Show("Yetkiniz bulunmuyor lütfen yöneticiyle iletişime geçiniz...");
                return;
            }//yetkisiz
            k.Show();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Close();
            Sofor k = new Sofor();
            k.ad = ad;
            k.yetki = yetki;
            k.yetki_id = yetki_id;
            if (yetki_id == 1)
            {

            }//tüm yetkiler
            else if (yetki_id == 2)
            {
                k.btn_guncelle.Enabled = false;
                k.ts_guncelle.Enabled = false;
            }//sadece ekle-sil
            else if (yetki_id == 3)
            {
                k.btn_sil.Enabled = false;
                k.ts_sil.Enabled = false;
            }//ekle-güncelle
            else if (yetki_id == 4)
            {
                k.btn_ekle.Enabled = false;
                k.ts_ekle.Enabled = false;
            }//sil-güncelle
            else if (yetki_id == 5)
            {
                k.btn_sil.Enabled = false;
                k.btn_guncelle.Enabled = false;
                k.ts_sil.Enabled = false;
                k.ts_guncelle.Enabled = false;
            }//ekle
            else if (yetki_id == 6)
            {
                k.btn_ekle.Enabled = false;
                k.btn_guncelle.Enabled = false;
                k.ts_ekle.Enabled = false;
                k.ts_guncelle.Enabled = false;
            }//sil
            else if (yetki_id == 7)
            {
                k.btn_ekle.Enabled = false;
                k.btn_sil.Enabled = false;
                k.ts_ekle.Enabled = false;
                k.ts_sil.Enabled = false;
            }//güncelle
            else if (yetki_id == 8)
            {
                k.btn_ekle.Enabled = false;
                k.btn_sil.Enabled = false;
                k.btn_guncelle.Enabled = false;
                k.ts_ekle.Enabled = false;
                k.ts_sil.Enabled = false;
                k.ts_guncelle.Enabled = false;
            }//sadece görüntüleme yetkisi
            else
            {
                MessageBox.Show("Yetkiniz bulunmuyor lütfen yöneticiyle iletişime geçiniz...");
                return;
            }//yetkisiz
            k.Show();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            this.Close();
            Musteri k = new Musteri();
            k.ad = ad;
            k.yetki = yetki;
            k.yetki_id = yetki_id;
            if (yetki_id == 1)
            {

            }//tüm yetkiler
            else if (yetki_id == 2)
            {
                k.btn_guncelle.Enabled = false;
                k.ts_guncelle.Enabled = false;
            }//sadece ekle-sil
            else if (yetki_id == 3)
            {
                k.btn_sil.Enabled = false;
                k.ts_sil.Enabled = false;
            }//ekle-güncelle
            else if (yetki_id == 4)
            {
                k.btn_ekle.Enabled = false;
                k.ts_ekle.Enabled = false;
            }//sil-güncelle
            else if (yetki_id == 5)
            {
                k.btn_sil.Enabled = false;
                k.btn_guncelle.Enabled = false;
                k.ts_sil.Enabled = false;
                k.ts_guncelle.Enabled = false;
            }//ekle
            else if (yetki_id == 6)
            {
                k.btn_ekle.Enabled = false;
                k.btn_guncelle.Enabled = false;
                k.ts_ekle.Enabled = false;
                k.ts_guncelle.Enabled = false;
            }//sil
            else if (yetki_id == 7)
            {
                k.btn_ekle.Enabled = false;
                k.btn_sil.Enabled = false;
                k.ts_ekle.Enabled = false;
                k.ts_sil.Enabled = false;
            }//güncelle
            else if (yetki_id == 8)
            {
                k.btn_ekle.Enabled = false;
                k.btn_sil.Enabled = false;
                k.btn_guncelle.Enabled = false;
                k.ts_ekle.Enabled = false;
                k.ts_sil.Enabled = false;
                k.ts_guncelle.Enabled = false;
            }//sadece görüntüleme yetkisi
            else
            {
                MessageBox.Show("Yetkiniz bulunmuyor lütfen yöneticiyle iletişime geçiniz...");
                return;
            }//yetkisiz
            k.Show();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            this.Close();
            OdemeTur k = new OdemeTur();
            k.ad = ad;
            k.yetki = yetki;
            k.yetki_id = yetki_id;
            if (yetki_id == 1)
            {

            }//tüm yetkiler
            else if (yetki_id == 2)
            {
                k.btn_guncelle.Enabled = false;
                k.ts_guncelle.Enabled = false;
            }//sadece ekle-sil
            else if (yetki_id == 3)
            {
                k.btn_sil.Enabled = false;
                k.ts_sil.Enabled = false;
            }//ekle-güncelle
            else if (yetki_id == 4)
            {
                k.btn_ekle.Enabled = false;
                k.ts_ekle.Enabled = false;
            }//sil-güncelle
            else if (yetki_id == 5)
            {
                k.btn_sil.Enabled = false;
                k.btn_guncelle.Enabled = false;
                k.ts_sil.Enabled = false;
                k.ts_guncelle.Enabled = false;
            }//ekle
            else if (yetki_id == 6)
            {
                k.btn_ekle.Enabled = false;
                k.btn_guncelle.Enabled = false;
                k.ts_ekle.Enabled = false;
                k.ts_guncelle.Enabled = false;
            }//sil
            else if (yetki_id == 7)
            {
                k.btn_ekle.Enabled = false;
                k.btn_sil.Enabled = false;
                k.ts_ekle.Enabled = false;
                k.ts_sil.Enabled = false;
            }//güncelle
            else if (yetki_id == 8)
            {
                k.btn_ekle.Enabled = false;
                k.btn_sil.Enabled = false;
                k.btn_guncelle.Enabled = false;
                k.ts_ekle.Enabled = false;
                k.ts_sil.Enabled = false;
                k.ts_guncelle.Enabled = false;
            }//sadece görüntüleme yetkisi
            else
            {
                MessageBox.Show("Yetkiniz bulunmuyor lütfen yöneticiyle iletişime geçiniz...");
                return;
            }//yetkisiz
            k.Show();
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            this.Close();
            hasilat k = new hasilat();
            k.ad = ad;
            k.yetki = yetki;
            k.yetki_id = yetki_id;
            if (yetki_id == 1)
            {

            }//tüm yetkiler
            else if (yetki_id == 2)
            {
                k.btn_guncelle.Enabled = false;
                k.ts_guncelle.Enabled = false;
            }//sadece ekle-sil
            else if (yetki_id == 3)
            {
                k.btn_sil.Enabled = false;
                k.ts_sil.Enabled = false;
            }//ekle-güncelle
            else if (yetki_id == 4)
            {
                k.btn_ekle.Enabled = false;
                k.ts_ekle.Enabled = false;
            }//sil-güncelle
            else if (yetki_id == 5)
            {
                k.btn_sil.Enabled = false;
                k.btn_guncelle.Enabled = false;
                k.ts_sil.Enabled = false;
                k.ts_guncelle.Enabled = false;
            }//ekle
            else if (yetki_id == 6)
            {
                k.btn_ekle.Enabled = false;
                k.btn_guncelle.Enabled = false;
                k.ts_ekle.Enabled = false;
                k.ts_guncelle.Enabled = false;
            }//sil
            else if (yetki_id == 7)
            {
                k.btn_ekle.Enabled = false;
                k.btn_sil.Enabled = false;
                k.ts_ekle.Enabled = false;
                k.ts_sil.Enabled = false;
            }//güncelle
            else if (yetki_id == 8)
            {
                k.btn_ekle.Enabled = false;
                k.btn_sil.Enabled = false;
                k.btn_guncelle.Enabled = false;
                k.ts_ekle.Enabled = false;
                k.ts_sil.Enabled = false;
                k.ts_guncelle.Enabled = false;
            }//sadece görüntüleme yetkisi
            else
            {
                MessageBox.Show("Yetkiniz bulunmuyor lütfen yöneticiyle iletişime geçiniz...");
                return;
            }//yetkisiz
            k.Show();
        }

        private void toolStripButton13_Click(object sender, EventArgs e)
        {
            this.Close();
            settings set = new settings();
            set.personel_id = personel_id;
            set.ad = ad;
            set.yetki_id = yetki_id;
            set.yetki = yetki;
            if (yetki_id == 1)
            {
                set.btn_tarife.Enabled = true;
            }
            else
            {
                set.btn_tarife.Enabled = false;
            }
            set.Show();
        }

        bool move;
        int mouse_x;
        int mouse_y;

        private void arayuz_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void arayuz_MouseMove(object sender, MouseEventArgs e)
        {

            if (move == true)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void arayuz_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
      


        private void harf_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
            && !char.IsSeparator(e.KeyChar);
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }
        private void txt_sadece_sayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void btn_ekle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                btn_ekle.PerformClick();
            }
        }

        private void btn_sil_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F6)
            {
                btn_sil.PerformClick();
            }
        }

        private void btn_guncelle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F7)
            {
                btn_guncelle.PerformClick();
            }
        }

        private void btn_temizle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F8)
            {
                btn_temizle.PerformClick();
            }
        }
        private void Sofor_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ayarlar.Default.tarife) || Convert.ToInt32(ayarlar.Default.tarife) == 0)
            {
                ayarlar.Default.tarife = "20"; // Tarife boşsa 20 olarak ata
                ayarlar.Default.Save();
                MessageBox.Show("Tarifeniz olmadığından 20 TL olarak ayarlanmıştır...");
            }
            FormManager.AddForm(this);
            string tarife = ayarlar.Default.tarife;
            lbl_tarife.Text = "Kilometre başına standart tarife ücreti " + tarife + " TL'dir.";

            cbx_musteri.ValueMember = "musteri_id";
            cbx_musteri.DisplayMember = "ad";
            cbx_musteri.DataSource = vt.Select("select musteri_id, ad from tbl_musteri order by ad");
            cbx_taksi.ValueMember = "taksi_id";
            cbx_taksi.DisplayMember = "plaka";
            cbx_taksi.DataSource = vt.Select("select taksi_id, plaka from tbl_taksi order by plaka");
            cbx_tur.ValueMember = "odemeTur_id";
            cbx_tur.DisplayMember = "odemeTur";
            cbx_tur.DataSource = vt.Select("select odemeTur_id, odemeTur from tbl_odemeTur");
            RezGridiDoldur();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (tx_km.Text.Length < 1 || tx_km.Text.Length > 7)
            {
                MessageBox.Show("KM En Az 1 Karakter En Fazla 7 Karakter olabilir...");
                return;
            }
            if (string.IsNullOrWhiteSpace(tx_km.Text) || tx_km.Text.Trim().Length != tx_km.Text.Length)
            {
                MessageBox.Show("KM Boş Bırakılamaz ve İçinde ya da Sonunda Boşluk Bulunamaz...");
                return;
            }
            if (dtp_tarih.Value == DateTime.MinValue)
            {
                MessageBox.Show("Rezervasyon Tarihi Boş Bırakılamaz. Lütfen Rezervasyon Tarihini seçiniz!");
                return;
            }
            string sayigirdi = tx_km.Text.Trim();
            foreach (char c in sayigirdi)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("KM'ye sadece rakam girebilirsiniz!");
                    return;
                }
            }
            if (cbx_musteri.SelectedValue == null || cbx_musteri.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Müşteri boş bırakılamaz. Lütfen Müşteri seçiniz!");
                return;
            }
            if (cbx_taksi.SelectedValue == null || cbx_taksi.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Taksi boş bırakılamaz. Lütfen Taksi seçiniz!");
                return;
            }
            if (cbx_tur.SelectedValue == null || cbx_tur.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Ödeme Türü boş bırakılamaz. Lütfen Ödeme Türü seçiniz!");
                return;
            }
            int tarife = Convert.ToInt32(ayarlar.Default.tarife);
            int km = Convert.ToInt32(tx_km.Text);
            int toplamTutar = km * tarife;
            vt.Insert(@"insert into tbl_rezervasyon(rezTarih, musteri_id, taksi_id)
            values('" + dtp_tarih.Value.ToString("yyyy-MM-dd") + "','" + cbx_musteri.SelectedValue + "','" + cbx_taksi.SelectedValue + "')");
            vt.Insert(@"insert into tbl_odeme(gidilenKm,topTutar, odemeTur_id, rez_id)
                        values('" + tx_km.Text + "','" + toplamTutar + "','" + cbx_tur.SelectedValue + "',(SELECT MAX(rez_id) FROM tbl_odeme))");
            RezGridiDoldur();
            MessageBox.Show("Rezervasyon ve Ödeme Bilgisi Eklendi...");
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {

            if (dgv_taksi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen Silinecek Rezervasyon Seçiniz...");

                return;
            }

            DialogResult secenek = MessageBox.Show("Bu Rezervasyon Bilgilerini Silmek Rezervasyona Ait Ödeme Bilgilerini'de Silecektir Devam Etmek İstiyor musunuz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {


                vt.UpdateDelete("delete from tbl_odeme where rez_id=" + dgv_taksi.SelectedRows[0].Cells["rez_id"].Value);
                vt.UpdateDelete("delete from tbl_rezervasyon where rez_id=" + dgv_taksi.SelectedRows[0].Cells["rez_id"].Value);


                RezGridiDoldur();
                MessageBox.Show("Rezervasyon ve Ödemesi Silindi");
            }
            else
                return;
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (dgv_taksi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen Güncellenecek Rezervasyon Seçiniz...");

                return;
            }
            if (tx_km.Text.Length < 1 || tx_km.Text.Length > 7)
            {
                MessageBox.Show("KM En Az 1 Karakter En Fazla 7 Karakter olabilir...");
                return;
            }
            string sayigirdi = tx_km.Text.Trim();
            foreach (char c in sayigirdi)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("KM'ye sadece rakam girebilirsiniz!");
                    return;
                }
            }
            if (string.IsNullOrWhiteSpace(tx_km.Text) || tx_km.Text.Trim().Length != tx_km.Text.Length)
            {
                MessageBox.Show("KM Boş Bırakılamaz ve İçinde ya da Sonunda Boşluk Bulunamaz...");
                return;
            }
            if (dtp_tarih.Value == DateTime.MinValue)
            {
                MessageBox.Show("Rezervasyon Tarihi Boş Bırakılamaz. Lütfen Rezervasyon Tarihini seçiniz!");
                return;
            }

            if (cbx_musteri.SelectedValue == null || cbx_musteri.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Müşteri boş bırakılamaz. Lütfen Müşteri seçiniz!");
                return;
            }
            if (cbx_taksi.SelectedValue == null || cbx_taksi.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Taksi boş bırakılamaz. Lütfen Taksi seçiniz!");
                return;
            }
            if (cbx_tur.SelectedValue == null || cbx_tur.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Ödeme Türü boş bırakılamaz. Lütfen Ödeme Türü seçiniz!");
                return;
            }

            DialogResult secenek = MessageBox.Show("Bu Rezervasyon Bilgilerini Güncellemek O Rezervasyona Ait Ödeme Kayıtlarını da Güncelleyebilir Devam Etmek İstiyor musunuz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                vt.UpdateDelete(@"update tbl_rezervasyon
                set 
	                rezTarih='" + dtp_tarih.Value.ToString("yyyy-MM-dd") + @"',
                    taksi_id='" + cbx_taksi.SelectedValue + @"',
                    musteri_id='" + cbx_musteri.SelectedValue + @"'
	                where rez_id=" + dgv_taksi.SelectedRows[0].Cells["rez_id"].Value);
                vt.UpdateDelete(@"update tbl_odeme
                set 
	                gidilenKm='" + tx_km.Text + @"',
                    topTutar='" + tx_topTutar.Text + @"',
                    odemeTur_id='" + cbx_tur.SelectedValue + @"'
	                where rez_id=" + dgv_taksi.SelectedRows[0].Cells["rez_id"].Value);
                RezGridiDoldur();
                MessageBox.Show("Rezervasyon ve Ödeme Bilgisi Güncellendi");
            }
            else
            {
                return;
            }
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            tx_km.Text = "";
            tx_topTutar.Text = "";
            dtp_tarih.Text = "";
            cbx_taksi.SelectedValue = 0;
            cbx_tur.SelectedValue = 0;
            cbx_musteri.SelectedValue = 0;
            if (dgv_taksi.SelectedRows.Count != 0)
                dgv_taksi.SelectedRows[0].Selected = false;
        }

        private void dgv_taksi_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_taksi.SelectedRows.Count == 0)
            {
                return;
            }
            tx_topTutar.Text = dgv_taksi.SelectedRows[0].Cells["topTutar"].Value.ToString();
            tx_km.Text = dgv_taksi.SelectedRows[0].Cells["gidilenKm"].Value.ToString();
            cbx_musteri.SelectedValue = dgv_taksi.SelectedRows[0].Cells["musteri_id"].Value.ToString();
            cbx_taksi.SelectedValue = dgv_taksi.SelectedRows[0].Cells["taksi_id"].Value.ToString();
            cbx_tur.SelectedValue = dgv_taksi.SelectedRows[0].Cells["odemeTur_id"].Value.ToString();
            dtp_tarih.Value = DateTime.Parse(dgv_taksi.SelectedRows[0].Cells["RezTarih"].Value.ToString());

        }

        private void tx_km_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tx_km.Text)) // Text kutusu boş değilse
            {
                int km;
                if (int.TryParse(tx_km.Text, out km) && km > 0) // Geçerli bir tamsayıya dönüştürülebilir ve 0'dan büyükse
                {
                    int tarife = Convert.ToInt32(ayarlar.Default.tarife);
                    int toplamTutar = km * tarife;
                    tx_topTutar.Text = toplamTutar.ToString();
                }
                else
                {
                    return;
                }
            }
            else
            {
                tx_topTutar.Text = "0";
            }
        }

        private void Rezervasyon_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormManager.RemoveForm(this);
        }

        private void RezGridiDoldur()
        {
            dgv_taksi.DataSource = vt.Select(@"SELECT t.rez_id, t.rezTarih as RezTarih, t.musteri_id, t.taksi_id, d.ad as MusteriAdı,o.gidilenKm as GidilenKM, o.topTutar as TopTutar,ot.odemeTur as OdemeTuru, tt.plaka as TaksiPlaka, ot.odemeTur_id
                FROM  tbl_rezervasyon t
                    JOIN tbl_musteri d ON d.musteri_id = t.musteri_id
                    JOIN tbl_taksi tt ON tt.taksi_id = t.taksi_id
                    JOIN tbl_odeme o on o.rez_id=t.rez_id
                    JOIN tbl_odemeTur ot on ot.odemeTur_id=o.odemeTur_id
                ORDER BY d.ad");
            dgv_taksi.Columns["rez_id"].Visible = false;
            dgv_taksi.Columns["musteri_id"].Visible = false;
            dgv_taksi.Columns["taksi_id"].Visible = false;
            dgv_taksi.Columns["odemeTur_id"].Visible = false;
        }


    }
}
