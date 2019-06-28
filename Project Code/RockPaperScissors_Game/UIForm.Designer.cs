namespace RockPaperScissors
{
    partial class UIForm
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
            this.groupBoxPlayerChoice = new System.Windows.Forms.GroupBox();
            this.buttonScissors = new System.Windows.Forms.Button();
            this.buttonPaper = new System.Windows.Forms.Button();
            this.buttonRock = new System.Windows.Forms.Button();
            this.labelPlayerChoice = new System.Windows.Forms.Label();
            this.labelAIChoice = new System.Windows.Forms.Label();
            this.textBoxPlayerChoice = new System.Windows.Forms.TextBox();
            this.textBoxAIChoice = new System.Windows.Forms.TextBox();
            this.groupBoxGameResult = new System.Windows.Forms.GroupBox();
            this.groupBoxScores = new System.Windows.Forms.GroupBox();
            this.textBoxGameResult = new System.Windows.Forms.TextBox();
            this.labelGameResult = new System.Windows.Forms.Label();
            this.labelPlayerScore = new System.Windows.Forms.Label();
            this.textBoxAIScore = new System.Windows.Forms.TextBox();
            this.labelAIScore = new System.Windows.Forms.Label();
            this.textBoxPlayerScore = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxPlayerChoice.SuspendLayout();
            this.groupBoxGameResult.SuspendLayout();
            this.groupBoxScores.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPlayerChoice
            // 
            this.groupBoxPlayerChoice.Controls.Add(this.buttonScissors);
            this.groupBoxPlayerChoice.Controls.Add(this.buttonPaper);
            this.groupBoxPlayerChoice.Controls.Add(this.buttonRock);
            this.groupBoxPlayerChoice.Location = new System.Drawing.Point(61, 32);
            this.groupBoxPlayerChoice.Name = "groupBoxPlayerChoice";
            this.groupBoxPlayerChoice.Size = new System.Drawing.Size(644, 126);
            this.groupBoxPlayerChoice.TabIndex = 0;
            this.groupBoxPlayerChoice.TabStop = false;
            this.groupBoxPlayerChoice.Text = "PLAYER CHOICE";
            // 
            // buttonScissors
            // 
            this.buttonScissors.Location = new System.Drawing.Point(440, 46);
            this.buttonScissors.Name = "buttonScissors";
            this.buttonScissors.Size = new System.Drawing.Size(115, 41);
            this.buttonScissors.TabIndex = 2;
            this.buttonScissors.Text = "SCISSORS";
            this.buttonScissors.UseVisualStyleBackColor = true;
            this.buttonScissors.Click += new System.EventHandler(this.buttonPlayerSelection_Click);
            // 
            // buttonPaper
            // 
            this.buttonPaper.Location = new System.Drawing.Point(250, 46);
            this.buttonPaper.Name = "buttonPaper";
            this.buttonPaper.Size = new System.Drawing.Size(115, 41);
            this.buttonPaper.TabIndex = 1;
            this.buttonPaper.Text = "PAPER";
            this.buttonPaper.UseVisualStyleBackColor = true;
            this.buttonPaper.Click += new System.EventHandler(this.buttonPlayerSelection_Click);
            // 
            // buttonRock
            // 
            this.buttonRock.Location = new System.Drawing.Point(69, 46);
            this.buttonRock.Name = "buttonRock";
            this.buttonRock.Size = new System.Drawing.Size(115, 41);
            this.buttonRock.TabIndex = 0;
            this.buttonRock.Text = "ROCK";
            this.buttonRock.UseVisualStyleBackColor = true;
            this.buttonRock.Click += new System.EventHandler(this.buttonPlayerSelection_Click);
            // 
            // labelPlayerChoice
            // 
            this.labelPlayerChoice.AutoSize = true;
            this.labelPlayerChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayerChoice.Location = new System.Drawing.Point(121, 26);
            this.labelPlayerChoice.Name = "labelPlayerChoice";
            this.labelPlayerChoice.Size = new System.Drawing.Size(146, 25);
            this.labelPlayerChoice.TabIndex = 1;
            this.labelPlayerChoice.Text = "Player Choice";
            // 
            // labelAIChoice
            // 
            this.labelAIChoice.AutoSize = true;
            this.labelAIChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAIChoice.Location = new System.Drawing.Point(340, 26);
            this.labelAIChoice.Name = "labelAIChoice";
            this.labelAIChoice.Size = new System.Drawing.Size(104, 25);
            this.labelAIChoice.TabIndex = 2;
            this.labelAIChoice.Text = "AI Choice";
            // 
            // textBoxPlayerChoice
            // 
            this.textBoxPlayerChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPlayerChoice.Location = new System.Drawing.Point(124, 63);
            this.textBoxPlayerChoice.Name = "textBoxPlayerChoice";
            this.textBoxPlayerChoice.ReadOnly = true;
            this.textBoxPlayerChoice.Size = new System.Drawing.Size(141, 31);
            this.textBoxPlayerChoice.TabIndex = 3;
            this.textBoxPlayerChoice.TabStop = false;
            this.textBoxPlayerChoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxAIChoice
            // 
            this.textBoxAIChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAIChoice.Location = new System.Drawing.Point(322, 63);
            this.textBoxAIChoice.Name = "textBoxAIChoice";
            this.textBoxAIChoice.ReadOnly = true;
            this.textBoxAIChoice.Size = new System.Drawing.Size(141, 31);
            this.textBoxAIChoice.TabIndex = 4;
            this.textBoxAIChoice.TabStop = false;
            this.textBoxAIChoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBoxGameResult
            // 
            this.groupBoxGameResult.Controls.Add(this.labelPlayerChoice);
            this.groupBoxGameResult.Controls.Add(this.textBoxAIChoice);
            this.groupBoxGameResult.Controls.Add(this.labelAIChoice);
            this.groupBoxGameResult.Controls.Add(this.textBoxPlayerChoice);
            this.groupBoxGameResult.Location = new System.Drawing.Point(61, 176);
            this.groupBoxGameResult.Name = "groupBoxGameResult";
            this.groupBoxGameResult.Size = new System.Drawing.Size(644, 122);
            this.groupBoxGameResult.TabIndex = 5;
            this.groupBoxGameResult.TabStop = false;
            this.groupBoxGameResult.Text = "GAME RESULT";
            // 
            // groupBoxScores
            // 
            this.groupBoxScores.Controls.Add(this.textBoxGameResult);
            this.groupBoxScores.Controls.Add(this.labelGameResult);
            this.groupBoxScores.Controls.Add(this.labelPlayerScore);
            this.groupBoxScores.Controls.Add(this.textBoxAIScore);
            this.groupBoxScores.Controls.Add(this.labelAIScore);
            this.groupBoxScores.Controls.Add(this.textBoxPlayerScore);
            this.groupBoxScores.Location = new System.Drawing.Point(61, 316);
            this.groupBoxScores.Name = "groupBoxScores";
            this.groupBoxScores.Size = new System.Drawing.Size(644, 122);
            this.groupBoxScores.TabIndex = 6;
            this.groupBoxScores.TabStop = false;
            this.groupBoxScores.Text = "GAME RESULT";
            // 
            // textBoxGameResult
            // 
            this.textBoxGameResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGameResult.Location = new System.Drawing.Point(411, 64);
            this.textBoxGameResult.Name = "textBoxGameResult";
            this.textBoxGameResult.ReadOnly = true;
            this.textBoxGameResult.Size = new System.Drawing.Size(141, 31);
            this.textBoxGameResult.TabIndex = 6;
            this.textBoxGameResult.TabStop = false;
            this.textBoxGameResult.Text = "0";
            this.textBoxGameResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelGameResult
            // 
            this.labelGameResult.AutoSize = true;
            this.labelGameResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameResult.Location = new System.Drawing.Point(435, 27);
            this.labelGameResult.Name = "labelGameResult";
            this.labelGameResult.Size = new System.Drawing.Size(101, 25);
            this.labelGameResult.TabIndex = 5;
            this.labelGameResult.Text = "RESULT:";
            // 
            // labelPlayerScore
            // 
            this.labelPlayerScore.AutoSize = true;
            this.labelPlayerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayerScore.Location = new System.Drawing.Point(26, 27);
            this.labelPlayerScore.Name = "labelPlayerScore";
            this.labelPlayerScore.Size = new System.Drawing.Size(135, 25);
            this.labelPlayerScore.TabIndex = 1;
            this.labelPlayerScore.Text = "Player Score";
            // 
            // textBoxAIScore
            // 
            this.textBoxAIScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAIScore.Location = new System.Drawing.Point(221, 64);
            this.textBoxAIScore.Name = "textBoxAIScore";
            this.textBoxAIScore.ReadOnly = true;
            this.textBoxAIScore.Size = new System.Drawing.Size(141, 31);
            this.textBoxAIScore.TabIndex = 4;
            this.textBoxAIScore.TabStop = false;
            this.textBoxAIScore.Text = "0";
            this.textBoxAIScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelAIScore
            // 
            this.labelAIScore.AutoSize = true;
            this.labelAIScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAIScore.Location = new System.Drawing.Point(245, 27);
            this.labelAIScore.Name = "labelAIScore";
            this.labelAIScore.Size = new System.Drawing.Size(93, 25);
            this.labelAIScore.TabIndex = 2;
            this.labelAIScore.Text = "AI Score";
            // 
            // textBoxPlayerScore
            // 
            this.textBoxPlayerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPlayerScore.Location = new System.Drawing.Point(23, 64);
            this.textBoxPlayerScore.Name = "textBoxPlayerScore";
            this.textBoxPlayerScore.ReadOnly = true;
            this.textBoxPlayerScore.Size = new System.Drawing.Size(141, 31);
            this.textBoxPlayerScore.TabIndex = 3;
            this.textBoxPlayerScore.TabStop = false;
            this.textBoxPlayerScore.Text = "0";
            this.textBoxPlayerScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "&Game";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newGameToolStripMenuItem.Text = "&New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rulesToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // rulesToolStripMenuItem
            // 
            this.rulesToolStripMenuItem.Name = "rulesToolStripMenuItem";
            this.rulesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rulesToolStripMenuItem.Text = "&Rules";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // UIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.groupBoxScores);
            this.Controls.Add(this.groupBoxGameResult);
            this.Controls.Add(this.groupBoxPlayerChoice);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UIForm";
            this.Text = "Rock, Paper, Scissors - GAME";
            this.groupBoxPlayerChoice.ResumeLayout(false);
            this.groupBoxGameResult.ResumeLayout(false);
            this.groupBoxGameResult.PerformLayout();
            this.groupBoxScores.ResumeLayout(false);
            this.groupBoxScores.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPlayerChoice;
        private System.Windows.Forms.Button buttonScissors;
        private System.Windows.Forms.Button buttonPaper;
        private System.Windows.Forms.Button buttonRock;
        private System.Windows.Forms.Label labelPlayerChoice;
        private System.Windows.Forms.Label labelAIChoice;
        private System.Windows.Forms.TextBox textBoxPlayerChoice;
        private System.Windows.Forms.TextBox textBoxAIChoice;
        private System.Windows.Forms.GroupBox groupBoxGameResult;
        private System.Windows.Forms.GroupBox groupBoxScores;
        private System.Windows.Forms.Label labelPlayerScore;
        private System.Windows.Forms.TextBox textBoxAIScore;
        private System.Windows.Forms.Label labelAIScore;
        private System.Windows.Forms.TextBox textBoxPlayerScore;
        private System.Windows.Forms.TextBox textBoxGameResult;
        private System.Windows.Forms.Label labelGameResult;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

