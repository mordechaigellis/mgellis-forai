namespace LanguageBasics
{
    partial class frmTest
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
            this.button1 = new System.Windows.Forms.Button();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.optTea = new System.Windows.Forms.RadioButton();
            this.optMilk = new System.Windows.Forms.RadioButton();
            this.optWater = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.optPizza = new System.Windows.Forms.RadioButton();
            this.optBread = new System.Windows.Forms.RadioButton();
            this.tabMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(583, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 53);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabMain
            // 
            this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMain.Controls.Add(this.tabPage1);
            this.tabMain.Location = new System.Drawing.Point(12, 282);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(775, 365);
            this.tabMain.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(767, 327);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.optTea, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.optMilk, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.optWater, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(81, 37);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(448, 221);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // optTea
            // 
            this.optTea.AutoSize = true;
            this.optTea.Location = new System.Drawing.Point(3, 155);
            this.optTea.Name = "optTea";
            this.optTea.Size = new System.Drawing.Size(58, 29);
            this.optTea.TabIndex = 2;
            this.optTea.Text = "Tea";
            this.optTea.UseVisualStyleBackColor = true;
            // 
            // optMilk
            // 
            this.optMilk.AutoSize = true;
            this.optMilk.Location = new System.Drawing.Point(3, 102);
            this.optMilk.Name = "optMilk";
            this.optMilk.Size = new System.Drawing.Size(66, 29);
            this.optMilk.TabIndex = 1;
            this.optMilk.Text = "Milk";
            this.optMilk.UseVisualStyleBackColor = true;
            // 
            // optWater
            // 
            this.optWater.AutoSize = true;
            this.optWater.Checked = true;
            this.optWater.Location = new System.Drawing.Point(3, 49);
            this.optWater.Name = "optWater";
            this.optWater.Size = new System.Drawing.Size(80, 29);
            this.optWater.TabIndex = 0;
            this.optWater.TabStop = true;
            this.optWater.Text = "Water";
            this.optWater.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.optPizza, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.optBread, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(442, 40);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // optPizza
            // 
            this.optPizza.AutoSize = true;
            this.optPizza.Location = new System.Drawing.Point(224, 3);
            this.optPizza.Name = "optPizza";
            this.optPizza.Size = new System.Drawing.Size(74, 29);
            this.optPizza.TabIndex = 4;
            this.optPizza.Text = "Pizza";
            this.optPizza.UseVisualStyleBackColor = true;
            // 
            // optBread
            // 
            this.optBread.AutoSize = true;
            this.optBread.Checked = true;
            this.optBread.Location = new System.Drawing.Point(3, 3);
            this.optBread.Name = "optBread";
            this.optBread.Size = new System.Drawing.Size(79, 29);
            this.optBread.TabIndex = 3;
            this.optBread.TabStop = true;
            this.optBread.Text = "Bread";
            this.optBread.UseVisualStyleBackColor = true;
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 659);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmTest";
            this.Text = "Test";
            this.tabMain.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button button1;
        private TabControl tabMain;
        private TabPage tabPage1;
        private TableLayoutPanel tableLayoutPanel1;
        private RadioButton optTea;
        private RadioButton optMilk;
        private RadioButton optWater;
        private TableLayoutPanel tableLayoutPanel2;
        private RadioButton optPizza;
        private RadioButton optBread;
    }
}