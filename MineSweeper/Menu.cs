using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class Menu : Form
    {
        int level = 1;
        private Game gameForm;
        private PracticeBox practiceBox;
        public Menu()
        {
            InitializeComponent();
            this.Text = "Minesweeper";
        }

        private void startClick(object sender, EventArgs e)
        {
            gameForm = new Game(level);
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
    }
}
