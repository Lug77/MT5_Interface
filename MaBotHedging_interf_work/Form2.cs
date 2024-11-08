using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaBotHedging_interf_work
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            //UpdateUI();
            ConfigData config = new ConfigData(this);
            config.LoadConfig(); //загрузка значений элементов из json-файл
            //блокируем элементы управления на вкладках
            BlockControls(indicator_page);
            BlockControls(main_order_page);
            BlockControls(hedg_order_page);
            BlockControls(gen_param_page);
            BlockControls(main_page);
        }

        private void Refresh_form(object sender, EventArgs e)
        {
            // Полная перерисовка формы
            this.Invalidate(); // Помечаем форму для перерисовки
            this.Update();     // Обновляем форму немедленно
        }

        private void Close_form(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Вы хотите закрыть окно?",
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
                Close();
        }
        //сохранение значений элементов в json-файл
        private void SaveChange(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Вы хотите изменить параметры советника?",
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
            {
                BlockControls(indicator_page);
                BlockControls(main_order_page);
                BlockControls(hedg_order_page);
                BlockControls(gen_param_page);
                BlockControls(main_page);
                ConfigData config = new ConfigData(this);
                config.SaveParams();
            }
        }

        //блокировка и разблокировка элементов управления на вкладке
        private void BlockControls(TabPage tabPage)
        {
            foreach (Control control in tabPage.Controls)
            {
                control.Enabled = false; // Блокируем элемент управления
            }
        }
        private void UnblockControls(TabPage tabPage)
        {
            foreach (Control control in tabPage.Controls)
            {
                control.Enabled = true; // Разблокируем элемент управления
            }
        }
        //разрешить редактирование элементов управления на вкладках
        private void AllowEdit(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Параметры советника доступны для редактирования");
            UnblockControls(indicator_page);
            UnblockControls(main_order_page);
            UnblockControls(hedg_order_page);
            UnblockControls(gen_param_page);
            UnblockControls(main_page);
        }

        /*
        private void Only_out_row_0_main_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Value_parts_take_m_ord_row_3_TextChanged(object sender, EventArgs e)
        {

        }
        */
    }
}
