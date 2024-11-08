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

        //вкладка Хедж ордер
        public string Symb_row_0_hedg_order_page { get; set; }
        public string Symb_row_1_hedg_order_page { get; set; }
        public string Symb_row_2_hedg_order_page { get; set; }
        public string Symb_row_3_hedg_order_page { get; set; }
        public string Symb_row_4_hedg_order_page { get; set; }
        public string Symb_row_5_hedg_order_page { get; set; }
        public string Symb_row_6_hedg_order_page { get; set; }
        public string Symb_row_7_hedg_order_page { get; set; }
        public string Symb_row_8_hedg_order_page { get; set; }
        public string Symb_row_9_hedg_order_page { get; set; }
        public string Symb_row_10_hedg_order_page { get; set; }
        public string Symb_row_11_hedg_order_page { get; set; }
        public string Symb_row_12_hedg_order_page { get; set; }
        public string on_func_use_hedge_0_hedg_order_page { get; set; }
        public string on_func_use_hedge_1_hedg_order_page { get; set; }
        public string on_func_use_hedge_2_hedg_order_page { get; set; }
        public string on_func_use_hedge_3_hedg_order_page { get; set; }
        public string on_func_use_hedge_4_hedg_order_page { get; set; }
        public string on_func_use_hedge_5_hedg_order_page { get; set; }
        public string on_func_use_hedge_6_hedg_order_page { get; set; }
        public string on_func_use_hedge_7_hedg_order_page { get; set; }
        public string on_func_use_hedge_8_hedg_order_page { get; set; }
        public string on_func_use_hedge_9_hedg_order_page { get; set; }
        public string on_func_use_hedge_10_hedg_order_page { get; set; }
        public string on_func_use_hedge_11_hedg_order_page { get; set; }
        public string on_func_use_hedge_12_hedg_order_page { get; set; }
        public string choice_bar_in_hedge_0_hedg_order_page { get; set; }
        public string choice_bar_in_hedge_1_hedg_order_page { get; set; }
        public string choice_bar_in_hedge_2_hedg_order_page { get; set; }
        public string choice_bar_in_hedge_3_hedg_order_page { get; set; }
        public string choice_bar_in_hedge_4_hedg_order_page { get; set; }
        public string choice_bar_in_hedge_5_hedg_order_page { get; set; }
        public string choice_bar_in_hedge_6_hedg_order_page { get; set; }
        public string choice_bar_in_hedge_7_hedg_order_page { get; set; }
        public string choice_bar_in_hedge_8_hedg_order_page { get; set; }
        public string choice_bar_in_hedge_9_hedg_order_page { get; set; }
        public string choice_bar_in_hedge_10_hedg_order_page { get; set; }
        public string choice_bar_in_hedge_11_hedg_order_page { get; set; }
        public string choice_bar_in_hedge_12_hedg_order_page { get; set; }
        public string on_func_ignor_signal_hedge_0_hedg_order_page { get; set; }
        public string on_func_ignor_signal_hedge_1_hedg_order_page { get; set; }
        public string on_func_ignor_signal_hedge_2_hedg_order_page { get; set; }
        public string on_func_ignor_signal_hedge_3_hedg_order_page { get; set; }
        public string on_func_ignor_signal_hedge_4_hedg_order_page { get; set; }
        public string on_func_ignor_signal_hedge_5_hedg_order_page { get; set; }
        public string on_func_ignor_signal_hedge_6_hedg_order_page { get; set; }
        public string on_func_ignor_signal_hedge_7_hedg_order_page { get; set; }
        public string on_func_ignor_signal_hedge_8_hedg_order_page { get; set; }
        public string on_func_ignor_signal_hedge_9_hedg_order_page { get; set; }
        public string on_func_ignor_signal_hedge_10_hedg_order_page { get; set; }
        public string on_func_ignor_signal_hedge_11_hedg_order_page { get; set; }
        public string on_func_ignor_signal_hedge_12_hedg_order_page { get; set; }
        public string quantity_bar_ignor_hedge_0_hedg_order_page { get; set; }
        public string quantity_bar_ignor_hedge_1_hedg_order_page { get; set; }
        public string quantity_bar_ignor_hedge_2_hedg_order_page { get; set; }
        public string quantity_bar_ignor_hedge_3_hedg_order_page { get; set; }
        public string quantity_bar_ignor_hedge_4_hedg_order_page { get; set; }
        public string quantity_bar_ignor_hedge_5_hedg_order_page { get; set; }
        public string quantity_bar_ignor_hedge_6_hedg_order_page { get; set; }
        public string quantity_bar_ignor_hedge_7_hedg_order_page { get; set; }
        public string quantity_bar_ignor_hedge_8_hedg_order_page { get; set; }
        public string quantity_bar_ignor_hedge_9_hedg_order_page { get; set; }
        public string quantity_bar_ignor_hedge_10_hedg_order_page { get; set; }
        public string quantity_bar_ignor_hedge_11_hedg_order_page { get; set; }
        public string quantity_bar_ignor_hedge_12_hedg_order_page { get; set; }
        public string on_func_fix_deal_on_bar_hedge_0_hedg_order_page { get; set; }
        public string on_func_fix_deal_on_bar_hedge_1_hedg_order_page { get; set; }
        public string on_func_fix_deal_on_bar_hedge_2_hedg_order_page { get; set; }
        public string on_func_fix_deal_on_bar_hedge_3_hedg_order_page { get; set; }
        public string on_func_fix_deal_on_bar_hedge_4_hedg_order_page { get; set; }
        public string on_func_fix_deal_on_bar_hedge_5_hedg_order_page { get; set; }
        public string on_func_fix_deal_on_bar_hedge_6_hedg_order_page { get; set; }
        public string on_func_fix_deal_on_bar_hedge_7_hedg_order_page { get; set; }
        public string on_func_fix_deal_on_bar_hedge_8_hedg_order_page { get; set; }
        public string on_func_fix_deal_on_bar_hedge_9_hedg_order_page { get; set; }
        public string on_func_fix_deal_on_bar_hedge_10_hedg_order_page { get; set; }
        public string on_func_fix_deal_on_bar_hedge_11_hedg_order_page { get; set; }
        public string on_func_fix_deal_on_bar_hedge_12_hedg_order_page { get; set; }
        public string quantity_deals_on_bar_hedge_0_hedg_order_page { get; set; }
        public string quantity_deals_on_bar_hedge_1_hedg_order_page { get; set; }
        public string quantity_deals_on_bar_hedge_2_hedg_order_page { get; set; }
        public string quantity_deals_on_bar_hedge_3_hedg_order_page { get; set; }
        public string quantity_deals_on_bar_hedge_4_hedg_order_page { get; set; }
        public string quantity_deals_on_bar_hedge_5_hedg_order_page { get; set; }
        public string quantity_deals_on_bar_hedge_6_hedg_order_page { get; set; }
        public string quantity_deals_on_bar_hedge_7_hedg_order_page { get; set; }
        public string quantity_deals_on_bar_hedge_8_hedg_order_page { get; set; }
        public string quantity_deals_on_bar_hedge_9_hedg_order_page { get; set; }
        public string quantity_deals_on_bar_hedge_10_hedg_order_page { get; set; }
        public string quantity_deals_on_bar_hedge_11_hedg_order_page { get; set; }
        public string quantity_deals_on_bar_hedge_12_hedg_order_page { get; set; }
        public string on_func_use_signal_for_out_hedge_0_hedg_order_page { get; set; }
        public string on_func_use_signal_for_out_hedge_1_hedg_order_page { get; set; }
        public string on_func_use_signal_for_out_hedge_2_hedg_order_page { get; set; }
        public string on_func_use_signal_for_out_hedge_3_hedg_order_page { get; set; }
        public string on_func_use_signal_for_out_hedge_4_hedg_order_page { get; set; }
        public string on_func_use_signal_for_out_hedge_5_hedg_order_page { get; set; }
        public string on_func_use_signal_for_out_hedge_6_hedg_order_page { get; set; }
        public string on_func_use_signal_for_out_hedge_7_hedg_order_page { get; set; }
        public string on_func_use_signal_for_out_hedge_8_hedg_order_page { get; set; }
        public string on_func_use_signal_for_out_hedge_9_hedg_order_page { get; set; }
        public string on_func_use_signal_for_out_hedge_10_hedg_order_page { get; set; }
        public string on_func_use_signal_for_out_hedge_11_hedg_order_page { get; set; }
        public string on_func_use_signal_for_out_hedge_12_hedg_order_page { get; set; }
        public string choice_bar_out_hedge_0_hedg_order_page { get; set; }
        public string choice_bar_out_hedge_1_hedg_order_page { get; set; }
        public string choice_bar_out_hedge_2_hedg_order_page { get; set; }
        public string choice_bar_out_hedge_3_hedg_order_page { get; set; }
        public string choice_bar_out_hedge_4_hedg_order_page { get; set; }
        public string choice_bar_out_hedge_5_hedg_order_page { get; set; }
        public string choice_bar_out_hedge_6_hedg_order_page { get; set; }
        public string choice_bar_out_hedge_7_hedg_order_page { get; set; }
        public string choice_bar_out_hedge_8_hedg_order_page { get; set; }
        public string choice_bar_out_hedge_9_hedg_order_page { get; set; }
        public string choice_bar_out_hedge_10_hedg_order_page { get; set; }
        public string choice_bar_out_hedge_11_hedg_order_page { get; set; }
        public string choice_bar_out_hedge_12_hedg_order_page { get; set; }
        public string fix_volume_hedge_0_hedg_order_page { get; set; }
        public string fix_volume_hedge_1_hedg_order_page { get; set; }
        public string fix_volume_hedge_2_hedg_order_page { get; set; }
        public string fix_volume_hedge_3_hedg_order_page { get; set; }
        public string fix_volume_hedge_4_hedg_order_page { get; set; }
        public string fix_volume_hedge_5_hedg_order_page { get; set; }
        public string fix_volume_hedge_6_hedg_order_page { get; set; }
        public string fix_volume_hedge_7_hedg_order_page { get; set; }
        public string fix_volume_hedge_8_hedg_order_page { get; set; }
        public string fix_volume_hedge_9_hedg_order_page { get; set; }
        public string fix_volume_hedge_10_hedg_order_page { get; set; }
        public string fix_volume_hedge_11_hedg_order_page { get; set; }
        public string fix_volume_hedge_12_hedg_order_page { get; set; }
        public string on_func_growth_deposit_hedge_0_hedg_order_page { get; set; }
        public string on_func_growth_deposit_hedge_1_hedg_order_page { get; set; }
        public string on_func_growth_deposit_hedge_2_hedg_order_page { get; set; }
        public string on_func_growth_deposit_hedge_3_hedg_order_page { get; set; }
        public string on_func_growth_deposit_hedge_4_hedg_order_page { get; set; }
        public string on_func_growth_deposit_hedge_5_hedg_order_page { get; set; }
        public string on_func_growth_deposit_hedge_6_hedg_order_page { get; set; }
        public string on_func_growth_deposit_hedge_7_hedg_order_page { get; set; }
        public string on_func_growth_deposit_hedge_8_hedg_order_page { get; set; }
        public string on_func_growth_deposit_hedge_9_hedg_order_page { get; set; }
        public string on_func_growth_deposit_hedge_10_hedg_order_page { get; set; }
        public string on_func_growth_deposit_hedge_11_hedg_order_page { get; set; }
        public string on_func_growth_deposit_hedge_12_hedg_order_page { get; set; }
        public string fix_take_percent_hedge_0_hedg_order_page { get; set; }
        public string fix_take_percent_hedge_1_hedg_order_page { get; set; }
        public string fix_take_percent_hedge_2_hedg_order_page { get; set; }
        public string fix_take_percent_hedge_3_hedg_order_page { get; set; }
        public string fix_take_percent_hedge_4_hedg_order_page { get; set; }
        public string fix_take_percent_hedge_5_hedg_order_page { get; set; }
        public string fix_take_percent_hedge_6_hedg_order_page { get; set; }
        public string fix_take_percent_hedge_7_hedg_order_page { get; set; }
        public string fix_take_percent_hedge_8_hedg_order_page { get; set; }
        public string fix_take_percent_hedge_9_hedg_order_page { get; set; }
        public string fix_take_percent_hedge_10_hedg_order_page { get; set; }
        public string fix_take_percent_hedge_11_hedg_order_page { get; set; }
        public string fix_take_percent_hedge_12_hedg_order_page { get; set; }
        public string on_func_part_close_pos_take_hedge_0_hedg_order_page { get; set; }
        public string on_func_part_close_pos_take_hedge_1_hedg_order_page { get; set; }
        public string on_func_part_close_pos_take_hedge_2_hedg_order_page { get; set; }
        public string on_func_part_close_pos_take_hedge_3_hedg_order_page { get; set; }
        public string on_func_part_close_pos_take_hedge_4_hedg_order_page { get; set; }
        public string on_func_part_close_pos_take_hedge_5_hedg_order_page { get; set; }
        public string on_func_part_close_pos_take_hedge_6_hedg_order_page { get; set; }
        public string on_func_part_close_pos_take_hedge_7_hedg_order_page { get; set; }
        public string on_func_part_close_pos_take_hedge_8_hedg_order_page { get; set; }
        public string on_func_part_close_pos_take_hedge_9_hedg_order_page { get; set; }
        public string on_func_part_close_pos_take_hedge_10_hedg_order_page { get; set; }
        public string on_func_part_close_pos_take_hedge_11_hedg_order_page { get; set; }
        public string on_func_part_close_pos_take_hedge_12_hedg_order_page { get; set; }
        public string quantity_parts_take_hedge_0_hedg_order_page { get; set; }
        public string quantity_parts_take_hedge_1_hedg_order_page { get; set; }
        public string quantity_parts_take_hedge_2_hedg_order_page { get; set; }
        public string quantity_parts_take_hedge_3_hedg_order_page { get; set; }
        public string quantity_parts_take_hedge_4_hedg_order_page { get; set; }
        public string quantity_parts_take_hedge_5_hedg_order_page { get; set; }
        public string quantity_parts_take_hedge_6_hedg_order_page { get; set; }
        public string quantity_parts_take_hedge_7_hedg_order_page { get; set; }
        public string quantity_parts_take_hedge_8_hedg_order_page { get; set; }
        public string quantity_parts_take_hedge_9_hedg_order_page { get; set; }
        public string quantity_parts_take_hedge_10_hedg_order_page { get; set; }
        public string quantity_parts_take_hedge_11_hedg_order_page { get; set; }
        public string quantity_parts_take_hedge_12_hedg_order_page { get; set; }
        public string size_parts_take_hedge_0_hedg_order_page { get; set; }
        public string size_parts_take_hedge_1_hedg_order_page { get; set; }
        public string size_parts_take_hedge_2_hedg_order_page { get; set; }
        public string size_parts_take_hedge_3_hedg_order_page { get; set; }
        public string size_parts_take_hedge_4_hedg_order_page { get; set; }
        public string size_parts_take_hedge_5_hedg_order_page { get; set; }
        public string size_parts_take_hedge_6_hedg_order_page { get; set; }
        public string size_parts_take_hedge_7_hedg_order_page { get; set; }
        public string size_parts_take_hedge_8_hedg_order_page { get; set; }
        public string size_parts_take_hedge_9_hedg_order_page { get; set; }
        public string size_parts_take_hedge_10_hedg_order_page { get; set; }
        public string size_parts_take_hedge_11_hedg_order_page { get; set; }
        public string size_parts_take_hedge_12_hedg_order_page { get; set; }
        public string fix_stop_percent_hedge_0_hedg_order_page { get; set; }
        public string fix_stop_percent_hedge_1_hedg_order_page { get; set; }
        public string fix_stop_percent_hedge_2_hedg_order_page { get; set; }
        public string fix_stop_percent_hedge_3_hedg_order_page { get; set; }
        public string fix_stop_percent_hedge_4_hedg_order_page { get; set; }
        public string fix_stop_percent_hedge_5_hedg_order_page { get; set; }
        public string fix_stop_percent_hedge_6_hedg_order_page { get; set; }
        public string fix_stop_percent_hedge_7_hedg_order_page { get; set; }
        public string fix_stop_percent_hedge_8_hedg_order_page { get; set; }
        public string fix_stop_percent_hedge_9_hedg_order_page { get; set; }
        public string fix_stop_percent_hedge_10_hedg_order_page { get; set; }
        public string fix_stop_percent_hedge_11_hedg_order_page { get; set; }
        public string fix_stop_percent_hedge_12_hedg_order_page { get; set; }
        public string on_func_part_close_pos_stop_hedge_0_hedg_order_page { get; set; }
        public string on_func_part_close_pos_stop_hedge_1_hedg_order_page { get; set; }
        public string on_func_part_close_pos_stop_hedge_2_hedg_order_page { get; set; }
        public string on_func_part_close_pos_stop_hedge_3_hedg_order_page { get; set; }
        public string on_func_part_close_pos_stop_hedge_4_hedg_order_page { get; set; }
        public string on_func_part_close_pos_stop_hedge_5_hedg_order_page { get; set; }
        public string on_func_part_close_pos_stop_hedge_6_hedg_order_page { get; set; }
        public string on_func_part_close_pos_stop_hedge_7_hedg_order_page { get; set; }
        public string on_func_part_close_pos_stop_hedge_8_hedg_order_page { get; set; }
        public string on_func_part_close_pos_stop_hedge_9_hedg_order_page { get; set; }
        public string on_func_part_close_pos_stop_hedge_10_hedg_order_page { get; set; }
        public string on_func_part_close_pos_stop_hedge_11_hedg_order_page { get; set; }
        public string on_func_part_close_pos_stop_hedge_12_hedg_order_page { get; set; }
        public string quantity_parts_stop_hedge_0_hedg_order_page { get; set; }
        public string quantity_parts_stop_hedge_1_hedg_order_page { get; set; }
        public string quantity_parts_stop_hedge_2_hedg_order_page { get; set; }
        public string quantity_parts_stop_hedge_3_hedg_order_page { get; set; }
        public string quantity_parts_stop_hedge_4_hedg_order_page { get; set; }
        public string quantity_parts_stop_hedge_5_hedg_order_page { get; set; }
        public string quantity_parts_stop_hedge_6_hedg_order_page { get; set; }
        public string quantity_parts_stop_hedge_7_hedg_order_page { get; set; }
        public string quantity_parts_stop_hedge_8_hedg_order_page { get; set; }
        public string quantity_parts_stop_hedge_9_hedg_order_page { get; set; }
        public string quantity_parts_stop_hedge_10_hedg_order_page { get; set; }
        public string quantity_parts_stop_hedge_11_hedg_order_page { get; set; }
        public string quantity_parts_stop_hedge_12_hedg_order_page { get; set; }
        public string size_parts_stop_hedge_0_hedg_order_page { get; set; }
        public string size_parts_stop_hedge_1_hedg_order_page { get; set; }
        public string size_parts_stop_hedge_2_hedg_order_page { get; set; }
        public string size_parts_stop_hedge_3_hedg_order_page { get; set; }
        public string size_parts_stop_hedge_4_hedg_order_page { get; set; }
        public string size_parts_stop_hedge_5_hedg_order_page { get; set; }
        public string size_parts_stop_hedge_6_hedg_order_page { get; set; }
        public string size_parts_stop_hedge_7_hedg_order_page { get; set; }
        public string size_parts_stop_hedge_8_hedg_order_page { get; set; }
        public string size_parts_stop_hedge_9_hedg_order_page { get; set; }
        public string size_parts_stop_hedge_10_hedg_order_page { get; set; }
        public string size_parts_stop_hedge_11_hedg_order_page { get; set; }
        public string size_parts_stop_hedge_12_hedg_order_page { get; set; }
        public string on_func_use_trailing_hedge_0_hedg_order_page { get; set; }
        public string on_func_use_trailing_hedge_1_hedg_order_page { get; set; }
        public string on_func_use_trailing_hedge_2_hedg_order_page { get; set; }
        public string on_func_use_trailing_hedge_3_hedg_order_page { get; set; }
        public string on_func_use_trailing_hedge_4_hedg_order_page { get; set; }
        public string on_func_use_trailing_hedge_5_hedg_order_page { get; set; }
        public string on_func_use_trailing_hedge_6_hedg_order_page { get; set; }
        public string on_func_use_trailing_hedge_7_hedg_order_page { get; set; }
        public string on_func_use_trailing_hedge_8_hedg_order_page { get; set; }
        public string on_func_use_trailing_hedge_9_hedg_order_page { get; set; }
        public string on_func_use_trailing_hedge_10_hedg_order_page { get; set; }
        public string on_func_use_trailing_hedge_11_hedg_order_page { get; set; }
        public string on_func_use_trailing_hedge_12_hedg_order_page { get; set; }
        public string start_trailing_hedge_0_hedg_order_page { get; set; }
        public string start_trailing_hedge_1_hedg_order_page { get; set; }
        public string start_trailing_hedge_2_hedg_order_page { get; set; }
        public string start_trailing_hedge_3_hedg_order_page { get; set; }
        public string start_trailing_hedge_4_hedg_order_page { get; set; }
        public string start_trailing_hedge_5_hedg_order_page { get; set; }
        public string start_trailing_hedge_6_hedg_order_page { get; set; }
        public string start_trailing_hedge_7_hedg_order_page { get; set; }
        public string start_trailing_hedge_8_hedg_order_page { get; set; }
        public string start_trailing_hedge_9_hedg_order_page { get; set; }
        public string start_trailing_hedge_10_hedg_order_page { get; set; }
        public string start_trailing_hedge_11_hedg_order_page { get; set; }
        public string start_trailing_hedge_12_hedg_order_page { get; set; }
        public string size_trailing_hedge_0_hedg_order_page { get; set; }
        public string size_trailing_hedge_1_hedg_order_page { get; set; }
        public string size_trailing_hedge_2_hedg_order_page { get; set; }
        public string size_trailing_hedge_3_hedg_order_page { get; set; }
        public string size_trailing_hedge_4_hedg_order_page { get; set; }
        public string size_trailing_hedge_5_hedg_order_page { get; set; }
        public string size_trailing_hedge_6_hedg_order_page { get; set; }
        public string size_trailing_hedge_7_hedg_order_page { get; set; }
        public string size_trailing_hedge_8_hedg_order_page { get; set; }
        public string size_trailing_hedge_9_hedg_order_page { get; set; }
        public string size_trailing_hedge_10_hedg_order_page { get; set; }
        public string size_trailing_hedge_11_hedg_order_page { get; set; }
        public string size_trailing_hedge_12_hedg_order_page { get; set; }
        public string on_func_minus_deals_hedge_0_hedg_order_page { get; set; }
        public string on_func_minus_deals_hedge_1_hedg_order_page { get; set; }
        public string on_func_minus_deals_hedge_2_hedg_order_page { get; set; }
        public string on_func_minus_deals_hedge_3_hedg_order_page { get; set; }
        public string on_func_minus_deals_hedge_4_hedg_order_page { get; set; }
        public string on_func_minus_deals_hedge_5_hedg_order_page { get; set; }
        public string on_func_minus_deals_hedge_6_hedg_order_page { get; set; }
        public string on_func_minus_deals_hedge_7_hedg_order_page { get; set; }
        public string on_func_minus_deals_hedge_8_hedg_order_page { get; set; }
        public string on_func_minus_deals_hedge_9_hedg_order_page { get; set; }
        public string on_func_minus_deals_hedge_10_hedg_order_page { get; set; }
        public string on_func_minus_deals_hedge_11_hedg_order_page { get; set; }
        public string on_func_minus_deals_hedge_12_hedg_order_page { get; set; }

        //вкладка Общие параметры
        public string start_trading { get; set; }
        public string stop_trading { get; set; }
        public string coeff_add_profit { get; set; }
        public string take_commission { get; set; }
        public string max_growth_deposit { get; set; }
        public string on_func_auto_reset { get; set; }
        public string max_spread { get; set; }
        public string tester_operating_mode { get; set; } //не используется в интерфейсе
        public string unit { get; set; }
        public string print_debugg_comments { get; set; }
    }

    public class ConfigData 
    {
        public static string file_path = "";
        public static string file_path_out = "gui_out.txt";
        public static Logger logger;
        private Form2 m_form;

        public ConfigData(Form2 form)
        {
            m_form = form;
            Logger log_obj = new Logger();
        }

        public bool ControlFile()
        {
            MethodBase method = MethodBase.GetCurrentMethod();
            if (File.Exists(Logger.m_file_path))
            {
                string msg = $"{Logger.m_prog_name}:{method.Name}: Файл json {Logger.m_file_path} найден";
                Logger.LogMessage(msg);
                return true;
            }
            else
            {
                string msg = $"{Logger.m_prog_name}:{method.Name}: Файл json {Logger.m_file_path} не найден";
                Logger.LogMessage(msg);
                return false;
            }
        }

        public void SaveParams()
        {
            MethodBase method = MethodBase.GetCurrentMethod();
            JsonData data = new JsonData();
            //получаем значения из элементов управления
            data.Symb_row_0_main_page = m_form.SymbRow0MainText;
            data.Symb_row_1_main_page = m_form.SymbRow1MainText;
            data.Symb_row_2_main_page = m_form.SymbRow2MainText;
            data.Symb_row_3_main_page = m_form.SymbRow3MainText;
            data.Symb_row_4_main_page = m_form.SymbRow4MainText;
            data.Symb_row_5_main_page = m_form.SymbRow5MainText;
            data.Symb_row_6_main_page = m_form.SymbRow6MainText;
            data.Symb_row_7_main_page = m_form.SymbRow7MainText;
            data.Symb_row_8_main_page = m_form.SymbRow8MainText;
            data.Symb_row_9_main_page = m_form.SymbRow9MainText;
            data.Symb_row_10_main_page = m_form.SymbRow10MainText;
            data.Symb_row_11_main_page = m_form.SymbRow11MainText;
            data.Symb_row_12_main_page = m_form.SymbRow12MainText;
            data.on_funs_out_only_0_main_page = m_form.OnlyOutRow0MainChecked;
            data.on_funs_out_only_1_main_page = m_form.OnlyOutRow1MainChecked;
            data.on_funs_out_only_2_main_page = m_form.OnlyOutRow2MainChecked;
            data.on_funs_out_only_3_main_page = m_form.OnlyOutRow3MainChecked;
            data.on_funs_out_only_4_main_page = m_form.OnlyOutRow4MainChecked;
            data.on_funs_out_only_5_main_page = m_form.OnlyOutRow5MainChecked;
            data.on_funs_out_only_6_main_page = m_form.OnlyOutRow6MainChecked;
            data.on_funs_out_only_7_main_page = m_form.OnlyOutRow7MainChecked;
            data.on_funs_out_only_8_main_page = m_form.OnlyOutRow8MainChecked;
            data.on_funs_out_only_9_main_page = m_form.OnlyOutRow9MainChecked;
            data.on_funs_out_only_10_main_page = m_form.OnlyOutRow10MainChecked;
            data.on_funs_out_only_11_main_page = m_form.OnlyOutRow11MainChecked;
            data.on_funs_out_only_12_main_page = m_form.OnlyOutRow12MainChecked;
            data.only_long_is_possible_0_main_page = m_form.OnlyLongRow0MainChecked;
            data.only_long_is_possible_1_main_page = m_form.OnlyLongRow1MainChecked;
            data.only_long_is_possible_2_main_page = m_form.OnlyLongRow2MainChecked;
            data.only_long_is_possible_3_main_page = m_form.OnlyLongRow3MainChecked;
            data.only_long_is_possible_4_main_page = m_form.OnlyLongRow4MainChecked;
            data.only_long_is_possible_5_main_page = m_form.OnlyLongRow5MainChecked;
            data.only_long_is_possible_6_main_page = m_form.OnlyLongRow6MainChecked;
            data.only_long_is_possible_7_main_page = m_form.OnlyLongRow7MainChecked;
            data.only_long_is_possible_8_main_page = m_form.OnlyLongRow8MainChecked;
            data.only_long_is_possible_9_main_page = m_form.OnlyLongRow9MainChecked;
            data.only_long_is_possible_10_main_page = m_form.OnlyLongRow10MainChecked;
            data.only_long_is_possible_11_main_page = m_form.OnlyLongRow11MainChecked;
            data.only_long_is_possible_12_main_page = m_form.OnlyLongRow12MainChecked;
            data.only_short_is_possible_0_main_page = m_form.OnlyShortRow0MainChecked;
            data.only_short_is_possible_1_main_page = m_form.OnlyShortRow1MainChecked;
            data.only_short_is_possible_2_main_page = m_form.OnlyShortRow2MainChecked;
            data.only_short_is_possible_3_main_page = m_form.OnlyShortRow3MainChecked;
            data.only_short_is_possible_4_main_page = m_form.OnlyShortRow4MainChecked;
            data.only_short_is_possible_5_main_page = m_form.OnlyShortRow5MainChecked;
            data.only_short_is_possible_6_main_page = m_form.OnlyShortRow6MainChecked;
            data.only_short_is_possible_7_main_page = m_form.OnlyShortRow7MainChecked;
            data.only_short_is_possible_8_main_page = m_form.OnlyShortRow8MainChecked;
            data.only_short_is_possible_9_main_page = m_form.OnlyShortRow9MainChecked;
            data.only_short_is_possible_10_main_page = m_form.OnlyShortRow10MainChecked;
            data.only_short_is_possible_11_main_page = m_form.OnlyShortRow11MainChecked;
            data.only_short_is_possible_12_main_page = m_form.OnlyShortRow12MainChecked;
            data.use_filtr_timing_0_main_page = m_form.UseTimeFiltrRow0Checked;
            data.use_filtr_timing_1_main_page = m_form.UseTimeFiltrRow1Checked;
            data.use_filtr_timing_2_main_page = m_form.UseTimeFiltrRow2Checked;
            data.use_filtr_timing_3_main_page = m_form.UseTimeFiltrRow3Checked;
            data.use_filtr_timing_4_main_page = m_form.UseTimeFiltrRow4Checked;
            data.use_filtr_timing_5_main_page = m_form.UseTimeFiltrRow5Checked;
            data.use_filtr_timing_6_main_page = m_form.UseTimeFiltrRow6Checked;
            data.use_filtr_timing_7_main_page = m_form.UseTimeFiltrRow7Checked;
            data.use_filtr_timing_8_main_page = m_form.UseTimeFiltrRow8Checked;
            data.use_filtr_timing_9_main_page = m_form.UseTimeFiltrRow9Checked;
            data.use_filtr_timing_10_main_page = m_form.UseTimeFiltrRow10Checked;
            data.use_filtr_timing_11_main_page = m_form.UseTimeFiltrRow11Checked;
            data.use_filtr_timing_12_main_page = m_form.UseTimeFiltrRow12Checked;
            data.choice_timing_0_main_page = m_form.CloseAllPosEndTorgRow0Checked;
            data.choice_timing_1_main_page = m_form.CloseAllPosEndTorgRow1Checked;
            data.choice_timing_2_main_page = m_form.CloseAllPosEndTorgRow2Checked;
            data.choice_timing_3_main_page = m_form.CloseAllPosEndTorgRow3Checked;
            data.choice_timing_4_main_page = m_form.CloseAllPosEndTorgRow4Checked;
            data.choice_timing_5_main_page = m_form.CloseAllPosEndTorgRow5Checked;
            data.choice_timing_6_main_page = m_form.CloseAllPosEndTorgRow6Checked;
            data.choice_timing_7_main_page = m_form.CloseAllPosEndTorgRow7Checked;
            data.choice_timing_8_main_page = m_form.CloseAllPosEndTorgRow8Checked;
            data.choice_timing_9_main_page = m_form.CloseAllPosEndTorgRow9Checked;
            data.choice_timing_10_main_page = m_form.CloseAllPosEndTorgRow10Checked;
            data.choice_timing_11_main_page = m_form.CloseAllPosEndTorgRow11Checked;
            data.choice_timing_12_main_page = m_form.CloseAllPosEndTorgRow12Checked;
            data.choice_timing_hedge_0_main_page = m_form.DelNoPairOrdEndTorgRow0Checked;
            data.choice_timing_hedge_1_main_page = m_form.DelNoPairOrdEndTorgRow1Checked;
            data.choice_timing_hedge_2_main_page = m_form.DelNoPairOrdEndTorgRow2Checked;
            data.choice_timing_hedge_3_main_page = m_form.DelNoPairOrdEndTorgRow3Checked;
            data.choice_timing_hedge_4_main_page = m_form.DelNoPairOrdEndTorgRow4Checked;
            data.choice_timing_hedge_5_main_page = m_form.DelNoPairOrdEndTorgRow5Checked;
            data.choice_timing_hedge_6_main_page = m_form.DelNoPairOrdEndTorgRow6Checked;
            data.choice_timing_hedge_7_main_page = m_form.DelNoPairOrdEndTorgRow7Checked;
            data.choice_timing_hedge_8_main_page = m_form.DelNoPairOrdEndTorgRow8Checked;
            data.choice_timing_hedge_9_main_page = m_form.DelNoPairOrdEndTorgRow9Checked;
            data.choice_timing_hedge_10_main_page = m_form.DelNoPairOrdEndTorgRow10Checked;
            data.choice_timing_hedge_11_main_page = m_form.DelNoPairOrdEndTorgRow11Checked;
            data.choice_timing_hedge_12_main_page = m_form.DelNoPairOrdEndTorgRow12Checked;
            data.on_delay_func_minus_0_main_page = m_form.OnDelayOtkupRow0Checked;
            data.on_delay_func_minus_1_main_page = m_form.OnDelayOtkupRow1Checked;
            data.on_delay_func_minus_2_main_page = m_form.OnDelayOtkupRow2Checked;
            data.on_delay_func_minus_3_main_page = m_form.OnDelayOtkupRow3Checked;
            data.on_delay_func_minus_4_main_page = m_form.OnDelayOtkupRow4Checked;
            data.on_delay_func_minus_5_main_page = m_form.OnDelayOtkupRow5Checked;
            data.on_delay_func_minus_6_main_page = m_form.OnDelayOtkupRow6Checked;
            data.on_delay_func_minus_7_main_page = m_form.OnDelayOtkupRow7Checked;
            data.on_delay_func_minus_8_main_page = m_form.OnDelayOtkupRow8Checked;
            data.on_delay_func_minus_9_main_page = m_form.OnDelayOtkupRow9Checked;
            data.on_delay_func_minus_10_main_page = m_form.OnDelayOtkupRow10Checked;
            data.on_delay_func_minus_11_main_page = m_form.OnDelayOtkupRow11Checked;
            data.on_delay_func_minus_12_main_page = m_form.OnDelayOtkupRow12Checked;
            data.series_minus_trades_0_main_page = m_form.SeriesMinusDealRow0Text;
            data.series_minus_trades_1_main_page = m_form.SeriesMinusDealRow1Text;
            data.series_minus_trades_2_main_page = m_form.SeriesMinusDealRow2Text;
            data.series_minus_trades_3_main_page = m_form.SeriesMinusDealRow3Text;
            data.series_minus_trades_4_main_page = m_form.SeriesMinusDealRow4Text;
            data.series_minus_trades_5_main_page = m_form.SeriesMinusDealRow5Text;
            data.series_minus_trades_6_main_page = m_form.SeriesMinusDealRow6Text;
            data.series_minus_trades_7_main_page = m_form.SeriesMinusDealRow7Text;
            data.series_minus_trades_8_main_page = m_form.SeriesMinusDealRow8Text;
            data.series_minus_trades_9_main_page = m_form.SeriesMinusDealRow9Text;
            data.series_minus_trades_10_main_page = m_form.SeriesMinusDealRow10Text;
            data.series_minus_trades_11_main_page = m_form.SeriesMinusDealRow11Text;
            data.series_minus_trades_12_main_page = m_form.SeriesMinusDealRow12Text;
            data.step_growth_deposit_0_main_page = m_form.StepAddDepositRow0Text;
            data.step_growth_deposit_1_main_page = m_form.StepAddDepositRow1Text;
            data.step_growth_deposit_2_main_page = m_form.StepAddDepositRow2Text;
            data.step_growth_deposit_3_main_page = m_form.StepAddDepositRow3Text;
            data.step_growth_deposit_4_main_page = m_form.StepAddDepositRow4Text;
            data.step_growth_deposit_5_main_page = m_form.StepAddDepositRow5Text;
            data.step_growth_deposit_6_main_page = m_form.StepAddDepositRow6Text;
            data.step_growth_deposit_7_main_page = m_form.StepAddDepositRow7Text;
            data.step_growth_deposit_8_main_page = m_form.StepAddDepositRow8Text;
            data.step_growth_deposit_9_main_page = m_form.StepAddDepositRow9Text;
            data.step_growth_deposit_10_main_page = m_form.StepAddDepositRow10Text;
            data.step_growth_deposit_11_main_page = m_form.StepAddDepositRow11Text;
            data.step_growth_deposit_12_main_page = m_form.StepAddDepositRow12Text;
            data.size_deposit_0_main_page = m_form.SizeDepositRow0Text;
            data.size_deposit_1_main_page = m_form.SizeDepositRow1Text;
            data.size_deposit_2_main_page = m_form.SizeDepositRow2Text;
            data.size_deposit_3_main_page = m_form.SizeDepositRow3Text;
            data.size_deposit_4_main_page = m_form.SizeDepositRow4Text;
            data.size_deposit_5_main_page = m_form.SizeDepositRow5Text;
            data.size_deposit_6_main_page = m_form.SizeDepositRow6Text;
            data.size_deposit_7_main_page = m_form.SizeDepositRow7Text;
            data.size_deposit_8_main_page = m_form.SizeDepositRow8Text;
            data.size_deposit_9_main_page = m_form.SizeDepositRow9Text;
            data.size_deposit_10_main_page = m_form.SizeDepositRow10Text;
            data.size_deposit_11_main_page = m_form.SizeDepositRow11Text;
            data.size_deposit_12_main_page = m_form.SizeDepositRow12Text;
            data.Symb_row_0_indicator_page = m_form.SymbRow0IndText;
            data.Symb_row_1_indicator_page = m_form.SymbRow1IndText;
            data.Symb_row_2_indicator_page = m_form.SymbRow2IndText;
            data.Symb_row_3_indicator_page = m_form.SymbRow3IndText;
            data.Symb_row_4_indicator_page = m_form.SymbRow4IndText;
            data.Symb_row_5_indicator_page = m_form.SymbRow5IndText;
            data.Symb_row_6_indicator_page = m_form.SymbRow6IndText;
            data.Symb_row_7_indicator_page = m_form.SymbRow7IndText;
            data.Symb_row_8_indicator_page = m_form.SymbRow8IndText;
            data.Symb_row_9_indicator_page = m_form.SymbRow9IndText;
            data.Symb_row_10_indicator_page = m_form.SymbRow10IndText;
            data.Symb_row_11_indicator_page = m_form.SymbRow11IndText;
            data.Symb_row_12_indicator_page = m_form.SymbRow12IndText;
            data.choice_indicator_in_0_indicator_page = m_form.ChoiceIndRow0Item;
            data.choice_indicator_in_1_indicator_page = m_form.ChoiceIndRow1Item;
            data.choice_indicator_in_2_indicator_page = m_form.ChoiceIndRow2Item;
            data.choice_indicator_in_3_indicator_page = m_form.ChoiceIndRow3Item;
            data.choice_indicator_in_4_indicator_page = m_form.ChoiceIndRow4Item;
            data.choice_indicator_in_5_indicator_page = m_form.ChoiceIndRow5Item;
            data.choice_indicator_in_6_indicator_page = m_form.ChoiceIndRow6Item;
            data.choice_indicator_in_7_indicator_page = m_form.ChoiceIndRow7Item;
            data.choice_indicator_in_8_indicator_page = m_form.ChoiceIndRow8Item;
            data.choice_indicator_in_9_indicator_page = m_form.ChoiceIndRow9Item;
            data.choice_indicator_in_10_indicator_page = m_form.ChoiceIndRow10Item;
            data.choice_indicator_in_11_indicator_page = m_form.ChoiceIndRow11Item;
            data.choice_indicator_in_12_indicator_page = m_form.ChoiceIndRow12Item;
            data.timeframe_indicator_in_0_indicator_page = m_form.ChoicePerRow0Item;
            data.timeframe_indicator_in_1_indicator_page = m_form.ChoicePerRow1Item;
            data.timeframe_indicator_in_2_indicator_page = m_form.ChoicePerRow2Item;
            data.timeframe_indicator_in_3_indicator_page = m_form.ChoicePerRow3Item;
            data.timeframe_indicator_in_4_indicator_page = m_form.ChoicePerRow4Item;
            data.timeframe_indicator_in_5_indicator_page = m_form.ChoicePerRow5Item;
            data.timeframe_indicator_in_6_indicator_page = m_form.ChoicePerRow6Item;
            data.timeframe_indicator_in_7_indicator_page = m_form.ChoicePerRow7Item;
            data.timeframe_indicator_in_8_indicator_page = m_form.ChoicePerRow8Item;
            data.timeframe_indicator_in_9_indicator_page = m_form.ChoicePerRow9Item;
            data.timeframe_indicator_in_10_indicator_page = m_form.ChoicePerRow10Item;
            data.timeframe_indicator_in_11_indicator_page = m_form.ChoicePerRow11Item;
            data.timeframe_indicator_in_12_indicator_page = m_form.ChoicePerRow12Item;
            data.macd_fast_ema_0_indicator_page = m_form.MacdPerFastRow0Text;
            data.macd_fast_ema_1_indicator_page = m_form.MacdPerFastRow1Text;
            data.macd_fast_ema_2_indicator_page = m_form.MacdPerFastRow2Text;
            data.macd_fast_ema_3_indicator_page = m_form.MacdPerFastRow3Text;
            data.macd_fast_ema_4_indicator_page = m_form.MacdPerFastRow4Text;
            data.macd_fast_ema_5_indicator_page = m_form.MacdPerFastRow5Text;
            data.macd_fast_ema_6_indicator_page = m_form.MacdPerFastRow6Text;
            data.macd_fast_ema_7_indicator_page = m_form.MacdPerFastRow7Text;
            data.macd_fast_ema_8_indicator_page = m_form.MacdPerFastRow8Text;
            data.macd_fast_ema_9_indicator_page = m_form.MacdPerFastRow9Text;
            data.macd_fast_ema_10_indicator_page = m_form.MacdPerFastRow10Text;
            data.macd_fast_ema_11_indicator_page = m_form.MacdPerFastRow11Text;
            data.macd_fast_ema_12_indicator_page = m_form.MacdPerFastRow12Text;
            data.macd_slow_ema_0_indicator_page = m_form.MacdPerMidRow0Text;
            data.macd_slow_ema_1_indicator_page = m_form.MacdPerMidRow1Text;
            data.macd_slow_ema_2_indicator_page = m_form.MacdPerMidRow2Text;
            data.macd_slow_ema_3_indicator_page = m_form.MacdPerMidRow3Text;
            data.macd_slow_ema_4_indicator_page = m_form.MacdPerMidRow4Text;
            data.macd_slow_ema_5_indicator_page = m_form.MacdPerMidRow5Text;
            data.macd_slow_ema_6_indicator_page = m_form.MacdPerMidRow6Text;
            data.macd_slow_ema_7_indicator_page = m_form.MacdPerMidRow7Text;
            data.macd_slow_ema_8_indicator_page = m_form.MacdPerMidRow8Text;
            data.macd_slow_ema_9_indicator_page = m_form.MacdPerMidRow9Text;
            data.macd_slow_ema_10_indicator_page = m_form.MacdPerMidRow10Text;
            data.macd_slow_ema_11_indicator_page = m_form.MacdPerMidRow11Text;
            data.macd_slow_ema_12_indicator_page = m_form.MacdPerMidRow12Text;
            data.macd_signal_period_0_indicator_page = m_form.MacdPerSlowRow0Text;
            data.macd_signal_period_1_indicator_page = m_form.MacdPerSlowRow1Text;
            data.macd_signal_period_2_indicator_page = m_form.MacdPerSlowRow2Text;
            data.macd_signal_period_3_indicator_page = m_form.MacdPerSlowRow3Text;
            data.macd_signal_period_4_indicator_page = m_form.MacdPerSlowRow4Text;
            data.macd_signal_period_5_indicator_page = m_form.MacdPerSlowRow5Text;
            data.macd_signal_period_6_indicator_page = m_form.MacdPerSlowRow6Text;
            data.macd_signal_period_7_indicator_page = m_form.MacdPerSlowRow7Text;
            data.macd_signal_period_8_indicator_page = m_form.MacdPerSlowRow8Text;
            data.macd_signal_period_9_indicator_page = m_form.MacdPerSlowRow9Text;
            data.macd_signal_period_10_indicator_page = m_form.MacdPerSlowRow10Text;
            data.macd_signal_period_11_indicator_page = m_form.MacdPerSlowRow11Text;
            data.macd_signal_period_12_indicator_page = m_form.MacdPerSlowRow12Text;
            data.select_signal_macd_0_indicator_page = m_form.MacdSigRow0Item;
            data.select_signal_macd_1_indicator_page = m_form.MacdSigRow1Item;
            data.select_signal_macd_2_indicator_page = m_form.MacdSigRow2Item;
            data.select_signal_macd_3_indicator_page = m_form.MacdSigRow3Item;
            data.select_signal_macd_4_indicator_page = m_form.MacdSigRow4Item;
            data.select_signal_macd_5_indicator_page = m_form.MacdSigRow5Item;
            data.select_signal_macd_6_indicator_page = m_form.MacdSigRow6Item;
            data.select_signal_macd_7_indicator_page = m_form.MacdSigRow7Item;
            data.select_signal_macd_8_indicator_page = m_form.MacdSigRow8Item;
            data.select_signal_macd_9_indicator_page = m_form.MacdSigRow9Item;
            data.select_signal_macd_10_indicator_page = m_form.MacdSigRow10Item;
            data.select_signal_macd_11_indicator_page = m_form.MacdSigRow11Item;
            data.select_signal_macd_12_indicator_page = m_form.MacdSigRow12Item;
            data.step_sar_0_indicator_page = m_form.SarStepRow0Text;
            data.step_sar_1_indicator_page = m_form.SarStepRow1Text;
            data.step_sar_2_indicator_page = m_form.SarStepRow2Text;
            data.step_sar_3_indicator_page = m_form.SarStepRow3Text;
            data.step_sar_4_indicator_page = m_form.SarStepRow4Text;
            data.step_sar_5_indicator_page = m_form.SarStepRow5Text;
            data.step_sar_6_indicator_page = m_form.SarStepRow6Text;
            data.step_sar_7_indicator_page = m_form.SarStepRow7Text;
            data.step_sar_8_indicator_page = m_form.SarStepRow8Text;
            data.step_sar_9_indicator_page = m_form.SarStepRow9Text;
            data.step_sar_10_indicator_page = m_form.SarStepRow10Text;
            data.step_sar_11_indicator_page = m_form.SarStepRow11Text;
            data.step_sar_12_indicator_page = m_form.SarStepRow12Text;
            data.max_step_0_indicator_page = m_form.SarMaxStepRow0Text;
            data.max_step_1_indicator_page = m_form.SarMaxStepRow1Text;
            data.max_step_2_indicator_page = m_form.SarMaxStepRow2Text;
            data.max_step_3_indicator_page = m_form.SarMaxStepRow3Text;
            data.max_step_4_indicator_page = m_form.SarMaxStepRow4Text;
            data.max_step_5_indicator_page = m_form.SarMaxStepRow5Text;
            data.max_step_6_indicator_page = m_form.SarMaxStepRow6Text;
            data.max_step_7_indicator_page = m_form.SarMaxStepRow7Text;
            data.max_step_8_indicator_page = m_form.SarMaxStepRow8Text;
            data.max_step_9_indicator_page = m_form.SarMaxStepRow9Text;
            data.max_step_10_indicator_page = m_form.SarMaxStepRow10Text;
            data.max_step_11_indicator_page = m_form.SarMaxStepRow11Text;
            data.max_step_12_indicator_page = m_form.SarMaxStepRow12Text;
            data.select_signal_sar_0_indicator_page = m_form.SarSigRow0Item;
            data.select_signal_sar_1_indicator_page = m_form.SarSigRow1Item;
            data.select_signal_sar_2_indicator_page = m_form.SarSigRow2Item;
            data.select_signal_sar_3_indicator_page = m_form.SarSigRow3Item;
            data.select_signal_sar_4_indicator_page = m_form.SarSigRow4Item;
            data.select_signal_sar_5_indicator_page = m_form.SarSigRow5Item;
            data.select_signal_sar_6_indicator_page = m_form.SarSigRow6Item;
            data.select_signal_sar_7_indicator_page = m_form.SarSigRow7Item;
            data.select_signal_sar_8_indicator_page = m_form.SarSigRow8Item;
            data.select_signal_sar_9_indicator_page = m_form.SarSigRow9Item;
            data.select_signal_sar_10_indicator_page = m_form.SarSigRow10Item;
            data.select_signal_sar_11_indicator_page = m_form.SarSigRow11Item;
            data.select_signal_sar_12_indicator_page = m_form.SarSigRow12Item;
            data.bands_period_0_indicator_page = m_form.BbPerMaRow0Text;
            data.bands_period_1_indicator_page = m_form.BbPerMaRow1Text;
            data.bands_period_2_indicator_page = m_form.BbPerMaRow2Text;
            data.bands_period_3_indicator_page = m_form.BbPerMaRow3Text;
            data.bands_period_4_indicator_page = m_form.BbPerMaRow4Text;
            data.bands_period_5_indicator_page = m_form.BbPerMaRow5Text;
            data.bands_period_6_indicator_page = m_form.BbPerMaRow6Text;
            data.bands_period_7_indicator_page = m_form.BbPerMaRow7Text;
            data.bands_period_8_indicator_page = m_form.BbPerMaRow8Text;
            data.bands_period_9_indicator_page = m_form.BbPerMaRow9Text;
            data.bands_period_10_indicator_page = m_form.BbPerMaRow10Text;
            data.bands_period_11_indicator_page = m_form.BbPerMaRow11Text;
            data.bands_period_12_indicator_page = m_form.BbPerMaRow12Text;
            data.bands_deviation_0_indicator_page = m_form.BbDevRow0Text;
            data.bands_deviation_1_indicator_page = m_form.BbDevRow1Text;
            data.bands_deviation_2_indicator_page = m_form.BbDevRow2Text;
            data.bands_deviation_3_indicator_page = m_form.BbDevRow3Text;
            data.bands_deviation_4_indicator_page = m_form.BbDevRow4Text;
            data.bands_deviation_5_indicator_page = m_form.BbDevRow5Text;
            data.bands_deviation_6_indicator_page = m_form.BbDevRow6Text;
            data.bands_deviation_7_indicator_page = m_form.BbDevRow7Text;
            data.bands_deviation_8_indicator_page = m_form.BbDevRow8Text;
            data.bands_deviation_9_indicator_page = m_form.BbDevRow9Text;
            data.bands_deviation_10_indicator_page = m_form.BbDevRow10Text;
            data.bands_deviation_11_indicator_page = m_form.BbDevRow11Text;
            data.bands_deviation_12_indicator_page = m_form.BbDevRow12Text;
            data.select_signal_bb_0_indicator_page = m_form.BbSigRow0Item;
            data.select_signal_bb_1_indicator_page = m_form.BbSigRow1Item;
            data.select_signal_bb_2_indicator_page = m_form.BbSigRow2Item;
            data.select_signal_bb_3_indicator_page = m_form.BbSigRow3Item;
            data.select_signal_bb_4_indicator_page = m_form.BbSigRow4Item;
            data.select_signal_bb_5_indicator_page = m_form.BbSigRow5Item;
            data.select_signal_bb_6_indicator_page = m_form.BbSigRow6Item;
            data.select_signal_bb_7_indicator_page = m_form.BbSigRow7Item;
            data.select_signal_bb_8_indicator_page = m_form.BbSigRow8Item;
            data.select_signal_bb_9_indicator_page = m_form.BbSigRow9Item;
            data.select_signal_bb_10_indicator_page = m_form.BbSigRow10Item;
            data.select_signal_bb_11_indicator_page = m_form.BbSigRow11Item;
            data.select_signal_bb_12_indicator_page = m_form.BbSigRow12Item;
            data.Symb_row_0_main_order_page = m_form.SymbRow0MOrdText;
            data.Symb_row_1_main_order_page = m_form.SymbRow1MOrdText;
            data.Symb_row_2_main_order_page = m_form.SymbRow2MOrdText;
            data.Symb_row_3_main_order_page = m_form.SymbRow3MOrdText;
            data.Symb_row_4_main_order_page = m_form.SymbRow4MOrdText;
            data.Symb_row_5_main_order_page = m_form.SymbRow5MOrdText;
            data.Symb_row_6_main_order_page = m_form.SymbRow6MOrdText;
            data.Symb_row_7_main_order_page = m_form.SymbRow7MOrdText;
            data.Symb_row_8_main_order_page = m_form.SymbRow8MOrdText;
            data.Symb_row_9_main_order_page = m_form.SymbRow9MOrdText;
            data.Symb_row_10_main_order_page = m_form.SymbRow10MOrdText;
            data.Symb_row_11_main_order_page = m_form.SymbRow11MOrdText;
            data.Symb_row_12_main_order_page = m_form.SymbRow12MOrdText;
            data.open_main_order_0_main_order_page = m_form.OpenMOrdRow0Checked;
            data.open_main_order_1_main_order_page = m_form.OpenMOrdRow1Checked;
            data.open_main_order_2_main_order_page = m_form.OpenMOrdRow2Checked;
            data.open_main_order_3_main_order_page = m_form.OpenMOrdRow3Checked;
            data.open_main_order_4_main_order_page = m_form.OpenMOrdRow4Checked;
            data.open_main_order_5_main_order_page = m_form.OpenMOrdRow5Checked;
            data.open_main_order_6_main_order_page = m_form.OpenMOrdRow6Checked;
            data.open_main_order_7_main_order_page = m_form.OpenMOrdRow7Checked;
            data.open_main_order_8_main_order_page = m_form.OpenMOrdRow8Checked;
            data.open_main_order_9_main_order_page = m_form.OpenMOrdRow9Checked;
            data.open_main_order_10_main_order_page = m_form.OpenMOrdRow10Checked;
            data.open_main_order_11_main_order_page = m_form.OpenMOrdRow11Checked;
            data.open_main_order_12_main_order_page = m_form.OpenMOrdRow12Checked;
            data.choice_bar_in_0_main_order_page = m_form.BarInMOrdRow0Item;
            data.choice_bar_in_1_main_order_page = m_form.BarInMOrdRow1Item;
            data.choice_bar_in_2_main_order_page = m_form.BarInMOrdRow2Item;
            data.choice_bar_in_3_main_order_page = m_form.BarInMOrdRow3Item;
            data.choice_bar_in_4_main_order_page = m_form.BarInMOrdRow4Item;
            data.choice_bar_in_5_main_order_page = m_form.BarInMOrdRow5Item;
            data.choice_bar_in_6_main_order_page = m_form.BarInMOrdRow6Item;
            data.choice_bar_in_7_main_order_page = m_form.BarInMOrdRow7Item;
            data.choice_bar_in_8_main_order_page = m_form.BarInMOrdRow8Item;
            data.choice_bar_in_9_main_order_page = m_form.BarInMOrdRow9Item;
            data.choice_bar_in_10_main_order_page = m_form.BarInMOrdRow10Item;
            data.choice_bar_in_11_main_order_page = m_form.BarInMOrdRow11Item;
            data.choice_bar_in_12_main_order_page = m_form.BarInMOrdRow12Item;
            data.on_func_ignor_signal_0_main_order_page = m_form.StopInBarMOrdRow0Checked;
            data.on_func_ignor_signal_1_main_order_page = m_form.StopInBarMOrdRow1Checked;
            data.on_func_ignor_signal_2_main_order_page = m_form.StopInBarMOrdRow2Checked;
            data.on_func_ignor_signal_3_main_order_page = m_form.StopInBarMOrdRow3Checked;
            data.on_func_ignor_signal_4_main_order_page = m_form.StopInBarMOrdRow4Checked;
            data.on_func_ignor_signal_5_main_order_page = m_form.StopInBarMOrdRow5Checked;
            data.on_func_ignor_signal_6_main_order_page = m_form.StopInBarMOrdRow6Checked;
            data.on_func_ignor_signal_7_main_order_page = m_form.StopInBarMOrdRow7Checked;
            data.on_func_ignor_signal_8_main_order_page = m_form.StopInBarMOrdRow8Checked;
            data.on_func_ignor_signal_9_main_order_page = m_form.StopInBarMOrdRow9Checked;
            data.on_func_ignor_signal_10_main_order_page = m_form.StopInBarMOrdRow10Checked;
            data.on_func_ignor_signal_11_main_order_page = m_form.StopInBarMOrdRow11Checked;
            data.on_func_ignor_signal_12_main_order_page = m_form.StopInBarMOrdRow12Checked;
            data.quantity_bar_ignor_0_main_order_page = m_form.DelayBarMOrdRow0Text;
            data.quantity_bar_ignor_1_main_order_page = m_form.DelayBarMOrdRow1Text;
            data.quantity_bar_ignor_2_main_order_page = m_form.DelayBarMOrdRow2Text;
            data.quantity_bar_ignor_3_main_order_page = m_form.DelayBarMOrdRow3Text;
            data.quantity_bar_ignor_4_main_order_page = m_form.DelayBarMOrdRow4Text;
            data.quantity_bar_ignor_5_main_order_page = m_form.DelayBarMOrdRow5Text;
            data.quantity_bar_ignor_6_main_order_page = m_form.DelayBarMOrdRow6Text;
            data.quantity_bar_ignor_7_main_order_page = m_form.DelayBarMOrdRow7Text;
            data.quantity_bar_ignor_8_main_order_page = m_form.DelayBarMOrdRow8Text;
            data.quantity_bar_ignor_9_main_order_page = m_form.DelayBarMOrdRow9Text;
            data.quantity_bar_ignor_10_main_order_page = m_form.DelayBarMOrdRow10Text;
            data.quantity_bar_ignor_11_main_order_page = m_form.DelayBarMOrdRow11Text;
            data.quantity_bar_ignor_12_main_order_page = m_form.DelayBarMOrdRow12Text;
            data.on_func_fix_deal_on_bar_0_main_order_page = m_form.FixDealInMOrdRow0Checked;
            data.on_func_fix_deal_on_bar_1_main_order_page = m_form.FixDealInMOrdRow1Checked;
            data.on_func_fix_deal_on_bar_2_main_order_page = m_form.FixDealInMOrdRow2Checked;
            data.on_func_fix_deal_on_bar_3_main_order_page = m_form.FixDealInMOrdRow3Checked;
            data.on_func_fix_deal_on_bar_4_main_order_page = m_form.FixDealInMOrdRow4Checked;
            data.on_func_fix_deal_on_bar_5_main_order_page = m_form.FixDealInMOrdRow5Checked;
            data.on_func_fix_deal_on_bar_6_main_order_page = m_form.FixDealInMOrdRow6Checked;
            data.on_func_fix_deal_on_bar_7_main_order_page = m_form.FixDealInMOrdRow7Checked;
            data.on_func_fix_deal_on_bar_8_main_order_page = m_form.FixDealInMOrdRow8Checked;
            data.on_func_fix_deal_on_bar_9_main_order_page = m_form.FixDealInMOrdRow9Checked;
            data.on_func_fix_deal_on_bar_10_main_order_page = m_form.FixDealInMOrdRow10Checked;
            data.on_func_fix_deal_on_bar_11_main_order_page = m_form.FixDealInMOrdRow11Checked;
            data.on_func_fix_deal_on_bar_12_main_order_page = m_form.FixDealInMOrdRow12Checked;
            data.quantity_deals_on_bar_0_main_order_page = m_form.MaxDealBarMOrdRow0Text;
            data.quantity_deals_on_bar_1_main_order_page = m_form.MaxDealBarMOrdRow1Text;
            data.quantity_deals_on_bar_2_main_order_page = m_form.MaxDealBarMOrdRow2Text;
            data.quantity_deals_on_bar_3_main_order_page = m_form.MaxDealBarMOrdRow3Text;
            data.quantity_deals_on_bar_4_main_order_page = m_form.MaxDealBarMOrdRow4Text;
            data.quantity_deals_on_bar_5_main_order_page = m_form.MaxDealBarMOrdRow5Text;
            data.quantity_deals_on_bar_6_main_order_page = m_form.MaxDealBarMOrdRow6Text;
            data.quantity_deals_on_bar_7_main_order_page = m_form.MaxDealBarMOrdRow7Text;
            data.quantity_deals_on_bar_8_main_order_page = m_form.MaxDealBarMOrdRow8Text;
            data.quantity_deals_on_bar_9_main_order_page = m_form.MaxDealBarMOrdRow9Text;
            data.quantity_deals_on_bar_10_main_order_page = m_form.MaxDealBarMOrdRow10Text;
            data.quantity_deals_on_bar_11_main_order_page = m_form.MaxDealBarMOrdRow11Text;
            data.quantity_deals_on_bar_12_main_order_page = m_form.MaxDealBarMOrdRow12Text;
            data.on_func_use_signal_for_out_0_main_order_page = m_form.OutSigIndMOrdRow0Checked;
            data.on_func_use_signal_for_out_1_main_order_page = m_form.OutSigIndMOrdRow1Checked;
            data.on_func_use_signal_for_out_2_main_order_page = m_form.OutSigIndMOrdRow2Checked;
            data.on_func_use_signal_for_out_3_main_order_page = m_form.OutSigIndMOrdRow3Checked;
            data.on_func_use_signal_for_out_4_main_order_page = m_form.OutSigIndMOrdRow4Checked;
            data.on_func_use_signal_for_out_5_main_order_page = m_form.OutSigIndMOrdRow5Checked;
            data.on_func_use_signal_for_out_6_main_order_page = m_form.OutSigIndMOrdRow6Checked;
            data.on_func_use_signal_for_out_7_main_order_page = m_form.OutSigIndMOrdRow7Checked;
            data.on_func_use_signal_for_out_8_main_order_page = m_form.OutSigIndMOrdRow8Checked;
            data.on_func_use_signal_for_out_9_main_order_page = m_form.OutSigIndMOrdRow9Checked;
            data.on_func_use_signal_for_out_10_main_order_page = m_form.OutSigIndMOrdRow10Checked;
            data.on_func_use_signal_for_out_11_main_order_page = m_form.OutSigIndMOrdRow11Checked;
            data.on_func_use_signal_for_out_12_main_order_page = m_form.OutSigIndMOrdRow12Checked;
            data.choice_bar_out_0_main_order_page = m_form.BarOutMOrdRow0Item;
            data.choice_bar_out_1_main_order_page = m_form.BarOutMOrdRow1Item;
            data.choice_bar_out_2_main_order_page = m_form.BarOutMOrdRow2Item;
            data.choice_bar_out_3_main_order_page = m_form.BarOutMOrdRow3Item;
            data.choice_bar_out_4_main_order_page = m_form.BarOutMOrdRow4Item;
            data.choice_bar_out_5_main_order_page = m_form.BarOutMOrdRow5Item;
            data.choice_bar_out_6_main_order_page = m_form.BarOutMOrdRow6Item;
            data.choice_bar_out_7_main_order_page = m_form.BarOutMOrdRow7Item;
            data.choice_bar_out_8_main_order_page = m_form.BarOutMOrdRow8Item;
            data.choice_bar_out_9_main_order_page = m_form.BarOutMOrdRow9Item;
            data.choice_bar_out_10_main_order_page = m_form.BarOutMOrdRow10Item;
            data.choice_bar_out_11_main_order_page = m_form.BarOutMOrdRow11Item;
            data.choice_bar_out_12_main_order_page = m_form.BarOutMOrdRow12Item;
            data.fix_volume_0_main_order_page = m_form.FixVolMOrdRow0Text;
            data.fix_volume_1_main_order_page = m_form.FixVolMOrdRow1Text;
            data.fix_volume_2_main_order_page = m_form.FixVolMOrdRow2Text;
            data.fix_volume_3_main_order_page = m_form.FixVolMOrdRow3Text;
            data.fix_volume_4_main_order_page = m_form.FixVolMOrdRow4Text;
            data.fix_volume_5_main_order_page = m_form.FixVolMOrdRow5Text;
            data.fix_volume_6_main_order_page = m_form.FixVolMOrdRow6Text;
            data.fix_volume_7_main_order_page = m_form.FixVolMOrdRow7Text;
            data.fix_volume_8_main_order_page = m_form.FixVolMOrdRow8Text;
            data.fix_volume_9_main_order_page = m_form.FixVolMOrdRow9Text;
            data.fix_volume_10_main_order_page = m_form.FixVolMOrdRow10Text;
            data.fix_volume_11_main_order_page = m_form.FixVolMOrdRow11Text;
            data.fix_volume_12_main_order_page = m_form.FixVolMOrdRow12Text;
            data.on_func_growth_deposit_0_main_order_page = m_form.GrowthDepoMOrdRow0Checked;
            data.on_func_growth_deposit_1_main_order_page = m_form.GrowthDepoMOrdRow1Checked;
            data.on_func_growth_deposit_2_main_order_page = m_form.GrowthDepoMOrdRow2Checked;
            data.on_func_growth_deposit_3_main_order_page = m_form.GrowthDepoMOrdRow3Checked;
            data.on_func_growth_deposit_4_main_order_page = m_form.GrowthDepoMOrdRow4Checked;
            data.on_func_growth_deposit_5_main_order_page = m_form.GrowthDepoMOrdRow5Checked;
            data.on_func_growth_deposit_6_main_order_page = m_form.GrowthDepoMOrdRow6Checked;
            data.on_func_growth_deposit_7_main_order_page = m_form.GrowthDepoMOrdRow7Checked;
            data.on_func_growth_deposit_8_main_order_page = m_form.GrowthDepoMOrdRow8Checked;
            data.on_func_growth_deposit_9_main_order_page = m_form.GrowthDepoMOrdRow9Checked;
            data.on_func_growth_deposit_10_main_order_page = m_form.GrowthDepoMOrdRow10Checked;
            data.on_func_growth_deposit_11_main_order_page = m_form.GrowthDepoMOrdRow11Checked;
            data.on_func_growth_deposit_12_main_order_page = m_form.GrowthDepoMOrdRow12Checked;
            data.fix_take_percent_0_main_order_page = m_form.TakeMOrdRow0Text;
            data.fix_take_percent_1_main_order_page = m_form.TakeMOrdRow1Text;
            data.fix_take_percent_2_main_order_page = m_form.TakeMOrdRow2Text;
            data.fix_take_percent_3_main_order_page = m_form.TakeMOrdRow3Text;
            data.fix_take_percent_4_main_order_page = m_form.TakeMOrdRow4Text;
            data.fix_take_percent_5_main_order_page = m_form.TakeMOrdRow5Text;
            data.fix_take_percent_6_main_order_page = m_form.TakeMOrdRow6Text;
            data.fix_take_percent_7_main_order_page = m_form.TakeMOrdRow7Text;
            data.fix_take_percent_8_main_order_page = m_form.TakeMOrdRow8Text;
            data.fix_take_percent_9_main_order_page = m_form.TakeMOrdRow9Text;
            data.fix_take_percent_10_main_order_page = m_form.TakeMOrdRow10Text;
            data.fix_take_percent_11_main_order_page = m_form.TakeMOrdRow11Text;
            data.fix_take_percent_12_main_order_page = m_form.TakeMOrdRow12Text;
            data.on_func_part_close_pos_take_0_main_order_page = m_form.CloseTakePartMOrdRow0Checked;
            data.on_func_part_close_pos_take_1_main_order_page = m_form.CloseTakePartMOrdRow1Checked;
            data.on_func_part_close_pos_take_2_main_order_page = m_form.CloseTakePartMOrdRow2Checked;
            data.on_func_part_close_pos_take_3_main_order_page = m_form.CloseTakePartMOrdRow3Checked;
            data.on_func_part_close_pos_take_4_main_order_page = m_form.CloseTakePartMOrdRow4Checked;
            data.on_func_part_close_pos_take_5_main_order_page = m_form.CloseTakePartMOrdRow5Checked;
            data.on_func_part_close_pos_take_6_main_order_page = m_form.CloseTakePartMOrdRow6Checked;
            data.on_func_part_close_pos_take_7_main_order_page = m_form.CloseTakePartMOrdRow7Checked;
            data.on_func_part_close_pos_take_8_main_order_page = m_form.CloseTakePartMOrdRow8Checked;
            data.on_func_part_close_pos_take_9_main_order_page = m_form.CloseTakePartMOrdRow9Checked;
            data.on_func_part_close_pos_take_10_main_order_page = m_form.CloseTakePartMOrdRow10Checked;
            data.on_func_part_close_pos_take_11_main_order_page = m_form.CloseTakePartMOrdRow11Checked;
            data.on_func_part_close_pos_take_12_main_order_page = m_form.CloseTakePartMOrdRow12Checked;
            data.quantity_parts_take_0_main_order_page = m_form.PartsTakeMOrdRow0Text;
            data.quantity_parts_take_1_main_order_page = m_form.PartsTakeMOrdRow1Text;
            data.quantity_parts_take_2_main_order_page = m_form.PartsTakeMOrdRow2Text;
            data.quantity_parts_take_3_main_order_page = m_form.PartsTakeMOrdRow3Text;
            data.quantity_parts_take_4_main_order_page = m_form.PartsTakeMOrdRow4Text;
            data.quantity_parts_take_5_main_order_page = m_form.PartsTakeMOrdRow5Text;
            data.quantity_parts_take_6_main_order_page = m_form.PartsTakeMOrdRow6Text;
            data.quantity_parts_take_7_main_order_page = m_form.PartsTakeMOrdRow7Text;
            data.quantity_parts_take_8_main_order_page = m_form.PartsTakeMOrdRow8Text;
            data.quantity_parts_take_9_main_order_page = m_form.PartsTakeMOrdRow9Text;
            data.quantity_parts_take_10_main_order_page = m_form.PartsTakeMOrdRow10Text;
            data.quantity_parts_take_11_main_order_page = m_form.PartsTakeMOrdRow11Text;
            data.quantity_parts_take_12_main_order_page = m_form.PartsTakeMOrdRow12Text;
            data.size_parts_take_0_main_order_page = m_form.ValuePartsTakeMOrdRow0Text;
            data.size_parts_take_1_main_order_page = m_form.ValuePartsTakeMOrdRow1Text;
            data.size_parts_take_2_main_order_page = m_form.ValuePartsTakeMOrdRow2Text;
            data.size_parts_take_3_main_order_page = m_form.ValuePartsTakeMOrdRow3Text;
            data.size_parts_take_4_main_order_page = m_form.ValuePartsTakeMOrdRow4Text;
            data.size_parts_take_5_main_order_page = m_form.ValuePartsTakeMOrdRow5Text;
            data.size_parts_take_6_main_order_page = m_form.ValuePartsTakeMOrdRow6Text;
            data.size_parts_take_7_main_order_page = m_form.ValuePartsTakeMOrdRow7Text;
            data.size_parts_take_8_main_order_page = m_form.ValuePartsTakeMOrdRow8Text;
            data.size_parts_take_9_main_order_page = m_form.ValuePartsTakeMOrdRow9Text;
            data.size_parts_take_10_main_order_page = m_form.ValuePartsTakeMOrdRow10Text;
            data.size_parts_take_11_main_order_page = m_form.ValuePartsTakeMOrdRow11Text;
            data.size_parts_take_12_main_order_page = m_form.ValuePartsTakeMOrdRow12Text;
            data.fix_stop_percent_0_main_order_page = m_form.StopMOrdRow0Text;
            data.fix_stop_percent_1_main_order_page = m_form.StopMOrdRow1Text;
            data.fix_stop_percent_2_main_order_page = m_form.StopMOrdRow2Text;
            data.fix_stop_percent_3_main_order_page = m_form.StopMOrdRow3Text;
            data.fix_stop_percent_4_main_order_page = m_form.StopMOrdRow4Text;
            data.fix_stop_percent_5_main_order_page = m_form.StopMOrdRow5Text;
            data.fix_stop_percent_6_main_order_page = m_form.StopMOrdRow6Text;
            data.fix_stop_percent_7_main_order_page = m_form.StopMOrdRow7Text;
            data.fix_stop_percent_8_main_order_page = m_form.StopMOrdRow8Text;
            data.fix_stop_percent_9_main_order_page = m_form.StopMOrdRow9Text;
            data.fix_stop_percent_10_main_order_page = m_form.StopMOrdRow10Text;
            data.fix_stop_percent_11_main_order_page = m_form.StopMOrdRow11Text;
            data.fix_stop_percent_12_main_order_page = m_form.StopMOrdRow12Text;
            data.on_func_part_close_pos_stop_0_main_order_page = m_form.CloseStopPartMOrdRow0Checked;
            data.on_func_part_close_pos_stop_1_main_order_page = m_form.CloseStopPartMOrdRow1Checked;
            data.on_func_part_close_pos_stop_2_main_order_page = m_form.CloseStopPartMOrdRow2Checked;
            data.on_func_part_close_pos_stop_3_main_order_page = m_form.CloseStopPartMOrdRow3Checked;
            data.on_func_part_close_pos_stop_4_main_order_page = m_form.CloseStopPartMOrdRow4Checked;
            data.on_func_part_close_pos_stop_5_main_order_page = m_form.CloseStopPartMOrdRow5Checked;
            data.on_func_part_close_pos_stop_6_main_order_page = m_form.CloseStopPartMOrdRow6Checked;
            data.on_func_part_close_pos_stop_7_main_order_page = m_form.CloseStopPartMOrdRow7Checked;
            data.on_func_part_close_pos_stop_8_main_order_page = m_form.CloseStopPartMOrdRow8Checked;
            data.on_func_part_close_pos_stop_9_main_order_page = m_form.CloseStopPartMOrdRow9Checked;
            data.on_func_part_close_pos_stop_10_main_order_page = m_form.CloseStopPartMOrdRow10Checked;
            data.on_func_part_close_pos_stop_11_main_order_page = m_form.CloseStopPartMOrdRow11Checked;
            data.on_func_part_close_pos_stop_12_main_order_page = m_form.CloseStopPartMOrdRow12Checked;
            data.quantity_parts_stop_0_main_order_page = m_form.PartsStopMOrdRow0Text;
            data.quantity_parts_stop_1_main_order_page = m_form.PartsStopMOrdRow1Text;
            data.quantity_parts_stop_2_main_order_page = m_form.PartsStopMOrdRow2Text;
            data.quantity_parts_stop_3_main_order_page = m_form.PartsStopMOrdRow3Text;
            data.quantity_parts_stop_4_main_order_page = m_form.PartsStopMOrdRow4Text;
            data.quantity_parts_stop_5_main_order_page = m_form.PartsStopMOrdRow5Text;
            data.quantity_parts_stop_6_main_order_page = m_form.PartsStopMOrdRow6Text;
            data.quantity_parts_stop_7_main_order_page = m_form.PartsStopMOrdRow7Text;
            data.quantity_parts_stop_8_main_order_page = m_form.PartsStopMOrdRow8Text;
            data.quantity_parts_stop_9_main_order_page = m_form.PartsStopMOrdRow9Text;
            data.quantity_parts_stop_10_main_order_page = m_form.PartsStopMOrdRow10Text;
            data.quantity_parts_stop_11_main_order_page = m_form.PartsStopMOrdRow11Text;
            data.quantity_parts_stop_12_main_order_page = m_form.PartsStopMOrdRow12Text;
            data.size_parts_stop_0_main_order_page = m_form.ValuePartsStopMOrdRow0Text;
            data.size_parts_stop_1_main_order_page = m_form.ValuePartsStopMOrdRow1Text;
            data.size_parts_stop_2_main_order_page = m_form.ValuePartsStopMOrdRow2Text;
            data.size_parts_stop_3_main_order_page = m_form.ValuePartsStopMOrdRow3Text;
            data.size_parts_stop_4_main_order_page = m_form.ValuePartsStopMOrdRow4Text;
            data.size_parts_stop_5_main_order_page = m_form.ValuePartsStopMOrdRow5Text;
            data.size_parts_stop_6_main_order_page = m_form.ValuePartsStopMOrdRow6Text;
            data.size_parts_stop_7_main_order_page = m_form.ValuePartsStopMOrdRow7Text;
            data.size_parts_stop_8_main_order_page = m_form.ValuePartsStopMOrdRow8Text;
            data.size_parts_stop_9_main_order_page = m_form.ValuePartsStopMOrdRow9Text;
            data.size_parts_stop_10_main_order_page = m_form.ValuePartsStopMOrdRow10Text;
            data.size_parts_stop_11_main_order_page = m_form.ValuePartsStopMOrdRow11Text;
            data.size_parts_stop_12_main_order_page = m_form.ValuePartsStopMOrdRow12Text;
            data.on_func_use_trailing_0_main_order_page = m_form.UseTrailMOrdRow0Checked;
            data.on_func_use_trailing_1_main_order_page = m_form.UseTrailMOrdRow1Checked;
            data.on_func_use_trailing_2_main_order_page = m_form.UseTrailMOrdRow2Checked;
            data.on_func_use_trailing_3_main_order_page = m_form.UseTrailMOrdRow3Checked;
            data.on_func_use_trailing_4_main_order_page = m_form.UseTrailMOrdRow4Checked;
            data.on_func_use_trailing_5_main_order_page = m_form.UseTrailMOrdRow5Checked;
            data.on_func_use_trailing_6_main_order_page = m_form.UseTrailMOrdRow6Checked;
            data.on_func_use_trailing_7_main_order_page = m_form.UseTrailMOrdRow7Checked;
            data.on_func_use_trailing_8_main_order_page = m_form.UseTrailMOrdRow8Checked;
            data.on_func_use_trailing_9_main_order_page = m_form.UseTrailMOrdRow9Checked;
            data.on_func_use_trailing_10_main_order_page = m_form.UseTrailMOrdRow10Checked;
            data.on_func_use_trailing_11_main_order_page = m_form.UseTrailMOrdRow11Checked;
            data.on_func_use_trailing_12_main_order_page = m_form.UseTrailMOrdRow12Checked;
            data.start_trailing_0_main_order_page = m_form.StartCalcTrailMOrdRow0Text;
            data.start_trailing_1_main_order_page = m_form.StartCalcTrailMOrdRow1Text;
            data.start_trailing_2_main_order_page = m_form.StartCalcTrailMOrdRow2Text;
            data.start_trailing_3_main_order_page = m_form.StartCalcTrailMOrdRow3Text;
            data.start_trailing_4_main_order_page = m_form.StartCalcTrailMOrdRow4Text;
            data.start_trailing_5_main_order_page = m_form.StartCalcTrailMOrdRow5Text;
            data.start_trailing_6_main_order_page = m_form.StartCalcTrailMOrdRow6Text;
            data.start_trailing_7_main_order_page = m_form.StartCalcTrailMOrdRow7Text;
            data.start_trailing_8_main_order_page = m_form.StartCalcTrailMOrdRow8Text;
            data.start_trailing_9_main_order_page = m_form.StartCalcTrailMOrdRow9Text;
            data.start_trailing_10_main_order_page = m_form.StartCalcTrailMOrdRow10Text;
            data.start_trailing_11_main_order_page = m_form.StartCalcTrailMOrdRow11Text;
            data.start_trailing_12_main_order_page = m_form.StartCalcTrailMOrdRow12Text;
            data.size_trailing_0_main_order_page = m_form.SizeTrailMOrdRow0Text;
            data.size_trailing_1_main_order_page = m_form.SizeTrailMOrdRow1Text;
            data.size_trailing_2_main_order_page = m_form.SizeTrailMOrdRow2Text;
            data.size_trailing_3_main_order_page = m_form.SizeTrailMOrdRow3Text;
            data.size_trailing_4_main_order_page = m_form.SizeTrailMOrdRow4Text;
            data.size_trailing_5_main_order_page = m_form.SizeTrailMOrdRow5Text;
            data.size_trailing_6_main_order_page = m_form.SizeTrailMOrdRow6Text;
            data.size_trailing_7_main_order_page = m_form.SizeTrailMOrdRow7Text;
            data.size_trailing_8_main_order_page = m_form.SizeTrailMOrdRow8Text;
            data.size_trailing_9_main_order_page = m_form.SizeTrailMOrdRow9Text;
            data.size_trailing_10_main_order_page = m_form.SizeTrailMOrdRow10Text;
            data.size_trailing_11_main_order_page = m_form.SizeTrailMOrdRow11Text;
            data.size_trailing_12_main_order_page = m_form.SizeTrailMOrdRow12Text;
            data.on_func_minus_deals_0_main_order_page = m_form.OtkupMinusMOrderRow0Checked;
            data.on_func_minus_deals_1_main_order_page = m_form.OtkupMinusMOrderRow1Checked;
            data.on_func_minus_deals_2_main_order_page = m_form.OtkupMinusMOrderRow2Checked;
            data.on_func_minus_deals_3_main_order_page = m_form.OtkupMinusMOrderRow3Checked;
            data.on_func_minus_deals_4_main_order_page = m_form.OtkupMinusMOrderRow4Checked;
            data.on_func_minus_deals_5_main_order_page = m_form.OtkupMinusMOrderRow5Checked;
            data.on_func_minus_deals_6_main_order_page = m_form.OtkupMinusMOrderRow6Checked;
            data.on_func_minus_deals_7_main_order_page = m_form.OtkupMinusMOrderRow7Checked;
            data.on_func_minus_deals_8_main_order_page = m_form.OtkupMinusMOrderRow8Checked;
            data.on_func_minus_deals_9_main_order_page = m_form.OtkupMinusMOrderRow9Checked;
            data.on_func_minus_deals_10_main_order_page = m_form.OtkupMinusMOrderRow10Checked;
            data.on_func_minus_deals_11_main_order_page = m_form.OtkupMinusMOrderRow11Checked;
            data.on_func_minus_deals_12_main_order_page = m_form.OtkupMinusMOrderRow12Checked;
            data.Symb_row_0_hedg_order_page = m_form.SymbRow0HOrdText;
            data.Symb_row_1_hedg_order_page = m_form.SymbRow1HOrdText;
            data.Symb_row_2_hedg_order_page = m_form.SymbRow2HOrdText;
            data.Symb_row_3_hedg_order_page = m_form.SymbRow3HOrdText;
            data.Symb_row_4_hedg_order_page = m_form.SymbRow4HOrdText;
            data.Symb_row_5_hedg_order_page = m_form.SymbRow5HOrdText;
            data.Symb_row_6_hedg_order_page = m_form.SymbRow6HOrdText;
            data.Symb_row_7_hedg_order_page = m_form.SymbRow7HOrdText;
            data.Symb_row_8_hedg_order_page = m_form.SymbRow8HOrdText;
            data.Symb_row_9_hedg_order_page = m_form.SymbRow9HOrdText;
            data.Symb_row_10_hedg_order_page = m_form.SymbRow10HOrdText;
            data.Symb_row_11_hedg_order_page = m_form.SymbRow11HOrdText;
            data.Symb_row_12_hedg_order_page = m_form.SymbRow12HOrdText;
            data.on_func_use_hedge_0_hedg_order_page = m_form.OpenHOrdRow0Checked;
            data.on_func_use_hedge_1_hedg_order_page = m_form.OpenHOrdRow1Checked;
            data.on_func_use_hedge_2_hedg_order_page = m_form.OpenHOrdRow2Checked;
            data.on_func_use_hedge_3_hedg_order_page = m_form.OpenHOrdRow3Checked;
            data.on_func_use_hedge_4_hedg_order_page = m_form.OpenHOrdRow4Checked;
            data.on_func_use_hedge_5_hedg_order_page = m_form.OpenHOrdRow5Checked;
            data.on_func_use_hedge_6_hedg_order_page = m_form.OpenHOrdRow6Checked;
            data.on_func_use_hedge_7_hedg_order_page = m_form.OpenHOrdRow7Checked;
            data.on_func_use_hedge_8_hedg_order_page = m_form.OpenHOrdRow8Checked;
            data.on_func_use_hedge_9_hedg_order_page = m_form.OpenHOrdRow9Checked;
            data.on_func_use_hedge_10_hedg_order_page = m_form.OpenHOrdRow10Checked;
            data.on_func_use_hedge_11_hedg_order_page = m_form.OpenHOrdRow11Checked;
            data.on_func_use_hedge_12_hedg_order_page = m_form.OpenHOrdRow12Checked;
            data.choice_bar_in_hedge_0_hedg_order_page = m_form.BarInHOrdRow0Item;
            data.choice_bar_in_hedge_1_hedg_order_page = m_form.BarInHOrdRow1Item;
            data.choice_bar_in_hedge_2_hedg_order_page = m_form.BarInHOrdRow2Item;
            data.choice_bar_in_hedge_3_hedg_order_page = m_form.BarInHOrdRow3Item;
            data.choice_bar_in_hedge_4_hedg_order_page = m_form.BarInHOrdRow4Item;
            data.choice_bar_in_hedge_5_hedg_order_page = m_form.BarInHOrdRow5Item;
            data.choice_bar_in_hedge_6_hedg_order_page = m_form.BarInHOrdRow6Item;
            data.choice_bar_in_hedge_7_hedg_order_page = m_form.BarInHOrdRow7Item;
            data.choice_bar_in_hedge_8_hedg_order_page = m_form.BarInHOrdRow8Item;
            data.choice_bar_in_hedge_9_hedg_order_page = m_form.BarInHOrdRow9Item;
            data.choice_bar_in_hedge_10_hedg_order_page = m_form.BarInHOrdRow10Item;
            data.choice_bar_in_hedge_11_hedg_order_page = m_form.BarInHOrdRow11Item;
            data.choice_bar_in_hedge_12_hedg_order_page = m_form.BarInHOrdRow12Item;
            data.on_func_ignor_signal_hedge_0_hedg_order_page = m_form.StopInBarHOrdRow0Checked;
            data.on_func_ignor_signal_hedge_1_hedg_order_page = m_form.StopInBarHOrdRow1Checked;
            data.on_func_ignor_signal_hedge_2_hedg_order_page = m_form.StopInBarHOrdRow2Checked;
            data.on_func_ignor_signal_hedge_3_hedg_order_page = m_form.StopInBarHOrdRow3Checked;
            data.on_func_ignor_signal_hedge_4_hedg_order_page = m_form.StopInBarHOrdRow4Checked;
            data.on_func_ignor_signal_hedge_5_hedg_order_page = m_form.StopInBarHOrdRow5Checked;
            data.on_func_ignor_signal_hedge_6_hedg_order_page = m_form.StopInBarHOrdRow6Checked;
            data.on_func_ignor_signal_hedge_7_hedg_order_page = m_form.StopInBarHOrdRow7Checked;
            data.on_func_ignor_signal_hedge_8_hedg_order_page = m_form.StopInBarHOrdRow8Checked;
            data.on_func_ignor_signal_hedge_9_hedg_order_page = m_form.StopInBarHOrdRow9Checked;
            data.on_func_ignor_signal_hedge_10_hedg_order_page = m_form.StopInBarHOrdRow10Checked;
            data.on_func_ignor_signal_hedge_11_hedg_order_page = m_form.StopInBarHOrdRow11Checked;
            data.on_func_ignor_signal_hedge_12_hedg_order_page = m_form.StopInBarHOrdRow12Checked;
            data.quantity_bar_ignor_hedge_0_hedg_order_page = m_form.DelayBarHOrdRow0Text;
            data.quantity_bar_ignor_hedge_1_hedg_order_page = m_form.DelayBarHOrdRow1Text;
            data.quantity_bar_ignor_hedge_2_hedg_order_page = m_form.DelayBarHOrdRow2Text;
            data.quantity_bar_ignor_hedge_3_hedg_order_page = m_form.DelayBarHOrdRow3Text;
            data.quantity_bar_ignor_hedge_4_hedg_order_page = m_form.DelayBarHOrdRow4Text;
            data.quantity_bar_ignor_hedge_5_hedg_order_page = m_form.DelayBarHOrdRow5Text;
            data.quantity_bar_ignor_hedge_6_hedg_order_page = m_form.DelayBarHOrdRow6Text;
            data.quantity_bar_ignor_hedge_7_hedg_order_page = m_form.DelayBarHOrdRow7Text;
            data.quantity_bar_ignor_hedge_8_hedg_order_page = m_form.DelayBarHOrdRow8Text;
            data.quantity_bar_ignor_hedge_9_hedg_order_page = m_form.DelayBarHOrdRow9Text;
            data.quantity_bar_ignor_hedge_10_hedg_order_page = m_form.DelayBarHOrdRow10Text;
            data.quantity_bar_ignor_hedge_11_hedg_order_page = m_form.DelayBarHOrdRow11Text;
            data.quantity_bar_ignor_hedge_12_hedg_order_page = m_form.DelayBarHOrdRow12Text;
            data.on_func_fix_deal_on_bar_hedge_0_hedg_order_page = m_form.FixDealInHOrdRow0Checked;
            data.on_func_fix_deal_on_bar_hedge_1_hedg_order_page = m_form.FixDealInHOrdRow1Checked;
            data.on_func_fix_deal_on_bar_hedge_2_hedg_order_page = m_form.FixDealInHOrdRow2Checked;
            data.on_func_fix_deal_on_bar_hedge_3_hedg_order_page = m_form.FixDealInHOrdRow3Checked;
            data.on_func_fix_deal_on_bar_hedge_4_hedg_order_page = m_form.FixDealInHOrdRow4Checked;
            data.on_func_fix_deal_on_bar_hedge_5_hedg_order_page = m_form.FixDealInHOrdRow5Checked;
            data.on_func_fix_deal_on_bar_hedge_6_hedg_order_page = m_form.FixDealInHOrdRow6Checked;
            data.on_func_fix_deal_on_bar_hedge_7_hedg_order_page = m_form.FixDealInHOrdRow7Checked;
            data.on_func_fix_deal_on_bar_hedge_8_hedg_order_page = m_form.FixDealInHOrdRow8Checked;
            data.on_func_fix_deal_on_bar_hedge_9_hedg_order_page = m_form.FixDealInHOrdRow9Checked;
            data.on_func_fix_deal_on_bar_hedge_10_hedg_order_page = m_form.FixDealInHOrdRow10Checked;
            data.on_func_fix_deal_on_bar_hedge_11_hedg_order_page = m_form.FixDealInHOrdRow11Checked;
            data.on_func_fix_deal_on_bar_hedge_12_hedg_order_page = m_form.FixDealInHOrdRow12Checked;
            data.quantity_deals_on_bar_hedge_0_hedg_order_page = m_form.MaxDealBarHOrdRow0Text;
            data.quantity_deals_on_bar_hedge_1_hedg_order_page = m_form.MaxDealBarHOrdRow1Text;
            data.quantity_deals_on_bar_hedge_2_hedg_order_page = m_form.MaxDealBarHOrdRow2Text;
            data.quantity_deals_on_bar_hedge_3_hedg_order_page = m_form.MaxDealBarHOrdRow3Text;
            data.quantity_deals_on_bar_hedge_4_hedg_order_page = m_form.MaxDealBarHOrdRow4Text;
            data.quantity_deals_on_bar_hedge_5_hedg_order_page = m_form.MaxDealBarHOrdRow5Text;
            data.quantity_deals_on_bar_hedge_6_hedg_order_page = m_form.MaxDealBarHOrdRow6Text;
            data.quantity_deals_on_bar_hedge_7_hedg_order_page = m_form.MaxDealBarHOrdRow7Text;
            data.quantity_deals_on_bar_hedge_8_hedg_order_page = m_form.MaxDealBarHOrdRow8Text;
            data.quantity_deals_on_bar_hedge_9_hedg_order_page = m_form.MaxDealBarHOrdRow9Text;
            data.quantity_deals_on_bar_hedge_10_hedg_order_page = m_form.MaxDealBarHOrdRow10Text;
            data.quantity_deals_on_bar_hedge_11_hedg_order_page = m_form.MaxDealBarHOrdRow11Text;
            data.quantity_deals_on_bar_hedge_12_hedg_order_page = m_form.MaxDealBarHOrdRow12Text;
            data.on_func_use_signal_for_out_hedge_0_hedg_order_page = m_form.OutSigIndHOrdRow0Checked;
            data.on_func_use_signal_for_out_hedge_1_hedg_order_page = m_form.OutSigIndHOrdRow1Checked;
            data.on_func_use_signal_for_out_hedge_2_hedg_order_page = m_form.OutSigIndHOrdRow2Checked;
            data.on_func_use_signal_for_out_hedge_3_hedg_order_page = m_form.OutSigIndHOrdRow3Checked;
            data.on_func_use_signal_for_out_hedge_4_hedg_order_page = m_form.OutSigIndHOrdRow4Checked;
            data.on_func_use_signal_for_out_hedge_5_hedg_order_page = m_form.OutSigIndHOrdRow5Checked;
            data.on_func_use_signal_for_out_hedge_6_hedg_order_page = m_form.OutSigIndHOrdRow6Checked;
            data.on_func_use_signal_for_out_hedge_7_hedg_order_page = m_form.OutSigIndHOrdRow7Checked;
            data.on_func_use_signal_for_out_hedge_8_hedg_order_page = m_form.OutSigIndHOrdRow8Checked;
            data.on_func_use_signal_for_out_hedge_9_hedg_order_page = m_form.OutSigIndHOrdRow9Checked;
            data.on_func_use_signal_for_out_hedge_10_hedg_order_page = m_form.OutSigIndHOrdRow10Checked;
            data.on_func_use_signal_for_out_hedge_11_hedg_order_page = m_form.OutSigIndHOrdRow11Checked;
            data.on_func_use_signal_for_out_hedge_12_hedg_order_page = m_form.OutSigIndHOrdRow12Checked;
            data.choice_bar_out_hedge_0_hedg_order_page = m_form.BarOutHOrdRow0Item;
            data.choice_bar_out_hedge_1_hedg_order_page = m_form.BarOutHOrdRow1Item;
            data.choice_bar_out_hedge_2_hedg_order_page = m_form.BarOutHOrdRow2Item;
            data.choice_bar_out_hedge_3_hedg_order_page = m_form.BarOutHOrdRow3Item;
            data.choice_bar_out_hedge_4_hedg_order_page = m_form.BarOutHOrdRow4Item;
            data.choice_bar_out_hedge_5_hedg_order_page = m_form.BarOutHOrdRow5Item;
            data.choice_bar_out_hedge_6_hedg_order_page = m_form.BarOutHOrdRow6Item;
            data.choice_bar_out_hedge_7_hedg_order_page = m_form.BarOutHOrdRow7Item;
            data.choice_bar_out_hedge_8_hedg_order_page = m_form.BarOutHOrdRow8Item;
            data.choice_bar_out_hedge_9_hedg_order_page = m_form.BarOutHOrdRow9Item;
            data.choice_bar_out_hedge_10_hedg_order_page = m_form.BarOutHOrdRow10Item;
            data.choice_bar_out_hedge_11_hedg_order_page = m_form.BarOutHOrdRow11Item;
            data.choice_bar_out_hedge_12_hedg_order_page = m_form.BarOutHOrdRow12Item;
            data.fix_volume_hedge_0_hedg_order_page = m_form.FixVolHOrdRow0Text;
            data.fix_volume_hedge_1_hedg_order_page = m_form.FixVolHOrdRow1Text;
            data.fix_volume_hedge_2_hedg_order_page = m_form.FixVolHOrdRow2Text;
            data.fix_volume_hedge_3_hedg_order_page = m_form.FixVolHOrdRow3Text;
            data.fix_volume_hedge_4_hedg_order_page = m_form.FixVolHOrdRow4Text;
            data.fix_volume_hedge_5_hedg_order_page = m_form.FixVolHOrdRow5Text;
            data.fix_volume_hedge_6_hedg_order_page = m_form.FixVolHOrdRow6Text;
            data.fix_volume_hedge_7_hedg_order_page = m_form.FixVolHOrdRow7Text;
            data.fix_volume_hedge_8_hedg_order_page = m_form.FixVolHOrdRow8Text;
            data.fix_volume_hedge_9_hedg_order_page = m_form.FixVolHOrdRow9Text;
            data.fix_volume_hedge_10_hedg_order_page = m_form.FixVolHOrdRow10Text;
            data.fix_volume_hedge_11_hedg_order_page = m_form.FixVolHOrdRow11Text;
            data.fix_volume_hedge_12_hedg_order_page = m_form.FixVolHOrdRow12Text;
            data.on_func_growth_deposit_hedge_0_hedg_order_page = m_form.GrowthDepoHOrdRow0Checked;
            data.on_func_growth_deposit_hedge_1_hedg_order_page = m_form.GrowthDepoHOrdRow1Checked;
            data.on_func_growth_deposit_hedge_2_hedg_order_page = m_form.GrowthDepoHOrdRow2Checked;
            data.on_func_growth_deposit_hedge_3_hedg_order_page = m_form.GrowthDepoHOrdRow3Checked;
            data.on_func_growth_deposit_hedge_4_hedg_order_page = m_form.GrowthDepoHOrdRow4Checked;
            data.on_func_growth_deposit_hedge_5_hedg_order_page = m_form.GrowthDepoHOrdRow5Checked;
            data.on_func_growth_deposit_hedge_6_hedg_order_page = m_form.GrowthDepoHOrdRow6Checked;
            data.on_func_growth_deposit_hedge_7_hedg_order_page = m_form.GrowthDepoHOrdRow7Checked;
            data.on_func_growth_deposit_hedge_8_hedg_order_page = m_form.GrowthDepoHOrdRow8Checked;
            data.on_func_growth_deposit_hedge_9_hedg_order_page = m_form.GrowthDepoHOrdRow9Checked;
            data.on_func_growth_deposit_hedge_10_hedg_order_page = m_form.GrowthDepoHOrdRow10Checked;
            data.on_func_growth_deposit_hedge_11_hedg_order_page = m_form.GrowthDepoHOrdRow11Checked;
            data.on_func_growth_deposit_hedge_12_hedg_order_page = m_form.GrowthDepoHOrdRow12Checked;
            data.fix_take_percent_hedge_0_hedg_order_page = m_form.TakeHOrdRow0Text;
            data.fix_take_percent_hedge_1_hedg_order_page = m_form.TakeHOrdRow1Text;
            data.fix_take_percent_hedge_2_hedg_order_page = m_form.TakeHOrdRow2Text;
            data.fix_take_percent_hedge_3_hedg_order_page = m_form.TakeHOrdRow3Text;
            data.fix_take_percent_hedge_4_hedg_order_page = m_form.TakeHOrdRow4Text;
            data.fix_take_percent_hedge_5_hedg_order_page = m_form.TakeHOrdRow5Text;
            data.fix_take_percent_hedge_6_hedg_order_page = m_form.TakeHOrdRow6Text;
            data.fix_take_percent_hedge_7_hedg_order_page = m_form.TakeHOrdRow7Text;
            data.fix_take_percent_hedge_8_hedg_order_page = m_form.TakeHOrdRow8Text;
            data.fix_take_percent_hedge_9_hedg_order_page = m_form.TakeHOrdRow9Text;
            data.fix_take_percent_hedge_10_hedg_order_page = m_form.TakeHOrdRow10Text;
            data.fix_take_percent_hedge_11_hedg_order_page = m_form.TakeHOrdRow11Text;
            data.fix_take_percent_hedge_12_hedg_order_page = m_form.TakeHOrdRow12Text;
            data.on_func_part_close_pos_take_hedge_0_hedg_order_page = m_form.CloseTakePartHOrdRow0Checked;
            data.on_func_part_close_pos_take_hedge_1_hedg_order_page = m_form.CloseTakePartHOrdRow1Checked;
            data.on_func_part_close_pos_take_hedge_2_hedg_order_page = m_form.CloseTakePartHOrdRow2Checked;
            data.on_func_part_close_pos_take_hedge_3_hedg_order_page = m_form.CloseTakePartHOrdRow3Checked;
            data.on_func_part_close_pos_take_hedge_4_hedg_order_page = m_form.CloseTakePartHOrdRow4Checked;
            data.on_func_part_close_pos_take_hedge_5_hedg_order_page = m_form.CloseTakePartHOrdRow5Checked;
            data.on_func_part_close_pos_take_hedge_6_hedg_order_page = m_form.CloseTakePartHOrdRow6Checked;
            data.on_func_part_close_pos_take_hedge_7_hedg_order_page = m_form.CloseTakePartHOrdRow7Checked;
            data.on_func_part_close_pos_take_hedge_8_hedg_order_page = m_form.CloseTakePartHOrdRow8Checked;
            data.on_func_part_close_pos_take_hedge_9_hedg_order_page = m_form.CloseTakePartHOrdRow9Checked;
            data.on_func_part_close_pos_take_hedge_10_hedg_order_page = m_form.CloseTakePartHOrdRow10Checked;
            data.on_func_part_close_pos_take_hedge_11_hedg_order_page = m_form.CloseTakePartHOrdRow11Checked;
            data.on_func_part_close_pos_take_hedge_12_hedg_order_page = m_form.CloseTakePartHOrdRow12Checked;
            data.quantity_parts_take_hedge_0_hedg_order_page = m_form.PartsTakeHOrdRow0Text;
            data.quantity_parts_take_hedge_1_hedg_order_page = m_form.PartsTakeHOrdRow1Text;
            data.quantity_parts_take_hedge_2_hedg_order_page = m_form.PartsTakeHOrdRow2Text;
            data.quantity_parts_take_hedge_3_hedg_order_page = m_form.PartsTakeHOrdRow3Text;
            data.quantity_parts_take_hedge_4_hedg_order_page = m_form.PartsTakeHOrdRow4Text;
            data.quantity_parts_take_hedge_5_hedg_order_page = m_form.PartsTakeHOrdRow5Text;
            data.quantity_parts_take_hedge_6_hedg_order_page = m_form.PartsTakeHOrdRow6Text;
            data.quantity_parts_take_hedge_7_hedg_order_page = m_form.PartsTakeHOrdRow7Text;
            data.quantity_parts_take_hedge_8_hedg_order_page = m_form.PartsTakeHOrdRow8Text;
            data.quantity_parts_take_hedge_9_hedg_order_page = m_form.PartsTakeHOrdRow9Text;
            data.quantity_parts_take_hedge_10_hedg_order_page = m_form.PartsTakeHOrdRow10Text;
            data.quantity_parts_take_hedge_11_hedg_order_page = m_form.PartsTakeHOrdRow11Text;
            data.quantity_parts_take_hedge_12_hedg_order_page = m_form.PartsTakeHOrdRow12Text;
            data.size_parts_take_hedge_0_hedg_order_page = m_form.ValuePartsTakeHOrdRow0Text;
            data.size_parts_take_hedge_1_hedg_order_page = m_form.ValuePartsTakeHOrdRow1Text;
            data.size_parts_take_hedge_2_hedg_order_page = m_form.ValuePartsTakeHOrdRow2Text;
            data.size_parts_take_hedge_3_hedg_order_page = m_form.ValuePartsTakeHOrdRow3Text;
            data.size_parts_take_hedge_4_hedg_order_page = m_form.ValuePartsTakeHOrdRow4Text;
            data.size_parts_take_hedge_5_hedg_order_page = m_form.ValuePartsTakeHOrdRow5Text;
            data.size_parts_take_hedge_6_hedg_order_page = m_form.ValuePartsTakeHOrdRow6Text;
            data.size_parts_take_hedge_7_hedg_order_page = m_form.ValuePartsTakeHOrdRow7Text;
            data.size_parts_take_hedge_8_hedg_order_page = m_form.ValuePartsTakeHOrdRow8Text;
            data.size_parts_take_hedge_9_hedg_order_page = m_form.ValuePartsTakeHOrdRow9Text;
            data.size_parts_take_hedge_10_hedg_order_page = m_form.ValuePartsTakeHOrdRow10Text;
            data.size_parts_take_hedge_11_hedg_order_page = m_form.ValuePartsTakeHOrdRow11Text;
            data.size_parts_take_hedge_12_hedg_order_page = m_form.ValuePartsTakeHOrdRow12Text;
            data.fix_stop_percent_hedge_0_hedg_order_page = m_form.StopHOrdRow0Text;
            data.fix_stop_percent_hedge_1_hedg_order_page = m_form.StopHOrdRow1Text;
            data.fix_stop_percent_hedge_2_hedg_order_page = m_form.StopHOrdRow2Text;
            data.fix_stop_percent_hedge_3_hedg_order_page = m_form.StopHOrdRow3Text;
            data.fix_stop_percent_hedge_4_hedg_order_page = m_form.StopHOrdRow4Text;
            data.fix_stop_percent_hedge_5_hedg_order_page = m_form.StopHOrdRow5Text;
            data.fix_stop_percent_hedge_6_hedg_order_page = m_form.StopHOrdRow6Text;
            data.fix_stop_percent_hedge_7_hedg_order_page = m_form.StopHOrdRow7Text;
            data.fix_stop_percent_hedge_8_hedg_order_page = m_form.StopHOrdRow8Text;
            data.fix_stop_percent_hedge_9_hedg_order_page = m_form.StopHOrdRow9Text;
            data.fix_stop_percent_hedge_10_hedg_order_page = m_form.StopHOrdRow10Text;
            data.fix_stop_percent_hedge_11_hedg_order_page = m_form.StopHOrdRow11Text;
            data.fix_stop_percent_hedge_12_hedg_order_page = m_form.StopHOrdRow12Text;
            data.on_func_part_close_pos_stop_hedge_0_hedg_order_page = m_form.CloseStopPartHOrdRow0Checked;
            data.on_func_part_close_pos_stop_hedge_1_hedg_order_page = m_form.CloseStopPartHOrdRow1Checked;
            data.on_func_part_close_pos_stop_hedge_2_hedg_order_page = m_form.CloseStopPartHOrdRow2Checked;
            data.on_func_part_close_pos_stop_hedge_3_hedg_order_page = m_form.CloseStopPartHOrdRow3Checked;
            data.on_func_part_close_pos_stop_hedge_4_hedg_order_page = m_form.CloseStopPartHOrdRow4Checked;
            data.on_func_part_close_pos_stop_hedge_5_hedg_order_page = m_form.CloseStopPartHOrdRow5Checked;
            data.on_func_part_close_pos_stop_hedge_6_hedg_order_page = m_form.CloseStopPartHOrdRow6Checked;
            data.on_func_part_close_pos_stop_hedge_7_hedg_order_page = m_form.CloseStopPartHOrdRow7Checked;
            data.on_func_part_close_pos_stop_hedge_8_hedg_order_page = m_form.CloseStopPartHOrdRow8Checked;
            data.on_func_part_close_pos_stop_hedge_9_hedg_order_page = m_form.CloseStopPartHOrdRow9Checked;
            data.on_func_part_close_pos_stop_hedge_10_hedg_order_page = m_form.CloseStopPartHOrdRow10Checked;
            data.on_func_part_close_pos_stop_hedge_11_hedg_order_page = m_form.CloseStopPartHOrdRow11Checked;
            data.on_func_part_close_pos_stop_hedge_12_hedg_order_page = m_form.CloseStopPartHOrdRow12Checked;
            data.quantity_parts_stop_hedge_0_hedg_order_page = m_form.PartsStopHOrdRow0Text;
            data.quantity_parts_stop_hedge_1_hedg_order_page = m_form.PartsStopHOrdRow1Text;
            data.quantity_parts_stop_hedge_2_hedg_order_page = m_form.PartsStopHOrdRow2Text;
            data.quantity_parts_stop_hedge_3_hedg_order_page = m_form.PartsStopHOrdRow3Text;
            data.quantity_parts_stop_hedge_4_hedg_order_page = m_form.PartsStopHOrdRow4Text;
            data.quantity_parts_stop_hedge_5_hedg_order_page = m_form.PartsStopHOrdRow5Text;
            data.quantity_parts_stop_hedge_6_hedg_order_page = m_form.PartsStopHOrdRow6Text;
            data.quantity_parts_stop_hedge_7_hedg_order_page = m_form.PartsStopHOrdRow7Text;
            data.quantity_parts_stop_hedge_8_hedg_order_page = m_form.PartsStopHOrdRow8Text;
            data.quantity_parts_stop_hedge_9_hedg_order_page = m_form.PartsStopHOrdRow9Text;
            data.quantity_parts_stop_hedge_10_hedg_order_page = m_form.PartsStopHOrdRow10Text;
            data.quantity_parts_stop_hedge_11_hedg_order_page = m_form.PartsStopHOrdRow11Text;
            data.quantity_parts_stop_hedge_12_hedg_order_page = m_form.PartsStopHOrdRow12Text;
            data.size_parts_stop_hedge_0_hedg_order_page = m_form.ValuePartsStopHOrdRow0Text;
            data.size_parts_stop_hedge_1_hedg_order_page = m_form.ValuePartsStopHOrdRow1Text;
            data.size_parts_stop_hedge_2_hedg_order_page = m_form.ValuePartsStopHOrdRow2Text;
            data.size_parts_stop_hedge_3_hedg_order_page = m_form.ValuePartsStopHOrdRow3Text;
            data.size_parts_stop_hedge_4_hedg_order_page = m_form.ValuePartsStopHOrdRow4Text;
            data.size_parts_stop_hedge_5_hedg_order_page = m_form.ValuePartsStopHOrdRow5Text;
            data.size_parts_stop_hedge_6_hedg_order_page = m_form.ValuePartsStopHOrdRow6Text;
            data.size_parts_stop_hedge_7_hedg_order_page = m_form.ValuePartsStopHOrdRow7Text;
            data.size_parts_stop_hedge_8_hedg_order_page = m_form.ValuePartsStopHOrdRow8Text;
            data.size_parts_stop_hedge_9_hedg_order_page = m_form.ValuePartsStopHOrdRow9Text;
            data.size_parts_stop_hedge_10_hedg_order_page = m_form.ValuePartsStopHOrdRow10Text;
            data.size_parts_stop_hedge_11_hedg_order_page = m_form.ValuePartsStopHOrdRow11Text;
            data.size_parts_stop_hedge_12_hedg_order_page = m_form.ValuePartsStopHOrdRow12Text;
            data.on_func_use_trailing_hedge_0_hedg_order_page = m_form.UseTrailHOrdRow0Checked;
            data.on_func_use_trailing_hedge_1_hedg_order_page = m_form.UseTrailHOrdRow1Checked;
            data.on_func_use_trailing_hedge_2_hedg_order_page = m_form.UseTrailHOrdRow2Checked;
            data.on_func_use_trailing_hedge_3_hedg_order_page = m_form.UseTrailHOrdRow3Checked;
            data.on_func_use_trailing_hedge_4_hedg_order_page = m_form.UseTrailHOrdRow4Checked;
            data.on_func_use_trailing_hedge_5_hedg_order_page = m_form.UseTrailHOrdRow5Checked;
            data.on_func_use_trailing_hedge_6_hedg_order_page = m_form.UseTrailHOrdRow6Checked;
            data.on_func_use_trailing_hedge_7_hedg_order_page = m_form.UseTrailHOrdRow7Checked;
            data.on_func_use_trailing_hedge_8_hedg_order_page = m_form.UseTrailHOrdRow8Checked;
            data.on_func_use_trailing_hedge_9_hedg_order_page = m_form.UseTrailHOrdRow9Checked;
            data.on_func_use_trailing_hedge_10_hedg_order_page = m_form.UseTrailHOrdRow10Checked;
            data.on_func_use_trailing_hedge_11_hedg_order_page = m_form.UseTrailHOrdRow11Checked;
            data.on_func_use_trailing_hedge_12_hedg_order_page = m_form.UseTrailHOrdRow12Checked;
            data.start_trailing_hedge_0_hedg_order_page = m_form.StartCalcTrailHOrdRow0Text;
            data.start_trailing_hedge_1_hedg_order_page = m_form.StartCalcTrailHOrdRow1Text;
            data.start_trailing_hedge_2_hedg_order_page = m_form.StartCalcTrailHOrdRow2Text;
            data.start_trailing_hedge_3_hedg_order_page = m_form.StartCalcTrailHOrdRow3Text;
            data.start_trailing_hedge_4_hedg_order_page = m_form.StartCalcTrailHOrdRow4Text;
            data.start_trailing_hedge_5_hedg_order_page = m_form.StartCalcTrailHOrdRow5Text;
            data.start_trailing_hedge_6_hedg_order_page = m_form.StartCalcTrailHOrdRow6Text;
            data.start_trailing_hedge_7_hedg_order_page = m_form.StartCalcTrailHOrdRow7Text;
            data.start_trailing_hedge_8_hedg_order_page = m_form.StartCalcTrailHOrdRow8Text;
            data.start_trailing_hedge_9_hedg_order_page = m_form.StartCalcTrailHOrdRow9Text;
            data.start_trailing_hedge_10_hedg_order_page = m_form.StartCalcTrailHOrdRow10Text;
            data.start_trailing_hedge_11_hedg_order_page = m_form.StartCalcTrailHOrdRow11Text;
            data.start_trailing_hedge_12_hedg_order_page = m_form.StartCalcTrailHOrdRow12Text;
            data.size_trailing_hedge_0_hedg_order_page = m_form.SizeTrailHOrdRow0Text;
            data.size_trailing_hedge_1_hedg_order_page = m_form.SizeTrailHOrdRow1Text;
            data.size_trailing_hedge_2_hedg_order_page = m_form.SizeTrailHOrdRow2Text;
            data.size_trailing_hedge_3_hedg_order_page = m_form.SizeTrailHOrdRow3Text;
            data.size_trailing_hedge_4_hedg_order_page = m_form.SizeTrailHOrdRow4Text;
            data.size_trailing_hedge_5_hedg_order_page = m_form.SizeTrailHOrdRow5Text;
            data.size_trailing_hedge_6_hedg_order_page = m_form.SizeTrailHOrdRow6Text;
            data.size_trailing_hedge_7_hedg_order_page = m_form.SizeTrailHOrdRow7Text;
            data.size_trailing_hedge_8_hedg_order_page = m_form.SizeTrailHOrdRow8Text;
            data.size_trailing_hedge_9_hedg_order_page = m_form.SizeTrailHOrdRow9Text;
            data.size_trailing_hedge_10_hedg_order_page = m_form.SizeTrailHOrdRow10Text;
            data.size_trailing_hedge_11_hedg_order_page = m_form.SizeTrailHOrdRow11Text;
            data.size_trailing_hedge_12_hedg_order_page = m_form.SizeTrailHOrdRow12Text;
            data.on_func_minus_deals_hedge_0_hedg_order_page = m_form.OtkupMinusHOrderRow0Checked;
            data.on_func_minus_deals_hedge_1_hedg_order_page = m_form.OtkupMinusHOrderRow1Checked;
            data.on_func_minus_deals_hedge_2_hedg_order_page = m_form.OtkupMinusHOrderRow2Checked;
            data.on_func_minus_deals_hedge_3_hedg_order_page = m_form.OtkupMinusHOrderRow3Checked;
            data.on_func_minus_deals_hedge_4_hedg_order_page = m_form.OtkupMinusHOrderRow4Checked;
            data.on_func_minus_deals_hedge_5_hedg_order_page = m_form.OtkupMinusHOrderRow5Checked;
            data.on_func_minus_deals_hedge_6_hedg_order_page = m_form.OtkupMinusHOrderRow6Checked;
            data.on_func_minus_deals_hedge_7_hedg_order_page = m_form.OtkupMinusHOrderRow7Checked;
            data.on_func_minus_deals_hedge_8_hedg_order_page = m_form.OtkupMinusHOrderRow8Checked;
            data.on_func_minus_deals_hedge_9_hedg_order_page = m_form.OtkupMinusHOrderRow9Checked;
            data.on_func_minus_deals_hedge_10_hedg_order_page = m_form.OtkupMinusHOrderRow10Checked;
            data.on_func_minus_deals_hedge_11_hedg_order_page = m_form.OtkupMinusHOrderRow11Checked;
            data.on_func_minus_deals_hedge_12_hedg_order_page = m_form.OtkupMinusHOrderRow12Checked;
            data.start_trading = m_form.TimeStartControlText;
            data.stop_trading = m_form.TimeEndControlText;
            data.coeff_add_profit = m_form.CoeffAddVolControlText;
            data.take_commission = m_form.UseComissionControlChecked;
            data.max_growth_deposit = m_form.MaxGrowthDepositResetControlText;
            data.on_func_auto_reset = m_form.UseResetDataOtkupControlChecked;
            data.max_spread = m_form.MaxSpreadControlText;
            data.unit = m_form.UnitStopTakeControlItem;
            data.print_debugg_comments = m_form.PrintCommentsControlChecked;

            string json = JsonConvert.SerializeObject(data, Formatting.Indented);
            //cохранение строки JSON в файл с кодировкой ANSI
            File.WriteAllText(
                Logger.m_file_path_out, json, System.Text.Encoding.GetEncoding("windows-1251"));
            string msg = $"{Logger.m_prog_name}:{method.Name}: Данные сохранены в файл json {Logger.m_file_path_out}";
            Logger.LogMessage(msg);
        }

        public void LoadConfig()
        {
            MethodBase method = MethodBase.GetCurrentMethod();
            if (Logger.m_file_path != "")
            {
                if (!ControlFile()) return;
                try
                {
                    string json;
                    using (var reader = new StreamReader(
                        Logger.m_file_path, Encoding.GetEncoding("windows-1251")))
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
                    m_form.SymbRow0HOrdText = configData.Symb_row_0_hedg_order_page;
                    m_form.SymbRow1HOrdText = configData.Symb_row_1_hedg_order_page;
                    m_form.SymbRow2HOrdText = configData.Symb_row_2_hedg_order_page;
                    m_form.SymbRow3HOrdText = configData.Symb_row_3_hedg_order_page;
                    m_form.SymbRow4HOrdText = configData.Symb_row_4_hedg_order_page;
                    m_form.SymbRow5HOrdText = configData.Symb_row_5_hedg_order_page;
                    m_form.SymbRow6HOrdText = configData.Symb_row_6_hedg_order_page;
                    m_form.SymbRow7HOrdText = configData.Symb_row_7_hedg_order_page;
                    m_form.SymbRow8HOrdText = configData.Symb_row_8_hedg_order_page;
                    m_form.SymbRow9HOrdText = configData.Symb_row_9_hedg_order_page;
                    m_form.SymbRow10HOrdText = configData.Symb_row_10_hedg_order_page;
                    m_form.SymbRow11HOrdText = configData.Symb_row_11_hedg_order_page;
                    m_form.SymbRow12HOrdText = configData.Symb_row_12_hedg_order_page;
                    m_form.OpenHOrdRow0Checked = configData.on_func_use_hedge_0_hedg_order_page;
                    m_form.OpenHOrdRow1Checked = configData.on_func_use_hedge_1_hedg_order_page;
                    m_form.OpenHOrdRow2Checked = configData.on_func_use_hedge_2_hedg_order_page;
                    m_form.OpenHOrdRow3Checked = configData.on_func_use_hedge_3_hedg_order_page;
                    m_form.OpenHOrdRow4Checked = configData.on_func_use_hedge_4_hedg_order_page;
                    m_form.OpenHOrdRow5Checked = configData.on_func_use_hedge_5_hedg_order_page;
                    m_form.OpenHOrdRow6Checked = configData.on_func_use_hedge_6_hedg_order_page;
                    m_form.OpenHOrdRow7Checked = configData.on_func_use_hedge_7_hedg_order_page;
                    m_form.OpenHOrdRow8Checked = configData.on_func_use_hedge_8_hedg_order_page;
                    m_form.OpenHOrdRow9Checked = configData.on_func_use_hedge_9_hedg_order_page;
                    m_form.OpenHOrdRow10Checked = configData.on_func_use_hedge_10_hedg_order_page;
                    m_form.OpenHOrdRow11Checked = configData.on_func_use_hedge_11_hedg_order_page;
                    m_form.OpenHOrdRow12Checked = configData.on_func_use_hedge_12_hedg_order_page;
                    m_form.BarInHOrdRow0Item = configData.choice_bar_in_hedge_0_hedg_order_page;
                    m_form.BarInHOrdRow1Item = configData.choice_bar_in_hedge_1_hedg_order_page;
                    m_form.BarInHOrdRow2Item = configData.choice_bar_in_hedge_2_hedg_order_page;
                    m_form.BarInHOrdRow3Item = configData.choice_bar_in_hedge_3_hedg_order_page;
                    m_form.BarInHOrdRow4Item = configData.choice_bar_in_hedge_4_hedg_order_page;
                    m_form.BarInHOrdRow5Item = configData.choice_bar_in_hedge_5_hedg_order_page;
                    m_form.BarInHOrdRow6Item = configData.choice_bar_in_hedge_6_hedg_order_page;
                    m_form.BarInHOrdRow7Item = configData.choice_bar_in_hedge_7_hedg_order_page;
                    m_form.BarInHOrdRow8Item = configData.choice_bar_in_hedge_8_hedg_order_page;
                    m_form.BarInHOrdRow9Item = configData.choice_bar_in_hedge_9_hedg_order_page;
                    m_form.BarInHOrdRow10Item = configData.choice_bar_in_hedge_10_hedg_order_page;
                    m_form.BarInHOrdRow11Item = configData.choice_bar_in_hedge_11_hedg_order_page;
                    m_form.BarInHOrdRow12Item = configData.choice_bar_in_hedge_12_hedg_order_page;
                    m_form.StopInBarHOrdRow0Checked = configData.on_func_ignor_signal_hedge_0_hedg_order_page;
                    m_form.StopInBarHOrdRow1Checked = configData.on_func_ignor_signal_hedge_1_hedg_order_page;
                    m_form.StopInBarHOrdRow2Checked = configData.on_func_ignor_signal_hedge_2_hedg_order_page;
                    m_form.StopInBarHOrdRow3Checked = configData.on_func_ignor_signal_hedge_3_hedg_order_page;
                    m_form.StopInBarHOrdRow4Checked = configData.on_func_ignor_signal_hedge_4_hedg_order_page;
                    m_form.StopInBarHOrdRow5Checked = configData.on_func_ignor_signal_hedge_5_hedg_order_page;
                    m_form.StopInBarHOrdRow6Checked = configData.on_func_ignor_signal_hedge_6_hedg_order_page;
                    m_form.StopInBarHOrdRow7Checked = configData.on_func_ignor_signal_hedge_7_hedg_order_page;
                    m_form.StopInBarHOrdRow8Checked = configData.on_func_ignor_signal_hedge_8_hedg_order_page;
                    m_form.StopInBarHOrdRow9Checked = configData.on_func_ignor_signal_hedge_9_hedg_order_page;
                    m_form.StopInBarHOrdRow10Checked = configData.on_func_ignor_signal_hedge_10_hedg_order_page;
                    m_form.StopInBarHOrdRow11Checked = configData.on_func_ignor_signal_hedge_11_hedg_order_page;
                    m_form.StopInBarHOrdRow12Checked = configData.on_func_ignor_signal_hedge_12_hedg_order_page;
                    m_form.DelayBarHOrdRow0Text = configData.quantity_bar_ignor_hedge_0_hedg_order_page;
                    m_form.DelayBarHOrdRow1Text = configData.quantity_bar_ignor_hedge_1_hedg_order_page;
                    m_form.DelayBarHOrdRow2Text = configData.quantity_bar_ignor_hedge_2_hedg_order_page;
                    m_form.DelayBarHOrdRow3Text = configData.quantity_bar_ignor_hedge_3_hedg_order_page;
                    m_form.DelayBarHOrdRow4Text = configData.quantity_bar_ignor_hedge_4_hedg_order_page;
                    m_form.DelayBarHOrdRow5Text = configData.quantity_bar_ignor_hedge_5_hedg_order_page;
                    m_form.DelayBarHOrdRow6Text = configData.quantity_bar_ignor_hedge_6_hedg_order_page;
                    m_form.DelayBarHOrdRow7Text = configData.quantity_bar_ignor_hedge_7_hedg_order_page;
                    m_form.DelayBarHOrdRow8Text = configData.quantity_bar_ignor_hedge_8_hedg_order_page;
                    m_form.DelayBarHOrdRow9Text = configData.quantity_bar_ignor_hedge_9_hedg_order_page;
                    m_form.DelayBarHOrdRow10Text = configData.quantity_bar_ignor_hedge_10_hedg_order_page;
                    m_form.DelayBarHOrdRow11Text = configData.quantity_bar_ignor_hedge_11_hedg_order_page;
                    m_form.DelayBarHOrdRow12Text = configData.quantity_bar_ignor_hedge_12_hedg_order_page;
                    m_form.FixDealInHOrdRow0Checked = configData.on_func_fix_deal_on_bar_hedge_0_hedg_order_page;
                    m_form.FixDealInHOrdRow1Checked = configData.on_func_fix_deal_on_bar_hedge_1_hedg_order_page;
                    m_form.FixDealInHOrdRow2Checked = configData.on_func_fix_deal_on_bar_hedge_2_hedg_order_page;
                    m_form.FixDealInHOrdRow3Checked = configData.on_func_fix_deal_on_bar_hedge_3_hedg_order_page;
                    m_form.FixDealInHOrdRow4Checked = configData.on_func_fix_deal_on_bar_hedge_4_hedg_order_page;
                    m_form.FixDealInHOrdRow5Checked = configData.on_func_fix_deal_on_bar_hedge_5_hedg_order_page;
                    m_form.FixDealInHOrdRow6Checked = configData.on_func_fix_deal_on_bar_hedge_6_hedg_order_page;
                    m_form.FixDealInHOrdRow7Checked = configData.on_func_fix_deal_on_bar_hedge_7_hedg_order_page;
                    m_form.FixDealInHOrdRow8Checked = configData.on_func_fix_deal_on_bar_hedge_8_hedg_order_page;
                    m_form.FixDealInHOrdRow9Checked = configData.on_func_fix_deal_on_bar_hedge_9_hedg_order_page;
                    m_form.FixDealInHOrdRow10Checked = configData.on_func_fix_deal_on_bar_hedge_10_hedg_order_page;
                    m_form.FixDealInHOrdRow11Checked = configData.on_func_fix_deal_on_bar_hedge_11_hedg_order_page;
                    m_form.FixDealInHOrdRow12Checked = configData.on_func_fix_deal_on_bar_hedge_12_hedg_order_page;
                    m_form.MaxDealBarHOrdRow0Text = configData.quantity_deals_on_bar_hedge_0_hedg_order_page;
                    m_form.MaxDealBarHOrdRow1Text = configData.quantity_deals_on_bar_hedge_1_hedg_order_page;
                    m_form.MaxDealBarHOrdRow2Text = configData.quantity_deals_on_bar_hedge_2_hedg_order_page;
                    m_form.MaxDealBarHOrdRow3Text = configData.quantity_deals_on_bar_hedge_3_hedg_order_page;
                    m_form.MaxDealBarHOrdRow4Text = configData.quantity_deals_on_bar_hedge_4_hedg_order_page;
                    m_form.MaxDealBarHOrdRow5Text = configData.quantity_deals_on_bar_hedge_5_hedg_order_page;
                    m_form.MaxDealBarHOrdRow6Text = configData.quantity_deals_on_bar_hedge_6_hedg_order_page;
                    m_form.MaxDealBarHOrdRow7Text = configData.quantity_deals_on_bar_hedge_7_hedg_order_page;
                    m_form.MaxDealBarHOrdRow8Text = configData.quantity_deals_on_bar_hedge_8_hedg_order_page;
                    m_form.MaxDealBarHOrdRow9Text = configData.quantity_deals_on_bar_hedge_9_hedg_order_page;
                    m_form.MaxDealBarHOrdRow10Text = configData.quantity_deals_on_bar_hedge_10_hedg_order_page;
                    m_form.MaxDealBarHOrdRow11Text = configData.quantity_deals_on_bar_hedge_11_hedg_order_page;
                    m_form.MaxDealBarHOrdRow12Text = configData.quantity_deals_on_bar_hedge_12_hedg_order_page;
                    m_form.OutSigIndHOrdRow0Checked = configData.on_func_use_signal_for_out_hedge_0_hedg_order_page;
                    m_form.OutSigIndHOrdRow1Checked = configData.on_func_use_signal_for_out_hedge_1_hedg_order_page;
                    m_form.OutSigIndHOrdRow2Checked = configData.on_func_use_signal_for_out_hedge_2_hedg_order_page;
                    m_form.OutSigIndHOrdRow3Checked = configData.on_func_use_signal_for_out_hedge_3_hedg_order_page;
                    m_form.OutSigIndHOrdRow4Checked = configData.on_func_use_signal_for_out_hedge_4_hedg_order_page;
                    m_form.OutSigIndHOrdRow5Checked = configData.on_func_use_signal_for_out_hedge_5_hedg_order_page;
                    m_form.OutSigIndHOrdRow6Checked = configData.on_func_use_signal_for_out_hedge_6_hedg_order_page;
                    m_form.OutSigIndHOrdRow7Checked = configData.on_func_use_signal_for_out_hedge_7_hedg_order_page;
                    m_form.OutSigIndHOrdRow8Checked = configData.on_func_use_signal_for_out_hedge_8_hedg_order_page;
                    m_form.OutSigIndHOrdRow9Checked = configData.on_func_use_signal_for_out_hedge_9_hedg_order_page;
                    m_form.OutSigIndHOrdRow10Checked = configData.on_func_use_signal_for_out_hedge_10_hedg_order_page;
                    m_form.OutSigIndHOrdRow11Checked = configData.on_func_use_signal_for_out_hedge_11_hedg_order_page;
                    m_form.OutSigIndHOrdRow12Checked = configData.on_func_use_signal_for_out_hedge_12_hedg_order_page;
                    m_form.BarOutHOrdRow0Item = configData.choice_bar_out_hedge_0_hedg_order_page;
                    m_form.BarOutHOrdRow1Item = configData.choice_bar_out_hedge_1_hedg_order_page;
                    m_form.BarOutHOrdRow2Item = configData.choice_bar_out_hedge_2_hedg_order_page;
                    m_form.BarOutHOrdRow3Item = configData.choice_bar_out_hedge_3_hedg_order_page;
                    m_form.BarOutHOrdRow4Item = configData.choice_bar_out_hedge_4_hedg_order_page;
                    m_form.BarOutHOrdRow5Item = configData.choice_bar_out_hedge_5_hedg_order_page;
                    m_form.BarOutHOrdRow6Item = configData.choice_bar_out_hedge_6_hedg_order_page;
                    m_form.BarOutHOrdRow7Item = configData.choice_bar_out_hedge_7_hedg_order_page;
                    m_form.BarOutHOrdRow8Item = configData.choice_bar_out_hedge_8_hedg_order_page;
                    m_form.BarOutHOrdRow9Item = configData.choice_bar_out_hedge_9_hedg_order_page;
                    m_form.BarOutHOrdRow10Item = configData.choice_bar_out_hedge_10_hedg_order_page;
                    m_form.BarOutHOrdRow11Item = configData.choice_bar_out_hedge_11_hedg_order_page;
                    m_form.BarOutHOrdRow12Item = configData.choice_bar_out_hedge_12_hedg_order_page;
                    m_form.FixVolHOrdRow0Text = configData.fix_volume_hedge_0_hedg_order_page;
                    m_form.FixVolHOrdRow1Text = configData.fix_volume_hedge_1_hedg_order_page;
                    m_form.FixVolHOrdRow2Text = configData.fix_volume_hedge_2_hedg_order_page;
                    m_form.FixVolHOrdRow3Text = configData.fix_volume_hedge_3_hedg_order_page;
                    m_form.FixVolHOrdRow4Text = configData.fix_volume_hedge_4_hedg_order_page;
                    m_form.FixVolHOrdRow5Text = configData.fix_volume_hedge_5_hedg_order_page;
                    m_form.FixVolHOrdRow6Text = configData.fix_volume_hedge_6_hedg_order_page;
                    m_form.FixVolHOrdRow7Text = configData.fix_volume_hedge_7_hedg_order_page;
                    m_form.FixVolHOrdRow8Text = configData.fix_volume_hedge_8_hedg_order_page;
                    m_form.FixVolHOrdRow9Text = configData.fix_volume_hedge_9_hedg_order_page;
                    m_form.FixVolHOrdRow10Text = configData.fix_volume_hedge_10_hedg_order_page;
                    m_form.FixVolHOrdRow11Text = configData.fix_volume_hedge_11_hedg_order_page;
                    m_form.FixVolHOrdRow12Text = configData.fix_volume_hedge_12_hedg_order_page;
                    m_form.GrowthDepoHOrdRow0Checked = configData.on_func_growth_deposit_hedge_0_hedg_order_page;
                    m_form.GrowthDepoHOrdRow1Checked = configData.on_func_growth_deposit_hedge_1_hedg_order_page;
                    m_form.GrowthDepoHOrdRow2Checked = configData.on_func_growth_deposit_hedge_2_hedg_order_page;
                    m_form.GrowthDepoHOrdRow3Checked = configData.on_func_growth_deposit_hedge_3_hedg_order_page;
                    m_form.GrowthDepoHOrdRow4Checked = configData.on_func_growth_deposit_hedge_4_hedg_order_page;
                    m_form.GrowthDepoHOrdRow5Checked = configData.on_func_growth_deposit_hedge_5_hedg_order_page;
                    m_form.GrowthDepoHOrdRow6Checked = configData.on_func_growth_deposit_hedge_6_hedg_order_page;
                    m_form.GrowthDepoHOrdRow7Checked = configData.on_func_growth_deposit_hedge_7_hedg_order_page;
                    m_form.GrowthDepoHOrdRow8Checked = configData.on_func_growth_deposit_hedge_8_hedg_order_page;
                    m_form.GrowthDepoHOrdRow9Checked = configData.on_func_growth_deposit_hedge_9_hedg_order_page;
                    m_form.GrowthDepoHOrdRow10Checked = configData.on_func_growth_deposit_hedge_10_hedg_order_page;
                    m_form.GrowthDepoHOrdRow11Checked = configData.on_func_growth_deposit_hedge_11_hedg_order_page;
                    m_form.GrowthDepoHOrdRow12Checked = configData.on_func_growth_deposit_hedge_12_hedg_order_page;
                    m_form.TakeHOrdRow0Text = configData.fix_take_percent_hedge_0_hedg_order_page;
                    m_form.TakeHOrdRow1Text = configData.fix_take_percent_hedge_1_hedg_order_page;
                    m_form.TakeHOrdRow2Text = configData.fix_take_percent_hedge_2_hedg_order_page;
                    m_form.TakeHOrdRow3Text = configData.fix_take_percent_hedge_3_hedg_order_page;
                    m_form.TakeHOrdRow4Text = configData.fix_take_percent_hedge_4_hedg_order_page;
                    m_form.TakeHOrdRow5Text = configData.fix_take_percent_hedge_5_hedg_order_page;
                    m_form.TakeHOrdRow6Text = configData.fix_take_percent_hedge_6_hedg_order_page;
                    m_form.TakeHOrdRow7Text = configData.fix_take_percent_hedge_7_hedg_order_page;
                    m_form.TakeHOrdRow8Text = configData.fix_take_percent_hedge_8_hedg_order_page;
                    m_form.TakeHOrdRow9Text = configData.fix_take_percent_hedge_9_hedg_order_page;
                    m_form.TakeHOrdRow10Text = configData.fix_take_percent_hedge_10_hedg_order_page;
                    m_form.TakeHOrdRow11Text = configData.fix_take_percent_hedge_11_hedg_order_page;
                    m_form.TakeHOrdRow12Text = configData.fix_take_percent_hedge_12_hedg_order_page;
                    m_form.CloseTakePartHOrdRow0Checked = configData.on_func_part_close_pos_take_hedge_0_hedg_order_page;
                    m_form.CloseTakePartHOrdRow1Checked = configData.on_func_part_close_pos_take_hedge_1_hedg_order_page;
                    m_form.CloseTakePartHOrdRow2Checked = configData.on_func_part_close_pos_take_hedge_2_hedg_order_page;
                    m_form.CloseTakePartHOrdRow3Checked = configData.on_func_part_close_pos_take_hedge_3_hedg_order_page;
                    m_form.CloseTakePartHOrdRow4Checked = configData.on_func_part_close_pos_take_hedge_4_hedg_order_page;
                    m_form.CloseTakePartHOrdRow5Checked = configData.on_func_part_close_pos_take_hedge_5_hedg_order_page;
                    m_form.CloseTakePartHOrdRow6Checked = configData.on_func_part_close_pos_take_hedge_6_hedg_order_page;
                    m_form.CloseTakePartHOrdRow7Checked = configData.on_func_part_close_pos_take_hedge_7_hedg_order_page;
                    m_form.CloseTakePartHOrdRow8Checked = configData.on_func_part_close_pos_take_hedge_8_hedg_order_page;
                    m_form.CloseTakePartHOrdRow9Checked = configData.on_func_part_close_pos_take_hedge_9_hedg_order_page;
                    m_form.CloseTakePartHOrdRow10Checked = configData.on_func_part_close_pos_take_hedge_10_hedg_order_page;
                    m_form.CloseTakePartHOrdRow11Checked = configData.on_func_part_close_pos_take_hedge_11_hedg_order_page;
                    m_form.CloseTakePartHOrdRow12Checked = configData.on_func_part_close_pos_take_hedge_12_hedg_order_page;
                    m_form.PartsTakeHOrdRow0Text = configData.quantity_parts_take_hedge_0_hedg_order_page;
                    m_form.PartsTakeHOrdRow1Text = configData.quantity_parts_take_hedge_1_hedg_order_page;
                    m_form.PartsTakeHOrdRow2Text = configData.quantity_parts_take_hedge_2_hedg_order_page;
                    m_form.PartsTakeHOrdRow3Text = configData.quantity_parts_take_hedge_3_hedg_order_page;
                    m_form.PartsTakeHOrdRow4Text = configData.quantity_parts_take_hedge_4_hedg_order_page;
                    m_form.PartsTakeHOrdRow5Text = configData.quantity_parts_take_hedge_5_hedg_order_page;
                    m_form.PartsTakeHOrdRow6Text = configData.quantity_parts_take_hedge_6_hedg_order_page;
                    m_form.PartsTakeHOrdRow7Text = configData.quantity_parts_take_hedge_7_hedg_order_page;
                    m_form.PartsTakeHOrdRow8Text = configData.quantity_parts_take_hedge_8_hedg_order_page;
                    m_form.PartsTakeHOrdRow9Text = configData.quantity_parts_take_hedge_9_hedg_order_page;
                    m_form.PartsTakeHOrdRow10Text = configData.quantity_parts_take_hedge_10_hedg_order_page;
                    m_form.PartsTakeHOrdRow11Text = configData.quantity_parts_take_hedge_11_hedg_order_page;
                    m_form.PartsTakeHOrdRow12Text = configData.quantity_parts_take_hedge_12_hedg_order_page;
                    m_form.ValuePartsTakeHOrdRow0Text = configData.size_parts_take_hedge_0_hedg_order_page;
                    m_form.ValuePartsTakeHOrdRow1Text = configData.size_parts_take_hedge_1_hedg_order_page;
                    m_form.ValuePartsTakeHOrdRow2Text = configData.size_parts_take_hedge_2_hedg_order_page;
                    m_form.ValuePartsTakeHOrdRow3Text = configData.size_parts_take_hedge_3_hedg_order_page;
                    m_form.ValuePartsTakeHOrdRow4Text = configData.size_parts_take_hedge_4_hedg_order_page;
                    m_form.ValuePartsTakeHOrdRow5Text = configData.size_parts_take_hedge_5_hedg_order_page;
                    m_form.ValuePartsTakeHOrdRow6Text = configData.size_parts_take_hedge_6_hedg_order_page;
                    m_form.ValuePartsTakeHOrdRow7Text = configData.size_parts_take_hedge_7_hedg_order_page;
                    m_form.ValuePartsTakeHOrdRow8Text = configData.size_parts_take_hedge_8_hedg_order_page;
                    m_form.ValuePartsTakeHOrdRow9Text = configData.size_parts_take_hedge_9_hedg_order_page;
                    m_form.ValuePartsTakeHOrdRow10Text = configData.size_parts_take_hedge_10_hedg_order_page;
                    m_form.ValuePartsTakeHOrdRow11Text = configData.size_parts_take_hedge_11_hedg_order_page;
                    m_form.ValuePartsTakeHOrdRow12Text = configData.size_parts_take_hedge_12_hedg_order_page;
                    m_form.StopHOrdRow0Text = configData.fix_stop_percent_hedge_0_hedg_order_page;
                    m_form.StopHOrdRow1Text = configData.fix_stop_percent_hedge_1_hedg_order_page;
                    m_form.StopHOrdRow2Text = configData.fix_stop_percent_hedge_2_hedg_order_page;
                    m_form.StopHOrdRow3Text = configData.fix_stop_percent_hedge_3_hedg_order_page;
                    m_form.StopHOrdRow4Text = configData.fix_stop_percent_hedge_4_hedg_order_page;
                    m_form.StopHOrdRow5Text = configData.fix_stop_percent_hedge_5_hedg_order_page;
                    m_form.StopHOrdRow6Text = configData.fix_stop_percent_hedge_6_hedg_order_page;
                    m_form.StopHOrdRow7Text = configData.fix_stop_percent_hedge_7_hedg_order_page;
                    m_form.StopHOrdRow8Text = configData.fix_stop_percent_hedge_8_hedg_order_page;
                    m_form.StopHOrdRow9Text = configData.fix_stop_percent_hedge_9_hedg_order_page;
                    m_form.StopHOrdRow10Text = configData.fix_stop_percent_hedge_10_hedg_order_page;
                    m_form.StopHOrdRow11Text = configData.fix_stop_percent_hedge_11_hedg_order_page;
                    m_form.StopHOrdRow12Text = configData.fix_stop_percent_hedge_12_hedg_order_page;
                    m_form.CloseStopPartHOrdRow0Checked = configData.on_func_part_close_pos_stop_hedge_0_hedg_order_page;
                    m_form.CloseStopPartHOrdRow1Checked = configData.on_func_part_close_pos_stop_hedge_1_hedg_order_page;
                    m_form.CloseStopPartHOrdRow2Checked = configData.on_func_part_close_pos_stop_hedge_2_hedg_order_page;
                    m_form.CloseStopPartHOrdRow3Checked = configData.on_func_part_close_pos_stop_hedge_3_hedg_order_page;
                    m_form.CloseStopPartHOrdRow4Checked = configData.on_func_part_close_pos_stop_hedge_4_hedg_order_page;
                    m_form.CloseStopPartHOrdRow5Checked = configData.on_func_part_close_pos_stop_hedge_5_hedg_order_page;
                    m_form.CloseStopPartHOrdRow6Checked = configData.on_func_part_close_pos_stop_hedge_6_hedg_order_page;
                    m_form.CloseStopPartHOrdRow7Checked = configData.on_func_part_close_pos_stop_hedge_7_hedg_order_page;
                    m_form.CloseStopPartHOrdRow8Checked = configData.on_func_part_close_pos_stop_hedge_8_hedg_order_page;
                    m_form.CloseStopPartHOrdRow9Checked = configData.on_func_part_close_pos_stop_hedge_9_hedg_order_page;
                    m_form.CloseStopPartHOrdRow10Checked = configData.on_func_part_close_pos_stop_hedge_10_hedg_order_page;
                    m_form.CloseStopPartHOrdRow11Checked = configData.on_func_part_close_pos_stop_hedge_11_hedg_order_page;
                    m_form.CloseStopPartHOrdRow12Checked = configData.on_func_part_close_pos_stop_hedge_12_hedg_order_page;
                    m_form.PartsStopHOrdRow0Text = configData.quantity_parts_stop_hedge_0_hedg_order_page;
                    m_form.PartsStopHOrdRow1Text = configData.quantity_parts_stop_hedge_1_hedg_order_page;
                    m_form.PartsStopHOrdRow2Text = configData.quantity_parts_stop_hedge_2_hedg_order_page;
                    m_form.PartsStopHOrdRow3Text = configData.quantity_parts_stop_hedge_3_hedg_order_page;
                    m_form.PartsStopHOrdRow4Text = configData.quantity_parts_stop_hedge_4_hedg_order_page;
                    m_form.PartsStopHOrdRow5Text = configData.quantity_parts_stop_hedge_5_hedg_order_page;
                    m_form.PartsStopHOrdRow6Text = configData.quantity_parts_stop_hedge_6_hedg_order_page;
                    m_form.PartsStopHOrdRow7Text = configData.quantity_parts_stop_hedge_7_hedg_order_page;
                    m_form.PartsStopHOrdRow8Text = configData.quantity_parts_stop_hedge_8_hedg_order_page;
                    m_form.PartsStopHOrdRow9Text = configData.quantity_parts_stop_hedge_9_hedg_order_page;
                    m_form.PartsStopHOrdRow10Text = configData.quantity_parts_stop_hedge_10_hedg_order_page;
                    m_form.PartsStopHOrdRow11Text = configData.quantity_parts_stop_hedge_11_hedg_order_page;
                    m_form.PartsStopHOrdRow12Text = configData.quantity_parts_stop_hedge_12_hedg_order_page;
                    m_form.ValuePartsStopHOrdRow0Text = configData.size_parts_stop_hedge_0_hedg_order_page;
                    m_form.ValuePartsStopHOrdRow1Text = configData.size_parts_stop_hedge_1_hedg_order_page;
                    m_form.ValuePartsStopHOrdRow2Text = configData.size_parts_stop_hedge_2_hedg_order_page;
                    m_form.ValuePartsStopHOrdRow3Text = configData.size_parts_stop_hedge_3_hedg_order_page;
                    m_form.ValuePartsStopHOrdRow4Text = configData.size_parts_stop_hedge_4_hedg_order_page;
                    m_form.ValuePartsStopHOrdRow5Text = configData.size_parts_stop_hedge_5_hedg_order_page;
                    m_form.ValuePartsStopHOrdRow6Text = configData.size_parts_stop_hedge_6_hedg_order_page;
                    m_form.ValuePartsStopHOrdRow7Text = configData.size_parts_stop_hedge_7_hedg_order_page;
                    m_form.ValuePartsStopHOrdRow8Text = configData.size_parts_stop_hedge_8_hedg_order_page;
                    m_form.ValuePartsStopHOrdRow9Text = configData.size_parts_stop_hedge_9_hedg_order_page;
                    m_form.ValuePartsStopHOrdRow10Text = configData.size_parts_stop_hedge_10_hedg_order_page;
                    m_form.ValuePartsStopHOrdRow11Text = configData.size_parts_stop_hedge_11_hedg_order_page;
                    m_form.ValuePartsStopHOrdRow12Text = configData.size_parts_stop_hedge_12_hedg_order_page;
                    m_form.UseTrailHOrdRow0Checked = configData.on_func_use_trailing_hedge_0_hedg_order_page;
                    m_form.UseTrailHOrdRow1Checked = configData.on_func_use_trailing_hedge_1_hedg_order_page;
                    m_form.UseTrailHOrdRow2Checked = configData.on_func_use_trailing_hedge_2_hedg_order_page;
                    m_form.UseTrailHOrdRow3Checked = configData.on_func_use_trailing_hedge_3_hedg_order_page;
                    m_form.UseTrailHOrdRow4Checked = configData.on_func_use_trailing_hedge_4_hedg_order_page;
                    m_form.UseTrailHOrdRow5Checked = configData.on_func_use_trailing_hedge_5_hedg_order_page;
                    m_form.UseTrailHOrdRow6Checked = configData.on_func_use_trailing_hedge_6_hedg_order_page;
                    m_form.UseTrailHOrdRow7Checked = configData.on_func_use_trailing_hedge_7_hedg_order_page;
                    m_form.UseTrailHOrdRow8Checked = configData.on_func_use_trailing_hedge_8_hedg_order_page;
                    m_form.UseTrailHOrdRow9Checked = configData.on_func_use_trailing_hedge_9_hedg_order_page;
                    m_form.UseTrailHOrdRow10Checked = configData.on_func_use_trailing_hedge_10_hedg_order_page;
                    m_form.UseTrailHOrdRow11Checked = configData.on_func_use_trailing_hedge_11_hedg_order_page;
                    m_form.UseTrailHOrdRow12Checked = configData.on_func_use_trailing_hedge_12_hedg_order_page;
                    m_form.StartCalcTrailHOrdRow0Text = configData.start_trailing_hedge_0_hedg_order_page;
                    m_form.StartCalcTrailHOrdRow1Text = configData.start_trailing_hedge_1_hedg_order_page;
                    m_form.StartCalcTrailHOrdRow2Text = configData.start_trailing_hedge_2_hedg_order_page;
                    m_form.StartCalcTrailHOrdRow3Text = configData.start_trailing_hedge_3_hedg_order_page;
                    m_form.StartCalcTrailHOrdRow4Text = configData.start_trailing_hedge_4_hedg_order_page;
                    m_form.StartCalcTrailHOrdRow5Text = configData.start_trailing_hedge_5_hedg_order_page;
                    m_form.StartCalcTrailHOrdRow6Text = configData.start_trailing_hedge_6_hedg_order_page;
                    m_form.StartCalcTrailHOrdRow7Text = configData.start_trailing_hedge_7_hedg_order_page;
                    m_form.StartCalcTrailHOrdRow8Text = configData.start_trailing_hedge_8_hedg_order_page;
                    m_form.StartCalcTrailHOrdRow9Text = configData.start_trailing_hedge_9_hedg_order_page;
                    m_form.StartCalcTrailHOrdRow10Text = configData.start_trailing_hedge_10_hedg_order_page;
                    m_form.StartCalcTrailHOrdRow11Text = configData.start_trailing_hedge_11_hedg_order_page;
                    m_form.StartCalcTrailHOrdRow12Text = configData.start_trailing_hedge_12_hedg_order_page;
                    m_form.SizeTrailHOrdRow0Text = configData.size_trailing_hedge_0_hedg_order_page;
                    m_form.SizeTrailHOrdRow1Text = configData.size_trailing_hedge_1_hedg_order_page;
                    m_form.SizeTrailHOrdRow2Text = configData.size_trailing_hedge_2_hedg_order_page;
                    m_form.SizeTrailHOrdRow3Text = configData.size_trailing_hedge_3_hedg_order_page;
                    m_form.SizeTrailHOrdRow4Text = configData.size_trailing_hedge_4_hedg_order_page;
                    m_form.SizeTrailHOrdRow5Text = configData.size_trailing_hedge_5_hedg_order_page;
                    m_form.SizeTrailHOrdRow6Text = configData.size_trailing_hedge_6_hedg_order_page;
                    m_form.SizeTrailHOrdRow7Text = configData.size_trailing_hedge_7_hedg_order_page;
                    m_form.SizeTrailHOrdRow8Text = configData.size_trailing_hedge_8_hedg_order_page;
                    m_form.SizeTrailHOrdRow9Text = configData.size_trailing_hedge_9_hedg_order_page;
                    m_form.SizeTrailHOrdRow10Text = configData.size_trailing_hedge_10_hedg_order_page;
                    m_form.SizeTrailHOrdRow11Text = configData.size_trailing_hedge_11_hedg_order_page;
                    m_form.SizeTrailHOrdRow12Text = configData.size_trailing_hedge_12_hedg_order_page;
                    m_form.OtkupMinusHOrderRow0Checked = configData.on_func_minus_deals_hedge_0_hedg_order_page;
                    m_form.OtkupMinusHOrderRow1Checked = configData.on_func_minus_deals_hedge_1_hedg_order_page;
                    m_form.OtkupMinusHOrderRow2Checked = configData.on_func_minus_deals_hedge_2_hedg_order_page;
                    m_form.OtkupMinusHOrderRow3Checked = configData.on_func_minus_deals_hedge_3_hedg_order_page;
                    m_form.OtkupMinusHOrderRow4Checked = configData.on_func_minus_deals_hedge_4_hedg_order_page;
                    m_form.OtkupMinusHOrderRow5Checked = configData.on_func_minus_deals_hedge_5_hedg_order_page;
                    m_form.OtkupMinusHOrderRow6Checked = configData.on_func_minus_deals_hedge_6_hedg_order_page;
                    m_form.OtkupMinusHOrderRow7Checked = configData.on_func_minus_deals_hedge_7_hedg_order_page;
                    m_form.OtkupMinusHOrderRow8Checked = configData.on_func_minus_deals_hedge_8_hedg_order_page;
                    m_form.OtkupMinusHOrderRow9Checked = configData.on_func_minus_deals_hedge_9_hedg_order_page;
                    m_form.OtkupMinusHOrderRow10Checked = configData.on_func_minus_deals_hedge_10_hedg_order_page;
                    m_form.OtkupMinusHOrderRow11Checked = configData.on_func_minus_deals_hedge_11_hedg_order_page;
                    m_form.OtkupMinusHOrderRow12Checked = configData.on_func_minus_deals_hedge_12_hedg_order_page;
                    m_form.TimeStartControlText = configData.start_trading;
                    m_form.TimeEndControlText = configData.stop_trading;
                    m_form.CoeffAddVolControlText = configData.coeff_add_profit;
                    m_form.UseComissionControlChecked = configData.take_commission;
                    m_form.MaxGrowthDepositResetControlText = configData.max_growth_deposit;
                    m_form.UseResetDataOtkupControlChecked = configData.on_func_auto_reset;
                    m_form.MaxSpreadControlText = configData.max_spread;
                    m_form.UnitStopTakeControlItem = configData.unit;
                    m_form.PrintCommentsControlChecked = configData.print_debugg_comments;
                }
                catch ( Exception ex )
                {
                    string msg = $"{Logger.m_prog_name}:{method.Name}: Возникло исключение {ex.Message}";
                    Logger.LogMessage(msg);
                }
            }
        }
    }
}
