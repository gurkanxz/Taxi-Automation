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
    public partial class Anasayfa : Form
    {
        public class FormManager
        {
            private static List<Form> openForms = new List<Form>();

            public static void AddForm(Form form)
            {
                openForms.Add(form);
            }

            public static void RemoveForm(Form form)
            {
                openForms.Remove(form);
            }

            public static void ToggleFormsVisibility()
            {
                foreach (var form in openForms)
                {
                    form.Visible = !form.Visible;
                }

            }
            public static List<Form> GetOpenForms()
            {
                return openForms;
            }
            public static void ExitApplication()
            {
                Application.Exit();
            }
            public static bool AreFormsVisible()
            {
                return openForms.Any(form => form.Visible);
            }

        }
        public Anasayfa()
        {
            InitializeComponent();
        }
        public int personel_id = 1;
        public int yetki_id = 1;
        public string adSoyad = " ";
        public string ad, yetki;
        DLLislemleri.Veritabani vt = new DLLislemleri.Veritabani(ayarlar.Default.SunucuAdi, ayarlar.Default.VeritabaniAdi, ayarlar.Default.UzakSunucuBaglantisi, ayarlar.Default.UserID, ayarlar.Default.Password);
        private void Anasayfa_Load(object sender, EventArgs e)
        {
            FormManager.AddForm(this);
            if (ayarlar.Default.lisansDurumu == false)
            {
                MessageBox.Show("Lisansınız bulunamadı, lisans sayfasına yönlendiriliyorsunuz...");
                this.Close();
                Lisans l =new Lisans();
                l.Show();
            }
            cbx_durak.ValueMember = "durak_id";
            cbx_durak.DisplayMember = "ad";
            cbx_durak.DataSource = vt.Select("select durak_id,ad from tbl_durak");
            tspl_ad.Text = ad;
            tspl_tur.Text = yetki;

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

        private void cbx_durak_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedDurakID = Convert.ToInt32(cbx_durak.SelectedValue); // Seçilen durak ID'sini al

            DataTable dt = vt.Select(@"select t.taksi_id,t.plaka,t.durum_id,t.taksiTur_id,t.model, a.boyut_id
	             from tbl_taksi t
		         join tbl_taksiTur tt on tt.taksiTur_id=t.taksiTur_id
		         join tbl_aracBoyut a on a.boyut_id=tt.boyut_id
		         where durak_id= '" + selectedDurakID + "' order by boyut_id");

            // Paneli temizle
            panel1.Controls.Clear();

            int maxSutun = 5; // Maksimum sütun sayısı
            int maxSatir = (dt.Rows.Count + maxSutun - 1) / maxSutun; // Maksimum satır sayısı

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int boyut_id = Convert.ToInt32(dt.Rows[i]["boyut_id"]);

                // Satır ve sütun hesaplamaları
                int sutunSay = boyut_id - 1 + (i / maxSatir);
                int satirSay = i % maxSatir;

                Button existingButton = panel1.Controls.Find("btn_" + dt.Rows[i]["taksi_id"].ToString(), true).FirstOrDefault() as Button;

                if (existingButton == null)
                {
                    Button b = new Button();
                    b.Size = new Size(55, 40 + boyut_id * 8);
                    b.Location = new Point(sutunSay * 80 + 35, satirSay * 65 + 35);
                    b.Text = dt.Rows[i]["plaka"].ToString() + " " + dt.Rows[i]["model"];
                    if (dt.Rows[i]["durum_id"].ToString() == "1")
                    {
                        b.BackColor = Color.IndianRed;
                    }
                    else
                    {
                        b.BackColor = Color.LightGreen;
                    }
                    b.Name = "btn_" + dt.Rows[i]["taksi_id"].ToString();
                    panel1.Controls.Add(b);
                }
                else
                {
                    if (dt.Rows[i]["durum_id"].ToString() == "1")
                    {
                        existingButton.BackColor = Color.IndianRed;
                    }
                    else
                    {
                        existingButton.BackColor = Color.LightGreen;
                    }
                }
            }

        }


        private void Anasayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void cbx_durak_SelectedValueChanged(object sender, EventArgs e)
        {
          
            
        }

        private void lbl_ad_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

            FormManager.RemoveForm(this);
            this.Hide();
            Taksi k = new Taksi();
            k.personel_id = personel_id;
            k.ad = ad;
            k.yetki= yetki;
            k.yetki_id=yetki_id;
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

            FormManager.RemoveForm(this);
            this.Hide();
            TaksiTur k = new TaksiTur();
            k.yetki_id= yetki_id;
            k.personel_id = personel_id;
            k.ad = ad;
            k.yetki= yetki;
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
            FormManager.RemoveForm(this);
            this.Hide();
            Personel k = new Personel();
            k.yetki_id= yetki_id;
            k.personel_id = personel_id;
            k.ad = ad;
            k.yetki= yetki;
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

            FormManager.RemoveForm(this);
            this.Hide();
            PersonelTur k = new PersonelTur();
            k.yetki_id= yetki_id;
            k.personel_id = personel_id;
            k.ad = ad;
            k.yetki= yetki;
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
            FormManager.RemoveForm(this);
            this.Hide();
            Sofor k= new Sofor();
            k.yetki_id = yetki_id;
            k.personel_id = personel_id;
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

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            FormManager.RemoveForm(this);
            this.Hide();
            Rezervasyon k = new Rezervasyon();
            k.yetki_id= yetki_id;
            k.personel_id = personel_id;
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

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            FormManager.RemoveForm(this);
            this.Hide();
            Musteri k = new Musteri();
            k.yetki_id= yetki_id;
            k.personel_id = personel_id;
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

        private void toolStripButton9_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {

            FormManager.RemoveForm(this);
            this.Hide();
            OdemeTur k = new OdemeTur();
            k.yetki_id= yetki_id;
            k.personel_id = personel_id;
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

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            FormManager.RemoveForm(this);
            this.Hide();
            hasilat k = new hasilat();
            k.yetki_id= yetki_id;
            k.personel_id = personel_id;
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

        private void toolStripButton13_Click(object sender, EventArgs e)
        {
            FormManager.RemoveForm(this);
            this.Hide();
            settings set = new settings();
            set.personel_id= personel_id;
            set.yetki_id= yetki_id;
            set.ad = ad;
            set.yetki = yetki;
            if(yetki_id==1)
            {
                set.btn_tarife.Enabled = true;
            }
            else
            {
                set.btn_tarife.Enabled = false;
            }
            set.Show();
        }

        private void gösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManager.ToggleFormsVisibility();
            gösterToolStripMenuItem.Text = FormManager.AreFormsVisible() ? "Gizle" : "Göster";
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManager.ExitApplication();
        }

        private void Anasayfa_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormManager.RemoveForm(this);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FormManager.RemoveForm(this);
            this.Hide();
            Durak k = new Durak();
            k.yetki_id= yetki_id;
            k.personel_id = personel_id;
            k.ad = ad;
            k.yetki= yetki;
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
    }
}
