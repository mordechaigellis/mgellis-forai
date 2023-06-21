using System.Drawing;

namespace TicTacToeSystem
{
    public class Game
    {
        public enum GameStatusEnum { NotStarted, Playing, Winner, Tie }
        public enum TurnEnum { None, X, O }
        List<List<Spot>> lstwinningsets = new();
        List<Spot> lstrankedbuttons;
        bool iscomputerturn;

        public Game()
        {
            for (int i = 0; i < 9; i++)
            {
                this.Spots.Add(new Spot());
            }
          
            lstwinningsets = new() {
                new() {this.Spots[0], this.Spots[1], this.Spots[2] },
                new() {this.Spots[3], this.Spots[4], this.Spots[5] },
                new() {this.Spots[6], this.Spots[7], this.Spots[8] },
                new() {this.Spots[0], this.Spots[3], this.Spots[6] },
                new() {this.Spots[1], this.Spots[4], this.Spots[7] },
                new() {this.Spots[2], this.Spots[5], this.Spots[8] },
                new() {this.Spots[0], this.Spots[4], this.Spots[8] },
                new() {this.Spots[2], this.Spots[4], this.Spots[6] }
            };
            lstrankedbuttons = new() { this.Spots[4], this.Spots[0], this.Spots[2], this.Spots[6], this.Spots[8] };
        }

        public List<Spot> Spots { get; private set; } = new();
        public GameStatusEnum GameStatus { get; private set; }
        public TurnEnum CurrentTurn { get; private set; }
        public string GameStatusDescription { get => ""; }
        public TurnEnum Winner { get; private set; }
        public bool PlayAgainstComputer { get; set; }
        public System.Drawing.Color SpotWinnerColor { get; set; } = System.Drawing.Color.Red;
        public System.Drawing.Color SpotTieColor { get; set; } = System.Drawing.Color.Gray;
        public System.Drawing.Color SpotPlayingColor { get; set; } = System.Drawing.Color.Silver;
        public System.Drawing.Color SpotNotStartedColor { get; set; } = System.Drawing.Color.Black;

        public void StartGame()
        {
            this.Spots.ForEach(b => b.Clear());
            this.GameStatus = GameStatusEnum.Playing;
            this.CurrentTurn = TurnEnum.X;

        }
        public void TakeSpot(int spotnum)
        {
            Spot spot = this.Spots[spotnum];
            if (spot.SpotValue == TurnEnum.None && this.GameStatus == GameStatusEnum.Playing)
            {
                spot.SpotValue = this.CurrentTurn;

                lstwinningsets.ForEach(l => DetectWinner(l));

                if (this.GameStatus == GameStatusEnum.Playing)
                {
                    DetectTie();
                    //switch turn
                    if (this.GameStatus == GameStatusEnum.Playing)
                    {
                        if (this.CurrentTurn == TurnEnum.X)
                        {
                            this.CurrentTurn = TurnEnum.O;
                        }
                        else
                        {
                            this.CurrentTurn = TurnEnum.X;
                        }
                        //if (IsComputerTurn())
                        //{
                        //    //1st step of algorithm - offense
                        //    DoComputerTurnOffenseDefense(TurnEnum.O);
                        //    if (IsComputerTurn())
                        //    {
                        //        //if turn not taken computer then defense
                        //        DoComputerTurnOffenseDefense(TurnEnum.X);
                        //        if (IsComputerTurn())
                        //        {
                        //            //if turn not taken computer then by rank
                        //            DoComputerTurnRank();

                        //            if (IsComputerTurn())
                        //            {
                        //                //if turn not taken computer then random available button
                        //                DoComputerTurnRandom();
                        //            }
                        //        }
                        //    }
                        //}

                    }
                }
            }
        }
        private void DetectWinner(List<Spot> lst)
        {
            if (lst.Count(b => b.SpotValue == this.CurrentTurn) == lst.Count())
            {
                this.GameStatus = GameStatusEnum.Winner;
                this.Winner = this.CurrentTurn;

            }
        }
        private void DetectTie()
        {
            if (this.Spots.Count(b => b.SpotValue == TurnEnum.None) == 0)
            {
                this.GameStatus = GameStatusEnum.Tie;
            }
        }
        private void DoComputerTurnOffenseDefense()
        {

        }
        private void DoComputerTurnRank()
        {

        }
        private void DoComputerTurnRandom()
        {

        }
    }
}