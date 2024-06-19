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

namespace Lisanslama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DigerIslemler  dg = new  DigerIslemler();
        private void button1_Click(object sender, EventArgs e)
        {
            if(tx_yazilimKodu.Text=="")
            {
                MessageBox.Show("Lütfen yazılım kodu girişi yapınız...!");
                return;
            }
            string yazilimKodu = tx_yazilimKodu.Text;
            tx_lisansKodu.Text = yazilimKodu;
            yazilimKodu = dg.MD5Sifrele(yazilimKodu).ToUpper();
            yazilimKodu = yazilimKodu.Substring(1, 3) +
            yazilimKodu.Substring(5, 4) +
            yazilimKodu.Substring(2, 4) +
            yazilimKodu.Substring(15, 3) +
            yazilimKodu.Substring(25, 2);
            yazilimKodu = yazilimKodu.Insert(12, "-");
            yazilimKodu = yazilimKodu.Insert(8, "-");
            yazilimKodu = yazilimKodu.Insert(4, "-");
            tx_lisansKodu.Text = yazilimKodu;
        }
    }
}
