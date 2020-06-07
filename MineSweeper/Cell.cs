using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper
{
    public class Cell
    {
        public bool mine;
        public bool flag = false;
        public bool open;
        public int number;
        public Cell()
        {
            flag = false;
            open = false;
            mine = false;
            number = 0;
        }
        public int Number
        {
            get
            {
                return number;
            }
        }

    }
}
