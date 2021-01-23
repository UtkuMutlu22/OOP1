using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager esnafKrediManager = new EsnafKredisiManager();
            IKrediManager ihtiyacKrediManager = new İhtiyacKrediManager();
            
            IKrediManager tasitKrediManager = new TasitKrediManager();
            
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService dataBaseLogerService = new DataBaseLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();
            List<ILoggerService> logggers = new List<ILoggerService>()
            {
                new SmsLoggerService(),new FileLoggerService()
            };

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(esnafKrediManager,logggers );
            List<IKrediManager> krediler = new List<IKrediManager>()
            {
                ihtiyacKrediManager,tasitKrediManager
            };
           // basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
