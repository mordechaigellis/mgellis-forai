namespace RecordKeeperWinForm
{
    partial class frmOlympicsCreateBasedOnPrevious
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblSeason = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblBasedOn = new System.Windows.Forms.Label();
            this.lstSeasonName = new System.Windows.Forms.ComboBox();
            this.lstCityDesc = new System.Windows.Forms.ComboBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lstOlympicsDec = new System.Windows.Forms.ComboBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.tblMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 3;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Controls.Add(this.lblHeader, 0, 0);
            this.tblMain.Controls.Add(this.lblSeason, 0, 1);
            this.tblMain.Controls.Add(this.lblCity, 0, 2);
            this.tblMain.Controls.Add(this.lblYear, 0, 3);
            this.tblMain.Controls.Add(this.lblBasedOn, 0, 4);
            this.tblMain.Controls.Add(this.lstSeasonName, 1, 1);
            this.tblMain.Controls.Add(this.lstCityDesc, 1, 2);
            this.tblMain.Controls.Add(this.txtYear, 1, 3);
            this.tblMain.Controls.Add(this.lstOlympicsDec, 1, 4);
            this.tblMain.Controls.Add(this.btnCreate, 1, 5);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 6;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.Size = new System.Drawing.Size(635, 630);
            this.tblMain.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.tblMain.SetColumnSpan(this.lblHeader, 2);
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHeader.Location = new System.Drawing.Point(3, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(551, 32);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Create New Olympics based on previous Olympics";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeason
            // 
            this.lblSeason.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSeason.AutoSize = true;
            this.lblSeason.Location = new System.Drawing.Point(3, 42);
            this.lblSeason.Name = "lblSeason";
            this.lblSeason.Size = new System.Drawing.Size(96, 21);
            this.lblSeason.TabIndex = 1;
            this.lblSeason.Text = "New Season";
            // 
            // lblCity
            // 
            this.lblCity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(3, 84);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(73, 21);
            this.lblCity.TabIndex = 2;
            this.lblCity.Text = "New City";
            // 
            // lblYear
            // 
            this.lblYear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(3, 126);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(76, 21);
            this.lblYear.TabIndex = 3;
            this.lblYear.Text = "New Year";
            // 
            // lblBasedOn
            // 
            this.lblBasedOn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBasedOn.AutoSize = true;
            this.lblBasedOn.Location = new System.Drawing.Point(3, 168);
            this.lblBasedOn.Name = "lblBasedOn";
            this.lblBasedOn.Size = new System.Drawing.Size(76, 21);
            this.lblBasedOn.TabIndex = 4;
            this.lblBasedOn.Text = "Based On";
            // 
            // lstSeasonName
            // 
            this.lstSeasonName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSeasonName.FormattingEnabled = true;
            this.lstSeasonName.Location = new System.Drawing.Point(105, 35);
            this.lstSeasonName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.lstSeasonName.Name = "lstSeasonName";
            this.lstSeasonName.Size = new System.Drawing.Size(449, 29);
            this.lstSeasonName.TabIndex = 0;
            // 
            // lstCityDesc
            // 
            this.lstCityDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstCityDesc.FormattingEnabled = true;
            this.lstCityDesc.Location = new System.Drawing.Point(105, 77);
            this.lstCityDesc.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.lstCityDesc.Name = "lstCityDesc";
            this.lstCityDesc.Size = new System.Drawing.Size(449, 29);
            this.lstCityDesc.TabIndex = 1;
            // 
            // txtYear
            // 
            this.txtYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtYear.Location = new System.Drawing.Point(105, 119);
            this.txtYear.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(449, 29);
            this.txtYear.TabIndex = 2;
            // 
            // lstOlympicsDec
            // 
            this.lstOlympicsDec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstOlympicsDec.FormattingEnabled = true;
            this.lstOlympicsDec.Location = new System.Drawing.Point(105, 161);
            this.lstOlympicsDec.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.lstOlympicsDec.Name = "lstOlympicsDec";
            this.lstOlympicsDec.Size = new System.Drawing.Size(449, 29);
            this.lstOlympicsDec.TabIndex = 3;
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.AutoSize = true;
            this.btnCreate.Location = new System.Drawing.Point(384, 203);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(170, 31);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create New Olympics";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // frmOlympicsCreateBasedOnPrevious
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 630);
            this.Controls.Add(this.tblMain);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmOlympicsCreateBasedOnPrevious";
            this.Text = "Olympics Create Based On Previous";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblHeader;
        private Label lblSeason;
        private Label lblCity;
        private Label lblYear;
        private Label lblBasedOn;
        private Button btnCreate;
        private ComboBox lstSeasonName;
        private ComboBox lstCityDesc;
        private TextBox txtYear;
        private ComboBox lstOlympicsDec;
    }
}