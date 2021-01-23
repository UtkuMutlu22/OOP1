using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager,List<ILoggerService> loggerService)
        {
            //Başvuru Bilgieri Değerlendirme
            krediManager.Hesapla();
            foreach (var item in loggerService)
            {
                Console.WriteLine("Loglamalar Yapıldı");
            }
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager>krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
