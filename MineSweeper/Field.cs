using System;

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
                    this.bombs = 8;
                    break;

                case 2:
                    this.rows = 12;
                    this.cols = 12;
                    this.bombs = 25;
                    break;

                case 3:
                    this.rows = 20;
                    this.cols = 15;
                    this.bombs = 80;
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
                if(mineField[i,j].Mine == false)
                {
                    mineField[i, j].Mine = true;
                    mineField[i, j].Number = -1;
                    bomb--;
                }               
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (mineField[i, j].Mine == false)
                    {
                        for (int k = i - 1; k <= i + 1; k++)
                            if ((k >= 0) && (k < rows))
                                for (int l = j - 1; l <= j + 1; l++)
                                    if ((l >= 0) && (l < cols) && mineField[k, l].Mine)
                                        mineField[i, j].Number++;
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
                    if (mineField[i, j].Open == true)
                        openFields++;
                }
            }
            if (openFields == rows * cols - bombs)
                return true;
            return false;
        }


      
    }
}
