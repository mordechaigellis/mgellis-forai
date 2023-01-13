﻿using System.Data;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using CPUFramework;
namespace RecordKeeperWinForm
{
    public partial class frmPresident : Form
    {
        DataTable dtpresident;
        public frmPresident()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
        }


        public void ShowForm(int presidentid) {
            string sql = "select p.*, y.PartyName from president p join party y on p.PartyId = y.PartyId where p.PresidentId = " + presidentid.ToString();
            dtpresident = SQLUtility.GetDataTable(sql);
            SetControlBinding(lblPartyName, dtpresident);
            SetControlBinding(lblNum, dtpresident);
            SetControlBinding(txtLastName, dtpresident);
            SetControlBinding(txtFirstName, dtpresident);
            SetControlBinding(txtDateBorn, dtpresident);
            SetControlBinding(txtDateDied, dtpresident);
            SetControlBinding(txtTermStart, dtpresident);
            SetControlBinding(txtTermEnd, dtpresident);
            this.Show();
        }

        public void SetControlBinding(Control ctrl, DataTable dt) {
            string propertyname = "";
            string columnname = "";
            string controlname = ctrl.Name.ToLower();

            if (controlname.StartsWith("txt") || controlname.StartsWith("lbl")) {
                propertyname = "Text";
                columnname = controlname.Substring(3);
            }

            if (propertyname != "" && columnname != "")
            {
                ctrl.DataBindings.Add(propertyname, dt, columnname, true, DataSourceUpdateMode.OnPropertyChanged);
            }
        }

        private void Save() {
            SQLUtility.DebugPrintDataTable(dtpresident);
            DataRow r = dtpresident.Rows[0];
            string sql = $"update president set FirstName = '{r["FirstName"]}' where PresidentId = ";


            Debug.Print(sql);
        }

        private void Delete() { 
        
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }
    }
}
