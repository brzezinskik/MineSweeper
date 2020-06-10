
namespace MineSweeper
{
    public class Cell
    {
        private bool mine;
        private bool flag = false;
        private bool open;
        private int number;
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
            set
            {
                number = value;
            }
        }

        public bool Flag
        {
            get
            {
                return flag;
            }
            set
            {
                flag = value;
            }
        }

        public bool Mine
        {
            get
            {
                return mine;
            }
            set
            {
                mine = value;
            }
        }

        public bool Open
        {
            get
            {
                return open;
            }
            set
            {
                open = value;
            }
        }

    }
}
