using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordKeeperSystem
{
    public class bizExecutiveOrder : bizObject<bizExecutiveOrder>
    {
        private int _executiveorderid;
        private int _presidentid;
        private int _ordernumber;
        private int _pagenum;
        private int _yearissued;
        private string _ordername = "";
        private bool _upheldbycourt;
        private string _reference = "";

        public List<bizExecutiveOrder> LoadByPresidentId(int presidentid)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("ExecutiveOrderGet");
            cmd.Parameters["@PresidentId"].Value = presidentid;
            var dt = SQLUtility.GetDataTable(cmd);
            return this.GetListFromDataTable(dt);
        }

        public int ExecutiveOrderId
        {
            get { return _executiveorderid; }
            set
            {
                if (_executiveorderid != value)
                {
                    _executiveorderid = value;
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

        public int OrderNumber
        {
            get { return _ordernumber; }
            set
            {
                if (_ordernumber != value)
                {
                    _ordernumber = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int PageNum
        {
            get { return _pagenum; }
            set
            {
                if (_pagenum != value)
                {
                    _pagenum = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int YearIssued
        {
            get { return _yearissued; }
            set
            {
                if (_yearissued != value)
                {
                    _yearissued = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string OrderName
        {
            get { return _ordername; }
            set
            {
                if (_ordername != value)
                {
                    _ordername = value;
                    InvokePropertyChanged();
                }
            }
        }

        public bool UpheldByCourt
        {
            get { return _upheldbycourt; }
            set
            {
                if (_upheldbycourt != value)
                {
                    _upheldbycourt = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string Reference
        {
            get { return _reference; }
            set
            {
                if (_reference != value)
                {
                    _reference = value;
                    InvokePropertyChanged();
                }
            }
        }

    }
}
