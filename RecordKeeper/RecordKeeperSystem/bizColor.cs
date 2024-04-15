using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordKeeperSystem
{
    public class bizColor: bizObject<bizColor>
    {
        private int _colorid;
        private string _colorname = "";

        public int ColorId
        {
            get { return _colorid; }
            set
            {
                _colorid = value;
                InvokePropertyChanged();
            }
        }

        public string ColorName
        {
            get { return _colorname; }
            set
            {
                _colorname = value;
                InvokePropertyChanged();
            }
        }

    }
}
