using System;
using System.IO;

namespace SecureAppLib
{
    public class Logger
    {
        public static void Log(string message)
        {
            File.AppendAllText("log.txt", $"{DateTime.Now}: {message}\n");
        }

        public static void LogError(Exception ex)
        {
            File.AppendAllText("log.txt", $"{DateTime.Now}: ERROR - {ex.Message}\n");
        }
    }
}