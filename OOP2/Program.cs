using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 =new GercekMusteri();
            musteri1.MusteriNo = "123456";
            musteri1.Adi = "Utku";
            musteri1.SoyAdi = "Mutlu";
            musteri1.TcNo = "12354";
            musteri1.Id = 1;

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "23343554";
            musteri2.SirketAdi = "Edunet";
            musteri2.VergiNo = "121212121212121";

            Musteri muster3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

        }
    }
}
