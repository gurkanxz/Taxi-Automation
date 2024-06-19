﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLLislemleri;
using static TaksiDurakOtomasyon.Anasayfa;

namespace TaksiDurakOtomasyon
{

    public partial class Personel : Form
    {
        DLLislemleri.DigerIslemler dg = new DLLislemleri.DigerIslemler();
        DLLislemleri.Veritabani vt = new DLLislemleri.Veritabani(ayarlar.Default.SunucuAdi, ayarlar.Default.VeritabaniAdi, ayarlar.Default.UzakSunucuBaglantisi, ayarlar.Default.UserID, ayarlar.Default.Password);
        public Personel()
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
            TaksiTur k = new TaksiTur();
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

        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
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
        private void Personel_Load(object sender, EventArgs e)
        {
            FormManager.AddForm(this);
            cbx_tur.ValueMember = "personelTur_id";
            cbx_tur.DisplayMember = "personelTur";
            cbx_tur.DataSource = vt.Select("select personelTur_id, personelTur from tbl_personelTur");

            cbx_durak.ValueMember = "durak_id";
            cbx_durak.DisplayMember = "ad";
            cbx_durak.DataSource = vt.Select("select ad, durak_id from tbl_durak");

            PersonelGridiDoldur();
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
            string sayigirdi2 = tx_tc.Text.Trim();
            foreach (char ccc in sayigirdi2)
            {
                if (!char.IsDigit(ccc))
                {
                    MessageBox.Show("TC No'da sadece rakam girebilirsiniz!");
                    return;
                }
            }
            if (tx_tel.Text.Length != 11)
            {
                MessageBox.Show("Telefon Numarası başında'0' dahil 11 Karakter olmalı...");
                return;
            }
            if (tx_tc.Text.Length != 11)
            {
                MessageBox.Show("TC Numarası 11 Karakter olmalı...");
                return;
            }
            if (string.IsNullOrWhiteSpace(tx_tel.Text) || tx_tel.Text.Trim().Length != tx_tel.Text.Length)
            {
                MessageBox.Show("Telefon Numarası Boş Bırakılamaz ve İçinde ya da Sonunda Boşluk Bulunamaz...");
                return;
            }
            if (string.IsNullOrWhiteSpace(tx_tc.Text) || tx_tc.Text.Trim().Length != tx_tc.Text.Length)
            {
                MessageBox.Show("TC Numarası Boş Bırakılamaz ve İçinde ya da Sonunda Boşluk Bulunamaz...");
                return;
            }
            if (string.IsNullOrWhiteSpace(tx_sifre.Text) || tx_sifre.Text.Trim().Length != tx_sifre.Text.Length)
            {
                MessageBox.Show("Şifre Boş Bırakılamaz ve İçinde ya da Sonunda Boşluk Bulunamaz...");
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
            if (IsValidEmail(tx_mail.Text))
            {
                tx_mail.Text = tx_mail.Text.ToLower();
            }
            else
            {
                MessageBox.Show("Geçersiz email adresi!");
                return;
            }
            DataTable dt = vt.Select(@"select tc, mail, tel from tbl_personel
                            where  tc='" + tx_tc.Text + "' OR tel='" + tx_tel.Text + "' OR mail='" + tx_mail.Text + "' ");
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["tc"].ToString() == tx_tc.Text.ToLower())
                {
                    MessageBox.Show("Bu TC numarası ile önceden kayıt edilmiş bir personel bulunuyor!");

                }
                else if (dt.Rows[0]["mail"].ToString() == tx_mail.Text.ToLower())
                {
                    MessageBox.Show("Bu  mail ile önceden kayıt edilmiş bir personel bulunuyor!");

                }
                else if (dt.Rows[0]["tel"].ToString() == tx_tel.Text)
                {
                    MessageBox.Show("Bu telefon numarası ile önceden kayıt edilmiş bir durak bulunuyor!");

                }
                return;
            }
            if (cbx_durak.SelectedValue == null || cbx_durak.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Durak boş bırakılamaz. Lütfen Durak seçiniz!");
                return;
            }
            if (cbx_tur.SelectedValue == null || cbx_tur.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Personel Türü boş bırakılamaz. Lütfen Durak seçiniz!");
                return;
            }
            vt.Insert(@"insert into tbl_personel(ad, soyAd, tc, mail, sifre, tel, durak_id, personelTur_id)
                        values('" + tx_ad.Text.ToUpper() + "','" + tx_soyAd.Text.ToUpper() + "','" + tx_tc.Text + "','" + tx_mail.Text + "','" + dg.MD5Sifrele(tx_sifre.Text) + "','" + tx_tel.Text + "','" + cbx_durak.SelectedValue + "','"+cbx_tur.SelectedValue+"')");
            PersonelGridiDoldur();
            MessageBox.Show("Personel Eklendi");
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (dgv_taksi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen Silinecek Personel Seçiniz...");

                return;
            }

            DialogResult secenek = MessageBox.Show("Bu Personel Bilgilerini Silmek Personele Ait Kayıtları Silebilir Devam Etmek İstiyor musunuz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {


                vt.UpdateDelete("delete from tbl_personel where personel_id=" + dgv_taksi.SelectedRows[0].Cells["personel_id"].Value);


                PersonelGridiDoldur();
                MessageBox.Show("Personel Silindi");
            }
            else
                return;
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (dgv_taksi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen Güncellenecek Personel Seçiniz...");

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
            string sayigirdi2 = tx_tc.Text.Trim();
            foreach (char ccc in sayigirdi2)
            {
                if (!char.IsDigit(ccc))
                {
                    MessageBox.Show("TC No'da sadece rakam girebilirsiniz!");
                    return;
                }
            }
            if (tx_tel.Text.Length != 11)
            {
                MessageBox.Show("Telefon Numarası başında'0' dahil 11 Karakter olmalı...");
                return;
            }
            if (tx_tc.Text.Length != 11)
            {
                MessageBox.Show("TC Numarası 11 Karakter olmalı...");
                return;
            }
            if (string.IsNullOrWhiteSpace(tx_tel.Text) || tx_tel.Text.Trim().Length != tx_tel.Text.Length)
            {
                MessageBox.Show("Telefon Numarası Boş Bırakılamaz ve İçinde ya da Sonunda Boşluk Bulunamaz...");
                return;
            }
            if (string.IsNullOrWhiteSpace(tx_tc.Text) || tx_tc.Text.Trim().Length != tx_tc.Text.Length)
            {
                MessageBox.Show("TC Numarası Boş Bırakılamaz ve İçinde ya da Sonunda Boşluk Bulunamaz...");
                return;
            }
            if (string.IsNullOrWhiteSpace(tx_sifre.Text) || tx_sifre.Text.Trim().Length != tx_sifre.Text.Length)
            {
                MessageBox.Show("Şifre Boş Bırakılamaz ve İçinde ya da Sonunda Boşluk Bulunamaz...");
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
            if (IsValidEmail(tx_mail.Text))
            {
                tx_mail.Text = tx_mail.Text.ToLower();
            }
            else
            {
                MessageBox.Show("Geçersiz email adresi!");
                return;
            }
            DataTable dt = vt.Select(@"select tc from tbl_personel
                            where tc='" + tx_tc.Text.ToUpper() + "'  AND personel_id <> " + dgv_taksi.SelectedRows[0].Cells["personel_id"].Value);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Bu TC Numarası Önceden Girilmiş...");
                return;
            }
            DataTable dtt = vt.Select(@"select mail from tbl_personel
                            where mail='" + tx_mail.Text.ToUpper() + "'  AND personel_id <> " + dgv_taksi.SelectedRows[0].Cells["personel_id"].Value);
            if (dtt.Rows.Count > 0)
            {
                MessageBox.Show("Bu Mail Önceden Girilmiş...");
                return;
            }
            DataTable dttt = vt.Select(@"select tel from tbl_personel
                            where tel='" + tx_tel.Text.ToUpper() + "'  AND personel_id <> " + dgv_taksi.SelectedRows[0].Cells["personel_id"].Value);
            if (dttt.Rows.Count > 0)
            {
                MessageBox.Show("Bu Telefon Numarası Önceden Girilmiş...");
                return;
            }
            if (cbx_durak.SelectedValue == null || cbx_durak.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Durak boş bırakılamaz. Lütfen Durak seçiniz!");
                return;
            }
            if (cbx_tur.SelectedValue == null || cbx_tur.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Personel Türü boş bırakılamaz. Lütfen Durak seçiniz!");
                return;
            }
            DialogResult secenek = MessageBox.Show("Bu Personel Bilgilerini Güncellemek O Personele Ait Personel Kayıtlarını da Güncelleyebilir Devam Etmek İstiyor musunuz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                vt.UpdateDelete(@"update tbl_personel
                set 
	                ad='" + tx_ad.Text + @"',
                    soyAd='" + tx_soyAd.Text + @"',
                    tc='" + tx_tc.Text + @"',
                    mail='" + tx_mail.Text + @"',
                    sifre='" + tx_sifre.Text + @"',
                    tel='" + tx_tel.Text + @"',
                    personelTur_id='" + cbx_tur.SelectedValue + @"',
                    durak_id='" + cbx_durak.SelectedValue + @"'
	                where personel_id=" + dgv_taksi.SelectedRows[0].Cells["personel_id"].Value);
                PersonelGridiDoldur();
                MessageBox.Show("Personel Güncellendi");
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
            tx_mail.Text = "";
            tx_sifre.Text = "";
            tx_tel.Text = "";
            tx_tc.Text = "";
            cbx_tur.SelectedValue = 0;
            cbx_durak.SelectedValue = 0;
            if (dgv_taksi.SelectedRows.Count != 0)
                dgv_taksi.SelectedRows[0].Selected = false;
        }

        private void dgv_taksi_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_taksi.SelectedRows.Count == 0)
            {
                return;
            }
            tx_ad.Text = dgv_taksi.SelectedRows[0].Cells["ad"].Value.ToString();
            tx_soyAd.Text = dgv_taksi.SelectedRows[0].Cells["soyAd"].Value.ToString();
            tx_mail.Text = dgv_taksi.SelectedRows[0].Cells["Eposta"].Value.ToString();
            tx_tel.Text = dgv_taksi.SelectedRows[0].Cells["tel"].Value.ToString();
            tx_tc.Text = dgv_taksi.SelectedRows[0].Cells["TcNo"].Value.ToString();
            cbx_tur.SelectedValue = dgv_taksi.SelectedRows[0].Cells["personelTur_id"].Value.ToString();
            cbx_durak.SelectedValue = dgv_taksi.SelectedRows[0].Cells["durak_id"].Value.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Personel_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormManager.RemoveForm(this);
        }

        private void PersonelGridiDoldur()
        {
            dgv_taksi.DataSource = vt.Select(@"SELECT d.ad AS DurakAdı, t.personel_id, t.ad AS Ad, t.soyAd AS SoyAd,t.tc as TcNo,t.mail AS Eposta, t.sifre AS Şifre, t.tel AS Tel,  tt.personelTur AS PerTürü, t.durak_id, t.personelTur_id
                FROM  tbl_personel t
                    JOIN tbl_durak d ON d.durak_id = t.durak_id
                    JOIN tbl_personelTur tt ON tt.personelTur_id = t.personelTur_id
                    ORDER BY d.ad");
            dgv_taksi.Columns["durak_id"].Visible = false;
            dgv_taksi.Columns["personel_id"].Visible = false;
            dgv_taksi.Columns["personelTur_id"].Visible = false;


        }

    }
}
