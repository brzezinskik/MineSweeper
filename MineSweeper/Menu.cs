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
        public Menu()
        {
            InitializeComponent();
        }

        private void startClick(object sender, EventArgs e)
        {
            this.Hide();
            Game form2 = new Game(level);
            form2.Show();
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
