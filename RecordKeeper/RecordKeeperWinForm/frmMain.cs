using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecordKeeperWinForm
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            mnuSearchPresident.Click += MnuSearchPresident_Click;
            mnuNewPresident.Click += MnuNewPresident_Click;
            mnuWindowTile.Click += MnuWindowTile_Click;
            mnuWindowCascade.Click += MnuWindowCascade_Click;
        }

       

        private void MnuWindowCascade_Click(object? sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void MnuWindowTile_Click(object? sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void MnuNewPresident_Click(object? sender, EventArgs e)
        {
            bool b = WindowsFormsUtility.IsFormOpen(typeof(frmPresident));
            if (b == false)
            {
                frmPresident f = new frmPresident();
                f.MdiParent = this;
                f.ShowForm(0);
            }
        }


        private void MnuSearchPresident_Click(object? sender, EventArgs e)
        {
            bool exists = WindowsFormsUtility.IsFormOpen(typeof(frmSearch));
           
            if (exists == false)
            {
                frmSearch f = new frmSearch();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
