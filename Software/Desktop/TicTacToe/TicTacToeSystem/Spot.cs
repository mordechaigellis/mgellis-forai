using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeSystem
{
    public class Spot
    {
        private GameStatusEnum _gamestatus;
        public enum GameStatusEnum { NotStarted, Playing, Winner, Tie}

        public GameStatusEnum GameStatus {
            get => _gamestatus;
            set {
                _gamestatus = value;
            }

        }
    }
}
