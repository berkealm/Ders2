﻿using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager ihtiyacCreditManager = new IhtiyacCreditManager();
            ICreditManager tasitCreditManager = new TasitCreditManager();
            ICreditManager konutCreditManager = new KonutCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(tasitCreditManager, new List<ILoggerService> { new DatabaseLoggerService(), new FileLoggerService()});
            

            
            List<ICreditManager> credits = new List<ICreditManager>() { tasitCreditManager, ihtiyacCreditManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(credits);
            
        }
    }
}
