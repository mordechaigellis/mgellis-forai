namespace CalculatorWinForms
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
            btn1.Click += BtnFactor_Click;
            btn2.Click += BtnFactor_Click;
            btn3.Click += BtnFactor_Click;
            btn4.Click += BtnFactor_Click;
            btn5.Click += BtnFactor_Click;
            btn6.Click += BtnFactor_Click;
            btn7.Click += BtnFactor_Click;
            btn8.Click += BtnFactor_Click;
            btn9.Click += BtnFactor_Click;
            btn0.Click += BtnFactor_Click;
            btnAdd.Click += BtnAdd_Click;
            btnSubstract.Click += BtnSubstract_Click;
            btnMultiply.Click += BtnMultiply_Click;
            btnDivide.Click += BtnDivide_Click;
            btnDecimal.Click += BtnFactor_Click;
            btnSign.Click += BtnFactor_Click;
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

        private string GetCurrentFactorValue() {
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
            return factorval;
        }

        private void SetCurrentFactorValue(string value)
        {
            int n = DetermineFactor();
            if (n == 1)
            {
                txtFactor1.Text = value;
            }
            else if (n == 2)
            {
                txtFactor2.Text = value;
            }
            
        }

        private void InputFactor(string value)
        {
            string factorval = GetCurrentFactorValue();

            if (value == ".")
            {
                if (factorval.Contains(".") == true) {
                    value = "";
                }
            }
            else if (value == "-/+")
            {
                value = "";
                if (factorval.StartsWith("-") == false) {
                    factorval = "-" + factorval;
                }
                else
                {
                    factorval = factorval.Substring(1);
                }
            }

            factorval = factorval + value;

            SetCurrentFactorValue(factorval);
        }


        private void CalculateAnswer()
        {
            decimal factor1 = 0; decimal factor2 = 0; decimal answer = 0;
            string operatorval = txtOperator.Text;
            bool b1 = decimal.TryParse(txtFactor1.Text, out factor1);
            bool b2 = decimal.TryParse(txtFactor2.Text, out factor2);
            bool displayanswer = true;

            if (b1 == false) {
                txtFactor1.Text = "";
                displayanswer = false;
            }

            if (b2 == false)
            {
                txtFactor2.Text = "";
                displayanswer = false;
            }

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
                    if (factor2 == 0)
                    {
                        txtFactor2.Text = "";
                        displayanswer = false;
                    }
                    else
                    {
                        answer = factor1 / factor2;
                    }
                }
                else
                {
                    txtOperator.Text = "";
                    displayanswer = false;
                }
            }
            if (displayanswer == true)
            {
                txtAnswer.Text = answer.ToString();
            }
            else
            {
                txtAnswer.Text = "";
            }

        }
        private void BtnClear_Click(object? sender, EventArgs e)
        {
            txtFactor1.Text = "";
            txtOperator.Text = "";
            txtFactor2.Text = "";
            txtAnswer.Text = "";
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


        private void BtnAdd_Click(object? sender, EventArgs e)
        {
            txtOperator.Text = btnAdd.Text;
        }

        private void BtnFactor_Click(object? sender, EventArgs e)
        {
            Button btn = (Button)sender;
            InputFactor(btn.Text);
        }

    }
}