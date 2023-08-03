﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordKeeperSystem
{
    public class bizPresident : bizObject<bizPresident>
    {
        public bizPresident() { 
        
        }
        private int _presidentId;
        private int _partyId;
        private int _num;
        private string _firstname = "";
        private string _lastname = "";
        private DateTime _dateborn;
        private DateTime? _datedied;
        private int _termstart;
        private int _termend;

        public int PresidentId
        {
            get { return _presidentId; }
            set
            {
                if (_presidentId != value)
                {
                    _presidentId = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int PartyId
        {
            get { return _partyId; }
            set
            {
                if (_partyId != value)
                {
                    _partyId = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int Num
        {
            get { return _num; }
            set
            {
                if (_num != value)
                {
                    _num = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string FirstName
        {
            get { return _firstname; }
            set
            {
                if (_firstname != value)
                {
                    _firstname = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string LastName
        {
            get { return _lastname; }
            set
            {
                if (_lastname != value)
                {
                    _lastname = value;
                    InvokePropertyChanged();
                }
            }
        }

        public DateTime DateBorn
        {
            get { return _dateborn; }
            set
            {
                if (_dateborn != value)
                {
                    _dateborn = value;
                    InvokePropertyChanged();
                }
            }
        }

        public DateTime? DateDied
        {
            get { return _datedied; }
            set
            {
                if (_datedied != value)
                {
                    _datedied = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int TermStart
        {
            get { return _termstart; }
            set
            {
                if (_termstart != value)
                {
                    _termstart = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int TermEnd
        {
            get { return _termend; }
            set
            {
                if (_termend != value)
                {
                    _termend = value;
                    InvokePropertyChanged();
                }
            }
        }

    }
}
