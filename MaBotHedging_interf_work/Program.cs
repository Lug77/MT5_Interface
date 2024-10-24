using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;
using System.Reflection;

namespace MaBotHedging_interf_work
{
    internal static class Program
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            ConfigData.logger = logger;
            MethodBase method = MethodBase.GetCurrentMethod();

            logger.Info($"{method.Name}: Приложение запущено.");
            if (args.Length != 0)
            {
                ConfigData.file_path = args[0];
                logger.Info($"{method.Name}: Получен параметр {args[0]}");
            }
            else
            {
                logger.Info($"{method.Name}: Запуск без параметров ком строки");
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form2());
        }
    }
}
