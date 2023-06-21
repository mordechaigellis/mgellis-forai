using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeSystem
{
    public class Spot
    {
        public Game.TurnEnum SpotValue { get; set; }
        public string SpotValueDescription { get => ""; }

        public System.Drawing.Color BackColor { get; set; }

        internal int Priority { get; set; }

        public void Clear() { 
        
        }
    }
}
