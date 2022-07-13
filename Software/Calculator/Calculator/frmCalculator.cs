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
           
        }

        private void BtnDivide_Click(object? sender, EventArgs e)
        {
            txtOperator.Text = txtOperator.Text + btnDivide.Text;
        }

        private void BtnMultiply_Click(object? sender, EventArgs e)
        {
            txtOperator.Text = txtOperator.Text + btnMultiply.Text;
        }

        private void BtnSubstract_Click(object? sender, EventArgs e)
        {
            txtOperator.Text = txtOperator.Text + btnSubstract.Text;
        }

        private void BtnDecimal_Click(object? sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object? sender, EventArgs e)
        {
            txtOperator.Text = txtOperator.Text + btnAdd.Text;
        }

        private void Btn0_Click(object? sender, EventArgs e)
        {
            txtFactor1.Text = txtFactor1.Text + btn0.Text;
        }

        private void Btn9_Click(object? sender, EventArgs e)
        {
            txtFactor1.Text = txtFactor1.Text + btn9.Text;
        }

        private void Btn8_Click(object? sender, EventArgs e)
        {
            txtFactor1.Text = txtFactor1.Text + btn8.Text;
        }

        private void Btn7_Click(object? sender, EventArgs e)
        {
            txtFactor1.Text = txtFactor1.Text + btn7.Text;
        }

        private void Btn6_Click(object? sender, EventArgs e)
        {
            txtFactor1.Text = txtFactor1.Text + btn6.Text;
        }

        private void Btn5_Click(object? sender, EventArgs e)
        {
            txtFactor1.Text = txtFactor1.Text + btn5.Text;
        }

        private void Btn4_Click(object? sender, EventArgs e)
        {
            txtFactor1.Text = txtFactor1.Text + btn4.Text;
        }

        private void Btn3_Click(object? sender, EventArgs e)
        {
            txtFactor1.Text = txtFactor1.Text + btn3.Text;
        }

        private void Btn2_Click(object? sender, EventArgs e)
        {
            txtFactor1.Text = txtFactor1.Text + btn2.Text;
        }

        private void Btn1_Click(object? sender, EventArgs e)
        {
            txtFactor1.Text = txtFactor1.Text + btn1.Text;
        }
    }
}