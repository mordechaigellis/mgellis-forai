﻿namespace RecordKeeperSystem
{
    public class bizOlympics:bizObject<bizOlympics>
    {
        private int _olympicsid;
        private int _seasonid;
        private int _cityid;
        private int _olympicyear;
        private string _seasonname = "";
        private string _olympicsdec = "";

        public int OlympicsId
        {
            get { return _olympicsid; }
            set
            {
                if (_olympicsid != value)
                {
                    _olympicsid = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int SeasonId
        {
            get { return _seasonid; }
            set
            {
                if (_seasonid != value)
                {
                    _seasonid = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int CityId
        {
            get { return _cityid; }
            set
            {
                if (_cityid != value)
                {
                    _cityid = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int OlympicYear
        {
            get { return _olympicyear; }
            set
            {
                if (_olympicyear != value)
                {
                    _olympicyear = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string SeasonName
        {
            get { return _seasonname; }
            set
            {
                if (_seasonname != value)
                {
                    _seasonname = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string OlympicsDesc
        {
            get { return _olympicsdec; }
            set
            {
                if (_olympicsdec != value)
                {
                    _olympicsdec = value;
                    InvokePropertyChanged();
                }
            }
        }
    }

}

