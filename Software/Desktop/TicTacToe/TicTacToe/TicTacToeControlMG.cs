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
        enum TurnEnum { X, O };
        TurnEnum currentturn = TurnEnum.X;

        enum GameStatusEnum { NotStarted, Playing, Tie, Winner }
        GameStatusEnum gamestatus =  GameStatusEnum.NotStarted ;

        List<Button> lstbuttons;

        public TicTacToeControlMG()
        {
            InitializeComponent();
            lblName.Text = "MG";
            lstbuttons = new() { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };

            lstbuttons.ForEach(b => b.Click += SpotButton_Click);
            btnStart.Click += BtnStart_Click;
            DisplayGameStatus();
        }

        private void StartGame()
        {
            lstbuttons.ForEach(b => b.Text = "");
            gamestatus = GameStatusEnum.Playing;
            currentturn = TurnEnum.X;
            DisplayGameStatus();
            SetButtonsBackcolor();
        }


        private void DoTurn(Button btn)
        {
            if (btn.Text == "" && gamestatus ==  GameStatusEnum.Playing)
            {
                btn.Text = currentturn.ToString();

                //switch turn
                if (currentturn == TurnEnum.X)
                {
                    currentturn = TurnEnum.O;
                }
                else
                {
                    currentturn = TurnEnum.X;
                }
                DetectTie();
                DisplayGameStatus();
            }
        }

        private void DetectTie() {
            if (lstbuttons.Where(b => b.Text == "").Count() == 0) {
                gamestatus = GameStatusEnum.Tie;
                SetButtonsBackcolor();
            }
        }

        private void SetButtonsBackcolor() {
            Color c = Button.DefaultBackColor;

            switch (gamestatus) {
                case GameStatusEnum.Tie:
                    c = Color.White;
                    break;
            }
            lstbuttons.ForEach(b => b.BackColor = c);
        }
        private void DisplayGameStatus()
        {
            string msg = "Click Start to begin Game";

            switch (gamestatus)
            {
                case GameStatusEnum.Playing:
                    msg = "Current Turn: " + currentturn.ToString();
                    break;
                case GameStatusEnum.Tie:
                    msg = "Tie";
                    break;
            }

            lblStatus.Text = msg;
        }
        private void SpotButton_Click(object? sender, EventArgs e)
        {
            if (sender is Button)
            {
                DoTurn((Button)sender);
            }

        }

        private void BtnStart_Click(object? sender, EventArgs e)
        {
            StartGame();
        }

        //detect winner

    }
}
