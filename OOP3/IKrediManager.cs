using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //interfaceler birbirlerinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanılır.
    interface IKrediManager  //şablon oluşturur //interface onu implement eden sınıfın referansını tutabilir.
    {
        void Hesapla();
        void BiseyYap();
    }
}
