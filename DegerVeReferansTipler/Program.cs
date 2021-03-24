using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //sayısal veri tipleri ==> int, decimal, float, double, bool==> değer tip ----stack de depolanır
            //array,class,interface,string ==> referans tip

            int sayi1 = 10;
            int sayi2 = 30;

            sayi1 = sayi2;
            sayi2 = 65;

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2; //sayilar1 in referans numarası eşittir sayilar2 nin referans numarası 
            sayilar2[0] = 999;

            Console.WriteLine(sayi1); //30 yazdırır.
            Console.WriteLine(sayilar1[0]); //999 yazdırır.

            Console.ReadLine();
        }
    }
}
