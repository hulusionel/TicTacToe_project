namespace TicTacToe
{
    partial class Board
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nerworkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.a1 = new System.Windows.Forms.Button();
            this.a2 = new System.Windows.Forms.Button();
            this.a3 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.c1 = new System.Windows.Forms.Button();
            this.c2 = new System.Windows.Forms.Button();
            this.c3 = new System.Windows.Forms.Button();
            this.prBar1 = new System.Windows.Forms.ProgressBar();
            this.lblxwin = new System.Windows.Forms.Label();
            this.lbldraw = new System.Windows.Forms.Label();
            this.lblowin = new System.Windows.Forms.Label();
            this.oCount = new System.Windows.Forms.Label();
            this.xCount = new System.Windows.Forms.Label();
            this.drawCount = new System.Windows.Forms.Label();
            this.lblXTimer = new System.Windows.Forms.Label();
            this.lblOTimer = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pnlButton = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.pnlButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(272, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerToolStripMenuItem,
            this.playerToolStripMenuItem1,
            this.nerworkToolStripMenuItem});
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(82, 23);
            this.newGameToolStripMenuItem.Text = "New Game";
            // 
            // playerToolStripMenuItem
            // 
            this.playerToolStripMenuItem.Name = "playerToolStripMenuItem";
            this.playerToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.playerToolStripMenuItem.Text = "1 Player";
            this.playerToolStripMenuItem.Click += new System.EventHandler(this.playerToolStripMenuItem_Click);
            // 
            // playerToolStripMenuItem1
            // 
            this.playerToolStripMenuItem1.Name = "playerToolStripMenuItem1";
            this.playerToolStripMenuItem1.Size = new System.Drawing.Size(126, 24);
            this.playerToolStripMenuItem1.Text = "2 Player";
            this.playerToolStripMenuItem1.Click += new System.EventHandler(this.playerToolStripMenuItem1_Click);
            // 
            // nerworkToolStripMenuItem
            // 
            this.nerworkToolStripMenuItem.Name = "nerworkToolStripMenuItem";
            this.nerworkToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.nerworkToolStripMenuItem.Text = "Network";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(63, 23);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // a1
            // 
            this.a1.Font = new System.Drawing.Font("Mistral", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a1.Location = new System.Drawing.Point(5, 3);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(75, 75);
            this.a1.TabIndex = 1;
            this.a1.UseVisualStyleBackColor = true;
            this.a1.Click += new System.EventHandler(this.button_click);
            // 
            // a2
            // 
            this.a2.Font = new System.Drawing.Font("Mistral", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a2.Location = new System.Drawing.Point(82, 3);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(75, 75);
            this.a2.TabIndex = 2;
            this.a2.UseVisualStyleBackColor = true;
            this.a2.Click += new System.EventHandler(this.button_click);
            // 
            // a3
            // 
            this.a3.Font = new System.Drawing.Font("Mistral", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a3.Location = new System.Drawing.Point(159, 3);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(75, 75);
            this.a3.TabIndex = 3;
            this.a3.UseVisualStyleBackColor = true;
            this.a3.Click += new System.EventHandler(this.button_click);
            // 
            // b1
            // 
            this.b1.Font = new System.Drawing.Font("Mistral", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Location = new System.Drawing.Point(5, 79);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(75, 75);
            this.b1.TabIndex = 4;
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.button_click);
            // 
            // b2
            // 
            this.b2.Font = new System.Drawing.Font("Mistral", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.Location = new System.Drawing.Point(82, 79);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(75, 75);
            this.b2.TabIndex = 5;
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.button_click);
            // 
            // b3
            // 
            this.b3.Font = new System.Drawing.Font("Mistral", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3.Location = new System.Drawing.Point(159, 79);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(75, 75);
            this.b3.TabIndex = 6;
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.button_click);
            // 
            // c1
            // 
            this.c1.Font = new System.Drawing.Font("Mistral", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1.Location = new System.Drawing.Point(5, 156);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(75, 75);
            this.c1.TabIndex = 7;
            this.c1.UseVisualStyleBackColor = true;
            this.c1.Click += new System.EventHandler(this.button_click);
            // 
            // c2
            // 
            this.c2.Font = new System.Drawing.Font("Mistral", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c2.Location = new System.Drawing.Point(82, 156);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(75, 75);
            this.c2.TabIndex = 8;
            this.c2.UseVisualStyleBackColor = true;
            this.c2.Click += new System.EventHandler(this.button_click);
            // 
            // c3
            // 
            this.c3.Font = new System.Drawing.Font("Mistral", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c3.Location = new System.Drawing.Point(159, 156);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(75, 75);
            this.c3.TabIndex = 9;
            this.c3.UseVisualStyleBackColor = true;
            this.c3.Click += new System.EventHandler(this.button_click);
            // 
            // prBar1
            // 
            this.prBar1.Location = new System.Drawing.Point(47, 33);
            this.prBar1.Name = "prBar1";
            this.prBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.prBar1.Size = new System.Drawing.Size(179, 14);
            this.prBar1.TabIndex = 10;
            this.prBar1.Value = 50;
            // 
            // lblxwin
            // 
            this.lblxwin.AutoSize = true;
            this.lblxwin.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblxwin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblxwin.Location = new System.Drawing.Point(18, 299);
            this.lblxwin.Name = "lblxwin";
            this.lblxwin.Size = new System.Drawing.Size(71, 28);
            this.lblxwin.TabIndex = 12;
            this.lblxwin.Text = "X win :";
            // 
            // lbldraw
            // 
            this.lbldraw.AutoSize = true;
            this.lbldraw.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldraw.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbldraw.Location = new System.Drawing.Point(102, 299);
            this.lbldraw.Name = "lbldraw";
            this.lbldraw.Size = new System.Drawing.Size(67, 28);
            this.lbldraw.TabIndex = 13;
            this.lbldraw.Text = "Draw :";
            // 
            // lblowin
            // 
            this.lblowin.AutoSize = true;
            this.lblowin.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblowin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblowin.Location = new System.Drawing.Point(179, 299);
            this.lblowin.Name = "lblowin";
            this.lblowin.Size = new System.Drawing.Size(72, 28);
            this.lblowin.TabIndex = 14;
            this.lblowin.Text = "O win :";
            // 
            // oCount
            // 
            this.oCount.AutoSize = true;
            this.oCount.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oCount.Location = new System.Drawing.Point(204, 321);
            this.oCount.Name = "oCount";
            this.oCount.Size = new System.Drawing.Size(24, 28);
            this.oCount.TabIndex = 15;
            this.oCount.Text = "0";
            // 
            // xCount
            // 
            this.xCount.AutoSize = true;
            this.xCount.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xCount.Location = new System.Drawing.Point(36, 321);
            this.xCount.Name = "xCount";
            this.xCount.Size = new System.Drawing.Size(24, 28);
            this.xCount.TabIndex = 16;
            this.xCount.Text = "0";
            // 
            // drawCount
            // 
            this.drawCount.AutoSize = true;
            this.drawCount.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawCount.Location = new System.Drawing.Point(119, 321);
            this.drawCount.Name = "drawCount";
            this.drawCount.Size = new System.Drawing.Size(24, 28);
            this.drawCount.TabIndex = 17;
            this.drawCount.Text = "0";
            // 
            // lblXTimer
            // 
            this.lblXTimer.AutoSize = true;
            this.lblXTimer.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXTimer.Location = new System.Drawing.Point(26, 27);
            this.lblXTimer.Name = "lblXTimer";
            this.lblXTimer.Size = new System.Drawing.Size(24, 28);
            this.lblXTimer.TabIndex = 18;
            this.lblXTimer.Text = "X";
            // 
            // lblOTimer
            // 
            this.lblOTimer.AutoSize = true;
            this.lblOTimer.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOTimer.Location = new System.Drawing.Point(235, 27);
            this.lblOTimer.Name = "lblOTimer";
            this.lblOTimer.Size = new System.Drawing.Size(25, 28);
            this.lblOTimer.TabIndex = 19;
            this.lblOTimer.Text = "O";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.b2);
            this.pnlButton.Controls.Add(this.b3);
            this.pnlButton.Controls.Add(this.c1);
            this.pnlButton.Controls.Add(this.a1);
            this.pnlButton.Controls.Add(this.b1);
            this.pnlButton.Controls.Add(this.c2);
            this.pnlButton.Controls.Add(this.a2);
            this.pnlButton.Controls.Add(this.a3);
            this.pnlButton.Controls.Add(this.c3);
            this.pnlButton.Location = new System.Drawing.Point(12, 61);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(244, 235);
            this.pnlButton.TabIndex = 20;
            // 
            // Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(272, 358);
            this.Controls.Add(this.pnlButton);
            this.Controls.Add(this.lblOTimer);
            this.Controls.Add(this.lblXTimer);
            this.Controls.Add(this.drawCount);
            this.Controls.Add(this.xCount);
            this.Controls.Add(this.oCount);
            this.Controls.Add(this.lblowin);
            this.Controls.Add(this.lbldraw);
            this.Controls.Add(this.lblxwin);
            this.Controls.Add(this.prBar1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Board";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Board_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlButton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.Button a1;
        private System.Windows.Forms.Button a2;
        private System.Windows.Forms.Button a3;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button c1;
        private System.Windows.Forms.Button c2;
        private System.Windows.Forms.Button c3;
        private System.Windows.Forms.ToolStripMenuItem playerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nerworkToolStripMenuItem;
        private System.Windows.Forms.ProgressBar prBar1;
        private System.Windows.Forms.Label lblxwin;
        private System.Windows.Forms.Label lbldraw;
        private System.Windows.Forms.Label lblowin;
        private System.Windows.Forms.Label oCount;
        private System.Windows.Forms.Label xCount;
        private System.Windows.Forms.Label drawCount;
        private System.Windows.Forms.Label lblXTimer;
        private System.Windows.Forms.Label lblOTimer;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel pnlButton;
    }
}

