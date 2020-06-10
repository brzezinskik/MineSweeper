using System;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class Menu : Form
    {
        int level = 1;
        private Game gameForm;
        private PracticeBox practiceBox;
        private HighScore highScoreBox;
        String name;
        public Menu()
        {
            InitializeComponent();
            difficulty.SelectedIndex = 0;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void startClick(object sender, EventArgs e)
        {
            name = nickName.Text;
            gameForm = new Game(level, name);
            gameForm.ShowDialog();
        }

        private void exitClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            practiceBox = new PracticeBox();
            practiceBox.ShowDialog();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (difficulty.Text == "Expert")
                level = 3;
            if (difficulty.Text == "Beginner")
                level = 1;
            if (difficulty.Text == "Intermiediate")
                level = 2;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.Text = "Minesweeper";
        }

        private void highScore_Click(object sender, EventArgs e)
        {
            highScoreBox = new HighScore();
            highScoreBox.ShowDialog();
        }
    }
}
