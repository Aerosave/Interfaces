using System;

namespace Interfaces
{
    // Определение интерфейса для логгирования
    public interface ILogger
    {
        void LogError(string message);
        void LogInfo(string message);
    }

    // Реализация интерфейса ILogger
    public class ConsoleLogger : ILogger
    {
        public void LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public void LogInfo(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
