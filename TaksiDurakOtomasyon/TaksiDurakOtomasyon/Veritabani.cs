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

namespace TaksiDurakOtomasyon
{
    public partial class Veritabani : Form
    {
        public Veritabani()
        {
            InitializeComponent();
        }
        private void Veritabani_Load(object sender, EventArgs e)
        {
            if (ayarlar.Default.lisansDurumu == false)
            {
                MessageBox.Show("Lisansınız bulunamadı, lisans sayfasına yönlendiriliyorsunuz...");
                this.Close();
                Lisans l = new Lisans();
                l.Show();
            }
            if (ayarlar.Default.SunucuAdi != "")
            {
                tx_sunucuAdi.Text = ayarlar.Default.SunucuAdi;
                tx_veritabaniAdi.Text = ayarlar.Default.VeritabaniAdi;
                chbx_uzakSunucu.Checked = ayarlar.Default.UzakSunucuBaglantisi;
                tx_kullaniciAdi.Text = ayarlar.Default.UserID;
                tx_sifre.Text = ayarlar.Default.Password;
            }
            btn_gosterGizle.Image = TaksiDurakOtomasyon.Properties.Resources.view__1_;
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
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if(tx_sunucuAdi.Text=="")
            {
                MessageBox.Show("Lütfen Sunucu Adı Giriniz...");
                return;
            }
            if(tx_veritabaniAdi.Text=="")
            {
                MessageBox.Show("Lütfen Veritabanı Adı Giriniz...");
                return;
            }
            if(chbx_uzakSunucu.Checked== true)
            {
                if (tx_kullaniciAdi.Text == "")
                {
                    MessageBox.Show("Lütfen Kullanıcı Adı Giriniz...");
                    return;
                }
                if (tx_sifre.Text == "")
                {
                    MessageBox.Show("Lütfen Sifre Giriniz...");
                    return;
                }
            }
            ayarlar.Default.SunucuAdi = tx_sunucuAdi.Text;
            ayarlar.Default.VeritabaniAdi = tx_veritabaniAdi.Text;
            ayarlar.Default.UzakSunucuBaglantisi = chbx_uzakSunucu.Checked;
            ayarlar.Default.UserID = tx_kullaniciAdi.Text;
            ayarlar.Default.Password = tx_sifre.Text;
            ayarlar.Default.Save();
            MessageBox.Show("Ayarlar Kaydedildi.."); 
            this.Hide();
            giris g =new giris();
            g.Show();  
        }

        private void chbx_uzakSunucu_CheckedChanged(object sender, EventArgs e)
        {
            if (chbx_uzakSunucu.Checked)
                tx_kullaniciAdi.Enabled = tx_sifre.Enabled = true;
            else
            {
                tx_kullaniciAdi.Enabled = tx_sifre.Enabled = false;
                tx_kullaniciAdi.Text = tx_sifre.Text = "";
            }
        }

        private void btn_gosterGizle_Click(object sender, EventArgs e)
        {
            if (tx_sifre.PasswordChar == '*')
            {
                btn_gosterGizle.Image = TaksiDurakOtomasyon.Properties.Resources.eye_password__2_;
                tx_sifre.PasswordChar = '\0';
                //btn_gosterGizle.Text = "Gizle";
            }
            else
            {
                btn_gosterGizle.Image = TaksiDurakOtomasyon.Properties.Resources.view__1_;
                tx_sifre.PasswordChar = '*';
                //btn_gosterGizle.Text = "Göster";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
