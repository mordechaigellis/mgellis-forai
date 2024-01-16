using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordKeeperSystem
{
    public class bizParty : bizObject<bizParty>
    {
        private int _partyid;
        private string _partyname = "";
        private int _yearstart;
        private int _colorid;
        private string _partycolor = "";
        private string _partydesc = "";


        public List<bizParty> Search(string partynameval) {
            SqlCommand cmd = SQLUtility.GetSQLCommand(this.GetSprocName);
            SQLUtility.SetParamValue(cmd, "PartyName", partynameval);
            DataTable dt = SQLUtility.GetDataTable(cmd);
            return this.GetListFromDataTable(dt);
        }

        public int PartyId
        {
            get { return _partyid; }
            set
            {
                if (_partyid != value)
                {
                    _partyid = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string PartyName
        {
            get { return _partyname; }
            set
            {
                if (_partyname != value)
                {
                    _partyname = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int YearStart
        {
            get { return _yearstart; }
            set
            {
                if (_yearstart != value)
                {
                    _yearstart = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int ColorId
        {
            get { return _colorid; }
            set
            {
                if (_colorid != value)
                {
                    _colorid = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string PartyDesc
        {
            get { return _partydesc; }
            set
            {
                if (_partydesc != value)
                {
                    _partydesc = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string PartyColor
        {
            get { return _partycolor; }
            set
            {
                if (_partycolor != value)
                {
                    _partycolor = value;
                    InvokePropertyChanged();
                }
            }
        }
    }
}
