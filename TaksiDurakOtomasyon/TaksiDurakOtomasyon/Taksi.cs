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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static TaksiDurakOtomasyon.Anasayfa;

namespace TaksiDurakOtomasyon
{
    public partial class Taksi : Form
    {
        DLLislemleri.Veritabani vt = new DLLislemleri.Veritabani(ayarlar.Default.SunucuAdi, ayarlar.Default.VeritabaniAdi, ayarlar.Default.UzakSunucuBaglantisi, ayarlar.Default.UserID, ayarlar.Default.Password);
        public Taksi()
        {
            InitializeComponent();
        }
        public string ad, yetki;
        public int personel_id = 1;
        public int yetki_id=1;
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
            TaksiTur k = new TaksiTur();
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

        private void Taksi_Load(object sender, EventArgs e)
        {
            FormManager.AddForm(this);
            cbx_tur.ValueMember = "taksiTur_id";
            cbx_tur.DisplayMember = "taksiTur";
            cbx_tur.DataSource = vt.Select("select taksiTur_id, taksiTur from tbl_taksiTur");

            cbx_durak.ValueMember = "durak_id";
            cbx_durak.DisplayMember = "ad";
            cbx_durak.DataSource = vt.Select("select ad, durak_id from tbl_durak");

            cbx_durum.DisplayMember = "durum";
            cbx_durum.ValueMember = "durum_id";
            cbx_durum.DataSource = vt.Select("SELECT durum, durum_id FROM tbl_taksiDurum");
            TaksiGridiDoldur();
        }
        private void TaksiGridiDoldur()
        {
            dgv_taksi.DataSource = vt.Select(@"SELECT  t.taksi_id, t.durak_id, t.taksiTur_id,d.ad AS DurakAdı, tt.taksiTur AS TaksiTürü, t.plaka as Plaka, t.model as Model, t.durum_id, td.durum as Durum
                FROM  tbl_taksi t
                    JOIN tbl_durak d ON d.durak_id = t.durak_id
                    JOIN tbl_taksiTur tt ON tt.taksiTur_id = t.taksiTur_id
                    JOIN tbl_taksiDurum td ON td.durum_id = t.durum_id
                    ORDER BY d.ad");
            dgv_taksi.Columns["durak_id"].Visible = false;
            dgv_taksi.Columns["taksi_id"].Visible = false;
            dgv_taksi.Columns["taksiTur_id"].Visible = false;
            dgv_taksi.Columns["durum_id"].Visible = false;


        }
        bool move;
        int mouse_x;
        int mouse_y;
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

            if (tx_plaka.Text.Length < 5 || tx_plaka.Text.Length > 6)
            {
                MessageBox.Show("Plaka En Az 5 Karakter En Fazla 6 Karakter olabilir...");
                return;
            }
            string girdi = tx_model.Text.Trim();
            foreach (char c in girdi)
            {
                if (!char.IsLetter(c))
                {
                    MessageBox.Show("Model'e sadece harf girebilirsiniz!");
                    return;
                }
            }
            if (string.IsNullOrWhiteSpace(tx_plaka.Text) || tx_plaka.Text.Trim().Length != tx_plaka.Text.Length)
            {
                MessageBox.Show("Plaka Boş Bırakılamaz ve İçinde ya da Sonunda Boşluk Bulunamaz...");
                return;
            }
            if (string.IsNullOrWhiteSpace(tx_model.Text) || tx_model.Text.Trim().Length != tx_model.Text.Length)
            {
                MessageBox.Show("Model Boş Bırakılamaz ve İçinde ya da Sonunda Boşluk Bulunamaz...");
                return;
            }

            DataTable dt = vt.Select(@"select plaka from tbl_taksi
                            where plaka='" + tx_plaka.Text.ToUpper() + "'  ");
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Bu Plaka Önceden Girilmiş...");
                return;
            }

            if (cbx_tur.SelectedValue == null || cbx_tur.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Taksi türü boş bırakılamaz. Lütfen Taksi türü seçiniz!");
                return;
            }
            if (cbx_durak.SelectedValue == null || cbx_durak.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Durak boş bırakılamaz. Lütfen Durak seçiniz!");
                return;
            }
            if (cbx_durum.SelectedValue == null || string.IsNullOrWhiteSpace(cbx_durum.SelectedValue.ToString()))
            {
                MessageBox.Show("Durum boş bırakılamaz. Lütfen Durum seçiniz!");
                return;
            }

            vt.Insert(@"insert into tbl_taksi(plaka, model, durak_id, taksiTur_id, durum_id)
            values('" + tx_plaka.Text.ToUpper() + "','" + tx_model.Text.ToUpper() + "','" + cbx_durak.SelectedValue + "','" + cbx_tur.SelectedValue + "','"+ cbx_durum.SelectedValue +"')");
            TaksiGridiDoldur();
            MessageBox.Show("Taksi Bilgisi Eklendi");
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (dgv_taksi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen Silinecek Taksi Seçiniz...");

                return;
            }

            DialogResult secenek = MessageBox.Show("Bu Taksi Bilgilerini Silmek Taksiye Ait Kayıtları Silebilir Devam Etmek İstiyor musunuz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {


                vt.UpdateDelete("DELETE t1 FROM tbl_odeme t1 INNER JOIN tbl_rezervasyon t2 ON t1.rez_id = t2.rez_id INNER JOIN tbl_taksi t3 ON t2.taksi_id=t3.taksi_id  WHERE t3.taksi_id =" + dgv_taksi.SelectedRows[0].Cells["taksi_id"].Value);
                vt.UpdateDelete("DELETE t1 FROM tbl_rezervasyon t1 INNER JOIN tbl_taksi t2 ON t1.taksi_id = t2.taksi_id WHERE t2.taksi_id =" + dgv_taksi.SelectedRows[0].Cells["taksi_id"].Value);
                vt.UpdateDelete("DELETE t1 FROM tbl_hasilat t1 INNER JOIN tbl_taksi t2 ON t1.taksi_id = t2.taksi_id WHERE t2.taksi_id =" + dgv_taksi.SelectedRows[0].Cells["taksi_id"].Value);
                vt.UpdateDelete("delete from tbl_taksi where taksi_id=" + dgv_taksi.SelectedRows[0].Cells["taksi_id"].Value);


                TaksiGridiDoldur();
                MessageBox.Show("Taksi Silindi");
            }
            else
                return;
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (dgv_taksi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen Güncellenecek Taksi Seçiniz...");

                return;
            }

            if (tx_plaka.Text.Length < 5 || tx_plaka.Text.Length > 6)
            {
                MessageBox.Show("Plaka En Az 5 Karakter En Fazla 6 Karakter olabilir...");
                return;
            }
            string girdi = tx_model.Text.Trim();
            foreach (char c in girdi)
            {
                if (!char.IsLetter(c))
                {
                    MessageBox.Show("Model'e sadece harf girebilirsiniz!");
                    return;
                }
            }
            if (string.IsNullOrWhiteSpace(tx_plaka.Text) || tx_plaka.Text.Trim().Length != tx_plaka.Text.Length)
            {
                MessageBox.Show("Plaka Boş Bırakılamaz ve İçinde ya da Sonunda Boşluk Bulunamaz...");
                return;
            }
            if (string.IsNullOrWhiteSpace(tx_model.Text) || tx_model.Text.Trim().Length != tx_model.Text.Length)
            {
                MessageBox.Show("Model Boş Bırakılamaz ve İçinde ya da Sonunda Boşluk Bulunamaz...");
                return;
            }

            DataTable dt = vt.Select(@"select plaka from tbl_taksi
                            where plaka='" + tx_plaka.Text.ToUpper() + "' AND taksi_id <> " + dgv_taksi.SelectedRows[0].Cells["taksi_id"].Value);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Bu Plaka Önceden Girilmiş...");
                return;
            }

            if (cbx_tur.SelectedValue == null || cbx_tur.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Taksi türü boş bırakılamaz. Lütfen Taksi türü seçiniz!");
                return;
            }
            if (cbx_durak.SelectedValue == null || cbx_durak.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Durak boş bırakılamaz. Lütfen Durak seçiniz!");
                return;
            }
            if (cbx_durum.SelectedValue == null || string.IsNullOrWhiteSpace(cbx_durum.SelectedValue.ToString()))
            {
                MessageBox.Show("Durum boş bırakılamaz. Lütfen Durum seçiniz!");
                return;
            }

            DialogResult secenek = MessageBox.Show("Bu Taksi Bilgilerini Güncellemek O Taksiye Ait Taksi Kayıtlarını da Güncelleyebilir Devam Etmek İstiyor musunuz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                vt.UpdateDelete(@"update tbl_taksi
                set 
	                plaka='" + tx_plaka.Text + @"',
                    model='" + tx_model.Text + @"',
                    taksiTur_id='" + cbx_tur.SelectedValue + @"',
                    durak_id='" + cbx_durak.SelectedValue + @"',
                    durum_id='" + cbx_durum.SelectedValue + @"'
	                where taksi_id=" + dgv_taksi.SelectedRows[0].Cells["taksi_id"].Value);
                TaksiGridiDoldur();
                MessageBox.Show("Taksi Güncellendi");
            }
            else if (secenek == DialogResult.No)
            {
                return;
            }
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            tx_plaka.Text = "";
            tx_model.Text = "";
            cbx_durum.SelectedValue = 0;
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
            tx_plaka.Text = dgv_taksi.SelectedRows[0].Cells["plaka"].Value.ToString();
            tx_model.Text = dgv_taksi.SelectedRows[0].Cells["model"].Value.ToString();
            cbx_durum.SelectedValue = dgv_taksi.SelectedRows[0].Cells["durum_id"].Value.ToString();
            cbx_tur.SelectedValue = dgv_taksi.SelectedRows[0].Cells["taksiTur_id"].Value.ToString();
            cbx_durak.SelectedValue = dgv_taksi.SelectedRows[0].Cells["durak_id"].Value.ToString();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

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
        private void Taksi_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormManager.RemoveForm(this);
        }



    }
}
