﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordKeeperSystem
{
    public class bizPresidentMedal : bizObject<bizPresidentMedal>
    {
        private int _presidentmedalId;
        private int _presidentid;
        private int _medalid;
        private string _medalname = "";

        public int PresidentMedalId
        {
            get { return _presidentmedalId; }
            set
            {
                if (_presidentmedalId != value)
                {
                    _presidentmedalId = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int PresidentId
        {
            get { return _presidentid; }
            set
            {
                if (_presidentid != value)
                {
                    _presidentid = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int MedalId
        {
            get { return _medalid; }
            set
            {
                if (_medalid != value)
                {
                    _medalid = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string MedalName
        {
            get { return _medalname; }
            set
            {
                if (_medalname != value)
                {
                    _medalname = value;
                    InvokePropertyChanged();
                }
            }
        }

    }
}
