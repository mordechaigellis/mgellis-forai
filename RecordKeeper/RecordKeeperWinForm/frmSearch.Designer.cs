namespace RecordKeeperWinForm
{
    partial class frmSearch
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
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.tblSearch = new System.Windows.Forms.TableLayoutPanel();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblParty = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstParty = new System.Windows.Forms.ComboBox();
            this.tblTermStart = new System.Windows.Forms.TableLayoutPanel();
            this.txtBeginTermStart = new System.Windows.Forms.TextBox();
            this.txtEndTermStart = new System.Windows.Forms.TextBox();
            this.lblTermStartTo = new System.Windows.Forms.Label();
            this.gPresident = new System.Windows.Forms.DataGridView();
            this.tblMain.SuspendLayout();
            this.tblSearch.SuspendLayout();
            this.tblTermStart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gPresident)).BeginInit();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 1;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.Controls.Add(this.tblSearch, 0, 0);
            this.tblMain.Controls.Add(this.gPresident, 0, 1);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Margin = new System.Windows.Forms.Padding(4);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 2;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.Size = new System.Drawing.Size(706, 630);
            this.tblMain.TabIndex = 1;
            // 
            // tblSearch
            // 
            this.tblSearch.AutoSize = true;
            this.tblSearch.ColumnCount = 4;
            this.tblSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblSearch.Controls.Add(this.lblLastName, 0, 1);
            this.tblSearch.Controls.Add(this.txtLastName, 1, 1);
            this.tblSearch.Controls.Add(this.btnSearch, 0, 3);
            this.tblSearch.Controls.Add(this.btnNew, 1, 3);
            this.tblSearch.Controls.Add(this.lblParty, 0, 0);
            this.tblSearch.Controls.Add(this.label2, 0, 2);
            this.tblSearch.Controls.Add(this.lstParty, 1, 0);
            this.tblSearch.Controls.Add(this.tblTermStart, 1, 2);
            this.tblSearch.Location = new System.Drawing.Point(4, 4);
            this.tblSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tblSearch.Name = "tblSearch";
            this.tblSearch.RowCount = 4;
            this.tblSearch.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblSearch.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblSearch.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblSearch.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblSearch.Size = new System.Drawing.Size(262, 148);
            this.tblSearch.TabIndex = 0;
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(4, 42);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(84, 21);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "&Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLastName.Location = new System.Drawing.Point(95, 38);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(164, 29);
            this.txtLastName.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSearch.AutoSize = true;
            this.btnSearch.Location = new System.Drawing.Point(3, 114);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 31);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.AutoSize = true;
            this.btnNew.Location = new System.Drawing.Point(207, 114);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(52, 31);
            this.btnNew.TabIndex = 7;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // lblParty
            // 
            this.lblParty.AutoSize = true;
            this.lblParty.Location = new System.Drawing.Point(3, 0);
            this.lblParty.Name = "lblParty";
            this.lblParty.Size = new System.Drawing.Size(45, 21);
            this.lblParty.TabIndex = 0;
            this.lblParty.Text = "Party";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Term Start";
            // 
            // lstParty
            // 
            this.lstParty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstParty.FormattingEnabled = true;
            this.lstParty.Location = new System.Drawing.Point(95, 3);
            this.lstParty.Name = "lstParty";
            this.lstParty.Size = new System.Drawing.Size(164, 29);
            this.lstParty.TabIndex = 1;
            // 
            // tblTermStart
            // 
            this.tblTermStart.AutoSize = true;
            this.tblTermStart.ColumnCount = 3;
            this.tblTermStart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblTermStart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblTermStart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblTermStart.Controls.Add(this.txtBeginTermStart, 0, 0);
            this.tblTermStart.Controls.Add(this.txtEndTermStart, 2, 0);
            this.tblTermStart.Controls.Add(this.lblTermStartTo, 1, 0);
            this.tblTermStart.Location = new System.Drawing.Point(95, 73);
            this.tblTermStart.Name = "tblTermStart";
            this.tblTermStart.RowCount = 1;
            this.tblTermStart.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblTermStart.Size = new System.Drawing.Size(164, 35);
            this.tblTermStart.TabIndex = 5;
            // 
            // txtBeginTermStart
            // 
            this.txtBeginTermStart.Location = new System.Drawing.Point(3, 3);
            this.txtBeginTermStart.Name = "txtBeginTermStart";
            this.txtBeginTermStart.Size = new System.Drawing.Size(60, 29);
            this.txtBeginTermStart.TabIndex = 0;
            // 
            // txtEndTermStart
            // 
            this.txtEndTermStart.Location = new System.Drawing.Point(99, 3);
            this.txtEndTermStart.Name = "txtEndTermStart";
            this.txtEndTermStart.Size = new System.Drawing.Size(62, 29);
            this.txtEndTermStart.TabIndex = 2;
            // 
            // lblTermStartTo
            // 
            this.lblTermStartTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTermStartTo.AutoSize = true;
            this.lblTermStartTo.Location = new System.Drawing.Point(69, 7);
            this.lblTermStartTo.Name = "lblTermStartTo";
            this.lblTermStartTo.Size = new System.Drawing.Size(24, 21);
            this.lblTermStartTo.TabIndex = 1;
            this.lblTermStartTo.Text = "to";
            // 
            // gPresident
            // 
            this.gPresident.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gPresident.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gPresident.Location = new System.Drawing.Point(3, 159);
            this.gPresident.Name = "gPresident";
            this.gPresident.RowTemplate.Height = 25;
            this.gPresident.Size = new System.Drawing.Size(700, 468);
            this.gPresident.StandardTab = true;
            this.gPresident.TabIndex = 0;
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 630);
            this.Controls.Add(this.tblMain);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSearch";
            this.Text = "President Search";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.tblSearch.ResumeLayout(false);
            this.tblSearch.PerformLayout();
            this.tblTermStart.ResumeLayout(false);
            this.tblTermStart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gPresident)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private TableLayoutPanel tblSearch;
        private Label lblLastName;
        private TextBox txtLastName;
        private Button btnSearch;
        private DataGridView gPresident;
        private Button btnNew;
        private Label lblParty;
        private Label label2;
        private ComboBox lstParty;
        private TableLayoutPanel tblTermStart;
        private TextBox txtBeginTermStart;
        private TextBox txtEndTermStart;
        private Label lblTermStartTo;
    }
}