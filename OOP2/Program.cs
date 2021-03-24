using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Engin Demiroğ
            GercekMusteri gercekMusteri = new GercekMusteri();
            gercekMusteri.Id = 1;
            gercekMusteri.MusteriNo = "12345";
            gercekMusteri.Adi = "Engin";
            gercekMusteri.Soyadi = "Demiroğ";
            gercekMusteri.TcNo = "12345678910";

            //Kodlama.io
            TuzelMusteri tuzelMusteri = new TuzelMusteri();
            tuzelMusteri.Id = 2;
            tuzelMusteri.MusteriNo = "54321";
            tuzelMusteri.SirketAdi = "Kodlama.io";
            tuzelMusteri.VergiNo = "1234567890";


            //Gerçek Müşteri - Tüzel Müşteri  benziyorlar diye ikisi asla birbirinin yerine kullanılamazlar
            //SO'L'ID

            Musteri gercekMusteri2 = new GercekMusteri() { Id=3, MusteriNo="12345", Adi="Yasemin", Soyadi="Türk", TcNo="1234567890"}; //Musteri hem gercek müsterinin hem de tüzel müşterinin referansını tutabiliyor.
            Musteri tuzelMusteri2 = new TuzelMusteri() { Id = 3, MusteriNo = "12345", SirketAdi = "ysmn.io", VergiNo = "1234567890" };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(gercekMusteri);
            musteriManager.Ekle(tuzelMusteri);
            musteriManager.Ekle(gercekMusteri2);
            musteriManager.Ekle(tuzelMusteri2);
        }
    }
}
