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
    public partial class giris : Form
    {
        public string ad, yetki;
        public giris()
        {
            InitializeComponent();
        }
        DLLislemleri.Veritabani vt = new DLLislemleri.Veritabani(ayarlar.Default.SunucuAdi, ayarlar.Default.VeritabaniAdi,ayarlar.Default.UzakSunucuBaglantisi,ayarlar.Default.UserID,ayarlar.Default.Password);
        DigerIslemler dg = new DigerIslemler();
        private void giris_Load(object sender, EventArgs e)
        {
            if (ayarlar.Default.lisansDurumu == false)
            {
                MessageBox.Show("Lisansınız bulunamadı, lisans sayfasına yönlendiriliyorsunuz...");
                this.Close();
                Lisans l = new Lisans();
                l.Show();
            }
            if (ayarlar.Default.beniHatirla == true)
            {
                tx_mail.Text = ayarlar.Default.tcNo;
                tx_sifre.Text = ayarlar.Default.sifre;
                chbx_beniHatirla.Checked = true;
            }

        }
        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            label3.Visible = true;
        }
        private void label5_MouseMove(object sender, MouseEventArgs e)
        {
            label5.Visible = true;
        }
        private void label6_MouseMove(object sender, MouseEventArgs e)
        {
            label6.Visible = true;
        }

        bool move;
        int mouse_x;
        int mouse_y;


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
        private void chbx_beniHatirla_CheckedChanged(object sender, EventArgs e)
        {
            if (chbx_beniHatirla.Checked == false)
            {
                ayarlar.Default.beniHatirla = false;
                ayarlar.Default.tcNo = "";
                ayarlar.Default.sifre = "";
                ayarlar.Default.Save();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void giris_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void giris_MouseMove(object sender, MouseEventArgs e)
        {
            label3.Visible = false;

            if (move == true)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
            label5.Visible = false;
            label6.Visible = false;
        }

        private void giris_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void btn_giris_Click_1(object sender, EventArgs e)
        {
            string md5liSifre = dg.MD5Sifrele(tx_sifre.Text);
            DataTable dt = vt.Select(@"select k.personel_id,k.mail,k.ad+' '+k.soyAd adSoyad, k.personelTur_id, kt.personelTur,kt.yetki_id,ye.yetki
                    from tbl_personel k
					join tbl_personelTur kt on kt.personelTur_id=k.personelTur_id
                    join tbl_yetki ye on ye.yetki_id=kt.yetki_id
            where mail='" + tx_mail.Text + "' and sifre='" + md5liSifre + "'");
            Anasayfa p = new Anasayfa();
            if (IsValidEmail(tx_mail.Text))
            {
                tx_mail.Text = tx_mail.Text.ToLower();
            }
            else
            {
                MessageBox.Show("Geçersiz email adresi!");
                return;
            }
            if (tx_sifre.Text == "")
            {
                MessageBox.Show("Şifre Boş Bırakılamaz...");
                return;
            }
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Mail veya şifre hatalı...");
                return;
            }
            else if (dt.Rows.Count != 0)
            {

                p.ad = "Kullanıcı: " + dt.Rows[0]["adSoyad"].ToString();
                p.yetki = "Kullanıcı Türü: " + dt.Rows[0]["personelTur"].ToString();

            }
            if (chbx_beniHatirla.Checked == true)
            {
                ayarlar.Default.beniHatirla = true;
                ayarlar.Default.tcNo = tx_mail.Text;
                ayarlar.Default.sifre = tx_sifre.Text;
                ayarlar.Default.Save();
            }
            p.personel_id = Convert.ToInt32(dt.Rows[0]["personel_id"]);
            MessageBox.Show("Kullanici Girişi Başarılı.\nHoş Geldin :" + dt.Rows[0]["adSoyad"].ToString());
            int yetki_id = (int)dt.Rows[0]["yetki_id"];
            p.yetki_id = yetki_id;
            this.Hide();
            p.Show();
        }
    }
}
