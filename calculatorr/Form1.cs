namespace calculatorr
{
    public partial class Form1 : Form
    {
        char _operation;
        double _number1;
        double _number2;
        double _result;
        public Form1()
        {
            InitializeComponent();
        }

        private void number1Button_Click(object sender, EventArgs e)
        {
            if (screenLabel.Text == "0")
            {
                screenLabel.Text = "";
            }
            screenLabel.Text += "1";
        }

        private void number2button_Click(object sender, EventArgs e)
        {
            if (screenLabel.Text == "0")
            {
                screenLabel.Text = "";
            }
            screenLabel.Text += "2";
        }

        private void number3Button_Click(object sender, EventArgs e)
        {
            if (screenLabel.Text == "0")
            {
                screenLabel.Text = "";
            }
            screenLabel.Text += "3";
        }

        private void number4Button_Click(object sender, EventArgs e)
        {
            if (screenLabel.Text == "0")
            {
                screenLabel.Text = "";
            }
            screenLabel.Text += "4";
        }

        private void number5Button_Click(object sender, EventArgs e)
        {
            if (screenLabel.Text == "0")
            {
                screenLabel.Text = "";
            }
            screenLabel.Text += "5";
        }

        private void number6Button_Click(object sender, EventArgs e)
        {
            if (screenLabel.Text == "0")
            {
                screenLabel.Text = "";
            }
            screenLabel.Text += "6";
        }

        private void number7Button_Click(object sender, EventArgs e)
        {
            if (screenLabel.Text == "0")
            {
                screenLabel.Text = "";
            }
            screenLabel.Text += "7";
        }

        private void number8Button_Click(object sender, EventArgs e)
        {
            if (screenLabel.Text == "0")
            {
                screenLabel.Text = "";
            }
            screenLabel.Text += "8";
        }

        private void number9Button_Click(object sender, EventArgs e)
        {
            if (screenLabel.Text == "0")
            {
                screenLabel.Text = "";
            }
            screenLabel.Text += "9";
        }

        private void number0Button_Click(object sender, EventArgs e)
        {
            if (screenLabel.Text != "0")
            {
                screenLabel.Text += "0";
            }
        }

        private void dotButton_Click(object sender, EventArgs e)
        {
            if (!screenLabel.Text.Contains(","))
            {
                screenLabel.Text += ",";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void clearAllbutton_Click(object sender, EventArgs e)
        {
            screenLabel.Text = "0";
        }

        private void additionButton_Click(object sender, EventArgs e)
        {
            _operation = '+';
            _number1 = double.Parse(screenLabel.Text);
            screenLabel.Text = "";
        }

        private void subtractionButton_Click(object sender, EventArgs e)
        {
            _operation = '-';
            _number1 = double.Parse(screenLabel.Text);
            screenLabel.Text = "";
        }

        private void multiplicationButton_Click(object sender, EventArgs e)
        {
            _operation = '*';
            _number1 = double.Parse(screenLabel.Text);
            screenLabel.Text = "";

        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            _operation = '/';
            _number1 = double.Parse(screenLabel.Text);
            screenLabel.Text = "";
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            _number2 = double.Parse(screenLabel.Text);

            switch (_operation)
            {
                case '+':
                    _result = _number1 + _number2;
                    break;
                case '-':
                    _result = _number1 - _number2;
                    break;
                case '*':
                    _result = _number1 * _number2;
                    break;
                case '/':
                    if (_number2 != 0)
                    {
                        _result = _number1 / _number2;
                    }
                    else
                    {
                        screenLabel.Text = "Error";
                        return;
                    }
                    break;           
            }
            screenLabel.Text = _result < 0 ? "-" + Math.Abs(_result) : _result+"";
        }
    }
}