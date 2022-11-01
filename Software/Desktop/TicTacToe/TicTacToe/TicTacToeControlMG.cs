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
        GameStatusEnum gamestatus = GameStatusEnum.NotStarted;

        List<Button> lstbuttons;

        List<List<Button>> lstwinningsets;
        List<Button> lstcomputerpriority;
        Color defaultbackcolor;

        bool playcomputer = false;
        public TicTacToeControlMG()
        {
            InitializeComponent();
            lblName.Text = "MG";
            defaultbackcolor = btn1.BackColor;
            lstbuttons = new() { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };

            lstbuttons.ForEach(b => b.Click += SpotButton_Click);
            btnStart.Click += BtnStart_Click;
            /*
1,2,3
4,5,6
7,8,9
*/
            lstwinningsets = new() {
                new() { btn1, btn2, btn3},
                new() {btn4, btn5, btn6},
                new() {btn7, btn8, btn9},
                new() {btn1, btn4, btn7},
                new() {btn2, btn5, btn8},
                new() {btn3, btn6, btn9},
                new() {btn1, btn5, btn9},
                new() {btn3, btn5, btn7}
            };

            lstcomputerpriority = new() { btn5, btn1, btn3, btn7, btn9 };

            DisplayGameStatus();
        }

        private void StartGame()
        {
            lstbuttons.ForEach(b => b.Text = "");
            gamestatus = GameStatusEnum.Playing;
            currentturn = TurnEnum.X;
            playcomputer = optPlayComputer.Checked;
            DisplayGameStatus();
            SetButtonsBackcolor(lstbuttons);
        }


        private void DoTurn(Button btn)
        {
            if (btn.Text == "" && gamestatus == GameStatusEnum.Playing)
            {
                btn.Text = currentturn.ToString();

                lstwinningsets.ForEach(l => DetectWinner(l));

                if (gamestatus == GameStatusEnum.Playing)
                {
                    DetectTie();
                    //switch turn
                    if (currentturn == TurnEnum.X)
                    {
                        currentturn = TurnEnum.O;
                    }
                    else
                    {
                        currentturn = TurnEnum.X;
                    }
                    if (currentturn == TurnEnum.O && playcomputer == true)
                    {
                        //offense
                        DoOffenseDefense(TurnEnum.O);
                        //if still the computer's turn because there was no offense move
                        if (currentturn == TurnEnum.O && gamestatus == GameStatusEnum.Playing)
                        {
                            //defense
                            DoOffenseDefense(TurnEnum.X);
                        }

                        if (currentturn == TurnEnum.O &&  gamestatus == GameStatusEnum.Playing) {
                            DoPriorityButton();
                        }

                        if (currentturn == TurnEnum.O &&  gamestatus == GameStatusEnum.Playing) {
                            DoRandomButton();
                        }
                    }
                    //if playcomputer and its the computer turn DoComputerTurn - choose the button to go, call DoTurn
                }

                DisplayGameStatus();
            }
        }

        private void DoOffenseDefense(TurnEnum turn)
        {
            List<Button>? lst = lstwinningsets.Find(
                    l =>
                        l.Count(b => b.Text == turn.ToString()) == 2
                        &&
                        l.Count(b => b.Text == "") == 1
                );
            if (lst != null)
            {
                Button btn = lst.First(b => b.Text == "");
                DoTurn(btn);
            }
        }

        private void DoPriorityButton() {
            Button? btn = lstcomputerpriority.Find(b => b.Text == "");
            if (btn != null) {
                DoTurn(btn);
            }
        }

        private void DoRandomButton() {
            var lst = lstbuttons.Where(b => b.Text == "").ToList();
            var btn = lst[new Random().Next(0, lst.Count())];
            DoTurn(btn);
        }
        private void DetectWinner(List<Button> lst)
        {
            if (lst.Where(b => b.Text == currentturn.ToString()).Count() == lst.Count())
            {
                Color c = Color.Yellow;
                gamestatus = GameStatusEnum.Winner;
                SetButtonsBackcolor(lst);

            }
        }


        private void DetectTie()
        {
            if (lstbuttons.Where(b => b.Text == "").Count() == 0)
            {
                gamestatus = GameStatusEnum.Tie;
                SetButtonsBackcolor(lstbuttons);
            }
        }

        private void SetButtonsBackcolor(List<Button> lst)
        {
            Color c = defaultbackcolor;

            switch (gamestatus)
            {
                case GameStatusEnum.Tie:
                    c = Color.White;
                    break;
                case GameStatusEnum.Winner:
                    c = Color.Yellow;
                    break;
            }
            lst.ForEach(b => b.BackColor = c);
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
                case GameStatusEnum.Winner:
                    msg = "Winner is: " + currentturn.ToString();
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
    }
}
