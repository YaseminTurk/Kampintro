using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList();

            MyDictionary();
        }

        private static void MyDictionary()
        {
            MyDictionary<string, string> sozluk = new MyDictionary<string, string>();
            sozluk.Add("klavye", "keyboard");
            sozluk.Add("fare", "mause");

            Console.WriteLine(sozluk.Count);
            Console.WriteLine(sozluk.Keys);
            Console.WriteLine(sozluk.Values);
            sozluk.List();
        }

        private static void MyList()
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Engin");

            Console.WriteLine(isimler.Length);

            isimler.Add("Yasemin");

            Console.WriteLine(isimler.Length);

            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }
        }
    }
}
