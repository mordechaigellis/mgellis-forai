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

        public void OpenForm(Type frmtype)
        {
            bool b = WindowsFormsUtility.IsFormOpen(frmtype);
            Form? newfrm = null;
            if (b == false)
            {
                if (frmtype == typeof(frmPresident))
                {
                    frmPresident f = new();
                    newfrm = f;
                    f.ShowForm(0);
                }
                else if (frmtype == typeof(frmSearch))
                {
                    frmSearch f = new();
                    newfrm = f;
                    f.Show();
                }
                if (newfrm != null) {
                    newfrm.MdiParent = this;
                    newfrm.WindowState = FormWindowState.Maximized;
                    newfrm.FormClosed += Frm_FormClosed;
                }
                SetupNav();
            }
        }

        private void Frm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            SetupNav();
        }

        public void SetupNav() {
            tsMain.Items.Clear();
            foreach (Form f in Application.OpenForms) {
                if (f.IsMdiContainer == false)
                {
                    ToolStripButton btn = new();
                    btn.Text = f.Text;
                    btn.Tag = f;
                    btn.Click += Btn_Click;
                    tsMain.Items.Add(btn);
                    tsMain.Items.Add(new ToolStripSeparator());
                }
            }
        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            if (sender != null && sender is ToolStripButton) {
                ToolStripButton btn = (ToolStripButton)sender;
                if (btn.Tag != null && btn.Tag is Form) {
                    ((Form)btn.Tag).Activate();
                }
            }
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
    }
}
