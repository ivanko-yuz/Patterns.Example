using System;

namespace Patterns.Example.Singleton
{
    public class LoggerSingleton
    {
        /// <summary>
        /// Чіткі ознаки Одинака — приватний конструктор та доступ до єдиного, внутрішньо створеного екземпляру, що здійснюється через статичний метод. 
        /// </summary>
        private LoggerSingleton()
        {
        }

        private int _logCount = 0;

        private static LoggerSingleton _loggerSingletonInstance = null;

        public static LoggerSingleton GetInstance()
        {
            return _loggerSingletonInstance ?? (_loggerSingletonInstance = new LoggerSingleton());
        }

        public void Log(String message)
        {
            Console.WriteLine(_logCount + ": " + message);
            _logCount++;
        }
    }
}
