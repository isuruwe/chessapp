namespace Chess
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            new2PlayerGameToolStripMenuItem = new ToolStripMenuItem();
            endCurrentGameToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            prgThinking = new ToolStripProgressBar();
            lblStatus = new ToolStripStatusLabel();
            splitView = new SplitContainer();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            lblBlackCheck = new Label();
            lblWhiteCheck = new Label();
            picTurn = new PictureBox();
            label3 = new Label();
            txtLog = new TextBox();
            lblWhiteTime = new Label();
            lblBlackTime = new Label();
            label1 = new Label();
            label2 = new Label();
            tmrWhite = new System.Windows.Forms.Timer(components);
            tmrBlack = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitView).BeginInit();
            splitView.Panel2.SuspendLayout();
            splitView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picTurn).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(1370, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { new2PlayerGameToolStripMenuItem, endCurrentGameToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(50, 20);
            fileToolStripMenuItem.Text = "Game";
            // 
            // new2PlayerGameToolStripMenuItem
            // 
            new2PlayerGameToolStripMenuItem.Name = "new2PlayerGameToolStripMenuItem";
            new2PlayerGameToolStripMenuItem.Size = new Size(216, 22);
            new2PlayerGameToolStripMenuItem.Text = "New Player vs Player Game";
            new2PlayerGameToolStripMenuItem.Click += NewGame;
            // 
            // endCurrentGameToolStripMenuItem
            // 
            endCurrentGameToolStripMenuItem.Name = "endCurrentGameToolStripMenuItem";
            endCurrentGameToolStripMenuItem.Size = new Size(216, 22);
            endCurrentGameToolStripMenuItem.Text = "End current game";
            endCurrentGameToolStripMenuItem.Click += endGame;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(216, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += Shutdown;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { prgThinking, lblStatus });
            statusStrip1.Location = new Point(0, 725);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(1370, 24);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // prgThinking
            // 
            prgThinking.Name = "prgThinking";
            prgThinking.Size = new Size(117, 18);
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(62, 19);
            lblStatus.Text = "Thinking...";
            // 
            // splitView
            // 
            splitView.Dock = DockStyle.Fill;
            splitView.FixedPanel = FixedPanel.Panel2;
            splitView.IsSplitterFixed = true;
            splitView.Location = new Point(0, 24);
            splitView.Margin = new Padding(4, 3, 4, 3);
            splitView.Name = "splitView";
            // 
            // splitView.Panel1
            // 
            splitView.Panel1.BackColor = Color.Gray;
            splitView.Panel1.Resize += ResizeBoard;
            splitView.Panel1MinSize = 400;
            // 
            // splitView.Panel2
            // 
            splitView.Panel2.BackColor = SystemColors.Control;
            splitView.Panel2.Controls.Add(listView1);
            splitView.Panel2.Controls.Add(lblBlackCheck);
            splitView.Panel2.Controls.Add(lblWhiteCheck);
            splitView.Panel2.Controls.Add(picTurn);
            splitView.Panel2.Controls.Add(label3);
            splitView.Panel2.Controls.Add(txtLog);
            splitView.Panel2.Controls.Add(lblWhiteTime);
            splitView.Panel2.Controls.Add(lblBlackTime);
            splitView.Panel2.Controls.Add(label1);
            splitView.Panel2.Controls.Add(label2);
            splitView.Panel2MinSize = 200;
            splitView.Size = new Size(1370, 701);
            splitView.SplitterDistance = 1110;
            splitView.SplitterWidth = 5;
            splitView.TabIndex = 2;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            listView1.Location = new Point(19, 85);
            listView1.Margin = new Padding(4, 3, 4, 3);
            listView1.Name = "listView1";
            listView1.Size = new Size(218, 602);
            listView1.TabIndex = 7;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Moves";
            columnHeader1.Width = 300;
            // 
            // lblBlackCheck
            // 
            lblBlackCheck.AutoSize = true;
            lblBlackCheck.Location = new Point(178, 57);
            lblBlackCheck.Margin = new Padding(4, 0, 4, 0);
            lblBlackCheck.Name = "lblBlackCheck";
            lblBlackCheck.Size = new Size(53, 15);
            lblBlackCheck.TabIndex = 6;
            lblBlackCheck.Text = "In Check";
            lblBlackCheck.Visible = false;
            // 
            // lblWhiteCheck
            // 
            lblWhiteCheck.AutoSize = true;
            lblWhiteCheck.Location = new Point(15, 57);
            lblWhiteCheck.Margin = new Padding(4, 0, 4, 0);
            lblWhiteCheck.Name = "lblWhiteCheck";
            lblWhiteCheck.Size = new Size(53, 15);
            lblWhiteCheck.TabIndex = 6;
            lblWhiteCheck.Text = "In Check";
            lblWhiteCheck.Visible = false;
            // 
            // picTurn
            // 
            picTurn.Location = new Point(104, 14);
            picTurn.Margin = new Padding(4, 3, 4, 3);
            picTurn.Name = "picTurn";
            picTurn.Size = new Size(46, 23);
            picTurn.TabIndex = 5;
            picTurn.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 85);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 4;
            label3.Text = "Moves:";
            label3.Visible = false;
            // 
            // txtLog
            // 
            txtLog.Location = new Point(19, 104);
            txtLog.Margin = new Padding(4, 3, 4, 3);
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.ScrollBars = ScrollBars.Vertical;
            txtLog.Size = new Size(218, 33);
            txtLog.TabIndex = 3;
            // 
            // lblWhiteTime
            // 
            lblWhiteTime.AutoSize = true;
            lblWhiteTime.Location = new Point(15, 37);
            lblWhiteTime.Margin = new Padding(4, 0, 4, 0);
            lblWhiteTime.Name = "lblWhiteTime";
            lblWhiteTime.Size = new Size(58, 15);
            lblWhiteTime.TabIndex = 2;
            lblWhiteTime.Text = "00:00:00.0";
            // 
            // lblBlackTime
            // 
            lblBlackTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblBlackTime.AutoSize = true;
            lblBlackTime.Location = new Point(169, 37);
            lblBlackTime.Margin = new Padding(4, 0, 4, 0);
            lblBlackTime.Name = "lblBlackTime";
            lblBlackTime.Size = new Size(58, 15);
            lblBlackTime.TabIndex = 2;
            lblBlackTime.Text = "00:00:00.0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 14);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "White";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(182, 14);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 1;
            label2.Text = "Black";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // tmrWhite
            // 
            tmrWhite.Tick += tmrWhite_Tick;
            // 
            // tmrBlack
            // 
            tmrBlack.Tick += tmrBlack_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(splitView);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(756, 571);
            Name = "MainForm";
            Text = "Chess";
            FormClosing += windowClosing;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            splitView.Panel2.ResumeLayout(false);
            splitView.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitView).EndInit();
            splitView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picTurn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar prgThinking;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.SplitContainer splitView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label lblWhiteTime;
        private System.Windows.Forms.Label lblBlackTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picTurn;
        private System.Windows.Forms.ToolStripMenuItem new2PlayerGameToolStripMenuItem;
        private System.Windows.Forms.Label lblBlackCheck;
        private System.Windows.Forms.Label lblWhiteCheck;
        private System.Windows.Forms.ToolStripMenuItem endCurrentGameToolStripMenuItem;
        private System.Windows.Forms.Timer tmrWhite;
        private System.Windows.Forms.Timer tmrBlack;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

