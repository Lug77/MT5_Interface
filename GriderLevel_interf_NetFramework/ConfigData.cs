using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GriderLevel_interf_NetFramework
{
    public class ConfigData
    {
        private Form1 m_form;

        public ConfigData(Form1 form)
        {
            m_form = form;
            //создадим обьект Logger для проверки путей в стат полях
            Logger log_obj = new Logger();
        }
        public bool ControlFile()
        {
            MethodBase method = MethodBase.GetCurrentMethod();
            if (File.Exists(Logger.m_filename_params))
            {
                string msg = $"{Logger.m_prog_name}:{method.Name}: Файл параметров {Logger.m_filename_params} найден";
                Logger.LogMessage(msg);
                return true;
            }
            else
            {
                string msg = $"{Logger.m_prog_name}:{method.Name}: Файл параметров {Logger.m_filename_params} не найден";
                Logger.LogMessage(msg);
                return false;
            }
        }
        public void ReadAndParseFile(ref List<double> numbers)
        {
            MethodBase method = MethodBase.GetCurrentMethod();
            // Используем культуру, где точка является десятичным разделителем
            CultureInfo culture = new CultureInfo("en-US");
            using (StreamReader reader = new StreamReader(Logger.m_filename_params))
            {
                string line = reader.ReadLine();
                if (line != null)
                {
                    string[] parts = line.Split('|');
                    foreach (var part in parts)
                    {
                        
                        //if (double.TryParse(part.Trim(), out double number))
                        if (double.TryParse(part, NumberStyles.Any, culture, out double number))
                        {
                            numbers.Add(number);
                        }
                        else
                        {
                            string msg = $"{Logger.m_prog_name}:{method.Name}: Не удалось преобразовать '{part}' в число.";
                            Logger.LogMessage(msg);
                        }
                    }
                }
                else
                {
                    string msg = $"{Logger.m_prog_name}:{method.Name}: Файл параметров {Logger.m_filename_params} пустой";
                    Logger.LogMessage(msg);
                }
            }
        }
        public void InitializeNumericUpDown()
        {
            MethodBase method = MethodBase.GetCurrentMethod();
            //string msg = $"{Logger.m_prog_name}:{method.Name}: Приложение запущено. Текущий каталог {Directory.GetCurrentDirectory()}";
            //Logger.LogMessage(msg);
            //читаем установочные параметры из файла
            if (Logger.m_filename_params != "")
            {
                if (!ControlFile()) return;
                List<double> gui_params = new List<double>();
                try
                {
                    ReadAndParseFile(ref gui_params);
                    //парметры
                    /*
                       double m_start_value_take;
                       double m_step_take;
                       double m_start_value_stop;
                       double m_step_stop;
                       double m_start_value_volume;
                       double m_step_volume;                     
                    */
                    m_form.NumericUpDownTpValue = (decimal)gui_params[0];
                    m_form.NumericUpDownTpIncrement = (decimal)gui_params[1];
                    m_form.NumericUpDownSlValue = (decimal)gui_params[2];
                    m_form.NumericUpDownSlIncrement = (decimal)gui_params[3];
                    m_form.NumericUpDownVolValue = (decimal)gui_params[4];
                    m_form.NumericUpDownVolIncrement = (decimal)gui_params[5];
                }
                catch (Exception ex)
                {
                    string msg = $"{Logger.m_prog_name}:{method.Name}: Произошла ошибка: {ex.Message}";
                    Logger.LogMessage(msg);
                }
            }
        }
    }
}
