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
        enum TurnEnum { X, O};
        TurnEnum currentturn = TurnEnum.X;

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
            if (sender is Button)
            {
                Button btn = (Button)sender;
                btn.Text = currentturn.ToString();

                //switch turn
                if (currentturn == TurnEnum.X)
                {
                    currentturn = TurnEnum.O;
                }
                else {
                    currentturn = TurnEnum.X;
                }
            }

        }
        
        //move the turn taking and alternating in to a procedure call DoTurn
        //do not allow a user to click on a button that is already taken
    }
}
