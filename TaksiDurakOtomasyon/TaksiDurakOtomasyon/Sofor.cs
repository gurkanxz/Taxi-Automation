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

    public partial class Sofor : Form
    {
        DLLislemleri.Veritabani vt = new DLLislemleri.Veritabani(ayarlar.Default.SunucuAdi, ayarlar.Default.VeritabaniAdi, ayarlar.Default.UzakSunucuBaglantisi, ayarlar.Default.UserID, ayarlar.Default.Password);
        public Sofor()
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

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Close();
            Rezervasyon k = new Rezervasyon();
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
        private void Sofor_Load(object sender, EventArgs e)
        {
            FormManager.AddForm(this);
            SoforGridiDoldur();
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
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (tx_ad.Text.Length < 3 || tx_ad.Text.Length > 25)
            {
                MessageBox.Show("Ad En Az 3 Karakter En Fazla 25 Karakter olabilir...");
                return;
            }
            if (tx_soyAd.Text.Length < 3 || tx_soyAd.Text.Length > 25)
            {
                MessageBox.Show("Soy Ad En Az 3 Karakter En Fazla 25 Karakter olabilir...");
                return;
            }
            string girdi = tx_ad.Text.Trim();
            foreach (char c in girdi)
            {
                if (!char.IsLetter(c))
                {
                    MessageBox.Show("Ad'a sadece harf girebilirsiniz!");
                    return;
                }
            }
            string girdi1 = tx_soyAd.Text.Trim();
            foreach (char cc in girdi1)
            {
                if (!char.IsLetter(cc))
                {
                    MessageBox.Show("SoyAd'a sadece harf girebilirsiniz!");
                    return;
                }
            }
            string sayigirdi = tx_tel.Text.Trim();
            foreach (char c in sayigirdi)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("Telefon'da sadece rakam girebilirsiniz!");
                    return;
                }
            }
            string sayigirdi2 = tx_ehliyet.Text.Trim();
            foreach (char ccc in sayigirdi2)
            {
                if (!char.IsDigit(ccc))
                {
                    MessageBox.Show("Ehliyet No'da sadece rakam girebilirsiniz!");
                    return;
                }
            }
            if (tx_tel.Text.Length != 11)
            {
                MessageBox.Show("Telefon Numarası başında'0' dahil 11 Karakter olmalı...");
                return;
            }
            if (tx_ehliyet.Text.Length != 6)
            {
                MessageBox.Show("Ehliyet Numarası 6 Karakter olmalı...");
                return;
            }
            if (string.IsNullOrWhiteSpace(tx_tel.Text) || tx_tel.Text.Trim().Length != tx_tel.Text.Length)
            {
                MessageBox.Show("Telefon Numarası Boş Bırakılamaz ve İçinde ya da Sonunda Boşluk Bulunamaz...");
                return;
            }
            if (string.IsNullOrWhiteSpace(tx_ehliyet.Text) || tx_ehliyet.Text.Trim().Length != tx_ehliyet.Text.Length)
            {
                MessageBox.Show("Ehliyet Numarası Boş Bırakılamaz ve İçinde ya da Sonunda Boşluk Bulunamaz...");
                return;
            }
            if (string.IsNullOrWhiteSpace(tx_ad.Text) || tx_ad.Text.Trim().Length != tx_ad.Text.Length)
            {
                MessageBox.Show("Ad Boş Bırakılamaz ve İçinde ya da Sonunda Boşluk Bulunamaz...");
                return;
            }
            if (string.IsNullOrWhiteSpace(tx_soyAd.Text) || tx_soyAd.Text.Trim().Length != tx_soyAd.Text.Length)
            {
                MessageBox.Show("SoyAd Boş Bırakılamaz ve İçinde ya da Sonunda Boşluk Bulunamaz...");
                return;
            }

            DataTable dt = vt.Select(@"select ad, soyad, tel, ehliyetNo from tbl_sofor
                            where  ehliyetNo='" + tx_ehliyet.Text + "' OR tel='" + tx_tel.Text + "' ");
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["ehliyetNo"].ToString() == tx_ehliyet.Text.ToLower())
                {
                    MessageBox.Show("Bu Ehliyet numarası ile önceden kayıt edilmiş bir personel bulunuyor!");

                }
                else if (dt.Rows[0]["tel"].ToString() == tx_tel.Text)
                {
                    MessageBox.Show("Bu telefon numarası ile önceden kayıt edilmiş bir durak bulunuyor!");

                }
                return;
            }
            vt.Insert(@"insert into tbl_sofor(ad, soyAd, ehliyetNo, tel)
                        values('" + tx_ad.Text.ToUpper() + "','" + tx_soyAd.Text.ToUpper() + "','" + tx_ehliyet.Text + "','" + tx_tel.Text + "')");
            SoforGridiDoldur();
            MessageBox.Show("Şoför Eklendi");
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (dgv_durak.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen Silinecek Şoför Seçiniz...");

                return;
            }

            DialogResult secenek = MessageBox.Show("Bu Şoför Bilgilerini Silmek Şoföre Ait Hasılat Kayıtlarını Silecektir Devam Etmek İstiyor musunuz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {


              
                vt.UpdateDelete("delete from tbl_hasilat where sofor_id=" + dgv_durak.SelectedRows[0].Cells["sofor_id"].Value);
                vt.UpdateDelete("delete from tbl_sofor where sofor_id=" + dgv_durak.SelectedRows[0].Cells["sofor_id"].Value);

                SoforGridiDoldur();
                MessageBox.Show("Şoför Silindi");
            }
            else
                return;
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (dgv_durak.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen Güncellenecek Şoför Seçiniz...");

                return;
            }
            if (tx_ad.Text.Length < 3 || tx_ad.Text.Length > 25)
            {
                MessageBox.Show("Ad En Az 3 Karakter En Fazla 25 Karakter olabilir...");
                return;
            }
            if (tx_soyAd.Text.Length < 3 || tx_soyAd.Text.Length > 25)
            {
                MessageBox.Show("Soy Ad En Az 3 Karakter En Fazla 25 Karakter olabilir...");
                return;
            }
            string girdi = tx_ad.Text.Trim();
            foreach (char c in girdi)
            {
                if (!char.IsLetter(c))
                {
                    MessageBox.Show("Ad'a sadece harf girebilirsiniz!");
                    return;
                }
            }
            string girdi1 = tx_soyAd.Text.Trim();
            foreach (char cc in girdi1)
            {
                if (!char.IsLetter(cc))
                {
                    MessageBox.Show("SoyAd'a sadece harf girebilirsiniz!");
                    return;
                }
            }
            string sayigirdi = tx_tel.Text.Trim();
            foreach (char c in sayigirdi)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("Telefon'da sadece rakam girebilirsiniz!");
                    return;
                }
            }
            string sayigirdi2 = tx_ehliyet.Text.Trim();
            foreach (char ccc in sayigirdi2)
            {
                if (!char.IsDigit(ccc))
                {
                    MessageBox.Show("Ehliyet No'da sadece rakam girebilirsiniz!");
                    return;
                }
            }
            if (tx_tel.Text.Length != 11)
            {
                MessageBox.Show("Telefon Numarası başında'0' dahil 11 Karakter olmalı...");
                return;
            }
            if (tx_ehliyet.Text.Length != 6)
            {
                MessageBox.Show("Ehliyet Numarası 6 Karakter olmalı...");
                return;
            }
            if (string.IsNullOrWhiteSpace(tx_tel.Text) || tx_tel.Text.Trim().Length != tx_tel.Text.Length)
            {
                MessageBox.Show("Telefon Numarası Boş Bırakılamaz ve İçinde ya da Sonunda Boşluk Bulunamaz...");
                return;
            }
            if (string.IsNullOrWhiteSpace(tx_ehliyet.Text) || tx_ehliyet.Text.Trim().Length != tx_ehliyet.Text.Length)
            {
                MessageBox.Show("Ehliyet Numarası Boş Bırakılamaz ve İçinde ya da Sonunda Boşluk Bulunamaz...");
                return;
            }
            if (string.IsNullOrWhiteSpace(tx_ad.Text) || tx_ad.Text.Trim().Length != tx_ad.Text.Length)
            {
                MessageBox.Show("Ad Boş Bırakılamaz ve İçinde ya da Sonunda Boşluk Bulunamaz...");
                return;
            }
            if (string.IsNullOrWhiteSpace(tx_soyAd.Text) || tx_soyAd.Text.Trim().Length != tx_soyAd.Text.Length)
            {
                MessageBox.Show("SoyAd Boş Bırakılamaz ve İçinde ya da Sonunda Boşluk Bulunamaz...");
                return;
            }

            DataTable dttt = vt.Select(@"select tel from tbl_sofor
                            where tel='" + tx_tel.Text.ToUpper() + "'  AND sofor_id <> " + dgv_durak.SelectedRows[0].Cells["sofor_id"].Value);
            if (dttt.Rows.Count > 0)
            {
                MessageBox.Show("Bu Telefon Numarası Önceden Girilmiş...");
                return;
            }
            DataTable dtt = vt.Select(@"select ehliyetNo from tbl_sofor
                            where ehliyetNo='" + tx_ehliyet.Text.ToUpper() + "'  AND sofor_id <> " + dgv_durak.SelectedRows[0].Cells["sofor_id"].Value);
            if (dtt.Rows.Count > 0)
            {
                MessageBox.Show("Bu Ehliyet Numarası Önceden Girilmiş...");
                return;
            }
            DialogResult secenek = MessageBox.Show("Bu Şoför Bilgilerini Güncellemek O Şoföre Ait Kayıtları da Güncelleyebilir Devam Etmek İstiyor musunuz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                vt.UpdateDelete(@"update tbl_sofor
                set 
	                ad='" + tx_ad.Text + @"',
                    soyAd='" + tx_soyAd.Text + @"',
                    ehliyetNo='" + tx_ehliyet.Text + @"',
                    tel='" + tx_tel.Text + @"'
	                where sofor_id=" + dgv_durak.SelectedRows[0].Cells["sofor_id"].Value);
                SoforGridiDoldur();
                MessageBox.Show("Şoför Güncellendi");
            }
            else if (secenek == DialogResult.No)
            {
                return;
            }
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            tx_ad.Text = "";
            tx_soyAd.Text = "";
            tx_tel.Text = "";
            tx_ehliyet.Text = "";
            if (dgv_durak.SelectedRows.Count != 0)
                dgv_durak.SelectedRows[0].Selected = false;
        }

        private void dgv_durak_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_durak.SelectedRows.Count == 0)
            {
                return;
            }
            tx_ad.Text = dgv_durak.SelectedRows[0].Cells["ad"].Value.ToString();
            tx_soyAd.Text = dgv_durak.SelectedRows[0].Cells["soyAd"].Value.ToString();
            tx_tel.Text = dgv_durak.SelectedRows[0].Cells["tel"].Value.ToString();
            tx_ehliyet.Text = dgv_durak.SelectedRows[0].Cells["ehliyetNo"].Value.ToString();
        }

        private void Sofor_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormManager.RemoveForm(this);
        }

        private void SoforGridiDoldur()
        {
            dgv_durak.DataSource = vt.Select(@"select sofor_id, ad as Ad, soyAd as SoyAd , tel as Tel, ehliyetNo as EhliyetNo
            from tbl_sofor");
            dgv_durak.Columns["sofor_id"].Visible = false;


        }
    }
}
