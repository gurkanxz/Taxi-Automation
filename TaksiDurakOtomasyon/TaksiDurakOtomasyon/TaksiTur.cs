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

    public partial class TaksiTur : Form
    {
        DLLislemleri.Veritabani vt = new DLLislemleri.Veritabani(ayarlar.Default.SunucuAdi, ayarlar.Default.VeritabaniAdi, ayarlar.Default.UzakSunucuBaglantisi, ayarlar.Default.UserID, ayarlar.Default.Password);
        public TaksiTur()
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

        private void TaksiTur_Load(object sender, EventArgs e)
        {
            FormManager.AddForm(this);
            cbx_tur.ValueMember = "boyut_id";
            cbx_tur.DisplayMember = "boyut";
            cbx_tur.DataSource = vt.Select("select boyut_id, boyut from tbl_aracBoyut");
            TaksiTurGridiDoldur();
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
        private void TaksiTurGridiDoldur()
        {
            dgv_taksi.DataSource = vt.Select(@"SELECT t.taksiTur_id, t.taksiTur as TaksiTürü, t.boyut_id, d.boyut as AraçBoyutu
                FROM  tbl_taksiTur t
                    JOIN tbl_aracBoyut d ON d.boyut_id = t.boyut_id
                ORDER BY d.boyut");
            dgv_taksi.Columns["taksiTur_id"].Visible = false;
            dgv_taksi.Columns["boyut_id"].Visible = false;
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

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (tx_tur.Text.Length < 3 || tx_tur.Text.Length > 10)
            {
                MessageBox.Show("Taksi Türü En Az 3 Karakter En Fazla 10 Karakter olabilir...");
                return;
            }
            string girdi = tx_tur.Text.Trim();
            foreach (char c in girdi)
            {
                if (!char.IsLetter(c))
                {
                    MessageBox.Show("Taksi Türüne sadece harf girebilirsiniz!");
                    return;
                }
            }
            if (string.IsNullOrWhiteSpace(tx_tur.Text) || tx_tur.Text.Trim().Length != tx_tur.Text.Length)
            {
                MessageBox.Show("Taksi Türü Boş Bırakılamaz ve İçinde ya da Sonunda Boşluk Bulunamaz...");
                return;
            }

            DataTable dt = vt.Select(@"select taksiTur from tbl_taksiTur
                            where taksiTur='" + tx_tur.Text.ToUpper() + "'  ");
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Bu Taksi Türü Önceden Girilmiş...");
                return;
            }

            if (cbx_tur.SelectedValue == null || cbx_tur.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Araç Boyutu boş bırakılamaz. Lütfen Araç Boyutu seçiniz!");
                return;
            }


            vt.Insert(@"insert into tbl_taksiTur(taksiTur, boyut_id)
            values('" + tx_tur.Text.ToUpper() + "','" + cbx_tur.SelectedValue + "')");
            TaksiTurGridiDoldur();
            MessageBox.Show("Taksi Türü Bilgisi Eklendi");
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (dgv_taksi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen Silinecek Taksi Türü Seçiniz...");

                return;
            }

            DialogResult secenek = MessageBox.Show("Bu Taksi Türü Bilgilerini Silmek Taksi Türüne Ait Kayıtları Silebilir Devam Etmek İstiyor musunuz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {


                vt.UpdateDelete("DELETE t1 FROM tbl_odeme t1 INNER JOIN tbl_rezervasyon t2 ON t1.rez_id = t2.rez_id INNER JOIN tbl_taksi t3 ON t2.taksi_id=t3.taksi_id  WHERE t3.taksiTur_id =" + dgv_taksi.SelectedRows[0].Cells["taksiTur_id"].Value);
                vt.UpdateDelete("DELETE t1 FROM tbl_rezervasyon t1 INNER JOIN tbl_taksi t2 ON t1.taksi_id = t2.taksi_id WHERE t2.taksiTur_id =" + dgv_taksi.SelectedRows[0].Cells["taksiTur_id"].Value);
                vt.UpdateDelete("DELETE t1 FROM tbl_hasilat t1 INNER JOIN tbl_taksi t2 ON t1.taksi_id = t2.taksi_id WHERE t2.taksiTur_id =" + dgv_taksi.SelectedRows[0].Cells["taksiTur_id"].Value);
                vt.UpdateDelete("delete from tbl_taksi where taksiTur_id=" + dgv_taksi.SelectedRows[0].Cells["taksiTur_id"].Value);
                vt.UpdateDelete("delete from tbl_taksiTur where taksiTur_id=" + dgv_taksi.SelectedRows[0].Cells["taksiTur_id"].Value);


                TaksiTurGridiDoldur();
                MessageBox.Show("Taksi Türü Silindi");
            }
            else
                return;
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (dgv_taksi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen Güncellenecek Taksi Türü Seçiniz...");

                return;
            }
            if (tx_tur.Text.Length < 3 || tx_tur.Text.Length > 10)
            {
                MessageBox.Show("Taksi Türü En Az 3 Karakter En Fazla 10 Karakter olabilir...");
                return;
            }
            string girdi = tx_tur.Text.Trim();
            foreach (char c in girdi)
            {
                if (!char.IsLetter(c))
                {
                    MessageBox.Show("Taksi Türüne sadece harf girebilirsiniz!");
                    return;
                }
            }
            if (string.IsNullOrWhiteSpace(tx_tur.Text) || tx_tur.Text.Trim().Length != tx_tur.Text.Length)
            {
                MessageBox.Show("Taksi Türü Boş Bırakılamaz ve İçinde ya da Sonunda Boşluk Bulunamaz...");
                return;
            }

            DataTable dt = vt.Select(@"select taksiTur from tbl_taksiTur
                            where taksiTur='" + tx_tur.Text.ToUpper() + "'  AND taksiTur_id <> " + dgv_taksi.SelectedRows[0].Cells["taksiTur_id"].Value);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Bu Taksi Türü Önceden Girilmiş...");
                return;
            }

            if (cbx_tur.SelectedValue == null || cbx_tur.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Araç Boyutu boş bırakılamaz. Lütfen Araç Boyutu seçiniz!");
                return;
            }
            DialogResult secenek = MessageBox.Show("Bu Taksi Türü Bilgilerini Güncellemek O Taksiye Ait Taksi Türü Kayıtlarını da Güncelleyebilir Devam Etmek İstiyor musunuz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                vt.UpdateDelete(@"update tbl_taksiTur
                set 
	                taksiTur='" + tx_tur.Text.ToUpper() + @"',
                    boyut_id='" + cbx_tur.SelectedValue + @"'
	                where taksiTur_id=" + dgv_taksi.SelectedRows[0].Cells["taksiTur_id"].Value);
                TaksiTurGridiDoldur();
                MessageBox.Show("Taksi Türü Güncellendi");
            }
            else if (secenek == DialogResult.No)
            {
                return;
            }
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            tx_tur.Text = "";
            cbx_tur.SelectedValue = 0;

            if (dgv_taksi.SelectedRows.Count != 0)
                dgv_taksi.SelectedRows[0].Selected = false;
        }

        private void dgv_taksi_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_taksi.SelectedRows.Count == 0)
            {
                return;
            }
            tx_tur.Text = dgv_taksi.SelectedRows[0].Cells["TaksiTürü"].Value.ToString();
            cbx_tur.SelectedValue = dgv_taksi.SelectedRows[0].Cells["boyut_id"].Value.ToString();
        }

        private void TaksiTur_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormManager.RemoveForm(this);
        }


    }
}
