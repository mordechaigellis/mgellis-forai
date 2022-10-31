namespace TicTacToe
{
    partial class TicTacToeControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.tblToolbar = new System.Windows.Forms.TableLayoutPanel();
            this.btnStart = new System.Windows.Forms.Button();
            this.optTwoPlayer = new System.Windows.Forms.RadioButton();
            this.optPlayComputer = new System.Windows.Forms.RadioButton();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tblSpots = new System.Windows.Forms.TableLayoutPanel();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.tblMain.SuspendLayout();
            this.tblToolbar.SuspendLayout();
            this.tblSpots.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 1;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Controls.Add(this.tblToolbar, 0, 0);
            this.tblMain.Controls.Add(this.tblSpots, 0, 1);
            this.tblMain.Controls.Add(this.lblName, 0, 2);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 3;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.64433F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.35567F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblMain.Size = new System.Drawing.Size(692, 451);
            this.tblMain.TabIndex = 0;
            // 
            // tblToolbar
            // 
            this.tblToolbar.ColumnCount = 4;
            this.tblToolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblToolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblToolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblToolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblToolbar.Controls.Add(this.btnStart, 0, 0);
            this.tblToolbar.Controls.Add(this.optTwoPlayer, 1, 0);
            this.tblToolbar.Controls.Add(this.optPlayComputer, 2, 0);
            this.tblToolbar.Controls.Add(this.lblStatus, 0, 1);
            this.tblToolbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblToolbar.Location = new System.Drawing.Point(3, 3);
            this.tblToolbar.Name = "tblToolbar";
            this.tblToolbar.RowCount = 2;
            this.tblToolbar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblToolbar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblToolbar.Size = new System.Drawing.Size(686, 74);
            this.tblToolbar.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnStart.AutoSize = true;
            this.btnStart.Location = new System.Drawing.Point(3, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(88, 31);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "&Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // optTwoPlayer
            // 
            this.optTwoPlayer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.optTwoPlayer.AutoSize = true;
            this.optTwoPlayer.Location = new System.Drawing.Point(97, 4);
            this.optTwoPlayer.Name = "optTwoPlayer";
            this.optTwoPlayer.Size = new System.Drawing.Size(97, 29);
            this.optTwoPlayer.TabIndex = 1;
            this.optTwoPlayer.TabStop = true;
            this.optTwoPlayer.Text = "2 &Player";
            this.optTwoPlayer.UseVisualStyleBackColor = true;
            // 
            // optPlayComputer
            // 
            this.optPlayComputer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.optPlayComputer.AutoSize = true;
            this.optPlayComputer.Location = new System.Drawing.Point(200, 4);
            this.optPlayComputer.Name = "optPlayComputer";
            this.optPlayComputer.Size = new System.Drawing.Size(254, 29);
            this.optPlayComputer.TabIndex = 2;
            this.optPlayComputer.TabStop = true;
            this.optPlayComputer.Text = "Play &Against the Computer";
            this.optPlayComputer.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.LightYellow;
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tblToolbar.SetColumnSpan(this.lblStatus, 4);
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.Location = new System.Drawing.Point(3, 37);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(680, 37);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblSpots
            // 
            this.tblSpots.ColumnCount = 3;
            this.tblSpots.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblSpots.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblSpots.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblSpots.Controls.Add(this.btn1, 0, 0);
            this.tblSpots.Controls.Add(this.btn2, 1, 0);
            this.tblSpots.Controls.Add(this.btn3, 2, 0);
            this.tblSpots.Controls.Add(this.btn4, 0, 1);
            this.tblSpots.Controls.Add(this.btn5, 1, 1);
            this.tblSpots.Controls.Add(this.btn6, 2, 1);
            this.tblSpots.Controls.Add(this.btn7, 0, 2);
            this.tblSpots.Controls.Add(this.btn8, 1, 2);
            this.tblSpots.Controls.Add(this.btn9, 2, 2);
            this.tblSpots.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblSpots.Location = new System.Drawing.Point(3, 83);
            this.tblSpots.Name = "tblSpots";
            this.tblSpots.RowCount = 3;
            this.tblSpots.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblSpots.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblSpots.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblSpots.Size = new System.Drawing.Size(686, 324);
            this.tblSpots.TabIndex = 1;
            // 
            // btn1
            // 
            this.btn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn1.Location = new System.Drawing.Point(3, 3);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(222, 102);
            this.btn1.TabIndex = 0;
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn2.Location = new System.Drawing.Point(231, 3);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(222, 102);
            this.btn2.TabIndex = 1;
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn3.Location = new System.Drawing.Point(459, 3);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(224, 102);
            this.btn3.TabIndex = 2;
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn4.Location = new System.Drawing.Point(3, 111);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(222, 102);
            this.btn4.TabIndex = 3;
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            this.btn5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn5.Location = new System.Drawing.Point(231, 111);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(222, 102);
            this.btn5.TabIndex = 4;
            this.btn5.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            this.btn6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn6.Location = new System.Drawing.Point(459, 111);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(224, 102);
            this.btn6.TabIndex = 5;
            this.btn6.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            this.btn7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn7.Location = new System.Drawing.Point(3, 219);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(222, 102);
            this.btn7.TabIndex = 6;
            this.btn7.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            this.btn8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn8.Location = new System.Drawing.Point(231, 219);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(222, 102);
            this.btn8.TabIndex = 7;
            this.btn8.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            this.btn9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn9.Location = new System.Drawing.Point(459, 219);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(224, 102);
            this.btn9.TabIndex = 8;
            this.btn9.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Location = new System.Drawing.Point(3, 410);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(686, 41);
            this.lblName.TabIndex = 2;
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TicTacToeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblMain);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TicTacToeControl";
            this.Size = new System.Drawing.Size(692, 451);
            this.tblMain.ResumeLayout(false);
            this.tblToolbar.ResumeLayout(false);
            this.tblToolbar.PerformLayout();
            this.tblSpots.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected TableLayoutPanel tblMain;
        protected TableLayoutPanel tblToolbar;
        protected Button btnStart;
        protected RadioButton optTwoPlayer;
        protected RadioButton optPlayComputer;
        protected Label lblStatus;
        protected TableLayoutPanel tblSpots;
        protected Button btn1;
        protected Button btn2;
        protected Button btn3;
        protected Button btn4;
        protected Button btn5;
        protected Button btn6;
        protected Button btn7;
        protected Button btn8;
        protected Button btn9;
        protected Label lblName;
    }
}
