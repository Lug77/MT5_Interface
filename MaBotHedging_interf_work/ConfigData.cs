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

        //вкладка Главный ордер
        public string Symb_row_0_main_order_page { get; set; }
        public string Symb_row_1_main_order_page { get; set; }
        public string Symb_row_2_main_order_page { get; set; }
        public string Symb_row_3_main_order_page { get; set; }
        public string Symb_row_4_main_order_page { get; set; }
        public string Symb_row_5_main_order_page { get; set; }
        public string Symb_row_6_main_order_page { get; set; }
        public string Symb_row_7_main_order_page { get; set; }
        public string Symb_row_8_main_order_page { get; set; }
        public string Symb_row_9_main_order_page { get; set; }
        public string Symb_row_10_main_order_page { get; set; }
        public string Symb_row_11_main_order_page { get; set; }
        public string Symb_row_12_main_order_page { get; set; }
        public string open_main_order_0_main_order_page { get; set; }
        public string open_main_order_1_main_order_page { get; set; }
        public string open_main_order_2_main_order_page { get; set; }
        public string open_main_order_3_main_order_page { get; set; }
        public string open_main_order_4_main_order_page { get; set; }
        public string open_main_order_5_main_order_page { get; set; }
        public string open_main_order_6_main_order_page { get; set; }
        public string open_main_order_7_main_order_page { get; set; }
        public string open_main_order_8_main_order_page { get; set; }
        public string open_main_order_9_main_order_page { get; set; }
        public string open_main_order_10_main_order_page { get; set; }
        public string open_main_order_11_main_order_page { get; set; }
        public string open_main_order_12_main_order_page { get; set; }
        public string choice_bar_in_0_main_order_page { get; set; }
        public string choice_bar_in_1_main_order_page { get; set; }
        public string choice_bar_in_2_main_order_page { get; set; }
        public string choice_bar_in_3_main_order_page { get; set; }
        public string choice_bar_in_4_main_order_page { get; set; }
        public string choice_bar_in_5_main_order_page { get; set; }
        public string choice_bar_in_6_main_order_page { get; set; }
        public string choice_bar_in_7_main_order_page { get; set; }
        public string choice_bar_in_8_main_order_page { get; set; }
        public string choice_bar_in_9_main_order_page { get; set; }
        public string choice_bar_in_10_main_order_page { get; set; }
        public string choice_bar_in_11_main_order_page { get; set; }
        public string choice_bar_in_12_main_order_page { get; set; }
        public string on_func_ignor_signal_0_main_order_page { get; set; }
        public string on_func_ignor_signal_1_main_order_page { get; set; }
        public string on_func_ignor_signal_2_main_order_page { get; set; }
        public string on_func_ignor_signal_3_main_order_page { get; set; }
        public string on_func_ignor_signal_4_main_order_page { get; set; }
        public string on_func_ignor_signal_5_main_order_page { get; set; }
        public string on_func_ignor_signal_6_main_order_page { get; set; }
        public string on_func_ignor_signal_7_main_order_page { get; set; }
        public string on_func_ignor_signal_8_main_order_page { get; set; }
        public string on_func_ignor_signal_9_main_order_page { get; set; }
        public string on_func_ignor_signal_10_main_order_page { get; set; }
        public string on_func_ignor_signal_11_main_order_page { get; set; }
        public string on_func_ignor_signal_12_main_order_page { get; set; }
        public string quantity_bar_ignor_0_main_order_page { get; set; }
        public string quantity_bar_ignor_1_main_order_page { get; set; }
        public string quantity_bar_ignor_2_main_order_page { get; set; }
        public string quantity_bar_ignor_3_main_order_page { get; set; }
        public string quantity_bar_ignor_4_main_order_page { get; set; }
        public string quantity_bar_ignor_5_main_order_page { get; set; }
        public string quantity_bar_ignor_6_main_order_page { get; set; }
        public string quantity_bar_ignor_7_main_order_page { get; set; }
        public string quantity_bar_ignor_8_main_order_page { get; set; }
        public string quantity_bar_ignor_9_main_order_page { get; set; }
        public string quantity_bar_ignor_10_main_order_page { get; set; }
        public string quantity_bar_ignor_11_main_order_page { get; set; }
        public string quantity_bar_ignor_12_main_order_page { get; set; }
        public string on_func_fix_deal_on_bar_0_main_order_page { get; set; }
        public string on_func_fix_deal_on_bar_1_main_order_page { get; set; }
        public string on_func_fix_deal_on_bar_2_main_order_page { get; set; }
        public string on_func_fix_deal_on_bar_3_main_order_page { get; set; }
        public string on_func_fix_deal_on_bar_4_main_order_page { get; set; }
        public string on_func_fix_deal_on_bar_5_main_order_page { get; set; }
        public string on_func_fix_deal_on_bar_6_main_order_page { get; set; }
        public string on_func_fix_deal_on_bar_7_main_order_page { get; set; }
        public string on_func_fix_deal_on_bar_8_main_order_page { get; set; }
        public string on_func_fix_deal_on_bar_9_main_order_page { get; set; }
        public string on_func_fix_deal_on_bar_10_main_order_page { get; set; }
        public string on_func_fix_deal_on_bar_11_main_order_page { get; set; }
        public string on_func_fix_deal_on_bar_12_main_order_page { get; set; }
        public string quantity_deals_on_bar_0_main_order_page { get; set; }
        public string quantity_deals_on_bar_1_main_order_page { get; set; }
        public string quantity_deals_on_bar_2_main_order_page { get; set; }
        public string quantity_deals_on_bar_3_main_order_page { get; set; }
        public string quantity_deals_on_bar_4_main_order_page { get; set; }
        public string quantity_deals_on_bar_5_main_order_page { get; set; }
        public string quantity_deals_on_bar_6_main_order_page { get; set; }
        public string quantity_deals_on_bar_7_main_order_page { get; set; }
        public string quantity_deals_on_bar_8_main_order_page { get; set; }
        public string quantity_deals_on_bar_9_main_order_page { get; set; }
        public string quantity_deals_on_bar_10_main_order_page { get; set; }
        public string quantity_deals_on_bar_11_main_order_page { get; set; }
        public string quantity_deals_on_bar_12_main_order_page { get; set; }
        public string on_func_use_signal_for_out_0_main_order_page { get; set; }
        public string on_func_use_signal_for_out_1_main_order_page { get; set; }
        public string on_func_use_signal_for_out_2_main_order_page { get; set; }
        public string on_func_use_signal_for_out_3_main_order_page { get; set; }
        public string on_func_use_signal_for_out_4_main_order_page { get; set; }
        public string on_func_use_signal_for_out_5_main_order_page { get; set; }
        public string on_func_use_signal_for_out_6_main_order_page { get; set; }
        public string on_func_use_signal_for_out_7_main_order_page { get; set; }
        public string on_func_use_signal_for_out_8_main_order_page { get; set; }
        public string on_func_use_signal_for_out_9_main_order_page { get; set; }
        public string on_func_use_signal_for_out_10_main_order_page { get; set; }
        public string on_func_use_signal_for_out_11_main_order_page { get; set; }
        public string on_func_use_signal_for_out_12_main_order_page { get; set; }
        public string choice_bar_out_0_main_order_page { get; set; }
        public string choice_bar_out_1_main_order_page { get; set; }
        public string choice_bar_out_2_main_order_page { get; set; }
        public string choice_bar_out_3_main_order_page { get; set; }
        public string choice_bar_out_4_main_order_page { get; set; }
        public string choice_bar_out_5_main_order_page { get; set; }
        public string choice_bar_out_6_main_order_page { get; set; }
        public string choice_bar_out_7_main_order_page { get; set; }
        public string choice_bar_out_8_main_order_page { get; set; }
        public string choice_bar_out_9_main_order_page { get; set; }
        public string choice_bar_out_10_main_order_page { get; set; }
        public string choice_bar_out_11_main_order_page { get; set; }
        public string choice_bar_out_12_main_order_page { get; set; }
        public string fix_volume_0_main_order_page { get; set; }
        public string fix_volume_1_main_order_page { get; set; }
        public string fix_volume_2_main_order_page { get; set; }
        public string fix_volume_3_main_order_page { get; set; }
        public string fix_volume_4_main_order_page { get; set; }
        public string fix_volume_5_main_order_page { get; set; }
        public string fix_volume_6_main_order_page { get; set; }
        public string fix_volume_7_main_order_page { get; set; }
        public string fix_volume_8_main_order_page { get; set; }
        public string fix_volume_9_main_order_page { get; set; }
        public string fix_volume_10_main_order_page { get; set; }
        public string fix_volume_11_main_order_page { get; set; }
        public string fix_volume_12_main_order_page { get; set; }
        public string on_func_growth_deposit_0_main_order_page { get; set; }
        public string on_func_growth_deposit_1_main_order_page { get; set; }
        public string on_func_growth_deposit_2_main_order_page { get; set; }
        public string on_func_growth_deposit_3_main_order_page { get; set; }
        public string on_func_growth_deposit_4_main_order_page { get; set; }
        public string on_func_growth_deposit_5_main_order_page { get; set; }
        public string on_func_growth_deposit_6_main_order_page { get; set; }
        public string on_func_growth_deposit_7_main_order_page { get; set; }
        public string on_func_growth_deposit_8_main_order_page { get; set; }
        public string on_func_growth_deposit_9_main_order_page { get; set; }
        public string on_func_growth_deposit_10_main_order_page { get; set; }
        public string on_func_growth_deposit_11_main_order_page { get; set; }
        public string on_func_growth_deposit_12_main_order_page { get; set; }
        public string fix_take_percent_0_main_order_page { get; set; }
        public string fix_take_percent_1_main_order_page { get; set; }
        public string fix_take_percent_2_main_order_page { get; set; }
        public string fix_take_percent_3_main_order_page { get; set; }
        public string fix_take_percent_4_main_order_page { get; set; }
        public string fix_take_percent_5_main_order_page { get; set; }
        public string fix_take_percent_6_main_order_page { get; set; }
        public string fix_take_percent_7_main_order_page { get; set; }
        public string fix_take_percent_8_main_order_page { get; set; }
        public string fix_take_percent_9_main_order_page { get; set; }
        public string fix_take_percent_10_main_order_page { get; set; }
        public string fix_take_percent_11_main_order_page { get; set; }
        public string fix_take_percent_12_main_order_page { get; set; }
        public string on_func_part_close_pos_take_0_main_order_page { get; set; }
        public string on_func_part_close_pos_take_1_main_order_page { get; set; }
        public string on_func_part_close_pos_take_2_main_order_page { get; set; }
        public string on_func_part_close_pos_take_3_main_order_page { get; set; }
        public string on_func_part_close_pos_take_4_main_order_page { get; set; }
        public string on_func_part_close_pos_take_5_main_order_page { get; set; }
        public string on_func_part_close_pos_take_6_main_order_page { get; set; }
        public string on_func_part_close_pos_take_7_main_order_page { get; set; }
        public string on_func_part_close_pos_take_8_main_order_page { get; set; }
        public string on_func_part_close_pos_take_9_main_order_page { get; set; }
        public string on_func_part_close_pos_take_10_main_order_page { get; set; }
        public string on_func_part_close_pos_take_11_main_order_page { get; set; }
        public string on_func_part_close_pos_take_12_main_order_page { get; set; }
        public string quantity_parts_take_0_main_order_page { get; set; }
        public string quantity_parts_take_1_main_order_page { get; set; }
        public string quantity_parts_take_2_main_order_page { get; set; }
        public string quantity_parts_take_3_main_order_page { get; set; }
        public string quantity_parts_take_4_main_order_page { get; set; }
        public string quantity_parts_take_5_main_order_page { get; set; }
        public string quantity_parts_take_6_main_order_page { get; set; }
        public string quantity_parts_take_7_main_order_page { get; set; }
        public string quantity_parts_take_8_main_order_page { get; set; }
        public string quantity_parts_take_9_main_order_page { get; set; }
        public string quantity_parts_take_10_main_order_page { get; set; }
        public string quantity_parts_take_11_main_order_page { get; set; }
        public string quantity_parts_take_12_main_order_page { get; set; }
        public string size_parts_take_0_main_order_page { get; set; }
        public string size_parts_take_1_main_order_page { get; set; }
        public string size_parts_take_2_main_order_page { get; set; }
        public string size_parts_take_3_main_order_page { get; set; }
        public string size_parts_take_4_main_order_page { get; set; }
        public string size_parts_take_5_main_order_page { get; set; }
        public string size_parts_take_6_main_order_page { get; set; }
        public string size_parts_take_7_main_order_page { get; set; }
        public string size_parts_take_8_main_order_page { get; set; }
        public string size_parts_take_9_main_order_page { get; set; }
        public string size_parts_take_10_main_order_page { get; set; }
        public string size_parts_take_11_main_order_page { get; set; }
        public string size_parts_take_12_main_order_page { get; set; }
        public string fix_stop_percent_0_main_order_page { get; set; }
        public string fix_stop_percent_1_main_order_page { get; set; }
        public string fix_stop_percent_2_main_order_page { get; set; }
        public string fix_stop_percent_3_main_order_page { get; set; }
        public string fix_stop_percent_4_main_order_page { get; set; }
        public string fix_stop_percent_5_main_order_page { get; set; }
        public string fix_stop_percent_6_main_order_page { get; set; }
        public string fix_stop_percent_7_main_order_page { get; set; }
        public string fix_stop_percent_8_main_order_page { get; set; }
        public string fix_stop_percent_9_main_order_page { get; set; }
        public string fix_stop_percent_10_main_order_page { get; set; }
        public string fix_stop_percent_11_main_order_page { get; set; }
        public string fix_stop_percent_12_main_order_page { get; set; }
        public string on_func_part_close_pos_stop_0_main_order_page { get; set; }
        public string on_func_part_close_pos_stop_1_main_order_page { get; set; }
        public string on_func_part_close_pos_stop_2_main_order_page { get; set; }
        public string on_func_part_close_pos_stop_3_main_order_page { get; set; }
        public string on_func_part_close_pos_stop_4_main_order_page { get; set; }
        public string on_func_part_close_pos_stop_5_main_order_page { get; set; }
        public string on_func_part_close_pos_stop_6_main_order_page { get; set; }
        public string on_func_part_close_pos_stop_7_main_order_page { get; set; }
        public string on_func_part_close_pos_stop_8_main_order_page { get; set; }
        public string on_func_part_close_pos_stop_9_main_order_page { get; set; }
        public string on_func_part_close_pos_stop_10_main_order_page { get; set; }
        public string on_func_part_close_pos_stop_11_main_order_page { get; set; }
        public string on_func_part_close_pos_stop_12_main_order_page { get; set; }
        public string quantity_parts_stop_0_main_order_page { get; set; }
        public string quantity_parts_stop_1_main_order_page { get; set; }
        public string quantity_parts_stop_2_main_order_page { get; set; }
        public string quantity_parts_stop_3_main_order_page { get; set; }
        public string quantity_parts_stop_4_main_order_page { get; set; }
        public string quantity_parts_stop_5_main_order_page { get; set; }
        public string quantity_parts_stop_6_main_order_page { get; set; }
        public string quantity_parts_stop_7_main_order_page { get; set; }
        public string quantity_parts_stop_8_main_order_page { get; set; }
        public string quantity_parts_stop_9_main_order_page { get; set; }
        public string quantity_parts_stop_10_main_order_page { get; set; }
        public string quantity_parts_stop_11_main_order_page { get; set; }
        public string quantity_parts_stop_12_main_order_page { get; set; }
        public string size_parts_stop_0_main_order_page { get; set; }
        public string size_parts_stop_1_main_order_page { get; set; }
        public string size_parts_stop_2_main_order_page { get; set; }
        public string size_parts_stop_3_main_order_page { get; set; }
        public string size_parts_stop_4_main_order_page { get; set; }
        public string size_parts_stop_5_main_order_page { get; set; }
        public string size_parts_stop_6_main_order_page { get; set; }
        public string size_parts_stop_7_main_order_page { get; set; }
        public string size_parts_stop_8_main_order_page { get; set; }
        public string size_parts_stop_9_main_order_page { get; set; }
        public string size_parts_stop_10_main_order_page { get; set; }
        public string size_parts_stop_11_main_order_page { get; set; }
        public string size_parts_stop_12_main_order_page { get; set; }
        public string on_func_use_trailing_0_main_order_page { get; set; }
        public string on_func_use_trailing_1_main_order_page { get; set; }
        public string on_func_use_trailing_2_main_order_page { get; set; }
        public string on_func_use_trailing_3_main_order_page { get; set; }
        public string on_func_use_trailing_4_main_order_page { get; set; }
        public string on_func_use_trailing_5_main_order_page { get; set; }
        public string on_func_use_trailing_6_main_order_page { get; set; }
        public string on_func_use_trailing_7_main_order_page { get; set; }
        public string on_func_use_trailing_8_main_order_page { get; set; }
        public string on_func_use_trailing_9_main_order_page { get; set; }
        public string on_func_use_trailing_10_main_order_page { get; set; }
        public string on_func_use_trailing_11_main_order_page { get; set; }
        public string on_func_use_trailing_12_main_order_page { get; set; }
        public string start_trailing_0_main_order_page { get; set; }
        public string start_trailing_1_main_order_page { get; set; }
        public string start_trailing_2_main_order_page { get; set; }
        public string start_trailing_3_main_order_page { get; set; }
        public string start_trailing_4_main_order_page { get; set; }
        public string start_trailing_5_main_order_page { get; set; }
        public string start_trailing_6_main_order_page { get; set; }
        public string start_trailing_7_main_order_page { get; set; }
        public string start_trailing_8_main_order_page { get; set; }
        public string start_trailing_9_main_order_page { get; set; }
        public string start_trailing_10_main_order_page { get; set; }
        public string start_trailing_11_main_order_page { get; set; }
        public string start_trailing_12_main_order_page { get; set; }
        public string size_trailing_0_main_order_page { get; set; }
        public string size_trailing_1_main_order_page { get; set; }
        public string size_trailing_2_main_order_page { get; set; }
        public string size_trailing_3_main_order_page { get; set; }
        public string size_trailing_4_main_order_page { get; set; }
        public string size_trailing_5_main_order_page { get; set; }
        public string size_trailing_6_main_order_page { get; set; }
        public string size_trailing_7_main_order_page { get; set; }
        public string size_trailing_8_main_order_page { get; set; }
        public string size_trailing_9_main_order_page { get; set; }
        public string size_trailing_10_main_order_page { get; set; }
        public string size_trailing_11_main_order_page { get; set; }
        public string size_trailing_12_main_order_page { get; set; }
        public string on_func_minus_deals_0_main_order_page { get; set; }
        public string on_func_minus_deals_1_main_order_page { get; set; }
        public string on_func_minus_deals_2_main_order_page { get; set; }
        public string on_func_minus_deals_3_main_order_page { get; set; }
        public string on_func_minus_deals_4_main_order_page { get; set; }
        public string on_func_minus_deals_5_main_order_page { get; set; }
        public string on_func_minus_deals_6_main_order_page { get; set; }
        public string on_func_minus_deals_7_main_order_page { get; set; }
        public string on_func_minus_deals_8_main_order_page { get; set; }
        public string on_func_minus_deals_9_main_order_page { get; set; }
        public string on_func_minus_deals_10_main_order_page { get; set; }
        public string on_func_minus_deals_11_main_order_page { get; set; }
        public string on_func_minus_deals_12_main_order_page { get; set; }
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
                    m_form.SymbRow0MOrdText = configData.Symb_row_0_main_order_page;
                    m_form.SymbRow1MOrdText = configData.Symb_row_1_main_order_page;
                    m_form.SymbRow2MOrdText = configData.Symb_row_2_main_order_page;
                    m_form.SymbRow3MOrdText = configData.Symb_row_3_main_order_page;
                    m_form.SymbRow4MOrdText = configData.Symb_row_4_main_order_page;
                    m_form.SymbRow5MOrdText = configData.Symb_row_5_main_order_page;
                    m_form.SymbRow6MOrdText = configData.Symb_row_6_main_order_page;
                    m_form.SymbRow7MOrdText = configData.Symb_row_7_main_order_page;
                    m_form.SymbRow8MOrdText = configData.Symb_row_8_main_order_page;
                    m_form.SymbRow9MOrdText = configData.Symb_row_9_main_order_page;
                    m_form.SymbRow10MOrdText = configData.Symb_row_10_main_order_page;
                    m_form.SymbRow11MOrdText = configData.Symb_row_11_main_order_page;
                    m_form.SymbRow12MOrdText = configData.Symb_row_12_main_order_page;
                    m_form.OpenMOrdRow0Checked = configData.open_main_order_0_main_order_page;
                    m_form.OpenMOrdRow1Checked = configData.open_main_order_1_main_order_page;
                    m_form.OpenMOrdRow2Checked = configData.open_main_order_2_main_order_page;
                    m_form.OpenMOrdRow3Checked = configData.open_main_order_3_main_order_page;
                    m_form.OpenMOrdRow4Checked = configData.open_main_order_4_main_order_page;
                    m_form.OpenMOrdRow5Checked = configData.open_main_order_5_main_order_page;
                    m_form.OpenMOrdRow6Checked = configData.open_main_order_6_main_order_page;
                    m_form.OpenMOrdRow7Checked = configData.open_main_order_7_main_order_page;
                    m_form.OpenMOrdRow8Checked = configData.open_main_order_8_main_order_page;
                    m_form.OpenMOrdRow9Checked = configData.open_main_order_9_main_order_page;
                    m_form.OpenMOrdRow10Checked = configData.open_main_order_10_main_order_page;
                    m_form.OpenMOrdRow11Checked = configData.open_main_order_11_main_order_page;
                    m_form.OpenMOrdRow12Checked = configData.open_main_order_12_main_order_page;
                    m_form.BarInMOrdRow0Item = configData.choice_bar_in_0_main_order_page;
                    m_form.BarInMOrdRow1Item = configData.choice_bar_in_1_main_order_page;
                    m_form.BarInMOrdRow2Item = configData.choice_bar_in_2_main_order_page;
                    m_form.BarInMOrdRow3Item = configData.choice_bar_in_3_main_order_page;
                    m_form.BarInMOrdRow4Item = configData.choice_bar_in_4_main_order_page;
                    m_form.BarInMOrdRow5Item = configData.choice_bar_in_5_main_order_page;
                    m_form.BarInMOrdRow6Item = configData.choice_bar_in_6_main_order_page;
                    m_form.BarInMOrdRow7Item = configData.choice_bar_in_7_main_order_page;
                    m_form.BarInMOrdRow8Item = configData.choice_bar_in_8_main_order_page;
                    m_form.BarInMOrdRow9Item = configData.choice_bar_in_9_main_order_page;
                    m_form.BarInMOrdRow10Item = configData.choice_bar_in_10_main_order_page;
                    m_form.BarInMOrdRow11Item = configData.choice_bar_in_11_main_order_page;
                    m_form.BarInMOrdRow12Item = configData.choice_bar_in_12_main_order_page;
                    m_form.StopInBarMOrdRow0Checked = configData.on_func_ignor_signal_0_main_order_page;
                    m_form.StopInBarMOrdRow1Checked = configData.on_func_ignor_signal_1_main_order_page;
                    m_form.StopInBarMOrdRow2Checked = configData.on_func_ignor_signal_2_main_order_page;
                    m_form.StopInBarMOrdRow3Checked = configData.on_func_ignor_signal_3_main_order_page;
                    m_form.StopInBarMOrdRow4Checked = configData.on_func_ignor_signal_4_main_order_page;
                    m_form.StopInBarMOrdRow5Checked = configData.on_func_ignor_signal_5_main_order_page;
                    m_form.StopInBarMOrdRow6Checked = configData.on_func_ignor_signal_6_main_order_page;
                    m_form.StopInBarMOrdRow7Checked = configData.on_func_ignor_signal_7_main_order_page;
                    m_form.StopInBarMOrdRow8Checked = configData.on_func_ignor_signal_8_main_order_page;
                    m_form.StopInBarMOrdRow9Checked = configData.on_func_ignor_signal_9_main_order_page;
                    m_form.StopInBarMOrdRow10Checked = configData.on_func_ignor_signal_10_main_order_page;
                    m_form.StopInBarMOrdRow11Checked = configData.on_func_ignor_signal_11_main_order_page;
                    m_form.StopInBarMOrdRow12Checked = configData.on_func_ignor_signal_12_main_order_page;
                    m_form.DelayBarMOrdRow0Text = configData.quantity_bar_ignor_0_main_order_page;
                    m_form.DelayBarMOrdRow1Text = configData.quantity_bar_ignor_1_main_order_page;
                    m_form.DelayBarMOrdRow2Text = configData.quantity_bar_ignor_2_main_order_page;
                    m_form.DelayBarMOrdRow3Text = configData.quantity_bar_ignor_3_main_order_page;
                    m_form.DelayBarMOrdRow4Text = configData.quantity_bar_ignor_4_main_order_page;
                    m_form.DelayBarMOrdRow5Text = configData.quantity_bar_ignor_5_main_order_page;
                    m_form.DelayBarMOrdRow6Text = configData.quantity_bar_ignor_6_main_order_page;
                    m_form.DelayBarMOrdRow7Text = configData.quantity_bar_ignor_7_main_order_page;
                    m_form.DelayBarMOrdRow8Text = configData.quantity_bar_ignor_8_main_order_page;
                    m_form.DelayBarMOrdRow9Text = configData.quantity_bar_ignor_9_main_order_page;
                    m_form.DelayBarMOrdRow10Text = configData.quantity_bar_ignor_10_main_order_page;
                    m_form.DelayBarMOrdRow11Text = configData.quantity_bar_ignor_11_main_order_page;
                    m_form.DelayBarMOrdRow12Text = configData.quantity_bar_ignor_12_main_order_page;
                    m_form.FixDealInMOrdRow0Checked = configData.on_func_fix_deal_on_bar_0_main_order_page;
                    m_form.FixDealInMOrdRow1Checked = configData.on_func_fix_deal_on_bar_1_main_order_page;
                    m_form.FixDealInMOrdRow2Checked = configData.on_func_fix_deal_on_bar_2_main_order_page;
                    m_form.FixDealInMOrdRow3Checked = configData.on_func_fix_deal_on_bar_3_main_order_page;
                    m_form.FixDealInMOrdRow4Checked = configData.on_func_fix_deal_on_bar_4_main_order_page;
                    m_form.FixDealInMOrdRow5Checked = configData.on_func_fix_deal_on_bar_5_main_order_page;
                    m_form.FixDealInMOrdRow6Checked = configData.on_func_fix_deal_on_bar_6_main_order_page;
                    m_form.FixDealInMOrdRow7Checked = configData.on_func_fix_deal_on_bar_7_main_order_page;
                    m_form.FixDealInMOrdRow8Checked = configData.on_func_fix_deal_on_bar_8_main_order_page;
                    m_form.FixDealInMOrdRow9Checked = configData.on_func_fix_deal_on_bar_9_main_order_page;
                    m_form.FixDealInMOrdRow10Checked = configData.on_func_fix_deal_on_bar_10_main_order_page;
                    m_form.FixDealInMOrdRow11Checked = configData.on_func_fix_deal_on_bar_11_main_order_page;
                    m_form.FixDealInMOrdRow12Checked = configData.on_func_fix_deal_on_bar_12_main_order_page;
                    m_form.MaxDealBarMOrdRow0Text = configData.quantity_deals_on_bar_0_main_order_page;
                    m_form.MaxDealBarMOrdRow1Text = configData.quantity_deals_on_bar_1_main_order_page;
                    m_form.MaxDealBarMOrdRow2Text = configData.quantity_deals_on_bar_2_main_order_page;
                    m_form.MaxDealBarMOrdRow3Text = configData.quantity_deals_on_bar_3_main_order_page;
                    m_form.MaxDealBarMOrdRow4Text = configData.quantity_deals_on_bar_4_main_order_page;
                    m_form.MaxDealBarMOrdRow5Text = configData.quantity_deals_on_bar_5_main_order_page;
                    m_form.MaxDealBarMOrdRow6Text = configData.quantity_deals_on_bar_6_main_order_page;
                    m_form.MaxDealBarMOrdRow7Text = configData.quantity_deals_on_bar_7_main_order_page;
                    m_form.MaxDealBarMOrdRow8Text = configData.quantity_deals_on_bar_8_main_order_page;
                    m_form.MaxDealBarMOrdRow9Text = configData.quantity_deals_on_bar_9_main_order_page;
                    m_form.MaxDealBarMOrdRow10Text = configData.quantity_deals_on_bar_10_main_order_page;
                    m_form.MaxDealBarMOrdRow11Text = configData.quantity_deals_on_bar_11_main_order_page;
                    m_form.MaxDealBarMOrdRow12Text = configData.quantity_deals_on_bar_12_main_order_page;
                    m_form.OutSigIndMOrdRow0Checked = configData.on_func_use_signal_for_out_0_main_order_page;
                    m_form.OutSigIndMOrdRow1Checked = configData.on_func_use_signal_for_out_1_main_order_page;
                    m_form.OutSigIndMOrdRow2Checked = configData.on_func_use_signal_for_out_2_main_order_page;
                    m_form.OutSigIndMOrdRow3Checked = configData.on_func_use_signal_for_out_3_main_order_page;
                    m_form.OutSigIndMOrdRow4Checked = configData.on_func_use_signal_for_out_4_main_order_page;
                    m_form.OutSigIndMOrdRow5Checked = configData.on_func_use_signal_for_out_5_main_order_page;
                    m_form.OutSigIndMOrdRow6Checked = configData.on_func_use_signal_for_out_6_main_order_page;
                    m_form.OutSigIndMOrdRow7Checked = configData.on_func_use_signal_for_out_7_main_order_page;
                    m_form.OutSigIndMOrdRow8Checked = configData.on_func_use_signal_for_out_8_main_order_page;
                    m_form.OutSigIndMOrdRow9Checked = configData.on_func_use_signal_for_out_9_main_order_page;
                    m_form.OutSigIndMOrdRow10Checked = configData.on_func_use_signal_for_out_10_main_order_page;
                    m_form.OutSigIndMOrdRow11Checked = configData.on_func_use_signal_for_out_11_main_order_page;
                    m_form.OutSigIndMOrdRow12Checked = configData.on_func_use_signal_for_out_12_main_order_page;
                    m_form.BarOutMOrdRow0Item = configData.choice_bar_out_0_main_order_page;
                    m_form.BarOutMOrdRow1Item = configData.choice_bar_out_1_main_order_page;
                    m_form.BarOutMOrdRow2Item = configData.choice_bar_out_2_main_order_page;
                    m_form.BarOutMOrdRow3Item = configData.choice_bar_out_3_main_order_page;
                    m_form.BarOutMOrdRow4Item = configData.choice_bar_out_4_main_order_page;
                    m_form.BarOutMOrdRow5Item = configData.choice_bar_out_5_main_order_page;
                    m_form.BarOutMOrdRow6Item = configData.choice_bar_out_6_main_order_page;
                    m_form.BarOutMOrdRow7Item = configData.choice_bar_out_7_main_order_page;
                    m_form.BarOutMOrdRow8Item = configData.choice_bar_out_8_main_order_page;
                    m_form.BarOutMOrdRow9Item = configData.choice_bar_out_9_main_order_page;
                    m_form.BarOutMOrdRow10Item = configData.choice_bar_out_10_main_order_page;
                    m_form.BarOutMOrdRow11Item = configData.choice_bar_out_11_main_order_page;
                    m_form.BarOutMOrdRow12Item = configData.choice_bar_out_12_main_order_page;
                    m_form.FixVolMOrdRow0Text = configData.fix_volume_0_main_order_page;
                    m_form.FixVolMOrdRow1Text = configData.fix_volume_1_main_order_page;
                    m_form.FixVolMOrdRow2Text = configData.fix_volume_2_main_order_page;
                    m_form.FixVolMOrdRow3Text = configData.fix_volume_3_main_order_page;
                    m_form.FixVolMOrdRow4Text = configData.fix_volume_4_main_order_page;
                    m_form.FixVolMOrdRow5Text = configData.fix_volume_5_main_order_page;
                    m_form.FixVolMOrdRow6Text = configData.fix_volume_6_main_order_page;
                    m_form.FixVolMOrdRow7Text = configData.fix_volume_7_main_order_page;
                    m_form.FixVolMOrdRow8Text = configData.fix_volume_8_main_order_page;
                    m_form.FixVolMOrdRow9Text = configData.fix_volume_9_main_order_page;
                    m_form.FixVolMOrdRow10Text = configData.fix_volume_10_main_order_page;
                    m_form.FixVolMOrdRow11Text = configData.fix_volume_11_main_order_page;
                    m_form.FixVolMOrdRow12Text = configData.fix_volume_12_main_order_page;
                    m_form.GrowthDepoMOrdRow0Checked = configData.on_func_growth_deposit_0_main_order_page;
                    m_form.GrowthDepoMOrdRow1Checked = configData.on_func_growth_deposit_1_main_order_page;
                    m_form.GrowthDepoMOrdRow2Checked = configData.on_func_growth_deposit_2_main_order_page;
                    m_form.GrowthDepoMOrdRow3Checked = configData.on_func_growth_deposit_3_main_order_page;
                    m_form.GrowthDepoMOrdRow4Checked = configData.on_func_growth_deposit_4_main_order_page;
                    m_form.GrowthDepoMOrdRow5Checked = configData.on_func_growth_deposit_5_main_order_page;
                    m_form.GrowthDepoMOrdRow6Checked = configData.on_func_growth_deposit_6_main_order_page;
                    m_form.GrowthDepoMOrdRow7Checked = configData.on_func_growth_deposit_7_main_order_page;
                    m_form.GrowthDepoMOrdRow8Checked = configData.on_func_growth_deposit_8_main_order_page;
                    m_form.GrowthDepoMOrdRow9Checked = configData.on_func_growth_deposit_9_main_order_page;
                    m_form.GrowthDepoMOrdRow10Checked = configData.on_func_growth_deposit_10_main_order_page;
                    m_form.GrowthDepoMOrdRow11Checked = configData.on_func_growth_deposit_11_main_order_page;
                    m_form.GrowthDepoMOrdRow12Checked = configData.on_func_growth_deposit_12_main_order_page;
                    m_form.TakeMOrdRow0Text = configData.fix_take_percent_0_main_order_page;
                    m_form.TakeMOrdRow1Text = configData.fix_take_percent_1_main_order_page;
                    m_form.TakeMOrdRow2Text = configData.fix_take_percent_2_main_order_page;
                    m_form.TakeMOrdRow3Text = configData.fix_take_percent_3_main_order_page;
                    m_form.TakeMOrdRow4Text = configData.fix_take_percent_4_main_order_page;
                    m_form.TakeMOrdRow5Text = configData.fix_take_percent_5_main_order_page;
                    m_form.TakeMOrdRow6Text = configData.fix_take_percent_6_main_order_page;
                    m_form.TakeMOrdRow7Text = configData.fix_take_percent_7_main_order_page;
                    m_form.TakeMOrdRow8Text = configData.fix_take_percent_8_main_order_page;
                    m_form.TakeMOrdRow9Text = configData.fix_take_percent_9_main_order_page;
                    m_form.TakeMOrdRow10Text = configData.fix_take_percent_10_main_order_page;
                    m_form.TakeMOrdRow11Text = configData.fix_take_percent_11_main_order_page;
                    m_form.TakeMOrdRow12Text = configData.fix_take_percent_12_main_order_page;
                    m_form.CloseTakePartMOrdRow0Checked = configData.on_func_part_close_pos_take_0_main_order_page;
                    m_form.CloseTakePartMOrdRow1Checked = configData.on_func_part_close_pos_take_1_main_order_page;
                    m_form.CloseTakePartMOrdRow2Checked = configData.on_func_part_close_pos_take_2_main_order_page;
                    m_form.CloseTakePartMOrdRow3Checked = configData.on_func_part_close_pos_take_3_main_order_page;
                    m_form.CloseTakePartMOrdRow4Checked = configData.on_func_part_close_pos_take_4_main_order_page;
                    m_form.CloseTakePartMOrdRow5Checked = configData.on_func_part_close_pos_take_5_main_order_page;
                    m_form.CloseTakePartMOrdRow6Checked = configData.on_func_part_close_pos_take_6_main_order_page;
                    m_form.CloseTakePartMOrdRow7Checked = configData.on_func_part_close_pos_take_7_main_order_page;
                    m_form.CloseTakePartMOrdRow8Checked = configData.on_func_part_close_pos_take_8_main_order_page;
                    m_form.CloseTakePartMOrdRow9Checked = configData.on_func_part_close_pos_take_9_main_order_page;
                    m_form.CloseTakePartMOrdRow10Checked = configData.on_func_part_close_pos_take_10_main_order_page;
                    m_form.CloseTakePartMOrdRow11Checked = configData.on_func_part_close_pos_take_11_main_order_page;
                    m_form.CloseTakePartMOrdRow12Checked = configData.on_func_part_close_pos_take_12_main_order_page;
                    m_form.PartsTakeMOrdRow0Text = configData.quantity_parts_take_0_main_order_page;
                    m_form.PartsTakeMOrdRow1Text = configData.quantity_parts_take_1_main_order_page;
                    m_form.PartsTakeMOrdRow2Text = configData.quantity_parts_take_2_main_order_page;
                    m_form.PartsTakeMOrdRow3Text = configData.quantity_parts_take_3_main_order_page;
                    m_form.PartsTakeMOrdRow4Text = configData.quantity_parts_take_4_main_order_page;
                    m_form.PartsTakeMOrdRow5Text = configData.quantity_parts_take_5_main_order_page;
                    m_form.PartsTakeMOrdRow6Text = configData.quantity_parts_take_6_main_order_page;
                    m_form.PartsTakeMOrdRow7Text = configData.quantity_parts_take_7_main_order_page;
                    m_form.PartsTakeMOrdRow8Text = configData.quantity_parts_take_8_main_order_page;
                    m_form.PartsTakeMOrdRow9Text = configData.quantity_parts_take_9_main_order_page;
                    m_form.PartsTakeMOrdRow10Text = configData.quantity_parts_take_10_main_order_page;
                    m_form.PartsTakeMOrdRow11Text = configData.quantity_parts_take_11_main_order_page;
                    m_form.PartsTakeMOrdRow12Text = configData.quantity_parts_take_12_main_order_page;
                    m_form.ValuePartsTakeMOrdRow0Text = configData.size_parts_take_0_main_order_page;
                    m_form.ValuePartsTakeMOrdRow1Text = configData.size_parts_take_1_main_order_page;
                    m_form.ValuePartsTakeMOrdRow2Text = configData.size_parts_take_2_main_order_page;
                    m_form.ValuePartsTakeMOrdRow3Text = configData.size_parts_take_3_main_order_page;
                    m_form.ValuePartsTakeMOrdRow4Text = configData.size_parts_take_4_main_order_page;
                    m_form.ValuePartsTakeMOrdRow5Text = configData.size_parts_take_5_main_order_page;
                    m_form.ValuePartsTakeMOrdRow6Text = configData.size_parts_take_6_main_order_page;
                    m_form.ValuePartsTakeMOrdRow7Text = configData.size_parts_take_7_main_order_page;
                    m_form.ValuePartsTakeMOrdRow8Text = configData.size_parts_take_8_main_order_page;
                    m_form.ValuePartsTakeMOrdRow9Text = configData.size_parts_take_9_main_order_page;
                    m_form.ValuePartsTakeMOrdRow10Text = configData.size_parts_take_10_main_order_page;
                    m_form.ValuePartsTakeMOrdRow11Text = configData.size_parts_take_11_main_order_page;
                    m_form.ValuePartsTakeMOrdRow12Text = configData.size_parts_take_12_main_order_page;
                    m_form.StopMOrdRow0Text = configData.fix_stop_percent_0_main_order_page;
                    m_form.StopMOrdRow1Text = configData.fix_stop_percent_1_main_order_page;
                    m_form.StopMOrdRow2Text = configData.fix_stop_percent_2_main_order_page;
                    m_form.StopMOrdRow3Text = configData.fix_stop_percent_3_main_order_page;
                    m_form.StopMOrdRow4Text = configData.fix_stop_percent_4_main_order_page;
                    m_form.StopMOrdRow5Text = configData.fix_stop_percent_5_main_order_page;
                    m_form.StopMOrdRow6Text = configData.fix_stop_percent_6_main_order_page;
                    m_form.StopMOrdRow7Text = configData.fix_stop_percent_7_main_order_page;
                    m_form.StopMOrdRow8Text = configData.fix_stop_percent_8_main_order_page;
                    m_form.StopMOrdRow9Text = configData.fix_stop_percent_9_main_order_page;
                    m_form.StopMOrdRow10Text = configData.fix_stop_percent_10_main_order_page;
                    m_form.StopMOrdRow11Text = configData.fix_stop_percent_11_main_order_page;
                    m_form.StopMOrdRow12Text = configData.fix_stop_percent_12_main_order_page;
                    m_form.CloseStopPartMOrdRow0Checked = configData.on_func_part_close_pos_stop_0_main_order_page;
                    m_form.CloseStopPartMOrdRow1Checked = configData.on_func_part_close_pos_stop_1_main_order_page;
                    m_form.CloseStopPartMOrdRow2Checked = configData.on_func_part_close_pos_stop_2_main_order_page;
                    m_form.CloseStopPartMOrdRow3Checked = configData.on_func_part_close_pos_stop_3_main_order_page;
                    m_form.CloseStopPartMOrdRow4Checked = configData.on_func_part_close_pos_stop_4_main_order_page;
                    m_form.CloseStopPartMOrdRow5Checked = configData.on_func_part_close_pos_stop_5_main_order_page;
                    m_form.CloseStopPartMOrdRow6Checked = configData.on_func_part_close_pos_stop_6_main_order_page;
                    m_form.CloseStopPartMOrdRow7Checked = configData.on_func_part_close_pos_stop_7_main_order_page;
                    m_form.CloseStopPartMOrdRow8Checked = configData.on_func_part_close_pos_stop_8_main_order_page;
                    m_form.CloseStopPartMOrdRow9Checked = configData.on_func_part_close_pos_stop_9_main_order_page;
                    m_form.CloseStopPartMOrdRow10Checked = configData.on_func_part_close_pos_stop_10_main_order_page;
                    m_form.CloseStopPartMOrdRow11Checked = configData.on_func_part_close_pos_stop_11_main_order_page;
                    m_form.CloseStopPartMOrdRow12Checked = configData.on_func_part_close_pos_stop_12_main_order_page;
                    m_form.PartsStopMOrdRow0Text = configData.quantity_parts_stop_0_main_order_page;
                    m_form.PartsStopMOrdRow1Text = configData.quantity_parts_stop_1_main_order_page;
                    m_form.PartsStopMOrdRow2Text = configData.quantity_parts_stop_2_main_order_page;
                    m_form.PartsStopMOrdRow3Text = configData.quantity_parts_stop_3_main_order_page;
                    m_form.PartsStopMOrdRow4Text = configData.quantity_parts_stop_4_main_order_page;
                    m_form.PartsStopMOrdRow5Text = configData.quantity_parts_stop_5_main_order_page;
                    m_form.PartsStopMOrdRow6Text = configData.quantity_parts_stop_6_main_order_page;
                    m_form.PartsStopMOrdRow7Text = configData.quantity_parts_stop_7_main_order_page;
                    m_form.PartsStopMOrdRow8Text = configData.quantity_parts_stop_8_main_order_page;
                    m_form.PartsStopMOrdRow9Text = configData.quantity_parts_stop_9_main_order_page;
                    m_form.PartsStopMOrdRow10Text = configData.quantity_parts_stop_10_main_order_page;
                    m_form.PartsStopMOrdRow11Text = configData.quantity_parts_stop_11_main_order_page;
                    m_form.PartsStopMOrdRow12Text = configData.quantity_parts_stop_12_main_order_page;
                    m_form.ValuePartsStopMOrdRow0Text = configData.size_parts_stop_0_main_order_page;
                    m_form.ValuePartsStopMOrdRow1Text = configData.size_parts_stop_1_main_order_page;
                    m_form.ValuePartsStopMOrdRow2Text = configData.size_parts_stop_2_main_order_page;
                    m_form.ValuePartsStopMOrdRow3Text = configData.size_parts_stop_3_main_order_page;
                    m_form.ValuePartsStopMOrdRow4Text = configData.size_parts_stop_4_main_order_page;
                    m_form.ValuePartsStopMOrdRow5Text = configData.size_parts_stop_5_main_order_page;
                    m_form.ValuePartsStopMOrdRow6Text = configData.size_parts_stop_6_main_order_page;
                    m_form.ValuePartsStopMOrdRow7Text = configData.size_parts_stop_7_main_order_page;
                    m_form.ValuePartsStopMOrdRow8Text = configData.size_parts_stop_8_main_order_page;
                    m_form.ValuePartsStopMOrdRow9Text = configData.size_parts_stop_9_main_order_page;
                    m_form.ValuePartsStopMOrdRow10Text = configData.size_parts_stop_10_main_order_page;
                    m_form.ValuePartsStopMOrdRow11Text = configData.size_parts_stop_11_main_order_page;
                    m_form.ValuePartsStopMOrdRow12Text = configData.size_parts_stop_12_main_order_page;
                    m_form.UseTrailMOrdRow0Checked = configData.on_func_use_trailing_0_main_order_page;
                    m_form.UseTrailMOrdRow1Checked = configData.on_func_use_trailing_1_main_order_page;
                    m_form.UseTrailMOrdRow2Checked = configData.on_func_use_trailing_2_main_order_page;
                    m_form.UseTrailMOrdRow3Checked = configData.on_func_use_trailing_3_main_order_page;
                    m_form.UseTrailMOrdRow4Checked = configData.on_func_use_trailing_4_main_order_page;
                    m_form.UseTrailMOrdRow5Checked = configData.on_func_use_trailing_5_main_order_page;
                    m_form.UseTrailMOrdRow6Checked = configData.on_func_use_trailing_6_main_order_page;
                    m_form.UseTrailMOrdRow7Checked = configData.on_func_use_trailing_7_main_order_page;
                    m_form.UseTrailMOrdRow8Checked = configData.on_func_use_trailing_8_main_order_page;
                    m_form.UseTrailMOrdRow9Checked = configData.on_func_use_trailing_9_main_order_page;
                    m_form.UseTrailMOrdRow10Checked = configData.on_func_use_trailing_10_main_order_page;
                    m_form.UseTrailMOrdRow11Checked = configData.on_func_use_trailing_11_main_order_page;
                    m_form.UseTrailMOrdRow12Checked = configData.on_func_use_trailing_12_main_order_page;
                    m_form.StartCalcTrailMOrdRow0Text = configData.start_trailing_0_main_order_page;
                    m_form.StartCalcTrailMOrdRow1Text = configData.start_trailing_1_main_order_page;
                    m_form.StartCalcTrailMOrdRow2Text = configData.start_trailing_2_main_order_page;
                    m_form.StartCalcTrailMOrdRow3Text = configData.start_trailing_3_main_order_page;
                    m_form.StartCalcTrailMOrdRow4Text = configData.start_trailing_4_main_order_page;
                    m_form.StartCalcTrailMOrdRow5Text = configData.start_trailing_5_main_order_page;
                    m_form.StartCalcTrailMOrdRow6Text = configData.start_trailing_6_main_order_page;
                    m_form.StartCalcTrailMOrdRow7Text = configData.start_trailing_7_main_order_page;
                    m_form.StartCalcTrailMOrdRow8Text = configData.start_trailing_8_main_order_page;
                    m_form.StartCalcTrailMOrdRow9Text = configData.start_trailing_9_main_order_page;
                    m_form.StartCalcTrailMOrdRow10Text = configData.start_trailing_10_main_order_page;
                    m_form.StartCalcTrailMOrdRow11Text = configData.start_trailing_11_main_order_page;
                    m_form.StartCalcTrailMOrdRow12Text = configData.start_trailing_12_main_order_page;
                    m_form.SizeTrailMOrdRow0Text = configData.size_trailing_0_main_order_page;
                    m_form.SizeTrailMOrdRow1Text = configData.size_trailing_1_main_order_page;
                    m_form.SizeTrailMOrdRow2Text = configData.size_trailing_2_main_order_page;
                    m_form.SizeTrailMOrdRow3Text = configData.size_trailing_3_main_order_page;
                    m_form.SizeTrailMOrdRow4Text = configData.size_trailing_4_main_order_page;
                    m_form.SizeTrailMOrdRow5Text = configData.size_trailing_5_main_order_page;
                    m_form.SizeTrailMOrdRow6Text = configData.size_trailing_6_main_order_page;
                    m_form.SizeTrailMOrdRow7Text = configData.size_trailing_7_main_order_page;
                    m_form.SizeTrailMOrdRow8Text = configData.size_trailing_8_main_order_page;
                    m_form.SizeTrailMOrdRow9Text = configData.size_trailing_9_main_order_page;
                    m_form.SizeTrailMOrdRow10Text = configData.size_trailing_10_main_order_page;
                    m_form.SizeTrailMOrdRow11Text = configData.size_trailing_11_main_order_page;
                    m_form.SizeTrailMOrdRow12Text = configData.size_trailing_12_main_order_page;
                    m_form.OtkupMinusMOrderRow0Checked = configData.on_func_minus_deals_0_main_order_page;
                    m_form.OtkupMinusMOrderRow1Checked = configData.on_func_minus_deals_1_main_order_page;
                    m_form.OtkupMinusMOrderRow2Checked = configData.on_func_minus_deals_2_main_order_page;
                    m_form.OtkupMinusMOrderRow3Checked = configData.on_func_minus_deals_3_main_order_page;
                    m_form.OtkupMinusMOrderRow4Checked = configData.on_func_minus_deals_4_main_order_page;
                    m_form.OtkupMinusMOrderRow5Checked = configData.on_func_minus_deals_5_main_order_page;
                    m_form.OtkupMinusMOrderRow6Checked = configData.on_func_minus_deals_6_main_order_page;
                    m_form.OtkupMinusMOrderRow7Checked = configData.on_func_minus_deals_7_main_order_page;
                    m_form.OtkupMinusMOrderRow8Checked = configData.on_func_minus_deals_8_main_order_page;
                    m_form.OtkupMinusMOrderRow9Checked = configData.on_func_minus_deals_9_main_order_page;
                    m_form.OtkupMinusMOrderRow10Checked = configData.on_func_minus_deals_10_main_order_page;
                    m_form.OtkupMinusMOrderRow11Checked = configData.on_func_minus_deals_11_main_order_page;
                    m_form.OtkupMinusMOrderRow12Checked = configData.on_func_minus_deals_12_main_order_page;

                }
                catch ( Exception ex )
                {
                    Console.WriteLine(ex.Message );
                }
            }
        }
    }
}
