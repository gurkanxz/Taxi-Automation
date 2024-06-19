using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using Microsoft.Win32;
using DLLislemleri;
using System.IO;

namespace TaksiDurakOtomasyon
{
    public partial class Lisans : Form
    {
        public Lisans()
        {
            InitializeComponent();
        }
        DigerIslemler dg = new DigerIslemler();
        private void Lisans_Load(object sender, EventArgs e)
        {
                string cpuSeriNo = CPUSeriNoCek();
                string hddSeriNo = HDDSeriNoCek()[0];
                string metin = (cpuSeriNo + hddSeriNo.Trim()).Replace('0', '3').Replace('A', 'H').Replace('B', 'C').Replace('1', 'G').Replace('2', '7').Replace('8', 'J');
                string mdlencek = dg.MD5Sifrele(metin).ToUpper();
                string lisanslanan = mdlencek.Substring(1, 3) +
                    mdlencek.Substring(5, 4) +
                    mdlencek.Substring(2, 4) +
                    mdlencek.Substring(15, 3) +
                    mdlencek.Substring(25, 2);
                lisanslanan = lisanslanan.Insert(12, "-");
                lisanslanan = lisanslanan.Insert(8, "-");
                lisanslanan = lisanslanan.Insert(4, "-");
                tx_yazilimKodu.Text = lisanslanan;
            //StreamWriter sww = new StreamWriter("yazilim.dll", false, Encoding.Default);
            //sww.WriteLine(lisanslanan);
            //sww.Close();

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
        public static String CPUSeriNoCek()
        {
            String processorID = "";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("Select * FROM WIN32_Processor");
            ManagementObjectCollection mObject = searcher.Get();

            foreach (ManagementObject obj in mObject)
            {
                processorID = obj["ProcessorId"].ToString();
            }

            return processorID;
        }
        public static List<string> HDDSeriNoCek()
        {
            List<string> serials = new List<string>();
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia");
            ManagementObjectCollection disks = searcher.Get();
            foreach (ManagementObject disk in disks)
            {
                if (disk["SerialNumber"] == null)
                    serials.Add("");
                else
                    serials.Add(disk["SerialNumber"].ToString());
            }
            return serials;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tx_lisansKodu.Text=="")
            {
                MessageBox.Show("Lütfen Lisans Kodu Giriniz...");
                return;
            }
            string yazilimKodu = tx_yazilimKodu.Text;
            StreamWriter sww = new StreamWriter("yazilim.dll", false, Encoding.Default);
            sww.WriteLine(yazilimKodu);
            sww.Close();
            yazilimKodu = dg.MD5Sifrele(yazilimKodu).ToUpper();
            yazilimKodu = yazilimKodu.Substring(1, 3) +
            yazilimKodu.Substring(5, 4) +
            yazilimKodu.Substring(2, 4) +
            yazilimKodu.Substring(15, 3) +
            yazilimKodu.Substring(25, 2);
            yazilimKodu = yazilimKodu.Insert(12, "-");
            yazilimKodu = yazilimKodu.Insert(8, "-");
            yazilimKodu = yazilimKodu.Insert(4, "-");
            if (yazilimKodu == tx_lisansKodu.Text)
            {
                StreamWriter sw = new StreamWriter("lisans.dll",false,Encoding.Default);
                sw.WriteLine(yazilimKodu);
                sw.Close();
                ayarlar.Default.lisansDurumu = true;
                ayarlar.Default.Save();
                MessageBox.Show("Lisanslama işlemi başarılı...");
                Application.Restart();
            }
            else
            {
                MessageBox.Show("Lisans kodunuz hatalı!");
                Lisans_Load(null, null);
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
