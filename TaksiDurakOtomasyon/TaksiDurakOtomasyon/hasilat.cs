using System;
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

    public partial class hasilat : Form
    {
        DLLislemleri.Veritabani vt = new DLLislemleri.Veritabani(ayarlar.Default.SunucuAdi, ayarlar.Default.VeritabaniAdi, ayarlar.Default.UzakSunucuBaglantisi, ayarlar.Default.UserID, ayarlar.Default.Password);
        public hasilat()
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

        private void toolStripButton9_Click(object sender, EventArgs e)
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
            cbx_sofor.ValueMember = "sofor_id";
            cbx_sofor.DisplayMember = "ad";
            cbx_sofor.DataSource = vt.Select("select sofor_id, ad from tbl_sofor order by ad");
            cbx_taksi.ValueMember = "taksi_id";
            cbx_taksi.DisplayMember = "plaka";
            cbx_taksi.DataSource = vt.Select("select taksi_id, plaka from tbl_taksi order by plaka");
            HasilatGridiDoldur();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (tx_baslangic.Text.Length < 1 || tx_baslangic.Text.Length > 7)
            {
                MessageBox.Show("Başlangıç KM En Az 1 Karakter En Fazla 7 Karakter olabilir...");
                return;
            }
            if (tx_bitis.Text.Length < 1 || tx_bitis.Text.Length > 7)
            {
                MessageBox.Show("Bitiş KM En Az 1 Karakter En Fazla 7 Karakter olabilir...");
                return;
            }
            if (string.IsNullOrWhiteSpace(tx_baslangic.Text) || tx_baslangic.Text.Trim().Length != tx_baslangic.Text.Length)
            {
                MessageBox.Show("Başlangıç KM Boş Bırakılamaz ve İçinde ya da Sonunda Boşluk Bulunamaz...");
                return;
            }
            if (string.IsNullOrWhiteSpace(tx_bitis.Text) || tx_bitis.Text.Trim().Length != tx_bitis.Text.Length)
            {
                MessageBox.Show("Bitiş KM Boş Bırakılamaz ve İçinde ya da Sonunda Boşluk Bulunamaz...");
                return;
            }
            if (dtp_tarih.Value == DateTime.MinValue)
            {
                MessageBox.Show("Hasılat Tarihi Boş Bırakılamaz. Lütfen Hasılat Tarihini seçiniz!");
                return;
            }
            string sayigirdi = tx_baslangic.Text.Trim();
            foreach (char c in sayigirdi)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("Başlangıç KM'ye sadece rakam girebilirsiniz!");
                    return;
                }
            }
            string sayigirdi1 = tx_baslangic.Text.Trim();
            foreach (char cc in sayigirdi1)
            {
                if (!char.IsDigit(cc))
                {
                    MessageBox.Show("Bitiş KM'ye sadece rakam girebilirsiniz!");
                    return;
                }
            }
            DataTable dt = vt.Select(@"select hasilatTarih, sofor_id, taksi_id from tbl_hasilat
                            where  hasilatTarih='" + dtp_tarih.Value.ToString("yyyy-MM-dd") + "' and sofor_id='" + cbx_sofor.SelectedValue + "' and taksi_id='" + cbx_taksi.SelectedValue + "' ");
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Seçilen Tarih Bilgisinde Şoför ve Taksiye Ait Kayıt Zaten Var...");
                return;
            }
            if (cbx_sofor.SelectedValue == null || cbx_sofor.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Şoför boş bırakılamaz. Lütfen Şoför seçiniz!");
                return;
            }
            if (cbx_taksi.SelectedValue == null || cbx_taksi.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Taksi boş bırakılamaz. Lütfen Taksi seçiniz!");
                return;
            }
            int tarife = Convert.ToInt32(ayarlar.Default.tarife);
            int baskm = Convert.ToInt32(tx_baslangic.Text);
            int bitkm = Convert.ToInt32(tx_bitis.Text);
            if (baskm > bitkm)
            {

                MessageBox.Show("Başlangıç KM Bitiş KM 'den büyük olamaz!");
                return;
            }
            int kalan = bitkm - baskm;
            int toplamTutar = kalan * tarife;
            vt.Insert(@"insert into tbl_hasilat(baslangicKm, bitisKm, topHasilat, hasilatTarih, taksi_id, sofor_id)
            values('" + tx_baslangic.Text + "','" + tx_bitis.Text + "','" + toplamTutar + "','" + dtp_tarih.Value.ToString("yyyy-MM-dd") + "','" + cbx_taksi.SelectedValue + "','" + cbx_sofor.SelectedValue + "')");

            HasilatGridiDoldur();
            MessageBox.Show("Hasılat Bilgisi Eklendi...");
        }

        private void tx_baslangic_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tx_baslangic.Text) && !string.IsNullOrWhiteSpace(tx_bitis.Text)) // Her iki Text kutusu da boş değilse
            {
                int baskm, bitkm;
                if (int.TryParse(tx_baslangic.Text, out baskm) && int.TryParse(tx_bitis.Text, out bitkm) && baskm > 0 && bitkm > 0) // Geçerli tamsayılara dönüştürülebilir ve her ikisi de 0'dan büyükse
                {
                    int tarife = Convert.ToInt32(ayarlar.Default.tarife);
                    int kalan = bitkm - baskm;
                    int toplamTutar = kalan * tarife;
                    tx_toplam.Text = toplamTutar.ToString();
                }
                else
                {
                    tx_toplam.Text = "0";
                }
            }
            else
            {
                tx_toplam.Text = "0";
            }

        }

        private void tx_bitis_TextChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(tx_baslangic.Text) && !string.IsNullOrWhiteSpace(tx_bitis.Text)) // Her iki Text kutusu da boş değilse
            {
                int baskm, bitkm;
                if (int.TryParse(tx_baslangic.Text, out baskm) && int.TryParse(tx_bitis.Text, out bitkm) && baskm > 0 && bitkm > 0) // Geçerli tamsayılara dönüştürülebilir ve her ikisi de 0'dan büyükse
                {
                    int tarife = Convert.ToInt32(ayarlar.Default.tarife);
                    int kalan = bitkm - baskm;
                    int toplamTutar = kalan * tarife;
                    tx_toplam.Text = toplamTutar.ToString();
                }
                else
                {
                    tx_toplam.Text = "0";
                }
            }
            else
            {
                tx_toplam.Text = "0";
            }

        }

        private void btn_sil_Click(object sender, EventArgs e)
        {

            if (dgv_taksi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen Silinecek Hasılat Seçiniz...");

                return;
            }

            DialogResult secenek = MessageBox.Show("Bu Hasılat Bilgilerini Silmek Hasılata Ait Bilgileri Silebilir Devam Etmek İstiyor musunuz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                vt.UpdateDelete("delete from tbl_hasilat where hasilat_id=" + dgv_taksi.SelectedRows[0].Cells["hasilat_id"].Value);
                HasilatGridiDoldur();
                MessageBox.Show("Hasılat Silindi");
            }
            else
                return;
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (dgv_taksi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen Güncellenecek Hasılat Seçiniz...");

                return;
            }
            if (tx_baslangic.Text.Length < 1 || tx_baslangic.Text.Length > 7)
            {
                MessageBox.Show("Başlangıç KM En Az 1 Karakter En Fazla 7 Karakter olabilir...");
                return;
            }
            if (tx_bitis.Text.Length < 1 || tx_bitis.Text.Length > 7)
            {
                MessageBox.Show("Bitiş KM En Az 1 Karakter En Fazla 7 Karakter olabilir...");
                return;
            }
            if (string.IsNullOrWhiteSpace(tx_baslangic.Text) || tx_baslangic.Text.Trim().Length != tx_baslangic.Text.Length)
            {
                MessageBox.Show("Başlangıç KM Boş Bırakılamaz ve İçinde ya da Sonunda Boşluk Bulunamaz...");
                return;
            }
            if (string.IsNullOrWhiteSpace(tx_bitis.Text) || tx_bitis.Text.Trim().Length != tx_bitis.Text.Length)
            {
                MessageBox.Show("Bitiş KM Boş Bırakılamaz ve İçinde ya da Sonunda Boşluk Bulunamaz...");
                return;
            }
            if (dtp_tarih.Value == DateTime.MinValue)
            {
                MessageBox.Show("Hasılat Tarihi Boş Bırakılamaz. Lütfen Hasılat Tarihini seçiniz!");
                return;
            }
            string sayigirdi = tx_baslangic.Text.Trim();
            foreach (char c in sayigirdi)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("Başlangıç KM'ye sadece rakam girebilirsiniz!");
                    return;
                }
            }
            string sayigirdi1 = tx_baslangic.Text.Trim();
            foreach (char cc in sayigirdi1)
            {
                if (!char.IsDigit(cc))
                {
                    MessageBox.Show("Bitiş KM'ye sadece rakam girebilirsiniz!");
                    return;
                }
            }
            DataTable dt = vt.Select(@"select hasilat_id ,hasilatTarih, sofor_id, taksi_id from tbl_hasilat
                            where  hasilatTarih='" + dtp_tarih.Value.ToString("yyyy-MM-dd") + "' and sofor_id='" + cbx_sofor.SelectedValue + "' and taksi_id='" + cbx_taksi.SelectedValue + "' AND hasilat_id <> " + dgv_taksi.SelectedRows[0].Cells["hasilat_id"].Value);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Seçilen Tarih Bilgisinde Şoför ve Taksiye Ait Kayıt Zaten Var...");
                return;
            }
            if (cbx_sofor.SelectedValue == null || cbx_sofor.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Şoför boş bırakılamaz. Lütfen Şoför seçiniz!");
                return;
            }
            if (cbx_taksi.SelectedValue == null || cbx_taksi.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Taksi boş bırakılamaz. Lütfen Taksi seçiniz!");
                return;
            }
            int tarife = Convert.ToInt32(ayarlar.Default.tarife);
            int baskm = Convert.ToInt32(tx_baslangic.Text);
            int bitkm = Convert.ToInt32(tx_bitis.Text);
            if (baskm > bitkm)
            {

                MessageBox.Show("Başlangıç KM Bitiş KM 'den büyük olamaz!");
                return;
            }
            int kalan = bitkm - baskm;
            int toplamTutar = kalan * tarife;
            DialogResult secenek = MessageBox.Show("Bu Hasılat Bilgilerini Güncellemek O Hasılata Ait Kayıtları da Güncelleyebilir Devam Etmek İstiyor musunuz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                vt.UpdateDelete(@"update tbl_hasilat
                set 
                    baslangicKm='" + tx_baslangic.Text + @"',
                    bitisKm='" + tx_bitis.Text + @"',
                    topHasilat='" + toplamTutar + @"',
	                hasilatTarih='" + dtp_tarih.Value.ToString("yyyy-MM-dd") + @"',
                    taksi_id='" + cbx_taksi.SelectedValue + @"',
                    sofor_id='" + cbx_sofor.SelectedValue + @"'
	                where hasilat_id=" + dgv_taksi.SelectedRows[0].Cells["hasilat_id"].Value);
                HasilatGridiDoldur();
                MessageBox.Show("Hasılat Bilgisi Güncellendi");
            }
            else
            {
                return;
            }
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            tx_baslangic.Text = "";
            tx_bitis.Text = "";
            tx_toplam.Text = "";
            dtp_tarih.Text = "";
            cbx_taksi.SelectedValue = 0;
            cbx_sofor.SelectedValue = 0;
            if (dgv_taksi.SelectedRows.Count != 0)
                dgv_taksi.SelectedRows[0].Selected = false;
        }

        private void dgv_taksi_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_taksi.SelectedRows.Count == 0)
            {
                return;
            }
            tx_toplam.Text = dgv_taksi.SelectedRows[0].Cells["TopHasılat"].Value.ToString();
            tx_baslangic.Text = dgv_taksi.SelectedRows[0].Cells["BaşlangıçKm"].Value.ToString();
            tx_bitis.Text = dgv_taksi.SelectedRows[0].Cells["BitişKm"].Value.ToString();
            cbx_sofor.SelectedValue = dgv_taksi.SelectedRows[0].Cells["sofor_id"].Value.ToString();
            cbx_taksi.SelectedValue = dgv_taksi.SelectedRows[0].Cells["taksi_id"].Value.ToString();
            dtp_tarih.Value = DateTime.Parse(dgv_taksi.SelectedRows[0].Cells["HasılatTarih"].Value.ToString());
        }

        private void hasilat_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormManager.RemoveForm(this);
        }

        private void HasilatGridiDoldur()
        {
            dgv_taksi.DataSource = vt.Select(@"SELECT h.hasilat_id, h.baslangicKm as BaşlangıçKm,h.bitisKm as BitişKm,h.topHasilat as TopHasılat,h.hasilatTarih as HasılatTarih,h.taksi_id,h.sofor_id,t.plaka as Plaka,s.ad as ŞoförAd
                FROM tbl_hasilat h
                Join tbl_taksi t on h.taksi_id=t.taksi_id
                Join tbl_sofor s on s.sofor_id=h.sofor_id");
            dgv_taksi.Columns["hasilat_id"].Visible = false;
            dgv_taksi.Columns["taksi_id"].Visible = false;
            dgv_taksi.Columns["sofor_id"].Visible = false;

        }

    }
}
