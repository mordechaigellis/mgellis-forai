using TicTacToeSystem;
namespace TicTacToe
{
    public partial class TicTacToeControlMG : TicTacToeControl
    {
        Game game = new();
        List<Button> lstbuttons;
        Color defaultbackcolor;
        public TicTacToeControlMG()
        {
            InitializeComponent();
            lblName.Text = "MG";
            defaultbackcolor = btn1.BackColor;
            lstbuttons = new() { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };

            lstbuttons.ForEach(b => {
                Spot spot = game.Spots[lstbuttons.IndexOf(b)];
                b.Click += SpotButton_Click;
                b.DataBindings.Add("Text", spot, "SpotValueDescription");
                b.DataBindings.Add("BackColor", spot, "BackColor");
            });
            btnStart.Click += BtnStart_Click;

            lblStatus.DataBindings.Add("Text", game, "GameStatusDescription");

        }

        private void StartGame()
        {
            game.StartGame();
        }

        private void DoTurn(Button btn)
        {
            int num = lstbuttons.IndexOf(btn);
            game.TakeSpot(num);
        }

     
        //private void DoComputerTurnOffenseDefense(TurnEnum turn)
        //{
        //    //find first set that has two buttongs with computer letter and one blank
        //    //get the blank button out of the set
        //    var lst = lstwinningsets.FirstOrDefault(l =>
        //        l.Count(b => b.Text == turn.ToString()) == 2
        //        &&
        //        l.Count(b => b.Text == "") == 1
        //        );

        //    if (lst != null)
        //    {
        //        var btn = lst.First(b => b.Text == "");
        //        DoTurn(btn);
        //    }

        //}

        //private void DoComputerTurnRank()
        //{
        //    var btn = lstrankedbuttons.FirstOrDefault(b => b.Text == "");
        //    if (btn != null)
        //    {
        //        DoTurn(btn);
        //    }
        //}

        //private void DoComputerTurnRandom()
        //{
        //    var lst = lstbuttons.Where(b => b.Text == "").ToList();
        //    var btn = lst[new Random().Next(0, lst.Count())];
        //    DoTurn(btn);
        //}

       

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
