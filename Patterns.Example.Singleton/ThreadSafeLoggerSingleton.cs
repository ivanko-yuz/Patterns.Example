
using System;

namespace Patterns.Example.Singleton
{
    public class ThreadSafeLoggerSingleton
    {
        private ThreadSafeLoggerSingleton()
        {
            
        }

        private int _logCount = 0;
        private static ThreadSafeLoggerSingleton _loggerInstance = null;
        private static readonly object locker = new object();

        public static ThreadSafeLoggerSingleton GetInstance()
        {
            lock (locker)
            {
                return _loggerInstance ?? (_loggerInstance = new ThreadSafeLoggerSingleton());
            }
        }

        public void Log(string message)
        {
            Console.WriteLine(_logCount + ": " + message);
            _logCount++;
        }
    }
}
