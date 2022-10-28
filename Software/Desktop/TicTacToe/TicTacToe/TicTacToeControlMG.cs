using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class TicTacToeControlMG : TicTacToeControl
    {

        List<Button> lstbuttons;
        public TicTacToeControlMG()
        {
            InitializeComponent();
            lblName.Text = "MG";
            lstbuttons = new() { btn1,btn2,btn3,btn4,btn5,btn6,btn7,btn8,btn9};

            lstbuttons.ForEach(b => b.Click += SpotButton_Click);
        }

        private void SpotButton_Click(object? sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Text = "X";

        }
    }
}
