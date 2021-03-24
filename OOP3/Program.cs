using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //interfaceler de kendini implemente eden sınıfın referans numarasını tutabilirler.
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager,new List<ILoggerService> { new DatabaseLoggerService(), new FileLoggerService() });
            //basvuruManager.BasvuruYap(tasitKrediManager,databaseLoggerService);
            //basvuruManager.BasvuruYap(konutKrediManager,new FileLoggerService());

            List<IKrediManager> krediler = new List<IKrediManager> { ihtiyacKrediManager,tasitKrediManager };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
