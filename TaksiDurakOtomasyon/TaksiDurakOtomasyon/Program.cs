using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;
using DLLislemleri;

namespace TaksiDurakOtomasyon
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DigerIslemler dg = new DigerIslemler();
            if (!File.Exists("lisans.dll") || !File.Exists("yazilim.dll"))
            {
                Application.Run(new Lisans());
            }
            else
            {
                using (StreamReader sw = new StreamReader("lisans.dll", Encoding.Default))
                using (StreamReader sww = new StreamReader("yazilim.dll", Encoding.Default))
                {
                    try
                    {

                        string lisansOkunan = sw.ReadLine();
                        string yazilimOkunan = sww.ReadLine();
                        string yazilimKodu = yazilimOkunan;
                        yazilimKodu = dg.MD5Sifrele(yazilimKodu).ToUpper();
                        yazilimKodu = yazilimKodu.Substring(1, 3) +
                                      yazilimKodu.Substring(5, 4) +
                                      yazilimKodu.Substring(2, 4) +
                                      yazilimKodu.Substring(15, 3) +
                                      yazilimKodu.Substring(25, 2);
                        yazilimKodu = yazilimKodu.Insert(12, "-");
                        yazilimKodu = yazilimKodu.Insert(8, "-");
                        yazilimKodu = yazilimKodu.Insert(4, "-");

                        if (lisansOkunan == yazilimKodu)
                        {
                            Application.Run(new Veritabani());
                        }
                        else
                        {
                            MessageBox.Show("Lisans kodunuz hatalı lütfen tekrar giriniz....");
                            File.Delete("lisans.dll");
                            Application.Run(new Lisans());
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bir hata oluştu: " + ex.Message);
                        File.Delete("lisans.dll");
                        Application.Run(new Lisans());
                    }
                }
            }
        }

      }
    }

