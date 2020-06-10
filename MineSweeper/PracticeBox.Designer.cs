namespace MineSweeper
{
    partial class PracticeBox
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.minesNum = new System.Windows.Forms.NumericUpDown();
            this.columnsNum = new System.Windows.Forms.NumericUpDown();
            this.rowsNum = new System.Windows.Forms.NumericUpDown();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.minesNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnsNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowsNum)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rows";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Columns";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(301, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mines";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(103, 78);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // minesNum
            // 
            this.minesNum.Location = new System.Drawing.Point(261, 27);
            this.minesNum.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.minesNum.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.minesNum.Name = "minesNum";
            this.minesNum.Size = new System.Drawing.Size(120, 20);
            this.minesNum.TabIndex = 7;
            this.minesNum.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // columnsNum
            // 
            this.columnsNum.Location = new System.Drawing.Point(135, 27);
            this.columnsNum.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.columnsNum.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.columnsNum.Name = "columnsNum";
            this.columnsNum.Size = new System.Drawing.Size(120, 20);
            this.columnsNum.TabIndex = 8;
            this.columnsNum.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // rowsNum
            // 
            this.rowsNum.Location = new System.Drawing.Point(9, 27);
            this.rowsNum.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.rowsNum.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.rowsNum.Name = "rowsNum";
            this.rowsNum.Size = new System.Drawing.Size(120, 20);
            this.rowsNum.TabIndex = 9;
            this.rowsNum.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.rowsNum.ValueChanged += new System.EventHandler(this.rowsNum_ValueChanged);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(201, 78);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 10;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // PracticeBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 118);
            this.Controls.Add(this.back);
            this.Controls.Add(this.rowsNum);
            this.Controls.Add(this.columnsNum);
            this.Controls.Add(this.minesNum);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "PracticeBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.minesNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnsNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowsNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.NumericUpDown minesNum;
        private System.Windows.Forms.NumericUpDown columnsNum;
        private System.Windows.Forms.NumericUpDown rowsNum;
        private System.Windows.Forms.Button back;
    }
}