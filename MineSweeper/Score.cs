using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper
{
    public class Score : IEquatable<Score>, IComparable<Score>
    {
        public string name { get; set; }
        public int time { get; set; }

        public Score(string name, int time)
        {
            this.name = name;
            this.time = time;
        }

        public int CompareTo(Score other)
        {
            if (other == null)
                return 1;

            else
                return this.time.CompareTo(other.time);
        }

        public bool Equals(Score other)
        {
            if (other == null) return false;
            return (this.time.Equals(other.time));
        }
        public override int GetHashCode()
        {
            return time;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Score objAsScore = obj as Score;
            if (objAsScore == null) return false;
            else return Equals(objAsScore);
        }
        public int sort(int time1, int time2)
        {

            return time1.CompareTo(time2);
        }
    }
}
