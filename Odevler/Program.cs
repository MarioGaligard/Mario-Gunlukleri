using System;

namespace Odev2
{
    class Program
    {
        static void Main(string[] args)
        {


            Urun urun1 = new Urun();
            {
                urun1.UrunAdi = "Rtx 3080";
                urun1.UrunFiyati = 20000;
                urun1.UrunAdeti = 197;
            }
            Urun urun2 = new Urun();
            {
                urun2.UrunAdi = "Rx 6800 XT";
                urun2.UrunFiyati = 18000;
                urun2.UrunAdeti = 542;
            }
            Urun urun3 = new Urun();
            {
                urun3.UrunAdi = "Rtx 3090";
                urun3.UrunFiyati = 40000;
                urun3.UrunAdeti = 4;
            }


            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };


            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.UrunAdeti + " : " + urun.UrunAdi + " : " + urun.UrunFiyati + " : ");
            }

        }
    }
    class Urun
    {
        public string UrunAdi { get; set; }
        public int UrunFiyati { get; set; }
        public int UrunAdeti { get; set; }
    }

}



