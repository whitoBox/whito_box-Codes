using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04KimYoHan
{
    class Grade
    {
        //static field
        //public static int MAX_GRADE_COUNT = 9;
        //privit static int MAX_GRADE_COUNT = 9;
        //const = const + static < c#에서는
        public static int MAX_GRADE_COUNT = 9;

        //instance field
        public string StudentNumber;
#if false
        public List<double> scores = new List<double>();

        public double Average()
        {
            if(this.scores.Count == 0)
            {
                return -1.0;
            }
            double sum = 0.0;
            foreach (var score in this.scores){
                sum += score;
            }
            return sum / scores.Count;
        }
#else
        private List<double> _scores = new List<double>();
        public int Count()
        {
            return _scores.Count;
        }
        public double Get(int i)
        {
            //i 값 검사 필요
            return _scores[i];
        }
        public double Average()
        {
            if (this._scores.Count == 0)
            {
                return -1.0;
            }
            return _scores.Average();
            return _scores.Sum() / _scores.Count();
            double sum = 0.0;
            foreach (var score in this._scores)
            {
                sum += score;
            }
            return sum / _scores.Count;
        }
        public void Clear()
        {
            _scores.Clear();
        }
        public bool Add(double score)
        {
            //if (_scores.Count >= MAX_GRADE_COUNT)
            //if (_scores.Count >= this.MAX_GRADE_COUNT)
            if (_scores.Count >= Grade.MAX_GRADE_COUNT)
                return false;
            _scores.Add(score);
            return true;
        }
#endif
        //instance method

    }
}
