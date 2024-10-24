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
            config.LoadConfig();
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
                "Вы хотите закрыть окно и завершить работу советника?",
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
                Close();
        }
        /*
        private void button1_Click(object sender, EventArgs e)
        {

        }

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
