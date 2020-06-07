using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
namespace MineSweeper
{
    public partial class Game : Form
    {
        Field ps;
        bool gameStatus = true;
        bool gameWon = false;
        Button[,] buttonMatrix;
        System.Timers.Timer aTimer;
        int timer;
        int difficulty = 1;
        Button back;
        Label minesLeft;
        Label minesLeftBox;
        Label time;
        Label timeBox;
        Point coordinates;
        int tileSize = 40;
        int rows;
        int cols;
        int mines;
        int infoBar = 200;
        public Game(int level)
        {
            difficulty = level;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            makeButtonMatrix();
            loadInfo();
        }

        private void makeButtonMatrix()
        {
            ps = new Field(difficulty);
            rows = ps.rows;
            cols = ps.cols;
            mines = ps.bombs;
            buttonMatrix = new Button[rows, cols];
            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < cols; y++)
                {
                    buttonMatrix[x, y] = new Button();
                    buttonMatrix[x, y].SetBounds(x * tileSize, y * tileSize, tileSize, tileSize);
                    buttonMatrix[x, y].MouseUp += new MouseEventHandler(mouseClick);
                    this.Controls.Add(buttonMatrix[x, y]);
                    buttonMatrix[x, y].BackgroundImage = MineSweeper.Resource1.unknown;
                }
            }
            this.Height = cols * (tileSize) + 40;
            this.Width = rows * (tileSize) + infoBar + 10;
        }

        private void backClick(object sender, EventArgs e)
        {
            this.Hide();
            Menu form1 = new Menu();
            form1.Show();

        }

        private void checkSurrounding(int x, int y)
        {
            Button c;
            if (ps.mineField[x, y].number == 0)
                for (int k = x - 1; k <= x + 1; k++)
                    if ((k >= 0) && (k < ps.rows))
                        for (int l = y - 1; l <= y + 1; l++)
                        {
                            if ((l >= 0) && (l < ps.cols) && !(l == x && k == y))
                            {
                                c = buttonMatrix[k, l];
                                makeImage(k, l);
                                c.Enabled = false;
                                if (ps.mineField[k, l].number == 0 && ps.mineField[k, l].open == false)
                                {
                                    ps.mineField[k, l].open = true;
                                    checkSurrounding(k, l);
                                }
                                ps.mineField[k, l].open = true;
                            }
                        }
        }
        private void checkGameStatus()
        {
            if (gameStatus == false)
            {
                string message = "You lost";
                string caption = "Message";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                aTimer.Stop();
                showBombs();
            }
            else
            {
                gameWon = ps.gameWon();
                if (gameWon == true)
                {
                    aTimer.Stop();
                }                
            }
        }

        private void showBombs()
        {
            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < cols; y++)
                {
                    buttonMatrix[x, y].Enabled = false;
                    if (ps.mineField[x, y].mine == true)
                        makeImage(x, y);
                }
            }
        }

        private void makeImage(int x, int y)
        {
            Button b = buttonMatrix[x, y];
            b.BackgroundImageLayout = ImageLayout.Stretch;
            switch (ps.mineField[x, y].number)
            {
                case 0:
                    b.BackgroundImage = MineSweeper.Resource1.blank;
                    break;

                case 1:
                    b.BackgroundImage = MineSweeper.Resource1._1;
                    break;

                case 2:
                    b.BackgroundImage = MineSweeper.Resource1._2;
                    break;

                case 3:
                    b.BackgroundImage = MineSweeper.Resource1._3;
                    break;

                case 4:
                    b.BackgroundImage = MineSweeper.Resource1._4;
                    break;

                case 5:
                    b.BackgroundImage = MineSweeper.Resource1._5;
                    break;

                case 6:
                    b.BackgroundImage = MineSweeper.Resource1._6;
                    break;

                case 7:
                    b.BackgroundImage = MineSweeper.Resource1._7;
                    break;

                case 8:
                    b.BackgroundImage = MineSweeper.Resource1._8;
                    break;

                case -1:
                    b.BackgroundImage = MineSweeper.Resource1.mine;
                    break;

            }
            b.Enabled = false;
        }
        private void mouseClick(object sender, MouseEventArgs e)
        {
            Button b = sender as Button;
            coordinates = b.Location;
            int x = (coordinates.X) / tileSize;
            int y = (coordinates.Y) / tileSize;
            if (e.Button == MouseButtons.Right)
            {
                b = buttonMatrix[x, y];
                if (ps.mineField[x, y].flag == true)
                {
                    ps.mineField[x, y].flag = false;
                    b.BackgroundImageLayout = ImageLayout.Stretch;
                    b.BackgroundImage = MineSweeper.Resource1.unknown;
                    mines++;
                    minesLeftBox.Text = mines.ToString();
                }
                else
                {
                    ps.mineField[x, y].flag = true;
                    b.BackgroundImageLayout = ImageLayout.Stretch;
                    b.BackgroundImage = MineSweeper.Resource1.flag;
                    mines--;
                    minesLeftBox.Text = mines.ToString();
                }
            }
            else
            {

                ps.mineField[x, y].open = true;
                ps.mineField[x, y].flag = false;
                if (ps.mineField[x, y].mine == false)
                {
                    makeImage(x, y);
                    if (ps.mineField[x, y].number == 0)
                    {
                        checkSurrounding(x, y);
                    }
                    ps.mineField[x, y].open = true;
                }
                else
                {
                    makeImage(x, y);
                    gameStatus = false;
                }
            }
            checkGameStatus();
        }
        private void loadInfo()
        {
            aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(tick);
            aTimer.Interval = 1000;
            aTimer.Enabled = true;
            minesLeft = new Label();
            minesLeft.Location = new Point(rows * (tileSize) + 5, 10);
            minesLeft.Size = new System.Drawing.Size(100, 50);
            minesLeft.Image = MineSweeper.Resource1.minesleft;
            this.Controls.Add(minesLeft);
            minesLeftBox = new Label();
            minesLeftBox.Location = new Point(rows * (tileSize) + 100, 0);
            minesLeftBox.Size = new System.Drawing.Size(50, 50);
            minesLeftBox.Text = mines.ToString();
            minesLeftBox.AutoSize = true;
            minesLeftBox.Font = new Font("Calibri", 40);
            minesLeftBox.ForeColor = Color.Green;
            this.Controls.Add(minesLeftBox);
            time = new Label();
            time.Location = new Point(rows * (tileSize) + 5, 80);
            time.Size = new System.Drawing.Size(100, 50);
            time.Image = MineSweeper.Resource1.time;
            this.Controls.Add(time);
            timeBox = new Label();
            timeBox.Location = new Point(rows * (tileSize) + 100, 70);
            timeBox.Size = new System.Drawing.Size(50, 50);
            timeBox.Text = timer.ToString();
            timeBox.AutoSize = true;
            timeBox.Font = new Font("Calibri", 40);
            timeBox.ForeColor = Color.Green;
            this.Controls.Add(timeBox);
            back = new Button();
            back.SetBounds(rows * (tileSize), cols * (tileSize) - 50, 200, 50);
            back.Text = "BACK";
            back.MouseClick += new MouseEventHandler(backClick);
            this.Controls.Add(back);
        }
        void tick(object sender, EventArgs e)
        {
            timer++;
            timeBox.Text = timer.ToString();
        }
    }
}
