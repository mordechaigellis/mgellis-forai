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
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tblOutput = new System.Windows.Forms.TableLayoutPanel();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.gOutput = new System.Windows.Forms.DataGridView();
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
            this.tblMain.Controls.Add(this.button3, 2, 1);
            this.tblMain.Controls.Add(this.button4, 3, 1);
            this.tblMain.Controls.Add(this.tblOutput, 0, 0);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 4;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblMain.Size = new System.Drawing.Size(760, 529);
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
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(382, 214);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(182, 98);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Location = new System.Drawing.Point(571, 214);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(185, 98);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
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
            this.tblOutput.Size = new System.Drawing.Size(752, 203);
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
            // frmLanguageBasics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 529);
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
        private Button button3;
        private Button button4;
        private TableLayoutPanel tblOutput;
        private TextBox txtOutput;
        private DataGridView gOutput;
    }
}