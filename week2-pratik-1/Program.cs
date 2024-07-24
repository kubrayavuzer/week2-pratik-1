using System;

namespace Patika
{
    class Program
    {
        static void Main(string[] args)
        {
            //Konsol ekranına 10 kere metin yazdırmak.

           for (int i =0; i <=10; i++)
            {
                Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
            }

           //1 ile 20 arasındaki sayıları konsol ekranına yazdırın.
           
           for ( int i = 1; i <= 20; i++)
            {
                Console.WriteLine($"i değeri {i}");
            }

            //1 ile 20 arasındaki çift sayılar
            

           for (int i = 0; i <= 20; i += 2)
            {
                Console.WriteLine(i);
            }

            //50 ile 150 arasındaki sayıların toplamı.

            int toplam = 0;

            for (int i = 50; i < 150; i++)
            {
                toplam += i;
            }


            int tekToplam = 0;
            int ciftToplam = 0;

            // 1 ile 120 arasındaki sayıları kontrol ediyoruz.

            for (int i = 0; i <= 120; i++)
            {
                if (i % 2 == 0)
                {
                    //Cift sayı ise ciftToplam'a ekliyoruz
                    ciftToplam += i;

                }

                else
                {
                    //Tek sayı ise tekToplam'a ekliyoruz

                    tekToplam += i;
                }
            }

            //Sonuçları ekrana yazdırıyoruz

            Console.WriteLine($"1 ile 120 arasındaki tek sayıların toplamı: {tekToplam}");
            Console.WriteLine($"1 ile 120 arasındaki çift sayıların toplamı: {ciftToplam}");

         
        }
    }
}
