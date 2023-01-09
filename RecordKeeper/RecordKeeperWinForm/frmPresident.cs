using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecordKeeperWinForm
{
    public partial class frmPresident : Form
    {
        public frmPresident()
        {
            InitializeComponent();
        }

        public void ShowForm(int presidentid) {
            string sql = "select p.*, y.PartyName from president p join party y on p.PartyId = y.PartyId where p.PresidentId = " + presidentid.ToString();
            DataTable dt = SQLUtility.GetDataTable(sql);
            lblParty.DataBindings.Add("Text", dt, "PartyName");
            lblNum.DataBindings.Add("Text", dt, "Num");
            txtLastName.DataBindings.Add("Text", dt, "LastName");
            txtFirstName.DataBindings.Add("Text", dt, "FirstName");
            txtDateBorn.DataBindings.Add("Text", dt, "DateBorn");
            txtDateDied.DataBindings.Add("Text", dt, "DateDied");
            txtTermStart.DataBindings.Add("Text", dt, "TermStart");
            txtTermEnd.DataBindings.Add("Text", dt, "TermEnd");
            this.Show();
        }
    }
}
