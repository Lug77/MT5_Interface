using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Linq.Expressions;
using NLog;
using System.Reflection;
using System.Windows.Forms;

namespace MaBotHedging_interf_work
{
    public class JsonData
    {
        //вкладка Main
        public string Symb_row_0_main_page { get; set; }
        public string Symb_row_1_main_page { get; set; }
        public string Symb_row_2_main_page { get; set; }
        public string Symb_row_3_main_page { get; set; }
        public string Symb_row_4_main_page { get; set; }
        public string Symb_row_5_main_page { get; set; }
        public string Symb_row_6_main_page { get; set; }
        public string Symb_row_7_main_page { get; set; }
        public string Symb_row_8_main_page { get; set; }
        public string Symb_row_9_main_page { get; set; }
        public string Symb_row_10_main_page { get; set; }
        public string Symb_row_11_main_page { get; set; }
        public string Symb_row_12_main_page { get; set; }
        public string on_funs_out_only_0_main_page { get; set; }
        public string on_funs_out_only_1_main_page { get; set; }
        public string on_funs_out_only_2_main_page { get; set; }
        public string on_funs_out_only_3_main_page { get; set; }
        public string on_funs_out_only_4_main_page { get; set; }
        public string on_funs_out_only_5_main_page { get; set; }
        public string on_funs_out_only_6_main_page { get; set; }
        public string on_funs_out_only_7_main_page { get; set; }
        public string on_funs_out_only_8_main_page { get; set; }
        public string on_funs_out_only_9_main_page { get; set; }
        public string on_funs_out_only_10_main_page { get; set; }
        public string on_funs_out_only_11_main_page { get; set; }
        public string on_funs_out_only_12_main_page { get; set; }
        public string only_long_is_possible_0_main_page { get; set; }
        public string only_long_is_possible_1_main_page { get; set; }
        public string only_long_is_possible_2_main_page { get; set; }
        public string only_long_is_possible_3_main_page { get; set; }
        public string only_long_is_possible_4_main_page { get; set; }
        public string only_long_is_possible_5_main_page { get; set; }
        public string only_long_is_possible_6_main_page { get; set; }
        public string only_long_is_possible_7_main_page { get; set; }
        public string only_long_is_possible_8_main_page { get; set; }
        public string only_long_is_possible_9_main_page { get; set; }
        public string only_long_is_possible_10_main_page { get; set; }
        public string only_long_is_possible_11_main_page { get; set; }
        public string only_long_is_possible_12_main_page { get; set; }
        public string only_short_is_possible_0_main_page { get; set; }
        public string only_short_is_possible_1_main_page { get; set; }
        public string only_short_is_possible_2_main_page { get; set; }
        public string only_short_is_possible_3_main_page { get; set; }
        public string only_short_is_possible_4_main_page { get; set; }
        public string only_short_is_possible_5_main_page { get; set; }
        public string only_short_is_possible_6_main_page { get; set; }
        public string only_short_is_possible_7_main_page { get; set; }
        public string only_short_is_possible_8_main_page { get; set; }
        public string only_short_is_possible_9_main_page { get; set; }
        public string only_short_is_possible_10_main_page { get; set; }
        public string only_short_is_possible_11_main_page { get; set; }
        public string only_short_is_possible_12_main_page { get; set; }
        public string use_filtr_timing_0_main_page { get; set; }
        public string use_filtr_timing_1_main_page { get; set; }
        public string use_filtr_timing_2_main_page { get; set; }
        public string use_filtr_timing_3_main_page { get; set; }
        public string use_filtr_timing_4_main_page { get; set; }
        public string use_filtr_timing_5_main_page { get; set; }
        public string use_filtr_timing_6_main_page { get; set; }
        public string use_filtr_timing_7_main_page { get; set; }
        public string use_filtr_timing_8_main_page { get; set; }
        public string use_filtr_timing_9_main_page { get; set; }
        public string use_filtr_timing_10_main_page { get; set; }
        public string use_filtr_timing_11_main_page { get; set; }
        public string use_filtr_timing_12_main_page { get; set; }
        public string choice_timing_0_main_page { get; set; }
        public string choice_timing_1_main_page { get; set; }
        public string choice_timing_2_main_page { get; set; }
        public string choice_timing_3_main_page { get; set; }
        public string choice_timing_4_main_page { get; set; }
        public string choice_timing_5_main_page { get; set; }
        public string choice_timing_6_main_page { get; set; }
        public string choice_timing_7_main_page { get; set; }
        public string choice_timing_8_main_page { get; set; }
        public string choice_timing_9_main_page { get; set; }
        public string choice_timing_10_main_page { get; set; }
        public string choice_timing_11_main_page { get; set; }
        public string choice_timing_12_main_page { get; set; }
        public string choice_timing_hedge_0_main_page { get; set; }
        public string choice_timing_hedge_1_main_page { get; set; }
        public string choice_timing_hedge_2_main_page { get; set; }
        public string choice_timing_hedge_3_main_page { get; set; }
        public string choice_timing_hedge_4_main_page { get; set; }
        public string choice_timing_hedge_5_main_page { get; set; }
        public string choice_timing_hedge_6_main_page { get; set; }
        public string choice_timing_hedge_7_main_page { get; set; }
        public string choice_timing_hedge_8_main_page { get; set; }
        public string choice_timing_hedge_9_main_page { get; set; }
        public string choice_timing_hedge_10_main_page { get; set; }
        public string choice_timing_hedge_11_main_page { get; set; }
        public string choice_timing_hedge_12_main_page { get; set; }
        public string on_delay_func_minus_0_main_page { get; set; }
        public string on_delay_func_minus_1_main_page { get; set; }
        public string on_delay_func_minus_2_main_page { get; set; }
        public string on_delay_func_minus_3_main_page { get; set; }
        public string on_delay_func_minus_4_main_page { get; set; }
        public string on_delay_func_minus_5_main_page { get; set; }
        public string on_delay_func_minus_6_main_page { get; set; }
        public string on_delay_func_minus_7_main_page { get; set; }
        public string on_delay_func_minus_8_main_page { get; set; }
        public string on_delay_func_minus_9_main_page { get; set; }
        public string on_delay_func_minus_10_main_page { get; set; }
        public string on_delay_func_minus_11_main_page { get; set; }
        public string on_delay_func_minus_12_main_page { get; set; }
        public string series_minus_trades_0_main_page { get; set; }
        public string series_minus_trades_1_main_page { get; set; }
        public string series_minus_trades_2_main_page { get; set; }
        public string series_minus_trades_3_main_page { get; set; }
        public string series_minus_trades_4_main_page { get; set; }
        public string series_minus_trades_5_main_page { get; set; }
        public string series_minus_trades_6_main_page { get; set; }
        public string series_minus_trades_7_main_page { get; set; }
        public string series_minus_trades_8_main_page { get; set; }
        public string series_minus_trades_9_main_page { get; set; }
        public string series_minus_trades_10_main_page { get; set; }
        public string series_minus_trades_11_main_page { get; set; }
        public string series_minus_trades_12_main_page { get; set; }
        public string step_growth_deposit_0_main_page { get; set; }
        public string step_growth_deposit_1_main_page { get; set; }
        public string step_growth_deposit_2_main_page { get; set; }
        public string step_growth_deposit_3_main_page { get; set; }
        public string step_growth_deposit_4_main_page { get; set; }
        public string step_growth_deposit_5_main_page { get; set; }
        public string step_growth_deposit_6_main_page { get; set; }
        public string step_growth_deposit_7_main_page { get; set; }
        public string step_growth_deposit_8_main_page { get; set; }
        public string step_growth_deposit_9_main_page { get; set; }
        public string step_growth_deposit_10_main_page { get; set; }
        public string step_growth_deposit_11_main_page { get; set; }
        public string step_growth_deposit_12_main_page { get; set; }
        public string size_deposit_0_main_page { get; set; }
        public string size_deposit_1_main_page { get; set; }
        public string size_deposit_2_main_page { get; set; }
        public string size_deposit_3_main_page { get; set; }
        public string size_deposit_4_main_page { get; set; }
        public string size_deposit_5_main_page { get; set; }
        public string size_deposit_6_main_page { get; set; }
        public string size_deposit_7_main_page { get; set; }
        public string size_deposit_8_main_page { get; set; }
        public string size_deposit_9_main_page { get; set; }
        public string size_deposit_10_main_page { get; set; }
        public string size_deposit_11_main_page { get; set; }
        public string size_deposit_12_main_page { get; set; }

        //вкладка Индикаторы
        public string Symb_row_0_indicator_page { get; set; }
        public string Symb_row_1_indicator_page { get; set; }
        public string Symb_row_2_indicator_page { get; set; }
        public string Symb_row_3_indicator_page { get; set; }
        public string Symb_row_4_indicator_page { get; set; }
        public string Symb_row_5_indicator_page { get; set; }
        public string Symb_row_6_indicator_page { get; set; }
        public string Symb_row_7_indicator_page { get; set; }
        public string Symb_row_8_indicator_page { get; set; }
        public string Symb_row_9_indicator_page { get; set; }
        public string Symb_row_10_indicator_page { get; set; }
        public string Symb_row_11_indicator_page { get; set; }
        public string Symb_row_12_indicator_page { get; set; }
        public string choice_indicator_in_0_indicator_page { get; set; }
        public string choice_indicator_in_1_indicator_page { get; set; }
        public string choice_indicator_in_2_indicator_page { get; set; }
        public string choice_indicator_in_3_indicator_page { get; set; }
        public string choice_indicator_in_4_indicator_page { get; set; }
        public string choice_indicator_in_5_indicator_page { get; set; }
        public string choice_indicator_in_6_indicator_page { get; set; }
        public string choice_indicator_in_7_indicator_page { get; set; }
        public string choice_indicator_in_8_indicator_page { get; set; }
        public string choice_indicator_in_9_indicator_page { get; set; }
        public string choice_indicator_in_10_indicator_page { get; set; }
        public string choice_indicator_in_11_indicator_page { get; set; }
        public string choice_indicator_in_12_indicator_page { get; set; }
        public string timeframe_indicator_in_0_indicator_page { get; set; }
        public string timeframe_indicator_in_1_indicator_page { get; set; }
        public string timeframe_indicator_in_2_indicator_page { get; set; }
        public string timeframe_indicator_in_3_indicator_page { get; set; }
        public string timeframe_indicator_in_4_indicator_page { get; set; }
        public string timeframe_indicator_in_5_indicator_page { get; set; }
        public string timeframe_indicator_in_6_indicator_page { get; set; }
        public string timeframe_indicator_in_7_indicator_page { get; set; }
        public string timeframe_indicator_in_8_indicator_page { get; set; }
        public string timeframe_indicator_in_9_indicator_page { get; set; }
        public string timeframe_indicator_in_10_indicator_page { get; set; }
        public string timeframe_indicator_in_11_indicator_page { get; set; }
        public string timeframe_indicator_in_12_indicator_page { get; set; }
        public string macd_fast_ema_0_indicator_page { get; set; }
        public string macd_fast_ema_1_indicator_page { get; set; }
        public string macd_fast_ema_2_indicator_page { get; set; }
        public string macd_fast_ema_3_indicator_page { get; set; }
        public string macd_fast_ema_4_indicator_page { get; set; }
        public string macd_fast_ema_5_indicator_page { get; set; }
        public string macd_fast_ema_6_indicator_page { get; set; }
        public string macd_fast_ema_7_indicator_page { get; set; }
        public string macd_fast_ema_8_indicator_page { get; set; }
        public string macd_fast_ema_9_indicator_page { get; set; }
        public string macd_fast_ema_10_indicator_page { get; set; }
        public string macd_fast_ema_11_indicator_page { get; set; }
        public string macd_fast_ema_12_indicator_page { get; set; }
        public string macd_slow_ema_0_indicator_page { get; set; }
        public string macd_slow_ema_1_indicator_page { get; set; }
        public string macd_slow_ema_2_indicator_page { get; set; }
        public string macd_slow_ema_3_indicator_page { get; set; }
        public string macd_slow_ema_4_indicator_page { get; set; }
        public string macd_slow_ema_5_indicator_page { get; set; }
        public string macd_slow_ema_6_indicator_page { get; set; }
        public string macd_slow_ema_7_indicator_page { get; set; }
        public string macd_slow_ema_8_indicator_page { get; set; }
        public string macd_slow_ema_9_indicator_page { get; set; }
        public string macd_slow_ema_10_indicator_page { get; set; }
        public string macd_slow_ema_11_indicator_page { get; set; }
        public string macd_slow_ema_12_indicator_page { get; set; }
        public string macd_signal_period_0_indicator_page { get; set; }
        public string macd_signal_period_1_indicator_page { get; set; }
        public string macd_signal_period_2_indicator_page { get; set; }
        public string macd_signal_period_3_indicator_page { get; set; }
        public string macd_signal_period_4_indicator_page { get; set; }
        public string macd_signal_period_5_indicator_page { get; set; }
        public string macd_signal_period_6_indicator_page { get; set; }
        public string macd_signal_period_7_indicator_page { get; set; }
        public string macd_signal_period_8_indicator_page { get; set; }
        public string macd_signal_period_9_indicator_page { get; set; }
        public string macd_signal_period_10_indicator_page { get; set; }
        public string macd_signal_period_11_indicator_page { get; set; }
        public string macd_signal_period_12_indicator_page { get; set; }
        public string select_signal_macd_0_indicator_page { get; set; }
        public string select_signal_macd_1_indicator_page { get; set; }
        public string select_signal_macd_2_indicator_page { get; set; }
        public string select_signal_macd_3_indicator_page { get; set; }
        public string select_signal_macd_4_indicator_page { get; set; }
        public string select_signal_macd_5_indicator_page { get; set; }
        public string select_signal_macd_6_indicator_page { get; set; }
        public string select_signal_macd_7_indicator_page { get; set; }
        public string select_signal_macd_8_indicator_page { get; set; }
        public string select_signal_macd_9_indicator_page { get; set; }
        public string select_signal_macd_10_indicator_page { get; set; }
        public string select_signal_macd_11_indicator_page { get; set; }
        public string select_signal_macd_12_indicator_page { get; set; }
        public string step_sar_0_indicator_page { get; set; }
        public string step_sar_1_indicator_page { get; set; }
        public string step_sar_2_indicator_page { get; set; }
        public string step_sar_3_indicator_page { get; set; }
        public string step_sar_4_indicator_page { get; set; }
        public string step_sar_5_indicator_page { get; set; }
        public string step_sar_6_indicator_page { get; set; }
        public string step_sar_7_indicator_page { get; set; }
        public string step_sar_8_indicator_page { get; set; }
        public string step_sar_9_indicator_page { get; set; }
        public string step_sar_10_indicator_page { get; set; }
        public string step_sar_11_indicator_page { get; set; }
        public string step_sar_12_indicator_page { get; set; }
        public string max_step_0_indicator_page { get; set; }
        public string max_step_1_indicator_page { get; set; }
        public string max_step_2_indicator_page { get; set; }
        public string max_step_3_indicator_page { get; set; }
        public string max_step_4_indicator_page { get; set; }
        public string max_step_5_indicator_page { get; set; }
        public string max_step_6_indicator_page { get; set; }
        public string max_step_7_indicator_page { get; set; }
        public string max_step_8_indicator_page { get; set; }
        public string max_step_9_indicator_page { get; set; }
        public string max_step_10_indicator_page { get; set; }
        public string max_step_11_indicator_page { get; set; }
        public string max_step_12_indicator_page { get; set; }
        public string select_signal_sar_0_indicator_page { get; set; }
        public string select_signal_sar_1_indicator_page { get; set; }
        public string select_signal_sar_2_indicator_page { get; set; }
        public string select_signal_sar_3_indicator_page { get; set; }
        public string select_signal_sar_4_indicator_page { get; set; }
        public string select_signal_sar_5_indicator_page { get; set; }
        public string select_signal_sar_6_indicator_page { get; set; }
        public string select_signal_sar_7_indicator_page { get; set; }
        public string select_signal_sar_8_indicator_page { get; set; }
        public string select_signal_sar_9_indicator_page { get; set; }
        public string select_signal_sar_10_indicator_page { get; set; }
        public string select_signal_sar_11_indicator_page { get; set; }
        public string select_signal_sar_12_indicator_page { get; set; }
        public string bands_period_0_indicator_page { get; set; }
        public string bands_period_1_indicator_page { get; set; }
        public string bands_period_2_indicator_page { get; set; }
        public string bands_period_3_indicator_page { get; set; }
        public string bands_period_4_indicator_page { get; set; }
        public string bands_period_5_indicator_page { get; set; }
        public string bands_period_6_indicator_page { get; set; }
        public string bands_period_7_indicator_page { get; set; }
        public string bands_period_8_indicator_page { get; set; }
        public string bands_period_9_indicator_page { get; set; }
        public string bands_period_10_indicator_page { get; set; }
        public string bands_period_11_indicator_page { get; set; }
        public string bands_period_12_indicator_page { get; set; }
        public string bands_deviation_0_indicator_page { get; set; }
        public string bands_deviation_1_indicator_page { get; set; }
        public string bands_deviation_2_indicator_page { get; set; }
        public string bands_deviation_3_indicator_page { get; set; }
        public string bands_deviation_4_indicator_page { get; set; }
        public string bands_deviation_5_indicator_page { get; set; }
        public string bands_deviation_6_indicator_page { get; set; }
        public string bands_deviation_7_indicator_page { get; set; }
        public string bands_deviation_8_indicator_page { get; set; }
        public string bands_deviation_9_indicator_page { get; set; }
        public string bands_deviation_10_indicator_page { get; set; }
        public string bands_deviation_11_indicator_page { get; set; }
        public string bands_deviation_12_indicator_page { get; set; }
        public string select_signal_bb_0_indicator_page { get; set; }
        public string select_signal_bb_1_indicator_page { get; set; }
        public string select_signal_bb_2_indicator_page { get; set; }
        public string select_signal_bb_3_indicator_page { get; set; }
        public string select_signal_bb_4_indicator_page { get; set; }
        public string select_signal_bb_5_indicator_page { get; set; }
        public string select_signal_bb_6_indicator_page { get; set; }
        public string select_signal_bb_7_indicator_page { get; set; }
        public string select_signal_bb_8_indicator_page { get; set; }
        public string select_signal_bb_9_indicator_page { get; set; }
        public string select_signal_bb_10_indicator_page { get; set; }
        public string select_signal_bb_11_indicator_page { get; set; }
        public string select_signal_bb_12_indicator_page { get; set; }
    }

    public class ConfigData 
    {
        public static string file_path = "";
        public static Logger logger;
        private Form2 m_form;

        public ConfigData(Form2 form)
        {
            m_form = form;
        }

        public bool ControlFile()
        {
            MethodBase method = MethodBase.GetCurrentMethod();
            if (File.Exists(file_path))
            {
                logger.Info($"{method.Name}: Файл json {file_path} найден");
                return true;
            }
            else
            {
                logger.Info($"{method.Name}: Файл json {file_path} не найден");
                return false;
            }
        }

        public void LoadConfig()
        {
            MethodBase method = MethodBase.GetCurrentMethod();
            if (file_path != "")
            {
                if (!ControlFile()) return;
                try
                {
                    string json;
                    using (var reader = new StreamReader(
                        file_path, Encoding.GetEncoding("windows-1251")))
                    {
                        json = reader.ReadToEnd();
                    }
                    var configData = JsonConvert.DeserializeObject<JsonData>(json);

                    m_form.SymbRow0MainText = configData.Symb_row_0_main_page;
                    m_form.SymbRow1MainText = configData.Symb_row_1_main_page;
                    m_form.SymbRow2MainText = configData.Symb_row_2_main_page;
                    m_form.SymbRow3MainText = configData.Symb_row_3_main_page;
                    m_form.SymbRow4MainText = configData.Symb_row_4_main_page;
                    m_form.SymbRow5MainText = configData.Symb_row_5_main_page;
                    m_form.SymbRow6MainText = configData.Symb_row_6_main_page;
                    m_form.SymbRow7MainText = configData.Symb_row_7_main_page;
                    m_form.SymbRow8MainText = configData.Symb_row_8_main_page;
                    m_form.SymbRow9MainText = configData.Symb_row_9_main_page;
                    m_form.SymbRow10MainText = configData.Symb_row_10_main_page;
                    m_form.SymbRow11MainText = configData.Symb_row_11_main_page;
                    m_form.SymbRow12MainText = configData.Symb_row_12_main_page;
                    m_form.OnlyOutRow0MainChecked = configData.on_funs_out_only_0_main_page;
                    m_form.OnlyOutRow1MainChecked = configData.on_funs_out_only_1_main_page;
                    m_form.OnlyOutRow2MainChecked = configData.on_funs_out_only_2_main_page;
                    m_form.OnlyOutRow3MainChecked = configData.on_funs_out_only_3_main_page;
                    m_form.OnlyOutRow4MainChecked = configData.on_funs_out_only_4_main_page;
                    m_form.OnlyOutRow5MainChecked = configData.on_funs_out_only_5_main_page;
                    m_form.OnlyOutRow6MainChecked = configData.on_funs_out_only_6_main_page;
                    m_form.OnlyOutRow7MainChecked = configData.on_funs_out_only_7_main_page;
                    m_form.OnlyOutRow8MainChecked = configData.on_funs_out_only_8_main_page;
                    m_form.OnlyOutRow9MainChecked = configData.on_funs_out_only_9_main_page;
                    m_form.OnlyOutRow10MainChecked = configData.on_funs_out_only_10_main_page;
                    m_form.OnlyOutRow11MainChecked = configData.on_funs_out_only_11_main_page;
                    m_form.OnlyOutRow12MainChecked = configData.on_funs_out_only_12_main_page;
                    m_form.OnlyLongRow0MainChecked = configData.only_long_is_possible_0_main_page;
                    m_form.OnlyLongRow1MainChecked = configData.only_long_is_possible_1_main_page;
                    m_form.OnlyLongRow2MainChecked = configData.only_long_is_possible_2_main_page;
                    m_form.OnlyLongRow3MainChecked = configData.only_long_is_possible_3_main_page;
                    m_form.OnlyLongRow4MainChecked = configData.only_long_is_possible_4_main_page;
                    m_form.OnlyLongRow5MainChecked = configData.only_long_is_possible_5_main_page;
                    m_form.OnlyLongRow6MainChecked = configData.only_long_is_possible_6_main_page;
                    m_form.OnlyLongRow7MainChecked = configData.only_long_is_possible_7_main_page;
                    m_form.OnlyLongRow8MainChecked = configData.only_long_is_possible_8_main_page;
                    m_form.OnlyLongRow9MainChecked = configData.only_long_is_possible_9_main_page;
                    m_form.OnlyLongRow10MainChecked = configData.only_long_is_possible_10_main_page;
                    m_form.OnlyLongRow11MainChecked = configData.only_long_is_possible_11_main_page;
                    m_form.OnlyLongRow12MainChecked = configData.only_long_is_possible_12_main_page;
                    m_form.OnlyShortRow0MainChecked = configData.only_short_is_possible_0_main_page;
                    m_form.OnlyShortRow1MainChecked = configData.only_short_is_possible_1_main_page;
                    m_form.OnlyShortRow2MainChecked = configData.only_short_is_possible_2_main_page;
                    m_form.OnlyShortRow3MainChecked = configData.only_short_is_possible_3_main_page;
                    m_form.OnlyShortRow4MainChecked = configData.only_short_is_possible_4_main_page;
                    m_form.OnlyShortRow5MainChecked = configData.only_short_is_possible_5_main_page;
                    m_form.OnlyShortRow6MainChecked = configData.only_short_is_possible_6_main_page;
                    m_form.OnlyShortRow7MainChecked = configData.only_short_is_possible_7_main_page;
                    m_form.OnlyShortRow8MainChecked = configData.only_short_is_possible_8_main_page;
                    m_form.OnlyShortRow9MainChecked = configData.only_short_is_possible_9_main_page;
                    m_form.OnlyShortRow10MainChecked = configData.only_short_is_possible_10_main_page;
                    m_form.OnlyShortRow11MainChecked = configData.only_short_is_possible_11_main_page;
                    m_form.OnlyShortRow12MainChecked = configData.only_short_is_possible_12_main_page;
                    m_form.UseTimeFiltrRow0Checked = configData.use_filtr_timing_0_main_page;
                    m_form.UseTimeFiltrRow1Checked = configData.use_filtr_timing_1_main_page;
                    m_form.UseTimeFiltrRow2Checked = configData.use_filtr_timing_2_main_page;
                    m_form.UseTimeFiltrRow3Checked = configData.use_filtr_timing_3_main_page;
                    m_form.UseTimeFiltrRow4Checked = configData.use_filtr_timing_4_main_page;
                    m_form.UseTimeFiltrRow5Checked = configData.use_filtr_timing_5_main_page;
                    m_form.UseTimeFiltrRow6Checked = configData.use_filtr_timing_6_main_page;
                    m_form.UseTimeFiltrRow7Checked = configData.use_filtr_timing_7_main_page;
                    m_form.UseTimeFiltrRow8Checked = configData.use_filtr_timing_8_main_page;
                    m_form.UseTimeFiltrRow9Checked = configData.use_filtr_timing_9_main_page;
                    m_form.UseTimeFiltrRow10Checked = configData.use_filtr_timing_10_main_page;
                    m_form.UseTimeFiltrRow11Checked = configData.use_filtr_timing_11_main_page;
                    m_form.UseTimeFiltrRow12Checked = configData.use_filtr_timing_12_main_page;
                    m_form.CloseAllPosEndTorgRow0Checked = configData.choice_timing_0_main_page;
                    m_form.CloseAllPosEndTorgRow1Checked = configData.choice_timing_1_main_page;
                    m_form.CloseAllPosEndTorgRow2Checked = configData.choice_timing_2_main_page;
                    m_form.CloseAllPosEndTorgRow3Checked = configData.choice_timing_3_main_page;
                    m_form.CloseAllPosEndTorgRow4Checked = configData.choice_timing_4_main_page;
                    m_form.CloseAllPosEndTorgRow5Checked = configData.choice_timing_5_main_page;
                    m_form.CloseAllPosEndTorgRow6Checked = configData.choice_timing_6_main_page;
                    m_form.CloseAllPosEndTorgRow7Checked = configData.choice_timing_7_main_page;
                    m_form.CloseAllPosEndTorgRow8Checked = configData.choice_timing_8_main_page;
                    m_form.CloseAllPosEndTorgRow9Checked = configData.choice_timing_9_main_page;
                    m_form.CloseAllPosEndTorgRow10Checked = configData.choice_timing_10_main_page;
                    m_form.CloseAllPosEndTorgRow11Checked = configData.choice_timing_11_main_page;
                    m_form.CloseAllPosEndTorgRow12Checked = configData.choice_timing_12_main_page;
                    m_form.DelNoPairOrdEndTorgRow0Checked = configData.choice_timing_hedge_0_main_page;
                    m_form.DelNoPairOrdEndTorgRow1Checked = configData.choice_timing_hedge_1_main_page;
                    m_form.DelNoPairOrdEndTorgRow2Checked = configData.choice_timing_hedge_2_main_page;
                    m_form.DelNoPairOrdEndTorgRow3Checked = configData.choice_timing_hedge_3_main_page;
                    m_form.DelNoPairOrdEndTorgRow4Checked = configData.choice_timing_hedge_4_main_page;
                    m_form.DelNoPairOrdEndTorgRow5Checked = configData.choice_timing_hedge_5_main_page;
                    m_form.DelNoPairOrdEndTorgRow6Checked = configData.choice_timing_hedge_6_main_page;
                    m_form.DelNoPairOrdEndTorgRow7Checked = configData.choice_timing_hedge_7_main_page;
                    m_form.DelNoPairOrdEndTorgRow8Checked = configData.choice_timing_hedge_8_main_page;
                    m_form.DelNoPairOrdEndTorgRow9Checked = configData.choice_timing_hedge_9_main_page;
                    m_form.DelNoPairOrdEndTorgRow10Checked = configData.choice_timing_hedge_10_main_page;
                    m_form.DelNoPairOrdEndTorgRow11Checked = configData.choice_timing_hedge_11_main_page;
                    m_form.DelNoPairOrdEndTorgRow12Checked = configData.choice_timing_hedge_12_main_page;
                    m_form.OnDelayOtkupRow0Checked = configData.on_delay_func_minus_0_main_page;
                    m_form.OnDelayOtkupRow1Checked = configData.on_delay_func_minus_1_main_page;
                    m_form.OnDelayOtkupRow2Checked = configData.on_delay_func_minus_2_main_page;
                    m_form.OnDelayOtkupRow3Checked = configData.on_delay_func_minus_3_main_page;
                    m_form.OnDelayOtkupRow4Checked = configData.on_delay_func_minus_4_main_page;
                    m_form.OnDelayOtkupRow5Checked = configData.on_delay_func_minus_5_main_page;
                    m_form.OnDelayOtkupRow6Checked = configData.on_delay_func_minus_6_main_page;
                    m_form.OnDelayOtkupRow7Checked = configData.on_delay_func_minus_7_main_page;
                    m_form.OnDelayOtkupRow8Checked = configData.on_delay_func_minus_8_main_page;
                    m_form.OnDelayOtkupRow9Checked = configData.on_delay_func_minus_9_main_page;
                    m_form.OnDelayOtkupRow10Checked = configData.on_delay_func_minus_10_main_page;
                    m_form.OnDelayOtkupRow11Checked = configData.on_delay_func_minus_11_main_page;
                    m_form.OnDelayOtkupRow12Checked = configData.on_delay_func_minus_12_main_page;
                    m_form.SeriesMinusDealRow0Text = configData.series_minus_trades_0_main_page;
                    m_form.SeriesMinusDealRow1Text = configData.series_minus_trades_1_main_page;
                    m_form.SeriesMinusDealRow2Text = configData.series_minus_trades_2_main_page;
                    m_form.SeriesMinusDealRow3Text = configData.series_minus_trades_3_main_page;
                    m_form.SeriesMinusDealRow4Text = configData.series_minus_trades_4_main_page;
                    m_form.SeriesMinusDealRow5Text = configData.series_minus_trades_5_main_page;
                    m_form.SeriesMinusDealRow6Text = configData.series_minus_trades_6_main_page;
                    m_form.SeriesMinusDealRow7Text = configData.series_minus_trades_7_main_page;
                    m_form.SeriesMinusDealRow8Text = configData.series_minus_trades_8_main_page;
                    m_form.SeriesMinusDealRow9Text = configData.series_minus_trades_9_main_page;
                    m_form.SeriesMinusDealRow10Text = configData.series_minus_trades_10_main_page;
                    m_form.SeriesMinusDealRow11Text = configData.series_minus_trades_11_main_page;
                    m_form.SeriesMinusDealRow12Text = configData.series_minus_trades_12_main_page;
                    m_form.StepAddDepositRow0Text = configData.step_growth_deposit_0_main_page;
                    m_form.StepAddDepositRow1Text = configData.step_growth_deposit_1_main_page;
                    m_form.StepAddDepositRow2Text = configData.step_growth_deposit_2_main_page;
                    m_form.StepAddDepositRow3Text = configData.step_growth_deposit_3_main_page;
                    m_form.StepAddDepositRow4Text = configData.step_growth_deposit_4_main_page;
                    m_form.StepAddDepositRow5Text = configData.step_growth_deposit_5_main_page;
                    m_form.StepAddDepositRow6Text = configData.step_growth_deposit_6_main_page;
                    m_form.StepAddDepositRow7Text = configData.step_growth_deposit_7_main_page;
                    m_form.StepAddDepositRow8Text = configData.step_growth_deposit_8_main_page;
                    m_form.StepAddDepositRow9Text = configData.step_growth_deposit_9_main_page;
                    m_form.StepAddDepositRow10Text = configData.step_growth_deposit_10_main_page;
                    m_form.StepAddDepositRow11Text = configData.step_growth_deposit_11_main_page;
                    m_form.StepAddDepositRow12Text = configData.step_growth_deposit_12_main_page;
                    m_form.SizeDepositRow0Text = configData.size_deposit_0_main_page;
                    m_form.SizeDepositRow1Text = configData.size_deposit_1_main_page;
                    m_form.SizeDepositRow2Text = configData.size_deposit_2_main_page;
                    m_form.SizeDepositRow3Text = configData.size_deposit_3_main_page;
                    m_form.SizeDepositRow4Text = configData.size_deposit_4_main_page;
                    m_form.SizeDepositRow5Text = configData.size_deposit_5_main_page;
                    m_form.SizeDepositRow6Text = configData.size_deposit_6_main_page;
                    m_form.SizeDepositRow7Text = configData.size_deposit_7_main_page;
                    m_form.SizeDepositRow8Text = configData.size_deposit_8_main_page;
                    m_form.SizeDepositRow9Text = configData.size_deposit_9_main_page;
                    m_form.SizeDepositRow10Text = configData.size_deposit_10_main_page;
                    m_form.SizeDepositRow11Text = configData.size_deposit_11_main_page;
                    m_form.SizeDepositRow12Text = configData.size_deposit_12_main_page;
                    m_form.SymbRow0IndText = configData.Symb_row_0_indicator_page;
                    m_form.SymbRow1IndText = configData.Symb_row_1_indicator_page;
                    m_form.SymbRow2IndText = configData.Symb_row_2_indicator_page;
                    m_form.SymbRow3IndText = configData.Symb_row_3_indicator_page;
                    m_form.SymbRow4IndText = configData.Symb_row_4_indicator_page;
                    m_form.SymbRow5IndText = configData.Symb_row_5_indicator_page;
                    m_form.SymbRow6IndText = configData.Symb_row_6_indicator_page;
                    m_form.SymbRow7IndText = configData.Symb_row_7_indicator_page;
                    m_form.SymbRow8IndText = configData.Symb_row_8_indicator_page;
                    m_form.SymbRow9IndText = configData.Symb_row_9_indicator_page;
                    m_form.SymbRow10IndText = configData.Symb_row_10_indicator_page;
                    m_form.SymbRow11IndText = configData.Symb_row_11_indicator_page;
                    m_form.SymbRow12IndText = configData.Symb_row_12_indicator_page;
                    m_form.ChoiceIndRow0Item = configData.choice_indicator_in_0_indicator_page;
                    m_form.ChoiceIndRow1Item = configData.choice_indicator_in_1_indicator_page;
                    m_form.ChoiceIndRow2Item = configData.choice_indicator_in_2_indicator_page;
                    m_form.ChoiceIndRow3Item = configData.choice_indicator_in_3_indicator_page;
                    m_form.ChoiceIndRow4Item = configData.choice_indicator_in_4_indicator_page;
                    m_form.ChoiceIndRow5Item = configData.choice_indicator_in_5_indicator_page;
                    m_form.ChoiceIndRow6Item = configData.choice_indicator_in_6_indicator_page;
                    m_form.ChoiceIndRow7Item = configData.choice_indicator_in_7_indicator_page;
                    m_form.ChoiceIndRow8Item = configData.choice_indicator_in_8_indicator_page;
                    m_form.ChoiceIndRow9Item = configData.choice_indicator_in_9_indicator_page;
                    m_form.ChoiceIndRow10Item = configData.choice_indicator_in_10_indicator_page;
                    m_form.ChoiceIndRow11Item = configData.choice_indicator_in_11_indicator_page;
                    m_form.ChoiceIndRow12Item = configData.choice_indicator_in_12_indicator_page;
                    m_form.ChoicePerRow0Item = configData.timeframe_indicator_in_0_indicator_page;
                    m_form.ChoicePerRow1Item = configData.timeframe_indicator_in_1_indicator_page;
                    m_form.ChoicePerRow2Item = configData.timeframe_indicator_in_2_indicator_page;
                    m_form.ChoicePerRow3Item = configData.timeframe_indicator_in_3_indicator_page;
                    m_form.ChoicePerRow4Item = configData.timeframe_indicator_in_4_indicator_page;
                    m_form.ChoicePerRow5Item = configData.timeframe_indicator_in_5_indicator_page;
                    m_form.ChoicePerRow6Item = configData.timeframe_indicator_in_6_indicator_page;
                    m_form.ChoicePerRow7Item = configData.timeframe_indicator_in_7_indicator_page;
                    m_form.ChoicePerRow8Item = configData.timeframe_indicator_in_8_indicator_page;
                    m_form.ChoicePerRow9Item = configData.timeframe_indicator_in_9_indicator_page;
                    m_form.ChoicePerRow10Item = configData.timeframe_indicator_in_10_indicator_page;
                    m_form.ChoicePerRow11Item = configData.timeframe_indicator_in_11_indicator_page;
                    m_form.ChoicePerRow12Item = configData.timeframe_indicator_in_12_indicator_page;
                    m_form.MacdPerFastRow0Text = configData.macd_fast_ema_0_indicator_page;
                    m_form.MacdPerFastRow1Text = configData.macd_fast_ema_1_indicator_page;
                    m_form.MacdPerFastRow2Text = configData.macd_fast_ema_2_indicator_page;
                    m_form.MacdPerFastRow3Text = configData.macd_fast_ema_3_indicator_page;
                    m_form.MacdPerFastRow4Text = configData.macd_fast_ema_4_indicator_page;
                    m_form.MacdPerFastRow5Text = configData.macd_fast_ema_5_indicator_page;
                    m_form.MacdPerFastRow6Text = configData.macd_fast_ema_6_indicator_page;
                    m_form.MacdPerFastRow7Text = configData.macd_fast_ema_7_indicator_page;
                    m_form.MacdPerFastRow8Text = configData.macd_fast_ema_8_indicator_page;
                    m_form.MacdPerFastRow9Text = configData.macd_fast_ema_9_indicator_page;
                    m_form.MacdPerFastRow10Text = configData.macd_fast_ema_10_indicator_page;
                    m_form.MacdPerFastRow11Text = configData.macd_fast_ema_11_indicator_page;
                    m_form.MacdPerFastRow12Text = configData.macd_fast_ema_12_indicator_page;
                    m_form.MacdPerMidRow0Text = configData.macd_slow_ema_0_indicator_page;
                    m_form.MacdPerMidRow1Text = configData.macd_slow_ema_1_indicator_page;
                    m_form.MacdPerMidRow2Text = configData.macd_slow_ema_2_indicator_page;
                    m_form.MacdPerMidRow3Text = configData.macd_slow_ema_3_indicator_page;
                    m_form.MacdPerMidRow4Text = configData.macd_slow_ema_4_indicator_page;
                    m_form.MacdPerMidRow5Text = configData.macd_slow_ema_5_indicator_page;
                    m_form.MacdPerMidRow6Text = configData.macd_slow_ema_6_indicator_page;
                    m_form.MacdPerMidRow7Text = configData.macd_slow_ema_7_indicator_page;
                    m_form.MacdPerMidRow8Text = configData.macd_slow_ema_8_indicator_page;
                    m_form.MacdPerMidRow9Text = configData.macd_slow_ema_9_indicator_page;
                    m_form.MacdPerMidRow10Text = configData.macd_slow_ema_10_indicator_page;
                    m_form.MacdPerMidRow11Text = configData.macd_slow_ema_11_indicator_page;
                    m_form.MacdPerMidRow12Text = configData.macd_slow_ema_12_indicator_page;
                    m_form.MacdPerSlowRow0Text = configData.macd_signal_period_0_indicator_page;
                    m_form.MacdPerSlowRow1Text = configData.macd_signal_period_1_indicator_page;
                    m_form.MacdPerSlowRow2Text = configData.macd_signal_period_2_indicator_page;
                    m_form.MacdPerSlowRow3Text = configData.macd_signal_period_3_indicator_page;
                    m_form.MacdPerSlowRow4Text = configData.macd_signal_period_4_indicator_page;
                    m_form.MacdPerSlowRow5Text = configData.macd_signal_period_5_indicator_page;
                    m_form.MacdPerSlowRow6Text = configData.macd_signal_period_6_indicator_page;
                    m_form.MacdPerSlowRow7Text = configData.macd_signal_period_7_indicator_page;
                    m_form.MacdPerSlowRow8Text = configData.macd_signal_period_8_indicator_page;
                    m_form.MacdPerSlowRow9Text = configData.macd_signal_period_9_indicator_page;
                    m_form.MacdPerSlowRow10Text = configData.macd_signal_period_10_indicator_page;
                    m_form.MacdPerSlowRow11Text = configData.macd_signal_period_11_indicator_page;
                    m_form.MacdPerSlowRow12Text = configData.macd_signal_period_12_indicator_page;
                    m_form.MacdSigRow0Item = configData.select_signal_macd_0_indicator_page;
                    m_form.MacdSigRow1Item = configData.select_signal_macd_1_indicator_page;
                    m_form.MacdSigRow2Item = configData.select_signal_macd_2_indicator_page;
                    m_form.MacdSigRow3Item = configData.select_signal_macd_3_indicator_page;
                    m_form.MacdSigRow4Item = configData.select_signal_macd_4_indicator_page;
                    m_form.MacdSigRow5Item = configData.select_signal_macd_5_indicator_page;
                    m_form.MacdSigRow6Item = configData.select_signal_macd_6_indicator_page;
                    m_form.MacdSigRow7Item = configData.select_signal_macd_7_indicator_page;
                    m_form.MacdSigRow8Item = configData.select_signal_macd_8_indicator_page;
                    m_form.MacdSigRow9Item = configData.select_signal_macd_9_indicator_page;
                    m_form.MacdSigRow10Item = configData.select_signal_macd_10_indicator_page;
                    m_form.MacdSigRow11Item = configData.select_signal_macd_11_indicator_page;
                    m_form.MacdSigRow12Item = configData.select_signal_macd_12_indicator_page;
                    m_form.SarStepRow0Text = configData.step_sar_0_indicator_page;
                    m_form.SarStepRow1Text = configData.step_sar_1_indicator_page;
                    m_form.SarStepRow2Text = configData.step_sar_2_indicator_page;
                    m_form.SarStepRow3Text = configData.step_sar_3_indicator_page;
                    m_form.SarStepRow4Text = configData.step_sar_4_indicator_page;
                    m_form.SarStepRow5Text = configData.step_sar_5_indicator_page;
                    m_form.SarStepRow6Text = configData.step_sar_6_indicator_page;
                    m_form.SarStepRow7Text = configData.step_sar_7_indicator_page;
                    m_form.SarStepRow8Text = configData.step_sar_8_indicator_page;
                    m_form.SarStepRow9Text = configData.step_sar_9_indicator_page;
                    m_form.SarStepRow10Text = configData.step_sar_10_indicator_page;
                    m_form.SarStepRow11Text = configData.step_sar_11_indicator_page;
                    m_form.SarStepRow12Text = configData.step_sar_12_indicator_page;
                    m_form.SarMaxStepRow0Text = configData.max_step_0_indicator_page;
                    m_form.SarMaxStepRow1Text = configData.max_step_1_indicator_page;
                    m_form.SarMaxStepRow2Text = configData.max_step_2_indicator_page;
                    m_form.SarMaxStepRow3Text = configData.max_step_3_indicator_page;
                    m_form.SarMaxStepRow4Text = configData.max_step_4_indicator_page;
                    m_form.SarMaxStepRow5Text = configData.max_step_5_indicator_page;
                    m_form.SarMaxStepRow6Text = configData.max_step_6_indicator_page;
                    m_form.SarMaxStepRow7Text = configData.max_step_7_indicator_page;
                    m_form.SarMaxStepRow8Text = configData.max_step_8_indicator_page;
                    m_form.SarMaxStepRow9Text = configData.max_step_9_indicator_page;
                    m_form.SarMaxStepRow10Text = configData.max_step_10_indicator_page;
                    m_form.SarMaxStepRow11Text = configData.max_step_11_indicator_page;
                    m_form.SarMaxStepRow12Text = configData.max_step_12_indicator_page;
                    m_form.SarSigRow0Item = configData.select_signal_sar_0_indicator_page;
                    m_form.SarSigRow1Item = configData.select_signal_sar_1_indicator_page;
                    m_form.SarSigRow2Item = configData.select_signal_sar_2_indicator_page;
                    m_form.SarSigRow3Item = configData.select_signal_sar_3_indicator_page;
                    m_form.SarSigRow4Item = configData.select_signal_sar_4_indicator_page;
                    m_form.SarSigRow5Item = configData.select_signal_sar_5_indicator_page;
                    m_form.SarSigRow6Item = configData.select_signal_sar_6_indicator_page;
                    m_form.SarSigRow7Item = configData.select_signal_sar_7_indicator_page;
                    m_form.SarSigRow8Item = configData.select_signal_sar_8_indicator_page;
                    m_form.SarSigRow9Item = configData.select_signal_sar_9_indicator_page;
                    m_form.SarSigRow10Item = configData.select_signal_sar_10_indicator_page;
                    m_form.SarSigRow11Item = configData.select_signal_sar_11_indicator_page;
                    m_form.SarSigRow12Item = configData.select_signal_sar_12_indicator_page;
                    m_form.BbPerMaRow0Text = configData.bands_period_0_indicator_page;
                    m_form.BbPerMaRow1Text = configData.bands_period_1_indicator_page;
                    m_form.BbPerMaRow2Text = configData.bands_period_2_indicator_page;
                    m_form.BbPerMaRow3Text = configData.bands_period_3_indicator_page;
                    m_form.BbPerMaRow4Text = configData.bands_period_4_indicator_page;
                    m_form.BbPerMaRow5Text = configData.bands_period_5_indicator_page;
                    m_form.BbPerMaRow6Text = configData.bands_period_6_indicator_page;
                    m_form.BbPerMaRow7Text = configData.bands_period_7_indicator_page;
                    m_form.BbPerMaRow8Text = configData.bands_period_8_indicator_page;
                    m_form.BbPerMaRow9Text = configData.bands_period_9_indicator_page;
                    m_form.BbPerMaRow10Text = configData.bands_period_10_indicator_page;
                    m_form.BbPerMaRow11Text = configData.bands_period_11_indicator_page;
                    m_form.BbPerMaRow12Text = configData.bands_period_12_indicator_page;
                    m_form.BbDevRow0Text = configData.bands_deviation_0_indicator_page;
                    m_form.BbDevRow1Text = configData.bands_deviation_1_indicator_page;
                    m_form.BbDevRow2Text = configData.bands_deviation_2_indicator_page;
                    m_form.BbDevRow3Text = configData.bands_deviation_3_indicator_page;
                    m_form.BbDevRow4Text = configData.bands_deviation_4_indicator_page;
                    m_form.BbDevRow5Text = configData.bands_deviation_5_indicator_page;
                    m_form.BbDevRow6Text = configData.bands_deviation_6_indicator_page;
                    m_form.BbDevRow7Text = configData.bands_deviation_7_indicator_page;
                    m_form.BbDevRow8Text = configData.bands_deviation_8_indicator_page;
                    m_form.BbDevRow9Text = configData.bands_deviation_9_indicator_page;
                    m_form.BbDevRow10Text = configData.bands_deviation_10_indicator_page;
                    m_form.BbDevRow11Text = configData.bands_deviation_11_indicator_page;
                    m_form.BbDevRow12Text = configData.bands_deviation_12_indicator_page;
                    m_form.BbSigRow0Item = configData.select_signal_bb_0_indicator_page;
                    m_form.BbSigRow1Item = configData.select_signal_bb_1_indicator_page;
                    m_form.BbSigRow2Item = configData.select_signal_bb_2_indicator_page;
                    m_form.BbSigRow3Item = configData.select_signal_bb_3_indicator_page;
                    m_form.BbSigRow4Item = configData.select_signal_bb_4_indicator_page;
                    m_form.BbSigRow5Item = configData.select_signal_bb_5_indicator_page;
                    m_form.BbSigRow6Item = configData.select_signal_bb_6_indicator_page;
                    m_form.BbSigRow7Item = configData.select_signal_bb_7_indicator_page;
                    m_form.BbSigRow8Item = configData.select_signal_bb_8_indicator_page;
                    m_form.BbSigRow9Item = configData.select_signal_bb_9_indicator_page;
                    m_form.BbSigRow10Item = configData.select_signal_bb_10_indicator_page;
                    m_form.BbSigRow11Item = configData.select_signal_bb_11_indicator_page;
                    m_form.BbSigRow12Item = configData.select_signal_bb_12_indicator_page;
                }
                catch ( Exception ex )
                {
                    Console.WriteLine(ex.Message );
                }
            }
        }
    }
}
