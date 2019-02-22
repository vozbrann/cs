using System;
using System.IO;
using System.Text;

namespace Practice4.Tools
{
    public static class Logger
    {
        private static readonly string Filepath = Path.Combine(StaticResources.ClientLogDirPath,
            "App" + DateTime.Now.ToString("YYYY_MM_DD") + ".txt");

        private static object _lock = new object();

        private static void CheckAndCreateFile()
        {
            if (!Directory.Exists(StaticResources.ClientLogDirPath))
            {
                Directory.CreateDirectory(StaticResources.ClientLogDirPath);
            }
            if (!File.Exists(Filepath))
            {
                File.Create(Filepath).Close();
            }
        }

        public static void Log(string message)
        {
            lock (_lock)
            {
                StreamWriter writer = null;
                FileStream file = null;
                try
                {
                    CheckAndCreateFile();
                    file = new FileStream(Filepath, FileMode.Append);
                    writer = new StreamWriter(file);
                    writer.WriteLine(DateTime.Now.ToString("HH:mm:ss.ms") + " " + message);
                }
                finally
                {
                    writer?.Close();
                    file?.Close();
                }
            }
        }
        public static void Log(string message, Exception ex)
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(message);
            while (ex != null)
            {
                stringBuilder.AppendLine(ex.Message);
                stringBuilder.AppendLine(ex.StackTrace);
                ex = ex.InnerException;
            }
            Log(stringBuilder.ToString());
        }

        public static void Log(Exception ex)
        {
            var stringBuilder = new StringBuilder();
            while (ex != null)
            {
                stringBuilder.AppendLine(ex.Message);
                stringBuilder.AppendLine(ex.StackTrace);
                ex = ex.InnerException;
            }
            Log(stringBuilder.ToString());
        }
    }
}
