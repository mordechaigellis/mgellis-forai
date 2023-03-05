namespace RecordKeeperWinForm
{
    partial class frmDataMaintenance
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
            this.btnSave = new System.Windows.Forms.Button();
            this.gData = new System.Windows.Forms.DataGridView();
            this.pnlOptionButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.optCountry = new System.Windows.Forms.RadioButton();
            this.optCity = new System.Windows.Forms.RadioButton();
            this.optOlympicMedal = new System.Windows.Forms.RadioButton();
            this.optSeason = new System.Windows.Forms.RadioButton();
            this.optSport = new System.Windows.Forms.RadioButton();
            this.optSportSubcategory = new System.Windows.Forms.RadioButton();
            this.tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gData)).BeginInit();
            this.pnlOptionButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.625F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.375F));
            this.tblMain.Controls.Add(this.btnSave, 0, 0);
            this.tblMain.Controls.Add(this.gData, 1, 1);
            this.tblMain.Controls.Add(this.pnlOptionButtons, 0, 1);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Margin = new System.Windows.Forms.Padding(4);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 2;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.77778F));
            this.tblMain.Size = new System.Drawing.Size(1029, 630);
            this.tblMain.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Location = new System.Drawing.Point(4, 4);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 35);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // gData
            // 
            this.gData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gData.Location = new System.Drawing.Point(256, 46);
            this.gData.Name = "gData";
            this.gData.RowTemplate.Height = 25;
            this.gData.Size = new System.Drawing.Size(770, 581);
            this.gData.TabIndex = 1;
            // 
            // pnlOptionButtons
            // 
            this.pnlOptionButtons.Controls.Add(this.optCountry);
            this.pnlOptionButtons.Controls.Add(this.optCity);
            this.pnlOptionButtons.Controls.Add(this.optOlympicMedal);
            this.pnlOptionButtons.Controls.Add(this.optSeason);
            this.pnlOptionButtons.Controls.Add(this.optSport);
            this.pnlOptionButtons.Controls.Add(this.optSportSubcategory);
            this.pnlOptionButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOptionButtons.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlOptionButtons.Location = new System.Drawing.Point(3, 46);
            this.pnlOptionButtons.Name = "pnlOptionButtons";
            this.pnlOptionButtons.Size = new System.Drawing.Size(247, 581);
            this.pnlOptionButtons.TabIndex = 2;
            // 
            // optCountry
            // 
            this.optCountry.AutoSize = true;
            this.optCountry.Checked = true;
            this.optCountry.Location = new System.Drawing.Point(3, 3);
            this.optCountry.Name = "optCountry";
            this.optCountry.Size = new System.Drawing.Size(95, 25);
            this.optCountry.TabIndex = 0;
            this.optCountry.TabStop = true;
            this.optCountry.Text = "Countries";
            this.optCountry.UseVisualStyleBackColor = true;
            // 
            // optCity
            // 
            this.optCity.AutoSize = true;
            this.optCity.Location = new System.Drawing.Point(3, 34);
            this.optCity.Name = "optCity";
            this.optCity.Size = new System.Drawing.Size(66, 25);
            this.optCity.TabIndex = 1;
            this.optCity.Text = "Cities";
            this.optCity.UseVisualStyleBackColor = true;
            // 
            // optOlympicMedal
            // 
            this.optOlympicMedal.AutoSize = true;
            this.optOlympicMedal.Location = new System.Drawing.Point(3, 65);
            this.optOlympicMedal.Name = "optOlympicMedal";
            this.optOlympicMedal.Size = new System.Drawing.Size(140, 25);
            this.optOlympicMedal.TabIndex = 2;
            this.optOlympicMedal.Text = "Olympic Medals";
            this.optOlympicMedal.UseVisualStyleBackColor = true;
            // 
            // optSeason
            // 
            this.optSeason.AutoSize = true;
            this.optSeason.Location = new System.Drawing.Point(3, 96);
            this.optSeason.Name = "optSeason";
            this.optSeason.Size = new System.Drawing.Size(85, 25);
            this.optSeason.TabIndex = 3;
            this.optSeason.Text = "Seasons";
            this.optSeason.UseVisualStyleBackColor = true;
            // 
            // optSport
            // 
            this.optSport.AutoSize = true;
            this.optSport.Location = new System.Drawing.Point(3, 127);
            this.optSport.Name = "optSport";
            this.optSport.Size = new System.Drawing.Size(73, 25);
            this.optSport.TabIndex = 4;
            this.optSport.Text = "Sports";
            this.optSport.UseVisualStyleBackColor = true;
            // 
            // optSportSubcategory
            // 
            this.optSportSubcategory.AutoSize = true;
            this.optSportSubcategory.Location = new System.Drawing.Point(3, 158);
            this.optSportSubcategory.Name = "optSportSubcategory";
            this.optSportSubcategory.Size = new System.Drawing.Size(168, 25);
            this.optSportSubcategory.TabIndex = 5;
            this.optSportSubcategory.Text = "Sport Subcategories";
            this.optSportSubcategory.UseVisualStyleBackColor = true;
            // 
            // frmDataMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 630);
            this.Controls.Add(this.tblMain);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDataMaintenance";
            this.Text = "Data Maintenance";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gData)).EndInit();
            this.pnlOptionButtons.ResumeLayout(false);
            this.pnlOptionButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private Button btnSave;
        private DataGridView gData;
        private FlowLayoutPanel pnlOptionButtons;
        private RadioButton optCountry;
        private RadioButton optCity;
        private RadioButton optOlympicMedal;
        private RadioButton optSeason;
        private RadioButton optSport;
        private RadioButton optSportSubcategory;
    }
}