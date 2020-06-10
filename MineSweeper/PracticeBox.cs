using System;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class PracticeBox : Form
    {
        int rows, columns, mines;
        private Game gameForm;

        private void rowsNum_ValueChanged(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rows = (int)rowsNum.Value;
            columns = (int)columnsNum.Value;
            mines = (int)minesNum.Value;
            Console.WriteLine(mines);
            if (mines > rows * columns / 3)
                mines = rows * columns / 3;
            gameForm = new Game(rows, columns, mines);
            gameForm.ShowDialog();
        }

        public PracticeBox()
        {
            InitializeComponent();
            this.Text = "Practice box";
        }


    }
}
