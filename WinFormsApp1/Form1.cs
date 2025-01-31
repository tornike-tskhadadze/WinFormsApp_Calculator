namespace WinFormsApp1
{
    public partial class MyForm : Form
    {
        private int _result;
        private string _firstInput;
        private int _secondInput;
        private string _operator;
        private bool _operatorClicked = false;
        public MyForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (_operatorClicked)
            {
                textBox1.Text = button.Text;
                _operatorClicked = false;
            }
            else
            {
                textBox1.Text += button.Text;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (_operatorClicked)
            {
                textBox1.Text = button.Text;
                _operatorClicked = false;
            }
            else
            {
                textBox1.Text += button.Text;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            _firstInput = textBox1.Text;
            textBox1.Text = button.Text;
            _operator = button.Text;
            _operatorClicked = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int first = int.Parse(_firstInput);

            _secondInput = int.Parse(textBox1.Text);

            if (_operator == "+")
            {
                _result = first + _secondInput;
            }
            else if (_operator == "-")
            {
                _result = first - _secondInput;
            }
            else if (_operator == "*")
            {
                _result = first * _secondInput;
            }
            else if (_operator == "/")
            {
                _result = first / _secondInput;
            }
            textBox1.Text = _result.ToString();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (_operatorClicked)
            {
                textBox1.Text = button.Text;
                _operatorClicked = false;
            }
            else
            {
                textBox1.Text += button.Text;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            _firstInput = textBox1.Text;
            textBox1.Text = button.Text;
            _operator = button.Text;
            _operatorClicked = true;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            _firstInput = textBox1.Text;
            textBox1.Text = button.Text;
            _operator = button.Text;
            _operatorClicked = true;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            _firstInput = textBox1.Text;
            textBox1.Text = button.Text;
            _operator = button.Text;
            _operatorClicked = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (_operatorClicked)
            {
                textBox1.Text = button.Text;
                _operatorClicked = false;
            }
            else
            {
                textBox1.Text += button.Text;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (_operatorClicked)
            {
                textBox1.Text = button.Text;
                _operatorClicked = false;
            }
            else
            {
                textBox1.Text += button.Text;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (_operatorClicked)
            {
                textBox1.Text = button.Text;
                _operatorClicked = false;
            }
            else
            {
                textBox1.Text += button.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (_operatorClicked)
            {
                textBox1.Text = button.Text;
                _operatorClicked = false;
            }
            else
            {
                textBox1.Text += button.Text;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (_operatorClicked)
            {
                textBox1.Text = button.Text;
                _operatorClicked = false;
            }
            else
            {
                textBox1.Text += button.Text;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (_operatorClicked)
            {
                textBox1.Text = button.Text;
                _operatorClicked = false;
            }
            else
            {
                textBox1.Text += button.Text;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (_operatorClicked)
            {
                textBox1.Text = button.Text;
                _operatorClicked = false;
            }
            else
            {
                textBox1.Text += button.Text;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            _result = 0;
            _firstInput = "";
            _secondInput = 0;
            _operator = "";
            textBox1.Text = "";
        }
    }
}
