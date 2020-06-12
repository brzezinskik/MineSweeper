namespace MineSweeper
{
    partial class Menu
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
            this.difficulty = new System.Windows.Forms.ComboBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.customButton = new System.Windows.Forms.Button();
            this.difficultyText = new System.Windows.Forms.TextBox();
            this.highScore = new System.Windows.Forms.Button();
            this.nickName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // difficulty
            // 
            this.difficulty.BackColor = System.Drawing.SystemColors.Info;
            this.difficulty.ForeColor = System.Drawing.SystemColors.Highlight;
            this.difficulty.FormattingEnabled = true;
            this.difficulty.Items.AddRange(new object[] {
            "Beginner",
            "Intermiediate",
            "Expert"});
            this.difficulty.Location = new System.Drawing.Point(12, 110);
            this.difficulty.Name = "difficulty";
            this.difficulty.Size = new System.Drawing.Size(158, 21);
            this.difficulty.TabIndex = 0;
            this.difficulty.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(12, 219);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(158, 35);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitClick);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Gainsboro;
            this.startButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.startButton.Location = new System.Drawing.Point(12, 6);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(158, 35);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startClick);
            // 
            // customButton
            // 
            this.customButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton.Location = new System.Drawing.Point(12, 137);
            this.customButton.Name = "customButton";
            this.customButton.Size = new System.Drawing.Size(158, 35);
            this.customButton.TabIndex = 3;
            this.customButton.Text = "Custom Game";
            this.customButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.customButton.UseVisualStyleBackColor = true;
            this.customButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // difficultyText
            // 
            this.difficultyText.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.difficultyText.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difficultyText.Location = new System.Drawing.Point(12, 73);
            this.difficultyText.Name = "difficultyText";
            this.difficultyText.ReadOnly = true;
            this.difficultyText.Size = new System.Drawing.Size(158, 33);
            this.difficultyText.TabIndex = 4;
            this.difficultyText.Text = "Difficulty";
            this.difficultyText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // highScore
            // 
            this.highScore.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScore.Location = new System.Drawing.Point(12, 178);
            this.highScore.Name = "highScore";
            this.highScore.Size = new System.Drawing.Size(158, 35);
            this.highScore.TabIndex = 5;
            this.highScore.Text = "High Score";
            this.highScore.UseVisualStyleBackColor = true;
            this.highScore.Click += new System.EventHandler(this.highScore_Click);
            // 
            // nickName
            // 
            this.nickName.BackColor = System.Drawing.SystemColors.Info;
            this.nickName.Location = new System.Drawing.Point(12, 47);
            this.nickName.Name = "nickName";
            this.nickName.Size = new System.Drawing.Size(158, 20);
            this.nickName.TabIndex = 6;
            this.nickName.Text = "Anonymous";
            this.nickName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Menu
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(186, 259);
            this.Controls.Add(this.nickName);
            this.Controls.Add(this.highScore);
            this.Controls.Add(this.difficultyText);
            this.Controls.Add(this.customButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.difficulty);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox difficulty;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button customButton;
        private System.Windows.Forms.TextBox difficultyText;
        private System.Windows.Forms.Button highScore;
        private System.Windows.Forms.TextBox nickName;
    }
}

