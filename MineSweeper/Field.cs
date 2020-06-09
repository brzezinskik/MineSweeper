using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper
{
    public class Field
    {
        Random rand;

        public int rows;
        public int cols;
        public int bombs;
        public Cell[,] mineField;

        public Field(int rows, int cols, int bombs)
        {
            mineField = new Cell[rows,cols];
            this.rows = rows;
            this.cols = cols;
            this.bombs = bombs;
            prep();
          
        }
        public Field(int difficulty)
        {
            switch (difficulty)
            {
                case 1:
                    this.rows = 8;
                    this.cols = 8;
                    this.bombs = 10;
                    break;

                case 2:
                    this.rows = 15;
                    this.cols = 15;
                    this.bombs = 30;
                    break;

                case 3:
                    this.rows = 25;
                    this.cols = 20;
                    this.bombs = 100;
                    break;
            }
            mineField = new Cell[rows, cols];
            prep();
        }
        public void prep()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    mineField[i, j] = new Cell();
                }
            }
            rand = new Random();
            int bomb = bombs;
            while (bomb > 0)
            {
                int i = rand.Next(rows);
                int j = rand.Next(cols);
                if(mineField[i,j].mine == false)
                {
                    mineField[i, j].mine = true;
                    mineField[i, j].number = -1;
                    bomb--;
                }               
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (mineField[i, j].mine == false)
                    {
                        for (int k = i - 1; k <= i + 1; k++)
                            if ((k >= 0) && (k < rows))
                                for (int l = j - 1; l <= j + 1; l++)
                                    if ((l >= 0) && (l < cols) && mineField[k, l].mine)
                                        mineField[i, j].number++;
                    }
                }
            }

        }

        public bool gameWon()
        {
            int openFields = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (mineField[i, j].open == true)
                        openFields++;
                }
            }
            if (openFields == rows * cols - bombs)
                return true;
            return false;
        }
    }
}
