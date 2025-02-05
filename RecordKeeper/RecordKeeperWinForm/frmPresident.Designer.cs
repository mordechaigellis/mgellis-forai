﻿namespace RecordKeeperWinForm
{
    partial class frmPresident
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPresident));
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblCaptionParty = new System.Windows.Forms.Label();
            this.lblCaptionNum = new System.Windows.Forms.Label();
            this.lblCaptionFirstName = new System.Windows.Forms.Label();
            this.lblCaptionLastName = new System.Windows.Forms.Label();
            this.lblCaptionDateBorn = new System.Windows.Forms.Label();
            this.lblCaptionDateDied = new System.Windows.Forms.Label();
            this.lblCaptionTermStart = new System.Windows.Forms.Label();
            this.lblCaptionTermEnd = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtDateDied = new System.Windows.Forms.TextBox();
            this.txtTermStart = new System.Windows.Forms.TextBox();
            this.txtTermEnd = new System.Windows.Forms.TextBox();
            this.lstPartyName = new System.Windows.Forms.ComboBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.dtpDateBorn = new System.Windows.Forms.DateTimePicker();
            this.tbChildRecords = new System.Windows.Forms.TabControl();
            this.tbMedal = new System.Windows.Forms.TabPage();
            this.tblMedals = new System.Windows.Forms.TableLayoutPanel();
            this.btnSaveMedal = new System.Windows.Forms.Button();
            this.gMedal = new System.Windows.Forms.DataGridView();
            this.tbExecutiveOrder = new System.Windows.Forms.TabPage();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ttPresident = new System.Windows.Forms.ToolTip(this.components);
            this.tblMain.SuspendLayout();
            this.tbChildRecords.SuspendLayout();
            this.tbMedal.SuspendLayout();
            this.tblMedals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gMedal)).BeginInit();
            this.tsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Controls.Add(this.lblCaptionParty, 0, 0);
            this.tblMain.Controls.Add(this.lblCaptionNum, 0, 1);
            this.tblMain.Controls.Add(this.lblCaptionFirstName, 0, 2);
            this.tblMain.Controls.Add(this.lblCaptionLastName, 0, 3);
            this.tblMain.Controls.Add(this.lblCaptionDateBorn, 0, 4);
            this.tblMain.Controls.Add(this.lblCaptionDateDied, 0, 5);
            this.tblMain.Controls.Add(this.lblCaptionTermStart, 0, 6);
            this.tblMain.Controls.Add(this.lblCaptionTermEnd, 0, 7);
            this.tblMain.Controls.Add(this.txtFirstName, 1, 2);
            this.tblMain.Controls.Add(this.txtLastName, 1, 3);
            this.tblMain.Controls.Add(this.txtDateDied, 1, 5);
            this.tblMain.Controls.Add(this.txtTermStart, 1, 6);
            this.tblMain.Controls.Add(this.txtTermEnd, 1, 7);
            this.tblMain.Controls.Add(this.lstPartyName, 1, 0);
            this.tblMain.Controls.Add(this.txtNum, 1, 1);
            this.tblMain.Controls.Add(this.dtpDateBorn, 1, 4);
            this.tblMain.Controls.Add(this.tbChildRecords, 0, 8);
            this.tblMain.Location = new System.Drawing.Point(0, 31);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 9;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Size = new System.Drawing.Size(635, 553);
            this.tblMain.TabIndex = 0;
            // 
            // lblCaptionParty
            // 
            this.lblCaptionParty.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionParty.AutoSize = true;
            this.lblCaptionParty.Location = new System.Drawing.Point(3, 7);
            this.lblCaptionParty.Name = "lblCaptionParty";
            this.lblCaptionParty.Size = new System.Drawing.Size(45, 21);
            this.lblCaptionParty.TabIndex = 0;
            this.lblCaptionParty.Text = "Part&y";
            // 
            // lblCaptionNum
            // 
            this.lblCaptionNum.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionNum.AutoSize = true;
            this.lblCaptionNum.Location = new System.Drawing.Point(3, 42);
            this.lblCaptionNum.Name = "lblCaptionNum";
            this.lblCaptionNum.Size = new System.Drawing.Size(45, 21);
            this.lblCaptionNum.TabIndex = 2;
            this.lblCaptionNum.Text = "N&um";
            // 
            // lblCaptionFirstName
            // 
            this.lblCaptionFirstName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionFirstName.AutoSize = true;
            this.lblCaptionFirstName.Location = new System.Drawing.Point(3, 77);
            this.lblCaptionFirstName.Name = "lblCaptionFirstName";
            this.lblCaptionFirstName.Size = new System.Drawing.Size(86, 21);
            this.lblCaptionFirstName.TabIndex = 4;
            this.lblCaptionFirstName.Text = "First Name";
            // 
            // lblCaptionLastName
            // 
            this.lblCaptionLastName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionLastName.AutoSize = true;
            this.lblCaptionLastName.Location = new System.Drawing.Point(3, 112);
            this.lblCaptionLastName.Name = "lblCaptionLastName";
            this.lblCaptionLastName.Size = new System.Drawing.Size(84, 21);
            this.lblCaptionLastName.TabIndex = 6;
            this.lblCaptionLastName.Text = "Last Name";
            // 
            // lblCaptionDateBorn
            // 
            this.lblCaptionDateBorn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionDateBorn.AutoSize = true;
            this.lblCaptionDateBorn.Location = new System.Drawing.Point(3, 147);
            this.lblCaptionDateBorn.Name = "lblCaptionDateBorn";
            this.lblCaptionDateBorn.Size = new System.Drawing.Size(79, 21);
            this.lblCaptionDateBorn.TabIndex = 8;
            this.lblCaptionDateBorn.Text = "Date Born";
            // 
            // lblCaptionDateDied
            // 
            this.lblCaptionDateDied.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionDateDied.AutoSize = true;
            this.lblCaptionDateDied.Location = new System.Drawing.Point(3, 182);
            this.lblCaptionDateDied.Name = "lblCaptionDateDied";
            this.lblCaptionDateDied.Size = new System.Drawing.Size(78, 21);
            this.lblCaptionDateDied.TabIndex = 10;
            this.lblCaptionDateDied.Text = "Date Died";
            // 
            // lblCaptionTermStart
            // 
            this.lblCaptionTermStart.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionTermStart.AutoSize = true;
            this.lblCaptionTermStart.Location = new System.Drawing.Point(3, 217);
            this.lblCaptionTermStart.Name = "lblCaptionTermStart";
            this.lblCaptionTermStart.Size = new System.Drawing.Size(80, 21);
            this.lblCaptionTermStart.TabIndex = 12;
            this.lblCaptionTermStart.Text = "Term Start";
            // 
            // lblCaptionTermEnd
            // 
            this.lblCaptionTermEnd.AutoSize = true;
            this.lblCaptionTermEnd.Location = new System.Drawing.Point(3, 252);
            this.lblCaptionTermEnd.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.lblCaptionTermEnd.Name = "lblCaptionTermEnd";
            this.lblCaptionTermEnd.Size = new System.Drawing.Size(74, 21);
            this.lblCaptionTermEnd.TabIndex = 14;
            this.lblCaptionTermEnd.Text = "Term End";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFirstName.Location = new System.Drawing.Point(95, 73);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(537, 29);
            this.txtFirstName.TabIndex = 5;
            // 
            // txtLastName
            // 
            this.txtLastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLastName.Location = new System.Drawing.Point(95, 108);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(537, 29);
            this.txtLastName.TabIndex = 7;
            // 
            // txtDateDied
            // 
            this.txtDateDied.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDateDied.Location = new System.Drawing.Point(95, 178);
            this.txtDateDied.Name = "txtDateDied";
            this.txtDateDied.Size = new System.Drawing.Size(537, 29);
            this.txtDateDied.TabIndex = 11;
            // 
            // txtTermStart
            // 
            this.txtTermStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTermStart.Location = new System.Drawing.Point(95, 213);
            this.txtTermStart.Name = "txtTermStart";
            this.txtTermStart.Size = new System.Drawing.Size(537, 29);
            this.txtTermStart.TabIndex = 13;
            this.ttPresident.SetToolTip(this.txtTermStart, "Enter a Year not a Date");
            // 
            // txtTermEnd
            // 
            this.txtTermEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTermEnd.Location = new System.Drawing.Point(95, 248);
            this.txtTermEnd.Name = "txtTermEnd";
            this.txtTermEnd.Size = new System.Drawing.Size(537, 29);
            this.txtTermEnd.TabIndex = 15;
            this.ttPresident.SetToolTip(this.txtTermEnd, "Enter a Year not a Date");
            // 
            // lstPartyName
            // 
            this.lstPartyName.FormattingEnabled = true;
            this.lstPartyName.Location = new System.Drawing.Point(95, 3);
            this.lstPartyName.Name = "lstPartyName";
            this.lstPartyName.Size = new System.Drawing.Size(202, 29);
            this.lstPartyName.TabIndex = 1;
            // 
            // txtNum
            // 
            this.txtNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNum.Location = new System.Drawing.Point(95, 38);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(537, 29);
            this.txtNum.TabIndex = 3;
            // 
            // dtpDateBorn
            // 
            this.dtpDateBorn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateBorn.Location = new System.Drawing.Point(95, 143);
            this.dtpDateBorn.Name = "dtpDateBorn";
            this.dtpDateBorn.Size = new System.Drawing.Size(124, 29);
            this.dtpDateBorn.TabIndex = 9;
            this.dtpDateBorn.Value = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            // 
            // tbChildRecords
            // 
            this.tblMain.SetColumnSpan(this.tbChildRecords, 2);
            this.tbChildRecords.Controls.Add(this.tbMedal);
            this.tbChildRecords.Controls.Add(this.tbExecutiveOrder);
            this.tbChildRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbChildRecords.Location = new System.Drawing.Point(3, 283);
            this.tbChildRecords.Name = "tbChildRecords";
            this.tbChildRecords.SelectedIndex = 0;
            this.tbChildRecords.Size = new System.Drawing.Size(629, 267);
            this.tbChildRecords.TabIndex = 16;
            // 
            // tbMedal
            // 
            this.tbMedal.Controls.Add(this.tblMedals);
            this.tbMedal.Location = new System.Drawing.Point(4, 30);
            this.tbMedal.Name = "tbMedal";
            this.tbMedal.Padding = new System.Windows.Forms.Padding(3);
            this.tbMedal.Size = new System.Drawing.Size(621, 233);
            this.tbMedal.TabIndex = 0;
            this.tbMedal.Text = "Medals";
            this.tbMedal.UseVisualStyleBackColor = true;
            // 
            // tblMedals
            // 
            this.tblMedals.ColumnCount = 1;
            this.tblMedals.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMedals.Controls.Add(this.btnSaveMedal, 0, 0);
            this.tblMedals.Controls.Add(this.gMedal, 0, 1);
            this.tblMedals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMedals.Location = new System.Drawing.Point(3, 3);
            this.tblMedals.Name = "tblMedals";
            this.tblMedals.RowCount = 2;
            this.tblMedals.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMedals.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMedals.Size = new System.Drawing.Size(615, 227);
            this.tblMedals.TabIndex = 0;
            // 
            // btnSaveMedal
            // 
            this.btnSaveMedal.AutoSize = true;
            this.btnSaveMedal.Location = new System.Drawing.Point(3, 3);
            this.btnSaveMedal.Name = "btnSaveMedal";
            this.btnSaveMedal.Size = new System.Drawing.Size(75, 31);
            this.btnSaveMedal.TabIndex = 0;
            this.btnSaveMedal.Text = "Save";
            this.btnSaveMedal.UseVisualStyleBackColor = true;
            // 
            // gMedal
            // 
            this.gMedal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gMedal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMedal.Location = new System.Drawing.Point(3, 40);
            this.gMedal.Name = "gMedal";
            this.gMedal.RowTemplate.Height = 25;
            this.gMedal.Size = new System.Drawing.Size(609, 184);
            this.gMedal.TabIndex = 1;
            // 
            // tbExecutiveOrder
            // 
            this.tbExecutiveOrder.Location = new System.Drawing.Point(4, 24);
            this.tbExecutiveOrder.Name = "tbExecutiveOrder";
            this.tbExecutiveOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tbExecutiveOrder.Size = new System.Drawing.Size(621, 318);
            this.tbExecutiveOrder.TabIndex = 1;
            this.tbExecutiveOrder.Text = "Executive Orders";
            this.tbExecutiveOrder.UseVisualStyleBackColor = true;
            // 
            // tsMain
            // 
            this.tsMain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.toolStripSeparator1,
            this.btnDelete,
            this.toolStripSeparator2});
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(635, 28);
            this.tsMain.TabIndex = 1;
            this.tsMain.TabStop = true;
            this.tsMain.Text = "toolStrip1";
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(47, 25);
            this.btnSave.Text = "&Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(58, 25);
            this.btnDelete.Text = "&Delete";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // frmPresident
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 584);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.tblMain);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPresident";
            this.Text = "President";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.tbChildRecords.ResumeLayout(false);
            this.tbMedal.ResumeLayout(false);
            this.tblMedals.ResumeLayout(false);
            this.tblMedals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gMedal)).EndInit();
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblCaptionParty;
        private Label lblCaptionNum;
        private Label lblCaptionFirstName;
        private Label lblCaptionLastName;
        private Label lblCaptionDateBorn;
        private Label lblCaptionDateDied;
        private Label lblCaptionTermStart;
        private Label lblCaptionTermEnd;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtDateDied;
        private TextBox txtTermStart;
        private TextBox txtTermEnd;
        private ToolStrip tsMain;
        private ToolStripButton btnSave;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnDelete;
        private ToolStripSeparator toolStripSeparator2;
        private ComboBox lstPartyName;
        private TextBox txtNum;
        private DateTimePicker dtpDateBorn;
        private ToolTip ttPresident;
        private TabControl tbChildRecords;
        private TabPage tbMedal;
        private TabPage tbExecutiveOrder;
        private TableLayoutPanel tblMedals;
        private Button btnSaveMedal;
        private DataGridView gMedal;
    }
}