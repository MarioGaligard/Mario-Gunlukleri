using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] meyveler = new string[] { };

            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Kırmızı Elma";

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Product[] products = new Product[] { urun1, urun2 };

            //type-safe -- Tip Güvenliği
            foreach (Product urun in products)
            {
                
                
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------------");
            }

            Console.WriteLine("------------Metotlar-------------");
            //instance - örnek
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12);
            sepetManager.Ekle2("Elma", "Yeşil Muz", 16);
            sepetManager.Ekle2("Karpuz", "Yeşil Elma", 13);
        }
    }
}



// Do not repeat yourself = DRY (Kendini Tekrar Etme) - Clean Code (Temiz Kod Yazma Teknikleri) - Best Practice (Doğru Uygulama Teknikleri)