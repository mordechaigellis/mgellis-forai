namespace CalculatorWinForms
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
            btn1.Click += Btn1_Click;
            btn2.Click += Btn2_Click;
            btn3.Click += Btn3_Click;
            btn4.Click += Btn4_Click;
            btn5.Click += Btn5_Click;
            btn6.Click += Btn6_Click;
            btn7.Click += Btn7_Click;
            btn8.Click += Btn8_Click;
            btn9.Click += Btn9_Click;
            btn0.Click += Btn0_Click;
            btnAdd.Click += BtnAdd_Click;
            btnSubstract.Click += BtnSubstract_Click;
            btnMultiply.Click += BtnMultiply_Click;
            btnDivide.Click += BtnDivide_Click;
            btnDecimal.Click += BtnDecimal_Click;
            btnSign.Click += BtnSign_Click;
            btnEquals.Click += BtnEquals_Click;
            btnClear.Click += BtnClear_Click;
        }

        private int DetermineFactor()
        {
            int n = 0;

            if (txtFactor1.Text == "" || txtOperator.Text == "")
            {
                n = 1;
            }
            else if ((txtFactor1.Text != "" || txtOperator.Text != "") && txtAnswer.Text == "")
            {
                n = 2;
            }

            return n;
        }

        private void InputFactor(string value)
        {
            int n = DetermineFactor();
            string factorval = "";
            if (n == 1)
            {
                factorval = txtFactor1.Text;
            }
            else if (n == 2)
            {
                factorval = txtFactor2.Text;
            }

            factorval = factorval + value;

            if (n == 1)
            {
                txtFactor1.Text = factorval;
            }
            else if (n == 2)
            {
                txtFactor2.Text = factorval;
            }
        }

        private void InputDecimal()
        {
            int n = DetermineFactor();
            string factorval = "";
            if (n == 1)
            {
                factorval = txtFactor1.Text;
            }
            else if (n == 2)
            {
                factorval = txtFactor2.Text;
            }

            if (factorval.Contains(".") == false)
            {
                factorval = factorval + ".";
            }

            if (n == 1)
            {
                txtFactor1.Text = factorval;
            }
            else if (n == 2)
            {
                txtFactor2.Text = factorval;
            }
        }

        private void CalculateAnswer()
        {
            decimal factor1 = 0; decimal factor2 = 0; decimal answer = 0;
            string operatorval = txtOperator.Text;
            bool b1 = decimal.TryParse(txtFactor1.Text, out factor1);
            bool b2 = decimal.TryParse(txtFactor2.Text, out factor2);
            if (b1 == true && b2 == true)
            {
                if (operatorval == "+")
                {
                    answer = factor1 + factor2;
                }
                else if (operatorval == "-")
                {
                    answer = factor1 - factor2;
                }
                else if (operatorval == "X")
                {
                    answer = factor1 * factor2;
                }
                else if (operatorval == "/")
                {
                    answer = factor1 / factor2;
                }
                txtAnswer.Text = answer.ToString();
            }
        }
        private void BtnClear_Click(object? sender, EventArgs e)
        {
            txtFactor1.Text = "";
            txtOperator.Text = "";
            txtFactor2.Text = "";
            txtAnswer.Text = "";
        }

        private void BtnSign_Click(object? sender, EventArgs e)
        {

        }

        private void BtnEquals_Click(object? sender, EventArgs e)
        {
            CalculateAnswer();
        }

        private void BtnDivide_Click(object? sender, EventArgs e)
        {
            txtOperator.Text = btnDivide.Text;
        }

        private void BtnMultiply_Click(object? sender, EventArgs e)
        {
            txtOperator.Text = btnMultiply.Text;
        }

        private void BtnSubstract_Click(object? sender, EventArgs e)
        {
            txtOperator.Text = btnSubstract.Text;
        }

        private void BtnDecimal_Click(object? sender, EventArgs e)
        {
            InputDecimal();
        }

        private void BtnAdd_Click(object? sender, EventArgs e)
        {
            txtOperator.Text = btnAdd.Text;
        }

        private void Btn0_Click(object? sender, EventArgs e)
        {
            InputFactor(btn0.Text);
        }

        private void Btn9_Click(object? sender, EventArgs e)
        {
            InputFactor(btn9.Text);
        }

        private void Btn8_Click(object? sender, EventArgs e)
        {
            InputFactor(btn8.Text);
        }

        private void Btn7_Click(object? sender, EventArgs e)
        {
            InputFactor(btn7.Text);
        }

        private void Btn6_Click(object? sender, EventArgs e)
        {
            InputFactor(btn6.Text);
        }

        private void Btn5_Click(object? sender, EventArgs e)
        {
            InputFactor(btn5.Text);
        }

        private void Btn4_Click(object? sender, EventArgs e)
        {
            InputFactor(btn4.Text);
        }

        private void Btn3_Click(object? sender, EventArgs e)
        {
            InputFactor(btn3.Text);
        }

        private void Btn2_Click(object? sender, EventArgs e)
        {
            InputFactor(btn2.Text);
        }

        private void Btn1_Click(object? sender, EventArgs e)
        {
            InputFactor(btn1.Text);
        }
    }
}