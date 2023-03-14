namespace RecordKeeperWinForm
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuPresident = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSearchPresident = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewPresident = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDataMaint = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDataMainEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindowTile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindowCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDashboard = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuPresident,
            this.mnuDataMaint,
            this.mnuWindow});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(1029, 29);
            this.mnuMain.TabIndex = 1;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuPresident
            // 
            this.mnuPresident.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSearchPresident,
            this.mnuNewPresident});
            this.mnuPresident.Name = "mnuPresident";
            this.mnuPresident.Size = new System.Drawing.Size(87, 25);
            this.mnuPresident.Text = "President";
            // 
            // mnuSearchPresident
            // 
            this.mnuSearchPresident.Name = "mnuSearchPresident";
            this.mnuSearchPresident.Size = new System.Drawing.Size(181, 26);
            this.mnuSearchPresident.Text = "Search";
            // 
            // mnuNewPresident
            // 
            this.mnuNewPresident.Name = "mnuNewPresident";
            this.mnuNewPresident.Size = new System.Drawing.Size(181, 26);
            this.mnuNewPresident.Text = "New President";
            // 
            // mnuDataMaint
            // 
            this.mnuDataMaint.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDataMainEdit});
            this.mnuDataMaint.Name = "mnuDataMaint";
            this.mnuDataMaint.Size = new System.Drawing.Size(147, 25);
            this.mnuDataMaint.Text = "Data Maintenance";
            // 
            // mnuDataMainEdit
            // 
            this.mnuDataMainEdit.Name = "mnuDataMainEdit";
            this.mnuDataMainEdit.Size = new System.Drawing.Size(142, 26);
            this.mnuDataMainEdit.Text = "Edit Data";
            // 
            // mnuWindow
            // 
            this.mnuWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuWindowTile,
            this.mnuWindowCascade});
            this.mnuWindow.Name = "mnuWindow";
            this.mnuWindow.Size = new System.Drawing.Size(80, 25);
            this.mnuWindow.Text = "&Window";
            // 
            // mnuWindowTile
            // 
            this.mnuWindowTile.Name = "mnuWindowTile";
            this.mnuWindowTile.Size = new System.Drawing.Size(137, 26);
            this.mnuWindowTile.Text = "Tile";
            // 
            // mnuWindowCascade
            // 
            this.mnuWindowCascade.Name = "mnuWindowCascade";
            this.mnuWindowCascade.Size = new System.Drawing.Size(137, 26);
            this.mnuWindowCascade.Text = "Cascade";
            // 
            // tsMain
            // 
            this.tsMain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tsMain.Location = new System.Drawing.Point(0, 29);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(1029, 25);
            this.tsMain.TabIndex = 3;
            this.tsMain.Text = "toolStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDashboard});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(46, 25);
            this.mnuFile.Text = "File";
            // 
            // mnuDashboard
            // 
            this.mnuDashboard.Name = "mnuDashboard";
            this.mnuDashboard.Size = new System.Drawing.Size(180, 26);
            this.mnuDashboard.Text = "Dashboard";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 630);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.mnuMain);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "Record Keeper";
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip mnuMain;
        private ToolStripMenuItem mnuPresident;
        private ToolStripMenuItem mnuSearchPresident;
        private ToolStripMenuItem mnuNewPresident;
        private ToolStripMenuItem mnuWindow;
        private ToolStripMenuItem mnuWindowTile;
        private ToolStripMenuItem mnuWindowCascade;
        private ToolStrip tsMain;
        private ToolStripMenuItem mnuDataMaint;
        private ToolStripMenuItem mnuDataMainEdit;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuDashboard;
    }
}