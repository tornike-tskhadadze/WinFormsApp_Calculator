namespace WinFormsApp1
{
    public partial class MyForm : Form
    {
        private int _result;
        private string _firstInput;
        private string _secondInput;
        private string _operator;
        public MyForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //textBox1.Text += _result;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            _firstInput = button.Text;
            textBox1.Text += _firstInput;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            _secondInput = button.Text;
            textBox1.Text += _secondInput;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            _operator = button.Text;
            textBox1.Text += _operator;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int first = int.Parse(_firstInput);
            int second = int.Parse(_secondInput);
            if (_operator == "+")
            {
                _result = first + second;
            }
            textBox1.Text = _result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
                
        }
    }
}
