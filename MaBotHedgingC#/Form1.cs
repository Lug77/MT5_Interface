namespace MaBotHedgingC_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //событие загрузка формы
        }

        private void Quit_click(object sender, EventArgs e)
        {
            //выход
            DialogResult result = MessageBox.Show(
                "Все открытые окна интерфейса будут закрыты. Вы уверены?",
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (result == DialogResult.Yes)
                this.Close();
        }

        private void Go_form_2_click(object sender, EventArgs e)
        {
            //переход к форме 2
            //блокировка кнопок перед вызовом 2-ой формы
            Source_load.Enabled = false;
            Go_form_2.Enabled = false;
            //сворачивание формы 1
            this.WindowState = FormWindowState.Minimized;
            //Form2 newForm = new Form2(this);
            Form2 newForm = new Form2();
            newForm.Show();
        }

        private void Check_from_db(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked) {
                MessageBox.Show("Вы выбрали " + radioButton.Text);
            }
        }

        private void Check_from_interface(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                MessageBox.Show("Вы выбрали " + radioButton.Text);
            }
        }

        private void Check_from_param_ea(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                MessageBox.Show("Вы выбрали " + radioButton.Text);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}