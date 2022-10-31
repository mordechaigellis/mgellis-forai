﻿using System;
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
        bool gameactive = false;
        public TicTacToeControlMG()
        {
            InitializeComponent();
            lblName.Text = "MG";
            lstbuttons = new() { btn1,btn2,btn3,btn4,btn5,btn6,btn7,btn8,btn9};

            lstbuttons.ForEach(b => b.Click += SpotButton_Click);
            btnStart.Click += BtnStart_Click;
            DisplayGameStatus();
        }

        private void StartGame() {
            lstbuttons.ForEach(b => b.Text = "");
            gameactive = true;
            currentturn = TurnEnum.X;
            DisplayGameStatus();
        }


        private void DoTurn(Button btn) {
            if (btn.Text == "" && gameactive == true)
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
                DisplayGameStatus();
            }
        }

        private void DisplayGameStatus() {
            string msg = "Click Start to begin Game";

            if(gameactive == true)
            {
                msg = "Current Turn: " + currentturn.ToString();
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

        //detect tie
        
    }
}
