namespace LanguageBasics
{
    partial class frmLanguageBasics
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
            this.btnEventHandler1 = new System.Windows.Forms.Button();
            this.btnEventHandler2 = new System.Windows.Forms.Button();
            this.btnVariable1 = new System.Windows.Forms.Button();
            this.btnVariable2 = new System.Windows.Forms.Button();
            this.tblOutput = new System.Windows.Forms.TableLayoutPanel();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.gOutput = new System.Windows.Forms.DataGridView();
            this.btnDataConversion1 = new System.Windows.Forms.Button();
            this.btnDataConversion2 = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnIf1 = new System.Windows.Forms.Button();
            this.btnIf2 = new System.Windows.Forms.Button();
            this.btnAddControl1 = new System.Windows.Forms.Button();
            this.tblMain.SuspendLayout();
            this.tblOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblMain.ColumnCount = 4;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblMain.Controls.Add(this.btnEventHandler1, 0, 1);
            this.tblMain.Controls.Add(this.btnEventHandler2, 1, 1);
            this.tblMain.Controls.Add(this.btnVariable1, 2, 1);
            this.tblMain.Controls.Add(this.btnVariable2, 3, 1);
            this.tblMain.Controls.Add(this.tblOutput, 0, 0);
            this.tblMain.Controls.Add(this.btnDataConversion1, 0, 2);
            this.tblMain.Controls.Add(this.btnDataConversion2, 1, 2);
            this.tblMain.Controls.Add(this.btnRandom, 2, 2);
            this.tblMain.Controls.Add(this.btnIf1, 0, 3);
            this.tblMain.Controls.Add(this.btnIf2, 1, 3);
            this.tblMain.Controls.Add(this.btnAddControl1, 2, 3);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 4;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblMain.Size = new System.Drawing.Size(759, 529);
            this.tblMain.TabIndex = 0;
            // 
            // btnEventHandler1
            // 
            this.btnEventHandler1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEventHandler1.Location = new System.Drawing.Point(4, 214);
            this.btnEventHandler1.Name = "btnEventHandler1";
            this.btnEventHandler1.Size = new System.Drawing.Size(182, 98);
            this.btnEventHandler1.TabIndex = 0;
            this.btnEventHandler1.Text = "Event Handler 1";
            this.btnEventHandler1.UseVisualStyleBackColor = true;
            // 
            // btnEventHandler2
            // 
            this.btnEventHandler2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEventHandler2.Location = new System.Drawing.Point(193, 214);
            this.btnEventHandler2.Name = "btnEventHandler2";
            this.btnEventHandler2.Size = new System.Drawing.Size(182, 98);
            this.btnEventHandler2.TabIndex = 1;
            this.btnEventHandler2.Text = "Event Handler 2";
            this.btnEventHandler2.UseVisualStyleBackColor = true;
            // 
            // btnVariable1
            // 
            this.btnVariable1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVariable1.Location = new System.Drawing.Point(382, 214);
            this.btnVariable1.Name = "btnVariable1";
            this.btnVariable1.Size = new System.Drawing.Size(182, 98);
            this.btnVariable1.TabIndex = 2;
            this.btnVariable1.Text = "Variables 1";
            this.btnVariable1.UseVisualStyleBackColor = true;
            // 
            // btnVariable2
            // 
            this.btnVariable2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVariable2.Location = new System.Drawing.Point(571, 214);
            this.btnVariable2.Name = "btnVariable2";
            this.btnVariable2.Size = new System.Drawing.Size(184, 98);
            this.btnVariable2.TabIndex = 3;
            this.btnVariable2.Text = "Variables 2";
            this.btnVariable2.UseVisualStyleBackColor = true;
            // 
            // tblOutput
            // 
            this.tblOutput.ColumnCount = 3;
            this.tblMain.SetColumnSpan(this.tblOutput, 4);
            this.tblOutput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblOutput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblOutput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblOutput.Controls.Add(this.txtOutput, 0, 0);
            this.tblOutput.Controls.Add(this.gOutput, 1, 0);
            this.tblOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblOutput.Location = new System.Drawing.Point(4, 4);
            this.tblOutput.Name = "tblOutput";
            this.tblOutput.RowCount = 1;
            this.tblOutput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblOutput.Size = new System.Drawing.Size(751, 203);
            this.tblOutput.TabIndex = 4;
            // 
            // txtOutput
            // 
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.Location = new System.Drawing.Point(3, 3);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(244, 197);
            this.txtOutput.TabIndex = 0;
            // 
            // gOutput
            // 
            this.gOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gOutput.Location = new System.Drawing.Point(253, 3);
            this.gOutput.Name = "gOutput";
            this.gOutput.RowTemplate.Height = 25;
            this.gOutput.Size = new System.Drawing.Size(244, 197);
            this.gOutput.TabIndex = 1;
            // 
            // btnDataConversion1
            // 
            this.btnDataConversion1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDataConversion1.Location = new System.Drawing.Point(4, 319);
            this.btnDataConversion1.Name = "btnDataConversion1";
            this.btnDataConversion1.Size = new System.Drawing.Size(182, 98);
            this.btnDataConversion1.TabIndex = 5;
            this.btnDataConversion1.Text = "Data Conversion 1";
            this.btnDataConversion1.UseVisualStyleBackColor = true;
            // 
            // btnDataConversion2
            // 
            this.btnDataConversion2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDataConversion2.Location = new System.Drawing.Point(193, 319);
            this.btnDataConversion2.Name = "btnDataConversion2";
            this.btnDataConversion2.Size = new System.Drawing.Size(182, 98);
            this.btnDataConversion2.TabIndex = 6;
            this.btnDataConversion2.Text = "Data Conversion 2";
            this.btnDataConversion2.UseVisualStyleBackColor = true;
            // 
            // btnRandom
            // 
            this.btnRandom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRandom.Location = new System.Drawing.Point(382, 319);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(182, 98);
            this.btnRandom.TabIndex = 7;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            // 
            // btnIf1
            // 
            this.btnIf1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIf1.Location = new System.Drawing.Point(4, 424);
            this.btnIf1.Name = "btnIf1";
            this.btnIf1.Size = new System.Drawing.Size(182, 101);
            this.btnIf1.TabIndex = 8;
            this.btnIf1.Text = "If 1";
            this.btnIf1.UseVisualStyleBackColor = true;
            // 
            // btnIf2
            // 
            this.btnIf2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIf2.Location = new System.Drawing.Point(193, 424);
            this.btnIf2.Name = "btnIf2";
            this.btnIf2.Size = new System.Drawing.Size(182, 101);
            this.btnIf2.TabIndex = 9;
            this.btnIf2.Text = "If 2";
            this.btnIf2.UseVisualStyleBackColor = true;
            // 
            // btnAddControl1
            // 
            this.btnAddControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddControl1.Location = new System.Drawing.Point(382, 424);
            this.btnAddControl1.Name = "btnAddControl1";
            this.btnAddControl1.Size = new System.Drawing.Size(182, 101);
            this.btnAddControl1.TabIndex = 10;
            this.btnAddControl1.Text = "Add Control 1";
            this.btnAddControl1.UseVisualStyleBackColor = true;
            // 
            // frmLanguageBasics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 529);
            this.Controls.Add(this.tblMain);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmLanguageBasics";
            this.Text = "Language Basics";
            this.tblMain.ResumeLayout(false);
            this.tblOutput.ResumeLayout(false);
            this.tblOutput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gOutput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private Button btnEventHandler1;
        private Button btnEventHandler2;
        private Button btnVariable1;
        private Button btnVariable2;
        private TableLayoutPanel tblOutput;
        private TextBox txtOutput;
        private DataGridView gOutput;
        private Button btnDataConversion1;
        private Button btnDataConversion2;
        private Button btnRandom;
        private Button btnIf1;
        private Button btnIf2;
        private Button btnAddControl1;
    }
}