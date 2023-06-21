using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeSystem
{
    public class Spot : INotifyPropertyChanged
    {
        Game.TurnEnum _spotvalue = Game.TurnEnum.None;
        System.Drawing.Color _backcolor;

        public event PropertyChangedEventHandler? PropertyChanged;
        public Game.TurnEnum SpotValue
        {
            get => _spotvalue;
            set
            {
                _spotvalue = value;
                this.InvokePropertyChanged();
                this.InvokePropertyChanged("SpotValueDescription");
            }
        }
        public string SpotValueDescription { get => this.SpotValue == Game.TurnEnum.None ? "" : this.SpotValue.ToString(); }

        public System.Drawing.Color BackColor
        {
            get => _backcolor;
            set
            {
                _backcolor = value;
                this.InvokePropertyChanged();
            }
        }

        internal int Priority { get; set; }



        public void Clear()
        {
            this.SpotValue = Game.TurnEnum.None;
        }

        private void InvokePropertyChanged([CallerMemberName] string propertyname = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}
