using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Bellekte stack ve heap adında 2 alanımız mevcuttur. İnt, decimal, floot, double benzeri değer tip bilgiler stack içerisinde belleğe kaydedilir. 
            // Array, class, interface, gibi çoklu değişken bilgiler ise heap içerisinde belleğe kaydedilir.

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;

            //sayi1 kaç olur ?
            // Cevap = 30 olur çünkü, int değişkeni bir değer tiptir. Dolayısıyla değer tiplemelerinde buna benzer sorularda 1. değer ve 2. değer eşitlenirse örnekte olduğu gibi
            // sayi1 = sayi2 dediğimizde sayi1'in 10 birimlik değeri sayi2'nin 30birimlik değeri ile eşitlenir ve 30 olur. Daha sonrasında tüm bağ koparılır ve 2. bir işlemde yer almaz.


            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;

            //sayilar1[0] elemanı kaç olur ?
            //Cevap = 999

            //Çözüm: int[]sayilar1 için stack bölgesinde verilen referans numarası (adreslenebilir heap bölgesi numarası) sayilar2 için stack bölgesinde verilen referans numarasına eşitlenir.
            //Dolayısıyla  Referans numarası 101 olarak sayilar1 "10,20,30" değerleri, referans numarası 102 olan sayilar2 "100,200,300"e eşitlenir.
            //sayilar2[0] = 999 " sayilar2'nin 0. elemanı 999 olduğuna göre sayilar1'in de 0. elemanı 999 olur. Çünkü referans tipleri eşitlenmiştir.

            //int sayilar1, 2, 3 dediğimizde Stack bölgesinde sayilar1, 2, 3, başlığı altında veriler oluşturulur. 
            //new int [] array dediğimiz anda stack karşılığı sayilar1 olan değerler için birim bellekleme noktası heap bölgesidir. 
            //sayilar1 [] {10,20,30} dersek burada ki sayilar1 stack bölgesine, "10,20,30" ise heap bölgesine adresli bir şekilde kaydedilir.

            //Boşta kalan kullanılmayan değerler Garbage Collector ile .Net eşliğinde çöpe atılır.


            //int, decimal, floot, double, bool vb sayılar bilgilere değer tip denir.
            //array, class, interface gibi çoklu değişken bilgilerine referans tip denir.
        }
    }
}
