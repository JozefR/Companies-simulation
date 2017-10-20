using System;

namespace XA01
{
    /// <summary>
    /// IMPLEMENTUJTE ZDE
    ///     Upravte tuto tridu tak, aby v programu byla vzdy prave jedna a ta sama instance. 
    ///     Jde o implementaci podle navrhoveho vzoru Singleton.
    ///     Cilem teto tridy je poskytnout moznost zapisovani logovacich informaci. Zatim neumime
    ///     pracovat se soubory nebo napr. s databazi, proto je logovani simulovano pouhym vypisem do konzole.
    /// </summary>
    public class Logger
    {
        
        public void Log(string message)
        {
            Console.WriteLine("Logger: {0}", message);
        }
    }
}
