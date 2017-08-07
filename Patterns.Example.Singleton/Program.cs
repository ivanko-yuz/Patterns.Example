using System;
using System.Threading;

namespace Patterns.Example.Singleton
{
    /// <summary>
    /// Одинак забезпечує існування єдиного екземпляру класу та єдиного доступу до нього
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            #region ThreadSave
            var logger = ThreadSafeLoggerSingleton.GetInstance();
            HardProcessor proccesso = new HardProcessor(1);
            logger.Log("Hard work started...");
            proccesso.ProcessTo(5);

            Thread.Sleep(1000);

            logger.Log("Hard work finished...");
            Console.ReadKey();
            #endregion

            //var logger = LoggerSingleton.GetInstance();
            //HardProcessor proccessor = new HardProcessor(1);
            //logger.Log("Hard work started...");
            //proccessor.ProcessTo(5);

            //Thread.Sleep(1000);

            //logger.Log("Hard work finished...");

            //Console.ReadKey(); 

        }
    }
}
