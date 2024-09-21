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
            //������� �������� �����
        }

        private void Quit_click(object sender, EventArgs e)
        {
            //�����
            DialogResult result = MessageBox.Show(
                "��� �������� ���� ���������� ����� �������. �� �������?",
                "���������",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (result == DialogResult.Yes)
                this.Close();
        }

        private void Go_form_2_click(object sender, EventArgs e)
        {
            //������� � ����� 2
            //���������� ������ ����� ������� 2-�� �����
            Source_load.Enabled = false;
            Go_form_2.Enabled = false;
            //������������ ����� 1
            this.WindowState = FormWindowState.Minimized;
            //Form2 newForm = new Form2(this);
            Form2 newForm = new Form2();
            newForm.Show();
        }

        private void Check_from_db(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked) {
                MessageBox.Show("�� ������� " + radioButton.Text);
            }
        }

        private void Check_from_interface(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                MessageBox.Show("�� ������� " + radioButton.Text);
            }
        }

        private void Check_from_param_ea(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                MessageBox.Show("�� ������� " + radioButton.Text);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}