namespace TicTacToe
{
    partial class frmTicTacToe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTicTacToe));
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.ctlTicTacToeMG = new TicTacToe.TicTacToeControlMG();
            this.ctlTicTacToeYou = new TicTacToe.TicTacToeControlYou();
            this.tblMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.Controls.Add(this.ctlTicTacToeMG, 0, 0);
            this.tblMain.Controls.Add(this.ctlTicTacToeYou, 1, 0);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 1;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Size = new System.Drawing.Size(1165, 577);
            this.tblMain.TabIndex = 0;
            // 
            // ctlTicTacToeMG
            // 
            this.ctlTicTacToeMG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlTicTacToeMG.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ctlTicTacToeMG.Location = new System.Drawing.Point(5, 5);
            this.ctlTicTacToeMG.Margin = new System.Windows.Forms.Padding(5);
            this.ctlTicTacToeMG.Name = "ctlTicTacToeMG";
            this.ctlTicTacToeMG.Size = new System.Drawing.Size(572, 567);
            this.ctlTicTacToeMG.TabIndex = 0;
            // 
            // ctlTicTacToeYou
            // 
            this.ctlTicTacToeYou.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlTicTacToeYou.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ctlTicTacToeYou.Location = new System.Drawing.Point(587, 5);
            this.ctlTicTacToeYou.Margin = new System.Windows.Forms.Padding(5);
            this.ctlTicTacToeYou.Name = "ctlTicTacToeYou";
            this.ctlTicTacToeYou.Size = new System.Drawing.Size(573, 567);
            this.ctlTicTacToeYou.TabIndex = 1;
            // 
            // frmTicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 577);
            this.Controls.Add(this.tblMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTicTacToe";
            this.Text = "Tic Tac Toe";
            this.tblMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private TicTacToeControlMG ctlTicTacToeMG;
        private TicTacToeControlYou ctlTicTacToeYou;
    }
}