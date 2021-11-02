using Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl(ConfigurationManager.AppSettings.Get("WebSiteURL"));
            IWebElement detailTitle = webDriver.FindElement(By.CssSelector(".classifiedDetailTitle"));
            var detailTitles = detailTitle.Text.Split(' ');
            string başlık = StringHelpers.DetailsTitleCut(detailTitles);
            detailTitle = webDriver.FindElement(By.CssSelector(".classifiedInfo"));
            
            var dizi = detailTitle.Text.Split('\n');

            var dizi2 = detailTitle.Text.Split(' ');

            int index = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(CarInfo.carInfo[index] +":"+ dizi[i].TrimStart(' '));
                    index++;
                }
            }

            //Console.WriteLine($"Fiyat :{dizi[0]}");
            //Console.WriteLine($"Yer :{dizi[2]}");
            //Console.WriteLine($"İlan No :{dizi[4]}");
            //Console.WriteLine($"İlan Tarihi:{dizi[6]}");
            //Console.WriteLine($"Marka    :{dizi[8]}");
            //Console.WriteLine($"Seri :{dizi[10]}");
            //Console.WriteLine($"Model :{dizi[12]}");
            //Console.WriteLine($"Yıl :{dizi[14]}");
            //Console.WriteLine($"Yakıt :{dizi[16]}");
            //Console.WriteLine($"Vites :{dizi[18]}");
            //Console.WriteLine($"KM :{dizi[20]}");
            //Console.WriteLine($"Kasa Tipi :{dizi[22]}");
            //Console.WriteLine($"Motor Gücü :{dizi[24]}");
            //Console.WriteLine($"Motor Hacmi :{dizi[26]}");
            //Console.WriteLine($"Çekiş :{dizi[28]}");
            //Console.WriteLine($"Kapı :{dizi[30]}");
            //Console.WriteLine($"Renk :{dizi[32]}");
            //Console.WriteLine($"Garanti :{dizi[34]}");
            //Console.WriteLine($"Plaka Uyruk :{dizi[36]}");
            //Console.WriteLine($"Kimden :{dizi[38]}");
            //Console.WriteLine($"Görüntülü Arama İle Görülebilir :{dizi[40]}");
            //Console.WriteLine($"Takas :{dizi[42]}");
            //Console.WriteLine($"Durumu :{dizi[44]}");

        }
    }
}
