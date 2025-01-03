using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Configuration;
using System.IO;

namespace MaBotHedging_interf_work
{
    public class Logger
    {
        public static string m_prog_name = "MaBotHedging_interf_work";
        public static string m_filename_log = Directory.GetCurrentDirectory() + "//" + m_prog_name + ".log";
        public static string m_file_path = Directory.GetCurrentDirectory() + "//" + "MaBotHedging" + ".txt";
        public static string m_file_path_out = Directory.GetCurrentDirectory() + "//" + "MaBotHedging_out" + ".txt";

        public Logger()
        {
            ControlPath();
        }

        public void ControlPath()
        {
            //если в текущем директории есть "Program Files" выполним поиск пути
            if (m_filename_log.Contains("Program Files"))
            {
                m_filename_log = FindMtGuiController();
                string path_params = m_filename_log.Replace("Libraries", "Files");
                //log-файл пишем в папку Libraries
                m_filename_log += "//" + m_prog_name + ".log";
                //параметры находятся в папке Files
                m_file_path = path_params + "//" + "MaBotHedging" + ".txt";
                m_file_path_out = path_params + "//" + "MaBotHedging_out" + ".txt";
            }
        }

        public string FindMtGuiController()
        {
            string userDirectory = @"C:\Users";
            if (!Directory.Exists(userDirectory))
            {
                userDirectory = @"C:\Пользователи";
            }
            // Получаем все папки пользователей
            string[] userFolders = Directory.GetDirectories(userDirectory);
            foreach (string userFolder in userFolders)
            {
                string appDataPath = Path.Combine(userFolder, "AppData", "Roaming", "MetaQuotes", "Terminal");
                if (Directory.Exists(appDataPath))
                {
                    // Получаем все папки в каталоге Terminal
                    string[] terminalFolders = Directory.GetDirectories(appDataPath);
                    foreach (string terminalFolder in terminalFolders)
                    {
                        string librariesPath = Path.Combine(terminalFolder, "MQL5", "Libraries");
                        if (Directory.Exists(librariesPath))
                        {
                            string dllPath = Path.Combine(librariesPath, m_prog_name + ".exe");
                            if (File.Exists(dllPath))
                            {
                                return librariesPath; // Возвращаем полный путь к папке библиотек
                            }
                        }
                    }
                }
            }
            return null;
        }

        public static void LogMessage(string message)
        {
            // Проверяем, существует ли файл
            if (!File.Exists(m_filename_log))
            {
                // Если файл не существует, создаем его
                using (File.Create(m_filename_log)) { }
            }

            // Получаем текущее время
            string timeStamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            // Формируем строку с временной меткой и сообщением
            string logEntry = $"{timeStamp} - {message}";

            // Добавляем запись в файл
            using (StreamWriter writer = new StreamWriter(m_filename_log, true))
            {
                writer.WriteLine(logEntry);
            }
        }
    }
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MethodBase method = MethodBase.GetCurrentMethod();
            string currentDirectory = Directory.GetCurrentDirectory();
            string msg = $"{Logger.m_prog_name}:{method.Name}: Приложение запущено. Текущий каталог {currentDirectory}";
            //создадим обьект Logger для проверки путей в стат полях
            Logger log_obj = new Logger();
            Logger.LogMessage(msg);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form2());
        }
    }
}
