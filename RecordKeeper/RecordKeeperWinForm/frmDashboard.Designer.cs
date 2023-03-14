namespace RecordKeeperWinForm
{
    partial class frmDashboard
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnPresident = new System.Windows.Forms.Button();
            this.btnOlympics = new System.Windows.Forms.Button();
            this.tblMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 1;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.Controls.Add(this.lblWelcome, 0, 0);
            this.tblMain.Controls.Add(this.lblDescription, 0, 1);
            this.tblMain.Controls.Add(this.btnPresident, 0, 2);
            this.tblMain.Controls.Add(this.btnOlympics, 0, 3);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 5;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.Size = new System.Drawing.Size(1029, 630);
            this.tblMain.TabIndex = 0;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.Location = new System.Drawing.Point(4, 10);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 10, 4, 50);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(304, 32);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to Record Keeper";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescription.Location = new System.Drawing.Point(4, 92);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 50);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(173, 30);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "This application...";
            // 
            // btnPresident
            // 
            this.btnPresident.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPresident.Location = new System.Drawing.Point(4, 176);
            this.btnPresident.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPresident.Name = "btnPresident";
            this.btnPresident.Size = new System.Drawing.Size(1021, 32);
            this.btnPresident.TabIndex = 2;
            this.btnPresident.UseVisualStyleBackColor = true;
            // 
            // btnOlympics
            // 
            this.btnOlympics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOlympics.Location = new System.Drawing.Point(4, 216);
            this.btnOlympics.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOlympics.Name = "btnOlympics";
            this.btnOlympics.Size = new System.Drawing.Size(1021, 32);
            this.btnOlympics.TabIndex = 3;
            this.btnOlympics.UseVisualStyleBackColor = true;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 630);
            this.Controls.Add(this.tblMain);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDashboard";
            this.Text = "Dashboard";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblWelcome;
        private Label lblDescription;
        private Button btnPresident;
        private Button btnOlympics;
    }
}