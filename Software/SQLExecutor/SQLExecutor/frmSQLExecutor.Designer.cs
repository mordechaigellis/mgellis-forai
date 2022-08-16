namespace SQLExecutor
{
    partial class frmSQLExecutor
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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.tblServer = new System.Windows.Forms.TableLayoutPanel();
            this.tblDatabase = new System.Windows.Forms.TableLayoutPanel();
            this.optRecordKeeper = new System.Windows.Forms.RadioButton();
            this.optLocalDB = new System.Windows.Forms.RadioButton();
            this.optRecipe = new System.Windows.Forms.RadioButton();
            this.optAzure = new System.Windows.Forms.RadioButton();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.tblMain.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tblServer.SuspendLayout();
            this.tblDatabase.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.125F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.875F));
            this.tblMain.Controls.Add(this.tabMain, 0, 2);
            this.tblMain.Controls.Add(this.lblDatabase, 0, 0);
            this.tblMain.Controls.Add(this.tblServer, 1, 0);
            this.tblMain.Controls.Add(this.tblDatabase, 0, 1);
            this.tblMain.Controls.Add(this.txtQuery, 1, 1);
            this.tblMain.Controls.Add(this.checkedListBox1, 0, 3);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 4;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.Size = new System.Drawing.Size(966, 554);
            this.tblMain.TabIndex = 0;
            this.tblMain.Paint += new System.Windows.Forms.PaintEventHandler(this.tblMain_Paint);
            // 
            // tabMain
            // 
            this.tblMain.SetColumnSpan(this.tabMain, 2);
            this.tabMain.Controls.Add(this.tabPage1);
            this.tabMain.Controls.Add(this.tabPage2);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(3, 216);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(960, 314);
            this.tabMain.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(952, 281);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(242, 92);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Location = new System.Drawing.Point(3, 0);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(72, 20);
            this.lblDatabase.TabIndex = 1;
            this.lblDatabase.Text = "Database";
            // 
            // tblServer
            // 
            this.tblServer.ColumnCount = 2;
            this.tblServer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblServer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblServer.Controls.Add(this.optLocalDB, 0, 0);
            this.tblServer.Controls.Add(this.optAzure, 1, 0);
            this.tblServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblServer.Location = new System.Drawing.Point(236, 3);
            this.tblServer.Name = "tblServer";
            this.tblServer.RowCount = 1;
            this.tblServer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblServer.Size = new System.Drawing.Size(727, 74);
            this.tblServer.TabIndex = 2;
            // 
            // tblDatabase
            // 
            this.tblDatabase.ColumnCount = 1;
            this.tblDatabase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDatabase.Controls.Add(this.optRecordKeeper, 0, 0);
            this.tblDatabase.Controls.Add(this.optRecipe, 0, 1);
            this.tblDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblDatabase.Location = new System.Drawing.Point(3, 83);
            this.tblDatabase.Name = "tblDatabase";
            this.tblDatabase.RowCount = 2;
            this.tblDatabase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDatabase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDatabase.Size = new System.Drawing.Size(227, 127);
            this.tblDatabase.TabIndex = 3;
            // 
            // optRecordKeeper
            // 
            this.optRecordKeeper.AutoSize = true;
            this.optRecordKeeper.Location = new System.Drawing.Point(3, 3);
            this.optRecordKeeper.Name = "optRecordKeeper";
            this.optRecordKeeper.Size = new System.Drawing.Size(124, 24);
            this.optRecordKeeper.TabIndex = 0;
            this.optRecordKeeper.TabStop = true;
            this.optRecordKeeper.Text = "RecordKeeper";
            this.optRecordKeeper.UseVisualStyleBackColor = true;
            // 
            // optLocalDB
            // 
            this.optLocalDB.AutoSize = true;
            this.optLocalDB.Location = new System.Drawing.Point(3, 3);
            this.optLocalDB.Name = "optLocalDB";
            this.optLocalDB.Size = new System.Drawing.Size(89, 24);
            this.optLocalDB.TabIndex = 0;
            this.optLocalDB.TabStop = true;
            this.optLocalDB.Text = "Local DB";
            this.optLocalDB.UseVisualStyleBackColor = true;
            // 
            // optRecipe
            // 
            this.optRecipe.AutoSize = true;
            this.optRecipe.Location = new System.Drawing.Point(3, 66);
            this.optRecipe.Name = "optRecipe";
            this.optRecipe.Size = new System.Drawing.Size(75, 24);
            this.optRecipe.TabIndex = 1;
            this.optRecipe.TabStop = true;
            this.optRecipe.Text = "Recipe";
            this.optRecipe.UseVisualStyleBackColor = true;
            // 
            // optAzure
            // 
            this.optAzure.AutoSize = true;
            this.optAzure.Location = new System.Drawing.Point(366, 3);
            this.optAzure.Name = "optAzure";
            this.optAzure.Size = new System.Drawing.Size(68, 24);
            this.optAzure.TabIndex = 1;
            this.optAzure.TabStop = true;
            this.optAzure.Text = "Azure";
            this.optAzure.UseVisualStyleBackColor = true;
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(236, 83);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(718, 27);
            this.txtQuery.TabIndex = 4;
            this.txtQuery.Text = "Type Query Here";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(3, 536);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(150, 4);
            this.checkedListBox1.TabIndex = 5;
            // 
            // frmSQLExecutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 554);
            this.Controls.Add(this.tblMain);
            this.Name = "frmSQLExecutor";
            this.Text = "SQL Executor";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.tblServer.ResumeLayout(false);
            this.tblServer.PerformLayout();
            this.tblDatabase.ResumeLayout(false);
            this.tblDatabase.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private TabControl tabMain;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label lblDatabase;
        private TableLayoutPanel tblServer;
        private RadioButton optLocalDB;
        private RadioButton optAzure;
        private TableLayoutPanel tblDatabase;
        private RadioButton optRecordKeeper;
        private RadioButton optRecipe;
        private TextBox txtQuery;
        private CheckedListBox checkedListBox1;
    }
}