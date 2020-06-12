using System;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;
namespace MineSweeper
{
    public partial class Game : Form
    {
        private Field gameField;
        private readonly Sounds sound = new Sounds();
        private Button[,] buttonMatrix;

        private readonly int tileSize = 40;
        private readonly int infoBar = 200;
        
        private bool gameStatus = true;
        private bool gameWon = false;
        private bool practice = false;
        
        private System.Timers.Timer gameTimer;
        private int timer;
        private int difficulty = 1;

        private Button back;
        private Label minesLeft;
        private Label minesLeftBox;
        private Label time;
        private Label timeBox;
        private Point coordinates;

        private String name;
        private int rows;
        private int cols;
        private int mines;


        public Game(int level, String name)
        {
            this.name = name;
            difficulty = level;
            InitializeComponent();
        }

        public Game(int rows, int columns, int mines)
        {
            this.cols = columns;
            this.mines = mines;
            this.rows = rows;
            practice = true;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            makeButtonMatrix();
            loadInfo();
            this.Text = "Minesweeper";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        private void makeButtonMatrix()
        {
            if (practice)
                gameField = new Field(rows, cols, mines);
            else
            {
                gameField = new Field(difficulty);
                rows = gameField.rows;
                cols = gameField.cols;
                mines = gameField.bombs;
            }
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
            this.Width = rows * (tileSize) + infoBar + 20;
        }

        private void checkSurrounding(int x, int y)
        {
            Button c;
            if (gameField.mineField[x, y].Number == 0)
                for (int i = x - 1; i <= x + 1; i++)
                    if ((i >= 0) && (i < rows))
                        for (int j = y - 1; j <= y + 1; j++)
                        {
                            if ((j >= 0) && (j < cols) && !(j == x && i == y))
                            {
                                c = buttonMatrix[i, j];
                                makeImage(i, j);
                                c.Enabled = false;
                                if (gameField.mineField[i, j].Number == 0 && gameField.mineField[i, j].Open == false)
                                {
                                    gameField.mineField[i, j].Open = true;
                                    checkSurrounding(i, j);
                                }
                                gameField.mineField[i, j].Open = true;
                            }
                        }
        }
        private void checkGameStatus()
        {
            if (gameStatus == false)
            {
                showBombs();
                string message = "You lost";
                string caption = "Message";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
                gameTimer.Stop();                
            }
            else
            {
                gameWon = gameField.gameWon();
                if (gameWon == true)
                {
                    gameTimer.Stop();
                    sound.playGameWonSound();
                    showBombs();
                    string message = "You won";
                    string caption = "Message";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, caption, buttons);
                    addToHighScore();
                }                
            }
        }

        private void addToHighScore()
        {
            if (practice)
                return;
            else
            {
                Score score = new Score(name, timer);
                switch (difficulty)
                {
                    case 1:
                        HighScore.listBeginner.Add(score);
                        break;

                    case 2:

                        break;

                    case 3:

                        break;
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
                    if (gameField.mineField[x, y].Mine == true)
                        makeImage(x, y);
                }
            }
        }

        private void makeImage(int x, int y)
        {
            Button b = buttonMatrix[x, y];
            b.BackgroundImageLayout = ImageLayout.Stretch;
            if (gameField.mineField[x, y].Flag)
                mines++;
            switch (gameField.mineField[x, y].Number)
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
                if (gameField.mineField[x, y].Flag == true)
                {
                    gameField.mineField[x, y].Flag = false;
                    b.BackgroundImageLayout = ImageLayout.Stretch;
                    b.BackgroundImage = MineSweeper.Resource1.unknown;
                    mines++;
                    minesLeftBox.Text = mines.ToString();
                }
                else
                {
                    gameField.mineField[x, y].Flag = true;
                    b.BackgroundImageLayout = ImageLayout.Stretch;
                    b.BackgroundImage = MineSweeper.Resource1.flag;
                    mines--;
                    minesLeftBox.Text = mines.ToString();
                }
            }
            else
            {

                gameField.mineField[x, y].Open = true;
                gameField.mineField[x, y].Flag = false;
                if (gameField.mineField[x, y].Mine == false)
                {
                    makeImage(x, y);
                    if (gameField.mineField[x, y].Number == 0)
                    {
                        checkSurrounding(x, y);
                    }
                    gameField.mineField[x, y].Open = true;
                }
                else
                {
                    makeImage(x, y);
                    sound.playBombSound();
                    gameStatus = false;
                }
            }
            checkGameStatus();
        }
        private void loadInfo()
        {
            gameTimer = new System.Timers.Timer();
            gameTimer.Elapsed += new ElapsedEventHandler(tick);
            gameTimer.Interval = 1000;
            gameTimer.Enabled = true;

            minesLeft = new Label
            {
                Location = new Point(rows * (tileSize) + 5, 10),
                Size = new System.Drawing.Size(100, 50),
                Image = MineSweeper.Resource1.minesleft
            };
            this.Controls.Add(minesLeft);

            minesLeftBox = new Label
            {
                Location = new Point(rows * (tileSize) + 100, 0),
                Size = new System.Drawing.Size(50, 50),
                Text = mines.ToString(),
                AutoSize = true,
                Font = new Font("Calibri", 40),
                ForeColor = Color.Green
            };
            this.Controls.Add(minesLeftBox);

            time = new Label
            {
                Location = new Point(rows * (tileSize) + 5, 80),
                Size = new System.Drawing.Size(100, 50),
                Image = MineSweeper.Resource1.time
            };
            this.Controls.Add(time);

            timeBox = new Label
            {
                Location = new Point(rows * (tileSize) + 100, 70),
                Size = new System.Drawing.Size(50, 50),
                Text = timer.ToString(),
                AutoSize = true,
                Font = new Font("Calibri", 40),
                ForeColor = Color.Green
            };
            this.Controls.Add(timeBox);

            back = new Button();
            back.SetBounds(rows * (tileSize), cols * (tileSize) - 50, 200, 50);
            back.Text = "Back";
            back.MouseClick += new MouseEventHandler(backClick);
            this.Controls.Add(back);
        }

        private void backClick(object sender, EventArgs e)
        {
            this.Close();
        }

        void tick(object sender, EventArgs e)
        {
            timer++;
            int currentTime = timer;
            timeBox.Text = currentTime.ToString();
        }
    }
}
