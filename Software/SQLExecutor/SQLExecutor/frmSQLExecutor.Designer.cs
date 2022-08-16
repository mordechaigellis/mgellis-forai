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
            this.lblDatabase = new System.Windows.Forms.Label();
            this.tblServer = new System.Windows.Forms.TableLayoutPanel();
            this.optLocalDB = new System.Windows.Forms.RadioButton();
            this.optAzure = new System.Windows.Forms.RadioButton();
            this.tblDatabase = new System.Windows.Forms.TableLayoutPanel();
            this.optRecordKeeper = new System.Windows.Forms.RadioButton();
            this.optRecipe = new System.Windows.Forms.RadioButton();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.btnRunQuery = new System.Windows.Forms.Button();
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
            this.tblMain.Controls.Add(this.tabMain, 0, 3);
            this.tblMain.Controls.Add(this.lblDatabase, 0, 0);
            this.tblMain.Controls.Add(this.tblServer, 1, 0);
            this.tblMain.Controls.Add(this.tblDatabase, 0, 1);
            this.tblMain.Controls.Add(this.txtQuery, 1, 1);
            this.tblMain.Controls.Add(this.btnRunQuery, 1, 2);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 4;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblMain.Size = new System.Drawing.Size(960, 471);
            this.tblMain.TabIndex = 0;
            // 
            // tabMain
            // 
            this.tblMain.SetColumnSpan(this.tabMain, 2);
            this.tabMain.Controls.Add(this.tabPage1);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabMain.Location = new System.Drawing.Point(3, 191);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(954, 277);
            this.tabMain.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(946, 241);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDatabase.Location = new System.Drawing.Point(3, 0);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(81, 23);
            this.lblDatabase.TabIndex = 0;
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
            this.tblServer.Location = new System.Drawing.Point(234, 3);
            this.tblServer.Name = "tblServer";
            this.tblServer.RowCount = 1;
            this.tblServer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblServer.Size = new System.Drawing.Size(723, 41);
            this.tblServer.TabIndex = 2;
            // 
            // optLocalDB
            // 
            this.optLocalDB.AutoSize = true;
            this.optLocalDB.Checked = true;
            this.optLocalDB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.optLocalDB.Location = new System.Drawing.Point(3, 3);
            this.optLocalDB.Name = "optLocalDB";
            this.optLocalDB.Size = new System.Drawing.Size(97, 27);
            this.optLocalDB.TabIndex = 0;
            this.optLocalDB.TabStop = true;
            this.optLocalDB.Text = "Local DB";
            this.optLocalDB.UseVisualStyleBackColor = true;
            // 
            // optAzure
            // 
            this.optAzure.AutoSize = true;
            this.optAzure.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.optAzure.Location = new System.Drawing.Point(364, 3);
            this.optAzure.Name = "optAzure";
            this.optAzure.Size = new System.Drawing.Size(75, 27);
            this.optAzure.TabIndex = 1;
            this.optAzure.Text = "Azure";
            this.optAzure.UseVisualStyleBackColor = true;
            // 
            // tblDatabase
            // 
            this.tblDatabase.ColumnCount = 1;
            this.tblDatabase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDatabase.Controls.Add(this.optRecordKeeper, 0, 0);
            this.tblDatabase.Controls.Add(this.optRecipe, 0, 1);
            this.tblDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblDatabase.Location = new System.Drawing.Point(3, 50);
            this.tblDatabase.Name = "tblDatabase";
            this.tblDatabase.RowCount = 2;
            this.tblMain.SetRowSpan(this.tblDatabase, 2);
            this.tblDatabase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDatabase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDatabase.Size = new System.Drawing.Size(225, 135);
            this.tblDatabase.TabIndex = 3;
            // 
            // optRecordKeeper
            // 
            this.optRecordKeeper.AutoSize = true;
            this.optRecordKeeper.Checked = true;
            this.optRecordKeeper.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.optRecordKeeper.Location = new System.Drawing.Point(3, 3);
            this.optRecordKeeper.Name = "optRecordKeeper";
            this.optRecordKeeper.Size = new System.Drawing.Size(137, 27);
            this.optRecordKeeper.TabIndex = 0;
            this.optRecordKeeper.TabStop = true;
            this.optRecordKeeper.Text = "RecordKeeper";
            this.optRecordKeeper.UseVisualStyleBackColor = true;
            // 
            // optRecipe
            // 
            this.optRecipe.AutoSize = true;
            this.optRecipe.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.optRecipe.Location = new System.Drawing.Point(3, 70);
            this.optRecipe.Name = "optRecipe";
            this.optRecipe.Size = new System.Drawing.Size(81, 27);
            this.optRecipe.TabIndex = 1;
            this.optRecipe.Text = "Recipe";
            this.optRecipe.UseVisualStyleBackColor = true;
            // 
            // txtQuery
            // 
            this.txtQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQuery.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQuery.Location = new System.Drawing.Point(234, 50);
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(723, 88);
            this.txtQuery.TabIndex = 4;
            this.txtQuery.Text = "Type Query Here";
            // 
            // btnRunQuery
            // 
            this.btnRunQuery.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRunQuery.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRunQuery.Location = new System.Drawing.Point(863, 144);
            this.btnRunQuery.Name = "btnRunQuery";
            this.btnRunQuery.Size = new System.Drawing.Size(94, 41);
            this.btnRunQuery.TabIndex = 5;
            this.btnRunQuery.Text = "Run Query";
            this.btnRunQuery.UseVisualStyleBackColor = true;
            this.btnRunQuery.Click += new System.EventHandler(this.btnRunQuery_Click);
            // 
            // frmSQLExecutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 471);
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
        private Label lblDatabase;
        private TableLayoutPanel tblServer;
        private RadioButton optLocalDB;
        private RadioButton optAzure;
        private TableLayoutPanel tblDatabase;
        private RadioButton optRecordKeeper;
        private RadioButton optRecipe;
        private TextBox txtQuery;
        private Button btnRunQuery;
        private TabControl tabMain;
        private TabPage tabPage1;
    }
}