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
            mnuDashboard.Click += MnuDashboard_Click;
            mnuWindowTile.Click += MnuWindowTile_Click;
            mnuWindowCascade.Click += MnuWindowCascade_Click;
            mnuDataMainEdit.Click += MnuDataMainEdit_Click;
            OpenForm(typeof(frmDashboard));
        }

        

        public void OpenForm(Type frmtype, int pkvalue = 0)
        {
            bool b = WindowsFormsUtility.IsFormOpen(frmtype);
            
            if (b == false)
            {
                Form? newfrm = null;
                if (frmtype == typeof(frmPresident))
                {
                    frmPresident f = new();
                    newfrm = f;
                    f.ShowForm(pkvalue);
                }
                else if (frmtype == typeof(frmSearch))
                {
                    frmSearch f = new();
                    newfrm = f;
                    f.Show();
                }
                else if (frmtype == typeof(frmDataMaintenance))
                {
                    frmDataMaintenance f = new();
                    newfrm = f;
                    f.Show();
                }
                else if (frmtype == typeof(frmDashboard)) {
                    frmDashboard f = new();
                    newfrm = f;
                    f.Show();
                }
                if (newfrm != null) {
                    newfrm.MdiParent = this;
                    newfrm.WindowState = FormWindowState.Maximized;
                    newfrm.FormClosed += Frm_FormClosed;
                    newfrm.TextChanged += Newfrm_TextChanged;
                }
                WindowsFormsUtility.SetupNav(tsMain);
            }
        }

        private void Newfrm_TextChanged(object? sender, EventArgs e)
        {
            WindowsFormsUtility.SetupNav(tsMain);
        }

        private void Frm_FormClosed(object? sender, FormClosedEventArgs e)
        {
           WindowsFormsUtility.SetupNav(tsMain);
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
            OpenForm(typeof(frmPresident));
        }


        private void MnuSearchPresident_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmSearch));
        }
        private void MnuDataMainEdit_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmDataMaintenance));
        }
        private void MnuDashboard_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmDashboard));
        }
    }
}
