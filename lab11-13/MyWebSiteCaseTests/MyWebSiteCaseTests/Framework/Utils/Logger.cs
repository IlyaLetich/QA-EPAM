using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebSiteCaseTests.Framework.Utils
{
    public static class Logger
    {
        private static string logFilePath = "log.txt";

        public static void Log(string message)
        {
            string logMessage = $"{DateTime.Now} - {message}";

            try
            {
                using (StreamWriter writer = new StreamWriter(logFilePath, true))
                {
                    writer.WriteLine(logMessage);
                }
                Console.WriteLine(logMessage);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при записи в лог: {ex.Message}");
            }
        }
        public static void ChangeLogFile(string newFilePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(logFilePath, true)) { }
                logFilePath = newFilePath;
                Console.WriteLine($"Файл лога изменен на: {logFilePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при смене файла лога: {ex.Message}");
            }
        }
    }
}
