using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class HighScore : Form
    {

        public static List<Score> listBeginner = new List<Score>();
        public static List<Score> listIntermediate = new List<Score>();
        public static List<Score> listExpert = new List<Score>();


        public HighScore()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "High Score";
            loadBeginnerScores();
            loadIntermediateScores();
            loadExpertScores();
        }

        private void loadBeginnerScores()
        {
            listBeginner.Sort();
            if (listBeginner.Count >= 1)
            {
                timeB1.Text = listBeginner[0].time.ToString();
                NameB1.Text = listBeginner[0].name.ToString();
            }
            if (listBeginner.Count >= 2)
            {
                timeB2.Text = listBeginner[1].time.ToString();
                NameB2.Text = listBeginner[1].name.ToString();
            }
            if (listBeginner.Count >= 3)
            {
                timeB3.Text = listBeginner[2].time.ToString();
                NameB3.Text = listBeginner[2].name.ToString();
            }
        }

        private void loadIntermediateScores()
        {
            listIntermediate.Sort();
            if (listIntermediate.Count >= 1)
            {
                timeI1.Text = listIntermediate[0].time.ToString();
                NameI1.Text = listIntermediate[0].name.ToString();
            }
            if (listIntermediate.Count >= 2)
            {
                timeI2.Text = listIntermediate[1].time.ToString();
                NameI2.Text = listIntermediate[1].name.ToString();
            }
            if (listIntermediate.Count >= 3)
            {
                timeI3.Text = listIntermediate[2].time.ToString();
                NameI3.Text = listIntermediate[2].name.ToString();
            }
        }

        private void loadExpertScores()
        {
            listExpert.Sort();
            if (listExpert.Count >= 1)
            {
                timeB1.Text = listExpert[0].time.ToString();
                NameB1.Text = listExpert[0].name.ToString();
            }
            if (listExpert.Count >= 2)
            {
                timeB2.Text = listExpert[1].time.ToString();
                NameB2.Text = listExpert[1].name.ToString();
            }
            if (listExpert.Count >= 3)
            {
                timeB3.Text = listExpert[2].time.ToString();
                NameB3.Text = listExpert[2].name.ToString();
            }
        }

        private void backMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }

}
